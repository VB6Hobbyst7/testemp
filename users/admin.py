from django import forms
from django.db import models
from django.contrib import admin
from django.contrib.auth import get_user_model
from django.contrib.auth.forms import PasswordResetForm
from django.http import HttpRequest
from tinymce.widgets import TinyMCE
import json

from .models import AuditEntry, Designation, Employee, EmployeeAddress

from tasks.models import Task


User = get_user_model()


class EmployeeAdminForm(forms.ModelForm):
    class Meta:
        model = Employee
        widgets = {
          'language': forms.RadioSelect
        }
        fields = '__all__'


class TaskInline(admin.TabularInline):
    model = Task
    classes = ('collapse',)
    fields = ['task_code', 'task_detail', 'due_date', 'is_complete']


@admin.register(User)
class UserAdmin(admin.ModelAdmin):
    fieldsets = [
        ('Authentication', {'fields': ('username', 'password')}),
        ('Permissions', {'fields': ('groups', 'user_permissions')}),
        ('Status', {'fields': ('is_superuser', 'is_staff', 'is_active')}),
    ]
    list_display = ['username', 'is_superuser', 'is_staff', 'is_active']
    list_editable = ['is_superuser', 'is_staff', 'is_active']

    def get_queryset(self, request):
        qs = super(UserAdmin, self).get_queryset(request)
        return qs.filter(is_active=True)


@admin.register(Designation)
class DesignationAdmin(admin.ModelAdmin):
    pass


@admin.register(Employee)
class EmployeeAdmin(admin.ModelAdmin):
    def get_queryset(self, request):
        qs = super(EmployeeAdmin, self).get_queryset(request)
        return qs.filter(is_active=True)
    save_as = True
    exclude = ['user']
    form = EmployeeAdminForm
    formfield_overrides = {
        models.TextField: {'widget': TinyMCE()}
    }
    list_display = ['employee_code', 'last_name', 'first_name', 'email', 'designation_code', 'language', 'cv', 'is_active']
    list_display_links = ['employee_code', 'designation_code', 'language', 'cv']
    list_editable = ['last_name', 'first_name', 'email', 'is_active']
    list_filter = ['designation']
    inlines = [
        TaskInline,
    ]

    def designation_code(self, instance):
        return instance.designation.designation_code

    def cv(self, instance):
        return instance.employee_code + " CV"

    def save_model(self, request, obj, form, change):
        super().save_model(request, obj, form, change)
        form = PasswordResetForm({'email': obj.email})
        with open('static/json/emails.json', encoding='utf-8') as data_file:
            json_data = json.loads(data_file.read())
        context = {
            'banner_english': json_data['email_english']['banner'],
            'banner_french': json_data['email_french']['banner'],
            'body_english': json_data['email_english']['body'],
            'body_french': json_data['email_french']['body'],
            'button_english': json_data['email_english']['button'],
            'button_french': json_data['email_french']['button'],
            'user': obj,
        }
        if obj.language == 'EN':
            subject = 'registration/account_creation_subject_english.txt'
        else:
            subject = 'registration/account_creation_subject_french.txt'

        if form.is_valid() and not change:
            request = HttpRequest()
            request.META['SERVER_NAME'] = 'localhost:8000'
            request.META['SERVER_PORT'] = '80'
            form.save(
                subject_template_name=subject,
                request=request,
                from_email="postmaster@sandboxa0c46bd45ba14d5abd97c762464e8b49.mailgun.org",
                html_email_template_name='registration/account_creation_email.html',
                extra_email_context=context
            )


@admin.register(EmployeeAddress)
class EmployeeAddressAdmin(admin.ModelAdmin):
    list_display = ['address_line_1', 'address_line_2', 'city', 'state', 'zip_code']
    search_fields = ['city', 'state']


@admin.register(AuditEntry)
class AuditEntryAdmin(admin.ModelAdmin):
    list_display = ['action', 'username', 'ip']
    list_filter = ['action']
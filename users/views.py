from io import BytesIO

from datetime import date
from django.db import connection
from django.shortcuts import redirect, render, reverse
from django.contrib.auth import get_user_model
from django.contrib.auth.decorators import login_required
from django.contrib.auth.forms import SetPasswordForm
from django.contrib.auth.views import PasswordResetConfirmView
from django.core.mail import EmailMessage
from django.http import HttpResponse
from django_renderpdf.helpers import render_pdf
from django_renderpdf.views import PDFView
import csv
from rest_framework.generics import ListAPIView
from rest_framework.permissions import AllowAny
import xlsxwriter

from .forms import EmailCheckBoxForm
from .models import Employee
from .serializers import EmployeeSerializer
from tasks.models import Task


User = get_user_model()


def check_age(date_of_birth):
    today = date.today()
    return today.year - date_of_birth.year - ((today.month, today.day) < (date_of_birth.month, date_of_birth.day))


def download_csv(request):
    t_list = Task.objects.filter(employee=request.user.employee)

    output = BytesIO()

    workbook = xlsxwriter.Workbook(output)
    worksheet = workbook.add_worksheet()
    worksheet.set_column('A:A', 5)
    worksheet.set_column('B:B', 40)
    worksheet.set_column('D:XFD', None, None, {'hidden': True})
    worksheet.set_row(1, None, None, {'hidden': True})
    worksheet.set_row(2, None, None, {'hidden': True})
    worksheet.set_row(3, None, None, {'hidden': True})
    header = workbook.add_format({'bold': True, 'font_color': 'blue', 'font_size': '35',
                                  'border': False, 'top_color': '#FFF'})
    th = workbook.add_format({'bold': True, 'border': True, 'font_color': 'white', 'bg_color': 'blue'})
    th_blank = workbook.add_format({'bg_color': 'blue', 'top': True})
    th_blank_left = workbook.add_format({'bg_color': 'blue', 'top': True, 'left': True})
    th_blank_right = workbook.add_format({'bg_color': 'blue', 'top': True, 'right': True})
    td_desc = workbook.add_format({'locked': True})
    td_desc_gray = workbook.add_format({'bg_color': '#E3E3E3', 'locked': True})
    td_due_date = workbook.add_format({'border': True, 'locked': True})

    worksheet.write(0, 0, 'Daily Task List', header)
    worksheet.write(4, 0, '', th_blank_left)
    worksheet.write(4, 1, '', th_blank)
    worksheet.write(4, 2, '', th_blank_right)
    worksheet.write(5, 0, 'Done?', th)
    worksheet.write(5, 1, 'Task Description', th)
    worksheet.write(5, 2, 'Due Date', th)

    col = 0
    count = 1
    row = 6

    for t in t_list:
        if count % 2 != 0:
            worksheet.write(row, col, t.is_complete)
            worksheet.write(row, col + 1, t.task_detail, td_desc)
            worksheet.write(row, col + 2, 'NA', td_due_date)
        else:
            worksheet.write(row, col, t.is_complete)
            worksheet.write(row, col + 1, t.task_detail, td_desc_gray)
            worksheet.write(row, col + 2, 'NA', td_due_date)
        count += 1
        row += 1

    workbook.close()

    output.seek(0)

    filename = 'tasks.xlsx'
    response = HttpResponse(
        output,
        content_type='application/vnd.openxmlformats-officedocument.spreadsheetml.sheet'
    )
    response['Content-Disposition'] = 'attachment; filename=%s' % filename
    if request.method == "GET":
        form = EmailCheckBoxForm(request.GET)
        if form.is_valid():
            checkbox = form.cleaned_data['email_file_copy']
            if checkbox and check_age(request.user.employee.date_of_birth) > 18:
                message = EmailMessage("Your csv file", "You requested a task list csv file.",
                                       "postmaster@sandboxa0c46bd45ba14d5abd97c762464e8b49.mailgun.org",
                                       [request.user.email])
                message.attach('tasks.xlsx', response.getvalue(), 'text/csv')
                message.send()

    return response


def home(request):
    if request.user.is_authenticated:
        return redirect('users:profile')
    return render(request, 'home.html')


@login_required
def profile(request):
    context = {
        'form': EmailCheckBoxForm,
        'tasks': Task.objects.filter(employee=request.user.employee),
        'user': User.objects.get(username=request.user.username)
    }
    return render(request, 'users/profile.html', context)


class DownloadPDFView(PDFView):
    x = prompt_download = True
    template_name = 'users/task_list.html'
    print(x)

    @property
    def download_name(self) -> str:
        return 'tasks.pdf'

    def get(self, request, *args, **kwargs) -> HttpResponse:
        context = self.get_context_data(*args, **kwargs)
        response = self.render(
            request=request,
            template=self.get_template_names(),
            context=context,
        )
        if request.method == "GET":
            form = EmailCheckBoxForm(request.GET)
            if form.is_valid():
                checkbox = form.cleaned_data['email_file_copy']
                if checkbox and check_age(request.user.employee.date_of_birth) > 18:
                    message = EmailMessage("Your pdf file", "You request a task list pdf file.",
                                           "postmaster@sandboxa0c46bd45ba14d5abd97c762464e8b49.mailgun.org",
                                           [request.user.email])
                    message.attach('tasks.pdf', response.getvalue(), 'application/pdf')
                    message.send()
        return response

    def get_context_data(self, *args, **kwargs):
        context = super().get_context_data(*args, **kwargs)
        context['tasks'] = Task.objects.filter(employee=self.request.user.employee)
        return context


class SetPasswordView(PasswordResetConfirmView):
    form_class = SetPasswordForm
    template_name = 'registration/set_password.html'

    def get_success_url(self):
        return reverse('login')


def test(request):
    return render(request, 'test.html')


class TestEmployeeListAPIView(ListAPIView):
    permission_classes = (AllowAny, )
    serializer_class = EmployeeSerializer

    def get_queryset(self):
        queryset = Employee.objects.all()
        return queryset

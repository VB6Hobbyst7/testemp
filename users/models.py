from django.contrib.auth.models import AbstractUser
from django.contrib.auth.signals import user_logged_in, user_logged_out, user_login_failed
from django.db import models
from django.dispatch import receiver


class User(AbstractUser):
    def __str__(self):
        return self.first_name


class Designation(models.Model):
    designation_code = models.CharField(max_length=3)
    name = models.CharField(max_length=20)
    description = models.TextField(blank=True, null=True)

    def __str__(self):
        return self.name


class Employee(models.Model):
    LANGUAGE_CHOICES = (
        ('EN', 'English'),
        ('FR', 'French'),
    )

    employee_code = models.CharField(max_length=20, unique=True, blank=False)
    first_name = models.CharField(max_length=20)
    last_name = models.CharField(max_length=20)
    email = models.EmailField(unique=True)
    # phone_number = PhoneNumberField(unique=True, help_text='(e.g +999999999) 15 digits max.')
    date_of_birth = models.DateField()
    is_active = models.BooleanField(default=True, verbose_name='Active')
    designation = models.ForeignKey(Designation, on_delete=models.DO_NOTHING, related_name='designation', blank=True, null=True)
    user = models.OneToOneField(User, on_delete=models.CASCADE, blank=True, null=True, related_name='user')
    employee_address = models.ForeignKey("EmployeeAddress", on_delete=models.DO_NOTHING, blank=True, null=True,
                                         related_name='employee_address')
    language = models.CharField(
        max_length=5,
        choices=LANGUAGE_CHOICES,
        default=LANGUAGE_CHOICES[0],
        blank=False,
    )
    employee_cv = models.TextField(blank=True, null=True, verbose_name="CV")

    def __str__(self):
        return f'{self.first_name} {self.last_name}'


class EmployeeAddress(models.Model):
    address_line_1 = models.CharField(max_length=50)
    address_line_2 = models.CharField(max_length=50, help_text='Optional', blank=True)
    city = models.CharField(max_length=50)
    state = models.CharField(max_length=2)
    zip_code = models.IntegerField()

    class Meta:
        verbose_name_plural = 'Employee Addresses'

    def __str__(self):
        if not self.address_line_2:
            return f'{self.address_line_1}, {self.city}, {self.state} {self.zip_code}'
        else:
            return f'{self.address_line_1} {self.address_line_2}, {self.city}, {self.state} {self.zip_code}'
    


class AuditEntry(models.Model):
    action = models.CharField(max_length=64)
    ip = models.GenericIPAddressField(null=True)
    username = models.CharField(max_length=256, null=True)

    def __unicode__(self):
        return '{0} - {1} - {2}'.format(self.action, self.username, self.ip)

    def __str__(self):
        return '{0} - {1} - {2}'.format(self.action, self.username, self.ip)

    class Meta:
        verbose_name_plural = 'Audit Entries'


@receiver(user_logged_in)
def user_logged_in_callback(sender, request, user, **kwargs):
    ip = request.META.get('REMOTE_ADDR')
    AuditEntry.objects.create(action='user_logged_in', ip=ip, username=user.username)


@receiver(user_logged_out)
def user_logged_out_callback(sender, request, user, **kwargs):
    ip = request.META.get('REMOTE_ADDR')
    AuditEntry.objects.create(action='user_logged_out', ip=ip, username=user.username)


@receiver(user_login_failed)
def user_login_failed_callback(sender, credentials, **kwargs):
    AuditEntry.objects.create(action='user_login_failed', username=credentials.get('username', None))

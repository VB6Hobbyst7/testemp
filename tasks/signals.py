from django.contrib.auth import get_user_model
from django.db.models.signals import post_save
from django.dispatch import receiver

from .models import TaskList
from users.models import Employee


User = get_user_model()


@receiver(post_save, sender=Employee)
def create_task_list(sender, instance, created, **kwargs):
    if created:
        TaskList.objects.create(employee=instance)


@receiver(post_save, sender=Employee)
def save_task_list(sender, instance, **kwargs):
    instance.tasklist.save()
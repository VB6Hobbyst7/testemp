from django.contrib.auth import get_user_model
from django.db.models.signals import post_save
from django.dispatch import receiver

from .models import Employee


User = get_user_model()


@receiver(post_save, sender=Employee)
def create_user(sender, instance, created, **kwargs):
    if created:
        password = User.objects.make_random_password(
                    length=10,
                    allowed_chars='abcdefghjkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ123456789')
        user = User.objects.create(
                username=instance.employee_code,
                password=password,
                email=instance.email
            )
        instance.user = user
        instance.save()
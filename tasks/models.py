from django.db import models


class Task(models.Model):
    task_code = models.CharField(max_length=7)
    task_detail = models.CharField(max_length=100)
    due_date = models.DateField(auto_now_add=False)
    is_complete = models.BooleanField(default=False)
    employee = models.ForeignKey('users.Employee', on_delete=models.DO_NOTHING, blank=True, null=True)
    task_list = models.ForeignKey('TaskList', on_delete=models.DO_NOTHING, blank=True, null=True)

    def save(self, *args, **kwargs):
        self.task_list = TaskList.objects.get(employee=self.employee)
        super(Task, self).save(*args, **kwargs)

    def __str__(self):
        return self.task_detail


class TaskList(models.Model):
    employee = models.OneToOneField('users.Employee', on_delete=models.CASCADE)

    class Meta:
        verbose_name_plural = 'Task Lists'

    def __str__(self):
        return f"{self.employee}'s Task List"
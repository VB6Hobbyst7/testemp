from django.contrib import admin

from .models import Task, TaskList


class TaskInline(admin.TabularInline):
    model = Task
    fields = ['task_code', 'task_detail', 'is_complete']


@admin.register(Task)
class TaskAdmin(admin.ModelAdmin):
    fields = ['task_code', 'task_detail', 'is_complete', 'employee']
    list_display = ['task_code', 'task_detail', 'is_complete', 'due_date', 'employee']

    list_filter = ['is_complete', 'due_date', 'employee']


@admin.register(TaskList)
class TaskListAdmin(admin.ModelAdmin):
    inlines = [
        TaskInline,
    ]

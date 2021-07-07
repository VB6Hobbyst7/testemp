# Generated by Django 3.2.4 on 2021-06-29 02:53

from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='Task',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('task_code', models.CharField(max_length=7)),
                ('task_detail', models.CharField(max_length=100)),
                ('due_date', models.DateField()),
                ('is_complete', models.BooleanField(default=False)),
            ],
        ),
        migrations.CreateModel(
            name='TaskList',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
            ],
            options={
                'verbose_name_plural': 'Task Lists',
            },
        ),
    ]
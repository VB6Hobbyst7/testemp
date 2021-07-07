from django.contrib import admin
from django.urls import include, path
from django.contrib.auth.views import (
    LoginView,
    LogoutView,
    PasswordResetView,
    PasswordResetDoneView,
    PasswordResetConfirmView,
    PasswordResetCompleteView,
)
from django.conf import settings
from django.conf.urls.static import static

urlpatterns = [
    path('admin/', admin.site.urls),
    path('', include('users.urls', namespace="users")),
    path('accounts/login/', LoginView.as_view(template_name="users/login.html", redirect_authenticated_user=True), name="login"),
    path('accounts/logout/', LogoutView.as_view(template_name="users/logout.html"), name="logout"),
    path('accounts/password_reset/', PasswordResetView.as_view(), name="password_reset"),
    path('accounts/password_reset/done/', PasswordResetDoneView.as_view(), name="password_reset_done"),
    path('accounts/reset/<uidb64>/<token>/', PasswordResetConfirmView.as_view(), name="password_reset_confirm"),
    path('accounts/reset/done/', PasswordResetCompleteView.as_view(), name="password_reset_complete"),
]

if settings.DEBUG:
    urlpatterns += static(settings.STATIC_URL, document_root=settings.STATIC_ROOT)

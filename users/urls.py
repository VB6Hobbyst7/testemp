from django.urls import path

from .views import download_csv, home, profile, SetPasswordView, DownloadPDFView, test, TestEmployeeListAPIView


app_name = "users"


urlpatterns = [
    path('', home, name="test-home"),
    path('profile/', profile, name="profile"),
    path('download-csv/', download_csv, name="download-csv"),
    path('html-to-pdf/', DownloadPDFView.as_view(), name="download-pdf"),
    path('set-password/<uidb64>/<token>/', SetPasswordView.as_view(), name="set-password"),
    path('test/', test, name="test"),
    path('test/employees/api/', TestEmployeeListAPIView.as_view(), name="test-list"),
]
Public Class Proxy_Options_Description

    Private Sub Proxy_Options_Description_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        descriptionWebBrowser.Visible = True
        Dim descriptionString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\HTTP_GET_and_POST\Proxy_Options.html")
        descriptionWebBrowser.DocumentText = descriptionString
    End Sub
End Class

Public Class Proxy_Options_Sample_Code

    Private Sub Proxy_Options_Sample_Code_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        codeSampleWebBrowser.Visible = True
        Dim codeSampleString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Code_Samples\VbNet\WinForms\HTML_to_PDF\HTTP_GET_and_POST\Proxy_Options.html")
        codeSampleWebBrowser.DocumentText = codeSampleString
    End Sub
End Class

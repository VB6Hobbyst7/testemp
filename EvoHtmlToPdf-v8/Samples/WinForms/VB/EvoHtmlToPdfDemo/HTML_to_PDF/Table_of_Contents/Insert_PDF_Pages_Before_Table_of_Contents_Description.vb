Public Class Insert_PDF_Pages_Before_Table_of_Contents_Description

    Private Sub Insert_PDF_Pages_Before_Table_of_Contents_Description_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        descriptionWebBrowser.Visible = True
        Dim descriptionString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Table_of_Contents\Insert_PDF_Before.html")
        descriptionWebBrowser.DocumentText = descriptionString
    End Sub
End Class

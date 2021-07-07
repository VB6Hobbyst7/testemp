Public Class Merge_Table_of_Contents_Description

    Private Sub Merge_Table_of_Contents_Description_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        descriptionWebBrowser.Visible = True
        Dim descriptionString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Table_of_Contents\Multiple_HTML.html")
        descriptionWebBrowser.DocumentText = descriptionString
    End Sub
End Class

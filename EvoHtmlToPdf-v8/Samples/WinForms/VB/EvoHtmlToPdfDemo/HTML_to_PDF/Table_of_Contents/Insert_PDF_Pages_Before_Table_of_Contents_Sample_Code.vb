Public Class Insert_PDF_Pages_Before_Table_of_Contents_Sample_Code

    Private Sub Insert_PDF_Pages_Before_Table_of_Contents_Sample_Code_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        codeSampleWebBrowser.Visible = True
        Dim codeSampleString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Code_Samples\VbNet\WinForms\HTML_to_PDF\Table_of_Contents\Insert_PDF_Before.html")
        codeSampleWebBrowser.DocumentText = codeSampleString
    End Sub
End Class

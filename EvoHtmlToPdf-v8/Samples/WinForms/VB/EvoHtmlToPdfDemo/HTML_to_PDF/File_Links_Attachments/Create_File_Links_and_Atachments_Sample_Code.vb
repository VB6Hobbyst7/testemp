Imports System.ComponentModel
Imports System.Text

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.File_Links_Attachments
	Partial Public Class Create_File_Links_and_Atachments_Sample_Code
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Create_File_Links_and_Atachments_Sample_Code_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			codeSampleWebBrowser.Visible = True
			Dim codeSampleString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Code_Samples\VbNet\WinForms\HTML_to_PDF\Links_Attach\Create_Links_Atach.html")
			codeSampleWebBrowser.DocumentText = codeSampleString
		End Sub
	End Class
End Namespace

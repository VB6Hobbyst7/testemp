Imports System.ComponentModel
Imports System.Text

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions
	Partial Public Class Execute_JavaScript_Button_Clicked_Description
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Execute_JavaScript_Button_Clicked_Description_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			descriptionWebBrowser.Visible = True
			Dim descriptionString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\PDF_Actions\Execute_JavaScript_Button.html")
			descriptionWebBrowser.DocumentText = descriptionString
		End Sub
	End Class
End Namespace

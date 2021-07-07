Imports System.ComponentModel
Imports System.Text

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks
	Partial Public Class Select_in_API_HTML_Elements_to_Bookmark_Description
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Select_in_API_HTML_Elements_to_Bookmark_Description_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			descriptionWebBrowser.Visible = True
			Dim descriptionString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Bookmarks\Select_in_API.html")
			descriptionWebBrowser.DocumentText = descriptionString
		End Sub
	End Class
End Namespace

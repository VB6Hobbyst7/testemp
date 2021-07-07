Imports System.ComponentModel

Imports System.Text

Namespace EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences
	Partial Public Class Set_Viewer_Preferences_Sample_Code
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Set_Viewer_Preferences_Sample_Code_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			codeSampleWebBrowser.Visible = True
			Dim codeSampleString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Code_Samples\VbNet\WinForms\PDF_Creator\PDF_Viewer\Set_Viewer_Preferences.html")
			codeSampleWebBrowser.DocumentText = codeSampleString
		End Sub
	End Class
End Namespace

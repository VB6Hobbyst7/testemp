Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Editor
	Partial Public Class Merge_PDF_Demo
		Inherits UserControl
		Private Sub mergePdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mergePdfButton.Click
			' Create the merge result PDF document
			Dim mergeResultPdfDocument As New Document()

			' Automatically close the merged documents when the document resulted after merge is closed
			mergeResultPdfDocument.AutoCloseAppendedDocs = True

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			mergeResultPdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			Cursor = Cursors.WaitCursor
			Dim outPdfFile As String = "DemoAppFiles\Output\PDF_Editor\Merge_PDF.pdf"
			Try
				' The documents to merge must remain opened until the PDF document resulted after merge is saved
				' The merged documents can be automatically closed when the document resulted after merge is closed
				' if the AutoCloseAppendedDocs property of the PDF document resulted after merge is set on true like
				' in this demo applcation

				' Load the first PDF document to merge
				Dim firstPdfDocumentToMerge As New Document(firstPdfFilePathTextBox.Text)
				' Merge the first PDF document
				mergeResultPdfDocument.AppendDocument(firstPdfDocumentToMerge)

				' Load the second PDF document to merge
				Dim secondPdfDocumentToMerge As New Document(secondPdfFilePathTextBox.Text)
				' Merge the second PDF document
				mergeResultPdfDocument.AppendDocument(secondPdfDocumentToMerge)

				' Save the merge result PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = mergeResultPdfDocument.Save()

				' Write the memory buffer in a PDF file
				System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
			Catch ex As Exception
				' The PDF creation failed
				MessageBox.Show(String.Format("Create PDF Document Error. {0}", ex.Message))
				Return
			Finally
				' Close the PDF document resulted after merge
				' When the AutoCloseAppendedDocs property is true the merged PDF documents will also be closed
				mergeResultPdfDocument.Close()

				Cursor = Cursors.Arrow
			End Try

			' Open the created PDF document in default PDF viewer
			Try
				Process.Start(outPdfFile)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
			End Try
		End Sub

		Private Sub Merge_PDF_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			firstPdfFilePathTextBox.Text = System.IO.Path.Combine(Application.StartupPath, "DemoAppFiles\Input\PDF_Files\Merge_Before_Conversion.pdf")
			secondPdfFilePathTextBox.Text = System.IO.Path.Combine(Application.StartupPath, "DemoAppFiles\Input\PDF_Files\Merge_After_Conversion.pdf")
		End Sub

		Private Sub selectFirstPdfFileButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles selectFirstPdfFileButton.Click
			Dim fd As New OpenFileDialog()
			fd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
			If fd.ShowDialog() = DialogResult.OK Then
				firstPdfFilePathTextBox.Text = fd.FileName
			End If
		End Sub

		Private Sub selectSecondPdfFileButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles selectSecondPdfFileButton.Click
			Dim fd As New OpenFileDialog()
			fd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
			If fd.ShowDialog() = DialogResult.OK Then
				secondPdfFilePathTextBox.Text = fd.FileName
			End If
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace

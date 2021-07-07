Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Editor
	Partial Public Class Split_PDF_Demo
		Inherits UserControl
		Private splitResultPdfFile1 As String = "DemoAppFiles\Output\PDF_Editor\Split_PDF_1.pdf"
		Private splitResultPdfFile2 As String = "DemoAppFiles\Output\PDF_Editor\Split_PDF_2.pdf"

		Private Sub splitPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles splitPdfButton.Click
			Cursor = Cursors.WaitCursor

			splitResultPanel.Visible = False

			Dim pdfDocumentToSplit As Document = Nothing
			Dim splitResultDocument1 As Document = Nothing
			Dim splitResultDocument2 As Document = Nothing
			Try
				' Load the PDF document to split
				' The document must remain opened until the PDF documents resulted after split are saved
				pdfDocumentToSplit = New Document(pdfFilePathTextBox.Text)

				' Get the page count of the document to split
				Dim pageCount As Integer = pdfDocumentToSplit.Pages.Count

				' Check if the document has the minimum required number of page
				If pageCount < 2 Then
					MessageBox.Show("The document to split must have at least 2 pages")
					Return
				End If

				' Create the first PDF document resulted after split
				splitResultDocument1 = New Document()
				' Set license key received after purchase
				splitResultDocument1.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="
				' Copy pages from loaded document into split result document
				splitResultDocument1.AppendDocument(pdfDocumentToSplit, 0, pageCount \ 2)
				' Save the first PDF document document resulted after split in a memory buffer
				Dim outPdfBuffer1() As Byte = splitResultDocument1.Save()
				' Write the memory buffer in a PDF file
				System.IO.File.WriteAllBytes(splitResultPdfFile1, outPdfBuffer1)

				' Create the second PDF document resulted after split  
				splitResultDocument2 = New Document()
				' Set license key received after purchase
				splitResultDocument2.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="
				' Copy pages from loaded document into split result document
				splitResultDocument2.AppendDocument(pdfDocumentToSplit, pageCount \ 2, pageCount - pageCount \ 2)
				' Save the second PDF document document resulted after split in a memory buffer
				Dim outPdfBuffer2() As Byte = splitResultDocument2.Save()
				' Write the memory buffer in a PDF file
				System.IO.File.WriteAllBytes(splitResultPdfFile2, outPdfBuffer2)

				splitResultPanel.Visible = True
			Catch ex As Exception
				' The PDF split failed
				MessageBox.Show(String.Format("Split PDF Error. {0}", ex.Message))
				Return
			Finally
				' Close all the PDF documents after the PDF documents resulted after split were already saved

				' Close the first split result document
				If splitResultDocument1 IsNot Nothing Then
					splitResultDocument1.Close()
				End If

				' Close the second split result document
				If splitResultDocument2 IsNot Nothing Then
					splitResultDocument2.Close()
				End If

				' Close the document to split
				If pdfDocumentToSplit IsNot Nothing Then
					pdfDocumentToSplit.Close()
				End If

				Cursor = Cursors.Arrow
			End Try
		End Sub

		Private Sub Split_PDF_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pdfFilePathTextBox.Text = System.IO.Path.Combine(Application.StartupPath, "DemoAppFiles\Input\PDF_Files\PDF_Document.pdf")
		End Sub

		Private Sub selectFileButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles selectFileButton.Click
			Dim fd As New OpenFileDialog()
			fd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
			If fd.ShowDialog() = DialogResult.OK Then
				pdfFilePathTextBox.Text = fd.FileName
			End If
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub openFirstLinkLabel_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles openFirstLinkLabel.LinkClicked
			Try
				Process.Start(splitResultPdfFile1)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", splitResultPdfFile1, ex.Message))
			End Try
		End Sub

		Private Sub openSecondLinkLabel_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles openSecondLinkLabel.LinkClicked
			Try
				Process.Start(splitResultPdfFile2)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", splitResultPdfFile2, ex.Message))
			End Try
		End Sub

		Private Sub openInitialLinkLabel_LinkClicked_1(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles openInitialLinkLabel.LinkClicked
			Try
				Process.Start(pdfFilePathTextBox.Text)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open initial PDF file '{0}'. {1}", pdfFilePathTextBox.Text, ex.Message))
			End Try
		End Sub
	End Class
End Namespace

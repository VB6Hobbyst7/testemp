Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Editor
	Partial Public Class Fill_PDF_Forms_Demo
		Inherits UserControl
		' The PDF document with a form to fill
		Private pdfFileWithForm As String = "DemoAppFiles\Input\PDF_Files\Fill_PDF_Forms.pdf"

		Private Sub fillPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles fillPdfButton.Click
			Cursor = Cursors.WaitCursor

			Dim outPdfFile As String = "DemoAppFiles\Output\PDF_Editor\Filled_PDF_Form.pdf"
			Dim pdfDocument As Document = Nothing
			Try
				' Load the PDF document with a form to fill
				pdfDocument = New Document(pdfFileWithForm)

				' Set license key received after purchase to use the converter in licensed mode
				' Leave it not set to use the converter in demo mode
				pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

				' Get the First Name text box field by name from PDF form fields collection and fill a text value
				Dim firstNameTextBoxField As PdfFormField = pdfDocument.Form.Fields("firstName")
				If firstNameTextBoxField IsNot Nothing Then
					firstNameTextBoxField.Value = firstNameTextBox.Text
				End If

				' Get the Last Name text box field by name from PDF form fields collection and fill a text value
				Dim lastNameTextBoxField As PdfFormField = pdfDocument.Form.Fields("lastName")
				If lastNameTextBoxField IsNot Nothing Then
					lastNameTextBoxField.Value = lastNameTextBox.Text
				End If

				' Get the Password text box field by name from PDF form fields collection and fill a text value
				Dim passwordTextBoxField As PdfFormField = pdfDocument.Form.Fields("password")
				If passwordTextBoxField IsNot Nothing Then
					passwordTextBoxField.Value = passwordTextBox.Text
				End If

				' Get the Gender radio buttons group field by name from form fields collection and set the selected value
				Dim genderRadioGroupField As PdfFormField = pdfDocument.Form.Fields("gender")
				If genderRadioGroupField IsNot Nothing Then
					genderRadioGroupField.Value = If(maleRadioButton.Checked, "male", "female")
				End If

				' Get the 'I have a car' check box field by name from form fields collection and set the checked status
				Dim haveCarCheckBoxField As PdfFormField = pdfDocument.Form.Fields("haveCar")
				If haveCarCheckBoxField IsNot Nothing Then
					haveCarCheckBoxField.Value = haveCarCheckBox.Checked
				End If

				' Get the 'Vehicle Type' combo box field by name from form fields collection and set the selected value
				Dim vehicleTypeComboBoxField As PdfFormField = pdfDocument.Form.Fields("vehicleType")
				If vehicleTypeComboBoxField IsNot Nothing Then
					vehicleTypeComboBoxField.Value = carTypeComboBox.SelectedItem
				End If

				' Get the Comments multi line text box field by name from PDF form fields collection and fill a text value
				Dim commentsTextBoxField As PdfFormField = pdfDocument.Form.Fields("comments")
				If commentsTextBoxField IsNot Nothing Then
					commentsTextBoxField.Value = commentsTextBox.Text
				End If

				' Flatten PDF form fields if this was requested
				If flattenPdfFormCheckBox.Checked Then
					pdfDocument.Form.FlattenFields()
				End If

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Write the memory buffer in a PDF file
				System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
			Catch ex As Exception
				' The PDF creation failed
				MessageBox.Show(String.Format("Create PDF Document Error. {0}", ex.Message))
				Return
			Finally
				' Close the document to stamp
				If pdfDocument IsNot Nothing Then
					pdfDocument.Close()
				End If

				Cursor = Cursors.Arrow
			End Try

			' Open the created PDF document in default PDF viewer
			Try
				Process.Start(outPdfFile)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
			End Try
		End Sub

		Private Sub openInitialLinkLabel_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles openInitialLinkLabel.LinkClicked
			Try
				Process.Start(pdfFileWithForm)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", pdfFileWithForm, ex.Message))
			End Try
		End Sub

		Private Sub Fill_PDF_Forms_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			carTypeComboBox.SelectedItem = "Volvo"
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace

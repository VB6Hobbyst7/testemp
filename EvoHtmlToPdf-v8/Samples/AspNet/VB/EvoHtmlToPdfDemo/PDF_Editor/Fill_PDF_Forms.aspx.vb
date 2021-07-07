Imports System.Web.UI
Imports System.Web.UI.WebControls

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Editor
	Partial Public Class Fill_PDF_Forms
		Inherits System.Web.UI.Page
		Protected Sub fillPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim pdfDocument As Document = Nothing
			Try
				' Load the PDF document with a form to fill
				Dim pdfFileWithForm As String = Server.MapPath("~/DemoAppFiles/Input/PDF_Files/Fill_PDF_Forms.pdf")
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
					vehicleTypeComboBoxField.Value = carTypeComboBox.SelectedValue
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

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Filled_PDF_Form.pdf.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' Close the document to stamp
				If pdfDocument IsNot Nothing Then
					pdfDocument.Close()
				End If
			End Try
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				carTypeComboBox.SelectedValue = "Volvo"

				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Editor/Fill_PDF_Forms.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Editor/Fill_PDF_Forms.html"))

				Dim currentPageUrl As String = HttpContext.Current.Request.Url.AbsoluteUri
				Dim rootUrl As String = currentPageUrl.Substring(0, currentPageUrl.LastIndexOf("/"c)) & "/../"

				pdfFileToFillHyperLink.NavigateUrl = rootUrl & "DemoAppFiles/Input/PDF_Files/Fill_PDF_Forms.pdf"

				Master.CollapseAll()
				Master.ExpandNode("PDF_Editor")
				Master.SelectNode("Fill_PDF_Forms")
			End If
		End Sub

		Protected Sub demoMenu_MenuItemClick(ByVal sender As Object, ByVal e As MenuEventArgs)
			Select Case e.Item.Value
				Case "Live_Demo"
					demoMultiView.SetActiveView(liveDemoView)
				Case "Description"
					demoMultiView.SetActiveView(descriptionView)
				Case "Sample_Code"
					demoMultiView.SetActiveView(sampleCodeView)
				Case Else
			End Select
		End Sub
	End Class
End Namespace
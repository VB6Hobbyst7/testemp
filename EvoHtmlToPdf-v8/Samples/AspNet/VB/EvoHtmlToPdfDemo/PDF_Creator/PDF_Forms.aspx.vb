Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class PDF_Forms
		Inherits System.Web.UI.Page
		Protected Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

			Try
				' The font used for titles in PDF document
				Dim titlesFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 10, FontStyle.Bold, GraphicsUnit.Point))
				' The font used for field names in PDF document
				Dim fieldNameFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 10, FontStyle.Regular, GraphicsUnit.Point))
				' The font used for buttons text in PDF document
				Dim buttonTextFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 10, FontStyle.Regular, GraphicsUnit.Point))
				' The font used for PDF form text box fields
				Dim textFieldFont As PdfFont = pdfDocument.AddFont(StdFontBaseFamily.Helvetica)
				textFieldFont.Size = 8
				' The font used for PDF form combo box fields
				Dim comboBoxFieldFont As PdfFont = pdfDocument.AddFont(StdFontBaseFamily.Helvetica)
				comboBoxFieldFont.Size = 8

				Dim xLocation As Single = 5
				Dim yLocation As Single = 5

				' Add document title
				Dim titleTextElement As New TextElement(xLocation, yLocation, "Create PDF Forms", titlesFont)
				Dim addElementResult As AddElementResult = pdfPage.AddElement(titleTextElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 15

				' Add a text box field to PDF form
				Dim fieldNameTextElement As New TextElement(xLocation, yLocation, 60, "First name:", fieldNameFont)
				addElementResult = pdfPage.AddElement(fieldNameTextElement)
				Dim fieldNameRectangle As RectangleF = addElementResult.EndPageBounds
				Dim fieldBoundingRectangle As New RectangleF(fieldNameRectangle.Right + 10, yLocation, 150, 15)
				' Create the form field
				Dim textBoxField As PdfFormTextBox = pdfDocument.Form.AddTextBox(pdfPage, fieldBoundingRectangle, "Enter First Name", textFieldFont)
				' Set unique form field name used when the form is submitted
				textBoxField.Name = "firstName"
				' Set the form field default value
				textBoxField.DefaultValue = "A default first name"
				' Set form field style 
				textBoxField.Style.BackColor = Color.AliceBlue

				yLocation = fieldNameRectangle.Bottom + 10

				' Add a text box field to PDF form
				fieldNameTextElement = New TextElement(xLocation, yLocation, 60, "Last name:", fieldNameFont)
				addElementResult = pdfPage.AddElement(fieldNameTextElement)
				fieldNameRectangle = addElementResult.EndPageBounds
				fieldBoundingRectangle = New RectangleF(fieldNameRectangle.Right + 10, yLocation, 150, 15)
				' Create the form field
				textBoxField = pdfDocument.Form.AddTextBox(pdfPage, fieldBoundingRectangle, "Enter Last Name", textFieldFont)
				' Set unique form field name used when the form is submitted
				textBoxField.Name = "lastName"
				' Set the form field default value
				textBoxField.DefaultValue = "A default last name"
				' Set form field style 
				textBoxField.Style.BackColor = Color.MistyRose

				yLocation = fieldNameRectangle.Bottom + 10

				' Add a password text box field to PDF form
				fieldNameTextElement = New TextElement(xLocation, yLocation, 60, "Password:", fieldNameFont)
				addElementResult = pdfPage.AddElement(fieldNameTextElement)
				fieldNameRectangle = addElementResult.EndPageBounds
				fieldBoundingRectangle = New RectangleF(fieldNameRectangle.Right + 10, yLocation, 150, 15)
				' Create the form field
				Dim passwordTextBoxField As PdfFormTextBox = pdfDocument.Form.AddTextBox(pdfPage, fieldBoundingRectangle, "", textFieldFont)
				' Set unique form field name used when the form is submitted
				passwordTextBoxField.Name = "password"
				' Set form field style 
				passwordTextBoxField.Style.BackColor = Color.AliceBlue
				' Set the password mode for the text box
				passwordTextBoxField.IsPassword = True

				yLocation = fieldNameRectangle.Bottom + 10

				' Add a radio buttons group to PDF form
				fieldNameTextElement = New TextElement(xLocation, yLocation, 60, "Gender:", fieldNameFont)
				addElementResult = pdfPage.AddElement(fieldNameTextElement)
				fieldNameRectangle = addElementResult.EndPageBounds
				' Create the radio buttons group
				Dim radioButtonsGroup As PdfFormRadioButtonsGroup = pdfDocument.Form.AddRadioButtonsGroup(pdfPage)
				' Set unique form field name used when the form is submitted
				radioButtonsGroup.Name = "gender"
				' Set style of the radio buttons in this group
				radioButtonsGroup.Style.BackColor = Color.AntiqueWhite

				' Add the first radio button to group
				Dim radioButtonRectangle As New RectangleF(fieldNameRectangle.Right + 10, yLocation, 50, 10)
				' Create the form field
				Dim radioButtonField As PdfFormRadioButton = radioButtonsGroup.AddRadioButton(radioButtonRectangle, "male", pdfPage)

				fieldNameTextElement = New TextElement(fieldNameRectangle.Right + 22, yLocation, 30, "Male", fieldNameFont)
				pdfPage.AddElement(fieldNameTextElement)

				' Add the second radio button to group
				radioButtonRectangle = New RectangleF(fieldNameRectangle.Right + 60, yLocation, 50, 10)
				' Create the form field
				radioButtonField = radioButtonsGroup.AddRadioButton(radioButtonRectangle, "female", pdfPage)

				fieldNameTextElement = New TextElement(fieldNameRectangle.Right + 72, yLocation, 30, "Female", fieldNameFont)
				pdfPage.AddElement(fieldNameTextElement)

				' Set the selected radio btton in group
				radioButtonsGroup.SetCheckedRadioButton("male")

				yLocation = fieldNameRectangle.Bottom + 10

				' Add a checkbox field to PDF form
				fieldNameTextElement = New TextElement(xLocation, yLocation, 60, "Vehicle:", fieldNameFont)
				addElementResult = pdfPage.AddElement(fieldNameTextElement)
				fieldNameRectangle = addElementResult.EndPageBounds
				fieldBoundingRectangle = New RectangleF(fieldNameRectangle.Right + 10, yLocation, 10, 10)
				' Create the form field
				Dim checkBoxField As PdfFormCheckBox = pdfDocument.Form.AddCheckBox(pdfPage, fieldBoundingRectangle)
				' Set unique form field name used when the form is submitted
				checkBoxField.Name = "haveCar"
				' Set form field style 
				checkBoxField.Style.BackColor = Color.AntiqueWhite
				' Set checkbox field checked state
				checkBoxField.Checked = True

				fieldNameTextElement = New TextElement(fieldNameRectangle.Right + 22, yLocation, 50, "I have a car", fieldNameFont)
				pdfPage.AddElement(fieldNameTextElement)

				yLocation = fieldNameRectangle.Bottom + 10

				' Add a combo box list field to PDF form
				fieldNameTextElement = New TextElement(xLocation, yLocation, 60, "Vehicle Type:", fieldNameFont)
				addElementResult = pdfPage.AddElement(fieldNameTextElement)
				fieldNameRectangle = addElementResult.EndPageBounds
				fieldBoundingRectangle = New RectangleF(fieldNameRectangle.Right + 10, yLocation, 50, 15)
				Dim comboBoxItems() As String = { "Volvo", "Saab", "Audi", "Opel" }
				' Create the form field
				Dim comboBoxField As PdfFormComboBox = pdfDocument.Form.AddComboBox(pdfPage, fieldBoundingRectangle, comboBoxItems, comboBoxFieldFont)
				' Set unique form field name used when the form is submitted
				comboBoxField.Name = "vehicleType"
				' Set the form field default value
				comboBoxField.DefaultValue = "Audi"
				' Set form field style 
				comboBoxField.Style.BackColor = Color.LightCyan
				' Set selected item in combo box
				comboBoxField.Value = "Audi"

				yLocation = fieldNameRectangle.Bottom + 10

				' Add a multiline text box field to PDF form
				fieldNameTextElement = New TextElement(xLocation, yLocation + 20, 60, "Comments:", fieldNameFont)
				addElementResult = pdfPage.AddElement(fieldNameTextElement)
				fieldNameRectangle = addElementResult.EndPageBounds
				fieldBoundingRectangle = New RectangleF(fieldNameRectangle.Right + 10, yLocation, 150, 60)
				' Create the form field
				Dim multilineTextBoxField As PdfFormTextBox = pdfDocument.Form.AddTextBox(pdfPage, fieldBoundingRectangle, "Enter your comments here:" & vbCrLf & "First comment line" & vbCrLf & "Second comment line", textFieldFont)
				' Set unique form field name used when the form is submitted
				multilineTextBoxField.Name = "comments"
				' Set form field style 
				multilineTextBoxField.Style.BackColor = Color.AliceBlue
				' Set the multiline mode for text box field
				multilineTextBoxField.IsMultiLine = True

				yLocation = yLocation + 70

				' Add a form submit button to PDF form
				fieldBoundingRectangle = New RectangleF(xLocation, yLocation, 75, 15)
				Dim submitFormButton As PdfFormButton = pdfDocument.Form.AddButton(pdfPage, fieldBoundingRectangle, "Submit", buttonTextFont)
				' Set unique form field name used when the form is submitted
				submitFormButton.Name = "submitFormButton"
				' Set form field style 
				submitFormButton.Style.BackColor = Color.Beige
				' Create the form submit action
				Dim submitFormAction As New PdfSubmitFormAction(submitUrlTextBox.Text)
				' Form values will be submitted in HTML form format
				submitFormAction.Flags = submitFormAction.Flags Or PdfFormSubmitFlags.ExportFormat
				If getMethodRadioButton.Checked Then
					submitFormAction.Flags = submitFormAction.Flags Or PdfFormSubmitFlags.GetMethod
				End If
				' Set the form submit button action
				submitFormButton.Action = submitFormAction

				' Add a form reset button to PDF form
				fieldBoundingRectangle = New RectangleF(xLocation + 100, yLocation, 75, 15)
				Dim resetFormButton As PdfFormButton = pdfDocument.Form.AddButton(pdfPage, fieldBoundingRectangle, "Reset", buttonTextFont)
				' Set unique form field name used when the form is submitted
				resetFormButton.Name = "resetFormButton"
				' Set form field style 
				resetFormButton.Style.BackColor = Color.Beige
				' Create the form reset action
				Dim resetFormAction As New PdfResetFormAction()
				' Set the form reset button action
				resetFormButton.Action = resetFormAction

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Create_PDF_Forms.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' Close the PDF document
				pdfDocument.Close()
			End Try
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Creator/PDF_Forms.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Creator/PDF_Forms.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Creator")
				Master.SelectNode("Create_PDF_Forms")
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
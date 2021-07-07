Imports System.Web.UI
Imports System.Web.UI.WebControls

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator.PDF_Security
	Partial Public Class PDF_Permissions_and_Password
		Inherits System.Web.UI.Page
		Protected Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a page to PDF document
            Dim pdfPage As PdfPage = pdfDocument.AddPage()

            ' Set the encryption algorithm and the encryption key size if they are not the default ones
            If (Not bit128RadioButton.Checked Or Not rc4RadioButton.Checked) Then
                ' set the encryption algorithm
                If (rc4RadioButton.Checked) Then
                    pdfDocument.Security.EncryptionAlgorithm = EncryptionAlgorithm.RC4
                Else
                    pdfDocument.Security.EncryptionAlgorithm = EncryptionAlgorithm.AES
                End If

                ' set the encryption key size
                If (bit40RadioButton.Checked) Then
                    pdfDocument.Security.KeySize = EncryptionKeySize.EncryptKey40Bit
                ElseIf (bit128RadioButton.Checked) Then
                    pdfDocument.Security.KeySize = EncryptionKeySize.EncryptKey128Bit
                ElseIf (bit256RadioButton.Checked) Then
                    pdfDocument.Security.KeySize = EncryptionKeySize.EncryptKey256Bit
                End If
            End If

			' Set user and owner passwords
			If userPasswordTextBox.Text.Length > 0 Then
				pdfDocument.Security.UserPassword = userPasswordTextBox.Text
			End If

			If ownerPasswordTextBox.Text.Length > 0 Then
				pdfDocument.Security.OwnerPassword = ownerPasswordTextBox.Text
			End If

            ' Set PDF document permissions
            pdfDocument.Security.CanPrint = printEnabledCheckBox.Checked
            pdfDocument.Security.CanPrintHighResolution = highResolutionPrintEnabledCheckBox.Checked
            pdfDocument.Security.CanCopyContent = copyContentEnabledCheckBox.Checked
            pdfDocument.Security.CanCopyAccessibilityContent = copyAccessibilityContentEnabledCheckBox.Checked
            pdfDocument.Security.CanEditContent = editContentEnabledCheckBox.Checked
            pdfDocument.Security.CanEditAnnotations = editAnnotationsEnabledCheckBox.Checked
            pdfDocument.Security.CanFillFormFields = fillFormFieldsEnabledCheckBox.Checked

            If ((PermissionsChanged(pdfDocument) Or pdfDocument.Security.UserPassword.Length > 0) And
                pdfDocument.Security.OwnerPassword.Length = 0) Then
                ' A user password is set but the owner password is not set or the permissions are not the default ones
                ' Set a default owner password
                pdfDocument.Security.OwnerPassword = "owner"
            End If

			Try
				' Create a HTML to PDF element to add to document
				Dim htmlToPdfElement As New HtmlToPdfElement(urlTextBox.Text)

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				htmlToPdfElement.ConversionDelay = 2

				' Add the HTML to PDF element to document
				pdfPage.AddElement(htmlToPdfElement)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Set_Permissions_Password.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' Close the PDF document
				pdfDocument.Close()
			End Try
        End Sub

        Private Function PermissionsChanged(ByVal pdfDocument As Document) As Boolean
            Return Not pdfDocument.Security.CanPrint Or Not pdfDocument.Security.CanPrintHighResolution Or
                    Not pdfDocument.Security.CanCopyContent Or Not pdfDocument.Security.CanCopyAccessibilityContent Or
                    Not pdfDocument.Security.CanEditContent Or Not pdfDocument.Security.CanEditAnnotations Or
                    Not pdfDocument.Security.CanFillFormFields
        End Function

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Creator/PDF_Security/PDF_Permissions.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Creator/PDF_Security/PDF_Permissions.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Creator")
				Master.ExpandNode("PDF_Creator_PDF_Security")
				Master.SelectNode("PDF_Creator_PDF_Permissions_and_Password")
			End If
		End Sub

		Protected Sub editContentEnabledCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If editContentEnabledCheckBox.Checked Then
				fillFormFieldsEnabledCheckBox.Checked = True
			End If
		End Sub

		Protected Sub editAnnotationsEnabledCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If editAnnotationsEnabledCheckBox.Checked Then
				fillFormFieldsEnabledCheckBox.Checked = True
			End If
		End Sub

		Protected Sub fillFormFieldsEnabledCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Not fillFormFieldsEnabledCheckBox.Checked Then
				editContentEnabledCheckBox.Checked = False
				editAnnotationsEnabledCheckBox.Checked = False
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

        Protected Sub rc4RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rc4RadioButton.CheckedChanged
            If (rc4RadioButton.Checked) Then
                ' RC4 does not support the 256-bit encryption key size
                bit256RadioButton.Enabled = False
                bit40RadioButton.Enabled = True
            Else
                ' AES does not support the 40-bit encryption key size
                bit256RadioButton.Enabled = True
                bit40RadioButton.Enabled = False
            End If

            bit128RadioButton.Checked = True
            bit40RadioButton.Checked = False
            bit256RadioButton.Checked = False
        End Sub

        Protected Sub aesRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles aesRadioButton.CheckedChanged
            If (rc4RadioButton.Checked) Then
                ' RC4 does not support the 256-bit encryption key size
                bit256RadioButton.Enabled = False
                bit40RadioButton.Enabled = True
            Else
                ' AES does not support the 40-bit encryption key size
                bit256RadioButton.Enabled = True
                bit40RadioButton.Enabled = False
            End If

            bit128RadioButton.Checked = True
            bit40RadioButton.Checked = False
            bit256RadioButton.Checked = False
        End Sub
    End Class
End Namespace
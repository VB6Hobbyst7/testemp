Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security
	Partial Public Class PDF_Permissions_and_Password_Demo
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convertToPdfButton.Click
			' Create a HTML to PDF converter object with default settings
			Dim htmlToPdfConverter As New HtmlToPdfConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
            htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

            ' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            ' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            htmlToPdfConverter.ConversionDelay = 2

            ' Set the encryption algorithm and the encryption key size if they are not the default ones
            If (Not bit128RadioButton.Checked Or Not rc4RadioButton.Checked) Then
                ' set the encryption algorithm
                If (rc4RadioButton.Checked) Then
                    htmlToPdfConverter.PdfSecurityOptions.EncryptionAlgorithm = EncryptionAlgorithm.RC4
                Else
                    htmlToPdfConverter.PdfSecurityOptions.EncryptionAlgorithm = EncryptionAlgorithm.AES
                End If

                ' set the encryption key size
                If (bit40RadioButton.Checked) Then
                    htmlToPdfConverter.PdfSecurityOptions.KeySize = EncryptionKeySize.EncryptKey40Bit
                ElseIf (bit128RadioButton.Checked) Then
                    htmlToPdfConverter.PdfSecurityOptions.KeySize = EncryptionKeySize.EncryptKey128Bit
                ElseIf (bit256RadioButton.Checked) Then
                    htmlToPdfConverter.PdfSecurityOptions.KeySize = EncryptionKeySize.EncryptKey256Bit
                End If
            End If

            ' Set user and owner passwords
            If userPasswordTextBox.Text.Length > 0 Then
                htmlToPdfConverter.PdfSecurityOptions.UserPassword = userPasswordTextBox.Text
            End If

            If ownerPasswordTextBox.Text.Length > 0 Then
                htmlToPdfConverter.PdfSecurityOptions.OwnerPassword = ownerPasswordTextBox.Text
            End If

            ' Set PDF document permissions
            htmlToPdfConverter.PdfSecurityOptions.CanPrint = printEnabledCheckBox.Checked
            htmlToPdfConverter.PdfSecurityOptions.CanPrintHighResolution = highResolutionPrintEnabledCheckBox.Checked
            htmlToPdfConverter.PdfSecurityOptions.CanCopyContent = copyContentEnabledCheckBox.Checked
            htmlToPdfConverter.PdfSecurityOptions.CanCopyAccessibilityContent = copyAccessibilityContentEnabledCheckBox.Checked
            htmlToPdfConverter.PdfSecurityOptions.CanEditContent = editContentEnabledCheckBox.Checked
            htmlToPdfConverter.PdfSecurityOptions.CanEditAnnotations = editAnnotationsEnabledCheckBox.Checked
            htmlToPdfConverter.PdfSecurityOptions.CanFillFormFields = fillFormFieldsEnabledCheckBox.Checked

            If ((PermissionsChanged(htmlToPdfConverter) Or htmlToPdfConverter.PdfSecurityOptions.UserPassword.Length > 0) And
                htmlToPdfConverter.PdfSecurityOptions.OwnerPassword.Length = 0) Then
                ' A user password is set but the owner password is not set or the permissions are not the default ones
                ' Set a default owner password
                htmlToPdfConverter.PdfSecurityOptions.OwnerPassword = "owner"
            End If

            Cursor = Cursors.WaitCursor

            ' Convert HTML to PDF using the settings above
            Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Set_Permissions_Password.pdf"
            Try
                ' Convert the HTML page to a PDF document in a memory buffer
                Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(urlTextBox.Text)

                ' Write the memory buffer in a PDF file
                System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
            Catch ex As Exception
                ' The HTML to PDF conversion failed
                MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message))
                Return
            Finally
                Cursor = Cursors.Arrow
            End Try

            ' Open the created PDF document in default PDF viewer
            Try
                Process.Start(outPdfFile)
            Catch ex As Exception
                MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
            End Try
        End Sub

        Private Function PermissionsChanged(ByVal htmlToPdfConverter As HtmlToPdfConverter) As Boolean
            Return Not htmlToPdfConverter.PdfSecurityOptions.CanPrint Or Not htmlToPdfConverter.PdfSecurityOptions.CanPrintHighResolution Or
                    Not htmlToPdfConverter.PdfSecurityOptions.CanCopyContent Or Not htmlToPdfConverter.PdfSecurityOptions.CanCopyAccessibilityContent Or
                    Not htmlToPdfConverter.PdfSecurityOptions.CanEditContent Or Not htmlToPdfConverter.PdfSecurityOptions.CanEditAnnotations Or
                    Not htmlToPdfConverter.PdfSecurityOptions.CanFillFormFields
        End Function

        Private Sub editContentEnabledCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles editContentEnabledCheckBox.CheckedChanged
            If editContentEnabledCheckBox.Checked Then
                fillFormFieldsEnabledCheckBox.Checked = True
            End If
        End Sub

        Private Sub editAnnotationsEnabledCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles editAnnotationsEnabledCheckBox.CheckedChanged
            If editAnnotationsEnabledCheckBox.Checked Then
                fillFormFieldsEnabledCheckBox.Checked = True
            End If
        End Sub

        Private Sub fillFormFieldsEnabledCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles fillFormFieldsEnabledCheckBox.CheckedChanged
            If Not fillFormFieldsEnabledCheckBox.Checked Then
                editContentEnabledCheckBox.Checked = False
                editAnnotationsEnabledCheckBox.Checked = False
            End If
        End Sub

        Private Sub rc4RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rc4RadioButton.CheckedChanged
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

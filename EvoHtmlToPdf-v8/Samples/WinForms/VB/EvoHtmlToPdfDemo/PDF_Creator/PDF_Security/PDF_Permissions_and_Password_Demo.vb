Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator.PDF_Security
	Partial Public Class PDF_Permissions_and_Password_Demo
		Inherits UserControl
        Private Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convertToPdfButton.Click
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

            Cursor = Cursors.WaitCursor

            Dim outPdfFile As String = "DemoAppFiles\Output\PDF_Creator\Set_Permissions_Password.pdf"
            Try
                ' Create a HTML to PDF element to add to document
                Dim htmlToPdfElement As New HtmlToPdfElement(urlTextBox.Text)

                ' Optionally set a delay before conversion to allow asynchonous scripts to finish
                htmlToPdfElement.ConversionDelay = 2

                ' Add the HTML to PDF element to document
                pdfPage.AddElement(htmlToPdfElement)

                ' Save the PDF document in a memory buffer
                Dim outPdfBuffer() As Byte = pdfDocument.Save()

                ' Write the memory buffer in a PDF file
                System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
            Catch ex As Exception
                ' The PDF creation failed
                MessageBox.Show(String.Format("Create PDF Document Error. {0}", ex.Message))
                Return
            Finally
                ' Close the PDF document
                pdfDocument.Close()

                Cursor = Cursors.Arrow
            End Try

            ' Open the created PDF document in default PDF viewer
            Try
                Process.Start(outPdfFile)
            Catch ex As Exception
                MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
            End Try
        End Sub

        Private Function PermissionsChanged(ByVal pdfDocument As Document) As Boolean
            Return Not pdfDocument.Security.CanPrint Or Not pdfDocument.Security.CanPrintHighResolution Or
                    Not pdfDocument.Security.CanCopyContent Or Not pdfDocument.Security.CanCopyAccessibilityContent Or
                    Not pdfDocument.Security.CanEditContent Or Not pdfDocument.Security.CanEditAnnotations Or
                    Not pdfDocument.Security.CanFillFormFields
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

		Public Sub New()
			InitializeComponent()
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

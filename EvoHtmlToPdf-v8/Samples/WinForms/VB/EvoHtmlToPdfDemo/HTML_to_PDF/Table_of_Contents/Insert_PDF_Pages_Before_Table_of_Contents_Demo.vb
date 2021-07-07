' Use EVO PDF Namespace
Imports EvoPdf

Public Class Insert_PDF_Pages_Before_Table_of_Contents_Demo

    Private Sub convertToPdfButton_Click(sender As Object, e As EventArgs) Handles convertToPdfButton.Click
        ' Create a HTML to PDF converter object with default settings
        Dim htmlToPdfConverter As HtmlToPdfConverter = New HtmlToPdfConverter()

        ' Set license key received after purchase to use the converter in licensed mode
        ' Leave it not set to use the converter in demo mode
        htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

        ' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
        ' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
        htmlToPdfConverter.ConversionDelay = 2

        ' Set the PDF file to be inserted before the table of contents
        htmlToPdfConverter.PdfDocumentOptions.AddStartDocument(pdfBeforeTextBox.Text)

        ' Enable the creation of a table of contents from H1 to H6 tags found in HTML
        htmlToPdfConverter.TableOfContentsOptions.AutoTocItemsEnabled = autoTableOfContentsCheckBox.Checked

        ' Optionally set the table of contents title
        htmlToPdfConverter.TableOfContentsOptions.Title = "Table of Contents"

        ' Optionally set the title style using CSS sttributes
        htmlToPdfConverter.TableOfContentsOptions.TitleStyle = "color:navy; font-family:'Times New Roman'; font-size:28px; font-weight:normal"

        ' Optionally set the style of level 1 items in table of contents
        Dim level1TextStyle As String = "color:black; font-family:'Times New Roman'; font-size:20px; font-weight:normal; font-style:normal; background-color:#F0F0F0"
        htmlToPdfConverter.TableOfContentsOptions.SetItemStyle(1, level1TextStyle)

        ' Optionally set the page numbers style of level 1 items in table of contents
        Dim level1PageNumberStyle As String = "color:black; padding-right:3px; background-color:#F0F0F0; font-size:14px; font-weight:bold"
        htmlToPdfConverter.TableOfContentsOptions.SetPageNumberStyle(1, level1PageNumberStyle)

        Cursor = Cursors.WaitCursor

        ' Convert HTML to PDF using the settings above
        Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Insert_PDF_Before_Table_of_Contents.pdf"
        Try
            ' Convert the HTML page to a PDF document in a memory buffer
            Dim outPdfBuffer As Byte() = htmlToPdfConverter.ConvertUrl(urlTextBox.Text)

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
            System.Diagnostics.Process.Start(outPdfFile)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
        End Try
    End Sub

    Private Sub viewHtmlLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewHtmlLinkLabel.LinkClicked
        System.Diagnostics.Process.Start(urlTextBox.Text)
    End Sub

    Private Sub Insert_PDF_Pages_Before_Table_of_Contents_Demo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pdfBeforeTextBox.Text = "DemoAppFiles\Input\PDF_Files\Merge_Before_Conversion.pdf"
    End Sub
End Class

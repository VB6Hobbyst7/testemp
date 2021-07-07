' Use EVO PDF Namespace
Imports EvoPdf

Public Class Merge_Table_of_Contents_Demo

    Private Sub convertToPdfButton_Click(sender As Object, e As EventArgs) Handles convertToPdfButton.Click
        ' Create the PDF document where to add the HTML documents
        Dim pdfDocument As Document = New Document()

        ' Set license key received after purchase to use the converter in licensed mode
        ' Leave it not set to use the converter in demo mode
        pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

        ' Create a PDF page where to add the first HTML
        Dim firstPdfPage As PdfPage = pdfDocument.AddPage()

        ' Enable the creation of a table of contents from H1 to H6 tags found in HTML
        pdfDocument.TableOfContents.AutoTocItemsEnabled = autoTableOfContentsCheckBox.Checked

        ' Optionally set the table of contents title
        pdfDocument.TableOfContents.Title = "Table of Contents"

        ' Optionally set the title style using CSS sttributes
        pdfDocument.TableOfContents.TitleStyle = "color:navy; font-family:'Times New Roman'; font-size:28px; font-weight:normal"

        ' Optionally set the style of level 1 items in table of contents
        Dim level1TextStyle As String = "color:black; font-family:'Times New Roman'; font-size:20px; font-weight:normal; font-style:normal; background-color:#F0F0F0"
        pdfDocument.TableOfContents.SetItemStyle(1, level1TextStyle)

        ' Optionally set the page numbers style of level 1 items in table of contents
        Dim level1PageNumberStyle As String = "color:black; padding-right:3px; background-color:#F0F0F0; font-size:14px; font-weight:bold"
        pdfDocument.TableOfContents.SetPageNumberStyle(1, level1PageNumberStyle)

        Cursor = Cursors.WaitCursor
        Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Merge_Table_of_Contents.pdf"
        Try
            ' Create the first HTML to PDF element
            Dim firstHtml As HtmlToPdfElement = New HtmlToPdfElement(0, 0, firstUrlTextBox.Text)

            ' Optionally set a delay before conversion to allow asynchonous scripts to finish
            firstHtml.ConversionDelay = 2

            ' Enable or disable the table of contents for the first HTML document
            firstHtml.TableOfContentsEnabled = includeFirstHtmlTocCheckBox.Checked

            ' Add the first HTML to PDF document
            Dim firstAddResult As AddElementResult = firstPdfPage.AddElement(firstHtml)

            Dim secondPdfPage As PdfPage = Nothing
            Dim secondHtmlLocation As PointF = Point.Empty

            If (startNewPageCheckBox.Checked) Then
                ' Create a PDF page where to add the second HTML
                secondPdfPage = pdfDocument.AddPage()
                secondHtmlLocation = PointF.Empty
            Else
                ' Add the second HTML on the PDF page where the first HTML ended
                secondPdfPage = firstAddResult.EndPdfPage
                secondHtmlLocation = New PointF(firstAddResult.EndPageBounds.Left, firstAddResult.EndPageBounds.Bottom)
            End If

            ' Create the second HTML to PDF element
            Dim secondHtml As HtmlToPdfElement = New HtmlToPdfElement(secondHtmlLocation.X, secondHtmlLocation.Y, secondUrlTextBox.Text)

            ' Optionally set a delay before conversion to allow asynchonous scripts to finish
            secondHtml.ConversionDelay = 2

            ' Enable or disable the table of contents for the second HTML document
            secondHtml.TableOfContentsEnabled = includeSecondHtmlTocCheckBox.Checked

            ' Add the second HTML to PDF document
            secondPdfPage.AddElement(secondHtml)

            ' Save the PDF document in a memory buffer
            Dim outPdfBuffer As Byte() = pdfDocument.Save()

            ' Write the memory buffer in a PDF file
            System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
        Catch ex As Exception
            ' The HTML to PDF conversion failed
            MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message))
            Return
        Finally
            ' Close the PDF document
            pdfDocument.Close()

            Cursor = Cursors.Arrow
        End Try

        ' Open the created PDF document in default PDF viewer
        Try
            System.Diagnostics.Process.Start(outPdfFile)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
        End Try
    End Sub

    Private Sub viewFirstHtmlLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewFirstHtmlLinkLabel.LinkClicked
        System.Diagnostics.Process.Start(firstUrlTextBox.Text)
    End Sub

    Private Sub viewSecondHtmlLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewSecondHtmlLinkLabel.LinkClicked
        System.Diagnostics.Process.Start(secondUrlTextBox.Text)
    End Sub
End Class

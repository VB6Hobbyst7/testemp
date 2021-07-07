' Use EVO PDF Namespace
Imports EvoPdf

Public Class Insert_PDF_Pages_Before_Table_of_Contents
    Inherits System.Web.UI.Page

    Protected Sub convertToPdfButton_Click(sender As Object, e As EventArgs) Handles convertToPdfButton.Click
        ' Create a HTML to PDF converter object with default settings
        Dim htmlToPdfConverter As HtmlToPdfConverter = New HtmlToPdfConverter()

        ' Set license key received after purchase to use the converter in licensed mode
        ' Leave it not set to use the converter in demo mode
        htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

        ' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
        ' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
        htmlToPdfConverter.ConversionDelay = 2

        ' Set the PDF file to be inserted before the table of contents
        Dim pdfFileBefore As String = Server.MapPath("~/DemoAppFiles/Input/PDF_Files/Merge_Before_Conversion.pdf")
        htmlToPdfConverter.PdfDocumentOptions.AddStartDocument(pdfFileBefore)

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

        ' The URL to convert
        Dim url As String = urlTextBox.Text

        ' Convert the HTML page to a PDF document in a memory buffer
        Dim outPdfBuffer As Byte() = htmlToPdfConverter.ConvertUrl(url)

        ' Send the PDF as response to browser

        ' Set response content type
        Response.AddHeader("Content-Type", "application/pdf")

        ' Instruct the browser to open the PDF file as an attachment or inline
        Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Insert_PDF_Before_Table_of_Contents.pdf; size={0}", outPdfBuffer.Length.ToString()))

        ' Write the PDF document buffer to HTTP response
        Response.BinaryWrite(outPdfBuffer)

        ' End the HTTP response and stop the current page processing
        Response.End()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/Table_of_Contents/Insert_PDF_Before.html"))
            descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/Table_of_Contents/Insert_PDF_Before.html"))

            Dim currentPageUrl As String = HttpContext.Current.Request.Url.AbsoluteUri
            Dim rootUrl As String = currentPageUrl.Substring(0, currentPageUrl.LastIndexOf("/"c)) & "/../../"

            pdfBeforeHyperLink.NavigateUrl = rootUrl & "DemoAppFiles/Input/PDF_Files/Merge_Before_Conversion.pdf"

            Master.CollapseAll()
            Master.ExpandNode("HTML_to_PDF")
            Master.ExpandNode("Table_of_Contents")
            Master.SelectNode("Insert_PDF_Before_Table_of_Contents")
        End If
    End Sub

    Protected Sub demoMenu_MenuItemClick(sender As Object, e As UI.WebControls.MenuEventArgs) Handles demoMenu.MenuItemClick
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
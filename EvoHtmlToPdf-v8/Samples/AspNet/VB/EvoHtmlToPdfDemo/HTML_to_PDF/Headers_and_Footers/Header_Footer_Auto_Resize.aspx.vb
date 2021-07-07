Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers
	Partial Public Class Header_Footer_Auto_Resize
		Inherits System.Web.UI.Page
		' Define the HTML to PDF converter object as a class member to make it accessible in the headerHtml_NavigationCompletedEvent handler
		' where the header height will be automatically adjusted
		Private htmlToPdfConverter As HtmlToPdfConverter

		' Indicates if a line should be drawn at the botom of the header
		Private drawHeaderLine As Boolean = True

		Protected Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a HTML to PDF converter object with default settings
			htmlToPdfConverter = New HtmlToPdfConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
            htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

            ' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            ' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            htmlToPdfConverter.ConversionDelay = 2

			' Enable header in the generated PDF document
			htmlToPdfConverter.PdfDocumentOptions.ShowHeader = True

			Dim headerHtmlUrl As String = Server.MapPath("~/DemoAppFiles/Input/HTML_Files/Header_HTML.html")
			Dim documentObject As Document = Nothing
			Try
				If autoResizeHeaderRadioButton.Checked Then
					' Create a HTML element to be added in header
					Dim headerHtml As New HtmlToPdfElement(headerHtmlUrl)

					' Install a handler where to set the automatically calculated header height
					AddHandler headerHtml.NavigationCompletedEvent, AddressOf headerHtml_NavigationCompletedEvent

					' Add the HTML element to header
					' When the element is rendered in header by converter, the headerHtml_NavigationCompletedEvent handler 
					' will be invoked and the header height will be automatically calculated
					htmlToPdfConverter.PdfHeaderOptions.AddElement(headerHtml)

					' Call the converter to produce a Document object
					documentObject = htmlToPdfConverter.ConvertUrlToPdfDocumentObject(urlTextBox.Text)

					' Uninstall the handler
					RemoveHandler headerHtml.NavigationCompletedEvent, AddressOf headerHtml_NavigationCompletedEvent

					' Draw a line at the header bottom
					If drawHeaderLine Then
						Dim headerWidth As Single = documentObject.Header.Width
						Dim headerHeight As Single = documentObject.Header.Height

						' Create a line element for the bottom of the header
						Dim headerLine As New LineElement(0, headerHeight - 1, headerWidth, headerHeight - 1)

						' Set line color
						headerLine.ForeColor = Color.Gray

						' Add line element to the bottom of the header
						documentObject.Header.AddElement(headerLine)
					End If

					' Save the PDF document in a memory buffer
					Dim outPdfBuffer() As Byte = documentObject.Save()

					' Send the PDF as response to browser

					' Set response content type
					Response.AddHeader("Content-Type", "application/pdf")

					' Instruct the browser to open the PDF file as an attachment or inline
					Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Auto_Resize_Header_Footer.pdf; size={0}", outPdfBuffer.Length.ToString()))

					' Write the PDF document buffer to HTTP response
					Response.BinaryWrite(outPdfBuffer)

					' End the HTTP response and stop the current page processing
					Response.End()
				Else
					' Create a HTML to PDF element to be added in header
					Dim headerHtml As New HtmlToPdfElement(headerHtmlUrl)

					' Set a fixed header height in points
					htmlToPdfConverter.PdfHeaderOptions.HeaderHeight = Single.Parse(headerHeightTextBox.Text)

					' Set the HTML element to fit the container height
					headerHtml.FitHeight = True

					' Add HTML element to fit the fixed header height
					htmlToPdfConverter.PdfHeaderOptions.AddElement(headerHtml)

					' Draw a line at the header bottom
					If drawHeaderLine Then
						' Calculate the header width based on PDF page size and margins
						Dim headerWidth As Single = htmlToPdfConverter.PdfDocumentOptions.PdfPageSize.Width - htmlToPdfConverter.PdfDocumentOptions.LeftMargin - htmlToPdfConverter.PdfDocumentOptions.RightMargin

						' Calculate header height
						Dim headerHeight As Single = htmlToPdfConverter.PdfHeaderOptions.HeaderHeight

						' Create a line element for the bottom of the header
						Dim headerLine As New LineElement(0, headerHeight - 1, headerWidth, headerHeight - 1)

						' Set line color
						headerLine.ForeColor = Color.Gray

						' Add line element to the bottom of the header
						htmlToPdfConverter.PdfHeaderOptions.AddElement(headerLine)
					End If

					' Convert the HTML page to a PDF document in a memory buffer
					Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(urlTextBox.Text)

					' Send the PDF as response to browser

					' Set response content type
					Response.AddHeader("Content-Type", "application/pdf")

					' Instruct the browser to open the PDF file as an attachment or inline
					Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Auto_Resize_Header_Footer.pdf; size={0}", outPdfBuffer.Length.ToString()))

					' Write the PDF document buffer to HTTP response
					Response.BinaryWrite(outPdfBuffer)

					' End the HTTP response and stop the current page processing
					Response.End()
				End If
			Finally
				' Close the PDF document
				If documentObject IsNot Nothing Then
					documentObject.Close()
				End If
			End Try
		End Sub

		''' <summary>
		''' This handler is called after the navigation to header HTML completed. The document header is resized in this event handler
		''' </summary>
		''' <param name="eventParams">The event parameter containing the HTML content size in pixels and points</param>
		Private Sub headerHtml_NavigationCompletedEvent(ByVal eventParams As NavigationCompletedParams)
			' Get the header HTML width and height from event parameters
			Dim headerHtmlWidth As Single = eventParams.HtmlContentWidthPt
			Dim headerHtmlHeight As Single = eventParams.HtmlContentHeightPt

			' Calculate the header width from coverter settings
			Dim headerWidth As Single = htmlToPdfConverter.PdfDocumentOptions.PdfPageSize.Width - htmlToPdfConverter.PdfDocumentOptions.LeftMargin - htmlToPdfConverter.PdfDocumentOptions.RightMargin

			' Calculate a resize factor to fit the header width
			Dim resizeFactor As Single = 1
			If headerHtmlWidth > headerWidth Then
				resizeFactor = headerWidth / headerHtmlWidth
			End If

			' Calculate the header height to preserve the HTML aspect ratio
			Dim headerHeight As Single = headerHtmlHeight * resizeFactor

			If Not(headerHeight < htmlToPdfConverter.PdfDocumentOptions.PdfPageSize.Height - htmlToPdfConverter.PdfDocumentOptions.TopMargin - htmlToPdfConverter.PdfDocumentOptions.BottomMargin) Then
				Throw New Exception("The header height cannot be bigger than PDF page height")
			End If

			' Set the calculated header height
			htmlToPdfConverter.PdfDocumentOptions.DocumentObject.Header.Height = headerHeight
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/Headers_and_Footers/Header_Footer_Auto_Resize.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/Headers_and_Footers/Header_Footer_Auto_Resize.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.ExpandNode("Headers_and_Footers")
				Master.SelectNode("Header_Footer_Auto_Resize")
			End If
		End Sub

		Protected Sub autoResizeHeaderRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			fixedHeightOptionsPanel.Visible = fitHeaderHeightRadioButton.Checked
		End Sub

		Protected Sub fitHeaderHeightRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			fixedHeightOptionsPanel.Visible = fitHeaderHeightRadioButton.Checked
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
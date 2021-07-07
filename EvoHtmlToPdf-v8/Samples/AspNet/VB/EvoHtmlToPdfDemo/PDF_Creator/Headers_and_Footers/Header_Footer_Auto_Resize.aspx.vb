Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers
	Partial Public Class Header_Footer_Auto_Resize
		Inherits System.Web.UI.Page
		' Define the PDF Document object as a class member to make it accessible in the headerHtml_NavigationCompletedEvent handler
		' where the header height will be automatically adjusted
		Private pdfDocument As Document

		' Indicates if a line should be drawn at the botom of the header
		Private drawHeaderLine As Boolean = True

		Protected Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a PDF document
			pdfDocument = New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a PDF page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

			Dim headerHtmlUrl As String = Server.MapPath("~/DemoAppFiles/Input/HTML_Files/Header_HTML.html")
			Try
				' Add the header to PDF document
				If autoResizeHeaderRadioButton.Checked Then
					' Create the document header with a default height
					' It will be automatically resized in headerHtml_NavigationCompletedEvent handler
					pdfDocument.AddHeaderTemplate(50)

					' Create a HTML element to be added in header
					Dim headerHtml As New HtmlToPdfElement(headerHtmlUrl)

					' Install a handler where to create the document header based on HTML element height
					AddHandler headerHtml.NavigationCompletedEvent, AddressOf headerHtml_NavigationCompletedEvent

					' Add the HTML element to header
					' When the element is rendered in header by converter, the headerHtml_NavigationCompletedEvent handler 
					' will be invoked and the header height will be automatically calculated
					pdfDocument.Header.AddElement(headerHtml)

					' Uninstall the handler
					AddHandler headerHtml.NavigationCompletedEvent, AddressOf headerHtml_NavigationCompletedEvent
				Else
					' Create the document header with a fixed height
					pdfDocument.AddHeaderTemplate(Single.Parse(headerHeightTextBox.Text))

					' Create a HTML to PDF element to be added in header
					Dim headerHtml As New HtmlToPdfElement(headerHtmlUrl)

					' Set the HTML element to fit the container height
					headerHtml.FitHeight = True

					' Add HTML element to fit the fixed header height
					pdfDocument.Header.AddElement(headerHtml)

				End If

				' Draw a line at the header bottom
				If drawHeaderLine Then
					Dim headerWidth As Single = pdfDocument.Header.Width
					Dim headerHeight As Single = pdfDocument.Header.Height

					' Create a line element for the bottom of the header
					Dim headerLine As New LineElement(0, headerHeight - 1, headerWidth, headerHeight - 1)

					' Set line color
					headerLine.ForeColor = Color.Gray

					' Add line element to the bottom of the header
					pdfDocument.Header.AddElement(headerLine)
				End If

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
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Auto_Resize_Header_Footer.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' Close the PDF document
				pdfDocument.Close()
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

			' Get the header width
			Dim headerWidth As Single = pdfDocument.Header.Width

			' Calculate a resize factor to fit the header width
			Dim resizeFactor As Single = 1
			If headerHtmlWidth > headerWidth Then
				resizeFactor = headerWidth / headerHtmlWidth
			End If

			' Calculate the header height to preserve the HTML aspect ratio
			Dim headerHeight As Single = headerHtmlHeight * resizeFactor

			If Not(headerHeight < pdfDocument.Pages(0).PageSize.Height - pdfDocument.Pages(0).Margins.Top - pdfDocument.Pages(0).Margins.Bottom) Then
				Throw New Exception("The header height cannot be bigger than PDF page height")
			End If

			' Set the calculated header height
			pdfDocument.Header.Height = headerHeight
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Creator/Headers_and_Footers/Header_Footer_Auto_Resize.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Creator/Headers_and_Footers/Header_Footer_Auto_Resize.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Creator")
				Master.ExpandNode("PDF_Creator_Headers_and_Footers")
				Master.SelectNode("PDF_Creator_Header_Footer_Auto_Resize")
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
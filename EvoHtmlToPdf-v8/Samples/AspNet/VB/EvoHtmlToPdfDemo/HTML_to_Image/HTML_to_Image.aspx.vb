Imports System.Web.UI
Imports System.Web.UI.WebControls

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_Image
	Partial Public Class HTML_to_Image
		Inherits System.Web.UI.Page
		Protected Sub convertToImageButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a HTML to Image converter object with default settings
			Dim htmlToImageConverter As New HtmlToImageConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			htmlToImageConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Set HTML Viewer width in pixels which is the equivalent in converter of the browser window width
			htmlToImageConverter.HtmlViewerWidth = Integer.Parse(htmlViewerWidthTextBox.Text)

			' Set HTML viewer height in pixels to convert the top part of a HTML page 
			' Leave it not set to convert the entire HTML
			If htmlViewerHeightTextBox.Text.Length > 0 Then
				htmlToImageConverter.HtmlViewerHeight = Integer.Parse(htmlViewerHeightTextBox.Text)
			End If

			' Set if the created image has a transparent background
			htmlToImageConverter.TransparentBackground = If(SelectedImageFormat() Is System.Drawing.Imaging.ImageFormat.Png, transparentBackgroundCheckBox.Checked, False)

			' Set the maximum time in seconds to wait for HTML page to be loaded 
			' Leave it not set for a default 60 seconds maximum wait time
			htmlToImageConverter.NavigationTimeout = Integer.Parse(navigationTimeoutTextBox.Text)

			' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
			' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
			If conversionDelayTextBox.Text.Length > 0 Then
				htmlToImageConverter.ConversionDelay = Integer.Parse(conversionDelayTextBox.Text)
			End If

            Dim imageTiles() As System.Drawing.Image = Nothing

			If convertUrlRadioButton.Checked Then
				Dim url As String = urlTextBox.Text

				' Convert the HTML page given by an URL to a set of Image objects
				imageTiles = htmlToImageConverter.ConvertUrlToImageTiles(url)
			Else
				Dim htmlString As String = htmlStringTextBox.Text
				Dim baseUrl As String = baseUrlTextBox.Text

				' Convert a HTML string with a base URL to a set of Image objects
				imageTiles = htmlToImageConverter.ConvertHtmlToImageTiles(htmlString, baseUrl)
			End If

			' Save the first image tile to a memory buffer

            Dim outImage As System.Drawing.Image = imageTiles(0)

			' Create a memory stream where to save the image
			Dim imageOutputStream As New System.IO.MemoryStream()

			' Save the image to memory stream
			outImage.Save(imageOutputStream, SelectedImageFormat())

			' Write the memory stream to a memory buffer
			imageOutputStream.Position = 0
			Dim outImageBuffer() As Byte = imageOutputStream.ToArray()

			' Close the output memory stream
			imageOutputStream.Close()

			' Send the image as response to browser

			Dim imageFormatName As String = imageFormatComboBox.SelectedValue.ToLower()

			' Set response content type
			Response.AddHeader("Content-Type", "image/" & (If(imageFormatName = "jpg", "jpeg", imageFormatName)))

			' Instruct the browser to open the image file as an attachment or inline
			Response.AddHeader("Content-Disposition", String.Format("attachment; filename={0}; size={1}", "HTML_to_Image." & imageFormatName, outImageBuffer.Length.ToString()))

			' Write the image buffer to HTTP response
			Response.BinaryWrite(outImageBuffer)

			' End the HTTP response and stop the current page processing
			Response.End()
		End Sub

		Private Function SelectedImageFormat() As System.Drawing.Imaging.ImageFormat
			Select Case imageFormatComboBox.SelectedValue
				Case "Png"
					Return System.Drawing.Imaging.ImageFormat.Png
				Case "Jpg"
					Return System.Drawing.Imaging.ImageFormat.Jpeg
				Case "Bmp"
					Return System.Drawing.Imaging.ImageFormat.Bmp
				Case Else
					Return System.Drawing.Imaging.ImageFormat.Png
			End Select
		End Function

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				imageFormatComboBox.SelectedValue = "Png"

				urlPanel.Visible = convertUrlRadioButton.Checked
				htmlStringPanel.Visible = Not convertUrlRadioButton.Checked

				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_Image/HTML_to_Image.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_Image/HTML_to_Image.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_Image")
				Master.SelectNode("Convert_HTML_to_Image")
			End If
		End Sub

		Protected Sub convertUrlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Protected Sub convertHtmlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Protected Sub imageFormatComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			transparentBackgroundCheckBox.Visible = SelectedImageFormat() Is System.Drawing.Imaging.ImageFormat.Png
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
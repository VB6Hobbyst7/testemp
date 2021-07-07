' Use EVO PDF Namespace
Imports EvoPdf

Public Class Proxy_Options
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

        ' Set proxy type
        ' when converting HTML pages from HTTP addresses use the Http proxy type
        ' when converting HTML pages from HTTPS addresses use Socks5 proxy type and make sure the proxy server
        ' is also configured to use SOCKS5 protocol
        htmlToPdfConverter.ProxyOptions.Type = SelectedProxyType()

        ' Set proxy hostname and port number
        ' Hostname and port number are required when the proxy type is set to something different from None value
        htmlToPdfConverter.ProxyOptions.HostName = hostNameTextBox.Text
        htmlToPdfConverter.ProxyOptions.PortNumber = Integer.Parse(portNumberTextBox.Text)

        ' Optionally set proxy username and password if they are required by proxy server
        htmlToPdfConverter.ProxyOptions.Username = usernameTextBox.Text
        htmlToPdfConverter.ProxyOptions.Password = passwordTextBox.Text

        ' Optionally set a list of hosts to be accessed directly without a proxy
        If (bypassedHostTextBox.Text.Length > 0) Then
            htmlToPdfConverter.ProxyOptions.BypassedHosts = New String() {bypassedHostTextBox.Text}
        End If

        ' Convert the HTML page to a PDF document in a memory buffer
        Dim outPdfBuffer As Byte() = htmlToPdfConverter.ConvertUrl(urlTextBox.Text)

        ' Send the PDF as response to browser

        ' Set response content type
        Response.AddHeader("Content-Type", "application/pdf")

        ' Instruct the browser to open the PDF file as an attachment or inline
        Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Proxy_Options.pdf; size={0}", outPdfBuffer.Length.ToString()))

        ' Write the PDF document buffer to HTTP response
        Response.BinaryWrite(outPdfBuffer)

        ' End the HTTP response and stop the current page processing
        Response.End()
    End Sub

    Private Function SelectedProxyType() As NetworkProxyType
        Select Case proxyTypeDropDownList.SelectedValue
            Case "None"
                Return NetworkProxyType.None
            Case "Http"
                Return NetworkProxyType.Http
            Case "Socks5"
                Return NetworkProxyType.Socks5
            Case "HttpCaching"
                Return NetworkProxyType.HttpCaching
            Case Else
                Return NetworkProxyType.None
        End Select
    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/HTTP_GET_and_POST/Proxy_Options.html"))
            descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/HTTP_GET_and_POST/Proxy_Options.html"))

            Master.CollapseAll()
            Master.ExpandNode("HTML_to_PDF")
            Master.ExpandNode("HTTP_GET_and_POST")
            Master.SelectNode("Proxy_Options")
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
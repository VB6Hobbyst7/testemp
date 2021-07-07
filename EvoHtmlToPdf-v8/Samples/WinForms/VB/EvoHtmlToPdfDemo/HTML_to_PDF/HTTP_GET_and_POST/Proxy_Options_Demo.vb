' Use EVO PDF Namespace
Imports EvoPdf

Public Class Proxy_Options_Demo

    Private Sub convertToPdfButton_Click(sender As Object, e As EventArgs) Handles convertToPdfButton.Click
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

        Cursor = Cursors.WaitCursor

        ' Convert HTML to PDF using the settings above
        Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Proxy_Options.pdf"
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

    Private Function SelectedProxyType() As NetworkProxyType
        Select Case proxyTypeComboBox.SelectedItem.ToString()
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

    Private Sub Proxy_Options_Demo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        proxyTypeComboBox.SelectedItem = "None"
    End Sub
End Class

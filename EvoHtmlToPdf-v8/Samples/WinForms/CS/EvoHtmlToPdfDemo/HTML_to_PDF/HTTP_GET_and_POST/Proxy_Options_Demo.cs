using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST
{
    public partial class Proxy_Options_Demo : UserControl
    {
        public Proxy_Options_Demo()
        {
            InitializeComponent();
        }

        private void convertToPdfButton_Click(object sender, EventArgs e)
        {
            // Create a HTML to PDF converter object with default settings
            HtmlToPdfConverter htmlToPdfConverter = new HtmlToPdfConverter();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            // Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            // Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            htmlToPdfConverter.ConversionDelay = 2;
            
            // Set proxy type
            // when converting HTML pages from HTTP addresses use the Http proxy type
            // when converting HTML pages from HTTPS addresses use Socks5 proxy type and make sure the proxy server
            // is also configured to use SOCKS5 protocol
            htmlToPdfConverter.ProxyOptions.Type = SelectedProxyType();

            // Set proxy hostname and port number
            // Hostname and port number are required when the proxy type is set to something different from None value
            htmlToPdfConverter.ProxyOptions.HostName = hostNameTextBox.Text;
            htmlToPdfConverter.ProxyOptions.PortNumber = int.Parse(portNumberTextBox.Text);

            // Optionally set proxy username and password if they are required by proxy server
            htmlToPdfConverter.ProxyOptions.Username = usernameTextBox.Text;
            htmlToPdfConverter.ProxyOptions.Password = passwordTextBox.Text;

            // Optionally set a list of hosts to be accessed directly without a proxy
            if (bypassedHostTextBox.Text.Length > 0)
                htmlToPdfConverter.ProxyOptions.BypassedHosts = new string[] { bypassedHostTextBox.Text };

            Cursor = Cursors.WaitCursor;

            // Convert HTML to PDF using the settings above
            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Proxy_Options.pdf";
            try
            {
                // Convert the HTML page to a PDF document in a memory buffer
                byte[] outPdfBuffer = htmlToPdfConverter.ConvertUrl(urlTextBox.Text);

                // Write the memory buffer in a PDF file
                System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer);
            }
            catch (Exception ex)
            {
                // The HTML to PDF conversion failed
                MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message));
                return;
            }
            finally
            {
                Cursor = Cursors.Arrow;
            }

            // Open the created PDF document in default PDF viewer
            try
            {
                System.Diagnostics.Process.Start(outPdfFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message));
            }
        }

        private NetworkProxyType SelectedProxyType()
        {
            switch (proxyTypeComboBox.SelectedItem.ToString())
            {
                case "None":
                    return NetworkProxyType.None;
                case "Http":
                    return NetworkProxyType.Http;
                case "Socks5":
                    return NetworkProxyType.Socks5;
                case "HttpCaching":
                    return NetworkProxyType.HttpCaching;                
                default:
                    return NetworkProxyType.None;
            }
        }

        private void Proxy_Options_Demo_Load(object sender, EventArgs e)
        {
            proxyTypeComboBox.SelectedItem = "None";
        }
    }
}

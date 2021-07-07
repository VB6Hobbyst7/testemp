using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST
{
    public partial class Proxy_Options : System.Web.UI.Page
    {
        protected void convertToPdfButton_Click(object sender, EventArgs e)
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

            // Convert the HTML page to a PDF document in a memory buffer
            byte[] outPdfBuffer = htmlToPdfConverter.ConvertUrl(urlTextBox.Text);

            // Send the PDF as response to browser

            // Set response content type
            Response.AddHeader("Content-Type", "application/pdf");

            // Instruct the browser to open the PDF file as an attachment or inline
            Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Proxy_Options.pdf; size={0}", outPdfBuffer.Length.ToString()));

            // Write the PDF document buffer to HTTP response
            Response.BinaryWrite(outPdfBuffer);

            // End the HTTP response and stop the current page processing
            Response.End();
        }

        private NetworkProxyType SelectedProxyType()
        {
            switch (proxyTypeDropDownList.SelectedValue)
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                proxyTypeDropDownList.SelectedValue = "None";

                sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/CSharp/AspNet/HTML_to_PDF/HTTP_GET_and_POST/Proxy_Options.html"));
                descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/HTTP_GET_and_POST/Proxy_Options.html"));

                Master.CollapseAll();
                Master.ExpandNode("HTML_to_PDF");
                Master.ExpandNode("HTTP_GET_and_POST");
                Master.SelectNode("Proxy_Options");
            }
        }

        protected void demoMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (e.Item.Value)
            {
                case "Live_Demo":
                    demoMultiView.SetActiveView(liveDemoView);
                    break;
                case "Description":
                    demoMultiView.SetActiveView(descriptionView);
                    break;
                case "Sample_Code":
                    demoMultiView.SetActiveView(sampleCodeView);
                    break;
                default:
                    break;
            }
        }
    }
}
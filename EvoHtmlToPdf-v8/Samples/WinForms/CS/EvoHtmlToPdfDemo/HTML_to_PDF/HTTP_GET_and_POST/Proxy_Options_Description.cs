using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST
{
    public partial class Proxy_Options_Description : UserControl
    {
        public Proxy_Options_Description()
        {
            InitializeComponent();
        }

        private void Proxy_Options_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\HTTP_GET_and_POST\Proxy_Options.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

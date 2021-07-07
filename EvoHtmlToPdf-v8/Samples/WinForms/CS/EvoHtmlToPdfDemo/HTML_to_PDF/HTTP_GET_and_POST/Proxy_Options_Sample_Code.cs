using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST
{
    public partial class Proxy_Options_Sample_Code : UserControl
    {
        public Proxy_Options_Sample_Code()
        {
            InitializeComponent();
        }

        private void Proxy_Options_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\HTTP_GET_and_POST\Proxy_Options.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.URI_Links
{
    public partial class Convert_URI_Links_to_PDF_Samples_Code : UserControl
    {
        public Convert_URI_Links_to_PDF_Samples_Code()
        {
            InitializeComponent();
        }

        private void Convert_URI_Links_to_PDF_Samples_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\URI_Links\Convert_URI_Links_to_PDF.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

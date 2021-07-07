using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers
{
    public partial class Header_Footer_In_External_PDF_Sample_Code : UserControl
    {
        public Header_Footer_In_External_PDF_Sample_Code()
        {
            InitializeComponent();
        }

        private void Header_Footer_In_External_PDF_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\PDF_Creator\Headers_and_Footers\Header_Footer_In_External_PDF.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

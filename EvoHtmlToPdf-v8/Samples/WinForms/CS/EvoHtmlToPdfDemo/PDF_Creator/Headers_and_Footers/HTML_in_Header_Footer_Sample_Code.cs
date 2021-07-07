using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers
{
    public partial class HTML_in_Header_Footer_Sample_Code : UserControl
    {
        public HTML_in_Header_Footer_Sample_Code()
        {
            InitializeComponent();
        }

        private void HTML_in_Header_Footer_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\PDF_Creator\Headers_and_Footers\HTML_in_Header_Footer.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

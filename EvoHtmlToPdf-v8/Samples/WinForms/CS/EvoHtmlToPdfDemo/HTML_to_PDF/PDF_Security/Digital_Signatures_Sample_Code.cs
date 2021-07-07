using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security
{
    public partial class Digital_Signatures_Sample_Code : UserControl
    {
        public Digital_Signatures_Sample_Code()
        {
            InitializeComponent();
        }

        private void Digital_Signatures_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\PDF_Security\Digital_Signatures.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

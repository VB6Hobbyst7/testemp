using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Standards
{
    public partial class Create_PDF_A_and_PDF_X_Sample_Code : UserControl
    {
        public Create_PDF_A_and_PDF_X_Sample_Code()
        {
            InitializeComponent();
        }

        private void Create_PDF_A_and_PDF_X_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\PDF_Standards\Create_PDF_A_and_PDF_X.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

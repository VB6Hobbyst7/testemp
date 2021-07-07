using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTML5_Features
{
    public partial class SVG_to_PDF_Sample_Code : UserControl
    {
        public SVG_to_PDF_Sample_Code()
        {
            InitializeComponent();
        }

        private void SVG_to_PDF_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\HTML5_Features\SVG_to_PDF.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Color_Spaces
{
    public partial class Create_GrayScale_CMYK_Sample_Code : UserControl
    {
        public Create_GrayScale_CMYK_Sample_Code()
        {
            InitializeComponent();
        }

        private void Create_GrayScale_CMYK_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\PDF_Color_Spaces\Create_GrayScale_CMYK.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

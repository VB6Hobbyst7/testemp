using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Fonts_Embedding
{
    public partial class Embed_Fonts_in_PDF_Sample_Code : UserControl
    {
        public Embed_Fonts_in_PDF_Sample_Code()
        {
            InitializeComponent();
        }

        private void Embed_Fonts_in_PDF_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Fonts_Embedding\Embed_Fonts_in_PDF.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

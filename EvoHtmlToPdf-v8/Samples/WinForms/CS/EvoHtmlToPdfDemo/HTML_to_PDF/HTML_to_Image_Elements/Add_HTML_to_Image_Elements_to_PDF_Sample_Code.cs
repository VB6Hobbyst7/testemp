using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_Image_Elements
{
    public partial class Add_HTML_to_Image_Elements_to_PDF_Sample_Code : UserControl
    {
        public Add_HTML_to_Image_Elements_to_PDF_Sample_Code()
        {
            InitializeComponent();
        }

        private void Add_HTML_to_Image_Elements_to_PDF_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\HTML_to_Image_Elements\Add_HTML_to_Image.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

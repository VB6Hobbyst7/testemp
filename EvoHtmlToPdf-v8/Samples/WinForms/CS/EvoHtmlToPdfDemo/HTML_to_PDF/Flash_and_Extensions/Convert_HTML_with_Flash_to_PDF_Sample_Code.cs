using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Flash_and_Extensions
{
    public partial class Convert_HTML_with_Flash_to_PDF_Sample_Code : UserControl
    {
        public Convert_HTML_with_Flash_to_PDF_Sample_Code()
        {
            InitializeComponent();
        }

        private void Convert_HTML_with_Flash_to_PDF_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Flash_Extensions\HTML_Flash_to_PDF.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

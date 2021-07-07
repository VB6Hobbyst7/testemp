using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Internal_Links
{
    public partial class Convert_Internal_Links_to_PDF_Sample_Code : UserControl
    {
        public Convert_Internal_Links_to_PDF_Sample_Code()
        {
            InitializeComponent();
        }

        private void Convert_Internal_Links_to_PDF_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Internal_Links\Convert_Internal_Links_to_PDF.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

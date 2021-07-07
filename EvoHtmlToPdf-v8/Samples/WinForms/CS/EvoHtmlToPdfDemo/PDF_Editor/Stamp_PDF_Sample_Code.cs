using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Editor
{
    public partial class Stamp_PDF_Sample_Code : UserControl
    {
        public Stamp_PDF_Sample_Code()
        {
            InitializeComponent();
        }

        private void Stamp_PDF_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\PDF_Editor\Stamp_PDF.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

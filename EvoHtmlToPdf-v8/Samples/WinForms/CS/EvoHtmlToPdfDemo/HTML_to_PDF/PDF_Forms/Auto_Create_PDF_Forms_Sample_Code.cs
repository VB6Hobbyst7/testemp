using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms
{
    public partial class Auto_Create_PDF_Forms_Sample_Code : UserControl
    {
        public Auto_Create_PDF_Forms_Sample_Code()
        {
            InitializeComponent();
        }

        private void PDF_Forms_Sample_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\PDF_Forms\Auto_Create_PDF_Forms.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

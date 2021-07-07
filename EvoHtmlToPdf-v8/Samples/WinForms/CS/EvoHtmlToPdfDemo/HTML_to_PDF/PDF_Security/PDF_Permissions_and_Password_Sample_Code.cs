using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security
{
    public partial class PDF_Permissions_and_Password_Sample_Code : UserControl
    {
        public PDF_Permissions_and_Password_Sample_Code()
        {
            InitializeComponent();
        }

        private void PDF_Permissions_and_Password_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\PDF_Security\PDF_Permissions.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

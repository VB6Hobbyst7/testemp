using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security
{
    public partial class Digital_Signatures_Description : UserControl
    {
        public Digital_Signatures_Description()
        {
            InitializeComponent();
        }

        private void Digital_Signatures_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\PDF_Security\Digital_Signatures.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

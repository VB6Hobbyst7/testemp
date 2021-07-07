using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Standards
{
    public partial class Create_PDF_A_and_PDF_X_Description : UserControl
    {
        public Create_PDF_A_and_PDF_X_Description()
        {
            InitializeComponent();
        }

        private void Create_PDF_A_and_PDF_X_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\PDF_Standards\Create_PDF_A_and_PDF_X.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

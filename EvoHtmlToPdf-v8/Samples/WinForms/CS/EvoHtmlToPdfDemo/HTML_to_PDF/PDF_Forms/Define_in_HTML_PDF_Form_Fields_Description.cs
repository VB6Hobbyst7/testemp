using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms
{
    public partial class Define_in_HTML_PDF_Form_Fields_Description : UserControl
    {
        public Define_in_HTML_PDF_Form_Fields_Description()
        {
            InitializeComponent();
        }

        private void Define_in_HTML_PDF_Form_Fields_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\PDF_Forms\Define_in_HTML.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

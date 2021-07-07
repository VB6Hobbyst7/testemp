using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Creator
{
    public partial class HTML_to_PDF_Elements_Description : UserControl
    {
        public HTML_to_PDF_Elements_Description()
        {
            InitializeComponent();
        }

        private void HTML_to_PDF_Elements_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\PDF_Creator\HTML_to_PDF_Elements.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_PDF_Elements
{
    public partial class Add_HTML_to_PDF_Elements_to_PDF_Description : UserControl
    {
        public Add_HTML_to_PDF_Elements_to_PDF_Description()
        {
            InitializeComponent();
        }

        private void Add_HTML_to_PDF_Elements_to_PDF_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\HTML_to_PDF_Elements\Add_HTML_to_PDF.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms
{
    public partial class Auto_Create_PDF_Forms_Description : UserControl
    {
        public Auto_Create_PDF_Forms_Description()
        {
            InitializeComponent();
        }

        private void PDF_Forms_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\PDF_Forms\Auto_Create_PDF_Forms.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

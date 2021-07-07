using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Editor
{
    public partial class Fill_PDF_Forms_Description : UserControl
    {
        public Fill_PDF_Forms_Description()
        {
            InitializeComponent();
        }

        private void Fill_PDF_Forms_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\PDF_Editor\Fill_PDF_Forms.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

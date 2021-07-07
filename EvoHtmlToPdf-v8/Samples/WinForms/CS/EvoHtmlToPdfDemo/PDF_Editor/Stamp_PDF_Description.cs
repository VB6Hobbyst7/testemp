using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Editor
{
    public partial class Stamp_PDF_Description : UserControl
    {
        public Stamp_PDF_Description()
        {
            InitializeComponent();
        }

        private void Stamp_PDF_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\PDF_Editor\Stamp_PDF.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

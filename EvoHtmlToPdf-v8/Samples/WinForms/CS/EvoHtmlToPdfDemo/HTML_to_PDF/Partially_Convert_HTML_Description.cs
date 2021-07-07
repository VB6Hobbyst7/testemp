using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF
{
    public partial class Partially_Convert_HTML_Description : UserControl
    {
        public Partially_Convert_HTML_Description()
        {
            InitializeComponent();
        }

        private void Partially_Convert_HTML_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Partially_Convert_HTML.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

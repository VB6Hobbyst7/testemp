using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF
{
    public partial class Merge_Multiple_HTML_Description : UserControl
    {
        public Merge_Multiple_HTML_Description()
        {
            InitializeComponent();
        }

        private void Merge_Multiple_HTML_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Merge_Multiple_HTML.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

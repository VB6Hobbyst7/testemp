using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality
{
    public partial class Replace_with_Higher_Quality_Images_Description : UserControl
    {
        public Replace_with_Higher_Quality_Images_Description()
        {
            InitializeComponent();
        }

        private void Replace_with_Higher_Quality_Images_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Images_Quality\Replace_with_Higher_Quality.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

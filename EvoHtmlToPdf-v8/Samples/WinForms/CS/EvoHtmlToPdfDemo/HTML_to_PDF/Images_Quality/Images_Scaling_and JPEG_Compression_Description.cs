using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality
{
    public partial class Images_Scaling_and_JPEG_Compression_Description : UserControl
    {
        public Images_Scaling_and_JPEG_Compression_Description()
        {
            InitializeComponent();
        }

        private void Images_Scaling_and_JPEG_Compression_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Images_Quality\Scaling_JPEG_Compression.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

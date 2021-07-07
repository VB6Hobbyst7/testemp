using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Color_Spaces
{
    public partial class Create_GrayScale_CMYK_Description : UserControl
    {
        public Create_GrayScale_CMYK_Description()
        {
            InitializeComponent();
        }

        private void Create_GrayScale_CMYK_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\PDF_Color_Spaces\Create_GrayScale_CMYK.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

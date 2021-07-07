using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTML5_Features
{
    public partial class Web_Fonts_to_PDF_Description : UserControl
    {
        public Web_Fonts_to_PDF_Description()
        {
            InitializeComponent();
        }

        private void Web_Fonts_to_PDF_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\HTML5_Features\Web_Fonts_to_PDF.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

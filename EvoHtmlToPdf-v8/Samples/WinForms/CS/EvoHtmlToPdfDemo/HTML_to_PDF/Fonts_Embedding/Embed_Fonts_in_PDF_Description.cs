using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Fonts_Embedding
{
    public partial class Embed_Fonts_in_PDF_Description : UserControl
    {
        public Embed_Fonts_in_PDF_Description()
        {
            InitializeComponent();
        }

        private void Embed_Fonts_in_PDF_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Fonts_Embedding\Embed_Fonts_in_PDF.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

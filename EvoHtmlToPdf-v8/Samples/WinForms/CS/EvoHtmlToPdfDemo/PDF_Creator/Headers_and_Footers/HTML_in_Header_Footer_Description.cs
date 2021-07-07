using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers
{
    public partial class HTML_in_Header_Footer_Description : UserControl
    {
        public HTML_in_Header_Footer_Description()
        {
            InitializeComponent();
        }

        private void HTML_in_Header_Footer_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\PDF_Creator\Headers_and_Footers\HTML_in_Header_Footer.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

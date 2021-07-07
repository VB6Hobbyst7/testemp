using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers
{
    public partial class Header_Footer_Change_Description : UserControl
    {
        public Header_Footer_Change_Description()
        {
            InitializeComponent();
        }

        private void Header_Footer_Change_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Headers_and_Footers\Header_Footer_Change.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

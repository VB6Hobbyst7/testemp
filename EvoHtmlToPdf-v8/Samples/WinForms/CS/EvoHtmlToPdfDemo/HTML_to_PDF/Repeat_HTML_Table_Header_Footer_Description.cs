using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF
{
    public partial class Repeat_HTML_Table_Header_Footer_Description : UserControl
    {
        public Repeat_HTML_Table_Header_Footer_Description()
        {
            InitializeComponent();
        }

        private void Repeat_HTML_Table_Header_Footer_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Repeat_Table_Header_Footer.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

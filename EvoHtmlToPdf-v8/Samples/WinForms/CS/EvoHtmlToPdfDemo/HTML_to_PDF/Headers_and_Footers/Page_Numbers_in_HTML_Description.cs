using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers
{
    public partial class Page_Numbers_in_HTML_Description : UserControl
    {
        public Page_Numbers_in_HTML_Description()
        {
            InitializeComponent();
        }

        private void Page_Numbers_in_HTML_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Headers_and_Footers\Page_Numbers_in_HTML.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

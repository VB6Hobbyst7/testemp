using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST
{
    public partial class GET_and_POST_HTTP_Methods_Description : UserControl
    {
        public GET_and_POST_HTTP_Methods_Description()
        {
            InitializeComponent();
        }

        private void GET_and_POST_HTTP_Methods_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\HTTP_GET_and_POST\GET_and_POST_HTTP_Methods.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

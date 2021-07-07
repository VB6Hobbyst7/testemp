using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.URI_Links
{
    public partial class Define_Custom_URI_Links_Description : UserControl
    {
        public Define_Custom_URI_Links_Description()
        {
            InitializeComponent();
        }

        private void Define_Custom_URI_Links_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\URI_Links\Define_Custom_URI_Links.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

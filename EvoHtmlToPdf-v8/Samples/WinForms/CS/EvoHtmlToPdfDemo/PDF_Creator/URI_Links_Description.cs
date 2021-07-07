using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Creator
{
    public partial class URI_Links_Description : UserControl
    {
        public URI_Links_Description()
        {
            InitializeComponent();
        }

        private void URI_Links_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\PDF_Creator\URI_Links.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF
{
    public partial class HTML_Content_Scaling_Description : UserControl
    {
        public HTML_Content_Scaling_Description()
        {
            InitializeComponent();
        }

        private void HTML_Content_Scaling_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\HTML_Content_Scaling.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

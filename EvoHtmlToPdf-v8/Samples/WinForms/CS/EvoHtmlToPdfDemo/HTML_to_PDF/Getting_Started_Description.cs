using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF
{
    public partial class Getting_Started_Description : UserControl
    {
        public Getting_Started_Description()
        {
            InitializeComponent();
        }

        private void Getting_Started_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Getting_Started.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

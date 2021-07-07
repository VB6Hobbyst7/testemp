using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location
{
    public partial class Select_in_HTML_Elements_to_Retrieve_Description : UserControl
    {
        public Select_in_HTML_Elements_to_Retrieve_Description()
        {
            InitializeComponent();
        }

        private void Select_in_HTML_Elements_to_Retrieve_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\HTML_Elements_Location\Select_in_HTML.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

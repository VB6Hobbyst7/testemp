using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Page_Breaks
{
    public partial class Avoid_Page_Breaks_Inside_HTML_Elements_Using_API_Description : UserControl
    {
        public Avoid_Page_Breaks_Inside_HTML_Elements_Using_API_Description()
        {
            InitializeComponent();
        }

        private void Avoid_Page_Breaks_Inside_HTML_Elements_Using_API_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Page_Breaks\Avoid_Page_Breaks_in_API.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

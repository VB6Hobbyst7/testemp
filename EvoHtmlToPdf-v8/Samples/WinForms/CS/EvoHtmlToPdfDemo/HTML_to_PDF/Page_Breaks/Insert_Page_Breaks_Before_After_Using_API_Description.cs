using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Page_Breaks
{
    public partial class Insert_Page_Breaks_Before_After_Using_API_Description : UserControl
    {
        public Insert_Page_Breaks_Before_After_Using_API_Description()
        {
            InitializeComponent();
        }

        private void Insert_Page_Breaks_Before_After_Using_API_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Page_Breaks\Insert_Page_Breaks_in_API.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

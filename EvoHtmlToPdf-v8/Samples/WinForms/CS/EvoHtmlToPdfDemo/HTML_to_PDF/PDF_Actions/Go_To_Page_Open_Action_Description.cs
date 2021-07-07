using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions
{
    public partial class Go_To_Page_Open_Action_Description : UserControl
    {
        public Go_To_Page_Open_Action_Description()
        {
            InitializeComponent();
        }

        private void Go_To_Page_Open_Action_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\PDF_Actions\Go_To_Page_Open_Action.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

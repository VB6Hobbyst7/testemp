using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.File_Links_Attachments
{
    public partial class Create_File_Links_and_Atachments_Description : UserControl
    {
        public Create_File_Links_and_Atachments_Description()
        {
            InitializeComponent();
        }

        private void Create_File_Links_and_Atachments_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Links_Attach\Create_Links_Atach.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Creator
{
    public partial class File_Attachments_Description : UserControl
    {
        public File_Attachments_Description()
        {
            InitializeComponent();
        }

        private void File_Attachments_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\PDF_Creator\File_Attachments.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

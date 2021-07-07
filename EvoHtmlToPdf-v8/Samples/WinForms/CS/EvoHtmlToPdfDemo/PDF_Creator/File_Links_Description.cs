using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Creator
{
    public partial class File_Links_Description : UserControl
    {
        public File_Links_Description()
        {
            InitializeComponent();
        }

        private void File_Links_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\PDF_Creator\File_Links.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

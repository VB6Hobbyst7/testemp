using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Creator
{
    public partial class Bookmarks_Description : UserControl
    {
        public Bookmarks_Description()
        {
            InitializeComponent();
        }

        private void Bookmarks_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\PDF_Creator\Bookmarks.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

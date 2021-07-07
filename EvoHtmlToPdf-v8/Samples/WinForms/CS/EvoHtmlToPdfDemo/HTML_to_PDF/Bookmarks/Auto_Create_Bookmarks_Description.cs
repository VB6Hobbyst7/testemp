using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks
{
    public partial class Auto_Create_Bookmarks_Description : UserControl
    {
        public Auto_Create_Bookmarks_Description()
        {
            InitializeComponent();
        }

        private void Auto_Create_Bookmarks_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Bookmarks\Auto_Create.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

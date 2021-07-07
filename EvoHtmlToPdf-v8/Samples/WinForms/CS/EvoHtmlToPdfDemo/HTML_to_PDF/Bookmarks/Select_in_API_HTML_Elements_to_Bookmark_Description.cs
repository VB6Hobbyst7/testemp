using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks
{
    public partial class Select_in_API_HTML_Elements_to_Bookmark_Description : UserControl
    {
        public Select_in_API_HTML_Elements_to_Bookmark_Description()
        {
            InitializeComponent();
        }

        private void Select_in_API_HTML_Elements_to_Bookmark_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Bookmarks\Select_in_API.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

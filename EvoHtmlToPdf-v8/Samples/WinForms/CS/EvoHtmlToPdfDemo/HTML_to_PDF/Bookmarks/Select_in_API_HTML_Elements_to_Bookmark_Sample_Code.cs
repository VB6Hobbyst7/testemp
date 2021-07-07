using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks
{
    public partial class Select_in_API_HTML_Elements_to_Bookmark_Sample_Code : UserControl
    {
        public Select_in_API_HTML_Elements_to_Bookmark_Sample_Code()
        {
            InitializeComponent();
        }

        private void Select_in_API_HTML_Elements_to_Bookmark_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Bookmarks\Select_in_API.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

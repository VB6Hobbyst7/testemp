using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Text_Notes
{
    public partial class Create_Text_Notes_Description : UserControl
    {
        public Create_Text_Notes_Description()
        {
            InitializeComponent();
        }

        private void Create_Text_Notes_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Text_Notes\Create_Text_Notes.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

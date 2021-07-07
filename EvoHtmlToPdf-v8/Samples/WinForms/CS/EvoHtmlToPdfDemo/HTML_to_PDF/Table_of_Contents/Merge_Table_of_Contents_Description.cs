using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents
{
    public partial class Merge_Table_of_Contents_Description : UserControl
    {
        public Merge_Table_of_Contents_Description()
        {
            InitializeComponent();
        }

        private void Merge_Table_of_Contents_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Table_of_Contents\Multiple_HTML.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

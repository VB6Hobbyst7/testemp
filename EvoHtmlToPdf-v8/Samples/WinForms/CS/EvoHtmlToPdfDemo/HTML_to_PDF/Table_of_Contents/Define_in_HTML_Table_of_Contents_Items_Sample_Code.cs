using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents
{
    public partial class Define_in_HTML_Table_of_Contents_Items_Sample_Code : UserControl
    {
        public Define_in_HTML_Table_of_Contents_Items_Sample_Code()
        {
            InitializeComponent();
        }

        private void Define_in_HTML_Table_of_Contents_Items_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Table_of_Contents\Define_in_HTML.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

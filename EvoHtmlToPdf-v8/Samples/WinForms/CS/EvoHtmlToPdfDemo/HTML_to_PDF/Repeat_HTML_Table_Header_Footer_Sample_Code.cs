using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF
{
    public partial class Repeat_HTML_Table_Header_Footer_Sample_Code : UserControl
    {
        public Repeat_HTML_Table_Header_Footer_Sample_Code()
        {
            InitializeComponent();
        }

        private void Repeat_HTML_Table_Header_Footer_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Repeat_Table_Header_Footer.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

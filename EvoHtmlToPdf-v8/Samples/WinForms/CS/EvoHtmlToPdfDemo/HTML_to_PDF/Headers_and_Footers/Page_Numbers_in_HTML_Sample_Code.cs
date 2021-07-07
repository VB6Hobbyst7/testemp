using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers
{
    public partial class Page_Numbers_in_HTML_Sample_Code : UserControl
    {
        public Page_Numbers_in_HTML_Sample_Code()
        {
            InitializeComponent();
        }

        private void Page_Numbers_in_HTML_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Headers_and_Footers\Page_Numbers_in_HTML.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

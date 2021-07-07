using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST
{
    public partial class GET_and_POST_HTTP_Methods_Sample_Code : UserControl
    {
        public GET_and_POST_HTTP_Methods_Sample_Code()
        {
            InitializeComponent();
        }

        private void GET_and_POST_HTTP_Methods_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\HTTP_GET_and_POST\GET_and_POST_HTTP_Methods.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

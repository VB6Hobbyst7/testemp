using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF
{
    public partial class HTML_Content_Scaling_Sample_Code : UserControl
    {
        public HTML_Content_Scaling_Sample_Code()
        {
            InitializeComponent();
        }

        private void HTML_Content_Scaling_Sample_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\HTML_Content_Scaling.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

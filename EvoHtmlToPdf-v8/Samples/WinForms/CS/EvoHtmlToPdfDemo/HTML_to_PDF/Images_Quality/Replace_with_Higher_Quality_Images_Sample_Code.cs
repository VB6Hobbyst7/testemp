using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality
{
    public partial class Replace_with_Higher_Quality_Images_Sample_Code : UserControl
    {
        public Replace_with_Higher_Quality_Images_Sample_Code()
        {
            InitializeComponent();
        }

        private void Replace_with_Higher_Quality_Images_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Images_Quality\Replace_with_Higher_Quality.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

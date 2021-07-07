using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Watermarks_Stamps
{
    public partial class Add_Watermarks_Stamps_Sample_Code : UserControl
    {
        public Add_Watermarks_Stamps_Sample_Code()
        {
            InitializeComponent();
        }

        private void Add_Watermarks_Stamps_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Watermarks_Stamps\Add_Watermarks_Stamps.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

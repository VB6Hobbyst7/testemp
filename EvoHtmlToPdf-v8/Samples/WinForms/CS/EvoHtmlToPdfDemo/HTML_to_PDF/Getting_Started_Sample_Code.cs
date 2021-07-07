using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF
{
    public partial class Getting_Started_Sample_Code : UserControl
    {
        public Getting_Started_Sample_Code()
        {
            InitializeComponent();
        }

        private void Getting_Started_Sample_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Getting_Started.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

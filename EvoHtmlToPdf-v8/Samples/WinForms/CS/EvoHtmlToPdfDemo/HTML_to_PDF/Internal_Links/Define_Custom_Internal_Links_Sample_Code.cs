using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Internal_Links
{
    public partial class Define_Custom_Internal_Links_Sample_Code : UserControl
    {
        public Define_Custom_Internal_Links_Sample_Code()
        {
            InitializeComponent();
        }

        private void Define_Custom_Internal_Links_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Internal_Links\Define_Custom_Internal_Links.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

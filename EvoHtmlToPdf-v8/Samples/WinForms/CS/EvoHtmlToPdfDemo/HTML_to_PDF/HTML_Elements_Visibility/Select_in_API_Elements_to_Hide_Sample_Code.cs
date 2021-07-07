using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Visibility
{
    public partial class Select_in_API_Elements_to_Hide_Sample_Code : UserControl
    {
        public Select_in_API_Elements_to_Hide_Sample_Code()
        {
            InitializeComponent();
        }

        private void Select_in_API_Elements_to_Hide_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\HTML_Elements_Visibility\Select_in_API.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

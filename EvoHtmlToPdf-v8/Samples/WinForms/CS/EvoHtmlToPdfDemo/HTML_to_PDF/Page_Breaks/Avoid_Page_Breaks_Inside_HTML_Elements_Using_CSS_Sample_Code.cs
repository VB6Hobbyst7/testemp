using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Page_Breaks
{
    public partial class Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS_Sample_Code : UserControl
    {
        public Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS_Sample_Code()
        {
            InitializeComponent();
        }

        private void Avoid_Page_Breaks_Inside_HTML_Elements_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Page_Breaks\Avoid_Page_Breaks_in_CSS.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

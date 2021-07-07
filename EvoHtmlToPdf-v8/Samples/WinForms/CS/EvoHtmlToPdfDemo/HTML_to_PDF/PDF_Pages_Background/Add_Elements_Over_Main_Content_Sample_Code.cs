using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background
{
    public partial class Add_Elements_Over_Main_Content_Sample_Code : UserControl
    {
        public Add_Elements_Over_Main_Content_Sample_Code()
        {
            InitializeComponent();
        }

        private void Add_Elements_Over_Main_Content_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\PDF_Pages_Back\Add_Elements_in_Front.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

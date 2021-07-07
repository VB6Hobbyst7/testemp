using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Text_Notes
{
    public partial class Create_Text_Notes_Sample_Code : UserControl
    {
        public Create_Text_Notes_Sample_Code()
        {
            InitializeComponent();
        }

        private void Create_Text_Notes_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Text_Notes\Create_Text_Notes.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

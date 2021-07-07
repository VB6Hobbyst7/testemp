using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.File_Links_Attachments
{
    public partial class Create_File_Links_and_Atachments_Sample_Code : UserControl
    {
        public Create_File_Links_and_Atachments_Sample_Code()
        {
            InitializeComponent();
        }

        private void Create_File_Links_and_Atachments_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Links_Attach\Create_Links_Atach.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

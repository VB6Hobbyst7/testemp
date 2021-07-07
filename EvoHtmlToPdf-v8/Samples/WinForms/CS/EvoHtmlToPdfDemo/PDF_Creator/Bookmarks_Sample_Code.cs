using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Creator
{
    public partial class Bookmarks_Sample_Code : UserControl
    {
        public Bookmarks_Sample_Code()
        {
            InitializeComponent();
        }

        private void Bookmarks_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\PDF_Creator\Bookmarks.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

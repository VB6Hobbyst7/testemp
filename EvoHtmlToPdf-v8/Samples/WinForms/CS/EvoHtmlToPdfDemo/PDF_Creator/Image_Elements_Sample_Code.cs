using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Creator
{
    public partial class Image_Elements_Sample_Code : UserControl
    {
        public Image_Elements_Sample_Code()
        {
            InitializeComponent();
        }

        private void Image_Elements_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\PDF_Creator\Image_Elements.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

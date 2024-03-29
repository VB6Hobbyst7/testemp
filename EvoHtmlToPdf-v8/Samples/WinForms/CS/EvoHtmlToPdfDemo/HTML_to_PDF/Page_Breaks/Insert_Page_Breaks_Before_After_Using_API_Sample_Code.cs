﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Page_Breaks
{
    public partial class Insert_Page_Breaks_Before_After_Using_API_Sample_Code : UserControl
    {
        public Insert_Page_Breaks_Before_After_Using_API_Sample_Code()
        {
            InitializeComponent();
        }

        private void Insert_Page_Breaks_Before_After_Using_API_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Page_Breaks\Insert_Page_Breaks_in_API.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

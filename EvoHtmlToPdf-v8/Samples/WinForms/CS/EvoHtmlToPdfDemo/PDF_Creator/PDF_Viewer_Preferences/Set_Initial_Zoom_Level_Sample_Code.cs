using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences
{
    public partial class Set_Initial_Zoom_Level_Sample_Code : UserControl
    {
        public Set_Initial_Zoom_Level_Sample_Code()
        {
            InitializeComponent();
        }

        private void Set_Initial_Zoom_Level_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\PDF_Creator\PDF_Viewer\Set_Initial_Zoom_Level.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

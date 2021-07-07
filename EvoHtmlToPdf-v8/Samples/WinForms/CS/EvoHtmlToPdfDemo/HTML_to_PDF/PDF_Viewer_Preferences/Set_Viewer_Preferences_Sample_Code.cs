using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences
{
    public partial class Set_Viewer_Preferences_Sample_Code : UserControl
    {
        public Set_Viewer_Preferences_Sample_Code()
        {
            InitializeComponent();
        }

        private void Set_Viewer_Preferences_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\PDF_Viewer\Set_Viewer_Preferences.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

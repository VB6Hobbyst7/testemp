using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Media_Types
{
    public partial class Select_Screen_or_Print_Media_Type_Sample_Code : UserControl
    {
        public Select_Screen_or_Print_Media_Type_Sample_Code()
        {
            InitializeComponent();
        }

        private void Select_Screen_or_Print_Media_Type_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Media_Types\Screen_Print_Media_Type.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

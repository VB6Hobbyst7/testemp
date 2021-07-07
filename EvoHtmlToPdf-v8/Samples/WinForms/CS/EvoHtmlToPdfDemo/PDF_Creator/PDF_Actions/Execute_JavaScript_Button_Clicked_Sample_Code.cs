using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions
{
    public partial class Execute_JavaScript_Button_Clicked_Sample_Code : UserControl
    {
        public Execute_JavaScript_Button_Clicked_Sample_Code()
        {
            InitializeComponent();
        }

        private void Execute_JavaScript_Button_Clicked_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\PDF_Creator\PDF_Actions\Execute_JavaScript_Button.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

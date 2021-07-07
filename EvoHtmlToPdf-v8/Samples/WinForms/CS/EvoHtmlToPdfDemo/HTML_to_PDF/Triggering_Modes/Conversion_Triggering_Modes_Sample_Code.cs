using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Triggering_Modes
{
    public partial class Conversion_Triggering_Modes_Sample_Code : UserControl
    {
        public Conversion_Triggering_Modes_Sample_Code()
        {
            InitializeComponent();
        }

        private void Conversion_Triggering_Modes_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\Triggering_Modes\Triggering_Modes.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

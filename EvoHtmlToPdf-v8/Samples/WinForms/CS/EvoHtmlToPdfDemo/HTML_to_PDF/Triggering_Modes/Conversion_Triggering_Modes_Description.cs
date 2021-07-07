using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Triggering_Modes
{
    public partial class Conversion_Triggering_Modes_Description : UserControl
    {
        public Conversion_Triggering_Modes_Description()
        {
            InitializeComponent();
        }

        private void Conversion_Triggering_Modes_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Triggering_Modes\Triggering_Modes.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

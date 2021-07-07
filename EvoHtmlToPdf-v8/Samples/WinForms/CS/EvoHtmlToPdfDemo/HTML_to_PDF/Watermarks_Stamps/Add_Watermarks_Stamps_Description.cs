using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Watermarks_Stamps
{
    public partial class Add_Watermarks_Stamps_Description : UserControl
    {
        public Add_Watermarks_Stamps_Description()
        {
            InitializeComponent();
        }

        private void Add_Watermarks_Stamps_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Watermarks_Stamps\Add_Watermarks_Stamps.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

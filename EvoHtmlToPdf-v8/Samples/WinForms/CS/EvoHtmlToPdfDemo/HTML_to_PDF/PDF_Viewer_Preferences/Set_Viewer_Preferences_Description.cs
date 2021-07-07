using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences
{
    public partial class Set_Viewer_Preferences_Description : UserControl
    {
        public Set_Viewer_Preferences_Description()
        {
            InitializeComponent();
        }

        private void Set_Viewer_Preferences_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\PDF_Viewer\Set_Viewer_Preferences.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences
{
    public partial class Set_Initial_Zoom_Level_Description : UserControl
    {
        public Set_Initial_Zoom_Level_Description()
        {
            InitializeComponent();
        }

        private void Set_Initial_Zoom_Level_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\PDF_Viewer\Set_Initial_Zoom_Level.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

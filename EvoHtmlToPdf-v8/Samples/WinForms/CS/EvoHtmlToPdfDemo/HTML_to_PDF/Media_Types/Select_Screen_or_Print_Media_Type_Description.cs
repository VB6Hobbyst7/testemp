using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Media_Types
{
    public partial class Select_Screen_or_Print_Media_Type_Description : UserControl
    {
        public Select_Screen_or_Print_Media_Type_Description()
        {
            InitializeComponent();
        }

        private void Select_Screen_or_Print_Media_Type_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Media_Types\Screen_Print_Media_Type.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

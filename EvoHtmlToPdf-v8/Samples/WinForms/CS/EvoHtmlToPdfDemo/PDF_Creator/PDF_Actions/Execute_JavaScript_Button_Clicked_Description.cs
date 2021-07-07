using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions
{
    public partial class Execute_JavaScript_Button_Clicked_Description : UserControl
    {
        public Execute_JavaScript_Button_Clicked_Description()
        {
            InitializeComponent();
        }

        private void Execute_JavaScript_Button_Clicked_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\PDF_Creator\PDF_Actions\Execute_JavaScript_Button.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

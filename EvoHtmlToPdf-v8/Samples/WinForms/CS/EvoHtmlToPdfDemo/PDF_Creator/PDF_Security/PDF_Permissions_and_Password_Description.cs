using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Creator.PDF_Security
{
    public partial class PDF_Permissions_and_Password_Description : UserControl
    {
        public PDF_Permissions_and_Password_Description()
        {
            InitializeComponent();
        }

        private void PDF_Permissions_and_Password_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\PDF_Creator\PDF_Security\PDF_Permissions.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

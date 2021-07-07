using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies
{
    public partial class Add_Cookies_to_Request_Description : UserControl
    {
        public Add_Cookies_to_Request_Description()
        {
            InitializeComponent();
        }

        private void Add_Cookies_to_Request_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\HTTP_Headers_Cookies\Add_Cookies.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}

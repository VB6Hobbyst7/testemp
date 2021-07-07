using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies
{
    public partial class Add_HTTP_Headers_to_Request_Sample_Code : UserControl
    {
        public Add_HTTP_Headers_to_Request_Sample_Code()
        {
            InitializeComponent();
        }

        private void Add_HTTP_Headers_to_Request_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\HTML_to_PDF\HTTP_Headers_Cookies\Add_HTTP_Headers.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}

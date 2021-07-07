using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Drawing;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents
{
    public partial class Merge_Table_of_Contents : System.Web.UI.Page
    {
        protected void convertToPdfButton_Click(object sender, EventArgs e)
        {
            // Create the PDF document where to add the HTML documents
            Document pdfDocument = new Document();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            // Create a PDF page where to add the first HTML
            PdfPage firstPdfPage = pdfDocument.AddPage();

            // Enable the creation of a table of contents from H1 to H6 tags found in HTML
            pdfDocument.TableOfContents.AutoTocItemsEnabled = autoTableOfContentsCheckBox.Checked;

            // Optionally set the table of contents title
            pdfDocument.TableOfContents.Title = "Table of Contents";

            // Optionally set the title style using CSS sttributes
            pdfDocument.TableOfContents.TitleStyle = "color:navy; font-family:'Times New Roman'; font-size:28px; font-weight:normal";

            // Optionally set the style of level 1 items in table of contents
            string level1TextStyle = "color:black; font-family:'Times New Roman'; font-size:20px; font-weight:normal; font-style:normal; background-color:#F0F0F0";
            pdfDocument.TableOfContents.SetItemStyle(1, level1TextStyle);

            // Optionally set the page numbers style of level 1 items in table of contents
            string level1PageNumberStyle = "color:black; padding-right:3px; background-color:#F0F0F0; font-size:14px; font-weight:bold";
            pdfDocument.TableOfContents.SetPageNumberStyle(1, level1PageNumberStyle);

            try
            {
                // Create the first HTML to PDF element
                HtmlToPdfElement firstHtml = new HtmlToPdfElement(0, 0, firstUrlTextBox.Text);

                // Optionally set a delay before conversion to allow asynchonous scripts to finish
                firstHtml.ConversionDelay = 2;

                // Enable or disable the table of contents for the first HTML document
                firstHtml.TableOfContentsEnabled = includeFirstHtmlTocCheckBox.Checked;

                // Add the first HTML to PDF document
                AddElementResult firstAddResult = firstPdfPage.AddElement(firstHtml);

                PdfPage secondPdfPage = null;
                PointF secondHtmlLocation = Point.Empty;

                if (startNewPageCheckBox.Checked)
                {
                    // Create a PDF page where to add the second HTML
                    secondPdfPage = pdfDocument.AddPage();
                    secondHtmlLocation = PointF.Empty;
                }
                else
                {
                    // Add the second HTML on the PDF page where the first HTML ended
                    secondPdfPage = firstAddResult.EndPdfPage;
                    secondHtmlLocation = new PointF(firstAddResult.EndPageBounds.Left, firstAddResult.EndPageBounds.Bottom);
                }

                // Create the second HTML to PDF element
                HtmlToPdfElement secondHtml = new HtmlToPdfElement(secondHtmlLocation.X, secondHtmlLocation.Y, secondUrlTextBox.Text);

                // Optionally set a delay before conversion to allow asynchonous scripts to finish
                secondHtml.ConversionDelay = 2;

                // Enable or disable the table of contents for the second HTML document
                secondHtml.TableOfContentsEnabled = includeSecondHtmlTocCheckBox.Checked;

                // Add the second HTML to PDF document
                secondPdfPage.AddElement(secondHtml);

                // Save the PDF document in a memory buffer
                byte[] outPdfBuffer = pdfDocument.Save();

                // Send the PDF as response to browser

                // Set response content type
                Response.AddHeader("Content-Type", "application/pdf");

                // Instruct the browser to open the PDF file as an attachment or inline
                Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Merge_Table_of_Contents.pdf; size={0}", outPdfBuffer.Length.ToString()));

                // Write the PDF document buffer to HTTP response
                Response.BinaryWrite(outPdfBuffer);

                // End the HTTP response and stop the current page processing
                Response.End();
            }
            finally
            {
                // Close the PDF document
                pdfDocument.Close();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/CSharp/AspNet/HTML_to_PDF/Table_of_Contents/Multiple_HTML.html"));
                descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/Table_of_Contents/Multiple_HTML.html"));

                Master.CollapseAll();
                Master.ExpandNode("HTML_to_PDF");
                Master.ExpandNode("Table_of_Contents");
                Master.SelectNode("Merge_Table_of_Contents");
            }
        }

        protected void demoMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (e.Item.Value)
            {
                case "Live_Demo":
                    demoMultiView.SetActiveView(liveDemoView);
                    break;
                case "Description":
                    demoMultiView.SetActiveView(descriptionView);
                    break;
                case "Sample_Code":
                    demoMultiView.SetActiveView(sampleCodeView);
                    break;
                default:
                    break;
            }
        }
    }
}
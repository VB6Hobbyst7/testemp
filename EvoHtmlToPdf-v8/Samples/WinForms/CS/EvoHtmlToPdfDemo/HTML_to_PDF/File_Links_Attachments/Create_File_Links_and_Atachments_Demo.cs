using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.File_Links_Attachments
{
    public partial class Create_File_Links_and_Atachments_Demo : UserControl
    {
        private void convertToPdfButton_Click(object sender, EventArgs e)
        {
            // Create a HTML to PDF converter object with default settings
            HtmlToPdfConverter htmlToPdfConverter = new HtmlToPdfConverter();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            // Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            // Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            htmlToPdfConverter.ConversionDelay = 2;

            Cursor = Cursors.WaitCursor;

            // Convert HTML to PDF using the settings above
            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\File_Links_and_Attachments.pdf";
            Document pdfDocument = null;
            try
            {   
                string htmlWithLinksAndAttachMarkers = htmlStringTextBox.Text;
                string baseUrl = baseUrlTextBox.Text;

                // Convert a HTML string with markers for file links and attachments to a PDF document object
                pdfDocument = htmlToPdfConverter.ConvertHtmlToPdfDocumentObject(htmlWithLinksAndAttachMarkers, baseUrl);

                // Display the attachments panel when the PDF document is opened in a PDF viewer
                pdfDocument.ViewerPreferences.PageMode = ViewerPageMode.UseAttachments;

                // Create File Links

                // Make the HTML element with 'file_link_text' mapping ID a link to an external file
                HtmlElementMapping fileLinkTextMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("file_link_text");
                if (fileLinkTextMapping != null)
                {
                    PdfPage fileLinkTextPage = fileLinkTextMapping.PdfRectangles[0].PdfPage;
                    RectangleF fileLinkTextRectangle = fileLinkTextMapping.PdfRectangles[0].Rectangle;

                    string filePath = @"..\..\Input\Linked_Files\Linked_External_File.txt";

                    // Create the file link
                    FileLinkElement fileLinkTextElement = new FileLinkElement(fileLinkTextRectangle, filePath);
                    fileLinkTextPage.AddElement(fileLinkTextElement);
                }

                // Make the HTML element with 'file_link_img' ID a link to an external file
                HtmlElementMapping fileLinkImgMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("file_link_image");
                if (fileLinkImgMapping != null)
                {
                    PdfPage fileLinkImgPage = fileLinkImgMapping.PdfRectangles[0].PdfPage;
                    RectangleF fileLinkImgRectangle = fileLinkImgMapping.PdfRectangles[0].Rectangle;

                    string filePath = @"..\..\Input\Linked_Files\Linked_External_File.txt";

                    // Create the file link
                    FileLinkElement fileLinkImgElement = new FileLinkElement(fileLinkImgRectangle, filePath);
                    fileLinkImgPage.AddElement(fileLinkImgElement);
                }

                // Create File Attachments

                // Create an attachment from a file without icon
                string fileAttachmentPath = @"DemoAppFiles\Input\Attach_Files\Attachment_File.txt";
                pdfDocument.AddFileAttachment(fileAttachmentPath, "Attachment from File");

                // Create an attachment from a stream without icon
                string fileStreamAttachmentPath = @"DemoAppFiles\Input\Attach_Files\Attachment_Stream.txt";
                System.IO.FileStream attachmentStream = new System.IO.FileStream(fileStreamAttachmentPath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                pdfDocument.AddFileAttachment(attachmentStream, "Attachment_Stream.txt", "Attachment from Stream");

                // Create an attachment from file with paperclip icon in PDF
                HtmlElementMapping attachFromFileIconMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("attach_from_file_icon");
                if (attachFromFileIconMapping != null)
                {
                    PdfPage attachFromFilePage = attachFromFileIconMapping.PdfRectangles[0].PdfPage;
                    RectangleF attachFromFileIconRectangle = attachFromFileIconMapping.PdfRectangles[0].Rectangle;

                    string fileAttachmentWithIconPath = @"DemoAppFiles\Input\Attach_Files\Attachment_File_Icon.txt";

                    // Create the attachment from file
                    FileAttachmentElement attachFromFileElement = new FileAttachmentElement(attachFromFileIconRectangle, fileAttachmentWithIconPath);
                    attachFromFileElement.IconType = FileAttachmentIcon.Paperclip;
                    attachFromFileElement.Text = "Attachment from File with Paperclip Icon";
                    attachFromFileElement.IconColor = Color.Blue;
                    attachFromFilePage.AddElement(attachFromFileElement);
                }

                // Create an attachment from stream with pushpin icon in PDF
                System.IO.FileStream attachmentStreamWithIcon = null;
                HtmlElementMapping attachFromStreamIconMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("attach_from_stream_icon");
                if (attachFromStreamIconMapping != null)
                {
                    PdfPage attachFromStreamPage = attachFromStreamIconMapping.PdfRectangles[0].PdfPage;
                    RectangleF attachFromStreamIconRectangle = attachFromStreamIconMapping.PdfRectangles[0].Rectangle;
                    
                    string fileStreamAttachmentWithIconPath = @"DemoAppFiles\Input\Attach_Files\Attachment_Stream_Icon.txt";

                    attachmentStreamWithIcon = new System.IO.FileStream(fileStreamAttachmentWithIconPath, System.IO.FileMode.Open, System.IO.FileAccess.Read);

                    // Create the attachment from stream
                    FileAttachmentElement attachFromStreamElement = new FileAttachmentElement(attachFromStreamIconRectangle, attachmentStreamWithIcon, "Attachment_Stream_Icon.txt");
                    attachFromStreamElement.IconType = FileAttachmentIcon.PushPin;
                    attachFromStreamElement.Text = "Attachment from Stream with Pushpin Icon";
                    attachFromStreamElement.IconColor = Color.Green;
                    attachFromStreamPage.AddElement(attachFromStreamElement);
                }
                
                // Save the PDF document in a memory buffer
                byte[] outPdfBuffer = pdfDocument.Save();

                // Write the memory buffer in a PDF file
                System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer);
            }
            catch (Exception ex)
            {
                // The HTML to PDF conversion failed
                MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message));
                return;
            }
            finally
            {
                // Close the PDF document
                if (pdfDocument != null)
                    pdfDocument.Close();

                Cursor = Cursors.Arrow;
            }

            // Open the created PDF document in default PDF viewer
            try
            {
                System.Diagnostics.Process.Start(outPdfFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message));
            }
        }

        private void Add_File_Links_and_Atachments_Demo_Load(object sender, EventArgs e)
        {
            htmlStringTextBox.Text = System.IO.File.ReadAllText(@"DemoAppFiles\Input\HTML_Files\File_Links_and_Attachments.html");
            baseUrlTextBox.Text = "file:///" + Application.StartupPath + @"\DemoAppFiles\Input\HTML_Files/";
        }

        public Create_File_Links_and_Atachments_Demo()
        {
            InitializeComponent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.PDF_Creator
{
    public partial class File_Attachments_Demo : UserControl
    {
        private void createPdfButton_Click(object sender, EventArgs e)
        {
            // Create a PDF document
            Document pdfDocument = new Document();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            // Display the attachments panel when the PDF document is opened in a PDF viewer
            pdfDocument.ViewerPreferences.PageMode = ViewerPageMode.UseAttachments;

            // Add a page to PDF document
            PdfPage pdfPage = pdfDocument.AddPage();

            Cursor = Cursors.WaitCursor;
            string outPdfFile = @"DemoAppFiles\Output\PDF_Creator\File_Attachments.pdf";
            try
            {
                // The titles font used to mark various sections of the PDF document
                PdfFont titleFont = pdfDocument.AddFont(new Font("Times New Roman", 10, FontStyle.Bold, GraphicsUnit.Point));
                PdfFont subtitleFont = pdfDocument.AddFont(new Font("Times New Roman", 8, FontStyle.Regular, GraphicsUnit.Point));

                float xLocation = 5;
                float yLocation = 5;

                // Add document title
                TextElement titleTextElement = new TextElement(xLocation, yLocation, "Attach Files and Streams to a PDF Document", titleFont);
                AddElementResult addElementResult = pdfPage.AddElement(titleTextElement);

                yLocation = addElementResult.EndPageBounds.Bottom + 15;

                // Create an attachment from a file without icon
                string fileAttachmentPath = @"DemoAppFiles\Input\Attach_Files\Attachment_File.txt";
                pdfDocument.AddFileAttachment(fileAttachmentPath, "Attachment from File");

                // Create an attachment from a stream without icon
                string fileStreamAttachmentPath = @"DemoAppFiles\Input\Attach_Files\Attachment_Stream.txt";
                System.IO.FileStream attachmentStream = new System.IO.FileStream(fileStreamAttachmentPath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                pdfDocument.AddFileAttachment(attachmentStream, "Attachment_Stream.txt", "Attachment from Stream");

                // Add the text element
                string text = "Click the next icon to open the attachment from a file:";
                float textWidth = subtitleFont.GetTextWidth(text);
                TextElement textElement = new TextElement(xLocation, yLocation, text, subtitleFont);
                addElementResult = pdfPage.AddElement(textElement);

                // Create an attachment from file with paperclip icon in PDF
                string fileAttachmentWithIconPath = @"DemoAppFiles\Input\Attach_Files\Attachment_File_Icon.txt";
                // Create the attachment from file
                RectangleF attachFromFileIconRectangle = new RectangleF(xLocation + textWidth + 3, yLocation, 6, 10);
                FileAttachmentElement attachFromFileElement = new FileAttachmentElement(attachFromFileIconRectangle, fileAttachmentWithIconPath);
                attachFromFileElement.IconType = FileAttachmentIcon.Paperclip;
                attachFromFileElement.Text = "Attachment from File with Paperclip Icon";
                attachFromFileElement.IconColor = Color.Blue;
                pdfPage.AddElement(attachFromFileElement);

                yLocation = addElementResult.EndPageBounds.Bottom + 10;

                // Add the text element
                text = "Click the next icon to open the attachment from a stream:";
                textWidth = subtitleFont.GetTextWidth(text);
                textElement = new TextElement(xLocation, yLocation, text, subtitleFont);
                addElementResult = pdfPage.AddElement(textElement);

                // Create an attachment from stream with pushpin icon in PDF
                string fileStreamAttachmentWithIconPath = @"DemoAppFiles\Input\Attach_Files\Attachment_Stream_Icon.txt";
                System.IO.FileStream attachmentStreamWithIcon = new System.IO.FileStream(fileStreamAttachmentWithIconPath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                // Create the attachment from stream
                RectangleF attachFromStreamIconRectangle = new RectangleF(xLocation + textWidth + 3, yLocation, 6, 10);
                FileAttachmentElement attachFromStreamElement = new FileAttachmentElement(attachFromStreamIconRectangle, attachmentStreamWithIcon, "Attachment_Stream_Icon.txt");
                attachFromStreamElement.IconType = FileAttachmentIcon.PushPin;
                attachFromStreamElement.Text = "Attachment from Stream with Pushpin Icon";
                attachFromStreamElement.IconColor = Color.Green;
                pdfPage.AddElement(attachFromStreamElement);

                // Save the PDF document in a memory buffer
                byte[] outPdfBuffer = pdfDocument.Save();

                // Write the memory buffer in a PDF file
                System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer);
            }
            catch (Exception ex)
            {
                // The PDF creation failed
                MessageBox.Show(String.Format("Create PDF Document Error. {0}", ex.Message));
                return;
            }
            finally
            {
                // Close the PDF document
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

        public File_Attachments_Demo()
        {
            InitializeComponent();
        }
    }
}

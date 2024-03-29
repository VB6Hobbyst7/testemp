﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Text_Notes
{
    public partial class Create_Text_Notes_Demo : UserControl
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
            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Text_Notes.pdf";
            Document pdfDocument = null;
            try
            {
                string htmlWithLinksAndAttachMarkers = htmlStringTextBox.Text;
                string baseUrl = baseUrlTextBox.Text;

                // Convert a HTML string with markers for file links and attachments to a PDF document object
                pdfDocument = htmlToPdfConverter.ConvertHtmlToPdfDocumentObject(htmlWithLinksAndAttachMarkers, baseUrl);
                
                // Make the HTML element with 'text_note' mapping ID a text note
                HtmlElementMapping textNoteMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("text_note");
                if (textNoteMapping != null)
                {
                    PdfPage textNotePage = textNoteMapping.PdfRectangles[0].PdfPage;
                    RectangleF textNoteRectangle = textNoteMapping.PdfRectangles[0].Rectangle;

                    // Create the text note
                    TextNoteElement textNoteElement = new TextNoteElement(textNoteRectangle, "This is an initially closed text note");
                    textNoteElement.NoteIcon = TextNoteIcon.Note;
                    textNoteElement.Open = false;
                    textNotePage.AddElement(textNoteElement);
                }

                // Make the HTML element with 'text_note_opened' mapping ID an initially opened text note
                HtmlElementMapping textNoteOpenedMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("text_note_opened");
                if (textNoteOpenedMapping != null)
                {
                    PdfPage textNoteOpenedPage = textNoteOpenedMapping.PdfRectangles[0].PdfPage;
                    RectangleF textNoteOpenedRectangle = textNoteOpenedMapping.PdfRectangles[0].Rectangle;

                    // Create the text note
                    TextNoteElement textNoteOpenedElement = new TextNoteElement(textNoteOpenedRectangle, "This is an initially opened text note");
                    textNoteOpenedElement.NoteIcon = TextNoteIcon.Note;
                    textNoteOpenedElement.Open = true;
                    textNoteOpenedPage.AddElement(textNoteOpenedElement);
                }

                // Make the HTML element with 'help_note' mapping ID a help note
                HtmlElementMapping helpNoteMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("help_note");
                if (helpNoteMapping != null)
                {
                    PdfPage helpNotePage = helpNoteMapping.PdfRectangles[0].PdfPage;
                    RectangleF helpNoteRectangle = helpNoteMapping.PdfRectangles[0].Rectangle;

                    // Create the text note
                    TextNoteElement helpNoteElement = new TextNoteElement(helpNoteRectangle, "This is an initially closed help note");
                    helpNoteElement.NoteIcon = TextNoteIcon.Help;
                    helpNoteElement.Open = false;
                    helpNotePage.AddElement(helpNoteElement);
                }

                // Make the HTML element with 'help_note_opened' mapping ID an initially opened help note
                HtmlElementMapping helpNoteOpenedMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("help_note_opened");
                if (helpNoteOpenedMapping != null)
                {
                    PdfPage helpNoteOpenedPage = helpNoteOpenedMapping.PdfRectangles[0].PdfPage;
                    RectangleF helpNoteOpenedRectangle = helpNoteOpenedMapping.PdfRectangles[0].Rectangle;

                    // Create the text note
                    TextNoteElement helpNoteOpenedElement = new TextNoteElement(helpNoteOpenedRectangle, "This is an initially opened help note");
                    helpNoteOpenedElement.NoteIcon = TextNoteIcon.Help;
                    helpNoteOpenedElement.Open = true;
                    helpNoteOpenedPage.AddElement(helpNoteOpenedElement);
                }

                // Make the HTML element with 'comment_note' mapping ID a comment note
                HtmlElementMapping commentNoteMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("comment_note");
                if (commentNoteMapping != null)
                {
                    PdfPage commentNotePage = commentNoteMapping.PdfRectangles[0].PdfPage;
                    RectangleF commentNoteRectangle = commentNoteMapping.PdfRectangles[0].Rectangle;

                    // Create the text note
                    TextNoteElement commentNoteElement = new TextNoteElement(commentNoteRectangle, "This is an initially closed comment note");
                    commentNoteElement.NoteIcon = TextNoteIcon.Comment;
                    commentNoteElement.Open = false;
                    commentNotePage.AddElement(commentNoteElement);
                }

                // Make the HTML element with 'comment_note_opened' mapping ID an initially opened comment note
                HtmlElementMapping commentNoteOpenedMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("comment_note_opened");
                if (commentNoteOpenedMapping != null)
                {
                    PdfPage commentNoteOpenedPage = commentNoteOpenedMapping.PdfRectangles[0].PdfPage;
                    RectangleF commentNoteOpenedRectangle = commentNoteOpenedMapping.PdfRectangles[0].Rectangle;

                    // Create the text note
                    TextNoteElement commentNoteOpenedElement = new TextNoteElement(commentNoteOpenedRectangle, "This is an initially opened comment note");
                    commentNoteOpenedElement.NoteIcon = TextNoteIcon.Comment;
                    commentNoteOpenedElement.Open = true;
                    commentNoteOpenedPage.AddElement(commentNoteOpenedElement);
                }

                // Make the HTML element with 'paragraph_note' mapping ID a paragraph note
                HtmlElementMapping paragraphNoteMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("paragraph_note");
                if (paragraphNoteMapping != null)
                {
                    PdfPage paragraphNotePage = paragraphNoteMapping.PdfRectangles[0].PdfPage;
                    RectangleF paragraphNoteRectangle = paragraphNoteMapping.PdfRectangles[0].Rectangle;

                    // Create the text note
                    TextNoteElement paragraphNoteElement = new TextNoteElement(paragraphNoteRectangle, "This is an initially closed paragraph note");
                    paragraphNoteElement.NoteIcon = TextNoteIcon.Paragraph;
                    paragraphNoteElement.Open = false;
                    paragraphNotePage.AddElement(paragraphNoteElement);
                }

                // Make the HTML element with 'new_paragraph_note' mapping ID a new paragraph note
                HtmlElementMapping newParagraphNoteMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("new_paragraph_note");
                if (newParagraphNoteMapping != null)
                {
                    PdfPage newParagraphNotePage = newParagraphNoteMapping.PdfRectangles[0].PdfPage;
                    RectangleF newParagraphNoteRectangle = newParagraphNoteMapping.PdfRectangles[0].Rectangle;

                    // Create the text note
                    TextNoteElement newParagraphNoteElement = new TextNoteElement(newParagraphNoteRectangle, "This is an initially closed new paragraph note");
                    newParagraphNoteElement.NoteIcon = TextNoteIcon.NewParagraph;
                    newParagraphNoteElement.Open = false;
                    newParagraphNotePage.AddElement(newParagraphNoteElement);
                }

                // Make the HTML element with 'key_note' mapping ID a key note
                HtmlElementMapping keyNoteMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("key_note");
                if (keyNoteMapping != null)
                {
                    PdfPage keyNotePage = keyNoteMapping.PdfRectangles[0].PdfPage;
                    RectangleF keyNoteRectangle = keyNoteMapping.PdfRectangles[0].Rectangle;

                    // Create the text note
                    TextNoteElement keyNoteElement = new TextNoteElement(keyNoteRectangle, "This is an initially closed key note");
                    keyNoteElement.NoteIcon = TextNoteIcon.Key;
                    keyNoteElement.Open = false;
                    keyNotePage.AddElement(keyNoteElement);
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

        private void Create_Text_Notes_Demo_Load(object sender, EventArgs e)
        {
            htmlStringTextBox.Text = System.IO.File.ReadAllText(@"DemoAppFiles\Input\HTML_Files\Text_Notes.html");
            baseUrlTextBox.Text = "file:///" + Application.StartupPath + @"\DemoAppFiles\Input\HTML_Files/";
        }

        public Create_Text_Notes_Demo()
        {
            InitializeComponent();
        }
    }
}

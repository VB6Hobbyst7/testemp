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
    public partial class Text_Notes_Demo : UserControl
    {
        private void createPdfButton_Click(object sender, EventArgs e)
        {
            // Create a PDF document
            Document pdfDocument = new Document();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";
            
            // Add a page to PDF document
            PdfPage pdfPage = pdfDocument.AddPage();

            Cursor = Cursors.WaitCursor;
            string outPdfFile = @"DemoAppFiles\Output\PDF_Creator\Text_Notes.pdf";
            try
            {
                // The titles font used to mark various sections of the PDF document
                PdfFont titleFont = pdfDocument.AddFont(new Font("Times New Roman", 10, FontStyle.Bold, GraphicsUnit.Point));
                PdfFont subtitleFont = pdfDocument.AddFont(new Font("Times New Roman", 8, FontStyle.Regular, GraphicsUnit.Point));

                float xLocation = 5;
                float yLocation = 5;

                // Add document title
                TextElement titleTextElement = new TextElement(xLocation, yLocation, "Add Text Notes to a PDF Document", titleFont);
                AddElementResult addElementResult = pdfPage.AddElement(titleTextElement);

                yLocation = addElementResult.EndPageBounds.Bottom + 15;

                // Add the text element
                string text = "Click the next icon to open the the text note:";
                float textWidth = subtitleFont.GetTextWidth(text);
                TextElement textElement = new TextElement(xLocation, yLocation, text, subtitleFont);
                addElementResult = pdfPage.AddElement(textElement);

                RectangleF textNoteRectangle = new RectangleF(xLocation + textWidth + 1, yLocation, 10, 10);

                // Create the text note
                TextNoteElement textNoteElement = new TextNoteElement(textNoteRectangle, "This is an initially closed text note");
                textNoteElement.NoteIcon = TextNoteIcon.Note;
                textNoteElement.Open = false;
                pdfPage.AddElement(textNoteElement);

                yLocation = addElementResult.EndPageBounds.Bottom + 10;

                // Add the text element
                text = "This is an already opened text note:";
                textWidth = subtitleFont.GetTextWidth(text);
                textElement = new TextElement(xLocation, yLocation, text, subtitleFont);
                addElementResult = pdfPage.AddElement(textElement);

                textNoteRectangle = new RectangleF(xLocation + textWidth + 1, yLocation, 10, 10);

                // Create the text note
                TextNoteElement textNoteOpenedElement = new TextNoteElement(textNoteRectangle, "This is an initially opened text note");
                textNoteOpenedElement.NoteIcon = TextNoteIcon.Note;
                textNoteOpenedElement.Open = true;
                pdfPage.AddElement(textNoteOpenedElement);

                yLocation = addElementResult.EndPageBounds.Bottom + 10;

                // Add the text element
                text = "Click the next icon to open the the help note:";
                textWidth = subtitleFont.GetTextWidth(text);
                textElement = new TextElement(xLocation, yLocation, text, subtitleFont);
                addElementResult = pdfPage.AddElement(textElement);

                textNoteRectangle = new RectangleF(xLocation + textWidth + 1, yLocation, 10, 10);

                // Create the text note
                TextNoteElement helpNoteElement = new TextNoteElement(textNoteRectangle, "This is an initially closed help note");
                helpNoteElement.NoteIcon = TextNoteIcon.Help;
                helpNoteElement.Open = false;
                pdfPage.AddElement(helpNoteElement);

                yLocation = addElementResult.EndPageBounds.Bottom + 10;

                // Add the text element
                text = "This is an already opened help note:";
                textWidth = subtitleFont.GetTextWidth(text);
                textElement = new TextElement(xLocation, yLocation, text, subtitleFont);
                addElementResult = pdfPage.AddElement(textElement);

                textNoteRectangle = new RectangleF(xLocation + textWidth + 1, yLocation, 10, 10);

                // Create the text note
                TextNoteElement helpNoteOpenedElement = new TextNoteElement(textNoteRectangle, "This is an initially opened help note");
                helpNoteOpenedElement.NoteIcon = TextNoteIcon.Help;
                helpNoteOpenedElement.Open = true;
                pdfPage.AddElement(helpNoteOpenedElement);

                yLocation = addElementResult.EndPageBounds.Bottom + 10;

                // Add the text element
                text = "Click the next icon to open the comment:";
                textWidth = subtitleFont.GetTextWidth(text);
                textElement = new TextElement(xLocation, yLocation, text, subtitleFont);
                addElementResult = pdfPage.AddElement(textElement);

                textNoteRectangle = new RectangleF(xLocation + textWidth + 1, yLocation, 10, 10);

                // Create the text note
                TextNoteElement commentNoteElement = new TextNoteElement(textNoteRectangle, "This is an initially closed comment note");
                commentNoteElement.NoteIcon = TextNoteIcon.Comment;
                commentNoteElement.Open = false;
                pdfPage.AddElement(commentNoteElement);

                yLocation = addElementResult.EndPageBounds.Bottom + 10;

                // Add the text element
                text = "This is an already opened comment:";
                textWidth = subtitleFont.GetTextWidth(text);
                textElement = new TextElement(xLocation, yLocation, text, subtitleFont);
                addElementResult = pdfPage.AddElement(textElement);

                textNoteRectangle = new RectangleF(xLocation + textWidth + 1, yLocation, 10, 10);

                // Create the text note
                TextNoteElement commentNoteOpenedElement = new TextNoteElement(textNoteRectangle, "This is an initially opened comment note");
                commentNoteOpenedElement.NoteIcon = TextNoteIcon.Comment;
                commentNoteOpenedElement.Open = true;
                pdfPage.AddElement(commentNoteOpenedElement);

                yLocation = addElementResult.EndPageBounds.Bottom + 10;

                // Add the text element
                text = "Click the next icon to open the paragraph note: ";
                textWidth = subtitleFont.GetTextWidth(text);
                textElement = new TextElement(xLocation, yLocation, text, subtitleFont);
                addElementResult = pdfPage.AddElement(textElement);

                textNoteRectangle = new RectangleF(xLocation + textWidth + 1, yLocation, 10, 10);

                // Create the text note
                TextNoteElement paragraphNoteElement = new TextNoteElement(textNoteRectangle, "This is an initially closed paragraph note");
                paragraphNoteElement.NoteIcon = TextNoteIcon.Paragraph;
                paragraphNoteElement.Open = false;
                pdfPage.AddElement(paragraphNoteElement);

                yLocation = addElementResult.EndPageBounds.Bottom + 10;

                // Add the text element
                text = "Click the next icon to open the new paragraph note:";
                textWidth = subtitleFont.GetTextWidth(text);
                textElement = new TextElement(xLocation, yLocation, text, subtitleFont);
                addElementResult = pdfPage.AddElement(textElement);

                textNoteRectangle = new RectangleF(xLocation + textWidth + 1, yLocation, 10, 10);

                // Create the text note
                TextNoteElement newParagraphNoteElement = new TextNoteElement(textNoteRectangle, "This is an initially closed new paragraph note");
                newParagraphNoteElement.NoteIcon = TextNoteIcon.NewParagraph;
                newParagraphNoteElement.Open = false;
                pdfPage.AddElement(newParagraphNoteElement);

                yLocation = addElementResult.EndPageBounds.Bottom + 10;

                // Add the text element
                text = "Click the next icon to open the key note:";
                textWidth = subtitleFont.GetTextWidth(text);
                textElement = new TextElement(xLocation, yLocation, text, subtitleFont);
                addElementResult = pdfPage.AddElement(textElement);

                textNoteRectangle = new RectangleF(xLocation + textWidth + 1, yLocation, 10, 10);

                // Create the text note
                TextNoteElement keyNoteElement = new TextNoteElement(textNoteRectangle, "This is an initially closed key note");
                keyNoteElement.NoteIcon = TextNoteIcon.Key;
                keyNoteElement.Open = false;
                pdfPage.AddElement(keyNoteElement);

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

        public Text_Notes_Demo()
        {
            InitializeComponent();
        }
    }
}

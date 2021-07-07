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
    public partial class Create_PDF_Documents_Demo : UserControl
    {
        private void createPdfButton_Click(object sender, EventArgs e)
        {
            // Get the PDF Standard
            // By default the Full PDF standard is used
            PdfStandardSubset pdfStandard = PdfStandardSubset.Full;
            if (pdfARadioButton.Checked)
                pdfStandard = PdfStandardSubset.Pdf_A_1b;
            else if (pdfXRadioButton.Checked)
                pdfStandard = PdfStandardSubset.Pdf_X_1a;

            // Get the Color Space
            // By default the RGB color space is used
            ColorSpace pdfColorSpace = ColorSpace.RGB;
            if (grayScaleRadioButton.Checked)
                pdfColorSpace = ColorSpace.Gray;
            else if (cmykRadioButton.Checked)
                pdfColorSpace = ColorSpace.CMYK;

            // Create the PDF document
            Document pdfDocument = null;

            if (pdfStandard == PdfStandardSubset.Full && pdfColorSpace == ColorSpace.RGB)
            {
                // Create a PDF document with default standard and color space
                pdfDocument = new Document();
            }
            else
            {
                // Create a PDF document with the selected standard and color space
                pdfDocument = new Document(pdfStandard, pdfColorSpace);
            }

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            // Get the selected PDF page size
            PdfPageSize pdfPageSize = SelectedPdfPageSize();

            // Get the selected PDF page orientation
            PdfPageOrientation pdfPageOrientation = SelectedPdfPageOrientation();

            // Get the PDF page margins
            Margins pdfPageMargins = new Margins(float.Parse(leftMarginTextBox.Text), float.Parse(rightMarginTextBox.Text),
                    float.Parse(topMarginTextBox.Text), float.Parse(bottomMarginTextBox.Text));

            // Create a PDF page in PDF document
            PdfPage firstPdfPage = pdfDocument.AddPage(pdfPageSize, pdfPageMargins, pdfPageOrientation);
            
            Cursor = Cursors.WaitCursor;

            // The output PDF file
            string outPdfFile = @"DemoAppFiles\Output\PDF_Creator\Create_PDF_Documents.pdf";
            try
            {
                // The URL of the HTML page to convert to PDF
                string urlToConvert = "http://www.evopdf.com";

                // Create the HTML to PDF element
                HtmlToPdfElement htmlToPdfElement = new HtmlToPdfElement(urlToConvert);

                // Optionally set a delay before conversion to allow asynchonous scripts to finish
                htmlToPdfElement.ConversionDelay = 2;

                // Add the HTML to PDF element to PDF document
                firstPdfPage.AddElement(htmlToPdfElement);

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

        private PdfPageSize SelectedPdfPageSize()
        {
            switch (pdfPageSizeComboBox.SelectedItem.ToString())
            {
                case "A0":
                    return PdfPageSize.A0;
                case "A1":
                    return PdfPageSize.A1;
                case "A10":
                    return PdfPageSize.A10;
                case "A2":
                    return PdfPageSize.A2;
                case "A3":
                    return PdfPageSize.A3;
                case "A4":
                    return PdfPageSize.A4;
                case "A5":
                    return PdfPageSize.A5;
                case "A6":
                    return PdfPageSize.A6;
                case "A7":
                    return PdfPageSize.A7;
                case "A8":
                    return PdfPageSize.A8;
                case "A9":
                    return PdfPageSize.A9;
                case "ArchA":
                    return PdfPageSize.ArchA;
                case "ArchB":
                    return PdfPageSize.ArchB;
                case "ArchC":
                    return PdfPageSize.ArchC;
                case "ArchD":
                    return PdfPageSize.ArchD;
                case "ArchE":
                    return PdfPageSize.ArchE;
                case "B0":
                    return PdfPageSize.B0;
                case "B1":
                    return PdfPageSize.B1;
                case "B2":
                    return PdfPageSize.B2;
                case "B3":
                    return PdfPageSize.B3;
                case "B4":
                    return PdfPageSize.B4;
                case "B5":
                    return PdfPageSize.B5;
                case "Flsa":
                    return PdfPageSize.Flsa;
                case "HalfLetter":
                    return PdfPageSize.HalfLetter;
                case "Ledger":
                    return PdfPageSize.Ledger;
                case "Legal":
                    return PdfPageSize.Legal;
                case "Letter":
                    return PdfPageSize.Letter;
                case "Letter11x17":
                    return PdfPageSize.Letter11x17;
                case "Note":
                    return PdfPageSize.Note;
                default:
                    return PdfPageSize.A4;
            }
        }

        private PdfPageOrientation SelectedPdfPageOrientation()
        {
            return (pdfPageOrientationComboBox.SelectedItem.ToString() == "Portrait") ?
                PdfPageOrientation.Portrait : PdfPageOrientation.Landscape;
        }

        private void Create_PDF_Documents_Demo_Load(object sender, EventArgs e)
        {
            pdfPageSizeComboBox.SelectedItem = "A4";
            pdfPageOrientationComboBox.SelectedItem = "Portrait";
        }

        public Create_PDF_Documents_Demo()
        {
            InitializeComponent();
        }
    }
}

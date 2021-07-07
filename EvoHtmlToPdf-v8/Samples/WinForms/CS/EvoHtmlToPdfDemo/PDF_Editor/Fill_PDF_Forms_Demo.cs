using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.PDF_Editor
{
    public partial class Fill_PDF_Forms_Demo : UserControl
    {
        // The PDF document with a form to fill
        string pdfFileWithForm = @"DemoAppFiles\Input\PDF_Files\Fill_PDF_Forms.pdf";

        private void fillPdfButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            string outPdfFile = @"DemoAppFiles\Output\PDF_Editor\Filled_PDF_Form.pdf";
            Document pdfDocument = null;
            try
            {
                // Load the PDF document with a form to fill
                pdfDocument = new Document(pdfFileWithForm);

                // Set license key received after purchase to use the converter in licensed mode
                // Leave it not set to use the converter in demo mode
                pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

                // Get the First Name text box field by name from PDF form fields collection and fill a text value
                PdfFormField firstNameTextBoxField = pdfDocument.Form.Fields["firstName"];
                if (firstNameTextBoxField != null)
                    firstNameTextBoxField.Value = firstNameTextBox.Text;

                // Get the Last Name text box field by name from PDF form fields collection and fill a text value
                PdfFormField lastNameTextBoxField = pdfDocument.Form.Fields["lastName"];
                if (lastNameTextBoxField != null)
                    lastNameTextBoxField.Value = lastNameTextBox.Text;

                // Get the Password text box field by name from PDF form fields collection and fill a text value
                PdfFormField passwordTextBoxField = pdfDocument.Form.Fields["password"];
                if (passwordTextBoxField != null)
                    passwordTextBoxField.Value = passwordTextBox.Text;

                // Get the Gender radio buttons group field by name from form fields collection and set the selected value
                PdfFormField genderRadioGroupField = pdfDocument.Form.Fields["gender"];
                if (genderRadioGroupField != null)
                    genderRadioGroupField.Value = maleRadioButton.Checked ? "male" : "female";

                // Get the 'I have a car' check box field by name from form fields collection and set the checked status
                PdfFormField haveCarCheckBoxField = pdfDocument.Form.Fields["haveCar"];
                if (haveCarCheckBoxField != null)
                    haveCarCheckBoxField.Value = haveCarCheckBox.Checked;

                // Get the 'Vehicle Type' combo box field by name from form fields collection and set the selected value
                PdfFormField vehicleTypeComboBoxField = pdfDocument.Form.Fields["vehicleType"];
                if (vehicleTypeComboBoxField != null)
                    vehicleTypeComboBoxField.Value = carTypeComboBox.SelectedItem;

                // Get the Comments multi line text box field by name from PDF form fields collection and fill a text value
                PdfFormField commentsTextBoxField = pdfDocument.Form.Fields["comments"];
                if (commentsTextBoxField != null)
                    commentsTextBoxField.Value = commentsTextBox.Text;

                // Flatten PDF form fields if this was requested
                if (flattenPdfFormCheckBox.Checked)
                    pdfDocument.Form.FlattenFields();

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
                // Close the document to stamp
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

        private void openInitialLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(pdfFileWithForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", pdfFileWithForm, ex.Message));
            }
        }

        private void Fill_PDF_Forms_Demo_Load(object sender, EventArgs e)
        {
            carTypeComboBox.SelectedItem = "Volvo";
        }

        public Fill_PDF_Forms_Demo()
        {
            InitializeComponent();
        }
    }
}

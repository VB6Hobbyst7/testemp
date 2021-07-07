Namespace EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers
	Partial Public Class Header_Footer_In_External_PDF_Demo
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.convertButtonPanel = New Panel()
			Me.createPdfButton = New Button()
			Me.urlPanel = New Panel()
			Me.addHeaderFooterInAppendedPdfCheckBox = New CheckBox()
			Me.showFooterInFirstPageCheckBox = New CheckBox()
			Me.showHeaderInFirstPageCheckBox = New CheckBox()
			Me.addHeaderFooterInInsertedPdfCheckBox = New CheckBox()
			Me.label2 = New Label()
			Me.label6 = New Label()
			Me.enterUrlLabel = New Label()
			Me.pdfAfterTextBox = New TextBox()
			Me.pdfBeforeTextBox = New TextBox()
			Me.urlTextBox = New TextBox()
			Me.descriptionPanel = New Panel()
			Me.descriptionLabel = New Label()
			Me.titlePanel = New Panel()
			Me.titleLabel = New Label()
			Me.convertButtonPanel.SuspendLayout()
			Me.urlPanel.SuspendLayout()
			Me.descriptionPanel.SuspendLayout()
			Me.titlePanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' demoLeftPanel
			' 
			Me.demoLeftPanel.Dock = DockStyle.Left
			Me.demoLeftPanel.Location = New Point(0, 6)
			Me.demoLeftPanel.Name = "demoLeftPanel"
			Me.demoLeftPanel.Size = New Size(6, 638)
			Me.demoLeftPanel.TabIndex = 19
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 18
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 644)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 17
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 16
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.createPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 366)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 42)
			Me.convertButtonPanel.TabIndex = 107
			' 
			' createPdfButton
			' 
			Me.createPdfButton.Location = New Point(9, 6)
			Me.createPdfButton.Name = "createPdfButton"
			Me.createPdfButton.Size = New Size(160, 27)
			Me.createPdfButton.TabIndex = 66
			Me.createPdfButton.Text = "Create PDF Document"
			Me.createPdfButton.UseVisualStyleBackColor = True
'			Me.createPdfButton.Click += New System.EventHandler(Me.createPdfButton_Click)
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.addHeaderFooterInAppendedPdfCheckBox)
			Me.urlPanel.Controls.Add(Me.showFooterInFirstPageCheckBox)
			Me.urlPanel.Controls.Add(Me.showHeaderInFirstPageCheckBox)
			Me.urlPanel.Controls.Add(Me.addHeaderFooterInInsertedPdfCheckBox)
			Me.urlPanel.Controls.Add(Me.label2)
			Me.urlPanel.Controls.Add(Me.label6)
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.pdfAfterTextBox)
			Me.urlPanel.Controls.Add(Me.pdfBeforeTextBox)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 97)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 269)
			Me.urlPanel.TabIndex = 106
			' 
			' addHeaderFooterInAppendedPdfCheckBox
			' 
			Me.addHeaderFooterInAppendedPdfCheckBox.AutoSize = True
			Me.addHeaderFooterInAppendedPdfCheckBox.Checked = True
			Me.addHeaderFooterInAppendedPdfCheckBox.CheckState = CheckState.Checked
			Me.addHeaderFooterInAppendedPdfCheckBox.Location = New Point(9, 242)
			Me.addHeaderFooterInAppendedPdfCheckBox.Name = "addHeaderFooterInAppendedPdfCheckBox"
			Me.addHeaderFooterInAppendedPdfCheckBox.Size = New Size(319, 21)
			Me.addHeaderFooterInAppendedPdfCheckBox.TabIndex = 0
			Me.addHeaderFooterInAppendedPdfCheckBox.Text = "Add Header and Footer in Appended PDF Document"
			Me.addHeaderFooterInAppendedPdfCheckBox.UseVisualStyleBackColor = True
			' 
			' showFooterInFirstPageCheckBox
			' 
			Me.showFooterInFirstPageCheckBox.AutoSize = True
			Me.showFooterInFirstPageCheckBox.Checked = True
			Me.showFooterInFirstPageCheckBox.CheckState = CheckState.Checked
			Me.showFooterInFirstPageCheckBox.Location = New Point(214, 145)
			Me.showFooterInFirstPageCheckBox.Name = "showFooterInFirstPageCheckBox"
			Me.showFooterInFirstPageCheckBox.Size = New Size(173, 21)
			Me.showFooterInFirstPageCheckBox.TabIndex = 0
			Me.showFooterInFirstPageCheckBox.Text = "Show Footer in First Page"
			Me.showFooterInFirstPageCheckBox.UseVisualStyleBackColor = True
			' 
			' showHeaderInFirstPageCheckBox
			' 
			Me.showHeaderInFirstPageCheckBox.AutoSize = True
			Me.showHeaderInFirstPageCheckBox.Checked = True
			Me.showHeaderInFirstPageCheckBox.CheckState = CheckState.Checked
			Me.showHeaderInFirstPageCheckBox.Location = New Point(9, 145)
			Me.showHeaderInFirstPageCheckBox.Name = "showHeaderInFirstPageCheckBox"
			Me.showHeaderInFirstPageCheckBox.Size = New Size(179, 21)
			Me.showHeaderInFirstPageCheckBox.TabIndex = 0
			Me.showHeaderInFirstPageCheckBox.Text = "Show Header in First Page"
			Me.showHeaderInFirstPageCheckBox.UseVisualStyleBackColor = True
			' 
			' addHeaderFooterInInsertedPdfCheckBox
			' 
			Me.addHeaderFooterInInsertedPdfCheckBox.AutoSize = True
			Me.addHeaderFooterInInsertedPdfCheckBox.Checked = True
			Me.addHeaderFooterInInsertedPdfCheckBox.CheckState = CheckState.Checked
			Me.addHeaderFooterInInsertedPdfCheckBox.Location = New Point(9, 120)
			Me.addHeaderFooterInInsertedPdfCheckBox.Name = "addHeaderFooterInInsertedPdfCheckBox"
			Me.addHeaderFooterInInsertedPdfCheckBox.Size = New Size(307, 21)
			Me.addHeaderFooterInInsertedPdfCheckBox.TabIndex = 0
			Me.addHeaderFooterInInsertedPdfCheckBox.Text = "Add Header and Footer in Inserted PDF Document"
			Me.addHeaderFooterInInsertedPdfCheckBox.UseVisualStyleBackColor = True
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label2.Location = New Point(6, 185)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(214, 15)
			Me.label2.TabIndex = 44
			Me.label2.Text = "PDF File to Add After Conversion"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label6.Location = New Point(6, 64)
			Me.label6.Name = "label6"
			Me.label6.Size = New Size(239, 15)
			Me.label6.TabIndex = 43
			Me.label6.Text = "PDF File to Insert Before Conversion"
			' 
			' enterUrlLabel
			' 
			Me.enterUrlLabel.AutoSize = True
			Me.enterUrlLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.enterUrlLabel.Location = New Point(6, 3)
			Me.enterUrlLabel.Name = "enterUrlLabel"
			Me.enterUrlLabel.Size = New Size(182, 15)
			Me.enterUrlLabel.TabIndex = 42
			Me.enterUrlLabel.Text = "HTML Page to Convert URL"
			' 
			' pdfAfterTextBox
			' 
			Me.pdfAfterTextBox.Location = New Point(9, 211)
			Me.pdfAfterTextBox.Name = "pdfAfterTextBox"
			Me.pdfAfterTextBox.Size = New Size(574, 21)
			Me.pdfAfterTextBox.TabIndex = 47
			' 
			' pdfBeforeTextBox
			' 
			Me.pdfBeforeTextBox.Location = New Point(9, 89)
			Me.pdfBeforeTextBox.Name = "pdfBeforeTextBox"
			Me.pdfBeforeTextBox.Size = New Size(574, 21)
			Me.pdfBeforeTextBox.TabIndex = 46
			' 
			' urlTextBox
			' 
			Me.urlTextBox.Location = New Point(8, 24)
			Me.urlTextBox.Name = "urlTextBox"
			Me.urlTextBox.Size = New Size(574, 21)
			Me.urlTextBox.TabIndex = 45
            Me.urlTextBox.Text = "http://www.evopdf.com/DemoAppFiles/HTML_Files/Structured_HTML.html"
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 51)
			Me.descriptionPanel.TabIndex = 105
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 51)
			Me.descriptionLabel.TabIndex = 0
			Me.descriptionLabel.Text = "EVO HTML to PDF Converter allows you to apply headers and footers on the external" & " PDF documents added to a PDF document. The Full Description and a Code Sample c" & "an be accessed from the top tabs."
			' 
			' titlePanel
			' 
			Me.titlePanel.Controls.Add(Me.titleLabel)
			Me.titlePanel.Dock = DockStyle.Top
			Me.titlePanel.Location = New Point(6, 6)
			Me.titlePanel.Name = "titlePanel"
			Me.titlePanel.Size = New Size(598, 40)
			Me.titlePanel.TabIndex = 104
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(380, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Add Header and Footer In External PDF Documents"
			' 
			' Header_Footer_In_External_PDF_Demo
			' 
			Me.AutoScaleDimensions = New SizeF(7F, 15F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScroll = True
			Me.Controls.Add(Me.convertButtonPanel)
			Me.Controls.Add(Me.urlPanel)
			Me.Controls.Add(Me.descriptionPanel)
			Me.Controls.Add(Me.titlePanel)
			Me.Controls.Add(Me.demoLeftPanel)
			Me.Controls.Add(Me.demoRightPanel)
			Me.Controls.Add(Me.demoBottomPanel)
			Me.Controls.Add(Me.demoTopPanel)
			Me.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.Name = "Header_Footer_In_External_PDF_Demo"
			Me.Size = New Size(610, 650)
'			Me.Load += New System.EventHandler(Me.Header_Footer_In_External_PDF_Demo_Load)
			Me.convertButtonPanel.ResumeLayout(False)
			Me.urlPanel.ResumeLayout(False)
			Me.urlPanel.PerformLayout()
			Me.descriptionPanel.ResumeLayout(False)
			Me.titlePanel.ResumeLayout(False)
			Me.titlePanel.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private demoLeftPanel As Panel
		Private demoRightPanel As Panel
		Private demoBottomPanel As Panel
		Private demoTopPanel As Panel
		Private convertButtonPanel As Panel
		Private WithEvents createPdfButton As Button
		Private urlPanel As Panel
		Private addHeaderFooterInAppendedPdfCheckBox As CheckBox
		Private showFooterInFirstPageCheckBox As CheckBox
		Private showHeaderInFirstPageCheckBox As CheckBox
		Private addHeaderFooterInInsertedPdfCheckBox As CheckBox
		Private label2 As Label
		Private label6 As Label
		Private enterUrlLabel As Label
		Private pdfAfterTextBox As TextBox
		Private pdfBeforeTextBox As TextBox
		Private urlTextBox As TextBox
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
	End Class
End Namespace

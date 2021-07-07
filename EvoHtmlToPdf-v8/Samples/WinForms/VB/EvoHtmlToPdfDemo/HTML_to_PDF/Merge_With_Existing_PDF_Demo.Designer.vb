Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class Merge_With_Existing_PDF_Demo
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
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.convertButtonPanel = New Panel()
			Me.convertToPdfButton = New Button()
			Me.urlPanel = New Panel()
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
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 644)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 6
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 5
			' 
			' demoLeftPanel
			' 
			Me.demoLeftPanel.Dock = DockStyle.Left
			Me.demoLeftPanel.Location = New Point(0, 6)
			Me.demoLeftPanel.Name = "demoLeftPanel"
			Me.demoLeftPanel.Size = New Size(6, 638)
			Me.demoLeftPanel.TabIndex = 9
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 8
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 297)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 43)
			Me.convertButtonPanel.TabIndex = 90
			' 
			' convertToPdfButton
			' 
			Me.convertToPdfButton.Location = New Point(6, 6)
			Me.convertToPdfButton.Name = "convertToPdfButton"
			Me.convertToPdfButton.Size = New Size(150, 27)
			Me.convertToPdfButton.TabIndex = 66
			Me.convertToPdfButton.Text = "Convert HTML to PDF"
			Me.convertToPdfButton.UseVisualStyleBackColor = True
'			Me.convertToPdfButton.Click += New System.EventHandler(Me.convertToPdfButton_Click)
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.label2)
			Me.urlPanel.Controls.Add(Me.label6)
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.pdfAfterTextBox)
			Me.urlPanel.Controls.Add(Me.pdfBeforeTextBox)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 101)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 196)
			Me.urlPanel.TabIndex = 88
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label2.Location = New Point(3, 138)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(235, 16)
			Me.label2.TabIndex = 40
			Me.label2.Text = "PDF File to Add After Conversion"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label6.Location = New Point(3, 74)
			Me.label6.Name = "label6"
			Me.label6.Size = New Size(259, 16)
			Me.label6.TabIndex = 40
			Me.label6.Text = "PDF File to Insert Before Conversion"
			' 
			' enterUrlLabel
			' 
			Me.enterUrlLabel.AutoSize = True
			Me.enterUrlLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.enterUrlLabel.Location = New Point(3, 13)
			Me.enterUrlLabel.Name = "enterUrlLabel"
			Me.enterUrlLabel.Size = New Size(198, 16)
			Me.enterUrlLabel.TabIndex = 40
			Me.enterUrlLabel.Text = "HTML Page to Convert URL"
			' 
			' pdfAfterTextBox
			' 
			Me.pdfAfterTextBox.Location = New Point(5, 159)
			Me.pdfAfterTextBox.Name = "pdfAfterTextBox"
			Me.pdfAfterTextBox.Size = New Size(574, 21)
			Me.pdfAfterTextBox.TabIndex = 41
			' 
			' pdfBeforeTextBox
			' 
			Me.pdfBeforeTextBox.Location = New Point(5, 95)
			Me.pdfBeforeTextBox.Name = "pdfBeforeTextBox"
			Me.pdfBeforeTextBox.Size = New Size(574, 21)
			Me.pdfBeforeTextBox.TabIndex = 41
			' 
			' urlTextBox
			' 
			Me.urlTextBox.Location = New Point(5, 34)
			Me.urlTextBox.Name = "urlTextBox"
			Me.urlTextBox.Size = New Size(574, 21)
			Me.urlTextBox.TabIndex = 41
			Me.urlTextBox.Text = "http://www.evopdf.com"
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 55)
			Me.descriptionPanel.TabIndex = 87
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 55)
			Me.descriptionLabel.TabIndex = 0
			Me.descriptionLabel.Text = "EVO HTML to PDF Converter allows you to add existing PDF documents before and aft" & "er the HTML to PDF conversion result. The Full Description and a Code Sample can" & " be accessed from the top tabs."
			' 
			' titlePanel
			' 
			Me.titlePanel.Controls.Add(Me.titleLabel)
			Me.titlePanel.Dock = DockStyle.Top
			Me.titlePanel.Location = New Point(6, 6)
			Me.titlePanel.Name = "titlePanel"
			Me.titlePanel.Size = New Size(598, 40)
			Me.titlePanel.TabIndex = 85
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(345, 18)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Merge Conversion Result with Existing PDFs"
			' 
			' Merge_With_Existing_PDF_Demo
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
			Me.Name = "Merge_With_Existing_PDF_Demo"
			Me.Size = New Size(610, 650)
'			Me.Load += New System.EventHandler(Me.Merge_With_Existing_PDF_Demo_Load)
			Me.convertButtonPanel.ResumeLayout(False)
			Me.urlPanel.ResumeLayout(False)
			Me.urlPanel.PerformLayout()
			Me.descriptionPanel.ResumeLayout(False)
			Me.titlePanel.ResumeLayout(False)
			Me.titlePanel.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private demoBottomPanel As Panel
		Private demoTopPanel As Panel
		Private demoLeftPanel As Panel
		Private demoRightPanel As Panel
		Private convertButtonPanel As Panel
		Private WithEvents convertToPdfButton As Button
		Private urlPanel As Panel
		Private label6 As Label
		Private enterUrlLabel As Label
		Private pdfBeforeTextBox As TextBox
		Private urlTextBox As TextBox
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
		Private label2 As Label
		Private pdfAfterTextBox As TextBox
	End Class
End Namespace

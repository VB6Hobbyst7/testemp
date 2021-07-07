Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Standards
	Partial Public Class Create_PDF_A_and_PDF_X_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Create_PDF_A_and_PDF_X_Demo))
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.convertButtonPanel = New Panel()
			Me.convertToPdfButton = New Button()
			Me.settingsPanel = New Panel()
			Me.pdfXRadioButton = New RadioButton()
			Me.pdfARadioButton = New RadioButton()
			Me.fullPdfRadioButton = New RadioButton()
			Me.label2 = New Label()
			Me.urlPanel = New Panel()
			Me.enterUrlLabel = New Label()
			Me.urlTextBox = New TextBox()
			Me.descriptionPanel = New Panel()
			Me.descriptionLabel = New Label()
			Me.titlePanel = New Panel()
			Me.titleLabel = New Label()
			Me.convertButtonPanel.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
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
			Me.demoLeftPanel.TabIndex = 147
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 146
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 644)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 145
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 144
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 232)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 43)
			Me.convertButtonPanel.TabIndex = 168
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
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.pdfXRadioButton)
			Me.settingsPanel.Controls.Add(Me.pdfARadioButton)
			Me.settingsPanel.Controls.Add(Me.fullPdfRadioButton)
			Me.settingsPanel.Controls.Add(Me.label2)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 169)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 63)
			Me.settingsPanel.TabIndex = 167
			' 
			' pdfXRadioButton
			' 
			Me.pdfXRadioButton.AutoSize = True
			Me.pdfXRadioButton.Location = New Point(205, 32)
			Me.pdfXRadioButton.Name = "pdfXRadioButton"
			Me.pdfXRadioButton.Size = New Size(85, 20)
			Me.pdfXRadioButton.TabIndex = 54
			Me.pdfXRadioButton.Text = "PDF/X-1a"
			Me.pdfXRadioButton.UseVisualStyleBackColor = True
			' 
			' pdfARadioButton
			' 
			Me.pdfARadioButton.AutoSize = True
			Me.pdfARadioButton.Location = New Point(109, 32)
			Me.pdfARadioButton.Name = "pdfARadioButton"
			Me.pdfARadioButton.Size = New Size(84, 20)
			Me.pdfARadioButton.TabIndex = 54
			Me.pdfARadioButton.Text = "PDF/A-1b"
			Me.pdfARadioButton.UseVisualStyleBackColor = True
			' 
			' fullPdfRadioButton
			' 
			Me.fullPdfRadioButton.AutoSize = True
			Me.fullPdfRadioButton.Checked = True
			Me.fullPdfRadioButton.Location = New Point(21, 32)
			Me.fullPdfRadioButton.Name = "fullPdfRadioButton"
			Me.fullPdfRadioButton.Size = New Size(79, 20)
			Me.fullPdfRadioButton.TabIndex = 54
			Me.fullPdfRadioButton.TabStop = True
			Me.fullPdfRadioButton.Text = "Full PDF"
			Me.fullPdfRadioButton.UseVisualStyleBackColor = True
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label2.Location = New Point(3, 3)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(96, 15)
			Me.label2.TabIndex = 53
			Me.label2.Text = "PDF Standard"
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 99)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 70)
			Me.urlPanel.TabIndex = 166
			' 
			' enterUrlLabel
			' 
			Me.enterUrlLabel.AutoSize = True
			Me.enterUrlLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.enterUrlLabel.Location = New Point(3, 7)
			Me.enterUrlLabel.Name = "enterUrlLabel"
			Me.enterUrlLabel.Size = New Size(266, 15)
			Me.enterUrlLabel.TabIndex = 50
			Me.enterUrlLabel.Text = "HTML Page URL or Local File to Convert"
			' 
			' urlTextBox
			' 
			Me.urlTextBox.Location = New Point(6, 36)
			Me.urlTextBox.Name = "urlTextBox"
			Me.urlTextBox.Size = New Size(576, 21)
			Me.urlTextBox.TabIndex = 51
			Me.urlTextBox.Text = "http://www.evopdf.com"
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 53)
			Me.descriptionPanel.TabIndex = 165
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 53)
			Me.descriptionLabel.TabIndex = 0
			Me.descriptionLabel.Text = resources.GetString("descriptionLabel.Text")
			' 
			' titlePanel
			' 
			Me.titlePanel.Controls.Add(Me.titleLabel)
			Me.titlePanel.Dock = DockStyle.Top
			Me.titlePanel.Location = New Point(6, 6)
			Me.titlePanel.Name = "titlePanel"
			Me.titlePanel.Size = New Size(598, 40)
			Me.titlePanel.TabIndex = 164
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(347, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Convert HTML to PDF/A and PDF/X Documents"
			' 
			' Create_PDF_A_and_PDF_X_Demo
			' 
			Me.AutoScaleDimensions = New SizeF(7F, 15F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScroll = True
			Me.Controls.Add(Me.convertButtonPanel)
			Me.Controls.Add(Me.settingsPanel)
			Me.Controls.Add(Me.urlPanel)
			Me.Controls.Add(Me.descriptionPanel)
			Me.Controls.Add(Me.titlePanel)
			Me.Controls.Add(Me.demoLeftPanel)
			Me.Controls.Add(Me.demoRightPanel)
			Me.Controls.Add(Me.demoBottomPanel)
			Me.Controls.Add(Me.demoTopPanel)
			Me.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.Name = "Create_PDF_A_and_PDF_X_Demo"
			Me.Size = New Size(610, 650)
			Me.convertButtonPanel.ResumeLayout(False)
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
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
		Private WithEvents convertToPdfButton As Button
		Private settingsPanel As Panel
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
		Private pdfXRadioButton As RadioButton
		Private pdfARadioButton As RadioButton
		Private fullPdfRadioButton As RadioButton
		Private label2 As Label
	End Class
End Namespace

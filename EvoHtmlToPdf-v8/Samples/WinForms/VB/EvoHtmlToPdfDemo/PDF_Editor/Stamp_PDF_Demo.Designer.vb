Namespace EvoHtmlToPdfDemo.PDF_Editor
	Partial Public Class Stamp_PDF_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Stamp_PDF_Demo))
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.urlPanel = New Panel()
			Me.selectFileButton = New Button()
			Me.pdfFilePathTextBox = New TextBox()
			Me.enterUrlLabel = New Label()
			Me.descriptionPanel = New Panel()
			Me.descriptionLabel = New Label()
			Me.titlePanel = New Panel()
			Me.titleLabel = New Label()
			Me.settingsPanel = New Panel()
			Me.label31 = New Label()
			Me.label23 = New Label()
			Me.label30 = New Label()
			Me.label26 = New Label()
			Me.stampHeightTextBox = New TextBox()
			Me.stampWidthTextBox = New TextBox()
			Me.label2 = New Label()
			Me.baseUrlTextBox = New TextBox()
			Me.htmlStringTextBox = New TextBox()
			Me.label12 = New Label()
			Me.label5 = New Label()
			Me.convertButtonPanel = New Panel()
			Me.stampPdfButton = New Button()
			Me.urlPanel.SuspendLayout()
			Me.descriptionPanel.SuspendLayout()
			Me.titlePanel.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			Me.convertButtonPanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' demoLeftPanel
			' 
			Me.demoLeftPanel.Dock = DockStyle.Left
			Me.demoLeftPanel.Location = New Point(0, 6)
			Me.demoLeftPanel.Name = "demoLeftPanel"
			Me.demoLeftPanel.Size = New Size(6, 671)
			Me.demoLeftPanel.TabIndex = 135
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 671)
			Me.demoRightPanel.TabIndex = 134
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 677)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 133
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 132
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.selectFileButton)
			Me.urlPanel.Controls.Add(Me.pdfFilePathTextBox)
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 98)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 73)
			Me.urlPanel.TabIndex = 143
			' 
			' selectFileButton
			' 
			Me.selectFileButton.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.selectFileButton.Location = New Point(516, 37)
			Me.selectFileButton.Name = "selectFileButton"
			Me.selectFileButton.Size = New Size(66, 26)
			Me.selectFileButton.TabIndex = 44
			Me.selectFileButton.Text = "Browse"
			Me.selectFileButton.UseVisualStyleBackColor = True
'			Me.selectFileButton.Click += New System.EventHandler(Me.selectFileButton_Click)
			' 
			' pdfFilePathTextBox
			' 
			Me.pdfFilePathTextBox.Location = New Point(9, 40)
			Me.pdfFilePathTextBox.Name = "pdfFilePathTextBox"
			Me.pdfFilePathTextBox.Size = New Size(501, 21)
			Me.pdfFilePathTextBox.TabIndex = 43
			' 
			' enterUrlLabel
			' 
			Me.enterUrlLabel.AutoSize = True
			Me.enterUrlLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.enterUrlLabel.Location = New Point(6, 13)
			Me.enterUrlLabel.Name = "enterUrlLabel"
			Me.enterUrlLabel.Size = New Size(192, 15)
			Me.enterUrlLabel.TabIndex = 42
			Me.enterUrlLabel.Text = "The PDF Document to Stamp"
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 52)
			Me.descriptionPanel.TabIndex = 142
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 52)
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
			Me.titlePanel.TabIndex = 141
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(173, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Stamp PDF Documents"
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.label31)
			Me.settingsPanel.Controls.Add(Me.label23)
			Me.settingsPanel.Controls.Add(Me.label30)
			Me.settingsPanel.Controls.Add(Me.label26)
			Me.settingsPanel.Controls.Add(Me.stampHeightTextBox)
			Me.settingsPanel.Controls.Add(Me.stampWidthTextBox)
			Me.settingsPanel.Controls.Add(Me.label2)
			Me.settingsPanel.Controls.Add(Me.baseUrlTextBox)
			Me.settingsPanel.Controls.Add(Me.htmlStringTextBox)
			Me.settingsPanel.Controls.Add(Me.label12)
			Me.settingsPanel.Controls.Add(Me.label5)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 171)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 447)
			Me.settingsPanel.TabIndex = 145
			' 
			' label31
			' 
			Me.label31.AutoSize = True
			Me.label31.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label31.Location = New Point(254, 41)
			Me.label31.Name = "label31"
			Me.label31.Size = New Size(17, 15)
			Me.label31.TabIndex = 128
			Me.label31.Text = "pt"
			' 
			' label23
			' 
			Me.label23.AutoSize = True
			Me.label23.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label23.Location = New Point(120, 41)
			Me.label23.Name = "label23"
			Me.label23.Size = New Size(17, 15)
			Me.label23.TabIndex = 127
			Me.label23.Text = "pt"
			' 
			' label30
			' 
			Me.label30.AutoSize = True
			Me.label30.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label30.Location = New Point(152, 41)
			Me.label30.Name = "label30"
			Me.label30.Size = New Size(46, 15)
			Me.label30.TabIndex = 125
			Me.label30.Text = "Height:"
			' 
			' label26
			' 
			Me.label26.AutoSize = True
			Me.label26.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label26.Location = New Point(25, 41)
			Me.label26.Name = "label26"
			Me.label26.Size = New Size(41, 15)
			Me.label26.TabIndex = 126
			Me.label26.Text = "Width:"
			' 
			' stampHeightTextBox
			' 
			Me.stampHeightTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.stampHeightTextBox.Location = New Point(203, 38)
			Me.stampHeightTextBox.Name = "stampHeightTextBox"
			Me.stampHeightTextBox.Size = New Size(45, 21)
			Me.stampHeightTextBox.TabIndex = 121
			Me.stampHeightTextBox.Text = "400"
			' 
			' stampWidthTextBox
			' 
			Me.stampWidthTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.stampWidthTextBox.Location = New Point(70, 38)
			Me.stampWidthTextBox.Name = "stampWidthTextBox"
			Me.stampWidthTextBox.Size = New Size(45, 21)
			Me.stampWidthTextBox.TabIndex = 122
			Me.stampWidthTextBox.Text = "400"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label2.Location = New Point(6, 393)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(71, 15)
			Me.label2.TabIndex = 52
			Me.label2.Text = "Base URL"
			' 
			' baseUrlTextBox
			' 
			Me.baseUrlTextBox.Location = New Point(9, 411)
			Me.baseUrlTextBox.Name = "baseUrlTextBox"
			Me.baseUrlTextBox.Size = New Size(575, 21)
			Me.baseUrlTextBox.TabIndex = 53
			' 
			' htmlStringTextBox
			' 
			Me.htmlStringTextBox.Location = New Point(9, 88)
			Me.htmlStringTextBox.MaxLength = 1000000
			Me.htmlStringTextBox.Multiline = True
			Me.htmlStringTextBox.Name = "htmlStringTextBox"
			Me.htmlStringTextBox.ScrollBars = ScrollBars.Vertical
			Me.htmlStringTextBox.Size = New Size(574, 302)
			Me.htmlStringTextBox.TabIndex = 51
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label12.Location = New Point(6, 70)
			Me.label12.Name = "label12"
			Me.label12.Size = New Size(127, 15)
			Me.label12.TabIndex = 50
			Me.label12.Text = "Stamp HTML Code"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label5.Location = New Point(6, 12)
			Me.label5.Name = "label5"
			Me.label5.Size = New Size(164, 15)
			Me.label5.TabIndex = 45
			Me.label5.Text = "Stamp Size in PDF Page"
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.stampPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 618)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 42)
			Me.convertButtonPanel.TabIndex = 146
			' 
			' stampPdfButton
			' 
			Me.stampPdfButton.Location = New Point(6, 6)
			Me.stampPdfButton.Name = "stampPdfButton"
			Me.stampPdfButton.Size = New Size(110, 27)
			Me.stampPdfButton.TabIndex = 66
			Me.stampPdfButton.Text = "Stamp PDF"
			Me.stampPdfButton.UseVisualStyleBackColor = True
'			Me.stampPdfButton.Click += New System.EventHandler(Me.stampPdfButton_Click)
			' 
			' Stamp_PDF_Demo
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
			Me.Name = "Stamp_PDF_Demo"
			Me.Size = New Size(610, 683)
'			Me.Load += New System.EventHandler(Me.Stamp_PDF_Demo_Load)
			Me.urlPanel.ResumeLayout(False)
			Me.urlPanel.PerformLayout()
			Me.descriptionPanel.ResumeLayout(False)
			Me.titlePanel.ResumeLayout(False)
			Me.titlePanel.PerformLayout()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			Me.convertButtonPanel.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private demoLeftPanel As Panel
		Private demoRightPanel As Panel
		Private demoBottomPanel As Panel
		Private demoTopPanel As Panel
		Private urlPanel As Panel
		Private WithEvents selectFileButton As Button
		Private pdfFilePathTextBox As TextBox
		Private enterUrlLabel As Label
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
		Private settingsPanel As Panel
		Private label31 As Label
		Private label23 As Label
		Private label30 As Label
		Private label26 As Label
		Private stampHeightTextBox As TextBox
		Private stampWidthTextBox As TextBox
		Private label2 As Label
		Private baseUrlTextBox As TextBox
		Private htmlStringTextBox As TextBox
		Private label12 As Label
		Private label5 As Label
		Private convertButtonPanel As Panel
		Private WithEvents stampPdfButton As Button
	End Class
End Namespace

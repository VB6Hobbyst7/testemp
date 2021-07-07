Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class Create_PDF_Documents_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Create_PDF_Documents_Demo))
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.convertButtonPanel = New Panel()
			Me.createPdfButton = New Button()
			Me.settingsPanel = New Panel()
			Me.panel2 = New Panel()
			Me.cmykRadioButton = New RadioButton()
			Me.grayScaleRadioButton = New RadioButton()
			Me.rgbRadioButton = New RadioButton()
			Me.label1 = New Label()
			Me.panel1 = New Panel()
			Me.pdfXRadioButton = New RadioButton()
			Me.pdfARadioButton = New RadioButton()
			Me.fullPdfRadioButton = New RadioButton()
			Me.label2 = New Label()
			Me.label10 = New Label()
			Me.label11 = New Label()
			Me.label13 = New Label()
			Me.label15 = New Label()
			Me.label16 = New Label()
			Me.label17 = New Label()
			Me.label18 = New Label()
			Me.label19 = New Label()
			Me.label22 = New Label()
			Me.rightMarginTextBox = New TextBox()
			Me.leftMarginTextBox = New TextBox()
			Me.topMarginTextBox = New TextBox()
			Me.bottomMarginTextBox = New TextBox()
			Me.label9 = New Label()
			Me.label4 = New Label()
			Me.label5 = New Label()
			Me.pdfPageSizeComboBox = New ComboBox()
			Me.pdfPageOrientationComboBox = New ComboBox()
			Me.descriptionPanel = New Panel()
			Me.descriptionLabel = New Label()
			Me.titlePanel = New Panel()
			Me.titleLabel = New Label()
			Me.convertButtonPanel.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.panel1.SuspendLayout()
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
			Me.convertButtonPanel.Controls.Add(Me.createPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 362)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 43)
			Me.convertButtonPanel.TabIndex = 168
			' 
			' createPdfButton
			' 
			Me.createPdfButton.Location = New Point(6, 6)
			Me.createPdfButton.Name = "createPdfButton"
			Me.createPdfButton.Size = New Size(160, 27)
			Me.createPdfButton.TabIndex = 66
			Me.createPdfButton.Text = "Create PDF Document"
			Me.createPdfButton.UseVisualStyleBackColor = True
'			Me.createPdfButton.Click += New System.EventHandler(Me.createPdfButton_Click)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.panel2)
			Me.settingsPanel.Controls.Add(Me.panel1)
			Me.settingsPanel.Controls.Add(Me.label10)
			Me.settingsPanel.Controls.Add(Me.label11)
			Me.settingsPanel.Controls.Add(Me.label13)
			Me.settingsPanel.Controls.Add(Me.label15)
			Me.settingsPanel.Controls.Add(Me.label16)
			Me.settingsPanel.Controls.Add(Me.label17)
			Me.settingsPanel.Controls.Add(Me.label18)
			Me.settingsPanel.Controls.Add(Me.label19)
			Me.settingsPanel.Controls.Add(Me.label22)
			Me.settingsPanel.Controls.Add(Me.rightMarginTextBox)
			Me.settingsPanel.Controls.Add(Me.leftMarginTextBox)
			Me.settingsPanel.Controls.Add(Me.topMarginTextBox)
			Me.settingsPanel.Controls.Add(Me.bottomMarginTextBox)
			Me.settingsPanel.Controls.Add(Me.label9)
			Me.settingsPanel.Controls.Add(Me.label4)
			Me.settingsPanel.Controls.Add(Me.label5)
			Me.settingsPanel.Controls.Add(Me.pdfPageSizeComboBox)
			Me.settingsPanel.Controls.Add(Me.pdfPageOrientationComboBox)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 112)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 250)
			Me.settingsPanel.TabIndex = 167
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.cmykRadioButton)
			Me.panel2.Controls.Add(Me.grayScaleRadioButton)
			Me.panel2.Controls.Add(Me.rgbRadioButton)
			Me.panel2.Controls.Add(Me.label1)
			Me.panel2.Location = New Point(3, 71)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New Size(591, 72)
			Me.panel2.TabIndex = 151
			' 
			' cmykRadioButton
			' 
			Me.cmykRadioButton.AutoSize = True
			Me.cmykRadioButton.Location = New Point(229, 34)
			Me.cmykRadioButton.Name = "cmykRadioButton"
			Me.cmykRadioButton.Size = New Size(66, 20)
			Me.cmykRadioButton.TabIndex = 64
			Me.cmykRadioButton.Text = "CMYK"
			Me.cmykRadioButton.UseVisualStyleBackColor = True
			' 
			' grayScaleRadioButton
			' 
			Me.grayScaleRadioButton.AutoSize = True
			Me.grayScaleRadioButton.Location = New Point(109, 34)
			Me.grayScaleRadioButton.Name = "grayScaleRadioButton"
			Me.grayScaleRadioButton.Size = New Size(91, 20)
			Me.grayScaleRadioButton.TabIndex = 66
			Me.grayScaleRadioButton.Text = "Gray Scale"
			Me.grayScaleRadioButton.UseVisualStyleBackColor = True
			' 
			' rgbRadioButton
			' 
			Me.rgbRadioButton.AutoSize = True
			Me.rgbRadioButton.Checked = True
			Me.rgbRadioButton.Location = New Point(21, 34)
			Me.rgbRadioButton.Name = "rgbRadioButton"
			Me.rgbRadioButton.Size = New Size(58, 20)
			Me.rgbRadioButton.TabIndex = 65
			Me.rgbRadioButton.TabStop = True
			Me.rgbRadioButton.Text = "RGB"
			Me.rgbRadioButton.UseVisualStyleBackColor = True
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label1.Location = New Point(3, 5)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(85, 15)
			Me.label1.TabIndex = 63
			Me.label1.Text = "Color Space"
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.pdfXRadioButton)
			Me.panel1.Controls.Add(Me.pdfARadioButton)
			Me.panel1.Controls.Add(Me.fullPdfRadioButton)
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Location = New Point(3, 4)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Size(591, 61)
			Me.panel1.TabIndex = 150
			' 
			' pdfXRadioButton
			' 
			Me.pdfXRadioButton.AutoSize = True
			Me.pdfXRadioButton.Location = New Point(205, 34)
			Me.pdfXRadioButton.Name = "pdfXRadioButton"
			Me.pdfXRadioButton.Size = New Size(85, 20)
			Me.pdfXRadioButton.TabIndex = 60
			Me.pdfXRadioButton.Text = "PDF/X-1a"
			Me.pdfXRadioButton.UseVisualStyleBackColor = True
			' 
			' pdfARadioButton
			' 
			Me.pdfARadioButton.AutoSize = True
			Me.pdfARadioButton.Location = New Point(109, 34)
			Me.pdfARadioButton.Name = "pdfARadioButton"
			Me.pdfARadioButton.Size = New Size(84, 20)
			Me.pdfARadioButton.TabIndex = 62
			Me.pdfARadioButton.Text = "PDF/A-1b"
			Me.pdfARadioButton.UseVisualStyleBackColor = True
			' 
			' fullPdfRadioButton
			' 
			Me.fullPdfRadioButton.AutoSize = True
			Me.fullPdfRadioButton.Checked = True
			Me.fullPdfRadioButton.Location = New Point(21, 34)
			Me.fullPdfRadioButton.Name = "fullPdfRadioButton"
			Me.fullPdfRadioButton.Size = New Size(79, 20)
			Me.fullPdfRadioButton.TabIndex = 61
			Me.fullPdfRadioButton.TabStop = True
			Me.fullPdfRadioButton.Text = "Full PDF"
			Me.fullPdfRadioButton.UseVisualStyleBackColor = True
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label2.Location = New Point(3, 5)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(96, 15)
			Me.label2.TabIndex = 59
			Me.label2.Text = "PDF Standard"
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label10.Location = New Point(531, 216)
			Me.label10.Name = "label10"
			Me.label10.Size = New Size(17, 15)
			Me.label10.TabIndex = 147
			Me.label10.Text = "pt"
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label11.Location = New Point(396, 216)
			Me.label11.Name = "label11"
			Me.label11.Size = New Size(17, 15)
			Me.label11.TabIndex = 146
			Me.label11.Text = "pt"
			' 
			' label13
			' 
			Me.label13.AutoSize = True
			Me.label13.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label13.Location = New Point(282, 216)
			Me.label13.Name = "label13"
			Me.label13.Size = New Size(17, 15)
			Me.label13.TabIndex = 149
			Me.label13.Text = "pt"
			' 
			' label15
			' 
			Me.label15.AutoSize = True
			Me.label15.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label15.Location = New Point(160, 216)
			Me.label15.Name = "label15"
			Me.label15.Size = New Size(17, 15)
			Me.label15.TabIndex = 148
			Me.label15.Text = "pt"
			' 
			' label16
			' 
			Me.label16.AutoSize = True
			Me.label16.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label16.Location = New Point(202, 216)
			Me.label16.Name = "label16"
			Me.label16.Size = New Size(39, 15)
			Me.label16.TabIndex = 142
			Me.label16.Text = "Right:"
			' 
			' label17
			' 
			Me.label17.AutoSize = True
			Me.label17.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label17.Location = New Point(322, 216)
			Me.label17.Name = "label17"
			Me.label17.Size = New Size(31, 15)
			Me.label17.TabIndex = 145
			Me.label17.Text = "Top:"
			' 
			' label18
			' 
			Me.label18.AutoSize = True
			Me.label18.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label18.Location = New Point(440, 216)
			Me.label18.Name = "label18"
			Me.label18.Size = New Size(49, 15)
			Me.label18.TabIndex = 144
			Me.label18.Text = "Bottom:"
			' 
			' label19
			' 
			Me.label19.AutoSize = True
			Me.label19.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label19.Location = New Point(90, 216)
			Me.label19.Name = "label19"
			Me.label19.Size = New Size(30, 15)
			Me.label19.TabIndex = 143
			Me.label19.Text = "Left:"
			' 
			' label22
			' 
			Me.label22.AutoSize = True
			Me.label22.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label22.Location = New Point(24, 216)
			Me.label22.Name = "label22"
			Me.label22.Size = New Size(55, 15)
			Me.label22.TabIndex = 137
			Me.label22.Text = "Margins:"
			' 
			' rightMarginTextBox
			' 
			Me.rightMarginTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.rightMarginTextBox.Location = New Point(248, 213)
			Me.rightMarginTextBox.Name = "rightMarginTextBox"
			Me.rightMarginTextBox.Size = New Size(30, 21)
			Me.rightMarginTextBox.TabIndex = 141
			Me.rightMarginTextBox.Text = "0"
			' 
			' leftMarginTextBox
			' 
			Me.leftMarginTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.leftMarginTextBox.Location = New Point(126, 213)
			Me.leftMarginTextBox.Name = "leftMarginTextBox"
			Me.leftMarginTextBox.Size = New Size(30, 21)
			Me.leftMarginTextBox.TabIndex = 139
			Me.leftMarginTextBox.Text = "0"
			' 
			' topMarginTextBox
			' 
			Me.topMarginTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.topMarginTextBox.Location = New Point(362, 213)
			Me.topMarginTextBox.Name = "topMarginTextBox"
			Me.topMarginTextBox.Size = New Size(30, 21)
			Me.topMarginTextBox.TabIndex = 140
			Me.topMarginTextBox.Text = "0"
			' 
			' bottomMarginTextBox
			' 
			Me.bottomMarginTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.bottomMarginTextBox.Location = New Point(497, 213)
			Me.bottomMarginTextBox.Name = "bottomMarginTextBox"
			Me.bottomMarginTextBox.Size = New Size(30, 21)
			Me.bottomMarginTextBox.TabIndex = 138
			Me.bottomMarginTextBox.Text = "0"
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label9.Location = New Point(6, 146)
			Me.label9.Name = "label9"
			Me.label9.Size = New Size(124, 15)
			Me.label9.TabIndex = 132
			Me.label9.Text = "PDF Page Options"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New Point(24, 181)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(37, 15)
			Me.label4.TabIndex = 134
			Me.label4.Text = "Size: "
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New Point(241, 181)
			Me.label5.Name = "label5"
			Me.label5.Size = New Size(70, 15)
			Me.label5.TabIndex = 133
			Me.label5.Text = "Orientation:"
			' 
			' pdfPageSizeComboBox
			' 
			Me.pdfPageSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList
			Me.pdfPageSizeComboBox.FormattingEnabled = True
			Me.pdfPageSizeComboBox.Items.AddRange(New Object() { "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10", "B0", "B1", "B2", "B3", "B4", "B5", "ArchA", "ArchB", "ArchC", "ArchD", "ArchE", "Flsa", "HalfLetter", "Ledger", "Legal", "Letter", "Letter11x17", "Note"})
			Me.pdfPageSizeComboBox.Location = New Point(70, 177)
			Me.pdfPageSizeComboBox.Name = "pdfPageSizeComboBox"
			Me.pdfPageSizeComboBox.Size = New Size(128, 23)
			Me.pdfPageSizeComboBox.TabIndex = 136
			' 
			' pdfPageOrientationComboBox
			' 
			Me.pdfPageOrientationComboBox.DropDownStyle = ComboBoxStyle.DropDownList
			Me.pdfPageOrientationComboBox.FormattingEnabled = True
			Me.pdfPageOrientationComboBox.Items.AddRange(New Object() { "Portrait", "Landscape"})
			Me.pdfPageOrientationComboBox.Location = New Point(322, 177)
			Me.pdfPageOrientationComboBox.Name = "pdfPageOrientationComboBox"
			Me.pdfPageOrientationComboBox.Size = New Size(135, 23)
			Me.pdfPageOrientationComboBox.TabIndex = 135
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 66)
			Me.descriptionPanel.TabIndex = 165
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 66)
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
			Me.titleLabel.Size = New Size(176, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Create PDF Documents"
			' 
			' Create_PDF_Documents_Demo
			' 
			Me.AutoScaleDimensions = New SizeF(7F, 15F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScroll = True
			Me.Controls.Add(Me.convertButtonPanel)
			Me.Controls.Add(Me.settingsPanel)
			Me.Controls.Add(Me.descriptionPanel)
			Me.Controls.Add(Me.titlePanel)
			Me.Controls.Add(Me.demoLeftPanel)
			Me.Controls.Add(Me.demoRightPanel)
			Me.Controls.Add(Me.demoBottomPanel)
			Me.Controls.Add(Me.demoTopPanel)
			Me.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.Name = "Create_PDF_Documents_Demo"
			Me.Size = New Size(610, 650)
'			Me.Load += New System.EventHandler(Me.Create_PDF_Documents_Demo_Load)
			Me.convertButtonPanel.ResumeLayout(False)
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
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
		Private settingsPanel As Panel
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
		Private label10 As Label
		Private label11 As Label
		Private label13 As Label
		Private label15 As Label
		Private label16 As Label
		Private label17 As Label
		Private label18 As Label
		Private label19 As Label
		Private label22 As Label
		Private rightMarginTextBox As TextBox
		Private leftMarginTextBox As TextBox
		Private topMarginTextBox As TextBox
		Private bottomMarginTextBox As TextBox
		Private label9 As Label
		Private label4 As Label
		Private label5 As Label
		Private pdfPageSizeComboBox As ComboBox
		Private pdfPageOrientationComboBox As ComboBox
		Private panel2 As Panel
		Private cmykRadioButton As RadioButton
		Private grayScaleRadioButton As RadioButton
		Private rgbRadioButton As RadioButton
		Private label1 As Label
		Private panel1 As Panel
		Private pdfXRadioButton As RadioButton
		Private pdfARadioButton As RadioButton
		Private fullPdfRadioButton As RadioButton
		Private label2 As Label
	End Class
End Namespace

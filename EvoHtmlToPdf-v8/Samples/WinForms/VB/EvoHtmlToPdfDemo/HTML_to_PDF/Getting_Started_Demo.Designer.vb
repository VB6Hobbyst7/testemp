Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class Getting_Started_Demo
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
			Me.descriptionPanel = New Panel()
			Me.descriptionLabel = New Label()
			Me.titlePanel = New Panel()
			Me.titleLabel = New Label()
			Me.demoRightPanel = New Panel()
			Me.demoLeftPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.selectHtmlToConvertPanel = New Panel()
			Me.convertHtmlRadioButton = New RadioButton()
			Me.convertUrlRadioButton = New RadioButton()
			Me.convertButtonPanel = New Panel()
			Me.convertToPdfButton = New Button()
			Me.settingsPanel = New Panel()
			Me.label11 = New Label()
			Me.label10 = New Label()
			Me.label1 = New Label()
			Me.label9 = New Label()
			Me.label21 = New Label()
			Me.label7 = New Label()
			Me.label2 = New Label()
			Me.label4 = New Label()
			Me.label5 = New Label()
			Me.label8 = New Label()
			Me.label6 = New Label()
			Me.label20 = New Label()
			Me.label3 = New Label()
			Me.conversionDelayTextBox = New TextBox()
			Me.htmlViewerHeightTextBox = New TextBox()
			Me.navigationTimeoutTextBox = New TextBox()
			Me.htmlViewerWidthTextBox = New TextBox()
			Me.pdfPageSizeComboBox = New ComboBox()
			Me.pdfPageOrientationComboBox = New ComboBox()
			Me.htmlStringPanel = New Panel()
			Me.label14 = New Label()
			Me.baseUrlTextBox = New TextBox()
			Me.htmlStringTextBox = New TextBox()
			Me.label12 = New Label()
			Me.urlPanel = New Panel()
			Me.enterUrlLabel = New Label()
			Me.urlTextBox = New TextBox()
			Me.descriptionPanel.SuspendLayout()
			Me.titlePanel.SuspendLayout()
			Me.selectHtmlToConvertPanel.SuspendLayout()
			Me.convertButtonPanel.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			Me.htmlStringPanel.SuspendLayout()
			Me.urlPanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 42)
			Me.descriptionPanel.TabIndex = 80
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 42)
			Me.descriptionLabel.TabIndex = 0
			Me.descriptionLabel.Text = "Convert a HTML page from an URL or a HTML String to PDF using the basic options o" & "f the HTML to PDF Converter. The Full Description and a Code Sample can be acces" & "sed from the top tabs."
			' 
			' titlePanel
			' 
			Me.titlePanel.Controls.Add(Me.titleLabel)
			Me.titlePanel.Dock = DockStyle.Top
			Me.titlePanel.Location = New Point(6, 6)
			Me.titlePanel.Name = "titlePanel"
			Me.titlePanel.Size = New Size(598, 40)
			Me.titlePanel.TabIndex = 79
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(382, 18)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Getting Started with EVO HTML to PDF Converter"
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 684)
			Me.demoRightPanel.TabIndex = 78
			' 
			' demoLeftPanel
			' 
			Me.demoLeftPanel.Dock = DockStyle.Left
			Me.demoLeftPanel.Location = New Point(0, 6)
			Me.demoLeftPanel.Name = "demoLeftPanel"
			Me.demoLeftPanel.Size = New Size(6, 684)
			Me.demoLeftPanel.TabIndex = 77
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 690)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 76
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 75
			' 
			' selectHtmlToConvertPanel
			' 
			Me.selectHtmlToConvertPanel.Controls.Add(Me.convertHtmlRadioButton)
			Me.selectHtmlToConvertPanel.Controls.Add(Me.convertUrlRadioButton)
			Me.selectHtmlToConvertPanel.Dock = DockStyle.Top
			Me.selectHtmlToConvertPanel.Location = New Point(6, 88)
			Me.selectHtmlToConvertPanel.Name = "selectHtmlToConvertPanel"
			Me.selectHtmlToConvertPanel.Size = New Size(598, 33)
			Me.selectHtmlToConvertPanel.TabIndex = 83
			' 
			' convertHtmlRadioButton
			' 
			Me.convertHtmlRadioButton.AutoSize = True
			Me.convertHtmlRadioButton.Location = New Point(207, 6)
			Me.convertHtmlRadioButton.Name = "convertHtmlRadioButton"
			Me.convertHtmlRadioButton.Size = New Size(152, 20)
			Me.convertHtmlRadioButton.TabIndex = 69
			Me.convertHtmlRadioButton.Text = "Convert HTML String"
			Me.convertHtmlRadioButton.UseVisualStyleBackColor = True
'			Me.convertHtmlRadioButton.CheckedChanged += New System.EventHandler(Me.convertHtmlRadioButton_CheckedChanged)
			' 
			' convertUrlRadioButton
			' 
			Me.convertUrlRadioButton.AutoSize = True
			Me.convertUrlRadioButton.Checked = True
			Me.convertUrlRadioButton.Location = New Point(3, 6)
			Me.convertUrlRadioButton.Name = "convertUrlRadioButton"
			Me.convertUrlRadioButton.Size = New Size(181, 20)
			Me.convertUrlRadioButton.TabIndex = 68
			Me.convertUrlRadioButton.TabStop = True
			Me.convertUrlRadioButton.Text = "Convert URL or Local File"
			Me.convertUrlRadioButton.UseVisualStyleBackColor = True
'			Me.convertUrlRadioButton.CheckedChanged += New System.EventHandler(Me.convertUrlRadioButton_CheckedChanged)
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 629)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 39)
			Me.convertButtonPanel.TabIndex = 94
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
			Me.settingsPanel.Controls.Add(Me.label11)
			Me.settingsPanel.Controls.Add(Me.label10)
			Me.settingsPanel.Controls.Add(Me.label1)
			Me.settingsPanel.Controls.Add(Me.label9)
			Me.settingsPanel.Controls.Add(Me.label21)
			Me.settingsPanel.Controls.Add(Me.label7)
			Me.settingsPanel.Controls.Add(Me.label2)
			Me.settingsPanel.Controls.Add(Me.label4)
			Me.settingsPanel.Controls.Add(Me.label5)
			Me.settingsPanel.Controls.Add(Me.label8)
			Me.settingsPanel.Controls.Add(Me.label6)
			Me.settingsPanel.Controls.Add(Me.label20)
			Me.settingsPanel.Controls.Add(Me.label3)
			Me.settingsPanel.Controls.Add(Me.conversionDelayTextBox)
			Me.settingsPanel.Controls.Add(Me.htmlViewerHeightTextBox)
			Me.settingsPanel.Controls.Add(Me.navigationTimeoutTextBox)
			Me.settingsPanel.Controls.Add(Me.htmlViewerWidthTextBox)
			Me.settingsPanel.Controls.Add(Me.pdfPageSizeComboBox)
			Me.settingsPanel.Controls.Add(Me.pdfPageOrientationComboBox)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 406)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 223)
			Me.settingsPanel.TabIndex = 93
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label11.Location = New Point(3, 158)
			Me.label11.Name = "label11"
			Me.label11.Size = New Size(140, 16)
			Me.label11.TabIndex = 39
			Me.label11.Text = "Navigation Options"
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label10.Location = New Point(3, 83)
			Me.label10.Name = "label10"
			Me.label10.Size = New Size(136, 16)
			Me.label10.TabIndex = 39
			Me.label10.Text = "PDF Page Options"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label1.Location = New Point(3, 13)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(157, 16)
			Me.label1.TabIndex = 39
			Me.label1.Text = "HTML Viewer Options"
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New Point(204, 189)
			Me.label9.Name = "label9"
			Me.label9.Size = New Size(121, 16)
			Me.label9.TabIndex = 44
			Me.label9.Text = "Delay Conversion :"
			' 
			' label21
			' 
			Me.label21.AutoSize = True
			Me.label21.Location = New Point(30, 189)
			Me.label21.Name = "label21"
			Me.label21.Size = New Size(60, 16)
			Me.label21.TabIndex = 44
			Me.label21.Text = "Timeout:"
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New Point(204, 49)
			Me.label7.Name = "label7"
			Me.label7.Size = New Size(50, 16)
			Me.label7.TabIndex = 44
			Me.label7.Text = "Height:"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New Point(30, 49)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(45, 16)
			Me.label2.TabIndex = 44
			Me.label2.Text = "Width:"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New Point(30, 119)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(40, 16)
			Me.label4.TabIndex = 45
			Me.label4.Text = "Size: "
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New Point(204, 119)
			Me.label5.Name = "label5"
			Me.label5.Size = New Size(75, 16)
			Me.label5.TabIndex = 42
			Me.label5.Text = "Orientation:"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New Point(365, 189)
			Me.label8.Name = "label8"
			Me.label8.Size = New Size(30, 16)
			Me.label8.TabIndex = 43
			Me.label8.Text = "sec"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New Point(334, 49)
			Me.label6.Name = "label6"
			Me.label6.Size = New Size(22, 16)
			Me.label6.TabIndex = 43
			Me.label6.Text = "px"
			' 
			' label20
			' 
			Me.label20.AutoSize = True
			Me.label20.Location = New Point(132, 189)
			Me.label20.Name = "label20"
			Me.label20.Size = New Size(30, 16)
			Me.label20.TabIndex = 43
			Me.label20.Text = "sec"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New Point(157, 49)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(22, 16)
			Me.label3.TabIndex = 43
			Me.label3.Text = "px"
			' 
			' conversionDelayTextBox
			' 
			Me.conversionDelayTextBox.Location = New Point(331, 186)
			Me.conversionDelayTextBox.Name = "conversionDelayTextBox"
			Me.conversionDelayTextBox.Size = New Size(30, 21)
            Me.conversionDelayTextBox.TabIndex = 46
            Me.conversionDelayTextBox.Text = "2"
			' 
			' htmlViewerHeightTextBox
			' 
			Me.htmlViewerHeightTextBox.Location = New Point(260, 46)
			Me.htmlViewerHeightTextBox.Name = "htmlViewerHeightTextBox"
			Me.htmlViewerHeightTextBox.Size = New Size(70, 21)
			Me.htmlViewerHeightTextBox.TabIndex = 46
			' 
			' navigationTimeoutTextBox
			' 
			Me.navigationTimeoutTextBox.Location = New Point(96, 186)
			Me.navigationTimeoutTextBox.Name = "navigationTimeoutTextBox"
			Me.navigationTimeoutTextBox.Size = New Size(30, 21)
			Me.navigationTimeoutTextBox.TabIndex = 46
			Me.navigationTimeoutTextBox.Text = "60"
			' 
			' htmlViewerWidthTextBox
			' 
			Me.htmlViewerWidthTextBox.Location = New Point(81, 46)
			Me.htmlViewerWidthTextBox.Name = "htmlViewerWidthTextBox"
			Me.htmlViewerWidthTextBox.Size = New Size(70, 21)
			Me.htmlViewerWidthTextBox.TabIndex = 46
			Me.htmlViewerWidthTextBox.Text = "1024"
			' 
			' pdfPageSizeComboBox
			' 
			Me.pdfPageSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList
			Me.pdfPageSizeComboBox.FormattingEnabled = True
			Me.pdfPageSizeComboBox.Items.AddRange(New Object() { "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10", "B0", "B1", "B2", "B3", "B4", "B5", "ArchA", "ArchB", "ArchC", "ArchD", "ArchE", "Flsa", "HalfLetter", "Ledger", "Legal", "Letter", "Letter11x17", "Note"})
			Me.pdfPageSizeComboBox.Location = New Point(76, 116)
			Me.pdfPageSizeComboBox.Name = "pdfPageSizeComboBox"
			Me.pdfPageSizeComboBox.Size = New Size(110, 23)
			Me.pdfPageSizeComboBox.TabIndex = 52
			' 
			' pdfPageOrientationComboBox
			' 
			Me.pdfPageOrientationComboBox.DropDownStyle = ComboBoxStyle.DropDownList
			Me.pdfPageOrientationComboBox.FormattingEnabled = True
			Me.pdfPageOrientationComboBox.Items.AddRange(New Object() { "Portrait", "Landscape"})
			Me.pdfPageOrientationComboBox.Location = New Point(285, 116)
			Me.pdfPageOrientationComboBox.Name = "pdfPageOrientationComboBox"
			Me.pdfPageOrientationComboBox.Size = New Size(116, 23)
			Me.pdfPageOrientationComboBox.TabIndex = 51
			' 
			' htmlStringPanel
			' 
			Me.htmlStringPanel.Controls.Add(Me.label14)
			Me.htmlStringPanel.Controls.Add(Me.baseUrlTextBox)
			Me.htmlStringPanel.Controls.Add(Me.htmlStringTextBox)
			Me.htmlStringPanel.Controls.Add(Me.label12)
			Me.htmlStringPanel.Dock = DockStyle.Top
			Me.htmlStringPanel.Location = New Point(6, 183)
			Me.htmlStringPanel.Name = "htmlStringPanel"
			Me.htmlStringPanel.Size = New Size(598, 223)
			Me.htmlStringPanel.TabIndex = 92
			Me.htmlStringPanel.Visible = False
			' 
			' label14
			' 
			Me.label14.AutoSize = True
			Me.label14.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label14.Location = New Point(0, 172)
			Me.label14.Name = "label14"
			Me.label14.Size = New Size(78, 16)
			Me.label14.TabIndex = 42
			Me.label14.Text = "Base URL"
			' 
			' baseUrlTextBox
			' 
			Me.baseUrlTextBox.Location = New Point(3, 190)
			Me.baseUrlTextBox.Name = "baseUrlTextBox"
			Me.baseUrlTextBox.Size = New Size(575, 21)
			Me.baseUrlTextBox.TabIndex = 43
			' 
			' htmlStringTextBox
			' 
			Me.htmlStringTextBox.Location = New Point(3, 26)
			Me.htmlStringTextBox.MaxLength = 1000000
			Me.htmlStringTextBox.Multiline = True
			Me.htmlStringTextBox.Name = "htmlStringTextBox"
			Me.htmlStringTextBox.ScrollBars = ScrollBars.Vertical
			Me.htmlStringTextBox.Size = New Size(573, 134)
			Me.htmlStringTextBox.TabIndex = 41
			Me.htmlStringTextBox.Text = "Enter the <b>HTML String to Convert</b> and optionally set a <b>Base URL</b> if t" & "he HTML string references external resources by relative URLs"
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label12.Location = New Point(3, 8)
			Me.label12.Name = "label12"
			Me.label12.Size = New Size(167, 16)
			Me.label12.TabIndex = 40
			Me.label12.Text = "HTML String to Convert"
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 121)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 62)
			Me.urlPanel.TabIndex = 91
			' 
			' enterUrlLabel
			' 
			Me.enterUrlLabel.AutoSize = True
			Me.enterUrlLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.enterUrlLabel.Location = New Point(0, 13)
			Me.enterUrlLabel.Name = "enterUrlLabel"
			Me.enterUrlLabel.Size = New Size(288, 16)
			Me.enterUrlLabel.TabIndex = 40
			Me.enterUrlLabel.Text = "HTML Page URL or Local File to Convert"
			' 
			' urlTextBox
			' 
			Me.urlTextBox.Location = New Point(3, 35)
			Me.urlTextBox.Name = "urlTextBox"
			Me.urlTextBox.Size = New Size(574, 21)
			Me.urlTextBox.TabIndex = 41
			Me.urlTextBox.Text = "http://www.evopdf.com"
			' 
			' Getting_Started_Demo
			' 
			Me.AutoScaleDimensions = New SizeF(7F, 15F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScroll = True
			Me.Controls.Add(Me.convertButtonPanel)
			Me.Controls.Add(Me.settingsPanel)
			Me.Controls.Add(Me.htmlStringPanel)
			Me.Controls.Add(Me.urlPanel)
			Me.Controls.Add(Me.selectHtmlToConvertPanel)
			Me.Controls.Add(Me.descriptionPanel)
			Me.Controls.Add(Me.titlePanel)
			Me.Controls.Add(Me.demoRightPanel)
			Me.Controls.Add(Me.demoLeftPanel)
			Me.Controls.Add(Me.demoBottomPanel)
			Me.Controls.Add(Me.demoTopPanel)
			Me.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.Name = "Getting_Started_Demo"
			Me.Size = New Size(610, 696)
'			Me.Load += New System.EventHandler(Me.Getting_Started_Demo_Load)
			Me.descriptionPanel.ResumeLayout(False)
			Me.titlePanel.ResumeLayout(False)
			Me.titlePanel.PerformLayout()
			Me.selectHtmlToConvertPanel.ResumeLayout(False)
			Me.selectHtmlToConvertPanel.PerformLayout()
			Me.convertButtonPanel.ResumeLayout(False)
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			Me.htmlStringPanel.ResumeLayout(False)
			Me.htmlStringPanel.PerformLayout()
			Me.urlPanel.ResumeLayout(False)
			Me.urlPanel.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
		Private demoRightPanel As Panel
		Private demoLeftPanel As Panel
		Private demoBottomPanel As Panel
		Private demoTopPanel As Panel
		Private selectHtmlToConvertPanel As Panel
		Private WithEvents convertHtmlRadioButton As RadioButton
		Private WithEvents convertUrlRadioButton As RadioButton
		Private convertButtonPanel As Panel
		Private WithEvents convertToPdfButton As Button
		Private settingsPanel As Panel
		Private label11 As Label
		Private label10 As Label
		Private label1 As Label
		Private label9 As Label
		Private label21 As Label
		Private label7 As Label
		Private label2 As Label
		Private label4 As Label
		Private label5 As Label
		Private label8 As Label
		Private label6 As Label
		Private label20 As Label
		Private label3 As Label
		Private conversionDelayTextBox As TextBox
		Private htmlViewerHeightTextBox As TextBox
		Private navigationTimeoutTextBox As TextBox
		Private htmlViewerWidthTextBox As TextBox
		Private pdfPageSizeComboBox As ComboBox
		Private pdfPageOrientationComboBox As ComboBox
		Private htmlStringPanel As Panel
		Private label14 As Label
		Private baseUrlTextBox As TextBox
		Private htmlStringTextBox As TextBox
		Private label12 As Label
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox


	End Class
End Namespace

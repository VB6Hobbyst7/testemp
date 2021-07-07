Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background
	Partial Public Class Add_Elements_in_Background_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Add_Elements_in_Background_Demo))
			Me.demoRightPanel = New Panel()
			Me.demoLeftPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.convertButtonPanel = New Panel()
			Me.convertToPdfButton = New Button()
			Me.settingsPanel = New Panel()
			Me.addBackgroundImageCheckBox = New CheckBox()
			Me.htmlStringPanel = New Panel()
			Me.label14 = New Label()
			Me.baseUrlTextBox = New TextBox()
			Me.htmlStringTextBox = New TextBox()
			Me.label12 = New Label()
			Me.urlPanel = New Panel()
			Me.enterUrlLabel = New Label()
			Me.urlTextBox = New TextBox()
			Me.selectHtmlToConvertPanel = New Panel()
			Me.convertHtmlRadioButton = New RadioButton()
			Me.convertUrlRadioButton = New RadioButton()
			Me.descriptionPanel = New Panel()
			Me.descriptionLabel = New Label()
			Me.titlePanel = New Panel()
			Me.titleLabel = New Label()
			Me.convertButtonPanel.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			Me.htmlStringPanel.SuspendLayout()
			Me.urlPanel.SuspendLayout()
			Me.selectHtmlToConvertPanel.SuspendLayout()
			Me.descriptionPanel.SuspendLayout()
			Me.titlePanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 86
			' 
			' demoLeftPanel
			' 
			Me.demoLeftPanel.Dock = DockStyle.Left
			Me.demoLeftPanel.Location = New Point(0, 6)
			Me.demoLeftPanel.Name = "demoLeftPanel"
			Me.demoLeftPanel.Size = New Size(6, 638)
			Me.demoLeftPanel.TabIndex = 85
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 644)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 84
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 83
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 469)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 39)
			Me.convertButtonPanel.TabIndex = 108
			' 
			' convertToPdfButton
			' 
			Me.convertToPdfButton.Location = New Point(6, 6)
			Me.convertToPdfButton.Name = "convertToPdfButton"
			Me.convertToPdfButton.Size = New Size(154, 27)
			Me.convertToPdfButton.TabIndex = 66
			Me.convertToPdfButton.Text = "Convert HTML to PDF"
			Me.convertToPdfButton.UseVisualStyleBackColor = True
'			Me.convertToPdfButton.Click += New System.EventHandler(Me.convertToPdfButton_Click)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.addBackgroundImageCheckBox)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 416)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 53)
			Me.settingsPanel.TabIndex = 107
			' 
			' addBackgroundImageCheckBox
			' 
			Me.addBackgroundImageCheckBox.AutoSize = True
			Me.addBackgroundImageCheckBox.Checked = True
			Me.addBackgroundImageCheckBox.CheckState = CheckState.Checked
			Me.addBackgroundImageCheckBox.Location = New Point(6, 16)
			Me.addBackgroundImageCheckBox.Name = "addBackgroundImageCheckBox"
			Me.addBackgroundImageCheckBox.Size = New Size(161, 21)
			Me.addBackgroundImageCheckBox.TabIndex = 0
			Me.addBackgroundImageCheckBox.Text = "Add Background Image"
			Me.addBackgroundImageCheckBox.UseVisualStyleBackColor = True
			' 
			' htmlStringPanel
			' 
			Me.htmlStringPanel.Controls.Add(Me.label14)
			Me.htmlStringPanel.Controls.Add(Me.baseUrlTextBox)
			Me.htmlStringPanel.Controls.Add(Me.htmlStringTextBox)
			Me.htmlStringPanel.Controls.Add(Me.label12)
			Me.htmlStringPanel.Dock = DockStyle.Top
			Me.htmlStringPanel.Location = New Point(6, 193)
			Me.htmlStringPanel.Name = "htmlStringPanel"
			Me.htmlStringPanel.Size = New Size(598, 223)
			Me.htmlStringPanel.TabIndex = 106
			Me.htmlStringPanel.Visible = False
			' 
			' label14
			' 
			Me.label14.AutoSize = True
			Me.label14.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label14.Location = New Point(3, 178)
			Me.label14.Name = "label14"
			Me.label14.Size = New Size(71, 15)
			Me.label14.TabIndex = 42
			Me.label14.Text = "Base URL"
			' 
			' baseUrlTextBox
			' 
			Me.baseUrlTextBox.Location = New Point(6, 196)
			Me.baseUrlTextBox.Name = "baseUrlTextBox"
			Me.baseUrlTextBox.Size = New Size(575, 21)
			Me.baseUrlTextBox.TabIndex = 43
			' 
			' htmlStringTextBox
			' 
			Me.htmlStringTextBox.Location = New Point(6, 26)
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
			Me.label12.Size = New Size(155, 15)
			Me.label12.TabIndex = 40
			Me.label12.Text = "HTML String to Convert"
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 131)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 62)
			Me.urlPanel.TabIndex = 105
			' 
			' enterUrlLabel
			' 
			Me.enterUrlLabel.AutoSize = True
			Me.enterUrlLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.enterUrlLabel.Location = New Point(3, 17)
			Me.enterUrlLabel.Name = "enterUrlLabel"
			Me.enterUrlLabel.Size = New Size(266, 15)
			Me.enterUrlLabel.TabIndex = 40
			Me.enterUrlLabel.Text = "HTML Page URL or Local File to Convert"
			' 
			' urlTextBox
			' 
			Me.urlTextBox.Location = New Point(6, 35)
			Me.urlTextBox.Name = "urlTextBox"
			Me.urlTextBox.Size = New Size(574, 21)
			Me.urlTextBox.TabIndex = 41
			Me.urlTextBox.Text = "http://www.evopdf.com/DemoAppFiles/HTML_Files/Structured_HTML.html"
			' 
			' selectHtmlToConvertPanel
			' 
			Me.selectHtmlToConvertPanel.Controls.Add(Me.convertHtmlRadioButton)
			Me.selectHtmlToConvertPanel.Controls.Add(Me.convertUrlRadioButton)
			Me.selectHtmlToConvertPanel.Dock = DockStyle.Top
			Me.selectHtmlToConvertPanel.Location = New Point(6, 98)
			Me.selectHtmlToConvertPanel.Name = "selectHtmlToConvertPanel"
			Me.selectHtmlToConvertPanel.Size = New Size(598, 33)
			Me.selectHtmlToConvertPanel.TabIndex = 104
			' 
			' convertHtmlRadioButton
			' 
			Me.convertHtmlRadioButton.AutoSize = True
			Me.convertHtmlRadioButton.Location = New Point(207, 6)
			Me.convertHtmlRadioButton.Name = "convertHtmlRadioButton"
			Me.convertHtmlRadioButton.Size = New Size(145, 20)
			Me.convertHtmlRadioButton.TabIndex = 69
			Me.convertHtmlRadioButton.Text = "Convert HTML String"
			Me.convertHtmlRadioButton.UseVisualStyleBackColor = True
'			Me.convertHtmlRadioButton.CheckedChanged += New System.EventHandler(Me.convertHtmlRadioButton_CheckedChanged)
			' 
			' convertUrlRadioButton
			' 
			Me.convertUrlRadioButton.AutoSize = True
			Me.convertUrlRadioButton.Checked = True
			Me.convertUrlRadioButton.Location = New Point(6, 6)
			Me.convertUrlRadioButton.Name = "convertUrlRadioButton"
			Me.convertUrlRadioButton.Size = New Size(171, 20)
			Me.convertUrlRadioButton.TabIndex = 68
			Me.convertUrlRadioButton.TabStop = True
			Me.convertUrlRadioButton.Text = "Convert URL or Local File"
			Me.convertUrlRadioButton.UseVisualStyleBackColor = True
'			Me.convertUrlRadioButton.CheckedChanged += New System.EventHandler(Me.convertUrlRadioButton_CheckedChanged)
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 41)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 57)
			Me.descriptionPanel.TabIndex = 103
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 57)
			Me.descriptionLabel.TabIndex = 0
			Me.descriptionLabel.Text = resources.GetString("descriptionLabel.Text")
			' 
			' titlePanel
			' 
			Me.titlePanel.Controls.Add(Me.titleLabel)
			Me.titlePanel.Dock = DockStyle.Top
			Me.titlePanel.Location = New Point(6, 6)
			Me.titlePanel.Name = "titlePanel"
			Me.titlePanel.Size = New Size(598, 35)
			Me.titlePanel.TabIndex = 102
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(3, 3)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(301, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Add Elements in PDF Pages Background"
			' 
			' Add_Elements_in_Background_Demo
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
			Me.Name = "Add_Elements_in_Background_Demo"
			Me.Size = New Size(610, 650)
			Me.convertButtonPanel.ResumeLayout(False)
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			Me.htmlStringPanel.ResumeLayout(False)
			Me.htmlStringPanel.PerformLayout()
			Me.urlPanel.ResumeLayout(False)
			Me.urlPanel.PerformLayout()
			Me.selectHtmlToConvertPanel.ResumeLayout(False)
			Me.selectHtmlToConvertPanel.PerformLayout()
			Me.descriptionPanel.ResumeLayout(False)
			Me.titlePanel.ResumeLayout(False)
			Me.titlePanel.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private demoRightPanel As Panel
		Private demoLeftPanel As Panel
		Private demoBottomPanel As Panel
		Private demoTopPanel As Panel
		Private convertButtonPanel As Panel
		Private WithEvents convertToPdfButton As Button
		Private settingsPanel As Panel
		Private addBackgroundImageCheckBox As CheckBox
		Private htmlStringPanel As Panel
		Private label14 As Label
		Private baseUrlTextBox As TextBox
		Private htmlStringTextBox As TextBox
		Private label12 As Label
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox
		Private selectHtmlToConvertPanel As Panel
		Private WithEvents convertHtmlRadioButton As RadioButton
		Private WithEvents convertUrlRadioButton As RadioButton
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
	End Class
End Namespace

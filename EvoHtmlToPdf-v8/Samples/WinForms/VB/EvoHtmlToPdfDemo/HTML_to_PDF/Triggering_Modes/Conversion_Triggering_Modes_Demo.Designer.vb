Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Triggering_Modes
	Partial Public Class Conversion_Triggering_Modes_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Conversion_Triggering_Modes_Demo))
			Me.convertButtonPanel = New Panel()
			Me.convertToPdfButton = New Button()
			Me.selectTriggeringModePanel = New Panel()
			Me.conversionDelayPanel = New Panel()
			Me.label9 = New Label()
			Me.label8 = New Label()
			Me.conversionDelayTextBox = New TextBox()
			Me.manualRadioButton = New RadioButton()
			Me.delayedRadioButton = New RadioButton()
			Me.autoRadioButton = New RadioButton()
			Me.label1 = New Label()
			Me.htmlPanel = New Panel()
			Me.label2 = New Label()
			Me.baseUrlTextBox = New TextBox()
			Me.htmlStringTextBox = New TextBox()
			Me.label12 = New Label()
			Me.urlPanel = New Panel()
			Me.viewHtmlLinkLabel = New LinkLabel()
			Me.enterUrlLabel = New Label()
			Me.urlTextBox = New TextBox()
			Me.selectHtmlToConvertPanel = New Panel()
			Me.convertHtmlRadioButton = New RadioButton()
			Me.convertUrlRadioButton = New RadioButton()
			Me.descriptionPanel = New Panel()
			Me.descriptionLabel = New Label()
			Me.titlePanel = New Panel()
			Me.titleLabel = New Label()
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.convertButtonPanel.SuspendLayout()
			Me.selectTriggeringModePanel.SuspendLayout()
			Me.conversionDelayPanel.SuspendLayout()
			Me.htmlPanel.SuspendLayout()
			Me.urlPanel.SuspendLayout()
			Me.selectHtmlToConvertPanel.SuspendLayout()
			Me.descriptionPanel.SuspendLayout()
			Me.titlePanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 701)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 43)
			Me.convertButtonPanel.TabIndex = 137
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
			' selectTriggeringModePanel
			' 
			Me.selectTriggeringModePanel.Controls.Add(Me.conversionDelayPanel)
			Me.selectTriggeringModePanel.Controls.Add(Me.manualRadioButton)
			Me.selectTriggeringModePanel.Controls.Add(Me.delayedRadioButton)
			Me.selectTriggeringModePanel.Controls.Add(Me.autoRadioButton)
			Me.selectTriggeringModePanel.Controls.Add(Me.label1)
			Me.selectTriggeringModePanel.Dock = DockStyle.Top
			Me.selectTriggeringModePanel.Location = New Point(6, 615)
			Me.selectTriggeringModePanel.Name = "selectTriggeringModePanel"
			Me.selectTriggeringModePanel.Size = New Size(598, 86)
			Me.selectTriggeringModePanel.TabIndex = 136
			' 
			' conversionDelayPanel
			' 
			Me.conversionDelayPanel.Controls.Add(Me.label9)
			Me.conversionDelayPanel.Controls.Add(Me.label8)
			Me.conversionDelayPanel.Controls.Add(Me.conversionDelayTextBox)
			Me.conversionDelayPanel.Location = New Point(344, 31)
			Me.conversionDelayPanel.Name = "conversionDelayPanel"
			Me.conversionDelayPanel.Size = New Size(240, 49)
			Me.conversionDelayPanel.TabIndex = 42
			Me.conversionDelayPanel.Visible = False
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New Point(15, 17)
			Me.label9.Name = "label9"
			Me.label9.Size = New Size(121, 16)
			Me.label9.TabIndex = 48
			Me.label9.Text = "Delay Conversion :"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New Point(176, 17)
			Me.label8.Name = "label8"
			Me.label8.Size = New Size(30, 16)
			Me.label8.TabIndex = 47
			Me.label8.Text = "sec"
			' 
			' conversionDelayTextBox
			' 
			Me.conversionDelayTextBox.Location = New Point(142, 14)
			Me.conversionDelayTextBox.Name = "conversionDelayTextBox"
			Me.conversionDelayTextBox.Size = New Size(30, 21)
			Me.conversionDelayTextBox.TabIndex = 49
			Me.conversionDelayTextBox.Text = "3"
			' 
			' manualRadioButton
			' 
			Me.manualRadioButton.AutoSize = True
			Me.manualRadioButton.Location = New Point(222, 46)
			Me.manualRadioButton.Name = "manualRadioButton"
			Me.manualRadioButton.Size = New Size(73, 20)
			Me.manualRadioButton.TabIndex = 41
			Me.manualRadioButton.Text = "Manual"
			Me.manualRadioButton.UseVisualStyleBackColor = True
'			Me.manualRadioButton.CheckedChanged += New System.EventHandler(Me.manualRadioButton_CheckedChanged)
			' 
			' delayedRadioButton
			' 
			Me.delayedRadioButton.AutoSize = True
			Me.delayedRadioButton.Location = New Point(119, 46)
			Me.delayedRadioButton.Name = "delayedRadioButton"
			Me.delayedRadioButton.Size = New Size(81, 20)
			Me.delayedRadioButton.TabIndex = 41
			Me.delayedRadioButton.Text = "Delayed"
			Me.delayedRadioButton.UseVisualStyleBackColor = True
'			Me.delayedRadioButton.CheckedChanged += New System.EventHandler(Me.delayedRadioButton_CheckedChanged)
			' 
			' autoRadioButton
			' 
			Me.autoRadioButton.AutoSize = True
			Me.autoRadioButton.Checked = True
			Me.autoRadioButton.Location = New Point(32, 46)
			Me.autoRadioButton.Name = "autoRadioButton"
			Me.autoRadioButton.Size = New Size(56, 20)
			Me.autoRadioButton.TabIndex = 41
			Me.autoRadioButton.TabStop = True
			Me.autoRadioButton.Text = "Auto"
			Me.autoRadioButton.UseVisualStyleBackColor = True
'			Me.autoRadioButton.CheckedChanged += New System.EventHandler(Me.autoRadioButton_CheckedChanged)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label1.Location = New Point(6, 18)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(171, 16)
			Me.label1.TabIndex = 40
			Me.label1.Text = "Select Triggering Mode"
			' 
			' htmlPanel
			' 
			Me.htmlPanel.Controls.Add(Me.label2)
			Me.htmlPanel.Controls.Add(Me.baseUrlTextBox)
			Me.htmlPanel.Controls.Add(Me.htmlStringTextBox)
			Me.htmlPanel.Controls.Add(Me.label12)
			Me.htmlPanel.Dock = DockStyle.Top
			Me.htmlPanel.Location = New Point(6, 248)
			Me.htmlPanel.Name = "htmlPanel"
			Me.htmlPanel.Size = New Size(598, 367)
			Me.htmlPanel.TabIndex = 135
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label2.Location = New Point(6, 321)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(78, 16)
			Me.label2.TabIndex = 48
			Me.label2.Text = "Base URL"
			' 
			' baseUrlTextBox
			' 
			Me.baseUrlTextBox.Location = New Point(9, 339)
			Me.baseUrlTextBox.Name = "baseUrlTextBox"
			Me.baseUrlTextBox.Size = New Size(575, 21)
			Me.baseUrlTextBox.TabIndex = 49
			' 
			' htmlStringTextBox
			' 
			Me.htmlStringTextBox.Location = New Point(9, 26)
			Me.htmlStringTextBox.MaxLength = 1000000
			Me.htmlStringTextBox.Multiline = True
			Me.htmlStringTextBox.Name = "htmlStringTextBox"
			Me.htmlStringTextBox.ScrollBars = ScrollBars.Vertical
			Me.htmlStringTextBox.Size = New Size(574, 292)
			Me.htmlStringTextBox.TabIndex = 43
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label12.Location = New Point(6, 6)
			Me.label12.Name = "label12"
			Me.label12.Size = New Size(253, 16)
			Me.label12.TabIndex = 42
			Me.label12.Text = "HTML String with Manual Triggering"
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.viewHtmlLinkLabel)
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 166)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 82)
			Me.urlPanel.TabIndex = 134
			Me.urlPanel.Visible = False
			' 
			' viewHtmlLinkLabel
			' 
			Me.viewHtmlLinkLabel.AutoSize = True
			Me.viewHtmlLinkLabel.Location = New Point(515, 47)
			Me.viewHtmlLinkLabel.Name = "viewHtmlLinkLabel"
			Me.viewHtmlLinkLabel.Size = New Size(77, 16)
			Me.viewHtmlLinkLabel.TabIndex = 48
			Me.viewHtmlLinkLabel.TabStop = True
			Me.viewHtmlLinkLabel.Text = "View HTML"
'			Me.viewHtmlLinkLabel.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.viewHtmlLinkLabel_LinkClicked)
			' 
			' enterUrlLabel
			' 
			Me.enterUrlLabel.AutoSize = True
			Me.enterUrlLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.enterUrlLabel.Location = New Point(6, 12)
			Me.enterUrlLabel.Name = "enterUrlLabel"
			Me.enterUrlLabel.Size = New Size(288, 16)
			Me.enterUrlLabel.TabIndex = 40
			Me.enterUrlLabel.Text = "HTML Page URL or Local File to Convert"
			' 
			' urlTextBox
			' 
			Me.urlTextBox.Location = New Point(9, 44)
			Me.urlTextBox.Name = "urlTextBox"
			Me.urlTextBox.Size = New Size(500, 21)
			Me.urlTextBox.TabIndex = 41
			' 
			' selectHtmlToConvertPanel
			' 
			Me.selectHtmlToConvertPanel.Controls.Add(Me.convertHtmlRadioButton)
			Me.selectHtmlToConvertPanel.Controls.Add(Me.convertUrlRadioButton)
			Me.selectHtmlToConvertPanel.Dock = DockStyle.Top
			Me.selectHtmlToConvertPanel.Location = New Point(6, 133)
			Me.selectHtmlToConvertPanel.Name = "selectHtmlToConvertPanel"
			Me.selectHtmlToConvertPanel.Size = New Size(598, 33)
			Me.selectHtmlToConvertPanel.TabIndex = 133
			' 
			' convertHtmlRadioButton
			' 
			Me.convertHtmlRadioButton.AutoSize = True
			Me.convertHtmlRadioButton.Checked = True
			Me.convertHtmlRadioButton.Location = New Point(9, 8)
			Me.convertHtmlRadioButton.Name = "convertHtmlRadioButton"
			Me.convertHtmlRadioButton.Size = New Size(152, 20)
			Me.convertHtmlRadioButton.TabIndex = 69
			Me.convertHtmlRadioButton.TabStop = True
			Me.convertHtmlRadioButton.Text = "Convert HTML String"
			Me.convertHtmlRadioButton.UseVisualStyleBackColor = True
'			Me.convertHtmlRadioButton.CheckedChanged += New System.EventHandler(Me.convertHtmlRadioButton_CheckedChanged)
			' 
			' convertUrlRadioButton
			' 
			Me.convertUrlRadioButton.AutoSize = True
			Me.convertUrlRadioButton.Location = New Point(222, 8)
			Me.convertUrlRadioButton.Name = "convertUrlRadioButton"
			Me.convertUrlRadioButton.Size = New Size(181, 20)
			Me.convertUrlRadioButton.TabIndex = 68
			Me.convertUrlRadioButton.Text = "Convert URL or Local File"
			Me.convertUrlRadioButton.UseVisualStyleBackColor = True
'			Me.convertUrlRadioButton.CheckedChanged += New System.EventHandler(Me.convertUrlRadioButton_CheckedChanged)
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 87)
			Me.descriptionPanel.TabIndex = 132
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 87)
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
			Me.titlePanel.TabIndex = 131
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(273, 18)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Select Conversion Triggering Mode"
			' 
			' demoLeftPanel
			' 
			Me.demoLeftPanel.Dock = DockStyle.Left
			Me.demoLeftPanel.Location = New Point(0, 6)
			Me.demoLeftPanel.Name = "demoLeftPanel"
			Me.demoLeftPanel.Size = New Size(6, 761)
			Me.demoLeftPanel.TabIndex = 130
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 761)
			Me.demoRightPanel.TabIndex = 129
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 767)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 128
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 127
			' 
			' Conversion_Triggering_Modes_Demo
			' 
			Me.AutoScaleDimensions = New SizeF(7F, 15F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScroll = True
			Me.Controls.Add(Me.convertButtonPanel)
			Me.Controls.Add(Me.selectTriggeringModePanel)
			Me.Controls.Add(Me.htmlPanel)
			Me.Controls.Add(Me.urlPanel)
			Me.Controls.Add(Me.selectHtmlToConvertPanel)
			Me.Controls.Add(Me.descriptionPanel)
			Me.Controls.Add(Me.titlePanel)
			Me.Controls.Add(Me.demoLeftPanel)
			Me.Controls.Add(Me.demoRightPanel)
			Me.Controls.Add(Me.demoBottomPanel)
			Me.Controls.Add(Me.demoTopPanel)
			Me.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.Name = "Conversion_Triggering_Modes_Demo"
			Me.Size = New Size(610, 773)
'			Me.Load += New System.EventHandler(Me.Conversion_Triggering_Modes_Demo_Load)
			Me.convertButtonPanel.ResumeLayout(False)
			Me.selectTriggeringModePanel.ResumeLayout(False)
			Me.selectTriggeringModePanel.PerformLayout()
			Me.conversionDelayPanel.ResumeLayout(False)
			Me.conversionDelayPanel.PerformLayout()
			Me.htmlPanel.ResumeLayout(False)
			Me.htmlPanel.PerformLayout()
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

		Private convertButtonPanel As Panel
		Private WithEvents convertToPdfButton As Button
		Private selectTriggeringModePanel As Panel
		Private WithEvents delayedRadioButton As RadioButton
		Private WithEvents autoRadioButton As RadioButton
		Private label1 As Label
		Private htmlPanel As Panel
		Private label2 As Label
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
		Private demoLeftPanel As Panel
		Private demoRightPanel As Panel
		Private demoBottomPanel As Panel
		Private demoTopPanel As Panel
		Private conversionDelayPanel As Panel
		Private WithEvents manualRadioButton As RadioButton
		Private label9 As Label
		Private label8 As Label
		Private conversionDelayTextBox As TextBox
		Private WithEvents viewHtmlLinkLabel As LinkLabel
	End Class
End Namespace

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions
	Partial Public Class Execute_JavaScript_Button_Clicked_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Execute_JavaScript_Button_Clicked_Demo))
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.htmlPanel = New Panel()
			Me.label2 = New Label()
			Me.baseUrlTextBox = New TextBox()
			Me.htmlStringTextBox = New TextBox()
			Me.label12 = New Label()
			Me.descriptionPanel = New Panel()
			Me.descriptionLabel = New Label()
			Me.titlePanel = New Panel()
			Me.titleLabel = New Label()
			Me.settingsPanel = New Panel()
			Me.zoomLevelPanel = New Panel()
			Me.label4 = New Label()
			Me.zoomLevelTextBox = New TextBox()
			Me.alertMessagePanel = New Panel()
			Me.alertMessageTextBox = New TextBox()
			Me.zoomLevelRadioButton = New RadioButton()
			Me.printDialogRadioButton = New RadioButton()
			Me.alertMessageRadioButton = New RadioButton()
			Me.label1 = New Label()
			Me.convertButtonPanel = New Panel()
			Me.convertToPdfButton = New Button()
			Me.htmlPanel.SuspendLayout()
			Me.descriptionPanel.SuspendLayout()
			Me.titlePanel.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			Me.zoomLevelPanel.SuspendLayout()
			Me.alertMessagePanel.SuspendLayout()
			Me.convertButtonPanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' demoLeftPanel
			' 
			Me.demoLeftPanel.Dock = DockStyle.Left
			Me.demoLeftPanel.Location = New Point(0, 6)
			Me.demoLeftPanel.Name = "demoLeftPanel"
			Me.demoLeftPanel.Size = New Size(6, 638)
			Me.demoLeftPanel.TabIndex = 153
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 152
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 644)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 151
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 150
			' 
			' htmlPanel
			' 
			Me.htmlPanel.Controls.Add(Me.label2)
			Me.htmlPanel.Controls.Add(Me.baseUrlTextBox)
			Me.htmlPanel.Controls.Add(Me.htmlStringTextBox)
			Me.htmlPanel.Controls.Add(Me.label12)
			Me.htmlPanel.Dock = DockStyle.Top
			Me.htmlPanel.Location = New Point(6, 108)
			Me.htmlPanel.Name = "htmlPanel"
			Me.htmlPanel.Size = New Size(598, 331)
			Me.htmlPanel.TabIndex = 164
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label2.Location = New Point(6, 269)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(71, 15)
			Me.label2.TabIndex = 48
			Me.label2.Text = "Base URL"
			' 
			' baseUrlTextBox
			' 
			Me.baseUrlTextBox.Location = New Point(9, 287)
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
			Me.htmlStringTextBox.Size = New Size(574, 230)
			Me.htmlStringTextBox.TabIndex = 43
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label12.Location = New Point(6, 6)
			Me.label12.Name = "label12"
			Me.label12.Size = New Size(174, 15)
			Me.label12.TabIndex = 42
			Me.label12.Text = "HTML String with a Button"
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 62)
			Me.descriptionPanel.TabIndex = 161
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 62)
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
			Me.titlePanel.TabIndex = 160
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(431, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Execute Acrobat JavaScript Code when a Button is Clicked"
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.zoomLevelPanel)
			Me.settingsPanel.Controls.Add(Me.alertMessagePanel)
			Me.settingsPanel.Controls.Add(Me.zoomLevelRadioButton)
			Me.settingsPanel.Controls.Add(Me.printDialogRadioButton)
			Me.settingsPanel.Controls.Add(Me.alertMessageRadioButton)
			Me.settingsPanel.Controls.Add(Me.label1)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 439)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 146)
			Me.settingsPanel.TabIndex = 166
			' 
			' zoomLevelPanel
			' 
			Me.zoomLevelPanel.Controls.Add(Me.label4)
			Me.zoomLevelPanel.Controls.Add(Me.zoomLevelTextBox)
			Me.zoomLevelPanel.Location = New Point(162, 91)
			Me.zoomLevelPanel.Name = "zoomLevelPanel"
			Me.zoomLevelPanel.Size = New Size(85, 45)
			Me.zoomLevelPanel.TabIndex = 44
			Me.zoomLevelPanel.Visible = False
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New Point(56, 18)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(18, 15)
			Me.label4.TabIndex = 1
			Me.label4.Text = "%"
			' 
			' zoomLevelTextBox
			' 
			Me.zoomLevelTextBox.Location = New Point(12, 15)
			Me.zoomLevelTextBox.Name = "zoomLevelTextBox"
			Me.zoomLevelTextBox.Size = New Size(38, 21)
			Me.zoomLevelTextBox.TabIndex = 0
			Me.zoomLevelTextBox.Text = "150"
			' 
			' alertMessagePanel
			' 
			Me.alertMessagePanel.Controls.Add(Me.alertMessageTextBox)
			Me.alertMessagePanel.Location = New Point(221, 18)
			Me.alertMessagePanel.Name = "alertMessagePanel"
			Me.alertMessagePanel.Size = New Size(373, 39)
			Me.alertMessagePanel.TabIndex = 44
			' 
			' alertMessageTextBox
			' 
			Me.alertMessageTextBox.Location = New Point(3, 14)
			Me.alertMessageTextBox.Name = "alertMessageTextBox"
			Me.alertMessageTextBox.Size = New Size(360, 21)
			Me.alertMessageTextBox.TabIndex = 0
			Me.alertMessageTextBox.Text = "PDF Action: Alert message from JavaScript !"
			' 
			' zoomLevelRadioButton
			' 
			Me.zoomLevelRadioButton.AutoSize = True
			Me.zoomLevelRadioButton.Location = New Point(34, 107)
			Me.zoomLevelRadioButton.Name = "zoomLevelRadioButton"
			Me.zoomLevelRadioButton.Size = New Size(117, 20)
			Me.zoomLevelRadioButton.TabIndex = 43
			Me.zoomLevelRadioButton.Text = "Set Zoom Level"
			Me.zoomLevelRadioButton.UseVisualStyleBackColor = True
'			Me.zoomLevelRadioButton.CheckedChanged += New System.EventHandler(Me.zoomLevelRadioButton_CheckedChanged)
			' 
			' printDialogRadioButton
			' 
			Me.printDialogRadioButton.AutoSize = True
			Me.printDialogRadioButton.Location = New Point(34, 70)
			Me.printDialogRadioButton.Name = "printDialogRadioButton"
			Me.printDialogRadioButton.Size = New Size(129, 20)
			Me.printDialogRadioButton.TabIndex = 43
			Me.printDialogRadioButton.Text = "Open Print Dialog"
			Me.printDialogRadioButton.UseVisualStyleBackColor = True
'			Me.printDialogRadioButton.CheckedChanged += New System.EventHandler(Me.printDialogRadioButton_CheckedChanged)
			' 
			' alertMessageRadioButton
			' 
			Me.alertMessageRadioButton.AutoSize = True
			Me.alertMessageRadioButton.Checked = True
			Me.alertMessageRadioButton.Location = New Point(34, 32)
			Me.alertMessageRadioButton.Name = "alertMessageRadioButton"
			Me.alertMessageRadioButton.Size = New Size(170, 20)
			Me.alertMessageRadioButton.TabIndex = 43
			Me.alertMessageRadioButton.TabStop = True
			Me.alertMessageRadioButton.Text = "Display an Alert Message"
			Me.alertMessageRadioButton.UseVisualStyleBackColor = True
'			Me.alertMessageRadioButton.CheckedChanged += New System.EventHandler(Me.alertMessageRadioButton_CheckedChanged)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label1.Location = New Point(6, 3)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(175, 15)
			Me.label1.TabIndex = 42
			Me.label1.Text = "Acrobat JavaScript Actions"
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 585)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 43)
			Me.convertButtonPanel.TabIndex = 167
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
			' Execute_JavaScript_Button_Clicked_Demo
			' 
			Me.AutoScaleDimensions = New SizeF(7F, 15F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScroll = True
			Me.Controls.Add(Me.convertButtonPanel)
			Me.Controls.Add(Me.settingsPanel)
			Me.Controls.Add(Me.htmlPanel)
			Me.Controls.Add(Me.descriptionPanel)
			Me.Controls.Add(Me.titlePanel)
			Me.Controls.Add(Me.demoLeftPanel)
			Me.Controls.Add(Me.demoRightPanel)
			Me.Controls.Add(Me.demoBottomPanel)
			Me.Controls.Add(Me.demoTopPanel)
			Me.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.Name = "Execute_JavaScript_Button_Clicked_Demo"
			Me.Size = New Size(610, 650)
'			Me.Load += New System.EventHandler(Me.Execute_JavaScript_Button_Clicked_Demo_Load)
			Me.htmlPanel.ResumeLayout(False)
			Me.htmlPanel.PerformLayout()
			Me.descriptionPanel.ResumeLayout(False)
			Me.titlePanel.ResumeLayout(False)
			Me.titlePanel.PerformLayout()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			Me.zoomLevelPanel.ResumeLayout(False)
			Me.zoomLevelPanel.PerformLayout()
			Me.alertMessagePanel.ResumeLayout(False)
			Me.alertMessagePanel.PerformLayout()
			Me.convertButtonPanel.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private demoLeftPanel As Panel
		Private demoRightPanel As Panel
		Private demoBottomPanel As Panel
		Private demoTopPanel As Panel
		Private htmlPanel As Panel
		Private label2 As Label
		Private baseUrlTextBox As TextBox
		Private htmlStringTextBox As TextBox
		Private label12 As Label
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
		Private settingsPanel As Panel
		Private zoomLevelPanel As Panel
		Private label4 As Label
		Private zoomLevelTextBox As TextBox
		Private alertMessagePanel As Panel
		Private alertMessageTextBox As TextBox
		Private WithEvents zoomLevelRadioButton As RadioButton
		Private WithEvents printDialogRadioButton As RadioButton
		Private WithEvents alertMessageRadioButton As RadioButton
		Private label1 As Label
		Private convertButtonPanel As Panel
		Private WithEvents convertToPdfButton As Button
	End Class
End Namespace

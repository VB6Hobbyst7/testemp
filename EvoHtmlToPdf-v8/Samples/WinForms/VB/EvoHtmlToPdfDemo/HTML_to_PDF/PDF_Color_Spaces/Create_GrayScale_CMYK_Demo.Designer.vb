Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Color_Spaces
	Partial Public Class Create_GrayScale_CMYK_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Create_GrayScale_CMYK_Demo))
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.convertButtonPanel = New Panel()
			Me.convertToPdfButton = New Button()
			Me.settingsPanel = New Panel()
			Me.cmykRadioButton = New RadioButton()
			Me.grayScaleRadioButton = New RadioButton()
			Me.rgbRadioButton = New RadioButton()
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
			Me.demoLeftPanel.TabIndex = 151
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 150
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 644)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 149
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 148
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 243)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 43)
			Me.convertButtonPanel.TabIndex = 173
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
			Me.settingsPanel.Controls.Add(Me.cmykRadioButton)
			Me.settingsPanel.Controls.Add(Me.grayScaleRadioButton)
			Me.settingsPanel.Controls.Add(Me.rgbRadioButton)
			Me.settingsPanel.Controls.Add(Me.label2)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 180)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 63)
			Me.settingsPanel.TabIndex = 172
			' 
			' cmykRadioButton
			' 
			Me.cmykRadioButton.AutoSize = True
			Me.cmykRadioButton.Location = New Point(229, 32)
			Me.cmykRadioButton.Name = "cmykRadioButton"
			Me.cmykRadioButton.Size = New Size(66, 20)
			Me.cmykRadioButton.TabIndex = 54
			Me.cmykRadioButton.Text = "CMYK"
			Me.cmykRadioButton.UseVisualStyleBackColor = True
			' 
			' grayScaleRadioButton
			' 
			Me.grayScaleRadioButton.AutoSize = True
			Me.grayScaleRadioButton.Location = New Point(109, 32)
			Me.grayScaleRadioButton.Name = "grayScaleRadioButton"
			Me.grayScaleRadioButton.Size = New Size(91, 20)
			Me.grayScaleRadioButton.TabIndex = 54
			Me.grayScaleRadioButton.Text = "Gray Scale"
			Me.grayScaleRadioButton.UseVisualStyleBackColor = True
			' 
			' rgbRadioButton
			' 
			Me.rgbRadioButton.AutoSize = True
			Me.rgbRadioButton.Checked = True
			Me.rgbRadioButton.Location = New Point(21, 32)
			Me.rgbRadioButton.Name = "rgbRadioButton"
			Me.rgbRadioButton.Size = New Size(58, 20)
			Me.rgbRadioButton.TabIndex = 54
			Me.rgbRadioButton.TabStop = True
			Me.rgbRadioButton.Text = "RGB"
			Me.rgbRadioButton.UseVisualStyleBackColor = True
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label2.Location = New Point(3, 3)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(85, 15)
			Me.label2.TabIndex = 53
			Me.label2.Text = "Color Space"
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 110)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 70)
			Me.urlPanel.TabIndex = 171
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
			Me.descriptionPanel.Size = New Size(598, 64)
			Me.descriptionPanel.TabIndex = 170
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 64)
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
			Me.titlePanel.TabIndex = 169
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(409, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Convert HTML to GrayScale and CMYK PDF Documents"
			' 
			' Create_GrayScale_CMYK_Demo
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
			Me.Name = "Create_GrayScale_CMYK_Demo"
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
		Private cmykRadioButton As RadioButton
		Private grayScaleRadioButton As RadioButton
		Private rgbRadioButton As RadioButton
		Private label2 As Label
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
	End Class
End Namespace

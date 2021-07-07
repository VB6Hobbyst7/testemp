Namespace EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences
	Partial Public Class Set_Initial_Zoom_Level_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Set_Initial_Zoom_Level_Demo))
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.convertButtonPanel = New Panel()
			Me.convertToPdfButton = New Button()
			Me.settingsPanel = New Panel()
			Me.label24 = New Label()
			Me.label25 = New Label()
			Me.label27 = New Label()
			Me.label28 = New Label()
			Me.yLocationTextBox = New TextBox()
			Me.xLocationTextBox = New TextBox()
			Me.zoomLevelPanel = New Panel()
			Me.label9 = New Label()
			Me.zoomLevelTextBox = New TextBox()
			Me.label2 = New Label()
			Me.viewModeComboBox = New ComboBox()
			Me.label8 = New Label()
			Me.label5 = New Label()
			Me.label3 = New Label()
			Me.pageNumberTextBox = New TextBox()
			Me.urlPanel = New Panel()
			Me.enterUrlLabel = New Label()
			Me.urlTextBox = New TextBox()
			Me.descriptionPanel = New Panel()
			Me.descriptionLabel = New Label()
			Me.titlePanel = New Panel()
			Me.titleLabel = New Label()
			Me.convertButtonPanel.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			Me.zoomLevelPanel.SuspendLayout()
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
			Me.demoLeftPanel.TabIndex = 155
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 154
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 644)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 153
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 152
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 310)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 43)
			Me.convertButtonPanel.TabIndex = 178
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
			Me.settingsPanel.Controls.Add(Me.label24)
			Me.settingsPanel.Controls.Add(Me.label25)
			Me.settingsPanel.Controls.Add(Me.label27)
			Me.settingsPanel.Controls.Add(Me.label28)
			Me.settingsPanel.Controls.Add(Me.yLocationTextBox)
			Me.settingsPanel.Controls.Add(Me.xLocationTextBox)
			Me.settingsPanel.Controls.Add(Me.zoomLevelPanel)
			Me.settingsPanel.Controls.Add(Me.viewModeComboBox)
			Me.settingsPanel.Controls.Add(Me.label8)
			Me.settingsPanel.Controls.Add(Me.label5)
			Me.settingsPanel.Controls.Add(Me.label3)
			Me.settingsPanel.Controls.Add(Me.pageNumberTextBox)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 174)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 136)
			Me.settingsPanel.TabIndex = 177
			' 
			' label24
			' 
			Me.label24.AutoSize = True
			Me.label24.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label24.Location = New Point(274, 55)
			Me.label24.Name = "label24"
			Me.label24.Size = New Size(17, 15)
			Me.label24.TabIndex = 154
			Me.label24.Text = "pt"
			' 
			' label25
			' 
			Me.label25.AutoSize = True
			Me.label25.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label25.Location = New Point(183, 55)
			Me.label25.Name = "label25"
			Me.label25.Size = New Size(17, 15)
			Me.label25.TabIndex = 153
			Me.label25.Text = "pt"
			' 
			' label27
			' 
			Me.label27.AutoSize = True
			Me.label27.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label27.Location = New Point(214, 55)
			Me.label27.Name = "label27"
			Me.label27.Size = New Size(17, 15)
			Me.label27.TabIndex = 152
			Me.label27.Text = "Y:"
			' 
			' label28
			' 
			Me.label28.AutoSize = True
			Me.label28.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label28.Location = New Point(123, 55)
			Me.label28.Name = "label28"
			Me.label28.Size = New Size(18, 15)
			Me.label28.TabIndex = 151
			Me.label28.Text = "X:"
			' 
			' yLocationTextBox
			' 
			Me.yLocationTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.yLocationTextBox.Location = New Point(236, 52)
			Me.yLocationTextBox.Name = "yLocationTextBox"
			Me.yLocationTextBox.Size = New Size(32, 21)
			Me.yLocationTextBox.TabIndex = 149
			Me.yLocationTextBox.Text = "50"
			' 
			' xLocationTextBox
			' 
			Me.xLocationTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.xLocationTextBox.Location = New Point(146, 52)
			Me.xLocationTextBox.Name = "xLocationTextBox"
			Me.xLocationTextBox.Size = New Size(31, 21)
			Me.xLocationTextBox.TabIndex = 150
			Me.xLocationTextBox.Text = "50"
			' 
			' zoomLevelPanel
			' 
			Me.zoomLevelPanel.Controls.Add(Me.label9)
			Me.zoomLevelPanel.Controls.Add(Me.zoomLevelTextBox)
			Me.zoomLevelPanel.Controls.Add(Me.label2)
			Me.zoomLevelPanel.Location = New Point(194, 78)
			Me.zoomLevelPanel.Name = "zoomLevelPanel"
			Me.zoomLevelPanel.Size = New Size(173, 47)
			Me.zoomLevelPanel.TabIndex = 148
			Me.zoomLevelPanel.Visible = False
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New Point(136, 15)
			Me.label9.Name = "label9"
			Me.label9.Size = New Size(18, 15)
			Me.label9.TabIndex = 1
			Me.label9.Text = "%"
			' 
			' zoomLevelTextBox
			' 
			Me.zoomLevelTextBox.Location = New Point(92, 12)
			Me.zoomLevelTextBox.Name = "zoomLevelTextBox"
			Me.zoomLevelTextBox.Size = New Size(38, 21)
			Me.zoomLevelTextBox.TabIndex = 0
			Me.zoomLevelTextBox.Text = "150"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New Point(12, 15)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(74, 15)
			Me.label2.TabIndex = 45
			Me.label2.Text = "Zoom Level:"
			' 
			' viewModeComboBox
			' 
			Me.viewModeComboBox.DropDownStyle = ComboBoxStyle.DropDownList
			Me.viewModeComboBox.FormattingEnabled = True
			Me.viewModeComboBox.Items.AddRange(New Object() { "X, Y and Zoom", "Fit Window", "Fit Horizontally", "Fit Vertically"})
			Me.viewModeComboBox.Location = New Point(83, 90)
			Me.viewModeComboBox.Name = "viewModeComboBox"
			Me.viewModeComboBox.Size = New Size(105, 23)
			Me.viewModeComboBox.TabIndex = 147
'			Me.viewModeComboBox.SelectedIndexChanged += New System.EventHandler(Me.viewModeComboBox_SelectedIndexChanged)
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New Point(6, 93)
			Me.label8.Name = "label8"
			Me.label8.Size = New Size(71, 15)
			Me.label8.TabIndex = 144
			Me.label8.Text = "View Mode:"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New Point(6, 55)
			Me.label5.Name = "label5"
			Me.label5.Size = New Size(89, 15)
			Me.label5.TabIndex = 145
			Me.label5.Text = "Initial Location:"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New Point(6, 18)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(119, 15)
			Me.label3.TabIndex = 146
			Me.label3.Text = "Initial Page Number:"
			' 
			' pageNumberTextBox
			' 
			Me.pageNumberTextBox.Location = New Point(131, 15)
			Me.pageNumberTextBox.Name = "pageNumberTextBox"
			Me.pageNumberTextBox.Size = New Size(38, 21)
			Me.pageNumberTextBox.TabIndex = 143
			Me.pageNumberTextBox.Text = "1"
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 104)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 70)
			Me.urlPanel.TabIndex = 176
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
            Me.urlTextBox.Text = "http://www.evopdf.com/DemoAppFiles/HTML_Files/Structured_HTML.html"
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 58)
			Me.descriptionPanel.TabIndex = 175
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 58)
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
			Me.titlePanel.TabIndex = 174
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(406, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Set Initial Zoom Level of the Generated PDF Document"
			' 
			' Set_Initial_Zoom_Level_Demo
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
			Me.Name = "Set_Initial_Zoom_Level_Demo"
			Me.Size = New Size(610, 650)
'			Me.Load += New System.EventHandler(Me.Set_Initial_Zoom_Level_Demo_Load)
			Me.convertButtonPanel.ResumeLayout(False)
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			Me.zoomLevelPanel.ResumeLayout(False)
			Me.zoomLevelPanel.PerformLayout()
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
		Private label24 As Label
		Private label25 As Label
		Private label27 As Label
		Private label28 As Label
		Private yLocationTextBox As TextBox
		Private xLocationTextBox As TextBox
		Private zoomLevelPanel As Panel
		Private label9 As Label
		Private zoomLevelTextBox As TextBox
		Private label2 As Label
		Private WithEvents viewModeComboBox As ComboBox
		Private label8 As Label
		Private label5 As Label
		Private label3 As Label
		Private pageNumberTextBox As TextBox

	End Class
End Namespace

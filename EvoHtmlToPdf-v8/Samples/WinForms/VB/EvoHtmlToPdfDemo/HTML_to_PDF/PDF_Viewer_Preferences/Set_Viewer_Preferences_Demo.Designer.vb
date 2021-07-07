Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences
	Partial Public Class Set_Viewer_Preferences_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Set_Viewer_Preferences_Demo))
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.convertButtonPanel = New Panel()
			Me.convertToPdfButton = New Button()
			Me.settingsPanel = New Panel()
			Me.label4 = New Label()
			Me.label3 = New Label()
			Me.pageModeComboBox = New ComboBox()
			Me.label2 = New Label()
			Me.pageLayoutComboBox = New ComboBox()
			Me.displayDocTitleCheckBox = New CheckBox()
			Me.hideWindowUICheckBox = New CheckBox()
			Me.hideToolbarCheckBox = New CheckBox()
			Me.hideMenuBarCheckBox = New CheckBox()
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
			Me.demoLeftPanel.TabIndex = 159
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 158
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 644)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 157
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 156
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 295)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 43)
			Me.convertButtonPanel.TabIndex = 183
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
			Me.settingsPanel.Controls.Add(Me.label4)
			Me.settingsPanel.Controls.Add(Me.label3)
			Me.settingsPanel.Controls.Add(Me.pageModeComboBox)
			Me.settingsPanel.Controls.Add(Me.label2)
			Me.settingsPanel.Controls.Add(Me.pageLayoutComboBox)
			Me.settingsPanel.Controls.Add(Me.displayDocTitleCheckBox)
			Me.settingsPanel.Controls.Add(Me.hideWindowUICheckBox)
			Me.settingsPanel.Controls.Add(Me.hideToolbarCheckBox)
			Me.settingsPanel.Controls.Add(Me.hideMenuBarCheckBox)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 174)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 121)
			Me.settingsPanel.TabIndex = 182
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label4.Location = New Point(3, 12)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(162, 15)
			Me.label4.TabIndex = 50
			Me.label4.Text = "PDF Viewer Preferences"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New Point(32, 44)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(74, 15)
			Me.label3.TabIndex = 2
			Me.label3.Text = "Page Mode:"
			' 
			' pageModeComboBox
			' 
			Me.pageModeComboBox.DropDownStyle = ComboBoxStyle.DropDownList
			Me.pageModeComboBox.FormattingEnabled = True
			Me.pageModeComboBox.Items.AddRange(New Object() { "Default", "Display Outlines", "Display Thumbnails", "Display Full Screen", "Display Optional Content Group", "Display Attachments"})
			Me.pageModeComboBox.Location = New Point(120, 41)
			Me.pageModeComboBox.Name = "pageModeComboBox"
			Me.pageModeComboBox.Size = New Size(189, 23)
			Me.pageModeComboBox.TabIndex = 1
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New Point(332, 44)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(78, 15)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Page Layout:"
			' 
			' pageLayoutComboBox
			' 
			Me.pageLayoutComboBox.DropDownStyle = ComboBoxStyle.DropDownList
			Me.pageLayoutComboBox.FormattingEnabled = True
			Me.pageLayoutComboBox.Items.AddRange(New Object() { "Single Page", "One Column", "Two Column Left", "Two Column Right"})
			Me.pageLayoutComboBox.Location = New Point(425, 41)
			Me.pageLayoutComboBox.Name = "pageLayoutComboBox"
			Me.pageLayoutComboBox.Size = New Size(121, 23)
			Me.pageLayoutComboBox.TabIndex = 1
			' 
			' displayDocTitleCheckBox
			' 
			Me.displayDocTitleCheckBox.AutoSize = True
			Me.displayDocTitleCheckBox.Location = New Point(405, 90)
			Me.displayDocTitleCheckBox.Name = "displayDocTitleCheckBox"
			Me.displayDocTitleCheckBox.Size = New Size(159, 21)
			Me.displayDocTitleCheckBox.TabIndex = 0
			Me.displayDocTitleCheckBox.Text = "Display Document Title"
			Me.displayDocTitleCheckBox.UseVisualStyleBackColor = True
			' 
			' hideWindowUICheckBox
			' 
			Me.hideWindowUICheckBox.AutoSize = True
			Me.hideWindowUICheckBox.Location = New Point(275, 90)
			Me.hideWindowUICheckBox.Name = "hideWindowUICheckBox"
			Me.hideWindowUICheckBox.Size = New Size(121, 21)
			Me.hideWindowUICheckBox.TabIndex = 0
			Me.hideWindowUICheckBox.Text = "Hide Window UI"
			Me.hideWindowUICheckBox.UseVisualStyleBackColor = True
			' 
			' hideToolbarCheckBox
			' 
			Me.hideToolbarCheckBox.AutoSize = True
			Me.hideToolbarCheckBox.Location = New Point(157, 90)
			Me.hideToolbarCheckBox.Name = "hideToolbarCheckBox"
			Me.hideToolbarCheckBox.Size = New Size(104, 21)
			Me.hideToolbarCheckBox.TabIndex = 0
			Me.hideToolbarCheckBox.Text = "Hide Toolbar"
			Me.hideToolbarCheckBox.UseVisualStyleBackColor = True
			' 
			' hideMenuBarCheckBox
			' 
			Me.hideMenuBarCheckBox.AutoSize = True
			Me.hideMenuBarCheckBox.Location = New Point(32, 90)
			Me.hideMenuBarCheckBox.Name = "hideMenuBarCheckBox"
			Me.hideMenuBarCheckBox.Size = New Size(116, 21)
			Me.hideMenuBarCheckBox.TabIndex = 0
			Me.hideMenuBarCheckBox.Text = "Hide Menu Bar"
			Me.hideMenuBarCheckBox.UseVisualStyleBackColor = True
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 104)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 70)
			Me.urlPanel.TabIndex = 181
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
			Me.descriptionPanel.TabIndex = 180
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
			Me.titlePanel.TabIndex = 179
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(460, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Set PDF Viewer Preferences for the Generated PDF Document"
			' 
			' Set_Viewer_Preferences_Demo
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
			Me.Name = "Set_Viewer_Preferences_Demo"
			Me.Size = New Size(610, 650)
'			Me.Load += New System.EventHandler(Me.Set_Viewer_Preferences_Demo_Load)
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
		Private hideToolbarCheckBox As CheckBox
		Private hideMenuBarCheckBox As CheckBox
		Private hideWindowUICheckBox As CheckBox
		Private displayDocTitleCheckBox As CheckBox
		Private label2 As Label
		Private pageLayoutComboBox As ComboBox
		Private label3 As Label
		Private pageModeComboBox As ComboBox
		Private label4 As Label
	End Class
End Namespace

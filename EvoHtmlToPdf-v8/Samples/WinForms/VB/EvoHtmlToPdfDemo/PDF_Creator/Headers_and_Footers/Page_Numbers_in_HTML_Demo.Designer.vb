Namespace EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers
	Partial Public Class Page_Numbers_in_HTML_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Page_Numbers_in_HTML_Demo))
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.convertButtonPanel = New Panel()
			Me.createPdfButton = New Button()
			Me.settingsPanel = New Panel()
			Me.label14 = New Label()
			Me.label8 = New Label()
			Me.footerSpacingTextBox = New TextBox()
			Me.drawFooterLineCheckBox = New CheckBox()
			Me.urlPanel = New Panel()
			Me.label1 = New Label()
			Me.baseUrlTextBox = New TextBox()
			Me.htmlWithPageNumbersTextBox = New TextBox()
			Me.label12 = New Label()
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
			Me.demoLeftPanel.TabIndex = 19
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 18
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 644)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 17
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 16
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.createPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 583)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 42)
			Me.convertButtonPanel.TabIndex = 96
			' 
			' createPdfButton
			' 
			Me.createPdfButton.Location = New Point(9, 6)
			Me.createPdfButton.Name = "createPdfButton"
			Me.createPdfButton.Size = New Size(160, 27)
			Me.createPdfButton.TabIndex = 66
			Me.createPdfButton.Text = "Create PDF Document"
			Me.createPdfButton.UseVisualStyleBackColor = True
'			Me.createPdfButton.Click += New System.EventHandler(Me.createPdfButton_Click)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.label14)
			Me.settingsPanel.Controls.Add(Me.label8)
			Me.settingsPanel.Controls.Add(Me.footerSpacingTextBox)
			Me.settingsPanel.Controls.Add(Me.drawFooterLineCheckBox)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 547)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 36)
			Me.settingsPanel.TabIndex = 95
			' 
			' label14
			' 
			Me.label14.AutoSize = True
			Me.label14.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label14.Location = New Point(253, 7)
			Me.label14.Name = "label14"
			Me.label14.Size = New Size(17, 15)
			Me.label14.TabIndex = 123
			Me.label14.Text = "pt"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label8.Location = New Point(153, 7)
			Me.label8.Name = "label8"
			Me.label8.Size = New Size(55, 15)
			Me.label8.TabIndex = 122
			Me.label8.Text = "Spacing:"
			' 
			' footerSpacingTextBox
			' 
			Me.footerSpacingTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.footerSpacingTextBox.Location = New Point(218, 4)
			Me.footerSpacingTextBox.Name = "footerSpacingTextBox"
			Me.footerSpacingTextBox.Size = New Size(31, 21)
			Me.footerSpacingTextBox.TabIndex = 121
			Me.footerSpacingTextBox.Text = "5"
			' 
			' drawFooterLineCheckBox
			' 
			Me.drawFooterLineCheckBox.AutoSize = True
			Me.drawFooterLineCheckBox.Checked = True
			Me.drawFooterLineCheckBox.CheckState = CheckState.Checked
			Me.drawFooterLineCheckBox.Location = New Point(9, 6)
			Me.drawFooterLineCheckBox.Name = "drawFooterLineCheckBox"
			Me.drawFooterLineCheckBox.Size = New Size(127, 21)
			Me.drawFooterLineCheckBox.TabIndex = 0
			Me.drawFooterLineCheckBox.Text = "Draw Footer Line"
			Me.drawFooterLineCheckBox.UseVisualStyleBackColor = True
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.label1)
			Me.urlPanel.Controls.Add(Me.baseUrlTextBox)
			Me.urlPanel.Controls.Add(Me.htmlWithPageNumbersTextBox)
			Me.urlPanel.Controls.Add(Me.label12)
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 110)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 437)
			Me.urlPanel.TabIndex = 94
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label1.Location = New Point(6, 389)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(71, 15)
			Me.label1.TabIndex = 46
			Me.label1.Text = "Base URL"
			' 
			' baseUrlTextBox
			' 
			Me.baseUrlTextBox.Location = New Point(9, 407)
			Me.baseUrlTextBox.Name = "baseUrlTextBox"
			Me.baseUrlTextBox.Size = New Size(575, 21)
			Me.baseUrlTextBox.TabIndex = 47
			' 
			' htmlWithPageNumbersTextBox
			' 
			Me.htmlWithPageNumbersTextBox.Location = New Point(9, 99)
			Me.htmlWithPageNumbersTextBox.MaxLength = 1000000
			Me.htmlWithPageNumbersTextBox.Multiline = True
			Me.htmlWithPageNumbersTextBox.Name = "htmlWithPageNumbersTextBox"
			Me.htmlWithPageNumbersTextBox.ScrollBars = ScrollBars.Vertical
			Me.htmlWithPageNumbersTextBox.Size = New Size(573, 287)
			Me.htmlWithPageNumbersTextBox.TabIndex = 45
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label12.Location = New Point(6, 72)
			Me.label12.Name = "label12"
			Me.label12.Size = New Size(334, 15)
			Me.label12.TabIndex = 44
			Me.label12.Text = "HTML String with Page Numbering to Add in Footer"
			' 
			' enterUrlLabel
			' 
			Me.enterUrlLabel.AutoSize = True
			Me.enterUrlLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.enterUrlLabel.Location = New Point(6, 9)
			Me.enterUrlLabel.Name = "enterUrlLabel"
			Me.enterUrlLabel.Size = New Size(266, 15)
			Me.enterUrlLabel.TabIndex = 40
			Me.enterUrlLabel.Text = "HTML Page URL or Local File to Convert"
			' 
			' urlTextBox
			' 
			Me.urlTextBox.Location = New Point(9, 33)
			Me.urlTextBox.Name = "urlTextBox"
			Me.urlTextBox.Size = New Size(576, 21)
			Me.urlTextBox.TabIndex = 41
            Me.urlTextBox.Text = "http://www.evopdf.com/DemoAppFiles/HTML_Files/Structured_HTML.html"
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 64)
			Me.descriptionPanel.TabIndex = 93
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
			Me.titlePanel.TabIndex = 92
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(226, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Add Page Numbering in HTML"
			' 
			' Page_Numbers_in_HTML_Demo
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
			Me.Name = "Page_Numbers_in_HTML_Demo"
			Me.Size = New Size(610, 650)
'			Me.Load += New System.EventHandler(Me.Page_Numbers_in_HTML_Demo_Load)
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
		Private WithEvents createPdfButton As Button
		Private settingsPanel As Panel
		Private label14 As Label
		Private label8 As Label
		Private footerSpacingTextBox As TextBox
		Private drawFooterLineCheckBox As CheckBox
		Private urlPanel As Panel
		Private label1 As Label
		Private baseUrlTextBox As TextBox
		Private htmlWithPageNumbersTextBox As TextBox
		Private label12 As Label
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
	End Class
End Namespace

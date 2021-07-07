Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Page_Breaks
	Partial Public Class Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS_Demo))
			Me.settingsPanel = New Panel()
			Me.descriptionPanel = New Panel()
			Me.descriptionLabel = New Label()
			Me.titlePanel = New Panel()
			Me.titleLabel = New Label()
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.convertButtonPanel = New Panel()
			Me.convertToPdfButton = New Button()
			Me.htmlPanel = New Panel()
			Me.label2 = New Label()
			Me.baseUrlTextBox = New TextBox()
			Me.htmlStringTextBox = New TextBox()
			Me.label12 = New Label()
			Me.urlPanel = New Panel()
			Me.viewHtmlLinkLabel = New LinkLabel()
			Me.enterUrlLabel = New Label()
			Me.urlTextBox = New TextBox()
			Me.panel2 = New Panel()
			Me.convertHtmlRadioButton = New RadioButton()
			Me.convertUrlRadioButton = New RadioButton()
			Me.descriptionPanel.SuspendLayout()
			Me.titlePanel.SuspendLayout()
			Me.convertButtonPanel.SuspendLayout()
			Me.htmlPanel.SuspendLayout()
			Me.urlPanel.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 102)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 1)
			Me.settingsPanel.TabIndex = 124
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 56)
			Me.descriptionPanel.TabIndex = 122
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 56)
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
			Me.titlePanel.TabIndex = 120
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(411, 18)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Avoid Page Breaks Inside HTML Elements Using CSS"
			' 
			' demoLeftPanel
			' 
			Me.demoLeftPanel.Dock = DockStyle.Left
			Me.demoLeftPanel.Location = New Point(0, 6)
			Me.demoLeftPanel.Name = "demoLeftPanel"
			Me.demoLeftPanel.Size = New Size(6, 720)
			Me.demoLeftPanel.TabIndex = 119
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 720)
			Me.demoRightPanel.TabIndex = 118
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 726)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 117
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 116
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 665)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 42)
			Me.convertButtonPanel.TabIndex = 129
			' 
			' convertToPdfButton
			' 
			Me.convertToPdfButton.Location = New Point(9, 6)
			Me.convertToPdfButton.Name = "convertToPdfButton"
			Me.convertToPdfButton.Size = New Size(150, 27)
			Me.convertToPdfButton.TabIndex = 66
			Me.convertToPdfButton.Text = "Convert HTML to PDF"
			Me.convertToPdfButton.UseVisualStyleBackColor = True
'			Me.convertToPdfButton.Click += New System.EventHandler(Me.convertToPdfButton_Click)
			' 
			' htmlPanel
			' 
			Me.htmlPanel.Controls.Add(Me.label2)
			Me.htmlPanel.Controls.Add(Me.baseUrlTextBox)
			Me.htmlPanel.Controls.Add(Me.htmlStringTextBox)
			Me.htmlPanel.Controls.Add(Me.label12)
			Me.htmlPanel.Dock = DockStyle.Top
			Me.htmlPanel.Location = New Point(6, 207)
			Me.htmlPanel.Name = "htmlPanel"
			Me.htmlPanel.Size = New Size(598, 458)
			Me.htmlPanel.TabIndex = 127
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label2.Location = New Point(6, 405)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(78, 16)
			Me.label2.TabIndex = 52
			Me.label2.Text = "Base URL"
			' 
			' baseUrlTextBox
			' 
			Me.baseUrlTextBox.Location = New Point(9, 423)
			Me.baseUrlTextBox.Name = "baseUrlTextBox"
			Me.baseUrlTextBox.Size = New Size(575, 21)
			Me.baseUrlTextBox.TabIndex = 53
			' 
			' htmlStringTextBox
			' 
			Me.htmlStringTextBox.Location = New Point(9, 36)
			Me.htmlStringTextBox.MaxLength = 1000000
			Me.htmlStringTextBox.Multiline = True
			Me.htmlStringTextBox.Name = "htmlStringTextBox"
			Me.htmlStringTextBox.ScrollBars = ScrollBars.Vertical
			Me.htmlStringTextBox.Size = New Size(574, 356)
			Me.htmlStringTextBox.TabIndex = 51
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label12.Location = New Point(6, 16)
			Me.label12.Name = "label12"
			Me.label12.Size = New Size(360, 16)
			Me.label12.TabIndex = 50
			Me.label12.Text = "HTML String With Page-Break-Inside : Avoid Styles"
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.viewHtmlLinkLabel)
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 140)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 67)
			Me.urlPanel.TabIndex = 126
			Me.urlPanel.Visible = False
			' 
			' viewHtmlLinkLabel
			' 
			Me.viewHtmlLinkLabel.AutoSize = True
			Me.viewHtmlLinkLabel.Location = New Point(514, 37)
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
			Me.enterUrlLabel.Location = New Point(6, 13)
			Me.enterUrlLabel.Name = "enterUrlLabel"
			Me.enterUrlLabel.Size = New Size(357, 16)
			Me.enterUrlLabel.TabIndex = 42
			Me.enterUrlLabel.Text = "HTML Page With Page-Break-Inside : Avoid Styles"
			' 
			' urlTextBox
			' 
			Me.urlTextBox.Location = New Point(8, 34)
			Me.urlTextBox.Name = "urlTextBox"
			Me.urlTextBox.Size = New Size(500, 21)
			Me.urlTextBox.TabIndex = 45
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.convertHtmlRadioButton)
			Me.panel2.Controls.Add(Me.convertUrlRadioButton)
			Me.panel2.Dock = DockStyle.Top
			Me.panel2.Location = New Point(6, 103)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New Size(598, 37)
			Me.panel2.TabIndex = 125
			' 
			' convertHtmlRadioButton
			' 
			Me.convertHtmlRadioButton.AutoSize = True
			Me.convertHtmlRadioButton.Checked = True
			Me.convertHtmlRadioButton.Location = New Point(8, 6)
			Me.convertHtmlRadioButton.Name = "convertHtmlRadioButton"
			Me.convertHtmlRadioButton.Size = New Size(152, 20)
			Me.convertHtmlRadioButton.TabIndex = 71
			Me.convertHtmlRadioButton.TabStop = True
			Me.convertHtmlRadioButton.Text = "Convert HTML String"
			Me.convertHtmlRadioButton.UseVisualStyleBackColor = True
'			Me.convertHtmlRadioButton.CheckedChanged += New System.EventHandler(Me.convertHtmlRadioButton_CheckedChanged)
			' 
			' convertUrlRadioButton
			' 
			Me.convertUrlRadioButton.AutoSize = True
			Me.convertUrlRadioButton.Location = New Point(191, 6)
			Me.convertUrlRadioButton.Name = "convertUrlRadioButton"
			Me.convertUrlRadioButton.Size = New Size(181, 20)
			Me.convertUrlRadioButton.TabIndex = 70
			Me.convertUrlRadioButton.Text = "Convert URL or Local File"
			Me.convertUrlRadioButton.UseVisualStyleBackColor = True
'			Me.convertUrlRadioButton.CheckedChanged += New System.EventHandler(Me.convertUrlRadioButton_CheckedChanged)
			' 
			' Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS_Demo
			' 
			Me.AutoScaleDimensions = New SizeF(7F, 15F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScroll = True
			Me.Controls.Add(Me.convertButtonPanel)
			Me.Controls.Add(Me.htmlPanel)
			Me.Controls.Add(Me.urlPanel)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.settingsPanel)
			Me.Controls.Add(Me.descriptionPanel)
			Me.Controls.Add(Me.titlePanel)
			Me.Controls.Add(Me.demoLeftPanel)
			Me.Controls.Add(Me.demoRightPanel)
			Me.Controls.Add(Me.demoBottomPanel)
			Me.Controls.Add(Me.demoTopPanel)
			Me.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.Name = "Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS_Demo"
			Me.Size = New Size(610, 732)
'			Me.Load += New System.EventHandler(Me.Avoid_Page_Breaks_Inside_HTML_Elements_Demo_Load)
			Me.descriptionPanel.ResumeLayout(False)
			Me.titlePanel.ResumeLayout(False)
			Me.titlePanel.PerformLayout()
			Me.convertButtonPanel.ResumeLayout(False)
			Me.htmlPanel.ResumeLayout(False)
			Me.htmlPanel.PerformLayout()
			Me.urlPanel.ResumeLayout(False)
			Me.urlPanel.PerformLayout()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private settingsPanel As Panel
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
		Private demoLeftPanel As Panel
		Private demoRightPanel As Panel
		Private demoBottomPanel As Panel
		Private demoTopPanel As Panel
		Private convertButtonPanel As Panel
		Private WithEvents convertToPdfButton As Button
		Private htmlPanel As Panel
		Private label2 As Label
		Private baseUrlTextBox As TextBox
		Private htmlStringTextBox As TextBox
		Private label12 As Label
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox
		Private panel2 As Panel
		Private WithEvents convertHtmlRadioButton As RadioButton
		Private WithEvents convertUrlRadioButton As RadioButton
		Private WithEvents viewHtmlLinkLabel As LinkLabel
	End Class
End Namespace

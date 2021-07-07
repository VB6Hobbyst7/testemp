Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers
	Partial Public Class Header_Footer_Change_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Header_Footer_Change_Demo))
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.convertButtonPanel = New Panel()
			Me.convertToPdfButton = New Button()
			Me.settingsPanel = New Panel()
			Me.changeHeaderAndFooterCheckBox = New CheckBox()
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
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 744)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 12
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 11
			' 
			' demoLeftPanel
			' 
			Me.demoLeftPanel.Dock = DockStyle.Left
			Me.demoLeftPanel.Location = New Point(0, 6)
			Me.demoLeftPanel.Name = "demoLeftPanel"
			Me.demoLeftPanel.Size = New Size(6, 738)
			Me.demoLeftPanel.TabIndex = 15
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(605, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 738)
			Me.demoRightPanel.TabIndex = 14
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(5, 215)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(600, 42)
			Me.convertButtonPanel.TabIndex = 109
			' 
			' convertToPdfButton
			' 
			Me.convertToPdfButton.Location = New Point(9, 6)
			Me.convertToPdfButton.Name = "convertToPdfButton"
			Me.convertToPdfButton.Size = New Size(135, 27)
			Me.convertToPdfButton.TabIndex = 66
			Me.convertToPdfButton.Text = "Convert HTML to PDF"
			Me.convertToPdfButton.UseVisualStyleBackColor = True
'			Me.convertToPdfButton.Click += New System.EventHandler(Me.convertToPdfButton_Click)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.changeHeaderAndFooterCheckBox)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(5, 165)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(600, 50)
			Me.settingsPanel.TabIndex = 108
			' 
			' changeHeaderAndFooterCheckBox
			' 
			Me.changeHeaderAndFooterCheckBox.AutoSize = True
			Me.changeHeaderAndFooterCheckBox.Checked = True
			Me.changeHeaderAndFooterCheckBox.CheckState = CheckState.Checked
			Me.changeHeaderAndFooterCheckBox.Location = New Point(9, 17)
			Me.changeHeaderAndFooterCheckBox.Name = "changeHeaderAndFooterCheckBox"
			Me.changeHeaderAndFooterCheckBox.Size = New Size(266, 19)
			Me.changeHeaderAndFooterCheckBox.TabIndex = 0
			Me.changeHeaderAndFooterCheckBox.Text = "Change the Header and Footer in First Page"
			Me.changeHeaderAndFooterCheckBox.UseVisualStyleBackColor = True
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(5, 107)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(600, 58)
			Me.urlPanel.TabIndex = 107
			' 
			' enterUrlLabel
			' 
			Me.enterUrlLabel.AutoSize = True
			Me.enterUrlLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.enterUrlLabel.Location = New Point(6, 3)
			Me.enterUrlLabel.Name = "enterUrlLabel"
			Me.enterUrlLabel.Size = New Size(182, 15)
			Me.enterUrlLabel.TabIndex = 42
			Me.enterUrlLabel.Text = "HTML Page to Convert URL"
			' 
			' urlTextBox
			' 
			Me.urlTextBox.Location = New Point(8, 24)
			Me.urlTextBox.Name = "urlTextBox"
			Me.urlTextBox.Size = New Size(574, 21)
			Me.urlTextBox.TabIndex = 45
            Me.urlTextBox.Text = "http://www.evopdf.com/DemoAppFiles/HTML_Files/Structured_HTML.html"
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(5, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(600, 61)
			Me.descriptionPanel.TabIndex = 106
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(600, 61)
			Me.descriptionLabel.TabIndex = 0
			Me.descriptionLabel.Text = resources.GetString("descriptionLabel.Text")
			' 
			' titlePanel
			' 
			Me.titlePanel.Controls.Add(Me.titleLabel)
			Me.titlePanel.Dock = DockStyle.Top
			Me.titlePanel.Location = New Point(5, 6)
			Me.titlePanel.Name = "titlePanel"
			Me.titlePanel.Size = New Size(600, 40)
			Me.titlePanel.TabIndex = 104
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(276, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Change Header and Footer per Page"
			' 
			' Header_Footer_Change_Demo
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
			Me.Name = "Header_Footer_Change_Demo"
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

		Private demoBottomPanel As Panel
		Private demoTopPanel As Panel
		Private demoLeftPanel As Panel
		Private demoRightPanel As Panel
		Private convertButtonPanel As Panel
		Private WithEvents convertToPdfButton As Button
		Private settingsPanel As Panel
		Private changeHeaderAndFooterCheckBox As CheckBox
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
	End Class
End Namespace

Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class Merge_Multiple_HTML_Demo
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
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.convertButtonPanel = New Panel()
			Me.convertToPdfButton = New Button()
			Me.settingsPanel = New Panel()
			Me.startNewPageCheckBox = New CheckBox()
			Me.label1 = New Label()
			Me.urlPanel = New Panel()
			Me.label6 = New Label()
			Me.enterUrlLabel = New Label()
			Me.secondUrlTextBox = New TextBox()
			Me.firstUrlTextBox = New TextBox()
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
			Me.demoBottomPanel.Location = New Point(0, 644)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 4
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 3
			' 
			' demoLeftPanel
			' 
			Me.demoLeftPanel.Dock = DockStyle.Left
			Me.demoLeftPanel.Location = New Point(0, 6)
			Me.demoLeftPanel.Name = "demoLeftPanel"
			Me.demoLeftPanel.Size = New Size(6, 638)
			Me.demoLeftPanel.TabIndex = 7
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 6
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 303)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 43)
			Me.convertButtonPanel.TabIndex = 84
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
			Me.settingsPanel.Controls.Add(Me.startNewPageCheckBox)
			Me.settingsPanel.Controls.Add(Me.label1)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 222)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 81)
			Me.settingsPanel.TabIndex = 83
			' 
			' startNewPageCheckBox
			' 
			Me.startNewPageCheckBox.AutoSize = True
			Me.startNewPageCheckBox.Location = New Point(10, 41)
			Me.startNewPageCheckBox.Name = "startNewPageCheckBox"
			Me.startNewPageCheckBox.Size = New Size(293, 20)
			Me.startNewPageCheckBox.TabIndex = 40
			Me.startNewPageCheckBox.Text = "Start the Second HTML on a New PDF Page"
			Me.startNewPageCheckBox.UseVisualStyleBackColor = True
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label1.Location = New Point(7, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(154, 16)
			Me.label1.TabIndex = 39
			Me.label1.Text = "HTML Merge Options"
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.label6)
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.secondUrlTextBox)
			Me.urlPanel.Controls.Add(Me.firstUrlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 86)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 136)
			Me.urlPanel.TabIndex = 82
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label6.Location = New Point(7, 80)
			Me.label6.Name = "label6"
			Me.label6.Size = New Size(181, 16)
			Me.label6.TabIndex = 40
			Me.label6.Text = "Second HTML Page URL"
			' 
			' enterUrlLabel
			' 
			Me.enterUrlLabel.AutoSize = True
			Me.enterUrlLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.enterUrlLabel.Location = New Point(7, 14)
			Me.enterUrlLabel.Name = "enterUrlLabel"
			Me.enterUrlLabel.Size = New Size(158, 16)
			Me.enterUrlLabel.TabIndex = 40
			Me.enterUrlLabel.Text = "First HTML Page URL"
			' 
			' secondUrlTextBox
			' 
			Me.secondUrlTextBox.Location = New Point(9, 101)
			Me.secondUrlTextBox.Name = "secondUrlTextBox"
			Me.secondUrlTextBox.Size = New Size(573, 21)
			Me.secondUrlTextBox.TabIndex = 41
            Me.secondUrlTextBox.Text = "http://www.evopdf.com"
			' 
			' firstUrlTextBox
			' 
			Me.firstUrlTextBox.Location = New Point(9, 35)
			Me.firstUrlTextBox.Name = "firstUrlTextBox"
			Me.firstUrlTextBox.Size = New Size(573, 21)
			Me.firstUrlTextBox.TabIndex = 41
			Me.firstUrlTextBox.Text = "http://www.cnn.com"
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 40)
			Me.descriptionPanel.TabIndex = 80
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 40)
			Me.descriptionLabel.TabIndex = 0
			Me.descriptionLabel.Text = "EVO HTML to PDF Converter allows you to merge multiple HTML document into a singl" & "e PDF document. The Full Description and a Code Sample can be accessed from the " & "top tabs."
			' 
			' titlePanel
			' 
			Me.titlePanel.Controls.Add(Me.titleLabel)
			Me.titlePanel.Dock = DockStyle.Top
			Me.titlePanel.Location = New Point(6, 6)
			Me.titlePanel.Name = "titlePanel"
			Me.titlePanel.Size = New Size(598, 40)
			Me.titlePanel.TabIndex = 78
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(356, 18)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Merge Multiple HTML Pages into a Single PDF"
			' 
			' Merge_Multiple_HTML_Demo
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
			Me.Name = "Merge_Multiple_HTML_Demo"
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
		Private label1 As Label
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private firstUrlTextBox As TextBox
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
		Private label6 As Label
		Private secondUrlTextBox As TextBox
		Private startNewPageCheckBox As CheckBox
	End Class
End Namespace

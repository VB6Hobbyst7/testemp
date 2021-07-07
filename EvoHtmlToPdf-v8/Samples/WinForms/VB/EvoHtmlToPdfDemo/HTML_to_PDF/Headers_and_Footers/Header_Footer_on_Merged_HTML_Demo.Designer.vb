Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers
	Partial Public Class Header_Footer_on_Merged_HTML_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Header_Footer_on_Merged_HTML_Demo))
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.convertButtonPanel = New Panel()
			Me.convertToPdfButton = New Button()
			Me.settingsPanel = New Panel()
			Me.label14 = New Label()
			Me.label8 = New Label()
			Me.footerSpacingTextBox = New TextBox()
			Me.label5 = New Label()
			Me.label12 = New Label()
			Me.label4 = New Label()
			Me.firstPageSpacingTextBox = New TextBox()
			Me.label7 = New Label()
			Me.headerSpacingTextBox = New TextBox()
			Me.label2 = New Label()
			Me.label3 = New Label()
			Me.label9 = New Label()
			Me.showFooterInEvenPagesCheckBox = New CheckBox()
			Me.addFooterCheckBox = New CheckBox()
			Me.showFooterInOddPagesCheckBox = New CheckBox()
			Me.showHeaderInEvenPagesCheckBox = New CheckBox()
			Me.drawFooterLineCheckBox = New CheckBox()
			Me.addPageNumbersInFooterCheckBox = New CheckBox()
			Me.showFooterInFirstPageCheckBox = New CheckBox()
			Me.showHeaderInOddPagesCheckBox = New CheckBox()
			Me.showHeaderInFirstPageCheckBox = New CheckBox()
			Me.drawHeaderLineCheckBox = New CheckBox()
			Me.addHeaderCheckBox = New CheckBox()
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
			Me.demoBottomPanel.TabIndex = 6
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 5
			' 
			' demoLeftPanel
			' 
			Me.demoLeftPanel.Dock = DockStyle.Left
			Me.demoLeftPanel.Location = New Point(0, 6)
			Me.demoLeftPanel.Name = "demoLeftPanel"
			Me.demoLeftPanel.Size = New Size(6, 638)
			Me.demoLeftPanel.TabIndex = 9
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 8
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 568)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 50)
			Me.convertButtonPanel.TabIndex = 89
			' 
			' convertToPdfButton
			' 
			Me.convertToPdfButton.Location = New Point(7, 7)
			Me.convertToPdfButton.Name = "convertToPdfButton"
			Me.convertToPdfButton.Size = New Size(150, 31)
			Me.convertToPdfButton.TabIndex = 66
			Me.convertToPdfButton.Text = "Convert HTML to PDF"
			Me.convertToPdfButton.UseVisualStyleBackColor = True
'			Me.convertToPdfButton.Click += New System.EventHandler(Me.convertToPdfButton_Click)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.label14)
			Me.settingsPanel.Controls.Add(Me.label8)
			Me.settingsPanel.Controls.Add(Me.footerSpacingTextBox)
			Me.settingsPanel.Controls.Add(Me.label5)
			Me.settingsPanel.Controls.Add(Me.label12)
			Me.settingsPanel.Controls.Add(Me.label4)
			Me.settingsPanel.Controls.Add(Me.firstPageSpacingTextBox)
			Me.settingsPanel.Controls.Add(Me.label7)
			Me.settingsPanel.Controls.Add(Me.headerSpacingTextBox)
			Me.settingsPanel.Controls.Add(Me.label2)
			Me.settingsPanel.Controls.Add(Me.label3)
			Me.settingsPanel.Controls.Add(Me.label9)
			Me.settingsPanel.Controls.Add(Me.showFooterInEvenPagesCheckBox)
			Me.settingsPanel.Controls.Add(Me.addFooterCheckBox)
			Me.settingsPanel.Controls.Add(Me.showFooterInOddPagesCheckBox)
			Me.settingsPanel.Controls.Add(Me.showHeaderInEvenPagesCheckBox)
			Me.settingsPanel.Controls.Add(Me.drawFooterLineCheckBox)
			Me.settingsPanel.Controls.Add(Me.addPageNumbersInFooterCheckBox)
			Me.settingsPanel.Controls.Add(Me.showFooterInFirstPageCheckBox)
			Me.settingsPanel.Controls.Add(Me.showHeaderInOddPagesCheckBox)
			Me.settingsPanel.Controls.Add(Me.showHeaderInFirstPageCheckBox)
			Me.settingsPanel.Controls.Add(Me.drawHeaderLineCheckBox)
			Me.settingsPanel.Controls.Add(Me.addHeaderCheckBox)
			Me.settingsPanel.Controls.Add(Me.startNewPageCheckBox)
			Me.settingsPanel.Controls.Add(Me.label1)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 240)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 328)
			Me.settingsPanel.TabIndex = 88
			' 
			' label14
			' 
			Me.label14.AutoSize = True
			Me.label14.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label14.Location = New Point(524, 300)
			Me.label14.Name = "label14"
			Me.label14.Size = New Size(19, 16)
			Me.label14.TabIndex = 146
			Me.label14.Text = "pt"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label8.Location = New Point(395, 300)
			Me.label8.Name = "label8"
			Me.label8.Size = New Size(61, 16)
			Me.label8.TabIndex = 145
			Me.label8.Text = "Spacing:"
			' 
			' footerSpacingTextBox
			' 
			Me.footerSpacingTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.footerSpacingTextBox.Location = New Point(467, 297)
			Me.footerSpacingTextBox.Name = "footerSpacingTextBox"
			Me.footerSpacingTextBox.Size = New Size(52, 21)
			Me.footerSpacingTextBox.TabIndex = 144
			Me.footerSpacingTextBox.Text = "5"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label5.Location = New Point(614, 218)
			Me.label5.Name = "label5"
			Me.label5.Size = New Size(19, 16)
			Me.label5.TabIndex = 142
			Me.label5.Text = "pt"
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label12.Location = New Point(333, 203)
			Me.label12.Name = "label12"
			Me.label12.Size = New Size(19, 16)
			Me.label12.TabIndex = 143
			Me.label12.Text = "pt"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label4.Location = New Point(395, 203)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(125, 16)
			Me.label4.TabIndex = 140
			Me.label4.Text = "First Page Spacing:"
			' 
			' firstPageSpacingTextBox
			' 
			Me.firstPageSpacingTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.firstPageSpacingTextBox.Location = New Point(525, 200)
			Me.firstPageSpacingTextBox.Name = "firstPageSpacingTextBox"
			Me.firstPageSpacingTextBox.Size = New Size(52, 21)
			Me.firstPageSpacingTextBox.TabIndex = 138
			Me.firstPageSpacingTextBox.Text = "0"
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label7.Location = New Point(205, 203)
			Me.label7.Name = "label7"
			Me.label7.Size = New Size(61, 16)
			Me.label7.TabIndex = 141
			Me.label7.Text = "Spacing:"
			' 
			' headerSpacingTextBox
			' 
			Me.headerSpacingTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.headerSpacingTextBox.Location = New Point(276, 200)
			Me.headerSpacingTextBox.Name = "headerSpacingTextBox"
			Me.headerSpacingTextBox.Size = New Size(52, 21)
			Me.headerSpacingTextBox.TabIndex = 139
			Me.headerSpacingTextBox.Text = "5"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label2.Location = New Point(8, 242)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(110, 16)
			Me.label2.TabIndex = 136
			Me.label2.Text = "Footer Options"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label3.Location = New Point(6, 70)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(192, 16)
			Me.label3.TabIndex = 137
			Me.label3.Text = "Enable Header and Footer"
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label9.Location = New Point(8, 144)
			Me.label9.Name = "label9"
			Me.label9.Size = New Size(117, 16)
			Me.label9.TabIndex = 135
			Me.label9.Text = "Header Options"
			' 
			' showFooterInEvenPagesCheckBox
			' 
			Me.showFooterInEvenPagesCheckBox.AutoSize = True
			Me.showFooterInEvenPagesCheckBox.Checked = True
			Me.showFooterInEvenPagesCheckBox.CheckState = CheckState.Checked
			Me.showFooterInEvenPagesCheckBox.Location = New Point(399, 271)
			Me.showFooterInEvenPagesCheckBox.Name = "showFooterInEvenPagesCheckBox"
			Me.showFooterInEvenPagesCheckBox.Size = New Size(153, 20)
			Me.showFooterInEvenPagesCheckBox.TabIndex = 127
			Me.showFooterInEvenPagesCheckBox.Text = "Show in Even Pages"
			Me.showFooterInEvenPagesCheckBox.UseVisualStyleBackColor = True
			' 
			' addFooterCheckBox
			' 
			Me.addFooterCheckBox.AutoSize = True
			Me.addFooterCheckBox.Checked = True
			Me.addFooterCheckBox.CheckState = CheckState.Checked
			Me.addFooterCheckBox.Location = New Point(174, 103)
			Me.addFooterCheckBox.Name = "addFooterCheckBox"
			Me.addFooterCheckBox.Size = New Size(97, 20)
			Me.addFooterCheckBox.TabIndex = 128
			Me.addFooterCheckBox.Text = "Add Footer"
			Me.addFooterCheckBox.UseVisualStyleBackColor = True
			' 
			' showFooterInOddPagesCheckBox
			' 
			Me.showFooterInOddPagesCheckBox.AutoSize = True
			Me.showFooterInOddPagesCheckBox.Checked = True
			Me.showFooterInOddPagesCheckBox.CheckState = CheckState.Checked
			Me.showFooterInOddPagesCheckBox.Location = New Point(207, 271)
			Me.showFooterInOddPagesCheckBox.Name = "showFooterInOddPagesCheckBox"
			Me.showFooterInOddPagesCheckBox.Size = New Size(148, 20)
			Me.showFooterInOddPagesCheckBox.TabIndex = 126
			Me.showFooterInOddPagesCheckBox.Text = "Show in Odd Pages"
			Me.showFooterInOddPagesCheckBox.UseVisualStyleBackColor = True
			' 
			' showHeaderInEvenPagesCheckBox
			' 
			Me.showHeaderInEvenPagesCheckBox.AutoSize = True
			Me.showHeaderInEvenPagesCheckBox.Checked = True
			Me.showHeaderInEvenPagesCheckBox.CheckState = CheckState.Checked
			Me.showHeaderInEvenPagesCheckBox.Location = New Point(398, 174)
			Me.showHeaderInEvenPagesCheckBox.Name = "showHeaderInEvenPagesCheckBox"
			Me.showHeaderInEvenPagesCheckBox.Size = New Size(153, 20)
			Me.showHeaderInEvenPagesCheckBox.TabIndex = 124
			Me.showHeaderInEvenPagesCheckBox.Text = "Show in Even Pages"
			Me.showHeaderInEvenPagesCheckBox.UseVisualStyleBackColor = True
			' 
			' drawFooterLineCheckBox
			' 
			Me.drawFooterLineCheckBox.AutoSize = True
			Me.drawFooterLineCheckBox.Checked = True
			Me.drawFooterLineCheckBox.CheckState = CheckState.Checked
			Me.drawFooterLineCheckBox.Location = New Point(207, 298)
			Me.drawFooterLineCheckBox.Name = "drawFooterLineCheckBox"
			Me.drawFooterLineCheckBox.Size = New Size(131, 20)
			Me.drawFooterLineCheckBox.TabIndex = 125
			Me.drawFooterLineCheckBox.Text = "Draw Footer Line"
			Me.drawFooterLineCheckBox.UseVisualStyleBackColor = True
			' 
			' addPageNumbersInFooterCheckBox
			' 
			Me.addPageNumbersInFooterCheckBox.AutoSize = True
			Me.addPageNumbersInFooterCheckBox.Checked = True
			Me.addPageNumbersInFooterCheckBox.CheckState = CheckState.Checked
			Me.addPageNumbersInFooterCheckBox.Location = New Point(38, 298)
			Me.addPageNumbersInFooterCheckBox.Name = "addPageNumbersInFooterCheckBox"
			Me.addPageNumbersInFooterCheckBox.Size = New Size(149, 20)
			Me.addPageNumbersInFooterCheckBox.TabIndex = 129
			Me.addPageNumbersInFooterCheckBox.Text = "Add Page Numbers"
			Me.addPageNumbersInFooterCheckBox.UseVisualStyleBackColor = True
			' 
			' showFooterInFirstPageCheckBox
			' 
			Me.showFooterInFirstPageCheckBox.AutoSize = True
			Me.showFooterInFirstPageCheckBox.Checked = True
			Me.showFooterInFirstPageCheckBox.CheckState = CheckState.Checked
			Me.showFooterInFirstPageCheckBox.Location = New Point(38, 271)
			Me.showFooterInFirstPageCheckBox.Name = "showFooterInFirstPageCheckBox"
			Me.showFooterInFirstPageCheckBox.Size = New Size(140, 20)
			Me.showFooterInFirstPageCheckBox.TabIndex = 133
			Me.showFooterInFirstPageCheckBox.Text = "Show in First Page"
			Me.showFooterInFirstPageCheckBox.UseVisualStyleBackColor = True
			' 
			' showHeaderInOddPagesCheckBox
			' 
			Me.showHeaderInOddPagesCheckBox.AutoSize = True
			Me.showHeaderInOddPagesCheckBox.Checked = True
			Me.showHeaderInOddPagesCheckBox.CheckState = CheckState.Checked
			Me.showHeaderInOddPagesCheckBox.Location = New Point(207, 174)
			Me.showHeaderInOddPagesCheckBox.Name = "showHeaderInOddPagesCheckBox"
			Me.showHeaderInOddPagesCheckBox.Size = New Size(148, 20)
			Me.showHeaderInOddPagesCheckBox.TabIndex = 134
			Me.showHeaderInOddPagesCheckBox.Text = "Show in Odd Pages"
			Me.showHeaderInOddPagesCheckBox.UseVisualStyleBackColor = True
			' 
			' showHeaderInFirstPageCheckBox
			' 
			Me.showHeaderInFirstPageCheckBox.AutoSize = True
			Me.showHeaderInFirstPageCheckBox.Checked = True
			Me.showHeaderInFirstPageCheckBox.CheckState = CheckState.Checked
			Me.showHeaderInFirstPageCheckBox.Location = New Point(40, 174)
			Me.showHeaderInFirstPageCheckBox.Name = "showHeaderInFirstPageCheckBox"
			Me.showHeaderInFirstPageCheckBox.Size = New Size(140, 20)
			Me.showHeaderInFirstPageCheckBox.TabIndex = 132
			Me.showHeaderInFirstPageCheckBox.Text = "Show in First Page"
			Me.showHeaderInFirstPageCheckBox.UseVisualStyleBackColor = True
			' 
			' drawHeaderLineCheckBox
			' 
			Me.drawHeaderLineCheckBox.AutoSize = True
			Me.drawHeaderLineCheckBox.Checked = True
			Me.drawHeaderLineCheckBox.CheckState = CheckState.Checked
			Me.drawHeaderLineCheckBox.Location = New Point(38, 204)
			Me.drawHeaderLineCheckBox.Name = "drawHeaderLineCheckBox"
			Me.drawHeaderLineCheckBox.Size = New Size(138, 20)
			Me.drawHeaderLineCheckBox.TabIndex = 130
			Me.drawHeaderLineCheckBox.Text = "Draw Header Line"
			Me.drawHeaderLineCheckBox.UseVisualStyleBackColor = True
			' 
			' addHeaderCheckBox
			' 
			Me.addHeaderCheckBox.AutoSize = True
			Me.addHeaderCheckBox.Checked = True
			Me.addHeaderCheckBox.CheckState = CheckState.Checked
			Me.addHeaderCheckBox.Location = New Point(40, 103)
			Me.addHeaderCheckBox.Name = "addHeaderCheckBox"
			Me.addHeaderCheckBox.Size = New Size(104, 20)
			Me.addHeaderCheckBox.TabIndex = 131
			Me.addHeaderCheckBox.Text = "Add Header"
			Me.addHeaderCheckBox.UseVisualStyleBackColor = True
			' 
			' startNewPageCheckBox
			' 
			Me.startNewPageCheckBox.AutoSize = True
			Me.startNewPageCheckBox.Location = New Point(40, 37)
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
			Me.label1.Location = New Point(8, 10)
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
			Me.urlPanel.Location = New Point(6, 109)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 131)
			Me.urlPanel.TabIndex = 87
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label6.Location = New Point(7, 73)
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
			Me.secondUrlTextBox.Location = New Point(9, 97)
			Me.secondUrlTextBox.Name = "secondUrlTextBox"
			Me.secondUrlTextBox.Size = New Size(568, 21)
			Me.secondUrlTextBox.TabIndex = 41
            Me.secondUrlTextBox.Text = "http://www.evopdf.com"
			' 
			' firstUrlTextBox
			' 
			Me.firstUrlTextBox.Location = New Point(9, 38)
			Me.firstUrlTextBox.Name = "firstUrlTextBox"
			Me.firstUrlTextBox.Size = New Size(568, 21)
			Me.firstUrlTextBox.TabIndex = 41
			Me.firstUrlTextBox.Text = "http://www.cnn.com"
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 52)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 57)
			Me.descriptionPanel.TabIndex = 86
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
			Me.titlePanel.Size = New Size(598, 46)
			Me.titlePanel.TabIndex = 85
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 12)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(356, 18)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Merge Multiple HTML Pages into a Single PDF"
			' 
			' Header_Footer_on_Merged_HTML_Demo
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
			Me.Name = "Header_Footer_on_Merged_HTML_Demo"
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
		Private startNewPageCheckBox As CheckBox
		Private label1 As Label
		Private urlPanel As Panel
		Private label6 As Label
		Private enterUrlLabel As Label
		Private secondUrlTextBox As TextBox
		Private firstUrlTextBox As TextBox
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
		Private label14 As Label
		Private label8 As Label
		Private footerSpacingTextBox As TextBox
		Private label5 As Label
		Private label12 As Label
		Private label4 As Label
		Private firstPageSpacingTextBox As TextBox
		Private label7 As Label
		Private headerSpacingTextBox As TextBox
		Private label2 As Label
		Private label3 As Label
		Private label9 As Label
		Private showFooterInEvenPagesCheckBox As CheckBox
		Private addFooterCheckBox As CheckBox
		Private showFooterInOddPagesCheckBox As CheckBox
		Private showHeaderInEvenPagesCheckBox As CheckBox
		Private drawFooterLineCheckBox As CheckBox
		Private addPageNumbersInFooterCheckBox As CheckBox
		Private showFooterInFirstPageCheckBox As CheckBox
		Private showHeaderInOddPagesCheckBox As CheckBox
		Private showHeaderInFirstPageCheckBox As CheckBox
		Private drawHeaderLineCheckBox As CheckBox
		Private addHeaderCheckBox As CheckBox
	End Class
End Namespace

Namespace EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers
	Partial Public Class HTML_in_Header_Footer_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(HTML_in_Header_Footer_Demo))
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
			Me.label5 = New Label()
			Me.label12 = New Label()
			Me.label4 = New Label()
			Me.firstPageSpacingTextBox = New TextBox()
			Me.label7 = New Label()
			Me.headerSpacingTextBox = New TextBox()
			Me.label2 = New Label()
			Me.label3 = New Label()
			Me.label1 = New Label()
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
			Me.convertButtonPanel.Location = New Point(6, 444)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 43)
			Me.convertButtonPanel.TabIndex = 89
			' 
			' createPdfButton
			' 
			Me.createPdfButton.Location = New Point(6, 6)
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
			Me.settingsPanel.Controls.Add(Me.label5)
			Me.settingsPanel.Controls.Add(Me.label12)
			Me.settingsPanel.Controls.Add(Me.label4)
			Me.settingsPanel.Controls.Add(Me.firstPageSpacingTextBox)
			Me.settingsPanel.Controls.Add(Me.label7)
			Me.settingsPanel.Controls.Add(Me.headerSpacingTextBox)
			Me.settingsPanel.Controls.Add(Me.label2)
			Me.settingsPanel.Controls.Add(Me.label3)
			Me.settingsPanel.Controls.Add(Me.label1)
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
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 168)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 276)
			Me.settingsPanel.TabIndex = 88
			' 
			' label14
			' 
			Me.label14.AutoSize = True
			Me.label14.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label14.Location = New Point(471, 241)
			Me.label14.Name = "label14"
			Me.label14.Size = New Size(17, 15)
			Me.label14.TabIndex = 123
			Me.label14.Text = "pt"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label8.Location = New Point(361, 241)
			Me.label8.Name = "label8"
			Me.label8.Size = New Size(55, 15)
			Me.label8.TabIndex = 122
			Me.label8.Text = "Spacing:"
			' 
			' footerSpacingTextBox
			' 
			Me.footerSpacingTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.footerSpacingTextBox.Location = New Point(422, 238)
			Me.footerSpacingTextBox.Name = "footerSpacingTextBox"
			Me.footerSpacingTextBox.Size = New Size(45, 21)
			Me.footerSpacingTextBox.TabIndex = 121
			Me.footerSpacingTextBox.Text = "5"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label5.Location = New Point(539, 143)
			Me.label5.Name = "label5"
			Me.label5.Size = New Size(17, 15)
			Me.label5.TabIndex = 120
			Me.label5.Text = "pt"
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label12.Location = New Point(299, 143)
			Me.label12.Name = "label12"
			Me.label12.Size = New Size(17, 15)
			Me.label12.TabIndex = 120
			Me.label12.Text = "pt"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label4.Location = New Point(359, 143)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(113, 15)
			Me.label4.TabIndex = 119
			Me.label4.Text = "First Page Spacing:"
			' 
			' firstPageSpacingTextBox
			' 
			Me.firstPageSpacingTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.firstPageSpacingTextBox.Location = New Point(490, 140)
			Me.firstPageSpacingTextBox.Name = "firstPageSpacingTextBox"
			Me.firstPageSpacingTextBox.Size = New Size(45, 21)
			Me.firstPageSpacingTextBox.TabIndex = 118
			Me.firstPageSpacingTextBox.Text = "0"
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label7.Location = New Point(189, 143)
			Me.label7.Name = "label7"
			Me.label7.Size = New Size(55, 15)
			Me.label7.TabIndex = 119
			Me.label7.Text = "Spacing:"
			' 
			' headerSpacingTextBox
			' 
			Me.headerSpacingTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.headerSpacingTextBox.Location = New Point(250, 140)
			Me.headerSpacingTextBox.Name = "headerSpacingTextBox"
			Me.headerSpacingTextBox.Size = New Size(45, 21)
			Me.headerSpacingTextBox.TabIndex = 118
			Me.headerSpacingTextBox.Text = "5"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label2.Location = New Point(3, 175)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(101, 15)
			Me.label2.TabIndex = 40
			Me.label2.Text = "Footer Options"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label3.Location = New Point(6, 14)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(176, 15)
			Me.label3.TabIndex = 40
			Me.label3.Text = "Enable Header and Footer"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label1.Location = New Point(3, 78)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(107, 15)
			Me.label1.TabIndex = 40
			Me.label1.Text = "Header Options"
			' 
			' showFooterInEvenPagesCheckBox
			' 
			Me.showFooterInEvenPagesCheckBox.AutoSize = True
			Me.showFooterInEvenPagesCheckBox.Checked = True
			Me.showFooterInEvenPagesCheckBox.CheckState = CheckState.Checked
			Me.showFooterInEvenPagesCheckBox.Location = New Point(362, 205)
			Me.showFooterInEvenPagesCheckBox.Name = "showFooterInEvenPagesCheckBox"
			Me.showFooterInEvenPagesCheckBox.Size = New Size(145, 21)
			Me.showFooterInEvenPagesCheckBox.TabIndex = 0
			Me.showFooterInEvenPagesCheckBox.Text = "Show in Even Pages"
			Me.showFooterInEvenPagesCheckBox.UseVisualStyleBackColor = True
			' 
			' addFooterCheckBox
			' 
			Me.addFooterCheckBox.AutoSize = True
			Me.addFooterCheckBox.Checked = True
			Me.addFooterCheckBox.CheckState = CheckState.Checked
			Me.addFooterCheckBox.Location = New Point(148, 41)
			Me.addFooterCheckBox.Name = "addFooterCheckBox"
			Me.addFooterCheckBox.Size = New Size(92, 21)
			Me.addFooterCheckBox.TabIndex = 0
			Me.addFooterCheckBox.Text = "Add Footer"
			Me.addFooterCheckBox.UseVisualStyleBackColor = True
			' 
			' showFooterInOddPagesCheckBox
			' 
			Me.showFooterInOddPagesCheckBox.AutoSize = True
			Me.showFooterInOddPagesCheckBox.Checked = True
			Me.showFooterInOddPagesCheckBox.CheckState = CheckState.Checked
			Me.showFooterInOddPagesCheckBox.Location = New Point(192, 205)
			Me.showFooterInOddPagesCheckBox.Name = "showFooterInOddPagesCheckBox"
			Me.showFooterInOddPagesCheckBox.Size = New Size(141, 21)
			Me.showFooterInOddPagesCheckBox.TabIndex = 0
			Me.showFooterInOddPagesCheckBox.Text = "Show in Odd Pages"
			Me.showFooterInOddPagesCheckBox.UseVisualStyleBackColor = True
			' 
			' showHeaderInEvenPagesCheckBox
			' 
			Me.showHeaderInEvenPagesCheckBox.AutoSize = True
			Me.showHeaderInEvenPagesCheckBox.Checked = True
			Me.showHeaderInEvenPagesCheckBox.CheckState = CheckState.Checked
			Me.showHeaderInEvenPagesCheckBox.Location = New Point(362, 108)
			Me.showHeaderInEvenPagesCheckBox.Name = "showHeaderInEvenPagesCheckBox"
			Me.showHeaderInEvenPagesCheckBox.Size = New Size(145, 21)
			Me.showHeaderInEvenPagesCheckBox.TabIndex = 0
			Me.showHeaderInEvenPagesCheckBox.Text = "Show in Even Pages"
			Me.showHeaderInEvenPagesCheckBox.UseVisualStyleBackColor = True
			' 
			' drawFooterLineCheckBox
			' 
			Me.drawFooterLineCheckBox.AutoSize = True
			Me.drawFooterLineCheckBox.Checked = True
			Me.drawFooterLineCheckBox.CheckState = CheckState.Checked
			Me.drawFooterLineCheckBox.Location = New Point(192, 240)
			Me.drawFooterLineCheckBox.Name = "drawFooterLineCheckBox"
			Me.drawFooterLineCheckBox.Size = New Size(127, 21)
			Me.drawFooterLineCheckBox.TabIndex = 0
			Me.drawFooterLineCheckBox.Text = "Draw Footer Line"
			Me.drawFooterLineCheckBox.UseVisualStyleBackColor = True
			' 
			' addPageNumbersInFooterCheckBox
			' 
			Me.addPageNumbersInFooterCheckBox.AutoSize = True
			Me.addPageNumbersInFooterCheckBox.Checked = True
			Me.addPageNumbersInFooterCheckBox.CheckState = CheckState.Checked
			Me.addPageNumbersInFooterCheckBox.Location = New Point(33, 240)
			Me.addPageNumbersInFooterCheckBox.Name = "addPageNumbersInFooterCheckBox"
			Me.addPageNumbersInFooterCheckBox.Size = New Size(140, 21)
			Me.addPageNumbersInFooterCheckBox.TabIndex = 0
			Me.addPageNumbersInFooterCheckBox.Text = "Add Page Numbers"
			Me.addPageNumbersInFooterCheckBox.UseVisualStyleBackColor = True
			' 
			' showFooterInFirstPageCheckBox
			' 
			Me.showFooterInFirstPageCheckBox.AutoSize = True
			Me.showFooterInFirstPageCheckBox.Checked = True
			Me.showFooterInFirstPageCheckBox.CheckState = CheckState.Checked
			Me.showFooterInFirstPageCheckBox.Location = New Point(33, 205)
			Me.showFooterInFirstPageCheckBox.Name = "showFooterInFirstPageCheckBox"
			Me.showFooterInFirstPageCheckBox.Size = New Size(135, 21)
			Me.showFooterInFirstPageCheckBox.TabIndex = 0
			Me.showFooterInFirstPageCheckBox.Text = "Show in First Page"
			Me.showFooterInFirstPageCheckBox.UseVisualStyleBackColor = True
			' 
			' showHeaderInOddPagesCheckBox
			' 
			Me.showHeaderInOddPagesCheckBox.AutoSize = True
			Me.showHeaderInOddPagesCheckBox.Checked = True
			Me.showHeaderInOddPagesCheckBox.CheckState = CheckState.Checked
			Me.showHeaderInOddPagesCheckBox.Location = New Point(192, 108)
			Me.showHeaderInOddPagesCheckBox.Name = "showHeaderInOddPagesCheckBox"
			Me.showHeaderInOddPagesCheckBox.Size = New Size(141, 21)
			Me.showHeaderInOddPagesCheckBox.TabIndex = 0
			Me.showHeaderInOddPagesCheckBox.Text = "Show in Odd Pages"
			Me.showHeaderInOddPagesCheckBox.UseVisualStyleBackColor = True
			' 
			' showHeaderInFirstPageCheckBox
			' 
			Me.showHeaderInFirstPageCheckBox.AutoSize = True
			Me.showHeaderInFirstPageCheckBox.Checked = True
			Me.showHeaderInFirstPageCheckBox.CheckState = CheckState.Checked
			Me.showHeaderInFirstPageCheckBox.Location = New Point(33, 108)
			Me.showHeaderInFirstPageCheckBox.Name = "showHeaderInFirstPageCheckBox"
			Me.showHeaderInFirstPageCheckBox.Size = New Size(135, 21)
			Me.showHeaderInFirstPageCheckBox.TabIndex = 0
			Me.showHeaderInFirstPageCheckBox.Text = "Show in First Page"
			Me.showHeaderInFirstPageCheckBox.UseVisualStyleBackColor = True
			' 
			' drawHeaderLineCheckBox
			' 
			Me.drawHeaderLineCheckBox.AutoSize = True
			Me.drawHeaderLineCheckBox.Checked = True
			Me.drawHeaderLineCheckBox.CheckState = CheckState.Checked
			Me.drawHeaderLineCheckBox.Location = New Point(33, 142)
			Me.drawHeaderLineCheckBox.Name = "drawHeaderLineCheckBox"
			Me.drawHeaderLineCheckBox.Size = New Size(133, 21)
			Me.drawHeaderLineCheckBox.TabIndex = 0
			Me.drawHeaderLineCheckBox.Text = "Draw Header Line"
			Me.drawHeaderLineCheckBox.UseVisualStyleBackColor = True
			' 
			' addHeaderCheckBox
			' 
			Me.addHeaderCheckBox.AutoSize = True
			Me.addHeaderCheckBox.Checked = True
			Me.addHeaderCheckBox.CheckState = CheckState.Checked
			Me.addHeaderCheckBox.Location = New Point(33, 41)
			Me.addHeaderCheckBox.Name = "addHeaderCheckBox"
			Me.addHeaderCheckBox.Size = New Size(98, 21)
			Me.addHeaderCheckBox.TabIndex = 0
			Me.addHeaderCheckBox.Text = "Add Header"
			Me.addHeaderCheckBox.UseVisualStyleBackColor = True
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 102)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 66)
			Me.urlPanel.TabIndex = 87
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
			Me.descriptionPanel.Size = New Size(598, 56)
			Me.descriptionPanel.TabIndex = 86
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
			Me.titlePanel.TabIndex = 85
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(243, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Add HTML in Header and Footer"
			' 
			' HTML_in_Header_Footer_Demo
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
			Me.Name = "HTML_in_Header_Footer_Demo"
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
		Private WithEvents createPdfButton As Button
		Private settingsPanel As Panel
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
		Private label1 As Label
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
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
	End Class
End Namespace

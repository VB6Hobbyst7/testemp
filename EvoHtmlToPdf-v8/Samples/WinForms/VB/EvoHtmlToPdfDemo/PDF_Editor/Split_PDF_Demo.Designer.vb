Namespace EvoHtmlToPdfDemo.PDF_Editor
	Partial Public Class Split_PDF_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Split_PDF_Demo))
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.convertButtonPanel = New Panel()
			Me.splitPdfButton = New Button()
			Me.splitResultPanel = New Panel()
			Me.openInitialLinkLabel = New LinkLabel()
			Me.openSecondLinkLabel = New LinkLabel()
			Me.openFirstLinkLabel = New LinkLabel()
			Me.label1 = New Label()
			Me.urlPanel = New Panel()
			Me.selectFileButton = New Button()
			Me.pdfFilePathTextBox = New TextBox()
			Me.enterUrlLabel = New Label()
			Me.descriptionPanel = New Panel()
			Me.descriptionLabel = New Label()
			Me.titlePanel = New Panel()
			Me.titleLabel = New Label()
			Me.convertButtonPanel.SuspendLayout()
			Me.splitResultPanel.SuspendLayout()
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
			Me.demoLeftPanel.TabIndex = 131
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 130
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 644)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 129
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 128
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.splitPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 238)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 42)
			Me.convertButtonPanel.TabIndex = 140
			' 
			' splitPdfButton
			' 
			Me.splitPdfButton.Location = New Point(6, 6)
			Me.splitPdfButton.Name = "splitPdfButton"
			Me.splitPdfButton.Size = New Size(86, 27)
			Me.splitPdfButton.TabIndex = 66
			Me.splitPdfButton.Text = "Split PDF"
			Me.splitPdfButton.UseVisualStyleBackColor = True
'			Me.splitPdfButton.Click += New System.EventHandler(Me.splitPdfButton_Click)
			' 
			' splitResultPanel
			' 
			Me.splitResultPanel.Controls.Add(Me.openInitialLinkLabel)
			Me.splitResultPanel.Controls.Add(Me.openSecondLinkLabel)
			Me.splitResultPanel.Controls.Add(Me.openFirstLinkLabel)
			Me.splitResultPanel.Controls.Add(Me.label1)
			Me.splitResultPanel.Dock = DockStyle.Top
			Me.splitResultPanel.Location = New Point(6, 177)
			Me.splitResultPanel.Name = "splitResultPanel"
			Me.splitResultPanel.Size = New Size(598, 61)
			Me.splitResultPanel.TabIndex = 139
			Me.splitResultPanel.Visible = False
			' 
			' openInitialLinkLabel
			' 
			Me.openInitialLinkLabel.AutoSize = True
			Me.openInitialLinkLabel.Location = New Point(414, 31)
			Me.openInitialLinkLabel.Name = "openInitialLinkLabel"
			Me.openInitialLinkLabel.Size = New Size(96, 15)
			Me.openInitialLinkLabel.TabIndex = 43
			Me.openInitialLinkLabel.TabStop = True
			Me.openInitialLinkLabel.Text = "Open Initial PDF"
'			Me.openInitialLinkLabel.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.openInitialLinkLabel_LinkClicked_1)
			' 
			' openSecondLinkLabel
			' 
			Me.openSecondLinkLabel.AutoSize = True
			Me.openSecondLinkLabel.Location = New Point(193, 31)
			Me.openSecondLinkLabel.Name = "openSecondLinkLabel"
			Me.openSecondLinkLabel.Size = New Size(181, 15)
			Me.openSecondLinkLabel.TabIndex = 43
			Me.openSecondLinkLabel.TabStop = True
			Me.openSecondLinkLabel.Text = "Open the Second Resulted PDF"
'			Me.openSecondLinkLabel.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.openSecondLinkLabel_LinkClicked)
			' 
			' openFirstLinkLabel
			' 
			Me.openFirstLinkLabel.AutoSize = True
			Me.openFirstLinkLabel.Location = New Point(6, 31)
			Me.openFirstLinkLabel.Name = "openFirstLinkLabel"
			Me.openFirstLinkLabel.Size = New Size(162, 15)
			Me.openFirstLinkLabel.TabIndex = 43
			Me.openFirstLinkLabel.TabStop = True
			Me.openFirstLinkLabel.Text = "Open the First Resulted PDF"
'			Me.openFirstLinkLabel.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.openFirstLinkLabel_LinkClicked)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label1.Location = New Point(6, 3)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(81, 15)
			Me.label1.TabIndex = 42
			Me.label1.Text = "Split Result"
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.selectFileButton)
			Me.urlPanel.Controls.Add(Me.pdfFilePathTextBox)
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 98)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 79)
			Me.urlPanel.TabIndex = 138
			' 
			' selectFileButton
			' 
			Me.selectFileButton.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.selectFileButton.Location = New Point(516, 37)
			Me.selectFileButton.Name = "selectFileButton"
			Me.selectFileButton.Size = New Size(66, 26)
			Me.selectFileButton.TabIndex = 44
			Me.selectFileButton.Text = "Browse"
			Me.selectFileButton.UseVisualStyleBackColor = True
'			Me.selectFileButton.Click += New System.EventHandler(Me.selectFileButton_Click)
			' 
			' pdfFilePathTextBox
			' 
			Me.pdfFilePathTextBox.Location = New Point(9, 40)
			Me.pdfFilePathTextBox.Name = "pdfFilePathTextBox"
			Me.pdfFilePathTextBox.Size = New Size(501, 21)
			Me.pdfFilePathTextBox.TabIndex = 43
			' 
			' enterUrlLabel
			' 
			Me.enterUrlLabel.AutoSize = True
			Me.enterUrlLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.enterUrlLabel.Location = New Point(6, 13)
			Me.enterUrlLabel.Name = "enterUrlLabel"
			Me.enterUrlLabel.Size = New Size(180, 15)
			Me.enterUrlLabel.TabIndex = 42
			Me.enterUrlLabel.Text = "The PDF Document to Split"
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 52)
			Me.descriptionPanel.TabIndex = 137
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 52)
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
			Me.titlePanel.TabIndex = 136
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(160, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Split PDF Documents"
			' 
			' Split_PDF_Demo
			' 
			Me.AutoScaleDimensions = New SizeF(7F, 15F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScroll = True
			Me.Controls.Add(Me.convertButtonPanel)
			Me.Controls.Add(Me.splitResultPanel)
			Me.Controls.Add(Me.urlPanel)
			Me.Controls.Add(Me.descriptionPanel)
			Me.Controls.Add(Me.titlePanel)
			Me.Controls.Add(Me.demoLeftPanel)
			Me.Controls.Add(Me.demoRightPanel)
			Me.Controls.Add(Me.demoBottomPanel)
			Me.Controls.Add(Me.demoTopPanel)
			Me.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.Name = "Split_PDF_Demo"
			Me.Size = New Size(610, 650)
'			Me.Load += New System.EventHandler(Me.Split_PDF_Demo_Load)
			Me.convertButtonPanel.ResumeLayout(False)
			Me.splitResultPanel.ResumeLayout(False)
			Me.splitResultPanel.PerformLayout()
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
		Private WithEvents splitPdfButton As Button
		Private splitResultPanel As Panel
		Private label1 As Label
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
		Private WithEvents openSecondLinkLabel As LinkLabel
		Private WithEvents openFirstLinkLabel As LinkLabel
		Private WithEvents selectFileButton As Button
		Private pdfFilePathTextBox As TextBox
		Private WithEvents openInitialLinkLabel As LinkLabel
	End Class
End Namespace

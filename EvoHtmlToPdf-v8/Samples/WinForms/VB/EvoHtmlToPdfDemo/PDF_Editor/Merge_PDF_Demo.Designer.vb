Namespace EvoHtmlToPdfDemo.PDF_Editor
	Partial Public Class Merge_PDF_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Merge_PDF_Demo))
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.convertButtonPanel = New Panel()
			Me.mergePdfButton = New Button()
			Me.urlPanel = New Panel()
			Me.selectSecondPdfFileButton = New Button()
			Me.selectFirstPdfFileButton = New Button()
			Me.secondPdfFilePathTextBox = New TextBox()
			Me.label2 = New Label()
			Me.firstPdfFilePathTextBox = New TextBox()
			Me.enterUrlLabel = New Label()
			Me.descriptionPanel = New Panel()
			Me.descriptionLabel = New Label()
			Me.titlePanel = New Panel()
			Me.titleLabel = New Label()
			Me.convertButtonPanel.SuspendLayout()
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
			Me.demoLeftPanel.TabIndex = 135
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 134
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 644)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 133
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 132
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.mergePdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 240)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 42)
			Me.convertButtonPanel.TabIndex = 145
			' 
			' mergePdfButton
			' 
			Me.mergePdfButton.Location = New Point(6, 6)
			Me.mergePdfButton.Name = "mergePdfButton"
			Me.mergePdfButton.Size = New Size(86, 27)
			Me.mergePdfButton.TabIndex = 66
			Me.mergePdfButton.Text = "Merge PDF"
			Me.mergePdfButton.UseVisualStyleBackColor = True
'			Me.mergePdfButton.Click += New System.EventHandler(Me.mergePdfButton_Click)
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.selectSecondPdfFileButton)
			Me.urlPanel.Controls.Add(Me.selectFirstPdfFileButton)
			Me.urlPanel.Controls.Add(Me.secondPdfFilePathTextBox)
			Me.urlPanel.Controls.Add(Me.label2)
			Me.urlPanel.Controls.Add(Me.firstPdfFilePathTextBox)
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 98)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 142)
			Me.urlPanel.TabIndex = 143
			' 
			' selectSecondPdfFileButton
			' 
			Me.selectSecondPdfFileButton.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.selectSecondPdfFileButton.Location = New Point(516, 102)
			Me.selectSecondPdfFileButton.Name = "selectSecondPdfFileButton"
			Me.selectSecondPdfFileButton.Size = New Size(66, 26)
			Me.selectSecondPdfFileButton.TabIndex = 44
			Me.selectSecondPdfFileButton.Text = "Browse"
			Me.selectSecondPdfFileButton.UseVisualStyleBackColor = True
'			Me.selectSecondPdfFileButton.Click += New System.EventHandler(Me.selectSecondPdfFileButton_Click)
			' 
			' selectFirstPdfFileButton
			' 
			Me.selectFirstPdfFileButton.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.selectFirstPdfFileButton.Location = New Point(516, 37)
			Me.selectFirstPdfFileButton.Name = "selectFirstPdfFileButton"
			Me.selectFirstPdfFileButton.Size = New Size(66, 26)
			Me.selectFirstPdfFileButton.TabIndex = 44
			Me.selectFirstPdfFileButton.Text = "Browse"
			Me.selectFirstPdfFileButton.UseVisualStyleBackColor = True
'			Me.selectFirstPdfFileButton.Click += New System.EventHandler(Me.selectFirstPdfFileButton_Click)
			' 
			' secondPdfFilePathTextBox
			' 
			Me.secondPdfFilePathTextBox.Location = New Point(9, 105)
			Me.secondPdfFilePathTextBox.Name = "secondPdfFilePathTextBox"
			Me.secondPdfFilePathTextBox.Size = New Size(501, 21)
			Me.secondPdfFilePathTextBox.TabIndex = 43
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label2.Location = New Point(6, 78)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(185, 15)
			Me.label2.TabIndex = 42
			Me.label2.Text = "Second Document to Merge"
			' 
			' firstPdfFilePathTextBox
			' 
			Me.firstPdfFilePathTextBox.Location = New Point(9, 40)
			Me.firstPdfFilePathTextBox.Name = "firstPdfFilePathTextBox"
			Me.firstPdfFilePathTextBox.Size = New Size(501, 21)
			Me.firstPdfFilePathTextBox.TabIndex = 43
			' 
			' enterUrlLabel
			' 
			Me.enterUrlLabel.AutoSize = True
			Me.enterUrlLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.enterUrlLabel.Location = New Point(6, 13)
			Me.enterUrlLabel.Name = "enterUrlLabel"
			Me.enterUrlLabel.Size = New Size(165, 15)
			Me.enterUrlLabel.TabIndex = 42
			Me.enterUrlLabel.Text = "First Document to Merge"
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 52)
			Me.descriptionPanel.TabIndex = 142
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
			Me.titlePanel.TabIndex = 141
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(173, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Merge PDF Documents"
			' 
			' Merge_PDF_Demo
			' 
			Me.AutoScaleDimensions = New SizeF(7F, 15F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScroll = True
			Me.Controls.Add(Me.convertButtonPanel)
			Me.Controls.Add(Me.urlPanel)
			Me.Controls.Add(Me.descriptionPanel)
			Me.Controls.Add(Me.titlePanel)
			Me.Controls.Add(Me.demoLeftPanel)
			Me.Controls.Add(Me.demoRightPanel)
			Me.Controls.Add(Me.demoBottomPanel)
			Me.Controls.Add(Me.demoTopPanel)
			Me.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.Name = "Merge_PDF_Demo"
			Me.Size = New Size(610, 650)
'			Me.Load += New System.EventHandler(Me.Merge_PDF_Demo_Load)
			Me.convertButtonPanel.ResumeLayout(False)
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
		Private WithEvents mergePdfButton As Button
		Private urlPanel As Panel
		Private WithEvents selectFirstPdfFileButton As Button
		Private firstPdfFilePathTextBox As TextBox
		Private enterUrlLabel As Label
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
		Private WithEvents selectSecondPdfFileButton As Button
		Private secondPdfFilePathTextBox As TextBox
		Private label2 As Label
	End Class
End Namespace

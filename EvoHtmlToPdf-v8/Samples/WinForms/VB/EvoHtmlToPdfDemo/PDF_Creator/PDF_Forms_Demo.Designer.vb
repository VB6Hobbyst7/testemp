Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class PDF_Forms_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(PDF_Forms_Demo))
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.descriptionPanel = New Panel()
			Me.descriptionLabel = New Label()
			Me.titlePanel = New Panel()
			Me.titleLabel = New Label()
			Me.optionsPanel = New Panel()
			Me.submitUrlLabel = New Label()
			Me.submitUrlTextBox = New TextBox()
			Me.panel1 = New Panel()
			Me.postMethodRadioButton = New RadioButton()
			Me.getMethodRadioButton = New RadioButton()
			Me.label5 = New Label()
			Me.convertButtonPanel = New Panel()
			Me.createPdfButton = New Button()
			Me.descriptionPanel.SuspendLayout()
			Me.titlePanel.SuspendLayout()
			Me.optionsPanel.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.convertButtonPanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' demoLeftPanel
			' 
			Me.demoLeftPanel.Dock = DockStyle.Left
			Me.demoLeftPanel.Location = New Point(0, 6)
			Me.demoLeftPanel.Name = "demoLeftPanel"
			Me.demoLeftPanel.Size = New Size(6, 638)
			Me.demoLeftPanel.TabIndex = 163
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 162
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 644)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 161
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 160
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 53)
			Me.descriptionPanel.TabIndex = 179
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 53)
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
			Me.titlePanel.TabIndex = 178
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(290, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Create a PDF Form in a PDF Document"
			' 
			' optionsPanel
			' 
			Me.optionsPanel.Controls.Add(Me.submitUrlLabel)
			Me.optionsPanel.Controls.Add(Me.submitUrlTextBox)
			Me.optionsPanel.Controls.Add(Me.panel1)
			Me.optionsPanel.Controls.Add(Me.label5)
			Me.optionsPanel.Dock = DockStyle.Top
			Me.optionsPanel.Location = New Point(6, 99)
			Me.optionsPanel.Name = "optionsPanel"
			Me.optionsPanel.Size = New Size(598, 129)
			Me.optionsPanel.TabIndex = 181
			' 
			' submitUrlLabel
			' 
			Me.submitUrlLabel.AutoSize = True
			Me.submitUrlLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.submitUrlLabel.Location = New Point(0, 12)
			Me.submitUrlLabel.Name = "submitUrlLabel"
			Me.submitUrlLabel.Size = New Size(152, 15)
			Me.submitUrlLabel.TabIndex = 42
			Me.submitUrlLabel.Text = "PDF Form Submit URL"
			' 
			' submitUrlTextBox
			' 
			Me.submitUrlTextBox.Location = New Point(21, 39)
			Me.submitUrlTextBox.Name = "submitUrlTextBox"
			Me.submitUrlTextBox.Size = New Size(561, 21)
			Me.submitUrlTextBox.TabIndex = 43
			Me.submitUrlTextBox.Text = "http://www.evopdf.com/pdf_forms_submit/"
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.postMethodRadioButton)
			Me.panel1.Controls.Add(Me.getMethodRadioButton)
			Me.panel1.Location = New Point(6, 92)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Size(252, 27)
			Me.panel1.TabIndex = 7
			' 
			' postMethodRadioButton
			' 
			Me.postMethodRadioButton.AutoSize = True
			Me.postMethodRadioButton.Checked = True
			Me.postMethodRadioButton.Location = New Point(15, 5)
			Me.postMethodRadioButton.Name = "postMethodRadioButton"
			Me.postMethodRadioButton.Size = New Size(64, 20)
			Me.postMethodRadioButton.TabIndex = 0
			Me.postMethodRadioButton.TabStop = True
			Me.postMethodRadioButton.Text = "POST"
			Me.postMethodRadioButton.UseVisualStyleBackColor = True
			' 
			' getMethodRadioButton
			' 
			Me.getMethodRadioButton.AutoSize = True
			Me.getMethodRadioButton.Location = New Point(88, 5)
			Me.getMethodRadioButton.Name = "getMethodRadioButton"
			Me.getMethodRadioButton.Size = New Size(56, 20)
			Me.getMethodRadioButton.TabIndex = 0
			Me.getMethodRadioButton.Text = "GET"
			Me.getMethodRadioButton.UseVisualStyleBackColor = True
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label5.Location = New Point(0, 74)
			Me.label5.Name = "label5"
			Me.label5.Size = New Size(108, 15)
			Me.label5.TabIndex = 4
			Me.label5.Text = "Submit Method:"
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.createPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 228)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 43)
			Me.convertButtonPanel.TabIndex = 182
			' 
			' createPdfButton
			' 
			Me.createPdfButton.Location = New Point(3, 6)
			Me.createPdfButton.Name = "createPdfButton"
			Me.createPdfButton.Size = New Size(160, 27)
			Me.createPdfButton.TabIndex = 66
			Me.createPdfButton.Text = "Create PDF Document"
			Me.createPdfButton.UseVisualStyleBackColor = True
'			Me.createPdfButton.Click += New System.EventHandler(Me.createPdfButton_Click)
			' 
			' PDF_Forms_Demo
			' 
			Me.AutoScaleDimensions = New SizeF(7F, 15F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScroll = True
			Me.Controls.Add(Me.convertButtonPanel)
			Me.Controls.Add(Me.optionsPanel)
			Me.Controls.Add(Me.descriptionPanel)
			Me.Controls.Add(Me.titlePanel)
			Me.Controls.Add(Me.demoLeftPanel)
			Me.Controls.Add(Me.demoRightPanel)
			Me.Controls.Add(Me.demoBottomPanel)
			Me.Controls.Add(Me.demoTopPanel)
			Me.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.Name = "PDF_Forms_Demo"
			Me.Size = New Size(610, 650)
			Me.descriptionPanel.ResumeLayout(False)
			Me.titlePanel.ResumeLayout(False)
			Me.titlePanel.PerformLayout()
			Me.optionsPanel.ResumeLayout(False)
			Me.optionsPanel.PerformLayout()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.convertButtonPanel.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private demoLeftPanel As Panel
		Private demoRightPanel As Panel
		Private demoBottomPanel As Panel
		Private demoTopPanel As Panel
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
		Private optionsPanel As Panel
		Private panel1 As Panel
		Private postMethodRadioButton As RadioButton
		Private getMethodRadioButton As RadioButton
		Private label5 As Label
		Private convertButtonPanel As Panel
		Private WithEvents createPdfButton As Button
		Private submitUrlLabel As Label
		Private submitUrlTextBox As TextBox
	End Class
End Namespace

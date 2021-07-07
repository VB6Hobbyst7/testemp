Namespace EvoHtmlToPdfDemo.PDF_Editor
	Partial Public Class Fill_PDF_Forms_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Fill_PDF_Forms_Demo))
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.descriptionPanel = New Panel()
			Me.descriptionLabel = New Label()
			Me.titlePanel = New Panel()
			Me.titleLabel = New Label()
			Me.splitResultPanel = New Panel()
			Me.openInitialLinkLabel = New LinkLabel()
			Me.label1 = New Label()
			Me.formValuesPanel = New Panel()
			Me.commentsTextBox = New TextBox()
			Me.carTypeComboBox = New ComboBox()
			Me.haveCarCheckBox = New CheckBox()
			Me.femaleRadioButton = New RadioButton()
			Me.maleRadioButton = New RadioButton()
			Me.label2 = New Label()
			Me.label8 = New Label()
			Me.passwordTextBox = New TextBox()
			Me.label4 = New Label()
			Me.lastNameTextBox = New TextBox()
			Me.label5 = New Label()
			Me.label6 = New Label()
			Me.label7 = New Label()
			Me.label3 = New Label()
			Me.firstNameTextBox = New TextBox()
			Me.convertButtonPanel = New Panel()
			Me.fillPdfButton = New Button()
			Me.flattenPdfFormCheckBox = New CheckBox()
			Me.descriptionPanel.SuspendLayout()
			Me.titlePanel.SuspendLayout()
			Me.splitResultPanel.SuspendLayout()
			Me.formValuesPanel.SuspendLayout()
			Me.convertButtonPanel.SuspendLayout()
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
			Me.titleLabel.Size = New Size(113, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Fill PDF Forms"
			' 
			' splitResultPanel
			' 
			Me.splitResultPanel.Controls.Add(Me.openInitialLinkLabel)
			Me.splitResultPanel.Controls.Add(Me.label1)
			Me.splitResultPanel.Dock = DockStyle.Top
			Me.splitResultPanel.Location = New Point(6, 98)
			Me.splitResultPanel.Name = "splitResultPanel"
			Me.splitResultPanel.Size = New Size(598, 65)
			Me.splitResultPanel.TabIndex = 147
			' 
			' openInitialLinkLabel
			' 
			Me.openInitialLinkLabel.AutoSize = True
			Me.openInitialLinkLabel.Location = New Point(21, 36)
			Me.openInitialLinkLabel.Name = "openInitialLinkLabel"
			Me.openInitialLinkLabel.Size = New Size(207, 15)
			Me.openInitialLinkLabel.TabIndex = 43
			Me.openInitialLinkLabel.TabStop = True
			Me.openInitialLinkLabel.Text = "Open Initial PDF with an Empty Form"
'			Me.openInitialLinkLabel.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.openInitialLinkLabel_LinkClicked)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label1.Location = New Point(3, 10)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(169, 15)
			Me.label1.TabIndex = 42
			Me.label1.Text = "PDF File with Form to Fill"
			' 
			' formValuesPanel
			' 
			Me.formValuesPanel.Controls.Add(Me.commentsTextBox)
			Me.formValuesPanel.Controls.Add(Me.carTypeComboBox)
			Me.formValuesPanel.Controls.Add(Me.haveCarCheckBox)
			Me.formValuesPanel.Controls.Add(Me.femaleRadioButton)
			Me.formValuesPanel.Controls.Add(Me.maleRadioButton)
			Me.formValuesPanel.Controls.Add(Me.label2)
			Me.formValuesPanel.Controls.Add(Me.label8)
			Me.formValuesPanel.Controls.Add(Me.passwordTextBox)
			Me.formValuesPanel.Controls.Add(Me.label4)
			Me.formValuesPanel.Controls.Add(Me.lastNameTextBox)
			Me.formValuesPanel.Controls.Add(Me.label5)
			Me.formValuesPanel.Controls.Add(Me.label6)
			Me.formValuesPanel.Controls.Add(Me.label7)
			Me.formValuesPanel.Controls.Add(Me.label3)
			Me.formValuesPanel.Controls.Add(Me.firstNameTextBox)
			Me.formValuesPanel.Dock = DockStyle.Top
			Me.formValuesPanel.Location = New Point(6, 163)
			Me.formValuesPanel.Name = "formValuesPanel"
			Me.formValuesPanel.Size = New Size(598, 217)
			Me.formValuesPanel.TabIndex = 149
			' 
			' commentsTextBox
			' 
			Me.commentsTextBox.Location = New Point(25, 143)
			Me.commentsTextBox.Multiline = True
			Me.commentsTextBox.Name = "commentsTextBox"
			Me.commentsTextBox.Size = New Size(429, 58)
			Me.commentsTextBox.TabIndex = 54
			Me.commentsTextBox.Text = "My comments" & vbCrLf & "Line 1" & vbCrLf & "Line 2"
			' 
			' carTypeComboBox
			' 
			Me.carTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList
			Me.carTypeComboBox.FormattingEnabled = True
			Me.carTypeComboBox.Items.AddRange(New Object() { "Volvo", "Saab", "Audi", "Opel"})
			Me.carTypeComboBox.Location = New Point(201, 91)
			Me.carTypeComboBox.Name = "carTypeComboBox"
			Me.carTypeComboBox.Size = New Size(121, 23)
			Me.carTypeComboBox.TabIndex = 53
			' 
			' haveCarCheckBox
			' 
			Me.haveCarCheckBox.AutoSize = True
			Me.haveCarCheckBox.Checked = True
			Me.haveCarCheckBox.CheckState = CheckState.Checked
			Me.haveCarCheckBox.Location = New Point(25, 93)
			Me.haveCarCheckBox.Name = "haveCarCheckBox"
			Me.haveCarCheckBox.Size = New Size(95, 21)
			Me.haveCarCheckBox.TabIndex = 52
			Me.haveCarCheckBox.Text = "I have a car"
			Me.haveCarCheckBox.UseVisualStyleBackColor = True
			' 
			' femaleRadioButton
			' 
			Me.femaleRadioButton.AutoSize = True
			Me.femaleRadioButton.Checked = True
			Me.femaleRadioButton.Location = New Point(161, 58)
			Me.femaleRadioButton.Name = "femaleRadioButton"
			Me.femaleRadioButton.Size = New Size(74, 20)
			Me.femaleRadioButton.TabIndex = 51
			Me.femaleRadioButton.TabStop = True
			Me.femaleRadioButton.Text = "Female"
			Me.femaleRadioButton.UseVisualStyleBackColor = True
			' 
			' maleRadioButton
			' 
			Me.maleRadioButton.AutoSize = True
			Me.maleRadioButton.Location = New Point(98, 58)
			Me.maleRadioButton.Name = "maleRadioButton"
			Me.maleRadioButton.Size = New Size(60, 20)
			Me.maleRadioButton.TabIndex = 51
			Me.maleRadioButton.Text = "Male"
			Me.maleRadioButton.UseVisualStyleBackColor = True
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label2.Location = New Point(3, 3)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(130, 15)
			Me.label2.TabIndex = 47
			Me.label2.Text = "Form Fields Values"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New Point(365, 31)
			Me.label8.Name = "label8"
			Me.label8.Size = New Size(64, 15)
			Me.label8.TabIndex = 48
			Me.label8.Text = "Password:"
			' 
			' passwordTextBox
			' 
			Me.passwordTextBox.Location = New Point(435, 28)
			Me.passwordTextBox.Name = "passwordTextBox"
			Me.passwordTextBox.Size = New Size(70, 21)
			Me.passwordTextBox.TabIndex = 50
			Me.passwordTextBox.Text = "secret"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New Point(198, 31)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(70, 15)
			Me.label4.TabIndex = 48
			Me.label4.Text = "Last Name:"
			' 
			' lastNameTextBox
			' 
			Me.lastNameTextBox.Location = New Point(274, 28)
			Me.lastNameTextBox.Name = "lastNameTextBox"
			Me.lastNameTextBox.Size = New Size(70, 21)
			Me.lastNameTextBox.TabIndex = 50
			Me.lastNameTextBox.Text = "Smith"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New Point(22, 60)
			Me.label5.Name = "label5"
			Me.label5.Size = New Size(51, 15)
			Me.label5.TabIndex = 48
			Me.label5.Text = "Gender:"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New Point(137, 94)
			Me.label6.Name = "label6"
			Me.label6.Size = New Size(58, 15)
			Me.label6.TabIndex = 48
			Me.label6.Text = "Car Type:"
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New Point(22, 125)
			Me.label7.Name = "label7"
			Me.label7.Size = New Size(70, 15)
			Me.label7.TabIndex = 48
			Me.label7.Text = "Comments:"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New Point(22, 31)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(70, 15)
			Me.label3.TabIndex = 48
			Me.label3.Text = "First Name:"
			' 
			' firstNameTextBox
			' 
			Me.firstNameTextBox.Location = New Point(98, 28)
			Me.firstNameTextBox.Name = "firstNameTextBox"
			Me.firstNameTextBox.Size = New Size(70, 21)
			Me.firstNameTextBox.TabIndex = 50
			Me.firstNameTextBox.Text = "John"
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.fillPdfButton)
			Me.convertButtonPanel.Controls.Add(Me.flattenPdfFormCheckBox)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 380)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 42)
			Me.convertButtonPanel.TabIndex = 150
			' 
			' fillPdfButton
			' 
			Me.fillPdfButton.Location = New Point(6, 6)
			Me.fillPdfButton.Name = "fillPdfButton"
			Me.fillPdfButton.Size = New Size(115, 27)
			Me.fillPdfButton.TabIndex = 66
			Me.fillPdfButton.Text = "Fill PDF Form"
			Me.fillPdfButton.UseVisualStyleBackColor = True
'			Me.fillPdfButton.Click += New System.EventHandler(Me.fillPdfButton_Click)
			' 
			' flattenPdfFormCheckBox
			' 
			Me.flattenPdfFormCheckBox.AutoSize = True
			Me.flattenPdfFormCheckBox.Location = New Point(201, 11)
			Me.flattenPdfFormCheckBox.Name = "flattenPdfFormCheckBox"
			Me.flattenPdfFormCheckBox.Size = New Size(165, 21)
			Me.flattenPdfFormCheckBox.TabIndex = 52
			Me.flattenPdfFormCheckBox.Text = "Flatten PDF Form Fields"
			Me.flattenPdfFormCheckBox.UseVisualStyleBackColor = True
			' 
			' Fill_PDF_Forms_Demo
			' 
			Me.AutoScaleDimensions = New SizeF(7F, 15F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScroll = True
			Me.Controls.Add(Me.convertButtonPanel)
			Me.Controls.Add(Me.formValuesPanel)
			Me.Controls.Add(Me.splitResultPanel)
			Me.Controls.Add(Me.descriptionPanel)
			Me.Controls.Add(Me.titlePanel)
			Me.Controls.Add(Me.demoLeftPanel)
			Me.Controls.Add(Me.demoRightPanel)
			Me.Controls.Add(Me.demoBottomPanel)
			Me.Controls.Add(Me.demoTopPanel)
			Me.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.Name = "Fill_PDF_Forms_Demo"
			Me.Size = New Size(610, 650)
'			Me.Load += New System.EventHandler(Me.Fill_PDF_Forms_Demo_Load)
			Me.descriptionPanel.ResumeLayout(False)
			Me.titlePanel.ResumeLayout(False)
			Me.titlePanel.PerformLayout()
			Me.splitResultPanel.ResumeLayout(False)
			Me.splitResultPanel.PerformLayout()
			Me.formValuesPanel.ResumeLayout(False)
			Me.formValuesPanel.PerformLayout()
			Me.convertButtonPanel.ResumeLayout(False)
			Me.convertButtonPanel.PerformLayout()
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
		Private splitResultPanel As Panel
		Private WithEvents openInitialLinkLabel As LinkLabel
		Private label1 As Label
		Private formValuesPanel As Panel
		Private commentsTextBox As TextBox
		Private carTypeComboBox As ComboBox
		Private haveCarCheckBox As CheckBox
		Private femaleRadioButton As RadioButton
		Private maleRadioButton As RadioButton
		Private label2 As Label
		Private label4 As Label
		Private lastNameTextBox As TextBox
		Private label5 As Label
		Private label6 As Label
		Private label7 As Label
		Private label3 As Label
		Private firstNameTextBox As TextBox
		Private convertButtonPanel As Panel
		Private WithEvents fillPdfButton As Button
		Private flattenPdfFormCheckBox As CheckBox
		Private label8 As Label
		Private passwordTextBox As TextBox
	End Class
End Namespace

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security
	Partial Public Class PDF_Permissions_and_Password_Demo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PDF_Permissions_and_Password_Demo))
            Me.demoLeftPanel = New System.Windows.Forms.Panel()
            Me.demoRightPanel = New System.Windows.Forms.Panel()
            Me.demoBottomPanel = New System.Windows.Forms.Panel()
            Me.demoTopPanel = New System.Windows.Forms.Panel()
            Me.convertButtonPanel = New System.Windows.Forms.Panel()
            Me.convertToPdfButton = New System.Windows.Forms.Button()
            Me.settingsPanel = New System.Windows.Forms.Panel()
            Me.label4 = New System.Windows.Forms.Label()
            Me.urlPanel = New System.Windows.Forms.Panel()
            Me.enterUrlLabel = New System.Windows.Forms.Label()
            Me.urlTextBox = New System.Windows.Forms.TextBox()
            Me.descriptionPanel = New System.Windows.Forms.Panel()
            Me.descriptionLabel = New System.Windows.Forms.Label()
            Me.titlePanel = New System.Windows.Forms.Panel()
            Me.titleLabel = New System.Windows.Forms.Label()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.label5 = New System.Windows.Forms.Label()
            Me.bit256RadioButton = New System.Windows.Forms.RadioButton()
            Me.bit128RadioButton = New System.Windows.Forms.RadioButton()
            Me.bit40RadioButton = New System.Windows.Forms.RadioButton()
            Me.encryptionTypePanel = New System.Windows.Forms.Panel()
            Me.label3 = New System.Windows.Forms.Label()
            Me.aesRadioButton = New System.Windows.Forms.RadioButton()
            Me.rc4RadioButton = New System.Windows.Forms.RadioButton()
            Me.copyAccessibilityContentEnabledCheckBox = New System.Windows.Forms.CheckBox()
            Me.highResolutionPrintEnabledCheckBox = New System.Windows.Forms.CheckBox()
            Me.fillFormFieldsEnabledCheckBox = New System.Windows.Forms.CheckBox()
            Me.editAnnotationsEnabledCheckBox = New System.Windows.Forms.CheckBox()
            Me.editContentEnabledCheckBox = New System.Windows.Forms.CheckBox()
            Me.copyContentEnabledCheckBox = New System.Windows.Forms.CheckBox()
            Me.printEnabledCheckBox = New System.Windows.Forms.CheckBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.ownerPasswordTextBox = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.userPasswordTextBox = New System.Windows.Forms.TextBox()
            Me.convertButtonPanel.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            Me.urlPanel.SuspendLayout()
            Me.descriptionPanel.SuspendLayout()
            Me.titlePanel.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.encryptionTypePanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'demoLeftPanel
            '
            Me.demoLeftPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.demoLeftPanel.Location = New System.Drawing.Point(0, 6)
            Me.demoLeftPanel.Name = "demoLeftPanel"
            Me.demoLeftPanel.Size = New System.Drawing.Size(6, 638)
            Me.demoLeftPanel.TabIndex = 163
            '
            'demoRightPanel
            '
            Me.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.demoRightPanel.Location = New System.Drawing.Point(604, 6)
            Me.demoRightPanel.Name = "demoRightPanel"
            Me.demoRightPanel.Size = New System.Drawing.Size(6, 638)
            Me.demoRightPanel.TabIndex = 162
            '
            'demoBottomPanel
            '
            Me.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.demoBottomPanel.Location = New System.Drawing.Point(0, 644)
            Me.demoBottomPanel.Name = "demoBottomPanel"
            Me.demoBottomPanel.Size = New System.Drawing.Size(610, 6)
            Me.demoBottomPanel.TabIndex = 161
            '
            'demoTopPanel
            '
            Me.demoTopPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.demoTopPanel.Location = New System.Drawing.Point(0, 0)
            Me.demoTopPanel.Name = "demoTopPanel"
            Me.demoTopPanel.Size = New System.Drawing.Size(610, 6)
            Me.demoTopPanel.TabIndex = 160
            '
            'convertButtonPanel
            '
            Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
            Me.convertButtonPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.convertButtonPanel.Location = New System.Drawing.Point(6, 449)
            Me.convertButtonPanel.Name = "convertButtonPanel"
            Me.convertButtonPanel.Size = New System.Drawing.Size(598, 43)
            Me.convertButtonPanel.TabIndex = 188
            '
            'convertToPdfButton
            '
            Me.convertToPdfButton.Location = New System.Drawing.Point(6, 6)
            Me.convertToPdfButton.Name = "convertToPdfButton"
            Me.convertToPdfButton.Size = New System.Drawing.Size(150, 27)
            Me.convertToPdfButton.TabIndex = 66
            Me.convertToPdfButton.Text = "Convert HTML to PDF"
            Me.convertToPdfButton.UseVisualStyleBackColor = True
            '
            'settingsPanel
            '
            Me.settingsPanel.Controls.Add(Me.panel1)
            Me.settingsPanel.Controls.Add(Me.encryptionTypePanel)
            Me.settingsPanel.Controls.Add(Me.copyAccessibilityContentEnabledCheckBox)
            Me.settingsPanel.Controls.Add(Me.highResolutionPrintEnabledCheckBox)
            Me.settingsPanel.Controls.Add(Me.fillFormFieldsEnabledCheckBox)
            Me.settingsPanel.Controls.Add(Me.editAnnotationsEnabledCheckBox)
            Me.settingsPanel.Controls.Add(Me.editContentEnabledCheckBox)
            Me.settingsPanel.Controls.Add(Me.copyContentEnabledCheckBox)
            Me.settingsPanel.Controls.Add(Me.printEnabledCheckBox)
            Me.settingsPanel.Controls.Add(Me.label1)
            Me.settingsPanel.Controls.Add(Me.ownerPasswordTextBox)
            Me.settingsPanel.Controls.Add(Me.label2)
            Me.settingsPanel.Controls.Add(Me.userPasswordTextBox)
            Me.settingsPanel.Controls.Add(Me.label4)
            Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.settingsPanel.Location = New System.Drawing.Point(6, 168)
            Me.settingsPanel.Name = "settingsPanel"
            Me.settingsPanel.Size = New System.Drawing.Size(598, 281)
            Me.settingsPanel.TabIndex = 187
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.label4.Location = New System.Drawing.Point(3, 3)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(142, 15)
            Me.label4.TabIndex = 50
            Me.label4.Text = "PDF Security Options"
            '
            'urlPanel
            '
            Me.urlPanel.Controls.Add(Me.enterUrlLabel)
            Me.urlPanel.Controls.Add(Me.urlTextBox)
            Me.urlPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.urlPanel.Location = New System.Drawing.Point(6, 98)
            Me.urlPanel.Name = "urlPanel"
            Me.urlPanel.Size = New System.Drawing.Size(598, 70)
            Me.urlPanel.TabIndex = 186
            '
            'enterUrlLabel
            '
            Me.enterUrlLabel.AutoSize = True
            Me.enterUrlLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.enterUrlLabel.Location = New System.Drawing.Point(3, 7)
            Me.enterUrlLabel.Name = "enterUrlLabel"
            Me.enterUrlLabel.Size = New System.Drawing.Size(266, 15)
            Me.enterUrlLabel.TabIndex = 50
            Me.enterUrlLabel.Text = "HTML Page URL or Local File to Convert"
            '
            'urlTextBox
            '
            Me.urlTextBox.Location = New System.Drawing.Point(6, 36)
            Me.urlTextBox.Name = "urlTextBox"
            Me.urlTextBox.Size = New System.Drawing.Size(576, 21)
            Me.urlTextBox.TabIndex = 51
            Me.urlTextBox.Text = "http://www.evopdf.com"
            '
            'descriptionPanel
            '
            Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
            Me.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.descriptionPanel.Location = New System.Drawing.Point(6, 46)
            Me.descriptionPanel.Name = "descriptionPanel"
            Me.descriptionPanel.Size = New System.Drawing.Size(598, 52)
            Me.descriptionPanel.TabIndex = 185
            '
            'descriptionLabel
            '
            Me.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.descriptionLabel.Location = New System.Drawing.Point(0, 0)
            Me.descriptionLabel.Name = "descriptionLabel"
            Me.descriptionLabel.Size = New System.Drawing.Size(598, 52)
            Me.descriptionLabel.TabIndex = 0
            Me.descriptionLabel.Text = resources.GetString("descriptionLabel.Text")
            '
            'titlePanel
            '
            Me.titlePanel.Controls.Add(Me.titleLabel)
            Me.titlePanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.titlePanel.Location = New System.Drawing.Point(6, 6)
            Me.titlePanel.Name = "titlePanel"
            Me.titlePanel.Size = New System.Drawing.Size(598, 40)
            Me.titlePanel.TabIndex = 184
            '
            'titleLabel
            '
            Me.titleLabel.AutoSize = True
            Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.titleLabel.Location = New System.Drawing.Point(0, 10)
            Me.titleLabel.Name = "titleLabel"
            Me.titleLabel.Size = New System.Drawing.Size(509, 17)
            Me.titleLabel.TabIndex = 1
            Me.titleLabel.Text = "Set Permissions and Password Protect the Generated PDF Document"
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.bit256RadioButton)
            Me.panel1.Controls.Add(Me.bit128RadioButton)
            Me.panel1.Controls.Add(Me.bit40RadioButton)
            Me.panel1.Location = New System.Drawing.Point(19, 236)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(502, 31)
            Me.panel1.TabIndex = 92
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(8, 9)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(90, 15)
            Me.label5.TabIndex = 51
            Me.label5.Text = "Encryption Key:"
            '
            'bit256RadioButton
            '
            Me.bit256RadioButton.AutoSize = True
            Me.bit256RadioButton.Enabled = False
            Me.bit256RadioButton.Location = New System.Drawing.Point(286, 7)
            Me.bit256RadioButton.Name = "bit256RadioButton"
            Me.bit256RadioButton.Size = New System.Drawing.Size(69, 19)
            Me.bit256RadioButton.TabIndex = 71
            Me.bit256RadioButton.Text = "256 Bits"
            Me.bit256RadioButton.UseVisualStyleBackColor = True
            '
            'bit128RadioButton
            '
            Me.bit128RadioButton.AutoSize = True
            Me.bit128RadioButton.Checked = True
            Me.bit128RadioButton.Location = New System.Drawing.Point(201, 7)
            Me.bit128RadioButton.Name = "bit128RadioButton"
            Me.bit128RadioButton.Size = New System.Drawing.Size(69, 19)
            Me.bit128RadioButton.TabIndex = 71
            Me.bit128RadioButton.TabStop = True
            Me.bit128RadioButton.Text = "128 Bits"
            Me.bit128RadioButton.UseVisualStyleBackColor = True
            '
            'bit40RadioButton
            '
            Me.bit40RadioButton.AutoSize = True
            Me.bit40RadioButton.Location = New System.Drawing.Point(129, 7)
            Me.bit40RadioButton.Name = "bit40RadioButton"
            Me.bit40RadioButton.Size = New System.Drawing.Size(62, 19)
            Me.bit40RadioButton.TabIndex = 70
            Me.bit40RadioButton.Text = "40 Bits"
            Me.bit40RadioButton.UseVisualStyleBackColor = True
            '
            'encryptionTypePanel
            '
            Me.encryptionTypePanel.Controls.Add(Me.label3)
            Me.encryptionTypePanel.Controls.Add(Me.aesRadioButton)
            Me.encryptionTypePanel.Controls.Add(Me.rc4RadioButton)
            Me.encryptionTypePanel.Location = New System.Drawing.Point(19, 199)
            Me.encryptionTypePanel.Name = "encryptionTypePanel"
            Me.encryptionTypePanel.Size = New System.Drawing.Size(502, 31)
            Me.encryptionTypePanel.TabIndex = 93
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(8, 9)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(96, 15)
            Me.label3.TabIndex = 51
            Me.label3.Text = "Encryption Type:"
            '
            'aesRadioButton
            '
            Me.aesRadioButton.AutoSize = True
            Me.aesRadioButton.Location = New System.Drawing.Point(201, 7)
            Me.aesRadioButton.Name = "aesRadioButton"
            Me.aesRadioButton.Size = New System.Drawing.Size(48, 19)
            Me.aesRadioButton.TabIndex = 71
            Me.aesRadioButton.Text = "AES"
            Me.aesRadioButton.UseVisualStyleBackColor = True
            '
            'rc4RadioButton
            '
            Me.rc4RadioButton.AutoSize = True
            Me.rc4RadioButton.Checked = True
            Me.rc4RadioButton.Location = New System.Drawing.Point(129, 7)
            Me.rc4RadioButton.Name = "rc4RadioButton"
            Me.rc4RadioButton.Size = New System.Drawing.Size(49, 19)
            Me.rc4RadioButton.TabIndex = 70
            Me.rc4RadioButton.TabStop = True
            Me.rc4RadioButton.Text = "RC4"
            Me.rc4RadioButton.UseVisualStyleBackColor = True
            '
            'copyAccessibilityContentEnabledCheckBox
            '
            Me.copyAccessibilityContentEnabledCheckBox.AutoSize = True
            Me.copyAccessibilityContentEnabledCheckBox.Checked = True
            Me.copyAccessibilityContentEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.copyAccessibilityContentEnabledCheckBox.Location = New System.Drawing.Point(201, 161)
            Me.copyAccessibilityContentEnabledCheckBox.Name = "copyAccessibilityContentEnabledCheckBox"
            Me.copyAccessibilityContentEnabledCheckBox.Size = New System.Drawing.Size(215, 19)
            Me.copyAccessibilityContentEnabledCheckBox.TabIndex = 90
            Me.copyAccessibilityContentEnabledCheckBox.Text = "Copy Accessibility Content Enabled"
            Me.copyAccessibilityContentEnabledCheckBox.UseVisualStyleBackColor = True
            '
            'highResolutionPrintEnabledCheckBox
            '
            Me.highResolutionPrintEnabledCheckBox.AutoSize = True
            Me.highResolutionPrintEnabledCheckBox.Checked = True
            Me.highResolutionPrintEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.highResolutionPrintEnabledCheckBox.Location = New System.Drawing.Point(201, 74)
            Me.highResolutionPrintEnabledCheckBox.Name = "highResolutionPrintEnabledCheckBox"
            Me.highResolutionPrintEnabledCheckBox.Size = New System.Drawing.Size(191, 19)
            Me.highResolutionPrintEnabledCheckBox.TabIndex = 91
            Me.highResolutionPrintEnabledCheckBox.Text = "High Resolution Print Enabled"
            Me.highResolutionPrintEnabledCheckBox.UseVisualStyleBackColor = True
            '
            'fillFormFieldsEnabledCheckBox
            '
            Me.fillFormFieldsEnabledCheckBox.AutoSize = True
            Me.fillFormFieldsEnabledCheckBox.Checked = True
            Me.fillFormFieldsEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.fillFormFieldsEnabledCheckBox.Location = New System.Drawing.Point(395, 116)
            Me.fillFormFieldsEnabledCheckBox.Name = "fillFormFieldsEnabledCheckBox"
            Me.fillFormFieldsEnabledCheckBox.Size = New System.Drawing.Size(159, 19)
            Me.fillFormFieldsEnabledCheckBox.TabIndex = 85
            Me.fillFormFieldsEnabledCheckBox.Text = "Fill Form Fields Enabled"
            Me.fillFormFieldsEnabledCheckBox.UseVisualStyleBackColor = True
            '
            'editAnnotationsEnabledCheckBox
            '
            Me.editAnnotationsEnabledCheckBox.AutoSize = True
            Me.editAnnotationsEnabledCheckBox.Checked = True
            Me.editAnnotationsEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.editAnnotationsEnabledCheckBox.Location = New System.Drawing.Point(201, 116)
            Me.editAnnotationsEnabledCheckBox.Name = "editAnnotationsEnabledCheckBox"
            Me.editAnnotationsEnabledCheckBox.Size = New System.Drawing.Size(163, 19)
            Me.editAnnotationsEnabledCheckBox.TabIndex = 86
            Me.editAnnotationsEnabledCheckBox.Text = "Edit Annotations Enabled"
            Me.editAnnotationsEnabledCheckBox.UseVisualStyleBackColor = True
            '
            'editContentEnabledCheckBox
            '
            Me.editContentEnabledCheckBox.AutoSize = True
            Me.editContentEnabledCheckBox.Checked = True
            Me.editContentEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.editContentEnabledCheckBox.Location = New System.Drawing.Point(29, 116)
            Me.editContentEnabledCheckBox.Name = "editContentEnabledCheckBox"
            Me.editContentEnabledCheckBox.Size = New System.Drawing.Size(141, 19)
            Me.editContentEnabledCheckBox.TabIndex = 87
            Me.editContentEnabledCheckBox.Text = "Edit Content Enabled"
            Me.editContentEnabledCheckBox.UseVisualStyleBackColor = True
            '
            'copyContentEnabledCheckBox
            '
            Me.copyContentEnabledCheckBox.AutoSize = True
            Me.copyContentEnabledCheckBox.Checked = True
            Me.copyContentEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.copyContentEnabledCheckBox.Location = New System.Drawing.Point(30, 161)
            Me.copyContentEnabledCheckBox.Name = "copyContentEnabledCheckBox"
            Me.copyContentEnabledCheckBox.Size = New System.Drawing.Size(147, 19)
            Me.copyContentEnabledCheckBox.TabIndex = 88
            Me.copyContentEnabledCheckBox.Text = "Copy Content Enabled"
            Me.copyContentEnabledCheckBox.UseVisualStyleBackColor = True
            '
            'printEnabledCheckBox
            '
            Me.printEnabledCheckBox.AutoSize = True
            Me.printEnabledCheckBox.Checked = True
            Me.printEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.printEnabledCheckBox.Location = New System.Drawing.Point(29, 74)
            Me.printEnabledCheckBox.Name = "printEnabledCheckBox"
            Me.printEnabledCheckBox.Size = New System.Drawing.Size(100, 19)
            Me.printEnabledCheckBox.TabIndex = 89
            Me.printEnabledCheckBox.Text = "Print Enabled"
            Me.printEnabledCheckBox.UseVisualStyleBackColor = True
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(313, 36)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(103, 15)
            Me.label1.TabIndex = 81
            Me.label1.Text = "Owner Password:"
            '
            'ownerPasswordTextBox
            '
            Me.ownerPasswordTextBox.Location = New System.Drawing.Point(432, 33)
            Me.ownerPasswordTextBox.Name = "ownerPasswordTextBox"
            Me.ownerPasswordTextBox.Size = New System.Drawing.Size(150, 21)
            Me.ownerPasswordTextBox.TabIndex = 83
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(26, 36)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(93, 15)
            Me.label2.TabIndex = 82
            Me.label2.Text = "User Password:"
            '
            'userPasswordTextBox
            '
            Me.userPasswordTextBox.Location = New System.Drawing.Point(135, 33)
            Me.userPasswordTextBox.Name = "userPasswordTextBox"
            Me.userPasswordTextBox.Size = New System.Drawing.Size(150, 21)
            Me.userPasswordTextBox.TabIndex = 84
            '
            'PDF_Permissions_and_Password_Demo
            '
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
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.Name = "PDF_Permissions_and_Password_Demo"
            Me.Size = New System.Drawing.Size(610, 650)
            Me.convertButtonPanel.ResumeLayout(False)
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            Me.urlPanel.ResumeLayout(False)
            Me.urlPanel.PerformLayout()
            Me.descriptionPanel.ResumeLayout(False)
            Me.titlePanel.ResumeLayout(False)
            Me.titlePanel.PerformLayout()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.encryptionTypePanel.ResumeLayout(False)
            Me.encryptionTypePanel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private demoLeftPanel As Panel
		Private demoRightPanel As Panel
		Private demoBottomPanel As Panel
		Private demoTopPanel As Panel
		Private convertButtonPanel As Panel
		Private WithEvents convertToPdfButton As Button
		Private settingsPanel As Panel
		Private label4 As Label
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
        Private titleLabel As Label
        Private WithEvents panel1 As System.Windows.Forms.Panel
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents bit256RadioButton As System.Windows.Forms.RadioButton
        Private WithEvents bit128RadioButton As System.Windows.Forms.RadioButton
        Private WithEvents bit40RadioButton As System.Windows.Forms.RadioButton
        Private WithEvents encryptionTypePanel As System.Windows.Forms.Panel
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents aesRadioButton As System.Windows.Forms.RadioButton
        Private WithEvents rc4RadioButton As System.Windows.Forms.RadioButton
        Private WithEvents copyAccessibilityContentEnabledCheckBox As System.Windows.Forms.CheckBox
        Private WithEvents highResolutionPrintEnabledCheckBox As System.Windows.Forms.CheckBox
        Private WithEvents fillFormFieldsEnabledCheckBox As System.Windows.Forms.CheckBox
        Private WithEvents editAnnotationsEnabledCheckBox As System.Windows.Forms.CheckBox
        Private WithEvents editContentEnabledCheckBox As System.Windows.Forms.CheckBox
        Private WithEvents copyContentEnabledCheckBox As System.Windows.Forms.CheckBox
        Private WithEvents printEnabledCheckBox As System.Windows.Forms.CheckBox
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents ownerPasswordTextBox As System.Windows.Forms.TextBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents userPasswordTextBox As System.Windows.Forms.TextBox
    End Class
End Namespace

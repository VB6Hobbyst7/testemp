Namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST
	Partial Public Class GET_and_POST_HTTP_Methods_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(GET_and_POST_HTTP_Methods_Demo))
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.convertButtonPanel = New Panel()
			Me.convertToPdfButton = New Button()
			Me.settingsPanel = New Panel()
			Me.label12 = New Label()
			Me.label10 = New Label()
			Me.label8 = New Label()
			Me.label6 = New Label()
			Me.label4 = New Label()
			Me.param5ValueTextBox = New TextBox()
			Me.param4ValueTextBox = New TextBox()
			Me.param3ValueTextBox = New TextBox()
			Me.param2ValueTextBox = New TextBox()
			Me.param1ValueTextBox = New TextBox()
			Me.label11 = New Label()
			Me.label9 = New Label()
			Me.label7 = New Label()
			Me.param5NameTextBox = New TextBox()
			Me.param4NameTextBox = New TextBox()
			Me.param3NameTextBox = New TextBox()
			Me.label5 = New Label()
			Me.param2NameTextBox = New TextBox()
			Me.label3 = New Label()
			Me.param1NameTextBox = New TextBox()
			Me.postMethodRadioButton = New RadioButton()
			Me.getMethodRadioButton = New RadioButton()
			Me.label1 = New Label()
			Me.label2 = New Label()
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
			Me.demoLeftPanel.TabIndex = 151
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 150
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 644)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 149
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 148
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 481)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 43)
			Me.convertButtonPanel.TabIndex = 173
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
			Me.settingsPanel.Controls.Add(Me.label12)
			Me.settingsPanel.Controls.Add(Me.label10)
			Me.settingsPanel.Controls.Add(Me.label8)
			Me.settingsPanel.Controls.Add(Me.label6)
			Me.settingsPanel.Controls.Add(Me.label4)
			Me.settingsPanel.Controls.Add(Me.param5ValueTextBox)
			Me.settingsPanel.Controls.Add(Me.param4ValueTextBox)
			Me.settingsPanel.Controls.Add(Me.param3ValueTextBox)
			Me.settingsPanel.Controls.Add(Me.param2ValueTextBox)
			Me.settingsPanel.Controls.Add(Me.param1ValueTextBox)
			Me.settingsPanel.Controls.Add(Me.label11)
			Me.settingsPanel.Controls.Add(Me.label9)
			Me.settingsPanel.Controls.Add(Me.label7)
			Me.settingsPanel.Controls.Add(Me.param5NameTextBox)
			Me.settingsPanel.Controls.Add(Me.param4NameTextBox)
			Me.settingsPanel.Controls.Add(Me.param3NameTextBox)
			Me.settingsPanel.Controls.Add(Me.label5)
			Me.settingsPanel.Controls.Add(Me.param2NameTextBox)
			Me.settingsPanel.Controls.Add(Me.label3)
			Me.settingsPanel.Controls.Add(Me.param1NameTextBox)
			Me.settingsPanel.Controls.Add(Me.postMethodRadioButton)
			Me.settingsPanel.Controls.Add(Me.getMethodRadioButton)
			Me.settingsPanel.Controls.Add(Me.label1)
			Me.settingsPanel.Controls.Add(Me.label2)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 199)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 282)
			Me.settingsPanel.TabIndex = 172
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Location = New Point(269, 240)
			Me.label12.Name = "label12"
			Me.label12.Size = New Size(41, 15)
			Me.label12.TabIndex = 56
			Me.label12.Text = "Value:"
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New Point(269, 204)
			Me.label10.Name = "label10"
			Me.label10.Size = New Size(41, 15)
			Me.label10.TabIndex = 56
			Me.label10.Text = "Value:"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New Point(269, 168)
			Me.label8.Name = "label8"
			Me.label8.Size = New Size(41, 15)
			Me.label8.TabIndex = 56
			Me.label8.Text = "Value:"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New Point(269, 133)
			Me.label6.Name = "label6"
			Me.label6.Size = New Size(41, 15)
			Me.label6.TabIndex = 56
			Me.label6.Text = "Value:"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New Point(269, 99)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(41, 15)
			Me.label4.TabIndex = 56
			Me.label4.Text = "Value:"
			' 
			' param5ValueTextBox
			' 
			Me.param5ValueTextBox.Location = New Point(319, 237)
			Me.param5ValueTextBox.Name = "param5ValueTextBox"
			Me.param5ValueTextBox.Size = New Size(142, 21)
			Me.param5ValueTextBox.TabIndex = 55
			Me.param5ValueTextBox.Text = "Value 5"
			' 
			' param4ValueTextBox
			' 
			Me.param4ValueTextBox.Location = New Point(319, 201)
			Me.param4ValueTextBox.Name = "param4ValueTextBox"
			Me.param4ValueTextBox.Size = New Size(142, 21)
			Me.param4ValueTextBox.TabIndex = 55
			Me.param4ValueTextBox.Text = "Value 4"
			' 
			' param3ValueTextBox
			' 
			Me.param3ValueTextBox.Location = New Point(319, 165)
			Me.param3ValueTextBox.Name = "param3ValueTextBox"
			Me.param3ValueTextBox.Size = New Size(142, 21)
			Me.param3ValueTextBox.TabIndex = 55
			Me.param3ValueTextBox.Text = "Value 3"
			' 
			' param2ValueTextBox
			' 
			Me.param2ValueTextBox.Location = New Point(319, 130)
			Me.param2ValueTextBox.Name = "param2ValueTextBox"
			Me.param2ValueTextBox.Size = New Size(142, 21)
			Me.param2ValueTextBox.TabIndex = 55
			Me.param2ValueTextBox.Text = "Value 2"
			' 
			' param1ValueTextBox
			' 
			Me.param1ValueTextBox.Location = New Point(319, 96)
			Me.param1ValueTextBox.Name = "param1ValueTextBox"
			Me.param1ValueTextBox.Size = New Size(142, 21)
			Me.param1ValueTextBox.TabIndex = 55
			Me.param1ValueTextBox.Text = "Value 1"
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Location = New Point(18, 240)
			Me.label11.Name = "label11"
			Me.label11.Size = New Size(44, 15)
			Me.label11.TabIndex = 56
			Me.label11.Text = "Name:"
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New Point(18, 204)
			Me.label9.Name = "label9"
			Me.label9.Size = New Size(44, 15)
			Me.label9.TabIndex = 56
			Me.label9.Text = "Name:"
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New Point(18, 168)
			Me.label7.Name = "label7"
			Me.label7.Size = New Size(44, 15)
			Me.label7.TabIndex = 56
			Me.label7.Text = "Name:"
			' 
			' param5NameTextBox
			' 
			Me.param5NameTextBox.Location = New Point(68, 237)
			Me.param5NameTextBox.Name = "param5NameTextBox"
			Me.param5NameTextBox.Size = New Size(142, 21)
			Me.param5NameTextBox.TabIndex = 55
			Me.param5NameTextBox.Text = "Param5"
			' 
			' param4NameTextBox
			' 
			Me.param4NameTextBox.Location = New Point(68, 201)
			Me.param4NameTextBox.Name = "param4NameTextBox"
			Me.param4NameTextBox.Size = New Size(142, 21)
			Me.param4NameTextBox.TabIndex = 55
			Me.param4NameTextBox.Text = "Param4"
			' 
			' param3NameTextBox
			' 
			Me.param3NameTextBox.Location = New Point(68, 165)
			Me.param3NameTextBox.Name = "param3NameTextBox"
			Me.param3NameTextBox.Size = New Size(142, 21)
			Me.param3NameTextBox.TabIndex = 55
			Me.param3NameTextBox.Text = "Param3"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New Point(18, 133)
			Me.label5.Name = "label5"
			Me.label5.Size = New Size(44, 15)
			Me.label5.TabIndex = 56
			Me.label5.Text = "Name:"
			' 
			' param2NameTextBox
			' 
			Me.param2NameTextBox.Location = New Point(68, 130)
			Me.param2NameTextBox.Name = "param2NameTextBox"
			Me.param2NameTextBox.Size = New Size(142, 21)
			Me.param2NameTextBox.TabIndex = 55
			Me.param2NameTextBox.Text = "Param2"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New Point(18, 99)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(44, 15)
			Me.label3.TabIndex = 56
			Me.label3.Text = "Name:"
			' 
			' param1NameTextBox
			' 
			Me.param1NameTextBox.Location = New Point(68, 96)
			Me.param1NameTextBox.Name = "param1NameTextBox"
			Me.param1NameTextBox.Size = New Size(142, 21)
			Me.param1NameTextBox.TabIndex = 55
			Me.param1NameTextBox.Text = "Param1"
			' 
			' postMethodRadioButton
			' 
			Me.postMethodRadioButton.AutoSize = True
			Me.postMethodRadioButton.Location = New Point(109, 32)
			Me.postMethodRadioButton.Name = "postMethodRadioButton"
			Me.postMethodRadioButton.Size = New Size(64, 20)
			Me.postMethodRadioButton.TabIndex = 54
			Me.postMethodRadioButton.Text = "POST"
			Me.postMethodRadioButton.UseVisualStyleBackColor = True
			' 
			' getMethodRadioButton
			' 
			Me.getMethodRadioButton.AutoSize = True
			Me.getMethodRadioButton.Checked = True
			Me.getMethodRadioButton.Location = New Point(21, 32)
			Me.getMethodRadioButton.Name = "getMethodRadioButton"
			Me.getMethodRadioButton.Size = New Size(56, 20)
			Me.getMethodRadioButton.TabIndex = 54
			Me.getMethodRadioButton.TabStop = True
			Me.getMethodRadioButton.Text = "GET"
			Me.getMethodRadioButton.UseVisualStyleBackColor = True
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label1.Location = New Point(3, 66)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(81, 15)
			Me.label1.TabIndex = 53
			Me.label1.Text = "Parameters"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label2.Location = New Point(3, 3)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(94, 15)
			Me.label2.TabIndex = 53
			Me.label2.Text = "HTTP Method"
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 129)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 70)
			Me.urlPanel.TabIndex = 171
			' 
			' enterUrlLabel
			' 
			Me.enterUrlLabel.AutoSize = True
			Me.enterUrlLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.enterUrlLabel.Location = New Point(3, 7)
			Me.enterUrlLabel.Name = "enterUrlLabel"
			Me.enterUrlLabel.Size = New Size(182, 15)
			Me.enterUrlLabel.TabIndex = 50
			Me.enterUrlLabel.Text = "HTML Page to Convert URL"
			' 
			' urlTextBox
			' 
			Me.urlTextBox.Location = New Point(6, 36)
			Me.urlTextBox.Name = "urlTextBox"
			Me.urlTextBox.Size = New Size(576, 21)
			Me.urlTextBox.TabIndex = 51
			Me.urlTextBox.Text = "http://www.evopdf.com/GET_and_POST/"
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 83)
			Me.descriptionPanel.TabIndex = 170
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 83)
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
			Me.titlePanel.TabIndex = 169
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(436, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Access a HTML Page Using GET and POST HTTP Methods"
			' 
			' GET_and_POST_HTTP_Methods_Demo
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
			Me.Name = "GET_and_POST_HTTP_Methods_Demo"
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
		Private WithEvents convertToPdfButton As Button
		Private settingsPanel As Panel
		Private postMethodRadioButton As RadioButton
		Private getMethodRadioButton As RadioButton
		Private label2 As Label
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
		Private label12 As Label
		Private label10 As Label
		Private label8 As Label
		Private label6 As Label
		Private label4 As Label
		Private param5ValueTextBox As TextBox
		Private param4ValueTextBox As TextBox
		Private param3ValueTextBox As TextBox
		Private param2ValueTextBox As TextBox
		Private param1ValueTextBox As TextBox
		Private label11 As Label
		Private label9 As Label
		Private label7 As Label
		Private param5NameTextBox As TextBox
		Private param4NameTextBox As TextBox
		Private param3NameTextBox As TextBox
		Private label5 As Label
		Private param2NameTextBox As TextBox
		Private label3 As Label
		Private param1NameTextBox As TextBox
		Private label1 As Label
	End Class
End Namespace

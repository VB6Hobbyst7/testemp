Namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies
	Partial Public Class Add_Cookies_to_Request_Demo
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
			Me.cookie5ValueTextBox = New TextBox()
			Me.cookie4ValueTextBox = New TextBox()
			Me.cookie3ValueTextBox = New TextBox()
			Me.cookie2ValueTextBox = New TextBox()
			Me.cookie1ValueTextBox = New TextBox()
			Me.label11 = New Label()
			Me.label9 = New Label()
			Me.label7 = New Label()
			Me.cookie5NameTextBox = New TextBox()
			Me.cookie4NameTextBox = New TextBox()
			Me.cookie3NameTextBox = New TextBox()
			Me.label5 = New Label()
			Me.cookie2NameTextBox = New TextBox()
			Me.label3 = New Label()
			Me.cookie1NameTextBox = New TextBox()
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
			Me.demoLeftPanel.TabIndex = 155
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 154
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 644)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 153
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 152
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 376)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 43)
			Me.convertButtonPanel.TabIndex = 183
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
			Me.settingsPanel.Controls.Add(Me.cookie5ValueTextBox)
			Me.settingsPanel.Controls.Add(Me.cookie4ValueTextBox)
			Me.settingsPanel.Controls.Add(Me.cookie3ValueTextBox)
			Me.settingsPanel.Controls.Add(Me.cookie2ValueTextBox)
			Me.settingsPanel.Controls.Add(Me.cookie1ValueTextBox)
			Me.settingsPanel.Controls.Add(Me.label11)
			Me.settingsPanel.Controls.Add(Me.label9)
			Me.settingsPanel.Controls.Add(Me.label7)
			Me.settingsPanel.Controls.Add(Me.cookie5NameTextBox)
			Me.settingsPanel.Controls.Add(Me.cookie4NameTextBox)
			Me.settingsPanel.Controls.Add(Me.cookie3NameTextBox)
			Me.settingsPanel.Controls.Add(Me.label5)
			Me.settingsPanel.Controls.Add(Me.cookie2NameTextBox)
			Me.settingsPanel.Controls.Add(Me.label3)
			Me.settingsPanel.Controls.Add(Me.cookie1NameTextBox)
			Me.settingsPanel.Controls.Add(Me.label2)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 155)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 221)
			Me.settingsPanel.TabIndex = 182
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Location = New Point(240, 183)
			Me.label12.Name = "label12"
			Me.label12.Size = New Size(41, 15)
			Me.label12.TabIndex = 56
			Me.label12.Text = "Value:"
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New Point(240, 147)
			Me.label10.Name = "label10"
			Me.label10.Size = New Size(41, 15)
			Me.label10.TabIndex = 56
			Me.label10.Text = "Value:"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New Point(240, 111)
			Me.label8.Name = "label8"
			Me.label8.Size = New Size(41, 15)
			Me.label8.TabIndex = 56
			Me.label8.Text = "Value:"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New Point(240, 75)
			Me.label6.Name = "label6"
			Me.label6.Size = New Size(41, 15)
			Me.label6.TabIndex = 56
			Me.label6.Text = "Value:"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New Point(240, 39)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(41, 15)
			Me.label4.TabIndex = 56
			Me.label4.Text = "Value:"
			' 
			' cookie5ValueTextBox
			' 
			Me.cookie5ValueTextBox.Location = New Point(290, 180)
			Me.cookie5ValueTextBox.Name = "cookie5ValueTextBox"
			Me.cookie5ValueTextBox.Size = New Size(292, 21)
			Me.cookie5ValueTextBox.TabIndex = 55
			Me.cookie5ValueTextBox.Text = "Value 5"
			' 
			' cookie4ValueTextBox
			' 
			Me.cookie4ValueTextBox.Location = New Point(290, 144)
			Me.cookie4ValueTextBox.Name = "cookie4ValueTextBox"
			Me.cookie4ValueTextBox.Size = New Size(292, 21)
			Me.cookie4ValueTextBox.TabIndex = 55
			Me.cookie4ValueTextBox.Text = "Value 4"
			' 
			' cookie3ValueTextBox
			' 
			Me.cookie3ValueTextBox.Location = New Point(290, 108)
			Me.cookie3ValueTextBox.Name = "cookie3ValueTextBox"
			Me.cookie3ValueTextBox.Size = New Size(292, 21)
			Me.cookie3ValueTextBox.TabIndex = 55
			Me.cookie3ValueTextBox.Text = "Value 3"
			' 
			' cookie2ValueTextBox
			' 
			Me.cookie2ValueTextBox.Location = New Point(290, 72)
			Me.cookie2ValueTextBox.Name = "cookie2ValueTextBox"
			Me.cookie2ValueTextBox.Size = New Size(292, 21)
			Me.cookie2ValueTextBox.TabIndex = 55
			Me.cookie2ValueTextBox.Text = "Value 2"
			' 
			' cookie1ValueTextBox
			' 
			Me.cookie1ValueTextBox.Location = New Point(290, 36)
			Me.cookie1ValueTextBox.Name = "cookie1ValueTextBox"
			Me.cookie1ValueTextBox.Size = New Size(292, 21)
			Me.cookie1ValueTextBox.TabIndex = 55
			Me.cookie1ValueTextBox.Text = "Value 1"
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Location = New Point(18, 183)
			Me.label11.Name = "label11"
			Me.label11.Size = New Size(44, 15)
			Me.label11.TabIndex = 56
			Me.label11.Text = "Name:"
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New Point(18, 147)
			Me.label9.Name = "label9"
			Me.label9.Size = New Size(44, 15)
			Me.label9.TabIndex = 56
			Me.label9.Text = "Name:"
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New Point(18, 111)
			Me.label7.Name = "label7"
			Me.label7.Size = New Size(44, 15)
			Me.label7.TabIndex = 56
			Me.label7.Text = "Name:"
			' 
			' cookie5NameTextBox
			' 
			Me.cookie5NameTextBox.Location = New Point(68, 180)
			Me.cookie5NameTextBox.Name = "cookie5NameTextBox"
			Me.cookie5NameTextBox.Size = New Size(142, 21)
			Me.cookie5NameTextBox.TabIndex = 55
			Me.cookie5NameTextBox.Text = "Cookie5"
			' 
			' cookie4NameTextBox
			' 
			Me.cookie4NameTextBox.Location = New Point(68, 144)
			Me.cookie4NameTextBox.Name = "cookie4NameTextBox"
			Me.cookie4NameTextBox.Size = New Size(142, 21)
			Me.cookie4NameTextBox.TabIndex = 55
			Me.cookie4NameTextBox.Text = "Cookie4"
			' 
			' cookie3NameTextBox
			' 
			Me.cookie3NameTextBox.Location = New Point(68, 108)
			Me.cookie3NameTextBox.Name = "cookie3NameTextBox"
			Me.cookie3NameTextBox.Size = New Size(142, 21)
			Me.cookie3NameTextBox.TabIndex = 55
			Me.cookie3NameTextBox.Text = "Cookie3"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New Point(18, 75)
			Me.label5.Name = "label5"
			Me.label5.Size = New Size(44, 15)
			Me.label5.TabIndex = 56
			Me.label5.Text = "Name:"
			' 
			' cookie2NameTextBox
			' 
			Me.cookie2NameTextBox.Location = New Point(68, 72)
			Me.cookie2NameTextBox.Name = "cookie2NameTextBox"
			Me.cookie2NameTextBox.Size = New Size(142, 21)
			Me.cookie2NameTextBox.TabIndex = 55
			Me.cookie2NameTextBox.Text = "Cookie2"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New Point(18, 39)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(44, 15)
			Me.label3.TabIndex = 56
			Me.label3.Text = "Name:"
			' 
			' cookie1NameTextBox
			' 
			Me.cookie1NameTextBox.Location = New Point(68, 36)
			Me.cookie1NameTextBox.Name = "cookie1NameTextBox"
			Me.cookie1NameTextBox.Size = New Size(142, 21)
			Me.cookie1NameTextBox.TabIndex = 55
			Me.cookie1NameTextBox.Text = "Cookie1"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label2.Location = New Point(3, 3)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(97, 15)
			Me.label2.TabIndex = 53
			Me.label2.Text = "HTTP Cookies"
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 85)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 70)
			Me.urlPanel.TabIndex = 181
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
			Me.urlTextBox.Text = "http://www.evopdf.com/HTTP_Cookies/"
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 39)
			Me.descriptionPanel.TabIndex = 180
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 39)
			Me.descriptionLabel.TabIndex = 0
			Me.descriptionLabel.Text = "EVO HTML to PDF Converter allows you to add HTTP cookies when you request the HTM" & "L page. The Full Description and a Code Sample can be accessed from the top tabs" & "." & vbCrLf
			' 
			' titlePanel
			' 
			Me.titlePanel.Controls.Add(Me.titleLabel)
			Me.titlePanel.Dock = DockStyle.Top
			Me.titlePanel.Location = New Point(6, 6)
			Me.titlePanel.Name = "titlePanel"
			Me.titlePanel.Size = New Size(598, 40)
			Me.titlePanel.TabIndex = 179
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(271, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Add Cookies to HTML Page Request"
			' 
			' Add_Cookies_to_Request_Demo
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
			Me.Name = "Add_Cookies_to_Request_Demo"
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
		Private label12 As Label
		Private label10 As Label
		Private label8 As Label
		Private label6 As Label
		Private label4 As Label
		Private cookie5ValueTextBox As TextBox
		Private cookie4ValueTextBox As TextBox
		Private cookie3ValueTextBox As TextBox
		Private cookie2ValueTextBox As TextBox
		Private cookie1ValueTextBox As TextBox
		Private label11 As Label
		Private label9 As Label
		Private label7 As Label
		Private cookie5NameTextBox As TextBox
		Private cookie4NameTextBox As TextBox
		Private cookie3NameTextBox As TextBox
		Private label5 As Label
		Private cookie2NameTextBox As TextBox
		Private label3 As Label
		Private cookie1NameTextBox As TextBox
		Private label2 As Label
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
	End Class
End Namespace

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies
	Partial Public Class Add_HTTP_Headers_to_Request_Demo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Add_HTTP_Headers_to_Request_Demo))
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
			Me.header5ValueTextBox = New TextBox()
			Me.header4ValueTextBox = New TextBox()
			Me.header3ValueTextBox = New TextBox()
			Me.header2ValueTextBox = New TextBox()
			Me.header1ValueTextBox = New TextBox()
			Me.label11 = New Label()
			Me.label9 = New Label()
			Me.label7 = New Label()
			Me.header5NameTextBox = New TextBox()
			Me.header4NameTextBox = New TextBox()
			Me.header3NameTextBox = New TextBox()
			Me.label5 = New Label()
			Me.header2NameTextBox = New TextBox()
			Me.label3 = New Label()
			Me.header1NameTextBox = New TextBox()
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
			Me.convertButtonPanel.Location = New Point(6, 420)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 43)
			Me.convertButtonPanel.TabIndex = 178
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
			Me.settingsPanel.Controls.Add(Me.header5ValueTextBox)
			Me.settingsPanel.Controls.Add(Me.header4ValueTextBox)
			Me.settingsPanel.Controls.Add(Me.header3ValueTextBox)
			Me.settingsPanel.Controls.Add(Me.header2ValueTextBox)
			Me.settingsPanel.Controls.Add(Me.header1ValueTextBox)
			Me.settingsPanel.Controls.Add(Me.label11)
			Me.settingsPanel.Controls.Add(Me.label9)
			Me.settingsPanel.Controls.Add(Me.label7)
			Me.settingsPanel.Controls.Add(Me.header5NameTextBox)
			Me.settingsPanel.Controls.Add(Me.header4NameTextBox)
			Me.settingsPanel.Controls.Add(Me.header3NameTextBox)
			Me.settingsPanel.Controls.Add(Me.label5)
			Me.settingsPanel.Controls.Add(Me.header2NameTextBox)
			Me.settingsPanel.Controls.Add(Me.label3)
			Me.settingsPanel.Controls.Add(Me.header1NameTextBox)
			Me.settingsPanel.Controls.Add(Me.label2)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 199)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 221)
			Me.settingsPanel.TabIndex = 177
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
			Me.label6.Location = New Point(240, 74)
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
			' header5ValueTextBox
			' 
			Me.header5ValueTextBox.Location = New Point(290, 180)
			Me.header5ValueTextBox.Name = "header5ValueTextBox"
			Me.header5ValueTextBox.Size = New Size(292, 21)
			Me.header5ValueTextBox.TabIndex = 55
			' 
			' header4ValueTextBox
			' 
			Me.header4ValueTextBox.Location = New Point(290, 144)
			Me.header4ValueTextBox.Name = "header4ValueTextBox"
			Me.header4ValueTextBox.Size = New Size(292, 21)
			Me.header4ValueTextBox.TabIndex = 55
			Me.header4ValueTextBox.Text = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Safari" & "/537.36"
			' 
			' header3ValueTextBox
			' 
			Me.header3ValueTextBox.Location = New Point(290, 108)
			Me.header3ValueTextBox.Name = "header3ValueTextBox"
			Me.header3ValueTextBox.Size = New Size(292, 21)
			Me.header3ValueTextBox.TabIndex = 55
			Me.header3ValueTextBox.Text = "Keep-Alive"
			' 
			' header2ValueTextBox
			' 
			Me.header2ValueTextBox.Location = New Point(290, 71)
			Me.header2ValueTextBox.Name = "header2ValueTextBox"
			Me.header2ValueTextBox.Size = New Size(292, 21)
			Me.header2ValueTextBox.TabIndex = 55
			Me.header2ValueTextBox.Text = "en-US,*"
			' 
			' header1ValueTextBox
			' 
			Me.header1ValueTextBox.Location = New Point(290, 36)
			Me.header1ValueTextBox.Name = "header1ValueTextBox"
			Me.header1ValueTextBox.Size = New Size(292, 21)
			Me.header1ValueTextBox.TabIndex = 55
			Me.header1ValueTextBox.Text = "text/html,application/xhtml+xml,application/xml"
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
			' header5NameTextBox
			' 
			Me.header5NameTextBox.Location = New Point(68, 180)
			Me.header5NameTextBox.Name = "header5NameTextBox"
			Me.header5NameTextBox.Size = New Size(142, 21)
			Me.header5NameTextBox.TabIndex = 55
			' 
			' header4NameTextBox
			' 
			Me.header4NameTextBox.Location = New Point(68, 144)
			Me.header4NameTextBox.Name = "header4NameTextBox"
			Me.header4NameTextBox.Size = New Size(142, 21)
			Me.header4NameTextBox.TabIndex = 55
			Me.header4NameTextBox.Text = "User-Agent"
			' 
			' header3NameTextBox
			' 
			Me.header3NameTextBox.Location = New Point(68, 108)
			Me.header3NameTextBox.Name = "header3NameTextBox"
			Me.header3NameTextBox.Size = New Size(142, 21)
			Me.header3NameTextBox.TabIndex = 55
			Me.header3NameTextBox.Text = "Connection"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New Point(18, 74)
			Me.label5.Name = "label5"
			Me.label5.Size = New Size(44, 15)
			Me.label5.TabIndex = 56
			Me.label5.Text = "Name:"
			' 
			' header2NameTextBox
			' 
			Me.header2NameTextBox.Location = New Point(68, 71)
			Me.header2NameTextBox.Name = "header2NameTextBox"
			Me.header2NameTextBox.Size = New Size(142, 21)
			Me.header2NameTextBox.TabIndex = 55
			Me.header2NameTextBox.Text = "Accept-Language"
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
			' header1NameTextBox
			' 
			Me.header1NameTextBox.Location = New Point(68, 36)
			Me.header1NameTextBox.Name = "header1NameTextBox"
			Me.header1NameTextBox.Size = New Size(142, 21)
			Me.header1NameTextBox.TabIndex = 55
			Me.header1NameTextBox.Text = "Accept"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label2.Location = New Point(3, 3)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(100, 15)
			Me.label2.TabIndex = 53
			Me.label2.Text = "HTTP Headers"
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 129)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 70)
			Me.urlPanel.TabIndex = 176
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
			Me.urlTextBox.Text = "http://www.evopdf.com/HTTP_Headers/"
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 83)
			Me.descriptionPanel.TabIndex = 175
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
			Me.titlePanel.TabIndex = 174
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(321, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Add HTTP Headers to HTML Page Request"
			' 
			' Add_HTTP_Headers_to_Request_Demo
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
			Me.Name = "Add_HTTP_Headers_to_Request_Demo"
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
		Private header5ValueTextBox As TextBox
		Private header4ValueTextBox As TextBox
		Private header3ValueTextBox As TextBox
		Private header2ValueTextBox As TextBox
		Private header1ValueTextBox As TextBox
		Private label11 As Label
		Private label9 As Label
		Private label7 As Label
		Private header5NameTextBox As TextBox
		Private header4NameTextBox As TextBox
		Private header3NameTextBox As TextBox
		Private label5 As Label
		Private header2NameTextBox As TextBox
		Private label3 As Label
		Private header1NameTextBox As TextBox
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

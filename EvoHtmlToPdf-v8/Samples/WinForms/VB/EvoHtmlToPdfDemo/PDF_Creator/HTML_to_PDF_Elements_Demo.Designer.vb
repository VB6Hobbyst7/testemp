Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class HTML_to_PDF_Elements_Demo
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
			Me.label31 = New Label()
			Me.label23 = New Label()
			Me.label24 = New Label()
			Me.label25 = New Label()
			Me.label30 = New Label()
			Me.label26 = New Label()
			Me.label27 = New Label()
			Me.label28 = New Label()
			Me.label29 = New Label()
			Me.yLocationTextBox = New TextBox()
			Me.xLocationTextBox = New TextBox()
			Me.contentHeightTextBox = New TextBox()
			Me.contentWidthTextBox = New TextBox()
			Me.clipContentCheckBox = New CheckBox()
			Me.label20 = New Label()
			Me.label1 = New Label()
			Me.label32 = New Label()
			Me.label2 = New Label()
			Me.label21 = New Label()
			Me.htmlViewerHeightTextBox = New TextBox()
			Me.label3 = New Label()
			Me.htmlViewerWidthTextBox = New TextBox()
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
			Me.demoLeftPanel.TabIndex = 147
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 638)
			Me.demoRightPanel.TabIndex = 146
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 644)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 145
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 144
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 308)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 43)
			Me.convertButtonPanel.TabIndex = 168
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
			Me.settingsPanel.Controls.Add(Me.label31)
			Me.settingsPanel.Controls.Add(Me.label23)
			Me.settingsPanel.Controls.Add(Me.label24)
			Me.settingsPanel.Controls.Add(Me.label25)
			Me.settingsPanel.Controls.Add(Me.label30)
			Me.settingsPanel.Controls.Add(Me.label26)
			Me.settingsPanel.Controls.Add(Me.label27)
			Me.settingsPanel.Controls.Add(Me.label28)
			Me.settingsPanel.Controls.Add(Me.label29)
			Me.settingsPanel.Controls.Add(Me.yLocationTextBox)
			Me.settingsPanel.Controls.Add(Me.xLocationTextBox)
			Me.settingsPanel.Controls.Add(Me.contentHeightTextBox)
			Me.settingsPanel.Controls.Add(Me.contentWidthTextBox)
			Me.settingsPanel.Controls.Add(Me.clipContentCheckBox)
			Me.settingsPanel.Controls.Add(Me.label20)
			Me.settingsPanel.Controls.Add(Me.label1)
			Me.settingsPanel.Controls.Add(Me.label32)
			Me.settingsPanel.Controls.Add(Me.label2)
			Me.settingsPanel.Controls.Add(Me.label21)
			Me.settingsPanel.Controls.Add(Me.htmlViewerHeightTextBox)
			Me.settingsPanel.Controls.Add(Me.label3)
			Me.settingsPanel.Controls.Add(Me.htmlViewerWidthTextBox)
			Me.settingsPanel.Dock = DockStyle.Top
			Me.settingsPanel.Location = New Point(6, 171)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New Size(598, 137)
			Me.settingsPanel.TabIndex = 167
			' 
			' label31
			' 
			Me.label31.AutoSize = True
			Me.label31.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label31.Location = New Point(542, 106)
			Me.label31.Name = "label31"
			Me.label31.Size = New Size(17, 15)
			Me.label31.TabIndex = 138
			Me.label31.Text = "pt"
			' 
			' label23
			' 
			Me.label23.AutoSize = True
			Me.label23.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label23.Location = New Point(408, 106)
			Me.label23.Name = "label23"
			Me.label23.Size = New Size(17, 15)
			Me.label23.TabIndex = 137
			Me.label23.Text = "pt"
			' 
			' label24
			' 
			Me.label24.AutoSize = True
			Me.label24.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label24.Location = New Point(279, 106)
			Me.label24.Name = "label24"
			Me.label24.Size = New Size(17, 15)
			Me.label24.TabIndex = 140
			Me.label24.Text = "pt"
			' 
			' label25
			' 
			Me.label25.AutoSize = True
			Me.label25.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label25.Location = New Point(174, 106)
			Me.label25.Name = "label25"
			Me.label25.Size = New Size(17, 15)
			Me.label25.TabIndex = 139
			Me.label25.Text = "pt"
			' 
			' label30
			' 
			Me.label30.AutoSize = True
			Me.label30.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label30.Location = New Point(440, 106)
			Me.label30.Name = "label30"
			Me.label30.Size = New Size(46, 15)
			Me.label30.TabIndex = 135
			Me.label30.Text = "Height:"
			' 
			' label26
			' 
			Me.label26.AutoSize = True
			Me.label26.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label26.Location = New Point(313, 106)
			Me.label26.Name = "label26"
			Me.label26.Size = New Size(41, 15)
			Me.label26.TabIndex = 136
			Me.label26.Text = "Width:"
			' 
			' label27
			' 
			Me.label27.AutoSize = True
			Me.label27.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label27.Location = New Point(208, 106)
			Me.label27.Name = "label27"
			Me.label27.Size = New Size(17, 15)
			Me.label27.TabIndex = 134
			Me.label27.Text = "Y:"
			' 
			' label28
			' 
			Me.label28.AutoSize = True
			Me.label28.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label28.Location = New Point(102, 106)
			Me.label28.Name = "label28"
			Me.label28.Size = New Size(18, 15)
			Me.label28.TabIndex = 133
			Me.label28.Text = "X:"
			' 
			' label29
			' 
			Me.label29.AutoSize = True
			Me.label29.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.label29.Location = New Point(24, 106)
			Me.label29.Name = "label29"
			Me.label29.Size = New Size(72, 15)
			Me.label29.TabIndex = 128
			Me.label29.Text = "Destination:"
			' 
			' yLocationTextBox
			' 
			Me.yLocationTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.yLocationTextBox.Location = New Point(230, 103)
			Me.yLocationTextBox.Name = "yLocationTextBox"
			Me.yLocationTextBox.Size = New Size(45, 21)
			Me.yLocationTextBox.TabIndex = 129
			Me.yLocationTextBox.Text = "50"
			' 
			' xLocationTextBox
			' 
			Me.xLocationTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.xLocationTextBox.Location = New Point(125, 103)
			Me.xLocationTextBox.Name = "xLocationTextBox"
			Me.xLocationTextBox.Size = New Size(45, 21)
			Me.xLocationTextBox.TabIndex = 130
			Me.xLocationTextBox.Text = "50"
			' 
			' contentHeightTextBox
			' 
			Me.contentHeightTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.contentHeightTextBox.Location = New Point(491, 103)
			Me.contentHeightTextBox.Name = "contentHeightTextBox"
			Me.contentHeightTextBox.Size = New Size(45, 21)
			Me.contentHeightTextBox.TabIndex = 131
			' 
			' contentWidthTextBox
			' 
			Me.contentWidthTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.contentWidthTextBox.Location = New Point(358, 103)
			Me.contentWidthTextBox.Name = "contentWidthTextBox"
			Me.contentWidthTextBox.Size = New Size(45, 21)
			Me.contentWidthTextBox.TabIndex = 132
			Me.contentWidthTextBox.Text = "500"
			' 
			' clipContentCheckBox
			' 
			Me.clipContentCheckBox.AutoSize = True
			Me.clipContentCheckBox.Location = New Point(306, 32)
			Me.clipContentCheckBox.Name = "clipContentCheckBox"
			Me.clipContentCheckBox.Size = New Size(260, 21)
			Me.clipContentCheckBox.TabIndex = 127
			Me.clipContentCheckBox.Text = "Clip HTML Content to HTML Viewer Width"
			Me.clipContentCheckBox.UseVisualStyleBackColor = True
			' 
			' label20
			' 
			Me.label20.AutoSize = True
			Me.label20.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label20.Location = New Point(3, 72)
			Me.label20.Name = "label20"
			Me.label20.Size = New Size(151, 15)
			Me.label20.TabIndex = 120
			Me.label20.Text = "HTML Content Options"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label1.Location = New Point(3, 3)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(145, 15)
			Me.label1.TabIndex = 119
			Me.label1.Text = "HTML Viewer Options"
			' 
			' label32
			' 
			Me.label32.AutoSize = True
			Me.label32.Location = New Point(155, 34)
			Me.label32.Name = "label32"
			Me.label32.Size = New Size(46, 15)
			Me.label32.TabIndex = 123
			Me.label32.Text = "Height:"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New Point(24, 33)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(41, 15)
			Me.label2.TabIndex = 124
			Me.label2.Text = "Width:"
			' 
			' label21
			' 
			Me.label21.AutoSize = True
			Me.label21.Location = New Point(262, 34)
			Me.label21.Name = "label21"
			Me.label21.Size = New Size(20, 15)
			Me.label21.TabIndex = 121
			Me.label21.Text = "px"
			' 
			' htmlViewerHeightTextBox
			' 
			Me.htmlViewerHeightTextBox.Location = New Point(211, 31)
			Me.htmlViewerHeightTextBox.Name = "htmlViewerHeightTextBox"
			Me.htmlViewerHeightTextBox.Size = New Size(47, 21)
			Me.htmlViewerHeightTextBox.TabIndex = 125
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New Point(122, 33)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(20, 15)
			Me.label3.TabIndex = 122
			Me.label3.Text = "px"
			' 
			' htmlViewerWidthTextBox
			' 
			Me.htmlViewerWidthTextBox.Location = New Point(70, 30)
			Me.htmlViewerWidthTextBox.Name = "htmlViewerWidthTextBox"
			Me.htmlViewerWidthTextBox.Size = New Size(47, 21)
			Me.htmlViewerWidthTextBox.TabIndex = 126
			Me.htmlViewerWidthTextBox.Text = "1024"
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 95)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 76)
			Me.urlPanel.TabIndex = 166
			' 
			' enterUrlLabel
			' 
			Me.enterUrlLabel.AutoSize = True
			Me.enterUrlLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.enterUrlLabel.Location = New Point(3, 7)
			Me.enterUrlLabel.Name = "enterUrlLabel"
			Me.enterUrlLabel.Size = New Size(266, 15)
			Me.enterUrlLabel.TabIndex = 50
			Me.enterUrlLabel.Text = "HTML Page URL or Local File to Convert"
			' 
			' urlTextBox
			' 
			Me.urlTextBox.Location = New Point(6, 36)
			Me.urlTextBox.Name = "urlTextBox"
			Me.urlTextBox.Size = New Size(576, 21)
			Me.urlTextBox.TabIndex = 51
            Me.urlTextBox.Text = "http://www.evopdf.com"
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 49)
			Me.descriptionPanel.TabIndex = 165
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 49)
			Me.descriptionLabel.TabIndex = 0
			Me.descriptionLabel.Text = "EVO HTML to PDF Converter allows you to convert a HTML page to PDF by adding a HT" & "ML to PDF Element to that PDF document. The Full Description and a Code Sample c" & "an be accessed from the top tabs." & vbCrLf
			' 
			' titlePanel
			' 
			Me.titlePanel.Controls.Add(Me.titleLabel)
			Me.titlePanel.Dock = DockStyle.Top
			Me.titlePanel.Location = New Point(6, 6)
			Me.titlePanel.Name = "titlePanel"
			Me.titlePanel.Size = New Size(598, 40)
			Me.titlePanel.TabIndex = 164
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(353, 17)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Add HTML to PDF Elements to a PDF Document"
			' 
			' HTML_to_PDF_Elements_Demo
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
			Me.Name = "HTML_to_PDF_Elements_Demo"
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
		Private label31 As Label
		Private label23 As Label
		Private label24 As Label
		Private label25 As Label
		Private label30 As Label
		Private label26 As Label
		Private label27 As Label
		Private label28 As Label
		Private label29 As Label
		Private yLocationTextBox As TextBox
		Private xLocationTextBox As TextBox
		Private contentHeightTextBox As TextBox
		Private contentWidthTextBox As TextBox
		Private clipContentCheckBox As CheckBox
		Private label20 As Label
		Private label1 As Label
		Private label32 As Label
		Private label2 As Label
		Private label21 As Label
		Private htmlViewerHeightTextBox As TextBox
		Private label3 As Label
		Private htmlViewerWidthTextBox As TextBox
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
	End Class
End Namespace

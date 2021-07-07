Namespace EvoHtmlToPdfDemo.HTML_to_Image
	Partial Public Class HTML_to_Image_Demo
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
            Me.demoRightPanel = New System.Windows.Forms.Panel()
            Me.demoLeftPanel = New System.Windows.Forms.Panel()
            Me.demoBottomPanel = New System.Windows.Forms.Panel()
            Me.demoTopPanel = New System.Windows.Forms.Panel()
            Me.convertButtonPanel = New System.Windows.Forms.Panel()
            Me.convertToImageButton = New System.Windows.Forms.Button()
            Me.settingsPanel = New System.Windows.Forms.Panel()
            Me.label4 = New System.Windows.Forms.Label()
            Me.transparentBackgroundCheckBox = New System.Windows.Forms.CheckBox()
            Me.imageFormatComboBox = New System.Windows.Forms.ComboBox()
            Me.label11 = New System.Windows.Forms.Label()
            Me.label10 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label9 = New System.Windows.Forms.Label()
            Me.label21 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label8 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label20 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.conversionDelayTextBox = New System.Windows.Forms.TextBox()
            Me.htmlViewerHeightTextBox = New System.Windows.Forms.TextBox()
            Me.navigationTimeoutTextBox = New System.Windows.Forms.TextBox()
            Me.htmlViewerWidthTextBox = New System.Windows.Forms.TextBox()
            Me.htmlStringPanel = New System.Windows.Forms.Panel()
            Me.label14 = New System.Windows.Forms.Label()
            Me.baseUrlTextBox = New System.Windows.Forms.TextBox()
            Me.htmlStringTextBox = New System.Windows.Forms.TextBox()
            Me.label12 = New System.Windows.Forms.Label()
            Me.urlPanel = New System.Windows.Forms.Panel()
            Me.enterUrlLabel = New System.Windows.Forms.Label()
            Me.urlTextBox = New System.Windows.Forms.TextBox()
            Me.selectHtmlToConvertPanel = New System.Windows.Forms.Panel()
            Me.convertHtmlRadioButton = New System.Windows.Forms.RadioButton()
            Me.convertUrlRadioButton = New System.Windows.Forms.RadioButton()
            Me.descriptionPanel = New System.Windows.Forms.Panel()
            Me.descriptionLabel = New System.Windows.Forms.Label()
            Me.titlePanel = New System.Windows.Forms.Panel()
            Me.titleLabel = New System.Windows.Forms.Label()
            Me.convertButtonPanel.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            Me.htmlStringPanel.SuspendLayout()
            Me.urlPanel.SuspendLayout()
            Me.selectHtmlToConvertPanel.SuspendLayout()
            Me.descriptionPanel.SuspendLayout()
            Me.titlePanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'demoRightPanel
            '
            Me.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.demoRightPanel.Location = New System.Drawing.Point(604, 6)
            Me.demoRightPanel.Name = "demoRightPanel"
            Me.demoRightPanel.Size = New System.Drawing.Size(6, 670)
            Me.demoRightPanel.TabIndex = 82
            '
            'demoLeftPanel
            '
            Me.demoLeftPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.demoLeftPanel.Location = New System.Drawing.Point(0, 6)
            Me.demoLeftPanel.Name = "demoLeftPanel"
            Me.demoLeftPanel.Size = New System.Drawing.Size(6, 670)
            Me.demoLeftPanel.TabIndex = 81
            '
            'demoBottomPanel
            '
            Me.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.demoBottomPanel.Location = New System.Drawing.Point(0, 676)
            Me.demoBottomPanel.Name = "demoBottomPanel"
            Me.demoBottomPanel.Size = New System.Drawing.Size(610, 6)
            Me.demoBottomPanel.TabIndex = 80
            '
            'demoTopPanel
            '
            Me.demoTopPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.demoTopPanel.Location = New System.Drawing.Point(0, 0)
            Me.demoTopPanel.Name = "demoTopPanel"
            Me.demoTopPanel.Size = New System.Drawing.Size(610, 6)
            Me.demoTopPanel.TabIndex = 79
            '
            'convertButtonPanel
            '
            Me.convertButtonPanel.Controls.Add(Me.convertToImageButton)
            Me.convertButtonPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.convertButtonPanel.Location = New System.Drawing.Point(6, 624)
            Me.convertButtonPanel.Name = "convertButtonPanel"
            Me.convertButtonPanel.Size = New System.Drawing.Size(598, 39)
            Me.convertButtonPanel.TabIndex = 101
            '
            'convertToImageButton
            '
            Me.convertToImageButton.Location = New System.Drawing.Point(6, 6)
            Me.convertToImageButton.Name = "convertToImageButton"
            Me.convertToImageButton.Size = New System.Drawing.Size(164, 27)
            Me.convertToImageButton.TabIndex = 66
            Me.convertToImageButton.Text = "Convert HTML to Image"
            Me.convertToImageButton.UseVisualStyleBackColor = True
            '
            'settingsPanel
            '
            Me.settingsPanel.Controls.Add(Me.label4)
            Me.settingsPanel.Controls.Add(Me.transparentBackgroundCheckBox)
            Me.settingsPanel.Controls.Add(Me.imageFormatComboBox)
            Me.settingsPanel.Controls.Add(Me.label11)
            Me.settingsPanel.Controls.Add(Me.label10)
            Me.settingsPanel.Controls.Add(Me.label1)
            Me.settingsPanel.Controls.Add(Me.label9)
            Me.settingsPanel.Controls.Add(Me.label21)
            Me.settingsPanel.Controls.Add(Me.label7)
            Me.settingsPanel.Controls.Add(Me.label2)
            Me.settingsPanel.Controls.Add(Me.label8)
            Me.settingsPanel.Controls.Add(Me.label6)
            Me.settingsPanel.Controls.Add(Me.label20)
            Me.settingsPanel.Controls.Add(Me.label3)
            Me.settingsPanel.Controls.Add(Me.conversionDelayTextBox)
            Me.settingsPanel.Controls.Add(Me.htmlViewerHeightTextBox)
            Me.settingsPanel.Controls.Add(Me.navigationTimeoutTextBox)
            Me.settingsPanel.Controls.Add(Me.htmlViewerWidthTextBox)
            Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.settingsPanel.Location = New System.Drawing.Point(6, 401)
            Me.settingsPanel.Name = "settingsPanel"
            Me.settingsPanel.Size = New System.Drawing.Size(598, 223)
            Me.settingsPanel.TabIndex = 100
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(30, 119)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(90, 15)
            Me.label4.TabIndex = 53
            Me.label4.Text = "Image Format: "
            '
            'transparentBackgroundCheckBox
            '
            Me.transparentBackgroundCheckBox.AutoSize = True
            Me.transparentBackgroundCheckBox.Location = New System.Drawing.Point(260, 118)
            Me.transparentBackgroundCheckBox.Name = "transparentBackgroundCheckBox"
            Me.transparentBackgroundCheckBox.Size = New System.Drawing.Size(161, 19)
            Me.transparentBackgroundCheckBox.TabIndex = 54
            Me.transparentBackgroundCheckBox.Text = "Transparent Background"
            Me.transparentBackgroundCheckBox.UseVisualStyleBackColor = True
            '
            'imageFormatComboBox
            '
            Me.imageFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.imageFormatComboBox.FormattingEnabled = True
            Me.imageFormatComboBox.Items.AddRange(New Object() {"Png", "Jpg", "Bmp"})
            Me.imageFormatComboBox.Location = New System.Drawing.Point(126, 116)
            Me.imageFormatComboBox.Name = "imageFormatComboBox"
            Me.imageFormatComboBox.Size = New System.Drawing.Size(100, 23)
            Me.imageFormatComboBox.TabIndex = 55
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.label11.Location = New System.Drawing.Point(3, 158)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(128, 15)
            Me.label11.TabIndex = 39
            Me.label11.Text = "Navigation Options"
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.label10.Location = New System.Drawing.Point(3, 83)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(100, 15)
            Me.label10.TabIndex = 39
            Me.label10.Text = "Image Options"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.label1.Location = New System.Drawing.Point(3, 13)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(145, 15)
            Me.label1.TabIndex = 39
            Me.label1.Text = "HTML Viewer Options"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(204, 189)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(108, 15)
            Me.label9.TabIndex = 44
            Me.label9.Text = "Delay Conversion :"
            '
            'label21
            '
            Me.label21.AutoSize = True
            Me.label21.Location = New System.Drawing.Point(30, 189)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(55, 15)
            Me.label21.TabIndex = 44
            Me.label21.Text = "Timeout:"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(204, 49)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(46, 15)
            Me.label7.TabIndex = 44
            Me.label7.Text = "Height:"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(30, 49)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(41, 15)
            Me.label2.TabIndex = 44
            Me.label2.Text = "Width:"
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(365, 189)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(26, 15)
            Me.label8.TabIndex = 43
            Me.label8.Text = "sec"
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(334, 49)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(20, 15)
            Me.label6.TabIndex = 43
            Me.label6.Text = "px"
            '
            'label20
            '
            Me.label20.AutoSize = True
            Me.label20.Location = New System.Drawing.Point(130, 187)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(26, 15)
            Me.label20.TabIndex = 43
            Me.label20.Text = "sec"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(157, 49)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(20, 15)
            Me.label3.TabIndex = 43
            Me.label3.Text = "px"
            '
            'conversionDelayTextBox
            '
            Me.conversionDelayTextBox.Location = New System.Drawing.Point(331, 186)
            Me.conversionDelayTextBox.Name = "conversionDelayTextBox"
            Me.conversionDelayTextBox.Size = New System.Drawing.Size(30, 21)
            Me.conversionDelayTextBox.TabIndex = 46
            Me.conversionDelayTextBox.Text = "2"
            '
            'htmlViewerHeightTextBox
            '
            Me.htmlViewerHeightTextBox.Location = New System.Drawing.Point(260, 46)
            Me.htmlViewerHeightTextBox.Name = "htmlViewerHeightTextBox"
            Me.htmlViewerHeightTextBox.Size = New System.Drawing.Size(70, 21)
            Me.htmlViewerHeightTextBox.TabIndex = 46
            '
            'navigationTimeoutTextBox
            '
            Me.navigationTimeoutTextBox.Location = New System.Drawing.Point(96, 184)
            Me.navigationTimeoutTextBox.Name = "navigationTimeoutTextBox"
            Me.navigationTimeoutTextBox.Size = New System.Drawing.Size(30, 21)
            Me.navigationTimeoutTextBox.TabIndex = 46
            Me.navigationTimeoutTextBox.Text = "60"
            '
            'htmlViewerWidthTextBox
            '
            Me.htmlViewerWidthTextBox.Location = New System.Drawing.Point(81, 46)
            Me.htmlViewerWidthTextBox.Name = "htmlViewerWidthTextBox"
            Me.htmlViewerWidthTextBox.Size = New System.Drawing.Size(70, 21)
            Me.htmlViewerWidthTextBox.TabIndex = 46
            Me.htmlViewerWidthTextBox.Text = "1024"
            '
            'htmlStringPanel
            '
            Me.htmlStringPanel.Controls.Add(Me.label14)
            Me.htmlStringPanel.Controls.Add(Me.baseUrlTextBox)
            Me.htmlStringPanel.Controls.Add(Me.htmlStringTextBox)
            Me.htmlStringPanel.Controls.Add(Me.label12)
            Me.htmlStringPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.htmlStringPanel.Location = New System.Drawing.Point(6, 178)
            Me.htmlStringPanel.Name = "htmlStringPanel"
            Me.htmlStringPanel.Size = New System.Drawing.Size(598, 223)
            Me.htmlStringPanel.TabIndex = 99
            Me.htmlStringPanel.Visible = False
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.label14.Location = New System.Drawing.Point(0, 172)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(71, 15)
            Me.label14.TabIndex = 42
            Me.label14.Text = "Base URL"
            '
            'baseUrlTextBox
            '
            Me.baseUrlTextBox.Location = New System.Drawing.Point(3, 190)
            Me.baseUrlTextBox.Name = "baseUrlTextBox"
            Me.baseUrlTextBox.Size = New System.Drawing.Size(575, 21)
            Me.baseUrlTextBox.TabIndex = 43
            '
            'htmlStringTextBox
            '
            Me.htmlStringTextBox.Location = New System.Drawing.Point(3, 26)
            Me.htmlStringTextBox.MaxLength = 1000000
            Me.htmlStringTextBox.Multiline = True
            Me.htmlStringTextBox.Name = "htmlStringTextBox"
            Me.htmlStringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.htmlStringTextBox.Size = New System.Drawing.Size(573, 134)
            Me.htmlStringTextBox.TabIndex = 41
            Me.htmlStringTextBox.Text = "Enter the <b>HTML String to Convert</b> and optionally set a <b>Base URL</b> if t" & _
        "he HTML string references external resources by relative URLs"
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.label12.Location = New System.Drawing.Point(3, 8)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(155, 15)
            Me.label12.TabIndex = 40
            Me.label12.Text = "HTML String to Convert"
            '
            'urlPanel
            '
            Me.urlPanel.Controls.Add(Me.enterUrlLabel)
            Me.urlPanel.Controls.Add(Me.urlTextBox)
            Me.urlPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.urlPanel.Location = New System.Drawing.Point(6, 116)
            Me.urlPanel.Name = "urlPanel"
            Me.urlPanel.Size = New System.Drawing.Size(598, 62)
            Me.urlPanel.TabIndex = 98
            '
            'enterUrlLabel
            '
            Me.enterUrlLabel.AutoSize = True
            Me.enterUrlLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.enterUrlLabel.Location = New System.Drawing.Point(0, 13)
            Me.enterUrlLabel.Name = "enterUrlLabel"
            Me.enterUrlLabel.Size = New System.Drawing.Size(266, 15)
            Me.enterUrlLabel.TabIndex = 40
            Me.enterUrlLabel.Text = "HTML Page URL or Local File to Convert"
            '
            'urlTextBox
            '
            Me.urlTextBox.Location = New System.Drawing.Point(3, 35)
            Me.urlTextBox.Name = "urlTextBox"
            Me.urlTextBox.Size = New System.Drawing.Size(574, 21)
            Me.urlTextBox.TabIndex = 41
            Me.urlTextBox.Text = "http://www.evopdf.com"
            '
            'selectHtmlToConvertPanel
            '
            Me.selectHtmlToConvertPanel.Controls.Add(Me.convertHtmlRadioButton)
            Me.selectHtmlToConvertPanel.Controls.Add(Me.convertUrlRadioButton)
            Me.selectHtmlToConvertPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.selectHtmlToConvertPanel.Location = New System.Drawing.Point(6, 83)
            Me.selectHtmlToConvertPanel.Name = "selectHtmlToConvertPanel"
            Me.selectHtmlToConvertPanel.Size = New System.Drawing.Size(598, 33)
            Me.selectHtmlToConvertPanel.TabIndex = 97
            '
            'convertHtmlRadioButton
            '
            Me.convertHtmlRadioButton.AutoSize = True
            Me.convertHtmlRadioButton.Location = New System.Drawing.Point(207, 6)
            Me.convertHtmlRadioButton.Name = "convertHtmlRadioButton"
            Me.convertHtmlRadioButton.Size = New System.Drawing.Size(138, 19)
            Me.convertHtmlRadioButton.TabIndex = 69
            Me.convertHtmlRadioButton.Text = "Convert HTML String"
            Me.convertHtmlRadioButton.UseVisualStyleBackColor = True
            '
            'convertUrlRadioButton
            '
            Me.convertUrlRadioButton.AutoSize = True
            Me.convertUrlRadioButton.Checked = True
            Me.convertUrlRadioButton.Location = New System.Drawing.Point(3, 6)
            Me.convertUrlRadioButton.Name = "convertUrlRadioButton"
            Me.convertUrlRadioButton.Size = New System.Drawing.Size(164, 19)
            Me.convertUrlRadioButton.TabIndex = 68
            Me.convertUrlRadioButton.TabStop = True
            Me.convertUrlRadioButton.Text = "Convert URL or Local File"
            Me.convertUrlRadioButton.UseVisualStyleBackColor = True
            '
            'descriptionPanel
            '
            Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
            Me.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.descriptionPanel.Location = New System.Drawing.Point(6, 41)
            Me.descriptionPanel.Name = "descriptionPanel"
            Me.descriptionPanel.Size = New System.Drawing.Size(598, 42)
            Me.descriptionPanel.TabIndex = 96
            '
            'descriptionLabel
            '
            Me.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.descriptionLabel.Location = New System.Drawing.Point(0, 0)
            Me.descriptionLabel.Name = "descriptionLabel"
            Me.descriptionLabel.Size = New System.Drawing.Size(598, 42)
            Me.descriptionLabel.TabIndex = 0
            Me.descriptionLabel.Text = "Convert a HTML page from an URL or a HTML String to a raster image using the basi" & _
        "c options of converter. The Full Description and a Code Sample can be accessed f" & _
        "rom the top tabs."
            '
            'titlePanel
            '
            Me.titlePanel.Controls.Add(Me.titleLabel)
            Me.titlePanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.titlePanel.Location = New System.Drawing.Point(6, 6)
            Me.titlePanel.Name = "titlePanel"
            Me.titlePanel.Size = New System.Drawing.Size(598, 35)
            Me.titlePanel.TabIndex = 95
            '
            'titleLabel
            '
            Me.titleLabel.AutoSize = True
            Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.titleLabel.Location = New System.Drawing.Point(0, 3)
            Me.titleLabel.Name = "titleLabel"
            Me.titleLabel.Size = New System.Drawing.Size(231, 17)
            Me.titleLabel.TabIndex = 1
            Me.titleLabel.Text = "Convert HTML to Raster Image"
            '
            'HTML_to_Image_Demo
            '
            Me.AutoScroll = True
            Me.Controls.Add(Me.convertButtonPanel)
            Me.Controls.Add(Me.settingsPanel)
            Me.Controls.Add(Me.htmlStringPanel)
            Me.Controls.Add(Me.urlPanel)
            Me.Controls.Add(Me.selectHtmlToConvertPanel)
            Me.Controls.Add(Me.descriptionPanel)
            Me.Controls.Add(Me.titlePanel)
            Me.Controls.Add(Me.demoRightPanel)
            Me.Controls.Add(Me.demoLeftPanel)
            Me.Controls.Add(Me.demoBottomPanel)
            Me.Controls.Add(Me.demoTopPanel)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.Name = "HTML_to_Image_Demo"
            Me.Size = New System.Drawing.Size(610, 682)
            Me.convertButtonPanel.ResumeLayout(False)
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            Me.htmlStringPanel.ResumeLayout(False)
            Me.htmlStringPanel.PerformLayout()
            Me.urlPanel.ResumeLayout(False)
            Me.urlPanel.PerformLayout()
            Me.selectHtmlToConvertPanel.ResumeLayout(False)
            Me.selectHtmlToConvertPanel.PerformLayout()
            Me.descriptionPanel.ResumeLayout(False)
            Me.titlePanel.ResumeLayout(False)
            Me.titlePanel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private demoRightPanel As Panel
		Private demoLeftPanel As Panel
		Private demoBottomPanel As Panel
		Private demoTopPanel As Panel
		Private convertButtonPanel As Panel
		Private WithEvents convertToImageButton As Button
		Private settingsPanel As Panel
		Private label11 As Label
		Private label10 As Label
		Private label1 As Label
		Private label9 As Label
		Private label21 As Label
		Private label7 As Label
		Private label2 As Label
		Private label8 As Label
		Private label6 As Label
		Private label20 As Label
		Private label3 As Label
		Private conversionDelayTextBox As TextBox
		Private htmlViewerHeightTextBox As TextBox
		Private navigationTimeoutTextBox As TextBox
		Private htmlViewerWidthTextBox As TextBox
		Private htmlStringPanel As Panel
		Private label14 As Label
		Private baseUrlTextBox As TextBox
		Private htmlStringTextBox As TextBox
		Private label12 As Label
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox
		Private selectHtmlToConvertPanel As Panel
		Private WithEvents convertHtmlRadioButton As RadioButton
		Private WithEvents convertUrlRadioButton As RadioButton
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
		Private label4 As Label
		Private transparentBackgroundCheckBox As CheckBox
		Private WithEvents imageFormatComboBox As ComboBox
	End Class
End Namespace

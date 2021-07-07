Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class HTML_Content_Scaling_Demo
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
            Me.demoTopPanel = New System.Windows.Forms.Panel()
            Me.demoBottomPanel = New System.Windows.Forms.Panel()
            Me.demoRightPanel = New System.Windows.Forms.Panel()
            Me.demoLeftPanel = New System.Windows.Forms.Panel()
            Me.titlePanel = New System.Windows.Forms.Panel()
            Me.titleLabel = New System.Windows.Forms.Label()
            Me.descriptionPanel = New System.Windows.Forms.Panel()
            Me.descriptionLabel = New System.Windows.Forms.Label()
            Me.convertButtonPanel = New System.Windows.Forms.Panel()
            Me.convertToPdfButton = New System.Windows.Forms.Button()
            Me.settingsPanel = New System.Windows.Forms.Panel()
            Me.label10 = New System.Windows.Forms.Label()
            Me.label11 = New System.Windows.Forms.Label()
            Me.label13 = New System.Windows.Forms.Label()
            Me.label15 = New System.Windows.Forms.Label()
            Me.label16 = New System.Windows.Forms.Label()
            Me.label17 = New System.Windows.Forms.Label()
            Me.label18 = New System.Windows.Forms.Label()
            Me.label19 = New System.Windows.Forms.Label()
            Me.label22 = New System.Windows.Forms.Label()
            Me.rightMarginTextBox = New System.Windows.Forms.TextBox()
            Me.leftMarginTextBox = New System.Windows.Forms.TextBox()
            Me.topMarginTextBox = New System.Windows.Forms.TextBox()
            Me.bottomMarginTextBox = New System.Windows.Forms.TextBox()
            Me.label31 = New System.Windows.Forms.Label()
            Me.label23 = New System.Windows.Forms.Label()
            Me.label14 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.label12 = New System.Windows.Forms.Label()
            Me.label25 = New System.Windows.Forms.Label()
            Me.label30 = New System.Windows.Forms.Label()
            Me.label26 = New System.Windows.Forms.Label()
            Me.label8 = New System.Windows.Forms.Label()
            Me.label27 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.label28 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.bottomSpacingTextBox = New System.Windows.Forms.TextBox()
            Me.label29 = New System.Windows.Forms.Label()
            Me.topSpacingTextBox = New System.Windows.Forms.TextBox()
            Me.yLocationTextBox = New System.Windows.Forms.TextBox()
            Me.xLocationTextBox = New System.Windows.Forms.TextBox()
            Me.contentHeightTextBox = New System.Windows.Forms.TextBox()
            Me.contentWidthTextBox = New System.Windows.Forms.TextBox()
            Me.stretchCheckBox = New System.Windows.Forms.CheckBox()
            Me.singlePageCheckBox = New System.Windows.Forms.CheckBox()
            Me.fitHeightCheckBox = New System.Windows.Forms.CheckBox()
            Me.autoSizeCheckBox = New System.Windows.Forms.CheckBox()
            Me.fitWidthCheckBox = New System.Windows.Forms.CheckBox()
            Me.label33 = New System.Windows.Forms.Label()
            Me.label20 = New System.Windows.Forms.Label()
            Me.label9 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.pdfPageSizeComboBox = New System.Windows.Forms.ComboBox()
            Me.pdfPageOrientationComboBox = New System.Windows.Forms.ComboBox()
            Me.urlPanel = New System.Windows.Forms.Panel()
            Me.enterUrlLabel = New System.Windows.Forms.Label()
            Me.urlTextBox = New System.Windows.Forms.TextBox()
            Me.label35 = New System.Windows.Forms.Label()
            Me.label34 = New System.Windows.Forms.Label()
            Me.htmlViewerZoomTextBox = New System.Windows.Forms.TextBox()
            Me.clipContentCheckBox = New System.Windows.Forms.CheckBox()
            Me.label32 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label21 = New System.Windows.Forms.Label()
            Me.htmlViewerHeightTextBox = New System.Windows.Forms.TextBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.htmlViewerWidthTextBox = New System.Windows.Forms.TextBox()
            Me.titlePanel.SuspendLayout()
            Me.descriptionPanel.SuspendLayout()
            Me.convertButtonPanel.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            Me.urlPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'demoTopPanel
            '
            Me.demoTopPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.demoTopPanel.Location = New System.Drawing.Point(0, 0)
            Me.demoTopPanel.Name = "demoTopPanel"
            Me.demoTopPanel.Size = New System.Drawing.Size(610, 6)
            Me.demoTopPanel.TabIndex = 1
            '
            'demoBottomPanel
            '
            Me.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.demoBottomPanel.Location = New System.Drawing.Point(0, 644)
            Me.demoBottomPanel.Name = "demoBottomPanel"
            Me.demoBottomPanel.Size = New System.Drawing.Size(610, 6)
            Me.demoBottomPanel.TabIndex = 2
            '
            'demoRightPanel
            '
            Me.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.demoRightPanel.Location = New System.Drawing.Point(604, 6)
            Me.demoRightPanel.Name = "demoRightPanel"
            Me.demoRightPanel.Size = New System.Drawing.Size(6, 638)
            Me.demoRightPanel.TabIndex = 4
            '
            'demoLeftPanel
            '
            Me.demoLeftPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.demoLeftPanel.Location = New System.Drawing.Point(0, 6)
            Me.demoLeftPanel.Name = "demoLeftPanel"
            Me.demoLeftPanel.Size = New System.Drawing.Size(6, 638)
            Me.demoLeftPanel.TabIndex = 5
            '
            'titlePanel
            '
            Me.titlePanel.Controls.Add(Me.titleLabel)
            Me.titlePanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.titlePanel.Location = New System.Drawing.Point(6, 6)
            Me.titlePanel.Name = "titlePanel"
            Me.titlePanel.Size = New System.Drawing.Size(598, 40)
            Me.titlePanel.TabIndex = 6
            '
            'titleLabel
            '
            Me.titleLabel.AutoSize = True
            Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.titleLabel.Location = New System.Drawing.Point(0, 10)
            Me.titleLabel.Name = "titleLabel"
            Me.titleLabel.Size = New System.Drawing.Size(260, 17)
            Me.titleLabel.TabIndex = 1
            Me.titleLabel.Text = "Control HTML Scaling in PDF Page"
            '
            'descriptionPanel
            '
            Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
            Me.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.descriptionPanel.Location = New System.Drawing.Point(6, 46)
            Me.descriptionPanel.Name = "descriptionPanel"
            Me.descriptionPanel.Size = New System.Drawing.Size(598, 40)
            Me.descriptionPanel.TabIndex = 8
            '
            'descriptionLabel
            '
            Me.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.descriptionLabel.Location = New System.Drawing.Point(0, 0)
            Me.descriptionLabel.Name = "descriptionLabel"
            Me.descriptionLabel.Size = New System.Drawing.Size(598, 40)
            Me.descriptionLabel.TabIndex = 0
            Me.descriptionLabel.Text = "Experiment various options of the EVO HTML to PDF Converter to scale and fit the " & _
        "HTML content in PDF Page. The Full Description and a Code Sample can be accessed" & _
        " from the top tabs."
            '
            'convertButtonPanel
            '
            Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
            Me.convertButtonPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.convertButtonPanel.Location = New System.Drawing.Point(6, 575)
            Me.convertButtonPanel.Name = "convertButtonPanel"
            Me.convertButtonPanel.Size = New System.Drawing.Size(598, 43)
            Me.convertButtonPanel.TabIndex = 77
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
            Me.settingsPanel.Controls.Add(Me.label35)
            Me.settingsPanel.Controls.Add(Me.label34)
            Me.settingsPanel.Controls.Add(Me.htmlViewerZoomTextBox)
            Me.settingsPanel.Controls.Add(Me.clipContentCheckBox)
            Me.settingsPanel.Controls.Add(Me.label32)
            Me.settingsPanel.Controls.Add(Me.label2)
            Me.settingsPanel.Controls.Add(Me.label21)
            Me.settingsPanel.Controls.Add(Me.htmlViewerHeightTextBox)
            Me.settingsPanel.Controls.Add(Me.label3)
            Me.settingsPanel.Controls.Add(Me.htmlViewerWidthTextBox)
            Me.settingsPanel.Controls.Add(Me.label10)
            Me.settingsPanel.Controls.Add(Me.label11)
            Me.settingsPanel.Controls.Add(Me.label13)
            Me.settingsPanel.Controls.Add(Me.label15)
            Me.settingsPanel.Controls.Add(Me.label16)
            Me.settingsPanel.Controls.Add(Me.label17)
            Me.settingsPanel.Controls.Add(Me.label18)
            Me.settingsPanel.Controls.Add(Me.label19)
            Me.settingsPanel.Controls.Add(Me.label22)
            Me.settingsPanel.Controls.Add(Me.rightMarginTextBox)
            Me.settingsPanel.Controls.Add(Me.leftMarginTextBox)
            Me.settingsPanel.Controls.Add(Me.topMarginTextBox)
            Me.settingsPanel.Controls.Add(Me.bottomMarginTextBox)
            Me.settingsPanel.Controls.Add(Me.label31)
            Me.settingsPanel.Controls.Add(Me.label23)
            Me.settingsPanel.Controls.Add(Me.label14)
            Me.settingsPanel.Controls.Add(Me.label24)
            Me.settingsPanel.Controls.Add(Me.label12)
            Me.settingsPanel.Controls.Add(Me.label25)
            Me.settingsPanel.Controls.Add(Me.label30)
            Me.settingsPanel.Controls.Add(Me.label26)
            Me.settingsPanel.Controls.Add(Me.label8)
            Me.settingsPanel.Controls.Add(Me.label27)
            Me.settingsPanel.Controls.Add(Me.label7)
            Me.settingsPanel.Controls.Add(Me.label28)
            Me.settingsPanel.Controls.Add(Me.label6)
            Me.settingsPanel.Controls.Add(Me.bottomSpacingTextBox)
            Me.settingsPanel.Controls.Add(Me.label29)
            Me.settingsPanel.Controls.Add(Me.topSpacingTextBox)
            Me.settingsPanel.Controls.Add(Me.yLocationTextBox)
            Me.settingsPanel.Controls.Add(Me.xLocationTextBox)
            Me.settingsPanel.Controls.Add(Me.contentHeightTextBox)
            Me.settingsPanel.Controls.Add(Me.contentWidthTextBox)
            Me.settingsPanel.Controls.Add(Me.stretchCheckBox)
            Me.settingsPanel.Controls.Add(Me.singlePageCheckBox)
            Me.settingsPanel.Controls.Add(Me.fitHeightCheckBox)
            Me.settingsPanel.Controls.Add(Me.autoSizeCheckBox)
            Me.settingsPanel.Controls.Add(Me.fitWidthCheckBox)
            Me.settingsPanel.Controls.Add(Me.label33)
            Me.settingsPanel.Controls.Add(Me.label20)
            Me.settingsPanel.Controls.Add(Me.label9)
            Me.settingsPanel.Controls.Add(Me.label1)
            Me.settingsPanel.Controls.Add(Me.label4)
            Me.settingsPanel.Controls.Add(Me.label5)
            Me.settingsPanel.Controls.Add(Me.pdfPageSizeComboBox)
            Me.settingsPanel.Controls.Add(Me.pdfPageOrientationComboBox)
            Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.settingsPanel.Location = New System.Drawing.Point(6, 152)
            Me.settingsPanel.Name = "settingsPanel"
            Me.settingsPanel.Size = New System.Drawing.Size(598, 423)
            Me.settingsPanel.TabIndex = 76
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label10.Location = New System.Drawing.Point(535, 154)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(17, 15)
            Me.label10.TabIndex = 129
            Me.label10.Text = "pt"
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label11.Location = New System.Drawing.Point(400, 154)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(17, 15)
            Me.label11.TabIndex = 128
            Me.label11.Text = "pt"
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label13.Location = New System.Drawing.Point(286, 154)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(17, 15)
            Me.label13.TabIndex = 131
            Me.label13.Text = "pt"
            '
            'label15
            '
            Me.label15.AutoSize = True
            Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label15.Location = New System.Drawing.Point(164, 154)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(17, 15)
            Me.label15.TabIndex = 130
            Me.label15.Text = "pt"
            '
            'label16
            '
            Me.label16.AutoSize = True
            Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label16.Location = New System.Drawing.Point(206, 154)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(39, 15)
            Me.label16.TabIndex = 124
            Me.label16.Text = "Right:"
            '
            'label17
            '
            Me.label17.AutoSize = True
            Me.label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label17.Location = New System.Drawing.Point(326, 154)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(31, 15)
            Me.label17.TabIndex = 127
            Me.label17.Text = "Top:"
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label18.Location = New System.Drawing.Point(444, 154)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(49, 15)
            Me.label18.TabIndex = 126
            Me.label18.Text = "Bottom:"
            '
            'label19
            '
            Me.label19.AutoSize = True
            Me.label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label19.Location = New System.Drawing.Point(94, 154)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(30, 15)
            Me.label19.TabIndex = 125
            Me.label19.Text = "Left:"
            '
            'label22
            '
            Me.label22.AutoSize = True
            Me.label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label22.Location = New System.Drawing.Point(28, 154)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(55, 15)
            Me.label22.TabIndex = 119
            Me.label22.Text = "Margins:"
            '
            'rightMarginTextBox
            '
            Me.rightMarginTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.rightMarginTextBox.Location = New System.Drawing.Point(252, 151)
            Me.rightMarginTextBox.Name = "rightMarginTextBox"
            Me.rightMarginTextBox.Size = New System.Drawing.Size(30, 21)
            Me.rightMarginTextBox.TabIndex = 123
            Me.rightMarginTextBox.Text = "0"
            '
            'leftMarginTextBox
            '
            Me.leftMarginTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.leftMarginTextBox.Location = New System.Drawing.Point(130, 151)
            Me.leftMarginTextBox.Name = "leftMarginTextBox"
            Me.leftMarginTextBox.Size = New System.Drawing.Size(30, 21)
            Me.leftMarginTextBox.TabIndex = 121
            Me.leftMarginTextBox.Text = "0"
            '
            'topMarginTextBox
            '
            Me.topMarginTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.topMarginTextBox.Location = New System.Drawing.Point(366, 151)
            Me.topMarginTextBox.Name = "topMarginTextBox"
            Me.topMarginTextBox.Size = New System.Drawing.Size(30, 21)
            Me.topMarginTextBox.TabIndex = 122
            Me.topMarginTextBox.Text = "0"
            '
            'bottomMarginTextBox
            '
            Me.bottomMarginTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.bottomMarginTextBox.Location = New System.Drawing.Point(501, 151)
            Me.bottomMarginTextBox.Name = "bottomMarginTextBox"
            Me.bottomMarginTextBox.Size = New System.Drawing.Size(30, 21)
            Me.bottomMarginTextBox.TabIndex = 120
            Me.bottomMarginTextBox.Text = "0"
            '
            'label31
            '
            Me.label31.AutoSize = True
            Me.label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label31.Location = New System.Drawing.Point(546, 232)
            Me.label31.Name = "label31"
            Me.label31.Size = New System.Drawing.Size(17, 15)
            Me.label31.TabIndex = 116
            Me.label31.Text = "pt"
            '
            'label23
            '
            Me.label23.AutoSize = True
            Me.label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label23.Location = New System.Drawing.Point(412, 232)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(17, 15)
            Me.label23.TabIndex = 115
            Me.label23.Text = "pt"
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label14.Location = New System.Drawing.Point(344, 272)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(17, 15)
            Me.label14.TabIndex = 118
            Me.label14.Text = "pt"
            '
            'label24
            '
            Me.label24.AutoSize = True
            Me.label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label24.Location = New System.Drawing.Point(283, 232)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(17, 15)
            Me.label24.TabIndex = 118
            Me.label24.Text = "pt"
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label12.Location = New System.Drawing.Point(191, 272)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(17, 15)
            Me.label12.TabIndex = 117
            Me.label12.Text = "pt"
            '
            'label25
            '
            Me.label25.AutoSize = True
            Me.label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label25.Location = New System.Drawing.Point(178, 232)
            Me.label25.Name = "label25"
            Me.label25.Size = New System.Drawing.Size(17, 15)
            Me.label25.TabIndex = 117
            Me.label25.Text = "pt"
            '
            'label30
            '
            Me.label30.AutoSize = True
            Me.label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label30.Location = New System.Drawing.Point(444, 232)
            Me.label30.Name = "label30"
            Me.label30.Size = New System.Drawing.Size(46, 15)
            Me.label30.TabIndex = 113
            Me.label30.Text = "Height:"
            '
            'label26
            '
            Me.label26.AutoSize = True
            Me.label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label26.Location = New System.Drawing.Point(317, 232)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(41, 15)
            Me.label26.TabIndex = 114
            Me.label26.Text = "Width:"
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label8.Location = New System.Drawing.Point(242, 272)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(49, 15)
            Me.label8.TabIndex = 112
            Me.label8.Text = "Bottom:"
            '
            'label27
            '
            Me.label27.AutoSize = True
            Me.label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label27.Location = New System.Drawing.Point(212, 232)
            Me.label27.Name = "label27"
            Me.label27.Size = New System.Drawing.Size(17, 15)
            Me.label27.TabIndex = 112
            Me.label27.Text = "Y:"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label7.Location = New System.Drawing.Point(106, 272)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(31, 15)
            Me.label7.TabIndex = 111
            Me.label7.Text = "Top:"
            '
            'label28
            '
            Me.label28.AutoSize = True
            Me.label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label28.Location = New System.Drawing.Point(106, 232)
            Me.label28.Name = "label28"
            Me.label28.Size = New System.Drawing.Size(18, 15)
            Me.label28.TabIndex = 111
            Me.label28.Text = "X:"
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label6.Location = New System.Drawing.Point(28, 272)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(55, 15)
            Me.label6.TabIndex = 106
            Me.label6.Text = "Spacing:"
            '
            'bottomSpacingTextBox
            '
            Me.bottomSpacingTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.bottomSpacingTextBox.Location = New System.Drawing.Point(295, 269)
            Me.bottomSpacingTextBox.Name = "bottomSpacingTextBox"
            Me.bottomSpacingTextBox.Size = New System.Drawing.Size(45, 21)
            Me.bottomSpacingTextBox.TabIndex = 107
            Me.bottomSpacingTextBox.Text = "0"
            '
            'label29
            '
            Me.label29.AutoSize = True
            Me.label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label29.Location = New System.Drawing.Point(28, 232)
            Me.label29.Name = "label29"
            Me.label29.Size = New System.Drawing.Size(72, 15)
            Me.label29.TabIndex = 106
            Me.label29.Text = "Destination:"
            '
            'topSpacingTextBox
            '
            Me.topSpacingTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.topSpacingTextBox.Location = New System.Drawing.Point(142, 269)
            Me.topSpacingTextBox.Name = "topSpacingTextBox"
            Me.topSpacingTextBox.Size = New System.Drawing.Size(45, 21)
            Me.topSpacingTextBox.TabIndex = 108
            Me.topSpacingTextBox.Text = "0"
            '
            'yLocationTextBox
            '
            Me.yLocationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.yLocationTextBox.Location = New System.Drawing.Point(234, 229)
            Me.yLocationTextBox.Name = "yLocationTextBox"
            Me.yLocationTextBox.Size = New System.Drawing.Size(45, 21)
            Me.yLocationTextBox.TabIndex = 107
            Me.yLocationTextBox.Text = "0"
            '
            'xLocationTextBox
            '
            Me.xLocationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.xLocationTextBox.Location = New System.Drawing.Point(129, 229)
            Me.xLocationTextBox.Name = "xLocationTextBox"
            Me.xLocationTextBox.Size = New System.Drawing.Size(45, 21)
            Me.xLocationTextBox.TabIndex = 108
            Me.xLocationTextBox.Text = "0"
            '
            'contentHeightTextBox
            '
            Me.contentHeightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.contentHeightTextBox.Location = New System.Drawing.Point(495, 229)
            Me.contentHeightTextBox.Name = "contentHeightTextBox"
            Me.contentHeightTextBox.Size = New System.Drawing.Size(45, 21)
            Me.contentHeightTextBox.TabIndex = 109
            '
            'contentWidthTextBox
            '
            Me.contentWidthTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.contentWidthTextBox.Location = New System.Drawing.Point(362, 229)
            Me.contentWidthTextBox.Name = "contentWidthTextBox"
            Me.contentWidthTextBox.Size = New System.Drawing.Size(45, 21)
            Me.contentWidthTextBox.TabIndex = 110
            '
            'stretchCheckBox
            '
            Me.stretchCheckBox.AutoSize = True
            Me.stretchCheckBox.Location = New System.Drawing.Point(232, 342)
            Me.stretchCheckBox.Name = "stretchCheckBox"
            Me.stretchCheckBox.Size = New System.Drawing.Size(127, 19)
            Me.stretchCheckBox.TabIndex = 56
            Me.stretchCheckBox.Text = "Stretch to Fit Width"
            Me.stretchCheckBox.UseVisualStyleBackColor = True
            '
            'singlePageCheckBox
            '
            Me.singlePageCheckBox.AutoSize = True
            Me.singlePageCheckBox.Location = New System.Drawing.Point(36, 381)
            Me.singlePageCheckBox.Name = "singlePageCheckBox"
            Me.singlePageCheckBox.Size = New System.Drawing.Size(169, 19)
            Me.singlePageCheckBox.TabIndex = 55
            Me.singlePageCheckBox.Text = "Create a Single PDF Page"
            Me.singlePageCheckBox.UseVisualStyleBackColor = True
            '
            'fitHeightCheckBox
            '
            Me.fitHeightCheckBox.AutoSize = True
            Me.fitHeightCheckBox.Location = New System.Drawing.Point(126, 342)
            Me.fitHeightCheckBox.Name = "fitHeightCheckBox"
            Me.fitHeightCheckBox.Size = New System.Drawing.Size(78, 19)
            Me.fitHeightCheckBox.TabIndex = 55
            Me.fitHeightCheckBox.Text = "Fit Height"
            Me.fitHeightCheckBox.UseVisualStyleBackColor = True
            '
            'autoSizeCheckBox
            '
            Me.autoSizeCheckBox.AutoSize = True
            Me.autoSizeCheckBox.Checked = True
            Me.autoSizeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.autoSizeCheckBox.Location = New System.Drawing.Point(388, 342)
            Me.autoSizeCheckBox.Name = "autoSizeCheckBox"
            Me.autoSizeCheckBox.Size = New System.Drawing.Size(136, 19)
            Me.autoSizeCheckBox.TabIndex = 55
            Me.autoSizeCheckBox.Text = "Auto Size PDF Page"
            Me.autoSizeCheckBox.UseVisualStyleBackColor = True
            Me.autoSizeCheckBox.Visible = False
            '
            'fitWidthCheckBox
            '
            Me.fitWidthCheckBox.AutoSize = True
            Me.fitWidthCheckBox.Checked = True
            Me.fitWidthCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.fitWidthCheckBox.Location = New System.Drawing.Point(36, 342)
            Me.fitWidthCheckBox.Name = "fitWidthCheckBox"
            Me.fitWidthCheckBox.Size = New System.Drawing.Size(73, 19)
            Me.fitWidthCheckBox.TabIndex = 54
            Me.fitWidthCheckBox.Text = "Fit Width"
            Me.fitWidthCheckBox.UseVisualStyleBackColor = True
            '
            'label33
            '
            Me.label33.AutoSize = True
            Me.label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.label33.Location = New System.Drawing.Point(7, 310)
            Me.label33.Name = "label33"
            Me.label33.Size = New System.Drawing.Size(108, 15)
            Me.label33.TabIndex = 39
            Me.label33.Text = "Scaling Options"
            '
            'label20
            '
            Me.label20.AutoSize = True
            Me.label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.label20.Location = New System.Drawing.Point(7, 198)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(151, 15)
            Me.label20.TabIndex = 39
            Me.label20.Text = "HTML Content Options"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.label9.Location = New System.Drawing.Point(7, 84)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(124, 15)
            Me.label9.TabIndex = 39
            Me.label9.Text = "PDF Page Options"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.label1.Location = New System.Drawing.Point(7, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(145, 15)
            Me.label1.TabIndex = 39
            Me.label1.Text = "HTML Viewer Options"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(28, 119)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(37, 15)
            Me.label4.TabIndex = 45
            Me.label4.Text = "Size: "
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(245, 119)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(70, 15)
            Me.label5.TabIndex = 42
            Me.label5.Text = "Orientation:"
            '
            'pdfPageSizeComboBox
            '
            Me.pdfPageSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.pdfPageSizeComboBox.FormattingEnabled = True
            Me.pdfPageSizeComboBox.Items.AddRange(New Object() {"A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10", "B0", "B1", "B2", "B3", "B4", "B5", "ArchA", "ArchB", "ArchC", "ArchD", "ArchE", "Flsa", "HalfLetter", "Ledger", "Legal", "Letter", "Letter11x17", "Note"})
            Me.pdfPageSizeComboBox.Location = New System.Drawing.Point(74, 115)
            Me.pdfPageSizeComboBox.Name = "pdfPageSizeComboBox"
            Me.pdfPageSizeComboBox.Size = New System.Drawing.Size(128, 23)
            Me.pdfPageSizeComboBox.TabIndex = 52
            '
            'pdfPageOrientationComboBox
            '
            Me.pdfPageOrientationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.pdfPageOrientationComboBox.FormattingEnabled = True
            Me.pdfPageOrientationComboBox.Items.AddRange(New Object() {"Portrait", "Landscape"})
            Me.pdfPageOrientationComboBox.Location = New System.Drawing.Point(326, 115)
            Me.pdfPageOrientationComboBox.Name = "pdfPageOrientationComboBox"
            Me.pdfPageOrientationComboBox.Size = New System.Drawing.Size(135, 23)
            Me.pdfPageOrientationComboBox.TabIndex = 51
            '
            'urlPanel
            '
            Me.urlPanel.Controls.Add(Me.enterUrlLabel)
            Me.urlPanel.Controls.Add(Me.urlTextBox)
            Me.urlPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.urlPanel.Location = New System.Drawing.Point(6, 86)
            Me.urlPanel.Name = "urlPanel"
            Me.urlPanel.Size = New System.Drawing.Size(598, 66)
            Me.urlPanel.TabIndex = 75
            '
            'enterUrlLabel
            '
            Me.enterUrlLabel.AutoSize = True
            Me.enterUrlLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.enterUrlLabel.Location = New System.Drawing.Point(7, 12)
            Me.enterUrlLabel.Name = "enterUrlLabel"
            Me.enterUrlLabel.Size = New System.Drawing.Size(266, 15)
            Me.enterUrlLabel.TabIndex = 40
            Me.enterUrlLabel.Text = "HTML Page URL or Local File to Convert"
            '
            'urlTextBox
            '
            Me.urlTextBox.Location = New System.Drawing.Point(9, 33)
            Me.urlTextBox.Name = "urlTextBox"
            Me.urlTextBox.Size = New System.Drawing.Size(576, 21)
            Me.urlTextBox.TabIndex = 41
            Me.urlTextBox.Text = "http://www.evopdf.com/DemoAppFiles/HTML_Files/Structured_HTML.html"
            '
            'label35
            '
            Me.label35.AutoSize = True
            Me.label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label35.Location = New System.Drawing.Point(566, 39)
            Me.label35.Name = "label35"
            Me.label35.Size = New System.Drawing.Size(18, 15)
            Me.label35.TabIndex = 141
            Me.label35.Text = "%"
            '
            'label34
            '
            Me.label34.AutoSize = True
            Me.label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label34.Location = New System.Drawing.Point(471, 39)
            Me.label34.Name = "label34"
            Me.label34.Size = New System.Drawing.Size(42, 15)
            Me.label34.TabIndex = 140
            Me.label34.Text = "Zoom:"
            '
            'htmlViewerZoomTextBox
            '
            Me.htmlViewerZoomTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.htmlViewerZoomTextBox.Location = New System.Drawing.Point(517, 36)
            Me.htmlViewerZoomTextBox.Name = "htmlViewerZoomTextBox"
            Me.htmlViewerZoomTextBox.Size = New System.Drawing.Size(45, 21)
            Me.htmlViewerZoomTextBox.TabIndex = 139
            Me.htmlViewerZoomTextBox.Text = "100"
            '
            'clipContentCheckBox
            '
            Me.clipContentCheckBox.AutoSize = True
            Me.clipContentCheckBox.Location = New System.Drawing.Point(298, 38)
            Me.clipContentCheckBox.Name = "clipContentCheckBox"
            Me.clipContentCheckBox.Size = New System.Drawing.Size(163, 19)
            Me.clipContentCheckBox.TabIndex = 138
            Me.clipContentCheckBox.Text = "Clip HTML Content Width"
            Me.clipContentCheckBox.UseVisualStyleBackColor = True
            '
            'label32
            '
            Me.label32.AutoSize = True
            Me.label32.Location = New System.Drawing.Point(159, 40)
            Me.label32.Name = "label32"
            Me.label32.Size = New System.Drawing.Size(46, 15)
            Me.label32.TabIndex = 134
            Me.label32.Text = "Height:"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(28, 39)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(41, 15)
            Me.label2.TabIndex = 135
            Me.label2.Text = "Width:"
            '
            'label21
            '
            Me.label21.AutoSize = True
            Me.label21.Location = New System.Drawing.Point(263, 40)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(20, 15)
            Me.label21.TabIndex = 132
            Me.label21.Text = "px"
            '
            'htmlViewerHeightTextBox
            '
            Me.htmlViewerHeightTextBox.Location = New System.Drawing.Point(211, 37)
            Me.htmlViewerHeightTextBox.Name = "htmlViewerHeightTextBox"
            Me.htmlViewerHeightTextBox.Size = New System.Drawing.Size(47, 21)
            Me.htmlViewerHeightTextBox.TabIndex = 136
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(126, 39)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(20, 15)
            Me.label3.TabIndex = 133
            Me.label3.Text = "px"
            '
            'htmlViewerWidthTextBox
            '
            Me.htmlViewerWidthTextBox.Location = New System.Drawing.Point(74, 36)
            Me.htmlViewerWidthTextBox.Name = "htmlViewerWidthTextBox"
            Me.htmlViewerWidthTextBox.Size = New System.Drawing.Size(47, 21)
            Me.htmlViewerWidthTextBox.TabIndex = 137
            Me.htmlViewerWidthTextBox.Text = "1024"
            '
            'HTML_Content_Scaling_Demo
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
            Me.Name = "HTML_Content_Scaling_Demo"
            Me.Size = New System.Drawing.Size(610, 650)
            Me.titlePanel.ResumeLayout(False)
            Me.titlePanel.PerformLayout()
            Me.descriptionPanel.ResumeLayout(False)
            Me.convertButtonPanel.ResumeLayout(False)
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            Me.urlPanel.ResumeLayout(False)
            Me.urlPanel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private demoTopPanel As Panel
		Private demoBottomPanel As Panel
		Private demoRightPanel As Panel
		Private demoLeftPanel As Panel
		Private titlePanel As Panel
		Private titleLabel As Label
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private convertButtonPanel As Panel
		Private WithEvents convertToPdfButton As Button
		Private settingsPanel As Panel
		Private label1 As Label
        Private label4 As Label
		Private label5 As Label
        Private pdfPageSizeComboBox As ComboBox
		Private pdfPageOrientationComboBox As ComboBox
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox
		Private fitHeightCheckBox As CheckBox
		Private autoSizeCheckBox As CheckBox
		Private WithEvents fitWidthCheckBox As CheckBox
        Private stretchCheckBox As CheckBox
		Private singlePageCheckBox As CheckBox
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
		Private label10 As Label
		Private label11 As Label
		Private label13 As Label
		Private label15 As Label
		Private label16 As Label
		Private label17 As Label
		Private label18 As Label
		Private label19 As Label
		Private label22 As Label
		Private rightMarginTextBox As TextBox
		Private leftMarginTextBox As TextBox
		Private topMarginTextBox As TextBox
		Private bottomMarginTextBox As TextBox
		Private label14 As Label
		Private label12 As Label
		Private label8 As Label
		Private label7 As Label
		Private label6 As Label
		Private bottomSpacingTextBox As TextBox
		Private topSpacingTextBox As TextBox
		Private label20 As Label
		Private label9 As Label
        Private label33 As Label
        Private WithEvents label35 As System.Windows.Forms.Label
        Private WithEvents label34 As System.Windows.Forms.Label
        Private WithEvents htmlViewerZoomTextBox As System.Windows.Forms.TextBox
        Private WithEvents clipContentCheckBox As System.Windows.Forms.CheckBox
        Private WithEvents label32 As System.Windows.Forms.Label
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents label21 As System.Windows.Forms.Label
        Private WithEvents htmlViewerHeightTextBox As System.Windows.Forms.TextBox
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents htmlViewerWidthTextBox As System.Windows.Forms.TextBox
    End Class
End Namespace

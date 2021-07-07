Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class Repeat_HTML_Table_Header_Footer_Demo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Repeat_HTML_Table_Header_Footer_Demo))
            Me.demoLeftPanel = New System.Windows.Forms.Panel()
            Me.demoRightPanel = New System.Windows.Forms.Panel()
            Me.demoBottomPanel = New System.Windows.Forms.Panel()
            Me.demoTopPanel = New System.Windows.Forms.Panel()
            Me.descriptionPanel = New System.Windows.Forms.Panel()
            Me.descriptionLabel = New System.Windows.Forms.Label()
            Me.titlePanel = New System.Windows.Forms.Panel()
            Me.titleLabel = New System.Windows.Forms.Label()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.convertHtmlRadioButton = New System.Windows.Forms.RadioButton()
            Me.convertUrlRadioButton = New System.Windows.Forms.RadioButton()
            Me.urlPanel = New System.Windows.Forms.Panel()
            Me.viewHtmlLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.enterUrlLabel = New System.Windows.Forms.Label()
            Me.urlTextBox = New System.Windows.Forms.TextBox()
            Me.htmlPanel = New System.Windows.Forms.Panel()
            Me.label2 = New System.Windows.Forms.Label()
            Me.baseUrlTextBox = New System.Windows.Forms.TextBox()
            Me.htmlStringTextBox = New System.Windows.Forms.TextBox()
            Me.label12 = New System.Windows.Forms.Label()
            Me.convertButtonPanel = New System.Windows.Forms.Panel()
            Me.convertToPdfButton = New System.Windows.Forms.Button()
            Me.settingsPanel = New System.Windows.Forms.Panel()
            Me.repeatHtmlTableFooterCheckBox = New System.Windows.Forms.CheckBox()
            Me.repeatHtmlTableHeaderCheckBox = New System.Windows.Forms.CheckBox()
            Me.descriptionPanel.SuspendLayout()
            Me.titlePanel.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.urlPanel.SuspendLayout()
            Me.htmlPanel.SuspendLayout()
            Me.convertButtonPanel.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'demoLeftPanel
            '
            Me.demoLeftPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.demoLeftPanel.Location = New System.Drawing.Point(0, 6)
            Me.demoLeftPanel.Name = "demoLeftPanel"
            Me.demoLeftPanel.Size = New System.Drawing.Size(6, 715)
            Me.demoLeftPanel.TabIndex = 19
            '
            'demoRightPanel
            '
            Me.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.demoRightPanel.Location = New System.Drawing.Point(604, 6)
            Me.demoRightPanel.Name = "demoRightPanel"
            Me.demoRightPanel.Size = New System.Drawing.Size(6, 715)
            Me.demoRightPanel.TabIndex = 18
            '
            'demoBottomPanel
            '
            Me.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.demoBottomPanel.Location = New System.Drawing.Point(0, 721)
            Me.demoBottomPanel.Name = "demoBottomPanel"
            Me.demoBottomPanel.Size = New System.Drawing.Size(610, 6)
            Me.demoBottomPanel.TabIndex = 17
            '
            'demoTopPanel
            '
            Me.demoTopPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.demoTopPanel.Location = New System.Drawing.Point(0, 0)
            Me.demoTopPanel.Name = "demoTopPanel"
            Me.demoTopPanel.Size = New System.Drawing.Size(610, 6)
            Me.demoTopPanel.TabIndex = 16
            '
            'descriptionPanel
            '
            Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
            Me.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.descriptionPanel.Location = New System.Drawing.Point(6, 46)
            Me.descriptionPanel.Name = "descriptionPanel"
            Me.descriptionPanel.Size = New System.Drawing.Size(598, 73)
            Me.descriptionPanel.TabIndex = 112
            '
            'descriptionLabel
            '
            Me.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.descriptionLabel.Location = New System.Drawing.Point(0, 0)
            Me.descriptionLabel.Name = "descriptionLabel"
            Me.descriptionLabel.Size = New System.Drawing.Size(598, 73)
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
            Me.titlePanel.TabIndex = 110
            '
            'titleLabel
            '
            Me.titleLabel.AutoSize = True
            Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.titleLabel.Location = New System.Drawing.Point(0, 10)
            Me.titleLabel.Name = "titleLabel"
            Me.titleLabel.Size = New System.Drawing.Size(398, 17)
            Me.titleLabel.TabIndex = 1
            Me.titleLabel.Text = "Repeat HTML Table Header and Footer in PDF Pages"
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.convertHtmlRadioButton)
            Me.panel1.Controls.Add(Me.convertUrlRadioButton)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(6, 119)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(598, 37)
            Me.panel1.TabIndex = 113
            '
            'convertHtmlRadioButton
            '
            Me.convertHtmlRadioButton.AutoSize = True
            Me.convertHtmlRadioButton.Checked = True
            Me.convertHtmlRadioButton.Location = New System.Drawing.Point(8, 6)
            Me.convertHtmlRadioButton.Name = "convertHtmlRadioButton"
            Me.convertHtmlRadioButton.Size = New System.Drawing.Size(138, 19)
            Me.convertHtmlRadioButton.TabIndex = 71
            Me.convertHtmlRadioButton.TabStop = True
            Me.convertHtmlRadioButton.Text = "Convert HTML String"
            Me.convertHtmlRadioButton.UseVisualStyleBackColor = True
            '
            'convertUrlRadioButton
            '
            Me.convertUrlRadioButton.AutoSize = True
            Me.convertUrlRadioButton.Location = New System.Drawing.Point(191, 6)
            Me.convertUrlRadioButton.Name = "convertUrlRadioButton"
            Me.convertUrlRadioButton.Size = New System.Drawing.Size(164, 19)
            Me.convertUrlRadioButton.TabIndex = 70
            Me.convertUrlRadioButton.Text = "Convert URL or Local File"
            Me.convertUrlRadioButton.UseVisualStyleBackColor = True
            '
            'urlPanel
            '
            Me.urlPanel.Controls.Add(Me.viewHtmlLinkLabel)
            Me.urlPanel.Controls.Add(Me.enterUrlLabel)
            Me.urlPanel.Controls.Add(Me.urlTextBox)
            Me.urlPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.urlPanel.Location = New System.Drawing.Point(6, 156)
            Me.urlPanel.Name = "urlPanel"
            Me.urlPanel.Size = New System.Drawing.Size(598, 67)
            Me.urlPanel.TabIndex = 116
            Me.urlPanel.Visible = False
            '
            'viewHtmlLinkLabel
            '
            Me.viewHtmlLinkLabel.AutoSize = True
            Me.viewHtmlLinkLabel.Location = New System.Drawing.Point(514, 37)
            Me.viewHtmlLinkLabel.Name = "viewHtmlLinkLabel"
            Me.viewHtmlLinkLabel.Size = New System.Drawing.Size(70, 15)
            Me.viewHtmlLinkLabel.TabIndex = 49
            Me.viewHtmlLinkLabel.TabStop = True
            Me.viewHtmlLinkLabel.Text = "View HTML"
            '
            'enterUrlLabel
            '
            Me.enterUrlLabel.AutoSize = True
            Me.enterUrlLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.enterUrlLabel.Location = New System.Drawing.Point(6, 13)
            Me.enterUrlLabel.Name = "enterUrlLabel"
            Me.enterUrlLabel.Size = New System.Drawing.Size(302, 15)
            Me.enterUrlLabel.TabIndex = 42
            Me.enterUrlLabel.Text = "HTML Page with Repeated Header and Footer"
            '
            'urlTextBox
            '
            Me.urlTextBox.Location = New System.Drawing.Point(8, 34)
            Me.urlTextBox.Name = "urlTextBox"
            Me.urlTextBox.Size = New System.Drawing.Size(500, 21)
            Me.urlTextBox.TabIndex = 45
            '
            'htmlPanel
            '
            Me.htmlPanel.Controls.Add(Me.label2)
            Me.htmlPanel.Controls.Add(Me.baseUrlTextBox)
            Me.htmlPanel.Controls.Add(Me.htmlStringTextBox)
            Me.htmlPanel.Controls.Add(Me.label12)
            Me.htmlPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.htmlPanel.Location = New System.Drawing.Point(6, 223)
            Me.htmlPanel.Name = "htmlPanel"
            Me.htmlPanel.Size = New System.Drawing.Size(598, 386)
            Me.htmlPanel.TabIndex = 117
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.label2.Location = New System.Drawing.Point(6, 341)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(71, 15)
            Me.label2.TabIndex = 52
            Me.label2.Text = "Base URL"
            '
            'baseUrlTextBox
            '
            Me.baseUrlTextBox.Location = New System.Drawing.Point(9, 359)
            Me.baseUrlTextBox.Name = "baseUrlTextBox"
            Me.baseUrlTextBox.Size = New System.Drawing.Size(575, 21)
            Me.baseUrlTextBox.TabIndex = 53
            '
            'htmlStringTextBox
            '
            Me.htmlStringTextBox.Location = New System.Drawing.Point(9, 36)
            Me.htmlStringTextBox.MaxLength = 1000000
            Me.htmlStringTextBox.Multiline = True
            Me.htmlStringTextBox.Name = "htmlStringTextBox"
            Me.htmlStringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.htmlStringTextBox.Size = New System.Drawing.Size(574, 292)
            Me.htmlStringTextBox.TabIndex = 51
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.label12.Location = New System.Drawing.Point(6, 16)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(307, 15)
            Me.label12.TabIndex = 50
            Me.label12.Text = "HTML String with Repeated Header and Footer"
            '
            'convertButtonPanel
            '
            Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
            Me.convertButtonPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.convertButtonPanel.Location = New System.Drawing.Point(6, 659)
            Me.convertButtonPanel.Name = "convertButtonPanel"
            Me.convertButtonPanel.Size = New System.Drawing.Size(598, 42)
            Me.convertButtonPanel.TabIndex = 120
            '
            'convertToPdfButton
            '
            Me.convertToPdfButton.Location = New System.Drawing.Point(9, 6)
            Me.convertToPdfButton.Name = "convertToPdfButton"
            Me.convertToPdfButton.Size = New System.Drawing.Size(150, 27)
            Me.convertToPdfButton.TabIndex = 66
            Me.convertToPdfButton.Text = "Convert HTML to PDF"
            Me.convertToPdfButton.UseVisualStyleBackColor = True
            '
            'settingsPanel
            '
            Me.settingsPanel.Controls.Add(Me.repeatHtmlTableFooterCheckBox)
            Me.settingsPanel.Controls.Add(Me.repeatHtmlTableHeaderCheckBox)
            Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.settingsPanel.Location = New System.Drawing.Point(6, 609)
            Me.settingsPanel.Name = "settingsPanel"
            Me.settingsPanel.Size = New System.Drawing.Size(598, 50)
            Me.settingsPanel.TabIndex = 119
            '
            'repeatHtmlTableFooterCheckBox
            '
            Me.repeatHtmlTableFooterCheckBox.AutoSize = True
            Me.repeatHtmlTableFooterCheckBox.Checked = True
            Me.repeatHtmlTableFooterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.repeatHtmlTableFooterCheckBox.Location = New System.Drawing.Point(234, 15)
            Me.repeatHtmlTableFooterCheckBox.Name = "repeatHtmlTableFooterCheckBox"
            Me.repeatHtmlTableFooterCheckBox.Size = New System.Drawing.Size(175, 19)
            Me.repeatHtmlTableFooterCheckBox.TabIndex = 2
            Me.repeatHtmlTableFooterCheckBox.Text = "Repeat HTML Table Footer"
            Me.repeatHtmlTableFooterCheckBox.UseVisualStyleBackColor = True
            '
            'repeatHtmlTableHeaderCheckBox
            '
            Me.repeatHtmlTableHeaderCheckBox.AutoSize = True
            Me.repeatHtmlTableHeaderCheckBox.Checked = True
            Me.repeatHtmlTableHeaderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.repeatHtmlTableHeaderCheckBox.Location = New System.Drawing.Point(9, 15)
            Me.repeatHtmlTableHeaderCheckBox.Name = "repeatHtmlTableHeaderCheckBox"
            Me.repeatHtmlTableHeaderCheckBox.Size = New System.Drawing.Size(181, 19)
            Me.repeatHtmlTableHeaderCheckBox.TabIndex = 1
            Me.repeatHtmlTableHeaderCheckBox.Text = "Repeat HTML Table Header"
            Me.repeatHtmlTableHeaderCheckBox.UseVisualStyleBackColor = True
            '
            'Repeat_HTML_Table_Header_Footer_Demo
            '
            Me.AutoScroll = True
            Me.Controls.Add(Me.convertButtonPanel)
            Me.Controls.Add(Me.settingsPanel)
            Me.Controls.Add(Me.htmlPanel)
            Me.Controls.Add(Me.urlPanel)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.descriptionPanel)
            Me.Controls.Add(Me.titlePanel)
            Me.Controls.Add(Me.demoLeftPanel)
            Me.Controls.Add(Me.demoRightPanel)
            Me.Controls.Add(Me.demoBottomPanel)
            Me.Controls.Add(Me.demoTopPanel)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.Name = "Repeat_HTML_Table_Header_Footer_Demo"
            Me.Size = New System.Drawing.Size(610, 727)
            Me.descriptionPanel.ResumeLayout(False)
            Me.titlePanel.ResumeLayout(False)
            Me.titlePanel.PerformLayout()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.urlPanel.ResumeLayout(False)
            Me.urlPanel.PerformLayout()
            Me.htmlPanel.ResumeLayout(False)
            Me.htmlPanel.PerformLayout()
            Me.convertButtonPanel.ResumeLayout(False)
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
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
		Private panel1 As Panel
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox
		Private htmlPanel As Panel
		Private convertButtonPanel As Panel
		Private WithEvents convertToPdfButton As Button
		Private settingsPanel As Panel
		Private repeatHtmlTableFooterCheckBox As CheckBox
		Private repeatHtmlTableHeaderCheckBox As CheckBox
		Private WithEvents convertHtmlRadioButton As RadioButton
		Private WithEvents convertUrlRadioButton As RadioButton
		Private label2 As Label
		Private baseUrlTextBox As TextBox
		Private htmlStringTextBox As TextBox
		Private label12 As Label
		Private WithEvents viewHtmlLinkLabel As LinkLabel
	End Class
End Namespace

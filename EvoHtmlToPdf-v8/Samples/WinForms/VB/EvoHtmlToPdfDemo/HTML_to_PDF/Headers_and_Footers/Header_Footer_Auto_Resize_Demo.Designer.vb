Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers
	Partial Public Class Header_Footer_Auto_Resize_Demo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Header_Footer_Auto_Resize_Demo))
            Me.demoBottomPanel = New System.Windows.Forms.Panel()
            Me.demoTopPanel = New System.Windows.Forms.Panel()
            Me.demoLeftPanel = New System.Windows.Forms.Panel()
            Me.demoRightPanel = New System.Windows.Forms.Panel()
            Me.convertButtonPanel = New System.Windows.Forms.Panel()
            Me.convertToPdfButton = New System.Windows.Forms.Button()
            Me.settingsPanel = New System.Windows.Forms.Panel()
            Me.fixedHeightOptionsPanel = New System.Windows.Forms.Panel()
            Me.label12 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.headerHeightTextBox = New System.Windows.Forms.TextBox()
            Me.fitHeaderHeightRadioButton = New System.Windows.Forms.RadioButton()
            Me.autoResizeHeaderRadioButton = New System.Windows.Forms.RadioButton()
            Me.urlPanel = New System.Windows.Forms.Panel()
            Me.enterUrlLabel = New System.Windows.Forms.Label()
            Me.urlTextBox = New System.Windows.Forms.TextBox()
            Me.descriptionPanel = New System.Windows.Forms.Panel()
            Me.descriptionLabel = New System.Windows.Forms.Label()
            Me.titlePanel = New System.Windows.Forms.Panel()
            Me.titleLabel = New System.Windows.Forms.Label()
            Me.convertButtonPanel.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            Me.fixedHeightOptionsPanel.SuspendLayout()
            Me.urlPanel.SuspendLayout()
            Me.descriptionPanel.SuspendLayout()
            Me.titlePanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'demoBottomPanel
            '
            Me.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.demoBottomPanel.Location = New System.Drawing.Point(0, 644)
            Me.demoBottomPanel.Name = "demoBottomPanel"
            Me.demoBottomPanel.Size = New System.Drawing.Size(610, 6)
            Me.demoBottomPanel.TabIndex = 8
            '
            'demoTopPanel
            '
            Me.demoTopPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.demoTopPanel.Location = New System.Drawing.Point(0, 0)
            Me.demoTopPanel.Name = "demoTopPanel"
            Me.demoTopPanel.Size = New System.Drawing.Size(610, 6)
            Me.demoTopPanel.TabIndex = 7
            '
            'demoLeftPanel
            '
            Me.demoLeftPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.demoLeftPanel.Location = New System.Drawing.Point(0, 6)
            Me.demoLeftPanel.Name = "demoLeftPanel"
            Me.demoLeftPanel.Size = New System.Drawing.Size(6, 638)
            Me.demoLeftPanel.TabIndex = 11
            '
            'demoRightPanel
            '
            Me.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.demoRightPanel.Location = New System.Drawing.Point(604, 6)
            Me.demoRightPanel.Name = "demoRightPanel"
            Me.demoRightPanel.Size = New System.Drawing.Size(6, 638)
            Me.demoRightPanel.TabIndex = 10
            '
            'convertButtonPanel
            '
            Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
            Me.convertButtonPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.convertButtonPanel.Location = New System.Drawing.Point(6, 224)
            Me.convertButtonPanel.Name = "convertButtonPanel"
            Me.convertButtonPanel.Size = New System.Drawing.Size(598, 42)
            Me.convertButtonPanel.TabIndex = 97
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
            Me.settingsPanel.Controls.Add(Me.fixedHeightOptionsPanel)
            Me.settingsPanel.Controls.Add(Me.fitHeaderHeightRadioButton)
            Me.settingsPanel.Controls.Add(Me.autoResizeHeaderRadioButton)
            Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.settingsPanel.Location = New System.Drawing.Point(6, 174)
            Me.settingsPanel.Name = "settingsPanel"
            Me.settingsPanel.Size = New System.Drawing.Size(598, 50)
            Me.settingsPanel.TabIndex = 96
            '
            'fixedHeightOptionsPanel
            '
            Me.fixedHeightOptionsPanel.Controls.Add(Me.label12)
            Me.fixedHeightOptionsPanel.Controls.Add(Me.label7)
            Me.fixedHeightOptionsPanel.Controls.Add(Me.headerHeightTextBox)
            Me.fixedHeightOptionsPanel.Location = New System.Drawing.Point(359, 6)
            Me.fixedHeightOptionsPanel.Name = "fixedHeightOptionsPanel"
            Me.fixedHeightOptionsPanel.Size = New System.Drawing.Size(226, 38)
            Me.fixedHeightOptionsPanel.TabIndex = 48
            Me.fixedHeightOptionsPanel.Visible = False
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label12.Location = New System.Drawing.Point(166, 11)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(17, 15)
            Me.label12.TabIndex = 123
            Me.label12.Text = "pt"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label7.Location = New System.Drawing.Point(14, 11)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(90, 15)
            Me.label7.TabIndex = 122
            Me.label7.Text = "Header Height:"
            '
            'headerHeightTextBox
            '
            Me.headerHeightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.headerHeightTextBox.Location = New System.Drawing.Point(117, 8)
            Me.headerHeightTextBox.Name = "headerHeightTextBox"
            Me.headerHeightTextBox.Size = New System.Drawing.Size(45, 21)
            Me.headerHeightTextBox.TabIndex = 121
            Me.headerHeightTextBox.Text = "40"
            '
            'fitHeaderHeightRadioButton
            '
            Me.fitHeaderHeightRadioButton.AutoSize = True
            Me.fitHeaderHeightRadioButton.Location = New System.Drawing.Point(164, 15)
            Me.fitHeaderHeightRadioButton.Name = "fitHeaderHeightRadioButton"
            Me.fitHeaderHeightRadioButton.Size = New System.Drawing.Size(164, 19)
            Me.fitHeaderHeightRadioButton.TabIndex = 47
            Me.fitHeaderHeightRadioButton.Text = "Fit a Fixed Header Height"
            Me.fitHeaderHeightRadioButton.UseVisualStyleBackColor = True
            '
            'autoResizeHeaderRadioButton
            '
            Me.autoResizeHeaderRadioButton.AutoSize = True
            Me.autoResizeHeaderRadioButton.Checked = True
            Me.autoResizeHeaderRadioButton.Location = New System.Drawing.Point(9, 15)
            Me.autoResizeHeaderRadioButton.Name = "autoResizeHeaderRadioButton"
            Me.autoResizeHeaderRadioButton.Size = New System.Drawing.Size(134, 19)
            Me.autoResizeHeaderRadioButton.TabIndex = 46
            Me.autoResizeHeaderRadioButton.TabStop = True
            Me.autoResizeHeaderRadioButton.Text = "Auto Resize Header"
            Me.autoResizeHeaderRadioButton.UseVisualStyleBackColor = True
            '
            'urlPanel
            '
            Me.urlPanel.Controls.Add(Me.enterUrlLabel)
            Me.urlPanel.Controls.Add(Me.urlTextBox)
            Me.urlPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.urlPanel.Location = New System.Drawing.Point(6, 104)
            Me.urlPanel.Name = "urlPanel"
            Me.urlPanel.Size = New System.Drawing.Size(598, 70)
            Me.urlPanel.TabIndex = 95
            '
            'enterUrlLabel
            '
            Me.enterUrlLabel.AutoSize = True
            Me.enterUrlLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.enterUrlLabel.Location = New System.Drawing.Point(6, 9)
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
            'descriptionPanel
            '
            Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
            Me.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.descriptionPanel.Location = New System.Drawing.Point(6, 46)
            Me.descriptionPanel.Name = "descriptionPanel"
            Me.descriptionPanel.Size = New System.Drawing.Size(598, 58)
            Me.descriptionPanel.TabIndex = 94
            '
            'descriptionLabel
            '
            Me.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.descriptionLabel.Location = New System.Drawing.Point(0, 0)
            Me.descriptionLabel.Name = "descriptionLabel"
            Me.descriptionLabel.Size = New System.Drawing.Size(598, 58)
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
            Me.titlePanel.TabIndex = 92
            '
            'titleLabel
            '
            Me.titleLabel.AutoSize = True
            Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.titleLabel.Location = New System.Drawing.Point(0, 10)
            Me.titleLabel.Name = "titleLabel"
            Me.titleLabel.Size = New System.Drawing.Size(328, 17)
            Me.titleLabel.TabIndex = 1
            Me.titleLabel.Text = "Automatically Resize the Header and Footer"
            '
            'Header_Footer_Auto_Resize_Demo
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
            Me.Name = "Header_Footer_Auto_Resize_Demo"
            Me.Size = New System.Drawing.Size(610, 650)
            Me.convertButtonPanel.ResumeLayout(False)
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            Me.fixedHeightOptionsPanel.ResumeLayout(False)
            Me.fixedHeightOptionsPanel.PerformLayout()
            Me.urlPanel.ResumeLayout(False)
            Me.urlPanel.PerformLayout()
            Me.descriptionPanel.ResumeLayout(False)
            Me.titlePanel.ResumeLayout(False)
            Me.titlePanel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private demoBottomPanel As Panel
		Private demoTopPanel As Panel
		Private demoLeftPanel As Panel
		Private demoRightPanel As Panel
		Private convertButtonPanel As Panel
		Private WithEvents convertToPdfButton As Button
		Private settingsPanel As Panel
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
		Private WithEvents fitHeaderHeightRadioButton As RadioButton
		Private WithEvents autoResizeHeaderRadioButton As RadioButton
		Private fixedHeightOptionsPanel As Panel
		Private label12 As Label
		Private label7 As Label
		Private headerHeightTextBox As TextBox
	End Class
End Namespace

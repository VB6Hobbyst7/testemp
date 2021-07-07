<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proxy_Options_Demo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proxy_Options_Demo))
        Me.demoBottomPanel = New System.Windows.Forms.Panel()
        Me.demoLeftPanel = New System.Windows.Forms.Panel()
        Me.demoRightPanel = New System.Windows.Forms.Panel()
        Me.demoTopPanel = New System.Windows.Forms.Panel()
        Me.titlePanel = New System.Windows.Forms.Panel()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.descriptionPanel = New System.Windows.Forms.Panel()
        Me.descriptionLabel = New System.Windows.Forms.Label()
        Me.convertButtonPanel = New System.Windows.Forms.Panel()
        Me.convertToPdfButton = New System.Windows.Forms.Button()
        Me.settingsPanel = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.bypassedHostTextBox = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.proxyTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.portNumberTextBox = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.hostNameTextBox = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.urlPanel = New System.Windows.Forms.Panel()
        Me.enterUrlLabel = New System.Windows.Forms.Label()
        Me.urlTextBox = New System.Windows.Forms.TextBox()
        Me.titlePanel.SuspendLayout()
        Me.descriptionPanel.SuspendLayout()
        Me.convertButtonPanel.SuspendLayout()
        Me.settingsPanel.SuspendLayout()
        Me.urlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'demoBottomPanel
        '
        Me.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.demoBottomPanel.Location = New System.Drawing.Point(6, 644)
        Me.demoBottomPanel.Name = "demoBottomPanel"
        Me.demoBottomPanel.Size = New System.Drawing.Size(598, 6)
        Me.demoBottomPanel.TabIndex = 202
        '
        'demoLeftPanel
        '
        Me.demoLeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.demoLeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.demoLeftPanel.Name = "demoLeftPanel"
        Me.demoLeftPanel.Size = New System.Drawing.Size(6, 650)
        Me.demoLeftPanel.TabIndex = 204
        '
        'demoRightPanel
        '
        Me.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.demoRightPanel.Location = New System.Drawing.Point(604, 0)
        Me.demoRightPanel.Name = "demoRightPanel"
        Me.demoRightPanel.Size = New System.Drawing.Size(6, 650)
        Me.demoRightPanel.TabIndex = 203
        '
        'demoTopPanel
        '
        Me.demoTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.demoTopPanel.Location = New System.Drawing.Point(6, 0)
        Me.demoTopPanel.Name = "demoTopPanel"
        Me.demoTopPanel.Size = New System.Drawing.Size(598, 6)
        Me.demoTopPanel.TabIndex = 210
        '
        'titlePanel
        '
        Me.titlePanel.Controls.Add(Me.titleLabel)
        Me.titlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlePanel.Location = New System.Drawing.Point(6, 6)
        Me.titlePanel.Name = "titlePanel"
        Me.titlePanel.Size = New System.Drawing.Size(598, 40)
        Me.titlePanel.TabIndex = 211
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.titleLabel.Location = New System.Drawing.Point(0, 10)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(287, 17)
        Me.titleLabel.TabIndex = 1
        Me.titleLabel.Text = "Access a HTML Page Through a Proxy"
        '
        'descriptionPanel
        '
        Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
        Me.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.descriptionPanel.Location = New System.Drawing.Point(6, 46)
        Me.descriptionPanel.Name = "descriptionPanel"
        Me.descriptionPanel.Size = New System.Drawing.Size(598, 52)
        Me.descriptionPanel.TabIndex = 212
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
        'convertButtonPanel
        '
        Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
        Me.convertButtonPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.convertButtonPanel.Location = New System.Drawing.Point(6, 300)
        Me.convertButtonPanel.Name = "convertButtonPanel"
        Me.convertButtonPanel.Size = New System.Drawing.Size(598, 43)
        Me.convertButtonPanel.TabIndex = 215
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
        Me.settingsPanel.Controls.Add(Me.label1)
        Me.settingsPanel.Controls.Add(Me.passwordTextBox)
        Me.settingsPanel.Controls.Add(Me.label7)
        Me.settingsPanel.Controls.Add(Me.bypassedHostTextBox)
        Me.settingsPanel.Controls.Add(Me.label6)
        Me.settingsPanel.Controls.Add(Me.usernameTextBox)
        Me.settingsPanel.Controls.Add(Me.label3)
        Me.settingsPanel.Controls.Add(Me.proxyTypeComboBox)
        Me.settingsPanel.Controls.Add(Me.label5)
        Me.settingsPanel.Controls.Add(Me.portNumberTextBox)
        Me.settingsPanel.Controls.Add(Me.label2)
        Me.settingsPanel.Controls.Add(Me.hostNameTextBox)
        Me.settingsPanel.Controls.Add(Me.label4)
        Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.settingsPanel.Location = New System.Drawing.Point(6, 168)
        Me.settingsPanel.Name = "settingsPanel"
        Me.settingsPanel.Size = New System.Drawing.Size(598, 132)
        Me.settingsPanel.TabIndex = 214
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(181, 90)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(64, 15)
        Me.label1.TabIndex = 56
        Me.label1.Text = "Password:"
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(251, 87)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(80, 21)
        Me.passwordTextBox.TabIndex = 58
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(356, 90)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(77, 15)
        Me.label7.TabIndex = 57
        Me.label7.Text = "Bypass Host:"
        '
        'bypassedHostTextBox
        '
        Me.bypassedHostTextBox.Location = New System.Drawing.Point(439, 87)
        Me.bypassedHostTextBox.Name = "bypassedHostTextBox"
        Me.bypassedHostTextBox.Size = New System.Drawing.Size(117, 21)
        Me.bypassedHostTextBox.TabIndex = 59
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(16, 90)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(68, 15)
        Me.label6.TabIndex = 57
        Me.label6.Text = "Username:"
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Location = New System.Drawing.Point(90, 87)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(80, 21)
        Me.usernameTextBox.TabIndex = 59
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(16, 40)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(39, 15)
        Me.label3.TabIndex = 54
        Me.label3.Text = "Type: "
        '
        'proxyTypeComboBox
        '
        Me.proxyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.proxyTypeComboBox.FormattingEnabled = True
        Me.proxyTypeComboBox.Items.AddRange(New Object() {"None", "Http", "Socks5", "HttpCaching"})
        Me.proxyTypeComboBox.Location = New System.Drawing.Point(62, 37)
        Me.proxyTypeComboBox.Name = "proxyTypeComboBox"
        Me.proxyTypeComboBox.Size = New System.Drawing.Size(90, 23)
        Me.proxyTypeComboBox.TabIndex = 55
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(423, 40)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(80, 15)
        Me.label5.TabIndex = 51
        Me.label5.Text = "Port Number:"
        '
        'portNumberTextBox
        '
        Me.portNumberTextBox.Location = New System.Drawing.Point(509, 37)
        Me.portNumberTextBox.Name = "portNumberTextBox"
        Me.portNumberTextBox.Size = New System.Drawing.Size(46, 21)
        Me.portNumberTextBox.TabIndex = 53
        Me.portNumberTextBox.Text = "0"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(181, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(100, 15)
        Me.label2.TabIndex = 51
        Me.label2.Text = "Host Name or IP:"
        '
        'hostNameTextBox
        '
        Me.hostNameTextBox.Location = New System.Drawing.Point(287, 37)
        Me.hostNameTextBox.Name = "hostNameTextBox"
        Me.hostNameTextBox.Size = New System.Drawing.Size(108, 21)
        Me.hostNameTextBox.TabIndex = 53
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.label4.Location = New System.Drawing.Point(3, 3)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(95, 15)
        Me.label4.TabIndex = 50
        Me.label4.Text = "Proxy Options"
        '
        'urlPanel
        '
        Me.urlPanel.Controls.Add(Me.enterUrlLabel)
        Me.urlPanel.Controls.Add(Me.urlTextBox)
        Me.urlPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.urlPanel.Location = New System.Drawing.Point(6, 98)
        Me.urlPanel.Name = "urlPanel"
        Me.urlPanel.Size = New System.Drawing.Size(598, 70)
        Me.urlPanel.TabIndex = 213
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
        'Proxy_Options_Demo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.convertButtonPanel)
        Me.Controls.Add(Me.settingsPanel)
        Me.Controls.Add(Me.urlPanel)
        Me.Controls.Add(Me.descriptionPanel)
        Me.Controls.Add(Me.titlePanel)
        Me.Controls.Add(Me.demoTopPanel)
        Me.Controls.Add(Me.demoBottomPanel)
        Me.Controls.Add(Me.demoLeftPanel)
        Me.Controls.Add(Me.demoRightPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Name = "Proxy_Options_Demo"
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
    Private WithEvents demoBottomPanel As System.Windows.Forms.Panel
    Private WithEvents demoLeftPanel As System.Windows.Forms.Panel
    Private WithEvents demoRightPanel As System.Windows.Forms.Panel
    Private WithEvents demoTopPanel As System.Windows.Forms.Panel
    Private WithEvents titlePanel As System.Windows.Forms.Panel
    Private WithEvents titleLabel As System.Windows.Forms.Label
    Private WithEvents descriptionPanel As System.Windows.Forms.Panel
    Private WithEvents descriptionLabel As System.Windows.Forms.Label
    Private WithEvents convertButtonPanel As System.Windows.Forms.Panel
    Private WithEvents convertToPdfButton As System.Windows.Forms.Button
    Private WithEvents settingsPanel As System.Windows.Forms.Panel
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents passwordTextBox As System.Windows.Forms.TextBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents bypassedHostTextBox As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents usernameTextBox As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents proxyTypeComboBox As System.Windows.Forms.ComboBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents portNumberTextBox As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents hostNameTextBox As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents urlPanel As System.Windows.Forms.Panel
    Private WithEvents enterUrlLabel As System.Windows.Forms.Label
    Private WithEvents urlTextBox As System.Windows.Forms.TextBox

End Class

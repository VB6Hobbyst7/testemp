<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Merge_Table_of_Contents_Demo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Merge_Table_of_Contents_Demo))
        Me.urlPanel = New System.Windows.Forms.Panel()
        Me.viewSecondHtmlLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.viewFirstHtmlLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.label6 = New System.Windows.Forms.Label()
        Me.enterUrlLabel = New System.Windows.Forms.Label()
        Me.secondUrlTextBox = New System.Windows.Forms.TextBox()
        Me.firstUrlTextBox = New System.Windows.Forms.TextBox()
        Me.descriptionPanel = New System.Windows.Forms.Panel()
        Me.descriptionLabel = New System.Windows.Forms.Label()
        Me.titlePanel = New System.Windows.Forms.Panel()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.demoBottomPanel = New System.Windows.Forms.Panel()
        Me.demoTopPanel = New System.Windows.Forms.Panel()
        Me.demoLeftPanel = New System.Windows.Forms.Panel()
        Me.demoRightPanel = New System.Windows.Forms.Panel()
        Me.convertButtonPanel = New System.Windows.Forms.Panel()
        Me.convertToPdfButton = New System.Windows.Forms.Button()
        Me.settingsPanel = New System.Windows.Forms.Panel()
        Me.autoTableOfContentsCheckBox = New System.Windows.Forms.CheckBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.includeSecondHtmlTocCheckBox = New System.Windows.Forms.CheckBox()
        Me.includeFirstHtmlTocCheckBox = New System.Windows.Forms.CheckBox()
        Me.startNewPageCheckBox = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.urlPanel.SuspendLayout()
        Me.descriptionPanel.SuspendLayout()
        Me.titlePanel.SuspendLayout()
        Me.convertButtonPanel.SuspendLayout()
        Me.settingsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'urlPanel
        '
        Me.urlPanel.Controls.Add(Me.viewSecondHtmlLinkLabel)
        Me.urlPanel.Controls.Add(Me.viewFirstHtmlLinkLabel)
        Me.urlPanel.Controls.Add(Me.label6)
        Me.urlPanel.Controls.Add(Me.enterUrlLabel)
        Me.urlPanel.Controls.Add(Me.secondUrlTextBox)
        Me.urlPanel.Controls.Add(Me.firstUrlTextBox)
        Me.urlPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.urlPanel.Location = New System.Drawing.Point(6, 109)
        Me.urlPanel.Name = "urlPanel"
        Me.urlPanel.Size = New System.Drawing.Size(598, 131)
        Me.urlPanel.TabIndex = 107
        '
        'viewSecondHtmlLinkLabel
        '
        Me.viewSecondHtmlLinkLabel.AutoSize = True
        Me.viewSecondHtmlLinkLabel.Location = New System.Drawing.Point(515, 100)
        Me.viewSecondHtmlLinkLabel.Name = "viewSecondHtmlLinkLabel"
        Me.viewSecondHtmlLinkLabel.Size = New System.Drawing.Size(70, 15)
        Me.viewSecondHtmlLinkLabel.TabIndex = 47
        Me.viewSecondHtmlLinkLabel.TabStop = True
        Me.viewSecondHtmlLinkLabel.Text = "View HTML"
        '
        'viewFirstHtmlLinkLabel
        '
        Me.viewFirstHtmlLinkLabel.AutoSize = True
        Me.viewFirstHtmlLinkLabel.Location = New System.Drawing.Point(515, 41)
        Me.viewFirstHtmlLinkLabel.Name = "viewFirstHtmlLinkLabel"
        Me.viewFirstHtmlLinkLabel.Size = New System.Drawing.Size(70, 15)
        Me.viewFirstHtmlLinkLabel.TabIndex = 47
        Me.viewFirstHtmlLinkLabel.TabStop = True
        Me.viewFirstHtmlLinkLabel.Text = "View HTML"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.label6.Location = New System.Drawing.Point(7, 73)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(166, 15)
        Me.label6.TabIndex = 40
        Me.label6.Text = "Second HTML Page URL"
        '
        'enterUrlLabel
        '
        Me.enterUrlLabel.AutoSize = True
        Me.enterUrlLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.enterUrlLabel.Location = New System.Drawing.Point(7, 14)
        Me.enterUrlLabel.Name = "enterUrlLabel"
        Me.enterUrlLabel.Size = New System.Drawing.Size(146, 15)
        Me.enterUrlLabel.TabIndex = 40
        Me.enterUrlLabel.Text = "First HTML Page URL"
        '
        'secondUrlTextBox
        '
        Me.secondUrlTextBox.Location = New System.Drawing.Point(9, 97)
        Me.secondUrlTextBox.Name = "secondUrlTextBox"
        Me.secondUrlTextBox.Size = New System.Drawing.Size(500, 21)
        Me.secondUrlTextBox.TabIndex = 41
        Me.secondUrlTextBox.Text = "http://www.evopdf.com/DemoAppFiles/HTML_Files/Structured_HTML.html"
        '
        'firstUrlTextBox
        '
        Me.firstUrlTextBox.Location = New System.Drawing.Point(9, 38)
        Me.firstUrlTextBox.Name = "firstUrlTextBox"
        Me.firstUrlTextBox.Size = New System.Drawing.Size(500, 21)
        Me.firstUrlTextBox.TabIndex = 41
        Me.firstUrlTextBox.Text = "http://www.cnn.com"
        '
        'descriptionPanel
        '
        Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
        Me.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.descriptionPanel.Location = New System.Drawing.Point(6, 52)
        Me.descriptionPanel.Name = "descriptionPanel"
        Me.descriptionPanel.Size = New System.Drawing.Size(598, 57)
        Me.descriptionPanel.TabIndex = 106
        '
        'descriptionLabel
        '
        Me.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.descriptionLabel.Location = New System.Drawing.Point(0, 0)
        Me.descriptionLabel.Name = "descriptionLabel"
        Me.descriptionLabel.Size = New System.Drawing.Size(598, 57)
        Me.descriptionLabel.TabIndex = 0
        Me.descriptionLabel.Text = resources.GetString("descriptionLabel.Text")
        '
        'titlePanel
        '
        Me.titlePanel.Controls.Add(Me.titleLabel)
        Me.titlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlePanel.Location = New System.Drawing.Point(6, 6)
        Me.titlePanel.Name = "titlePanel"
        Me.titlePanel.Size = New System.Drawing.Size(598, 46)
        Me.titlePanel.TabIndex = 105
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.titleLabel.Location = New System.Drawing.Point(0, 12)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(382, 17)
        Me.titleLabel.TabIndex = 1
        Me.titleLabel.Text = "Merge Table of Contents from Multiple HTML Pages"
        '
        'demoBottomPanel
        '
        Me.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.demoBottomPanel.Location = New System.Drawing.Point(6, 644)
        Me.demoBottomPanel.Name = "demoBottomPanel"
        Me.demoBottomPanel.Size = New System.Drawing.Size(598, 6)
        Me.demoBottomPanel.TabIndex = 102
        '
        'demoTopPanel
        '
        Me.demoTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.demoTopPanel.Location = New System.Drawing.Point(6, 0)
        Me.demoTopPanel.Name = "demoTopPanel"
        Me.demoTopPanel.Size = New System.Drawing.Size(598, 6)
        Me.demoTopPanel.TabIndex = 101
        '
        'demoLeftPanel
        '
        Me.demoLeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.demoLeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.demoLeftPanel.Name = "demoLeftPanel"
        Me.demoLeftPanel.Size = New System.Drawing.Size(6, 650)
        Me.demoLeftPanel.TabIndex = 104
        '
        'demoRightPanel
        '
        Me.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.demoRightPanel.Location = New System.Drawing.Point(604, 0)
        Me.demoRightPanel.Name = "demoRightPanel"
        Me.demoRightPanel.Size = New System.Drawing.Size(6, 650)
        Me.demoRightPanel.TabIndex = 103
        '
        'convertButtonPanel
        '
        Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
        Me.convertButtonPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.convertButtonPanel.Location = New System.Drawing.Point(6, 418)
        Me.convertButtonPanel.Name = "convertButtonPanel"
        Me.convertButtonPanel.Size = New System.Drawing.Size(598, 50)
        Me.convertButtonPanel.TabIndex = 111
        '
        'convertToPdfButton
        '
        Me.convertToPdfButton.Location = New System.Drawing.Point(7, 7)
        Me.convertToPdfButton.Name = "convertToPdfButton"
        Me.convertToPdfButton.Size = New System.Drawing.Size(150, 31)
        Me.convertToPdfButton.TabIndex = 66
        Me.convertToPdfButton.Text = "Convert HTML to PDF"
        Me.convertToPdfButton.UseVisualStyleBackColor = True
        '
        'settingsPanel
        '
        Me.settingsPanel.Controls.Add(Me.autoTableOfContentsCheckBox)
        Me.settingsPanel.Controls.Add(Me.label5)
        Me.settingsPanel.Controls.Add(Me.label3)
        Me.settingsPanel.Controls.Add(Me.includeSecondHtmlTocCheckBox)
        Me.settingsPanel.Controls.Add(Me.includeFirstHtmlTocCheckBox)
        Me.settingsPanel.Controls.Add(Me.startNewPageCheckBox)
        Me.settingsPanel.Controls.Add(Me.label1)
        Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.settingsPanel.Location = New System.Drawing.Point(6, 240)
        Me.settingsPanel.Name = "settingsPanel"
        Me.settingsPanel.Size = New System.Drawing.Size(598, 178)
        Me.settingsPanel.TabIndex = 110
        '
        'autoTableOfContentsCheckBox
        '
        Me.autoTableOfContentsCheckBox.AutoSize = True
        Me.autoTableOfContentsCheckBox.Checked = True
        Me.autoTableOfContentsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.autoTableOfContentsCheckBox.Location = New System.Drawing.Point(40, 104)
        Me.autoTableOfContentsCheckBox.Name = "autoTableOfContentsCheckBox"
        Me.autoTableOfContentsCheckBox.Size = New System.Drawing.Size(279, 19)
        Me.autoTableOfContentsCheckBox.TabIndex = 143
        Me.autoTableOfContentsCheckBox.Text = "Create a Table of Contents from H1 to H6 Tags"
        Me.autoTableOfContentsCheckBox.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.label5.Location = New System.Drawing.Point(614, 218)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(17, 15)
        Me.label5.TabIndex = 142
        Me.label5.Text = "pt"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.label3.Location = New System.Drawing.Point(6, 70)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(172, 15)
        Me.label3.TabIndex = 137
        Me.label3.Text = "Table of Contents Options"
        '
        'includeSecondHtmlTocCheckBox
        '
        Me.includeSecondHtmlTocCheckBox.AutoSize = True
        Me.includeSecondHtmlTocCheckBox.Checked = True
        Me.includeSecondHtmlTocCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.includeSecondHtmlTocCheckBox.Location = New System.Drawing.Point(234, 139)
        Me.includeSecondHtmlTocCheckBox.Name = "includeSecondHtmlTocCheckBox"
        Me.includeSecondHtmlTocCheckBox.Size = New System.Drawing.Size(175, 19)
        Me.includeSecondHtmlTocCheckBox.TabIndex = 128
        Me.includeSecondHtmlTocCheckBox.Text = "Include Second HTML TOC"
        Me.includeSecondHtmlTocCheckBox.UseVisualStyleBackColor = True
        '
        'includeFirstHtmlTocCheckBox
        '
        Me.includeFirstHtmlTocCheckBox.AutoSize = True
        Me.includeFirstHtmlTocCheckBox.Checked = True
        Me.includeFirstHtmlTocCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.includeFirstHtmlTocCheckBox.Location = New System.Drawing.Point(40, 139)
        Me.includeFirstHtmlTocCheckBox.Name = "includeFirstHtmlTocCheckBox"
        Me.includeFirstHtmlTocCheckBox.Size = New System.Drawing.Size(156, 19)
        Me.includeFirstHtmlTocCheckBox.TabIndex = 131
        Me.includeFirstHtmlTocCheckBox.Text = "Include First HTML TOC"
        Me.includeFirstHtmlTocCheckBox.UseVisualStyleBackColor = True
        '
        'startNewPageCheckBox
        '
        Me.startNewPageCheckBox.AutoSize = True
        Me.startNewPageCheckBox.Location = New System.Drawing.Point(40, 37)
        Me.startNewPageCheckBox.Name = "startNewPageCheckBox"
        Me.startNewPageCheckBox.Size = New System.Drawing.Size(267, 19)
        Me.startNewPageCheckBox.TabIndex = 40
        Me.startNewPageCheckBox.Text = "Start the Second HTML on a New PDF Page"
        Me.startNewPageCheckBox.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.label1.Location = New System.Drawing.Point(8, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(143, 15)
        Me.label1.TabIndex = 39
        Me.label1.Text = "HTML Merge Options"
        '
        'Merge_Table_of_Contents_Demo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.convertButtonPanel)
        Me.Controls.Add(Me.settingsPanel)
        Me.Controls.Add(Me.urlPanel)
        Me.Controls.Add(Me.descriptionPanel)
        Me.Controls.Add(Me.titlePanel)
        Me.Controls.Add(Me.demoBottomPanel)
        Me.Controls.Add(Me.demoTopPanel)
        Me.Controls.Add(Me.demoLeftPanel)
        Me.Controls.Add(Me.demoRightPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Name = "Merge_Table_of_Contents_Demo"
        Me.Size = New System.Drawing.Size(610, 650)
        Me.urlPanel.ResumeLayout(False)
        Me.urlPanel.PerformLayout()
        Me.descriptionPanel.ResumeLayout(False)
        Me.titlePanel.ResumeLayout(False)
        Me.titlePanel.PerformLayout()
        Me.convertButtonPanel.ResumeLayout(False)
        Me.settingsPanel.ResumeLayout(False)
        Me.settingsPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents urlPanel As System.Windows.Forms.Panel
    Private WithEvents viewSecondHtmlLinkLabel As System.Windows.Forms.LinkLabel
    Private WithEvents viewFirstHtmlLinkLabel As System.Windows.Forms.LinkLabel
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents enterUrlLabel As System.Windows.Forms.Label
    Private WithEvents secondUrlTextBox As System.Windows.Forms.TextBox
    Private WithEvents firstUrlTextBox As System.Windows.Forms.TextBox
    Private WithEvents descriptionPanel As System.Windows.Forms.Panel
    Private WithEvents descriptionLabel As System.Windows.Forms.Label
    Private WithEvents titlePanel As System.Windows.Forms.Panel
    Private WithEvents titleLabel As System.Windows.Forms.Label
    Private WithEvents demoBottomPanel As System.Windows.Forms.Panel
    Private WithEvents demoTopPanel As System.Windows.Forms.Panel
    Private WithEvents demoLeftPanel As System.Windows.Forms.Panel
    Private WithEvents demoRightPanel As System.Windows.Forms.Panel
    Private WithEvents convertButtonPanel As System.Windows.Forms.Panel
    Private WithEvents convertToPdfButton As System.Windows.Forms.Button
    Private WithEvents settingsPanel As System.Windows.Forms.Panel
    Private WithEvents autoTableOfContentsCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents includeSecondHtmlTocCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents includeFirstHtmlTocCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents startNewPageCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents label1 As System.Windows.Forms.Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Insert_PDF_Pages_Before_Table_of_Contents_Demo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Insert_PDF_Pages_Before_Table_of_Contents_Demo))
        Me.demoLeftPanel = New System.Windows.Forms.Panel()
        Me.demoRightPanel = New System.Windows.Forms.Panel()
        Me.demoBottomPanel = New System.Windows.Forms.Panel()
        Me.demoTopPanel = New System.Windows.Forms.Panel()
        Me.titlePanel = New System.Windows.Forms.Panel()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.descriptionPanel = New System.Windows.Forms.Panel()
        Me.descriptionLabel = New System.Windows.Forms.Label()
        Me.urlPanel = New System.Windows.Forms.Panel()
        Me.viewHtmlLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.enterUrlLabel = New System.Windows.Forms.Label()
        Me.urlTextBox = New System.Windows.Forms.TextBox()
        Me.settingsPanel = New System.Windows.Forms.Panel()
        Me.label6 = New System.Windows.Forms.Label()
        Me.pdfBeforeTextBox = New System.Windows.Forms.TextBox()
        Me.autoTableOfContentsCheckBox = New System.Windows.Forms.CheckBox()
        Me.convertButtonPanel = New System.Windows.Forms.Panel()
        Me.convertToPdfButton = New System.Windows.Forms.Button()
        Me.titlePanel.SuspendLayout()
        Me.descriptionPanel.SuspendLayout()
        Me.urlPanel.SuspendLayout()
        Me.settingsPanel.SuspendLayout()
        Me.convertButtonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'demoLeftPanel
        '
        Me.demoLeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.demoLeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.demoLeftPanel.Name = "demoLeftPanel"
        Me.demoLeftPanel.Size = New System.Drawing.Size(6, 644)
        Me.demoLeftPanel.TabIndex = 157
        '
        'demoRightPanel
        '
        Me.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.demoRightPanel.Location = New System.Drawing.Point(604, 0)
        Me.demoRightPanel.Name = "demoRightPanel"
        Me.demoRightPanel.Size = New System.Drawing.Size(6, 644)
        Me.demoRightPanel.TabIndex = 156
        '
        'demoBottomPanel
        '
        Me.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.demoBottomPanel.Location = New System.Drawing.Point(0, 644)
        Me.demoBottomPanel.Name = "demoBottomPanel"
        Me.demoBottomPanel.Size = New System.Drawing.Size(610, 6)
        Me.demoBottomPanel.TabIndex = 155
        '
        'demoTopPanel
        '
        Me.demoTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.demoTopPanel.Location = New System.Drawing.Point(6, 0)
        Me.demoTopPanel.Name = "demoTopPanel"
        Me.demoTopPanel.Size = New System.Drawing.Size(598, 6)
        Me.demoTopPanel.TabIndex = 163
        '
        'titlePanel
        '
        Me.titlePanel.Controls.Add(Me.titleLabel)
        Me.titlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlePanel.Location = New System.Drawing.Point(6, 6)
        Me.titlePanel.Name = "titlePanel"
        Me.titlePanel.Size = New System.Drawing.Size(598, 40)
        Me.titlePanel.TabIndex = 164
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.titleLabel.Location = New System.Drawing.Point(0, 10)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(321, 17)
        Me.titleLabel.TabIndex = 1
        Me.titleLabel.Text = "Insert PDF Pages Before Table of Contents"
        '
        'descriptionPanel
        '
        Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
        Me.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.descriptionPanel.Location = New System.Drawing.Point(6, 46)
        Me.descriptionPanel.Name = "descriptionPanel"
        Me.descriptionPanel.Size = New System.Drawing.Size(598, 71)
        Me.descriptionPanel.TabIndex = 165
        '
        'descriptionLabel
        '
        Me.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.descriptionLabel.Location = New System.Drawing.Point(0, 0)
        Me.descriptionLabel.Name = "descriptionLabel"
        Me.descriptionLabel.Size = New System.Drawing.Size(598, 71)
        Me.descriptionLabel.TabIndex = 0
        Me.descriptionLabel.Text = resources.GetString("descriptionLabel.Text")
        '
        'urlPanel
        '
        Me.urlPanel.Controls.Add(Me.viewHtmlLinkLabel)
        Me.urlPanel.Controls.Add(Me.enterUrlLabel)
        Me.urlPanel.Controls.Add(Me.urlTextBox)
        Me.urlPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.urlPanel.Location = New System.Drawing.Point(6, 117)
        Me.urlPanel.Name = "urlPanel"
        Me.urlPanel.Size = New System.Drawing.Size(598, 67)
        Me.urlPanel.TabIndex = 166
        '
        'viewHtmlLinkLabel
        '
        Me.viewHtmlLinkLabel.AutoSize = True
        Me.viewHtmlLinkLabel.Location = New System.Drawing.Point(514, 37)
        Me.viewHtmlLinkLabel.Name = "viewHtmlLinkLabel"
        Me.viewHtmlLinkLabel.Size = New System.Drawing.Size(70, 15)
        Me.viewHtmlLinkLabel.TabIndex = 46
        Me.viewHtmlLinkLabel.TabStop = True
        Me.viewHtmlLinkLabel.Text = "View HTML"
        '
        'enterUrlLabel
        '
        Me.enterUrlLabel.AutoSize = True
        Me.enterUrlLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.enterUrlLabel.Location = New System.Drawing.Point(6, 13)
        Me.enterUrlLabel.Name = "enterUrlLabel"
        Me.enterUrlLabel.Size = New System.Drawing.Size(266, 15)
        Me.enterUrlLabel.TabIndex = 42
        Me.enterUrlLabel.Text = "HTML Page URL or Local File to Convert"
        '
        'urlTextBox
        '
        Me.urlTextBox.Location = New System.Drawing.Point(8, 34)
        Me.urlTextBox.Name = "urlTextBox"
        Me.urlTextBox.Size = New System.Drawing.Size(500, 21)
        Me.urlTextBox.TabIndex = 45
        Me.urlTextBox.Text = "http://www.evopdf.com/DemoAppFiles/HTML_Files/Structured_HTML.html"
        '
        'settingsPanel
        '
        Me.settingsPanel.Controls.Add(Me.label6)
        Me.settingsPanel.Controls.Add(Me.pdfBeforeTextBox)
        Me.settingsPanel.Controls.Add(Me.autoTableOfContentsCheckBox)
        Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.settingsPanel.Location = New System.Drawing.Point(6, 184)
        Me.settingsPanel.Name = "settingsPanel"
        Me.settingsPanel.Size = New System.Drawing.Size(598, 112)
        Me.settingsPanel.TabIndex = 167
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.label6.Location = New System.Drawing.Point(6, 48)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(239, 15)
        Me.label6.TabIndex = 49
        Me.label6.Text = "PDF File to Insert Before Conversion"
        '
        'pdfBeforeTextBox
        '
        Me.pdfBeforeTextBox.Location = New System.Drawing.Point(9, 73)
        Me.pdfBeforeTextBox.Name = "pdfBeforeTextBox"
        Me.pdfBeforeTextBox.Size = New System.Drawing.Size(574, 21)
        Me.pdfBeforeTextBox.TabIndex = 50
        '
        'autoTableOfContentsCheckBox
        '
        Me.autoTableOfContentsCheckBox.AutoSize = True
        Me.autoTableOfContentsCheckBox.Checked = True
        Me.autoTableOfContentsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.autoTableOfContentsCheckBox.Location = New System.Drawing.Point(9, 15)
        Me.autoTableOfContentsCheckBox.Name = "autoTableOfContentsCheckBox"
        Me.autoTableOfContentsCheckBox.Size = New System.Drawing.Size(279, 19)
        Me.autoTableOfContentsCheckBox.TabIndex = 1
        Me.autoTableOfContentsCheckBox.Text = "Create a Table of Contents from H1 to H6 Tags"
        Me.autoTableOfContentsCheckBox.UseVisualStyleBackColor = True
        '
        'convertButtonPanel
        '
        Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
        Me.convertButtonPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.convertButtonPanel.Location = New System.Drawing.Point(6, 296)
        Me.convertButtonPanel.Name = "convertButtonPanel"
        Me.convertButtonPanel.Size = New System.Drawing.Size(598, 42)
        Me.convertButtonPanel.TabIndex = 168
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
        'Insert_PDF_Pages_Before_Table_of_Contents_Demo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.convertButtonPanel)
        Me.Controls.Add(Me.settingsPanel)
        Me.Controls.Add(Me.urlPanel)
        Me.Controls.Add(Me.descriptionPanel)
        Me.Controls.Add(Me.titlePanel)
        Me.Controls.Add(Me.demoTopPanel)
        Me.Controls.Add(Me.demoLeftPanel)
        Me.Controls.Add(Me.demoRightPanel)
        Me.Controls.Add(Me.demoBottomPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Name = "Insert_PDF_Pages_Before_Table_of_Contents_Demo"
        Me.Size = New System.Drawing.Size(610, 650)
        Me.titlePanel.ResumeLayout(False)
        Me.titlePanel.PerformLayout()
        Me.descriptionPanel.ResumeLayout(False)
        Me.urlPanel.ResumeLayout(False)
        Me.urlPanel.PerformLayout()
        Me.settingsPanel.ResumeLayout(False)
        Me.settingsPanel.PerformLayout()
        Me.convertButtonPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents demoLeftPanel As System.Windows.Forms.Panel
    Private WithEvents demoRightPanel As System.Windows.Forms.Panel
    Private WithEvents demoBottomPanel As System.Windows.Forms.Panel
    Private WithEvents demoTopPanel As System.Windows.Forms.Panel
    Private WithEvents titlePanel As System.Windows.Forms.Panel
    Private WithEvents titleLabel As System.Windows.Forms.Label
    Private WithEvents descriptionPanel As System.Windows.Forms.Panel
    Private WithEvents descriptionLabel As System.Windows.Forms.Label
    Private WithEvents urlPanel As System.Windows.Forms.Panel
    Private WithEvents viewHtmlLinkLabel As System.Windows.Forms.LinkLabel
    Private WithEvents enterUrlLabel As System.Windows.Forms.Label
    Private WithEvents urlTextBox As System.Windows.Forms.TextBox
    Private WithEvents settingsPanel As System.Windows.Forms.Panel
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents pdfBeforeTextBox As System.Windows.Forms.TextBox
    Private WithEvents autoTableOfContentsCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents convertButtonPanel As System.Windows.Forms.Panel
    Private WithEvents convertToPdfButton As System.Windows.Forms.Button

End Class

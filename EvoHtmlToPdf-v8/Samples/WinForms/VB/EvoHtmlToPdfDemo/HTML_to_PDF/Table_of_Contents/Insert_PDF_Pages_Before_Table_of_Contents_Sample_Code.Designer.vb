<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Insert_PDF_Pages_Before_Table_of_Contents_Sample_Code
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
        Me.codeSampleTopPanel = New System.Windows.Forms.Panel()
        Me.codeSampleBrowserPanel = New System.Windows.Forms.Panel()
        Me.codeSampleWebBrowser = New System.Windows.Forms.WebBrowser()
        Me.codeSampleSeparatorPanel = New System.Windows.Forms.Panel()
        Me.codeSampleTitlePanel = New System.Windows.Forms.Panel()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.codeSampleLeftPanel = New System.Windows.Forms.Panel()
        Me.codeSampleRightPanel = New System.Windows.Forms.Panel()
        Me.codeSampleBottomPanel = New System.Windows.Forms.Panel()
        Me.codeSampleBrowserPanel.SuspendLayout()
        Me.codeSampleTitlePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'codeSampleTopPanel
        '
        Me.codeSampleTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.codeSampleTopPanel.Location = New System.Drawing.Point(0, 0)
        Me.codeSampleTopPanel.Name = "codeSampleTopPanel"
        Me.codeSampleTopPanel.Size = New System.Drawing.Size(596, 6)
        Me.codeSampleTopPanel.TabIndex = 28
        '
        'codeSampleBrowserPanel
        '
        Me.codeSampleBrowserPanel.AutoScroll = True
        Me.codeSampleBrowserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.codeSampleBrowserPanel.Controls.Add(Me.codeSampleWebBrowser)
        Me.codeSampleBrowserPanel.Controls.Add(Me.codeSampleSeparatorPanel)
        Me.codeSampleBrowserPanel.Controls.Add(Me.codeSampleTitlePanel)
        Me.codeSampleBrowserPanel.Controls.Add(Me.codeSampleTopPanel)
        Me.codeSampleBrowserPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.codeSampleBrowserPanel.Location = New System.Drawing.Point(6, 0)
        Me.codeSampleBrowserPanel.Name = "codeSampleBrowserPanel"
        Me.codeSampleBrowserPanel.Size = New System.Drawing.Size(598, 644)
        Me.codeSampleBrowserPanel.TabIndex = 37
        '
        'codeSampleWebBrowser
        '
        Me.codeSampleWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.codeSampleWebBrowser.Location = New System.Drawing.Point(0, 48)
        Me.codeSampleWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.codeSampleWebBrowser.Name = "codeSampleWebBrowser"
        Me.codeSampleWebBrowser.Size = New System.Drawing.Size(596, 594)
        Me.codeSampleWebBrowser.TabIndex = 34
        Me.codeSampleWebBrowser.Visible = False
        '
        'codeSampleSeparatorPanel
        '
        Me.codeSampleSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.codeSampleSeparatorPanel.Location = New System.Drawing.Point(0, 41)
        Me.codeSampleSeparatorPanel.Name = "codeSampleSeparatorPanel"
        Me.codeSampleSeparatorPanel.Size = New System.Drawing.Size(596, 7)
        Me.codeSampleSeparatorPanel.TabIndex = 33
        '
        'codeSampleTitlePanel
        '
        Me.codeSampleTitlePanel.Controls.Add(Me.titleLabel)
        Me.codeSampleTitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.codeSampleTitlePanel.Location = New System.Drawing.Point(0, 6)
        Me.codeSampleTitlePanel.Name = "codeSampleTitlePanel"
        Me.codeSampleTitlePanel.Size = New System.Drawing.Size(596, 35)
        Me.codeSampleTitlePanel.TabIndex = 32
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.titleLabel.Location = New System.Drawing.Point(0, 10)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(321, 17)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Insert PDF Pages Before Table of Contents"
        '
        'codeSampleLeftPanel
        '
        Me.codeSampleLeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.codeSampleLeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.codeSampleLeftPanel.Name = "codeSampleLeftPanel"
        Me.codeSampleLeftPanel.Size = New System.Drawing.Size(6, 644)
        Me.codeSampleLeftPanel.TabIndex = 36
        '
        'codeSampleRightPanel
        '
        Me.codeSampleRightPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.codeSampleRightPanel.Location = New System.Drawing.Point(604, 0)
        Me.codeSampleRightPanel.Name = "codeSampleRightPanel"
        Me.codeSampleRightPanel.Size = New System.Drawing.Size(6, 644)
        Me.codeSampleRightPanel.TabIndex = 35
        '
        'codeSampleBottomPanel
        '
        Me.codeSampleBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.codeSampleBottomPanel.Location = New System.Drawing.Point(0, 644)
        Me.codeSampleBottomPanel.Name = "codeSampleBottomPanel"
        Me.codeSampleBottomPanel.Size = New System.Drawing.Size(610, 6)
        Me.codeSampleBottomPanel.TabIndex = 34
        '
        'Insert_PDF_Pages_Before_Table_of_Contents_Sample_Code
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.codeSampleBrowserPanel)
        Me.Controls.Add(Me.codeSampleLeftPanel)
        Me.Controls.Add(Me.codeSampleRightPanel)
        Me.Controls.Add(Me.codeSampleBottomPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Name = "Insert_PDF_Pages_Before_Table_of_Contents_Sample_Code"
        Me.Size = New System.Drawing.Size(610, 650)
        Me.codeSampleBrowserPanel.ResumeLayout(False)
        Me.codeSampleTitlePanel.ResumeLayout(False)
        Me.codeSampleTitlePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents codeSampleTopPanel As System.Windows.Forms.Panel
    Private WithEvents codeSampleBrowserPanel As System.Windows.Forms.Panel
    Private WithEvents codeSampleWebBrowser As System.Windows.Forms.WebBrowser
    Private WithEvents codeSampleSeparatorPanel As System.Windows.Forms.Panel
    Private WithEvents codeSampleTitlePanel As System.Windows.Forms.Panel
    Private WithEvents titleLabel As System.Windows.Forms.Label
    Private WithEvents codeSampleLeftPanel As System.Windows.Forms.Panel
    Private WithEvents codeSampleRightPanel As System.Windows.Forms.Panel
    Private WithEvents codeSampleBottomPanel As System.Windows.Forms.Panel

End Class

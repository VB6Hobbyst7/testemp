<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proxy_Options_Sample_Code
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
        Me.codeSampleWebBrowser = New System.Windows.Forms.WebBrowser()
        Me.codeSampleTitlePanel = New System.Windows.Forms.Panel()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.codeSampleTopPanel = New System.Windows.Forms.Panel()
        Me.codeSampleBrowserPanel = New System.Windows.Forms.Panel()
        Me.codeSampleSeparatorPanel = New System.Windows.Forms.Panel()
        Me.codeSampleLeftPanel = New System.Windows.Forms.Panel()
        Me.codeSampleRightPanel = New System.Windows.Forms.Panel()
        Me.codeSampleBottomPanel = New System.Windows.Forms.Panel()
        Me.codeSampleTitlePanel.SuspendLayout()
        Me.codeSampleBrowserPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'codeSampleWebBrowser
        '
        Me.codeSampleWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.codeSampleWebBrowser.Location = New System.Drawing.Point(0, 55)
        Me.codeSampleWebBrowser.MinimumSize = New System.Drawing.Size(23, 23)
        Me.codeSampleWebBrowser.Name = "codeSampleWebBrowser"
        Me.codeSampleWebBrowser.Size = New System.Drawing.Size(594, 586)
        Me.codeSampleWebBrowser.TabIndex = 34
        Me.codeSampleWebBrowser.Visible = False
        '
        'codeSampleTitlePanel
        '
        Me.codeSampleTitlePanel.Controls.Add(Me.titleLabel)
        Me.codeSampleTitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.codeSampleTitlePanel.Location = New System.Drawing.Point(0, 7)
        Me.codeSampleTitlePanel.Name = "codeSampleTitlePanel"
        Me.codeSampleTitlePanel.Size = New System.Drawing.Size(594, 40)
        Me.codeSampleTitlePanel.TabIndex = 32
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.titleLabel.Location = New System.Drawing.Point(0, 12)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(287, 17)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Access a HTML Page Through a Proxy"
        '
        'codeSampleTopPanel
        '
        Me.codeSampleTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.codeSampleTopPanel.Location = New System.Drawing.Point(0, 0)
        Me.codeSampleTopPanel.Name = "codeSampleTopPanel"
        Me.codeSampleTopPanel.Size = New System.Drawing.Size(594, 7)
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
        Me.codeSampleBrowserPanel.Location = New System.Drawing.Point(7, 0)
        Me.codeSampleBrowserPanel.Name = "codeSampleBrowserPanel"
        Me.codeSampleBrowserPanel.Size = New System.Drawing.Size(596, 643)
        Me.codeSampleBrowserPanel.TabIndex = 45
        '
        'codeSampleSeparatorPanel
        '
        Me.codeSampleSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.codeSampleSeparatorPanel.Location = New System.Drawing.Point(0, 47)
        Me.codeSampleSeparatorPanel.Name = "codeSampleSeparatorPanel"
        Me.codeSampleSeparatorPanel.Size = New System.Drawing.Size(594, 8)
        Me.codeSampleSeparatorPanel.TabIndex = 33
        '
        'codeSampleLeftPanel
        '
        Me.codeSampleLeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.codeSampleLeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.codeSampleLeftPanel.Name = "codeSampleLeftPanel"
        Me.codeSampleLeftPanel.Size = New System.Drawing.Size(7, 643)
        Me.codeSampleLeftPanel.TabIndex = 44
        '
        'codeSampleRightPanel
        '
        Me.codeSampleRightPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.codeSampleRightPanel.Location = New System.Drawing.Point(603, 0)
        Me.codeSampleRightPanel.Name = "codeSampleRightPanel"
        Me.codeSampleRightPanel.Size = New System.Drawing.Size(7, 643)
        Me.codeSampleRightPanel.TabIndex = 43
        '
        'codeSampleBottomPanel
        '
        Me.codeSampleBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.codeSampleBottomPanel.Location = New System.Drawing.Point(0, 643)
        Me.codeSampleBottomPanel.Name = "codeSampleBottomPanel"
        Me.codeSampleBottomPanel.Size = New System.Drawing.Size(610, 7)
        Me.codeSampleBottomPanel.TabIndex = 42
        '
        'Proxy_Options_Sample_Code
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.codeSampleBrowserPanel)
        Me.Controls.Add(Me.codeSampleLeftPanel)
        Me.Controls.Add(Me.codeSampleRightPanel)
        Me.Controls.Add(Me.codeSampleBottomPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Name = "Proxy_Options_Sample_Code"
        Me.Size = New System.Drawing.Size(610, 650)
        Me.codeSampleTitlePanel.ResumeLayout(False)
        Me.codeSampleTitlePanel.PerformLayout()
        Me.codeSampleBrowserPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents codeSampleWebBrowser As System.Windows.Forms.WebBrowser
    Private WithEvents codeSampleTitlePanel As System.Windows.Forms.Panel
    Private WithEvents titleLabel As System.Windows.Forms.Label
    Private WithEvents codeSampleTopPanel As System.Windows.Forms.Panel
    Private WithEvents codeSampleBrowserPanel As System.Windows.Forms.Panel
    Private WithEvents codeSampleSeparatorPanel As System.Windows.Forms.Panel
    Private WithEvents codeSampleLeftPanel As System.Windows.Forms.Panel
    Private WithEvents codeSampleRightPanel As System.Windows.Forms.Panel
    Private WithEvents codeSampleBottomPanel As System.Windows.Forms.Panel

End Class

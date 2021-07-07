<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proxy_Options_Description
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
        Me.descriptionTopPanel = New System.Windows.Forms.Panel()
        Me.descriptionPanel = New System.Windows.Forms.Panel()
        Me.descriptionWebBrowser = New System.Windows.Forms.WebBrowser()
        Me.descriptionSeparatorPanel = New System.Windows.Forms.Panel()
        Me.descriptionTitlePanel = New System.Windows.Forms.Panel()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.descriptionLeftPanel = New System.Windows.Forms.Panel()
        Me.descriptionRightPanel = New System.Windows.Forms.Panel()
        Me.descriptionBottomPane = New System.Windows.Forms.Panel()
        Me.descriptionPanel.SuspendLayout()
        Me.descriptionTitlePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'descriptionTopPanel
        '
        Me.descriptionTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.descriptionTopPanel.Location = New System.Drawing.Point(0, 0)
        Me.descriptionTopPanel.Name = "descriptionTopPanel"
        Me.descriptionTopPanel.Size = New System.Drawing.Size(598, 6)
        Me.descriptionTopPanel.TabIndex = 26
        '
        'descriptionPanel
        '
        Me.descriptionPanel.AutoScroll = True
        Me.descriptionPanel.Controls.Add(Me.descriptionWebBrowser)
        Me.descriptionPanel.Controls.Add(Me.descriptionSeparatorPanel)
        Me.descriptionPanel.Controls.Add(Me.descriptionTitlePanel)
        Me.descriptionPanel.Controls.Add(Me.descriptionTopPanel)
        Me.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.descriptionPanel.Location = New System.Drawing.Point(6, 0)
        Me.descriptionPanel.Name = "descriptionPanel"
        Me.descriptionPanel.Size = New System.Drawing.Size(598, 644)
        Me.descriptionPanel.TabIndex = 43
        '
        'descriptionWebBrowser
        '
        Me.descriptionWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.descriptionWebBrowser.Location = New System.Drawing.Point(0, 51)
        Me.descriptionWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.descriptionWebBrowser.Name = "descriptionWebBrowser"
        Me.descriptionWebBrowser.Size = New System.Drawing.Size(598, 593)
        Me.descriptionWebBrowser.TabIndex = 32
        Me.descriptionWebBrowser.Visible = False
        '
        'descriptionSeparatorPanel
        '
        Me.descriptionSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.descriptionSeparatorPanel.Location = New System.Drawing.Point(0, 41)
        Me.descriptionSeparatorPanel.Name = "descriptionSeparatorPanel"
        Me.descriptionSeparatorPanel.Size = New System.Drawing.Size(598, 10)
        Me.descriptionSeparatorPanel.TabIndex = 31
        '
        'descriptionTitlePanel
        '
        Me.descriptionTitlePanel.Controls.Add(Me.titleLabel)
        Me.descriptionTitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.descriptionTitlePanel.Location = New System.Drawing.Point(0, 6)
        Me.descriptionTitlePanel.Name = "descriptionTitlePanel"
        Me.descriptionTitlePanel.Size = New System.Drawing.Size(598, 35)
        Me.descriptionTitlePanel.TabIndex = 30
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.titleLabel.Location = New System.Drawing.Point(0, 10)
        Me.titleLabel.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(287, 17)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Access a HTML Page Through a Proxy"
        '
        'descriptionLeftPanel
        '
        Me.descriptionLeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.descriptionLeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.descriptionLeftPanel.Name = "descriptionLeftPanel"
        Me.descriptionLeftPanel.Size = New System.Drawing.Size(6, 644)
        Me.descriptionLeftPanel.TabIndex = 42
        '
        'descriptionRightPanel
        '
        Me.descriptionRightPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.descriptionRightPanel.Location = New System.Drawing.Point(604, 0)
        Me.descriptionRightPanel.Name = "descriptionRightPanel"
        Me.descriptionRightPanel.Size = New System.Drawing.Size(6, 644)
        Me.descriptionRightPanel.TabIndex = 41
        '
        'descriptionBottomPane
        '
        Me.descriptionBottomPane.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.descriptionBottomPane.Location = New System.Drawing.Point(0, 644)
        Me.descriptionBottomPane.Name = "descriptionBottomPane"
        Me.descriptionBottomPane.Size = New System.Drawing.Size(610, 6)
        Me.descriptionBottomPane.TabIndex = 40
        '
        'Proxy_Options_Description
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.descriptionPanel)
        Me.Controls.Add(Me.descriptionLeftPanel)
        Me.Controls.Add(Me.descriptionRightPanel)
        Me.Controls.Add(Me.descriptionBottomPane)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Name = "Proxy_Options_Description"
        Me.Size = New System.Drawing.Size(610, 650)
        Me.descriptionPanel.ResumeLayout(False)
        Me.descriptionTitlePanel.ResumeLayout(False)
        Me.descriptionTitlePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents descriptionTopPanel As System.Windows.Forms.Panel
    Private WithEvents descriptionPanel As System.Windows.Forms.Panel
    Private WithEvents descriptionWebBrowser As System.Windows.Forms.WebBrowser
    Private WithEvents descriptionSeparatorPanel As System.Windows.Forms.Panel
    Private WithEvents descriptionTitlePanel As System.Windows.Forms.Panel
    Private WithEvents titleLabel As System.Windows.Forms.Label
    Private WithEvents descriptionLeftPanel As System.Windows.Forms.Panel
    Private WithEvents descriptionRightPanel As System.Windows.Forms.Panel
    Private WithEvents descriptionBottomPane As System.Windows.Forms.Panel

End Class

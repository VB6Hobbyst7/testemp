Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security
	Partial Public Class PDF_Permissions_and_Password_Description
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
            Me.descriptionPanel = New System.Windows.Forms.Panel()
            Me.descriptionWebBrowser = New System.Windows.Forms.WebBrowser()
            Me.descriptionSeparatorPanel = New System.Windows.Forms.Panel()
            Me.descriptionTitlePanel = New System.Windows.Forms.Panel()
            Me.titleLabel = New System.Windows.Forms.Label()
            Me.descriptionLeftPanel = New System.Windows.Forms.Panel()
            Me.descriptionRightPanel = New System.Windows.Forms.Panel()
            Me.descriptionBottomPane = New System.Windows.Forms.Panel()
            Me.descriptionTopPanel = New System.Windows.Forms.Panel()
            Me.descriptionPanel.SuspendLayout()
            Me.descriptionTitlePanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'descriptionPanel
            '
            Me.descriptionPanel.AutoScroll = True
            Me.descriptionPanel.Controls.Add(Me.descriptionWebBrowser)
            Me.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.descriptionPanel.Location = New System.Drawing.Point(6, 51)
            Me.descriptionPanel.Name = "descriptionPanel"
            Me.descriptionPanel.Size = New System.Drawing.Size(598, 593)
            Me.descriptionPanel.TabIndex = 24
            '
            'descriptionWebBrowser
            '
            Me.descriptionWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
            Me.descriptionWebBrowser.Location = New System.Drawing.Point(0, 0)
            Me.descriptionWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
            Me.descriptionWebBrowser.Name = "descriptionWebBrowser"
            Me.descriptionWebBrowser.Size = New System.Drawing.Size(598, 593)
            Me.descriptionWebBrowser.TabIndex = 0
            Me.descriptionWebBrowser.Visible = False
            '
            'descriptionSeparatorPanel
            '
            Me.descriptionSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.descriptionSeparatorPanel.Location = New System.Drawing.Point(6, 41)
            Me.descriptionSeparatorPanel.Name = "descriptionSeparatorPanel"
            Me.descriptionSeparatorPanel.Size = New System.Drawing.Size(598, 10)
            Me.descriptionSeparatorPanel.TabIndex = 23
            '
            'descriptionTitlePanel
            '
            Me.descriptionTitlePanel.Controls.Add(Me.titleLabel)
            Me.descriptionTitlePanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.descriptionTitlePanel.Location = New System.Drawing.Point(6, 6)
            Me.descriptionTitlePanel.Name = "descriptionTitlePanel"
            Me.descriptionTitlePanel.Size = New System.Drawing.Size(598, 35)
            Me.descriptionTitlePanel.TabIndex = 22
            '
            'titleLabel
            '
            Me.titleLabel.AutoSize = True
            Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.titleLabel.Location = New System.Drawing.Point(0, 10)
            Me.titleLabel.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
            Me.titleLabel.Name = "titleLabel"
            Me.titleLabel.Size = New System.Drawing.Size(509, 17)
            Me.titleLabel.TabIndex = 0
            Me.titleLabel.Text = "Set Permissions and Password Protect the Generated PDF Document"
            '
            'descriptionLeftPanel
            '
            Me.descriptionLeftPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.descriptionLeftPanel.Location = New System.Drawing.Point(0, 6)
            Me.descriptionLeftPanel.Name = "descriptionLeftPanel"
            Me.descriptionLeftPanel.Size = New System.Drawing.Size(6, 638)
            Me.descriptionLeftPanel.TabIndex = 21
            '
            'descriptionRightPanel
            '
            Me.descriptionRightPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.descriptionRightPanel.Location = New System.Drawing.Point(604, 6)
            Me.descriptionRightPanel.Name = "descriptionRightPanel"
            Me.descriptionRightPanel.Size = New System.Drawing.Size(6, 638)
            Me.descriptionRightPanel.TabIndex = 20
            '
            'descriptionBottomPane
            '
            Me.descriptionBottomPane.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.descriptionBottomPane.Location = New System.Drawing.Point(0, 644)
            Me.descriptionBottomPane.Name = "descriptionBottomPane"
            Me.descriptionBottomPane.Size = New System.Drawing.Size(610, 6)
            Me.descriptionBottomPane.TabIndex = 19
            '
            'descriptionTopPanel
            '
            Me.descriptionTopPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.descriptionTopPanel.Location = New System.Drawing.Point(0, 0)
            Me.descriptionTopPanel.Name = "descriptionTopPanel"
            Me.descriptionTopPanel.Size = New System.Drawing.Size(610, 6)
            Me.descriptionTopPanel.TabIndex = 18
            '
            'PDF_Permissions_and_Password_Description
            '
            Me.Controls.Add(Me.descriptionPanel)
            Me.Controls.Add(Me.descriptionSeparatorPanel)
            Me.Controls.Add(Me.descriptionTitlePanel)
            Me.Controls.Add(Me.descriptionLeftPanel)
            Me.Controls.Add(Me.descriptionRightPanel)
            Me.Controls.Add(Me.descriptionBottomPane)
            Me.Controls.Add(Me.descriptionTopPanel)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.Name = "PDF_Permissions_and_Password_Description"
            Me.Size = New System.Drawing.Size(610, 650)
            Me.descriptionPanel.ResumeLayout(False)
            Me.descriptionTitlePanel.ResumeLayout(False)
            Me.descriptionTitlePanel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private descriptionPanel As Panel
		Private descriptionWebBrowser As WebBrowser
		Private descriptionSeparatorPanel As Panel
		Private descriptionTitlePanel As Panel
		Private titleLabel As Label
		Private descriptionLeftPanel As Panel
		Private descriptionRightPanel As Panel
		Private descriptionBottomPane As Panel
		Private descriptionTopPanel As Panel
	End Class
End Namespace

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Page_Breaks
	Partial Public Class Avoid_Page_Breaks_Inside_HTML_Elements_Using_API_Sample_Code
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
            Me.codeSampleBrowserPanel = New System.Windows.Forms.Panel()
            Me.codeSampleWebBrowser = New System.Windows.Forms.WebBrowser()
            Me.codeSampleTitlePanel = New System.Windows.Forms.Panel()
            Me.titleLabel = New System.Windows.Forms.Label()
            Me.codeSampleLeftPanel = New System.Windows.Forms.Panel()
            Me.codeSampleRightPanel = New System.Windows.Forms.Panel()
            Me.codeSampleBottomPanel = New System.Windows.Forms.Panel()
            Me.codeSampleTopPanel = New System.Windows.Forms.Panel()
            Me.codeSampleBrowserPanel.SuspendLayout()
            Me.codeSampleTitlePanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'codeSampleBrowserPanel
            '
            Me.codeSampleBrowserPanel.AutoScroll = True
            Me.codeSampleBrowserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.codeSampleBrowserPanel.Controls.Add(Me.codeSampleWebBrowser)
            Me.codeSampleBrowserPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.codeSampleBrowserPanel.Location = New System.Drawing.Point(6, 41)
            Me.codeSampleBrowserPanel.Name = "codeSampleBrowserPanel"
            Me.codeSampleBrowserPanel.Size = New System.Drawing.Size(598, 693)
            Me.codeSampleBrowserPanel.TabIndex = 32
            '
            'codeSampleWebBrowser
            '
            Me.codeSampleWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
            Me.codeSampleWebBrowser.Location = New System.Drawing.Point(0, 0)
            Me.codeSampleWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
            Me.codeSampleWebBrowser.Name = "codeSampleWebBrowser"
            Me.codeSampleWebBrowser.Size = New System.Drawing.Size(596, 691)
            Me.codeSampleWebBrowser.TabIndex = 11
            Me.codeSampleWebBrowser.Visible = False
            '
            'codeSampleTitlePanel
            '
            Me.codeSampleTitlePanel.Controls.Add(Me.titleLabel)
            Me.codeSampleTitlePanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.codeSampleTitlePanel.Location = New System.Drawing.Point(6, 6)
            Me.codeSampleTitlePanel.Name = "codeSampleTitlePanel"
            Me.codeSampleTitlePanel.Size = New System.Drawing.Size(598, 35)
            Me.codeSampleTitlePanel.TabIndex = 31
            '
            'titleLabel
            '
            Me.titleLabel.AutoSize = True
            Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.titleLabel.Location = New System.Drawing.Point(0, 10)
            Me.titleLabel.Name = "titleLabel"
            Me.titleLabel.Size = New System.Drawing.Size(386, 17)
            Me.titleLabel.TabIndex = 0
            Me.titleLabel.Text = "Avoid Page Breaks Inside HTML Elements Using API"
            '
            'codeSampleLeftPanel
            '
            Me.codeSampleLeftPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.codeSampleLeftPanel.Location = New System.Drawing.Point(0, 6)
            Me.codeSampleLeftPanel.Name = "codeSampleLeftPanel"
            Me.codeSampleLeftPanel.Size = New System.Drawing.Size(6, 728)
            Me.codeSampleLeftPanel.TabIndex = 30
            '
            'codeSampleRightPanel
            '
            Me.codeSampleRightPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.codeSampleRightPanel.Location = New System.Drawing.Point(604, 6)
            Me.codeSampleRightPanel.Name = "codeSampleRightPanel"
            Me.codeSampleRightPanel.Size = New System.Drawing.Size(6, 728)
            Me.codeSampleRightPanel.TabIndex = 29
            '
            'codeSampleBottomPanel
            '
            Me.codeSampleBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.codeSampleBottomPanel.Location = New System.Drawing.Point(0, 734)
            Me.codeSampleBottomPanel.Name = "codeSampleBottomPanel"
            Me.codeSampleBottomPanel.Size = New System.Drawing.Size(610, 6)
            Me.codeSampleBottomPanel.TabIndex = 28
            '
            'codeSampleTopPanel
            '
            Me.codeSampleTopPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.codeSampleTopPanel.Location = New System.Drawing.Point(0, 0)
            Me.codeSampleTopPanel.Name = "codeSampleTopPanel"
            Me.codeSampleTopPanel.Size = New System.Drawing.Size(610, 6)
            Me.codeSampleTopPanel.TabIndex = 27
            '
            'Avoid_Page_Breaks_Inside_HTML_Elements_Using_API_Sample_Code
            '
            Me.Controls.Add(Me.codeSampleBrowserPanel)
            Me.Controls.Add(Me.codeSampleTitlePanel)
            Me.Controls.Add(Me.codeSampleLeftPanel)
            Me.Controls.Add(Me.codeSampleRightPanel)
            Me.Controls.Add(Me.codeSampleBottomPanel)
            Me.Controls.Add(Me.codeSampleTopPanel)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.Name = "Avoid_Page_Breaks_Inside_HTML_Elements_Using_API_Sample_Code"
            Me.Size = New System.Drawing.Size(610, 740)
            Me.codeSampleBrowserPanel.ResumeLayout(False)
            Me.codeSampleTitlePanel.ResumeLayout(False)
            Me.codeSampleTitlePanel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private codeSampleBrowserPanel As Panel
		Private codeSampleWebBrowser As WebBrowser
		Private codeSampleTitlePanel As Panel
		Private titleLabel As Label
		Private codeSampleLeftPanel As Panel
		Private codeSampleRightPanel As Panel
		Private codeSampleBottomPanel As Panel
		Private codeSampleTopPanel As Panel
	End Class
End Namespace

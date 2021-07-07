Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class Partially_Convert_HTML_Description
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
			Me.descriptionBottomPane = New Panel()
			Me.descriptionTopPanel = New Panel()
			Me.descriptionLeftPanel = New Panel()
			Me.descriptionRightPanel = New Panel()
			Me.descriptionPanel = New Panel()
			Me.descriptionWebBrowser = New WebBrowser()
			Me.descriptionSeparatorPanel = New Panel()
			Me.descriptionTitlePanel = New Panel()
			Me.titleLabel = New Label()
			Me.descriptionPanel.SuspendLayout()
			Me.descriptionTitlePanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' descriptionBottomPane
			' 
			Me.descriptionBottomPane.Dock = DockStyle.Bottom
			Me.descriptionBottomPane.Location = New Point(0, 743)
			Me.descriptionBottomPane.Name = "descriptionBottomPane"
			Me.descriptionBottomPane.Size = New Size(610, 6)
			Me.descriptionBottomPane.TabIndex = 12
			' 
			' descriptionTopPanel
			' 
			Me.descriptionTopPanel.Dock = DockStyle.Top
			Me.descriptionTopPanel.Location = New Point(0, 0)
			Me.descriptionTopPanel.Name = "descriptionTopPanel"
			Me.descriptionTopPanel.Size = New Size(610, 6)
			Me.descriptionTopPanel.TabIndex = 11
			' 
			' descriptionLeftPanel
			' 
			Me.descriptionLeftPanel.Dock = DockStyle.Left
			Me.descriptionLeftPanel.Location = New Point(0, 7)
			Me.descriptionLeftPanel.Name = "descriptionLeftPanel"
			Me.descriptionLeftPanel.Size = New Size(6, 736)
			Me.descriptionLeftPanel.TabIndex = 15
			' 
			' descriptionRightPanel
			' 
			Me.descriptionRightPanel.Dock = DockStyle.Right
			Me.descriptionRightPanel.Location = New Point(604, 7)
			Me.descriptionRightPanel.Name = "descriptionRightPanel"
			Me.descriptionRightPanel.Size = New Size(6, 736)
			Me.descriptionRightPanel.TabIndex = 14
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.AutoScroll = True
			Me.descriptionPanel.Controls.Add(Me.descriptionWebBrowser)
			Me.descriptionPanel.Dock = DockStyle.Fill
			Me.descriptionPanel.Location = New Point(6, 52)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 691)
			Me.descriptionPanel.TabIndex = 23
			' 
			' descriptionWebBrowser
			' 
			Me.descriptionWebBrowser.Dock = DockStyle.Fill
			Me.descriptionWebBrowser.Location = New Point(0, 0)
			Me.descriptionWebBrowser.MinimumSize = New Size(20, 20)
			Me.descriptionWebBrowser.Name = "descriptionWebBrowser"
			Me.descriptionWebBrowser.Size = New Size(598, 691)
			Me.descriptionWebBrowser.TabIndex = 0
			Me.descriptionWebBrowser.Visible = False
			' 
			' descriptionSeparatorPanel
			' 
			Me.descriptionSeparatorPanel.Dock = DockStyle.Top
			Me.descriptionSeparatorPanel.Location = New Point(6, 42)
			Me.descriptionSeparatorPanel.Name = "descriptionSeparatorPanel"
			Me.descriptionSeparatorPanel.Size = New Size(598, 10)
			Me.descriptionSeparatorPanel.TabIndex = 22
			' 
			' descriptionTitlePanel
			' 
			Me.descriptionTitlePanel.Controls.Add(Me.titleLabel)
			Me.descriptionTitlePanel.Dock = DockStyle.Top
			Me.descriptionTitlePanel.Location = New Point(6, 7)
			Me.descriptionTitlePanel.Name = "descriptionTitlePanel"
			Me.descriptionTitlePanel.Size = New Size(598, 35)
			Me.descriptionTitlePanel.TabIndex = 21
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Margin = New Padding(0, 0, 3, 0)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(285, 17)
			Me.titleLabel.TabIndex = 0
			Me.titleLabel.Text = "Partially Convert a HTML Page to PDF"
			' 
			' Partially_Convert_HTML_Description
			' 
			Me.AutoScaleDimensions = New SizeF(7F, 15F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScroll = True
			Me.Controls.Add(Me.descriptionPanel)
			Me.Controls.Add(Me.descriptionSeparatorPanel)
			Me.Controls.Add(Me.descriptionTitlePanel)
			Me.Controls.Add(Me.descriptionLeftPanel)
			Me.Controls.Add(Me.descriptionRightPanel)
			Me.Controls.Add(Me.descriptionBottomPane)
			Me.Controls.Add(Me.descriptionTopPanel)
			Me.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.Name = "Partially_Convert_HTML_Description"
			Me.Size = New Size(610, 650)
'			Me.Load += New System.EventHandler(Me.Partially_Convert_HTML_Description_Load)
			Me.descriptionPanel.ResumeLayout(False)
			Me.descriptionTitlePanel.ResumeLayout(False)
			Me.descriptionTitlePanel.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private descriptionBottomPane As Panel
		Private descriptionTopPanel As Panel
		Private descriptionLeftPanel As Panel
		Private descriptionRightPanel As Panel
		Private descriptionPanel As Panel
		Private descriptionWebBrowser As WebBrowser
		Private descriptionSeparatorPanel As Panel
		Private descriptionTitlePanel As Panel
		Private titleLabel As Label
	End Class
End Namespace

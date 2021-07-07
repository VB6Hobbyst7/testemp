Namespace EvoHtmlToPdfDemo
	Partial Public Class demoForm
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Getting Started with HTML to PDF")
            Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HTML Content Destination and Scaling in PDF")
            Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Merge Multiple HTML Pages into a Single PDF")
            Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Merge HTML with Existing PDF Documents")
            Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Partially Convert of a HTML Page to PDF")
            Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Repeat HTML Table Header and Footer in PDF")
            Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add HTML in Header and Footer")
            Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Page Numbering in HTML")
            Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Change Header and Footer per Page")
            Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Header and Footer in External PDFs")
            Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Merge Multiple HTMLs into a Single PDF")
            Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auto Resize Header and Footer")
            Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Headers and Footers", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12})
            Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Insert Page Breaks in PDF Using CSS")
            Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Avoid Page Break Inside Elements Using CSS")
            Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Insert Page Breaks in PDF Using API")
            Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Avoid Page Break Inside Elements Using API")
            Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Avoid Page Breaks Inside Images Using API")
            Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Page Breaks Control", New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18})
            Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Use Different Styles for Screen and Print")
            Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Screen and Print Media Types", New System.Windows.Forms.TreeNode() {TreeNode20})
            Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Select Conversion Triggering Mode")
            Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Conversion Triggering Modes", New System.Windows.Forms.TreeNode() {TreeNode22})
            Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auto Create Hierachical Bookmarks")
            Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Select in API the Elements to Bookmark")
            Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Select in HTML the Elements to Bookmark")
            Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hierachical Bookmarks", New System.Windows.Forms.TreeNode() {TreeNode24, TreeNode25, TreeNode26})
            Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auto Create a Table of Contents")
            Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Define in HTML the Table of Contents Items")
            Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Table of Contents for Multiple HTMLs")
            Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Insert PDF Before Table of Contents")
            Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Table of Contents", New System.Windows.Forms.TreeNode() {TreeNode28, TreeNode29, TreeNode30, TreeNode31})
            Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auto Create a Fillable PDF Form")
            Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Define in HTML the PDF Form Fields")
            Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Live PDF Forms", New System.Windows.Forms.TreeNode() {TreeNode33, TreeNode34})
            Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Convert HTML with SVG to PDF")
            Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Convert HTML with Web Fonts to PDF")
            Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HTML5 Features", New System.Windows.Forms.TreeNode() {TreeNode36, TreeNode37})
            Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Access HTML Pages with GET and POST")
            Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Access HTML Pages Through a Proxy")
            Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HTTP GET and POST, Proxy Options", New System.Windows.Forms.TreeNode() {TreeNode39, TreeNode40})
            Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add HTTP Headers to HTML Page Request")
            Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Cookies to HTML Page Request")
            Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HTTP Headers and Cookies", New System.Windows.Forms.TreeNode() {TreeNode42, TreeNode43})
            Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Embed Fonts in PDF Document")
            Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Embed Web Fonts in PDF Document")
            Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fonts Embedding", New System.Windows.Forms.TreeNode() {TreeNode45, TreeNode46})
            Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Select in API the HTML Elements to Retrieve")
            Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Select in HTML the Elements to Retrieve")
            Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HTML Elements Location in PDF", New System.Windows.Forms.TreeNode() {TreeNode48, TreeNode49})
            Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Use API to Select HTML Elements to Hide")
            Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Define in HTML the Elements to Hide")
            Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HTML Elements Visibility in PDF", New System.Windows.Forms.TreeNode() {TreeNode51, TreeNode52})
            Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Convert URI Links from HTML to PDF")
            Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Define Custom URI Links in HTML")
            Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("URI Links in PDF", New System.Windows.Forms.TreeNode() {TreeNode54, TreeNode55})
            Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Convert Internal Links from HTML to PDF")
            Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Define Custom Internal Links in HTML")
            Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Internal Links in PDF", New System.Windows.Forms.TreeNode() {TreeNode57, TreeNode58})
            Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Create File Links and Attachments in PDF")
            Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File Links and Attachments", New System.Windows.Forms.TreeNode() {TreeNode60})
            Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Create Text Notes in Generated PDF")
            Dim TreeNode63 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Text Notes in PDF", New System.Windows.Forms.TreeNode() {TreeNode62})
            Dim TreeNode64 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Execute JavaScript when Document is Opened")
            Dim TreeNode65 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Go To a Page when Document is Opened")
            Dim TreeNode66 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Execute JavaScript when a Button is Clicked")
            Dim TreeNode67 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PDF Actions", New System.Windows.Forms.TreeNode() {TreeNode64, TreeNode65, TreeNode66})
            Dim TreeNode68 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add HTML to PDF Elements to PDF")
            Dim TreeNode69 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HTML to PDF Elements", New System.Windows.Forms.TreeNode() {TreeNode68})
            Dim TreeNode70 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add HTML to Image Elements to PDF")
            Dim TreeNode71 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HTML to Image Elements", New System.Windows.Forms.TreeNode() {TreeNode70})
            Dim TreeNode72 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set Scaling and JPEG Compression Level")
            Dim TreeNode73 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Replace Images with Higher Quality Images")
            Dim TreeNode74 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Images Quality in Generated PDF", New System.Windows.Forms.TreeNode() {TreeNode72, TreeNode73})
            Dim TreeNode75 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Convert HTML with Flash to PDF")
            Dim TreeNode76 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Flash and Extensions Support", New System.Windows.Forms.TreeNode() {TreeNode75})
            Dim TreeNode77 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Watermarks and Stamps in PDF")
            Dim TreeNode78 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Watermarks and Stamps", New System.Windows.Forms.TreeNode() {TreeNode77})
            Dim TreeNode79 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Elements in PDF Page Background")
            Dim TreeNode80 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Elements Over PDF Page Main Content")
            Dim TreeNode81 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PDF Background and Foreground", New System.Windows.Forms.TreeNode() {TreeNode79, TreeNode80})
            Dim TreeNode82 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Create PDF/A and PDF/X Documents")
            Dim TreeNode83 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PDF/A and PDF/X Standards", New System.Windows.Forms.TreeNode() {TreeNode82})
            Dim TreeNode84 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Create CMYK and GrayScale PDF Documents")
            Dim TreeNode85 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CMYK and GrayScale Color Spaces", New System.Windows.Forms.TreeNode() {TreeNode84})
            Dim TreeNode86 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set Layout, Mode, Menus and Toolbars")
            Dim TreeNode87 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set Initial Zoom Level")
            Dim TreeNode88 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PDF Viewer Preferences", New System.Windows.Forms.TreeNode() {TreeNode86, TreeNode87})
            Dim TreeNode89 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set PDF Permissions and Password")
            Dim TreeNode90 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Digitally Sign the Generated PDF")
            Dim TreeNode91 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PDF Security Features", New System.Windows.Forms.TreeNode() {TreeNode89, TreeNode90})
            Dim TreeNode92 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HTML to PDF Converter", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode13, TreeNode19, TreeNode21, TreeNode23, TreeNode27, TreeNode32, TreeNode35, TreeNode38, TreeNode41, TreeNode44, TreeNode47, TreeNode50, TreeNode53, TreeNode56, TreeNode59, TreeNode61, TreeNode63, TreeNode67, TreeNode69, TreeNode71, TreeNode74, TreeNode76, TreeNode78, TreeNode81, TreeNode83, TreeNode85, TreeNode88, TreeNode91})
            Dim TreeNode93 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Convert HTML to a Raster Image")
            Dim TreeNode94 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Convert HTML to SVG Vector Image")
            Dim TreeNode95 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HTML to Image Converter", New System.Windows.Forms.TreeNode() {TreeNode93, TreeNode94})
            Dim TreeNode96 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Create PDF Documents")
            Dim TreeNode97 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HTML to PDF Elements")
            Dim TreeNode98 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HTML to Image Elements")
            Dim TreeNode99 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Text Elements")
            Dim TreeNode100 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Graphic Elements")
            Dim TreeNode101 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Image Elements")
            Dim TreeNode102 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add HTML in Header and Footer")
            Dim TreeNode103 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Page Numbering in HTML")
            Dim TreeNode104 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Change Header and Footer per Page")
            Dim TreeNode105 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Header and Footer in External PDFs")
            Dim TreeNode106 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auto Resize Header and Footer")
            Dim TreeNode107 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Headers and Footers", New System.Windows.Forms.TreeNode() {TreeNode102, TreeNode103, TreeNode104, TreeNode105, TreeNode106})
            Dim TreeNode108 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bookmarks")
            Dim TreeNode109 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PDF Forms")
            Dim TreeNode110 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("URI Links")
            Dim TreeNode111 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Internal Links")
            Dim TreeNode112 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File Links")
            Dim TreeNode113 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File Attachments")
            Dim TreeNode114 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Text Notes")
            Dim TreeNode115 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Execute JavaScript when Document is Opened")
            Dim TreeNode116 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Go To a Page when Document is Opened")
            Dim TreeNode117 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Execute JavaScript when a Button is Clicked")
            Dim TreeNode118 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PDF Actions", New System.Windows.Forms.TreeNode() {TreeNode115, TreeNode116, TreeNode117})
            Dim TreeNode119 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set Layout, Mode, Menus and Toolbars")
            Dim TreeNode120 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set Initial Zoom Level")
            Dim TreeNode121 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Viewer Preferences", New System.Windows.Forms.TreeNode() {TreeNode119, TreeNode120})
            Dim TreeNode122 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set PDF Permissions and Password")
            Dim TreeNode123 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Digitally Sign a PDF Document")
            Dim TreeNode124 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PDF Security", New System.Windows.Forms.TreeNode() {TreeNode122, TreeNode123})
            Dim TreeNode125 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PDF Creator", New System.Windows.Forms.TreeNode() {TreeNode96, TreeNode97, TreeNode98, TreeNode99, TreeNode100, TreeNode101, TreeNode107, TreeNode108, TreeNode109, TreeNode110, TreeNode111, TreeNode112, TreeNode113, TreeNode114, TreeNode118, TreeNode121, TreeNode124})
            Dim TreeNode126 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Merge PDF Documents")
            Dim TreeNode127 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Split PDF Documents")
            Dim TreeNode128 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stamp PDF Documents")
            Dim TreeNode129 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fill PDF Forms")
            Dim TreeNode130 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PDF Editor", New System.Windows.Forms.TreeNode() {TreeNode126, TreeNode127, TreeNode128, TreeNode129})
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(demoForm))
            Me.allPanel = New System.Windows.Forms.Panel()
            Me.contentsPanel = New System.Windows.Forms.Panel()
            Me.splitContainer = New System.Windows.Forms.SplitContainer()
            Me.tableOfContents = New System.Windows.Forms.TreeView()
            Me.pnlTreeViewSeparator = New System.Windows.Forms.Panel()
            Me.topTreeViewBanner = New System.Windows.Forms.Panel()
            Me.expandAllLabel = New System.Windows.Forms.Label()
            Me.collapseAllLabel = New System.Windows.Forms.Label()
            Me.bannerPicture = New System.Windows.Forms.PictureBox()
            Me.expandAllPictureBox = New System.Windows.Forms.PictureBox()
            Me.collapseAllPictureBox = New System.Windows.Forms.PictureBox()
            Me.tocBottomPanel = New System.Windows.Forms.Panel()
            Me.tocRightPanel = New System.Windows.Forms.Panel()
            Me.tocLeftPanel = New System.Windows.Forms.Panel()
            Me.tocTopPanel = New System.Windows.Forms.Panel()
            Me.demoContentsPanel = New System.Windows.Forms.Panel()
            Me.demoTabControl = New System.Windows.Forms.TabControl()
            Me.liveDemoTabPage = New System.Windows.Forms.TabPage()
            Me.descriptionTabPage = New System.Windows.Forms.TabPage()
            Me.pnlDescriptionTop = New System.Windows.Forms.Panel()
            Me.codeSampleTabPage = New System.Windows.Forms.TabPage()
            Me.panelDemoRightSeparator = New System.Windows.Forms.Panel()
            Me.panelDemoLeftSeparator = New System.Windows.Forms.Panel()
            Me.panelDemoBottomSeparator = New System.Windows.Forms.Panel()
            Me.pnlDemoTopSeparator = New System.Windows.Forms.Panel()
            Me.demoRightPanel = New System.Windows.Forms.Panel()
            Me.demoLeftPanel = New System.Windows.Forms.Panel()
            Me.demoBottomPanel = New System.Windows.Forms.Panel()
            Me.demoTopPanel = New System.Windows.Forms.Panel()
            Me.rightMargin = New System.Windows.Forms.Panel()
            Me.leftMargin = New System.Windows.Forms.Panel()
            Me.bottomMargin = New System.Windows.Forms.Panel()
            Me.topMargin = New System.Windows.Forms.Panel()
            Me.allPanel.SuspendLayout()
            Me.contentsPanel.SuspendLayout()
            Me.splitContainer.Panel1.SuspendLayout()
            Me.splitContainer.Panel2.SuspendLayout()
            Me.splitContainer.SuspendLayout()
            Me.topTreeViewBanner.SuspendLayout()
            CType(Me.bannerPicture, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.expandAllPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.collapseAllPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.demoContentsPanel.SuspendLayout()
            Me.demoTabControl.SuspendLayout()
            Me.descriptionTabPage.SuspendLayout()
            Me.SuspendLayout()
            '
            'allPanel
            '
            Me.allPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.allPanel.Controls.Add(Me.contentsPanel)
            Me.allPanel.Controls.Add(Me.rightMargin)
            Me.allPanel.Controls.Add(Me.leftMargin)
            Me.allPanel.Controls.Add(Me.bottomMargin)
            Me.allPanel.Controls.Add(Me.topMargin)
            Me.allPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.allPanel.Location = New System.Drawing.Point(0, 0)
            Me.allPanel.Name = "allPanel"
            Me.allPanel.Size = New System.Drawing.Size(984, 729)
            Me.allPanel.TabIndex = 0
            '
            'contentsPanel
            '
            Me.contentsPanel.BackColor = System.Drawing.Color.White
            Me.contentsPanel.Controls.Add(Me.splitContainer)
            Me.contentsPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.contentsPanel.Location = New System.Drawing.Point(1, 1)
            Me.contentsPanel.Name = "contentsPanel"
            Me.contentsPanel.Size = New System.Drawing.Size(978, 723)
            Me.contentsPanel.TabIndex = 9
            '
            'splitContainer
            '
            Me.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainer.Location = New System.Drawing.Point(0, 0)
            Me.splitContainer.Name = "splitContainer"
            '
            'splitContainer.Panel1
            '
            Me.splitContainer.Panel1.Controls.Add(Me.tableOfContents)
            Me.splitContainer.Panel1.Controls.Add(Me.pnlTreeViewSeparator)
            Me.splitContainer.Panel1.Controls.Add(Me.topTreeViewBanner)
            Me.splitContainer.Panel1.Controls.Add(Me.tocBottomPanel)
            Me.splitContainer.Panel1.Controls.Add(Me.tocRightPanel)
            Me.splitContainer.Panel1.Controls.Add(Me.tocLeftPanel)
            Me.splitContainer.Panel1.Controls.Add(Me.tocTopPanel)
            '
            'splitContainer.Panel2
            '
            Me.splitContainer.Panel2.Controls.Add(Me.demoContentsPanel)
            Me.splitContainer.Panel2.Controls.Add(Me.demoRightPanel)
            Me.splitContainer.Panel2.Controls.Add(Me.demoLeftPanel)
            Me.splitContainer.Panel2.Controls.Add(Me.demoBottomPanel)
            Me.splitContainer.Panel2.Controls.Add(Me.demoTopPanel)
            Me.splitContainer.Size = New System.Drawing.Size(978, 723)
            Me.splitContainer.SplitterDistance = 335
            Me.splitContainer.SplitterWidth = 5
            Me.splitContainer.TabIndex = 0
            '
            'tableOfContents
            '
            Me.tableOfContents.BackColor = System.Drawing.Color.White
            Me.tableOfContents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tableOfContents.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableOfContents.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.tableOfContents.HideSelection = False
            Me.tableOfContents.Indent = 16
            Me.tableOfContents.ItemHeight = 18
            Me.tableOfContents.Location = New System.Drawing.Point(1, 68)
            Me.tableOfContents.Name = "tableOfContents"
            TreeNode1.Name = "Getting_Started"
            TreeNode1.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode1.Text = "Getting Started with HTML to PDF"
            TreeNode1.ToolTipText = "Getting Started with EVO HTML to PDF Converter"
            TreeNode2.Name = "HTML_Content_Scaling"
            TreeNode2.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode2.Text = "HTML Content Destination and Scaling in PDF"
            TreeNode2.ToolTipText = "Experiment Various Options to Control HTML Content Scaling in PDF Page"
            TreeNode3.Name = "Merge_Multiple_HTML"
            TreeNode3.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode3.Text = "Merge Multiple HTML Pages into a Single PDF"
            TreeNode3.ToolTipText = "Merge Multiple HTML Pages into a Sigle PDF Document"
            TreeNode4.Name = "Merge_With_Existing_PDF"
            TreeNode4.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode4.Text = "Merge HTML with Existing PDF Documents"
            TreeNode4.ToolTipText = "Add Existing PDFs Before and After HTML to PDF Conversion Result"
            TreeNode5.Name = "Partially_Convert_HTML"
            TreeNode5.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode5.Text = "Partially Convert of a HTML Page to PDF"
            TreeNode5.ToolTipText = "Partially Convert of a HTML Page to PDF"
            TreeNode6.Name = "Repeat_HTML_Table_Header_Footer"
            TreeNode6.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode6.Text = "Repeat HTML Table Header and Footer in PDF"
            TreeNode6.ToolTipText = "Repeat HTML Table Header and Footer in PDF"
            TreeNode7.Checked = True
            TreeNode7.Name = "HTML_in_Header_Footer"
            TreeNode7.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode7.Text = "Add HTML in Header and Footer"
            TreeNode7.ToolTipText = "Add HTML in Header and Footer"
            TreeNode8.Name = "Page_Numbers_in_HTML"
            TreeNode8.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode8.Text = "Add Page Numbering in HTML"
            TreeNode8.ToolTipText = "Add Page Numbering in HTML"
            TreeNode9.Name = "Header_Footer_Change_Per_Page"
            TreeNode9.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode9.Text = "Change Header and Footer per Page"
            TreeNode9.ToolTipText = "Change Header and Footer per Page"
            TreeNode10.Name = "Header_Footer_in_External_PDF"
            TreeNode10.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode10.Text = "Add Header and Footer in External PDFs"
            TreeNode10.ToolTipText = "Add Header and Footer in External PDFs"
            TreeNode11.Name = "Header_Footer_on_Merged_HTML"
            TreeNode11.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode11.Text = "Merge Multiple HTMLs into a Single PDF"
            TreeNode11.ToolTipText = "Merge Multiple HTMLs into a Single PDF"
            TreeNode12.Name = "Header_Footer_Auto_Resize"
            TreeNode12.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode12.Text = "Auto Resize Header and Footer"
            TreeNode12.ToolTipText = "Auto Resize Header and Footer"
            TreeNode13.Name = "Headers_and_Footers"
            TreeNode13.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode13.Text = "Headers and Footers"
            TreeNode13.ToolTipText = "Headers and Footers"
            TreeNode14.Name = "Insert_Page_Breaks_Using_CSS"
            TreeNode14.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode14.Text = "Insert Page Breaks in PDF Using CSS"
            TreeNode14.ToolTipText = "Insert Page Breaks in PDF Using CSS"
            TreeNode15.Name = "Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS"
            TreeNode15.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode15.Text = "Avoid Page Break Inside Elements Using CSS"
            TreeNode15.ToolTipText = "Avoid Page Break Inside Elements Using CSS"
            TreeNode16.Name = "Insert_Page_Breaks_Using_API"
            TreeNode16.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode16.Text = "Insert Page Breaks in PDF Using API"
            TreeNode16.ToolTipText = "Insert Page Breaks in PDF Using API"
            TreeNode17.Name = "Avoid_Page_Breaks_Inside_HTML_Elements_Using_API"
            TreeNode17.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode17.Text = "Avoid Page Break Inside Elements Using API"
            TreeNode17.ToolTipText = "Avoid Page Break Inside Elements Using API"
            TreeNode18.Name = "Avoid_Page_Breaks_Inside_Images_Using_API"
            TreeNode18.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode18.Text = "Avoid Page Breaks Inside Images Using API"
            TreeNode18.ToolTipText = "Avoid Page Breaks Inside Images Using API"
            TreeNode19.Name = "Page_Breaks_Control"
            TreeNode19.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode19.Text = "Page Breaks Control"
            TreeNode19.ToolTipText = "Page Breaks Control"
            TreeNode20.Name = "Select_Screen_or_Print_Media_Type"
            TreeNode20.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode20.Text = "Use Different Styles for Screen and Print"
            TreeNode20.ToolTipText = "Use Different Styles for Screen and Print"
            TreeNode21.Name = "Select_Media_Type"
            TreeNode21.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode21.Text = "Screen and Print Media Types"
            TreeNode21.ToolTipText = "Screen and Print Media Types"
            TreeNode22.Name = "Select_Triggering_Mode"
            TreeNode22.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode22.Text = "Select Conversion Triggering Mode"
            TreeNode22.ToolTipText = "Select Conversion Triggering Mode"
            TreeNode23.Name = "Triggering_Modes"
            TreeNode23.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode23.Text = "Conversion Triggering Modes"
            TreeNode23.ToolTipText = "Conversion Triggering Modes"
            TreeNode24.Name = "Auto_Create_Bookmarks"
            TreeNode24.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode24.Text = "Auto Create Hierachical Bookmarks"
            TreeNode24.ToolTipText = "Auto Create Hierachical Bookmarks"
            TreeNode25.Name = "Select_Bookmarks_in_API"
            TreeNode25.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode25.Text = "Select in API the Elements to Bookmark"
            TreeNode25.ToolTipText = "Select in API the Elements to Bookmark"
            TreeNode26.Name = "Select_Bookmarks_in_HTML"
            TreeNode26.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode26.Text = "Select in HTML the Elements to Bookmark"
            TreeNode26.ToolTipText = "Select in HTML the Elements to Bookmark"
            TreeNode27.Name = "Hierachical_Bookmarks"
            TreeNode27.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode27.Text = "Hierachical Bookmarks"
            TreeNode27.ToolTipText = "Hierachical Bookmarks"
            TreeNode28.Name = "Auto_Create_Table_of_Contents"
            TreeNode28.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode28.Text = "Auto Create a Table of Contents"
            TreeNode28.ToolTipText = "Auto Create a Table of Contents"
            TreeNode29.Name = "Define_in_HTML_Table_of_Contents"
            TreeNode29.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode29.Text = "Define in HTML the Table of Contents Items"
            TreeNode29.ToolTipText = "Define in HTML the Table of Contents Items"
            TreeNode30.Name = "Merge_Table_of_Contents"
            TreeNode30.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode30.Text = "Table of Contents for Multiple HTMLs"
            TreeNode30.ToolTipText = "Table of Contents for Multiple HTMLs"
            TreeNode31.Name = "Insert_PDF_Before_Table_of_Contents"
            TreeNode31.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode31.Text = "Insert PDF Before Table of Contents"
            TreeNode31.ToolTipText = "Insert PDF Before Table of Contents"
            TreeNode32.Name = "Table_of_Contents"
            TreeNode32.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode32.Text = "Table of Contents"
            TreeNode32.ToolTipText = "Table of Contents"
            TreeNode33.Name = "HTML_Forms_to_PDF_Forms"
            TreeNode33.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode33.Text = "Auto Create a Fillable PDF Form"
            TreeNode33.ToolTipText = "Convert a HTML Form to a PDF Form"
            TreeNode34.Name = "Define_in_HTML_PDF_Form_Fields"
            TreeNode34.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode34.Text = "Define in HTML the PDF Form Fields"
            TreeNode34.ToolTipText = "Define in HTML the PDF Form Fields"
            TreeNode35.Name = "PDF_Forms"
            TreeNode35.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode35.Text = "Live PDF Forms"
            TreeNode35.ToolTipText = "Convert a HTML Form to a PDF Form"
            TreeNode36.Name = "SVG_to_PDF"
            TreeNode36.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode36.Text = "Convert HTML with SVG to PDF"
            TreeNode36.ToolTipText = "Convert HTML with SVG to PDF"
            TreeNode37.Name = "Web_Fonts_to_PDF"
            TreeNode37.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode37.Text = "Convert HTML with Web Fonts to PDF"
            TreeNode37.ToolTipText = "Convert HTML with Web Fonts to PDF"
            TreeNode38.Name = "HTML5_Features"
            TreeNode38.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode38.Text = "HTML5 Features"
            TreeNode38.ToolTipText = "HTML5 Features"
            TreeNode39.Name = "Access_Using_HTTP_GET_and_POST"
            TreeNode39.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode39.Text = "Access HTML Pages with GET and POST"
            TreeNode39.ToolTipText = "Access HTML Pages with GET and POST"
            TreeNode40.Name = "Proxy_Options"
            TreeNode40.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode40.Text = "Access HTML Pages Through a Proxy"
            TreeNode40.ToolTipText = "Access HTML Pages Through a Proxy"
            TreeNode41.Name = "HTTP_GET_and_POST"
            TreeNode41.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode41.Text = "HTTP GET and POST, Proxy Options"
            TreeNode41.ToolTipText = "HTTP GET and POST, Proxy Options"
            TreeNode42.Name = "Add_HTTP_Headers"
            TreeNode42.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode42.Text = "Add HTTP Headers to HTML Page Request"
            TreeNode42.ToolTipText = "Add HTTP Headers to HTML Page Request"
            TreeNode43.Name = "Add_Cookies"
            TreeNode43.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode43.Text = "Add Cookies to HTML Page Request"
            TreeNode43.ToolTipText = "Add Cookies to HTML Page Request"
            TreeNode44.Name = "HTTP_Headers_and_Cookies"
            TreeNode44.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode44.Text = "HTTP Headers and Cookies"
            TreeNode44.ToolTipText = "HTTP Headers and Cookies"
            TreeNode45.Name = "Embed_Fonts"
            TreeNode45.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode45.Text = "Embed Fonts in PDF Document"
            TreeNode45.ToolTipText = "Embed Fonts in PDF Document"
            TreeNode46.Name = "Embed_Web_Fonts"
            TreeNode46.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode46.Text = "Embed Web Fonts in PDF Document"
            TreeNode46.ToolTipText = "Embed Web Fonts in PDF Document"
            TreeNode47.Name = "Fonts_Embedding"
            TreeNode47.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode47.Text = "Fonts Embedding"
            TreeNode47.ToolTipText = "Fonts Embedding"
            TreeNode48.Name = "Select_in_API_Elements_to_Retrieve"
            TreeNode48.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode48.Text = "Select in API the HTML Elements to Retrieve"
            TreeNode48.ToolTipText = "Select in API the HTML Elements to Retrieve"
            TreeNode49.Name = "Select_in_HTML_Elements_to_Retrieve"
            TreeNode49.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode49.Text = "Select in HTML the Elements to Retrieve"
            TreeNode49.ToolTipText = "Select in HTML the Elements to Retrieve"
            TreeNode50.Name = "HTML_Elements_Location_in_PDF"
            TreeNode50.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode50.Text = "HTML Elements Location in PDF"
            TreeNode50.ToolTipText = "HTML Elements Location in PDF"
            TreeNode51.Name = "Select_in_API_Elements_to_Hide"
            TreeNode51.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode51.Text = "Use API to Select HTML Elements to Hide"
            TreeNode51.ToolTipText = "Use API to Select HTML Elements to Hide"
            TreeNode52.Name = "Select_in_HTML_Elements_to_Hide"
            TreeNode52.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode52.Text = "Define in HTML the Elements to Hide"
            TreeNode52.ToolTipText = "Define in HTML the Elements to Hide"
            TreeNode53.Name = "HTML_Elements_Visibility"
            TreeNode53.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode53.Text = "HTML Elements Visibility in PDF"
            TreeNode53.ToolTipText = "HTML Elements Visibility in PDF"
            TreeNode54.Name = "Convert_URI_Links"
            TreeNode54.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode54.Text = "Convert URI Links from HTML to PDF"
            TreeNode54.ToolTipText = "Convert URI Links from HTML to PDF"
            TreeNode55.Name = "Custom_URI_Links"
            TreeNode55.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode55.Text = "Define Custom URI Links in HTML"
            TreeNode55.ToolTipText = "Define Custom URI Links in HTML"
            TreeNode56.Name = "URI_Links_in_PDF"
            TreeNode56.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode56.Text = "URI Links in PDF"
            TreeNode56.ToolTipText = "URI Links in PDF"
            TreeNode57.Name = "Convert_Internal_Links"
            TreeNode57.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode57.Text = "Convert Internal Links from HTML to PDF"
            TreeNode57.ToolTipText = "Convert Internal Links from HTML to PDF"
            TreeNode58.Name = "Custom_Internal_Links"
            TreeNode58.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode58.Text = "Define Custom Internal Links in HTML"
            TreeNode58.ToolTipText = "Define Custom Internal Links in HTML"
            TreeNode59.Name = "Internal_Links_in_PDF"
            TreeNode59.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode59.Text = "Internal Links in PDF"
            TreeNode59.ToolTipText = "Internal Links in PDF"
            TreeNode60.Name = "Create_File_Links_and_Attachments"
            TreeNode60.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode60.Text = "Create File Links and Attachments in PDF"
            TreeNode60.ToolTipText = "Create File Links and Attachments in PDF"
            TreeNode61.Name = "File_Links_and_Attachments"
            TreeNode61.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode61.Text = "File Links and Attachments"
            TreeNode61.ToolTipText = "File Links and Attachments"
            TreeNode62.Name = "Create_Text_Notes"
            TreeNode62.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode62.Text = "Create Text Notes in Generated PDF"
            TreeNode62.ToolTipText = "Create Text Notes in Generated PDF"
            TreeNode63.Name = "Text_Notes"
            TreeNode63.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode63.Text = "Text Notes in PDF"
            TreeNode63.ToolTipText = "Text Notes in PDF"
            TreeNode64.Name = "Execute_JavaScript_Open_Action"
            TreeNode64.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode64.Text = "Execute JavaScript when Document is Opened"
            TreeNode64.ToolTipText = "Execute JavaScript when Document is Opened"
            TreeNode65.Name = "Go_To_Page_Open_Action"
            TreeNode65.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode65.Text = "Go To a Page when Document is Opened"
            TreeNode65.ToolTipText = "Go To a Page in PDF Document"
            TreeNode66.Name = "Execute_JavaScript_Button_Clicked"
            TreeNode66.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode66.Text = "Execute JavaScript when a Button is Clicked"
            TreeNode66.ToolTipText = "Execute JavaScript when a Button is Clicked"
            TreeNode67.Name = "PDF_Actions"
            TreeNode67.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode67.Text = "PDF Actions"
            TreeNode67.ToolTipText = "PDF Actions"
            TreeNode68.Name = "Add_HTML_to_PDF_Elements_to_PDF_Document"
            TreeNode68.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode68.Text = "Add HTML to PDF Elements to PDF"
            TreeNode68.ToolTipText = "Add HTML to PDF Elements to PDF"
            TreeNode69.Name = "HTML_to_PDF_Elements"
            TreeNode69.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode69.Text = "HTML to PDF Elements"
            TreeNode69.ToolTipText = "HTML to PDF Elements"
            TreeNode70.Name = "Add_HTML_to_Image_Elements_to_PDF_Document"
            TreeNode70.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode70.Text = "Add HTML to Image Elements to PDF"
            TreeNode70.ToolTipText = "Add HTML to Image Elements to PDF"
            TreeNode71.Name = "HTML_to_Image_Elements"
            TreeNode71.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode71.Text = "HTML to Image Elements"
            TreeNode71.ToolTipText = "HTML to Image Elements"
            TreeNode72.Name = "Images_Scaling_and_JPEG_Compression"
            TreeNode72.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode72.Text = "Set Scaling and JPEG Compression Level"
            TreeNode72.ToolTipText = "Set Scaling and JPEG Compression Level"
            TreeNode73.Name = "Replace_Images"
            TreeNode73.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode73.Text = "Replace Images with Higher Quality Images"
            TreeNode73.ToolTipText = "Replace Images with Higher Quality Images"
            TreeNode74.Name = "Images_Quality"
            TreeNode74.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode74.Text = "Images Quality in Generated PDF"
            TreeNode74.ToolTipText = "Images Quality in Generated PDF"
            TreeNode75.Name = "Convert_HTML_with_Flash_to_PDF"
            TreeNode75.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode75.Text = "Convert HTML with Flash to PDF"
            TreeNode75.ToolTipText = "Convert HTML with Flash to PDF"
            TreeNode76.Name = "Flash_and_Extensions"
            TreeNode76.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode76.Text = "Flash and Extensions Support"
            TreeNode76.ToolTipText = "Flash and Extensions Support"
            TreeNode77.Name = "Add_Watermarks_and_Stamps"
            TreeNode77.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode77.Text = "Add Watermarks and Stamps in PDF"
            TreeNode77.ToolTipText = "Add Watermarks and Stamps in PDF"
            TreeNode78.Name = "Watermarks_and_Stamps"
            TreeNode78.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode78.Text = "Watermarks and Stamps"
            TreeNode78.ToolTipText = "Watermarks and Stamps"
            TreeNode79.Name = "Add_Elements_in_Background"
            TreeNode79.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode79.Text = "Add Elements in PDF Page Background"
            TreeNode79.ToolTipText = "Add Elements in PDF Page Background"
            TreeNode80.Name = "Add_Elements_Over_Main_Content"
            TreeNode80.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode80.Text = "Add Elements Over PDF Page Main Content"
            TreeNode80.ToolTipText = "Add Elements Over PDF Page Main Content"
            TreeNode81.Name = "PDF_Background_Foreground"
            TreeNode81.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode81.Text = "PDF Background and Foreground"
            TreeNode81.ToolTipText = "PDF Background and Foreground"
            TreeNode82.Name = "Create_PDF_A_PDF_X_Documents"
            TreeNode82.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode82.Text = "Create PDF/A and PDF/X Documents"
            TreeNode82.ToolTipText = "Create PDF/A and PDF/X Documents"
            TreeNode83.Name = "PDF_Standards"
            TreeNode83.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode83.Text = "PDF/A and PDF/X Standards"
            TreeNode83.ToolTipText = "PDF/A and PDF/X Standards"
            TreeNode84.Name = "Create_GrayScale_CMYK_Documents"
            TreeNode84.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode84.Text = "Create CMYK and GrayScale PDF Documents"
            TreeNode84.ToolTipText = "Create CMYK and GrayScale PDF Documents"
            TreeNode85.Name = "PDF_Color_Spaces"
            TreeNode85.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode85.Text = "CMYK and GrayScale Color Spaces"
            TreeNode85.ToolTipText = "CMYK and GrayScale Color Spaces"
            TreeNode86.Name = "Set_Viewer_Preferences"
            TreeNode86.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode86.Text = "Set Layout, Mode, Menus and Toolbars"
            TreeNode86.ToolTipText = "Set Layout, Mode, Menus and Toolbars"
            TreeNode87.Name = "Set_Initial_Zoom_Level"
            TreeNode87.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode87.Text = "Set Initial Zoom Level"
            TreeNode87.ToolTipText = "Set Initial Zoom Level"
            TreeNode88.Name = "PDF_Viewer_Preferences"
            TreeNode88.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode88.Text = "PDF Viewer Preferences"
            TreeNode88.ToolTipText = "PDF Viewer Preferences"
            TreeNode89.Name = "PDF_Permissions_and_Password"
            TreeNode89.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode89.Text = "Set PDF Permissions and Password"
            TreeNode89.ToolTipText = "Set PDF Permissions and Password"
            TreeNode90.Name = "Digital_Signatures"
            TreeNode90.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode90.Text = "Digitally Sign the Generated PDF"
            TreeNode90.ToolTipText = "Digitally Sign the Generated PDF"
            TreeNode91.Name = "PDF_Security_Features"
            TreeNode91.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode91.Text = "PDF Security Features"
            TreeNode91.ToolTipText = "PDF Security Features"
            TreeNode92.ForeColor = System.Drawing.Color.Black
            TreeNode92.Name = "HTML_to_PDF"
            TreeNode92.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            TreeNode92.Text = "HTML to PDF Converter"
            TreeNode92.ToolTipText = "EVO HTML to PDF Converter"
            TreeNode93.Name = "Convert_HTML_to_Image"
            TreeNode93.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode93.Text = "Convert HTML to a Raster Image"
            TreeNode93.ToolTipText = "Convert HTML to a Raster Image"
            TreeNode94.Name = "Convert_HTML_to_SVG"
            TreeNode94.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode94.Text = "Convert HTML to SVG Vector Image"
            TreeNode94.ToolTipText = "Convert HTML to SVG Vector Image"
            TreeNode95.Name = "HTML_to_Image"
            TreeNode95.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            TreeNode95.Text = "HTML to Image Converter"
            TreeNode95.ToolTipText = "HTML to Image Converter"
            TreeNode96.Name = "Create_PDF_Documents"
            TreeNode96.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode96.Text = "Create PDF Documents"
            TreeNode96.ToolTipText = "Create PDF Documents"
            TreeNode97.Name = "PDF_Creator_HTML_to_PDF_Elements"
            TreeNode97.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode97.Text = "HTML to PDF Elements"
            TreeNode97.ToolTipText = "HTML to PDF Elements"
            TreeNode98.Name = "PDF_Creator_HTML_to_Image_Elements"
            TreeNode98.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode98.Text = "HTML to Image Elements"
            TreeNode98.ToolTipText = "HTML to Image Elements"
            TreeNode99.Name = "Text_Elements"
            TreeNode99.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode99.Text = "Text Elements"
            TreeNode99.ToolTipText = "Text Elements"
            TreeNode100.Name = "Graphic_Elements"
            TreeNode100.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode100.Text = "Graphic Elements"
            TreeNode100.ToolTipText = "Graphic Elements"
            TreeNode101.Name = "Image_Elements"
            TreeNode101.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode101.Text = "Image Elements"
            TreeNode101.ToolTipText = "Image Elements"
            TreeNode102.Name = "PDF_Creator_Headers_and_Footers"
            TreeNode102.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode102.Text = "Add HTML in Header and Footer"
            TreeNode102.ToolTipText = "Add HTML in Header and Footer"
            TreeNode103.Name = "PDF_Creator_Page_Numbers_in_HTML"
            TreeNode103.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode103.Text = "Add Page Numbering in HTML"
            TreeNode103.ToolTipText = "Add Page Numbering in HTML"
            TreeNode104.Name = "PDF_Creator_Header_Footer_Change_Per_Page"
            TreeNode104.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode104.Text = "Change Header and Footer per Page"
            TreeNode104.ToolTipText = "Change Header and Footer per Page"
            TreeNode105.Name = "PDF_Creator_Header_Footer_in_External_PDF"
            TreeNode105.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode105.Text = "Add Header and Footer in External PDFs"
            TreeNode105.ToolTipText = "Add Header and Footer in External PDFs"
            TreeNode106.Name = "PDF_Creator_Header_Footer_Auto_Resize"
            TreeNode106.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode106.Text = "Auto Resize Header and Footer"
            TreeNode106.ToolTipText = "Auto Resize Header and Footer"
            TreeNode107.Name = "PDF_Creator_HTML_in_Header_Footer"
            TreeNode107.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode107.Text = "Headers and Footers"
            TreeNode107.ToolTipText = "Headers and Footers"
            TreeNode108.Name = "Bookmarks"
            TreeNode108.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode108.Text = "Bookmarks"
            TreeNode108.ToolTipText = "Bookmarks"
            TreeNode109.Name = "Create_PDF_Forms"
            TreeNode109.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode109.Text = "PDF Forms"
            TreeNode109.ToolTipText = "PDF Forms"
            TreeNode110.Name = "URI_Links"
            TreeNode110.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode110.Text = "URI Links"
            TreeNode110.ToolTipText = "URI Links"
            TreeNode111.Name = "Internal_Links"
            TreeNode111.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode111.Text = "Internal Links"
            TreeNode111.ToolTipText = "Internal Links"
            TreeNode112.Name = "File_Links"
            TreeNode112.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode112.Text = "File Links"
            TreeNode112.ToolTipText = "File Links"
            TreeNode113.Name = "File_Attachments"
            TreeNode113.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode113.Text = "File Attachments"
            TreeNode113.ToolTipText = "File Attachments"
            TreeNode114.Name = "PDF_Creator_Text_Notes"
            TreeNode114.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode114.Text = "Text Notes"
            TreeNode114.ToolTipText = "Text Notes"
            TreeNode115.Name = "PDF_Creator_Execute_JavaScript_Open_Action"
            TreeNode115.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode115.Text = "Execute JavaScript when Document is Opened"
            TreeNode115.ToolTipText = "Execute JavaScript when Document is Opened"
            TreeNode116.Name = "PDF_Creator_Go_To_Page_Open_Action"
            TreeNode116.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode116.Text = "Go To a Page when Document is Opened"
            TreeNode116.ToolTipText = "Go To a Page when Document is Opened"
            TreeNode117.Name = "PDF_Creator_Execute_JavaScript_Button_Clicked"
            TreeNode117.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode117.Text = "Execute JavaScript when a Button is Clicked"
            TreeNode117.ToolTipText = "Execute JavaScript when a Button is Clicked"
            TreeNode118.Name = "PDF_Creator_PDF_Actions"
            TreeNode118.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode118.Text = "PDF Actions"
            TreeNode118.ToolTipText = "PDF Actions"
            TreeNode119.Name = "PDF_Creator_Set_Viewer_Preferences"
            TreeNode119.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode119.Text = "Set Layout, Mode, Menus and Toolbars"
            TreeNode119.ToolTipText = "Set Layout, Mode, Menus and Toolbars"
            TreeNode120.Name = "PDF_Creator_Set_Initial_Zoom_Level"
            TreeNode120.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode120.Text = "Set Initial Zoom Level"
            TreeNode120.ToolTipText = "Set Initial Zoom Level"
            TreeNode121.Name = "PDF_Creator_PDF_Viewer_Preferences"
            TreeNode121.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode121.Text = "Viewer Preferences"
            TreeNode121.ToolTipText = "Viewer Preferences"
            TreeNode122.Name = "PDF_Creator_PDF_Permissions_and_Password"
            TreeNode122.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode122.Text = "Set PDF Permissions and Password"
            TreeNode122.ToolTipText = "Set PDF Permissions and Password"
            TreeNode123.Name = "PDF_Creator_Digital_Signatures"
            TreeNode123.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode123.Text = "Digitally Sign a PDF Document"
            TreeNode123.ToolTipText = "Digitally Sign a PDF Document"
            TreeNode124.Name = "PDF_Creator_PDF_Security"
            TreeNode124.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode124.Text = "PDF Security"
            TreeNode125.Name = "PDF_Creator"
            TreeNode125.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            TreeNode125.Text = "PDF Creator"
            TreeNode125.ToolTipText = "PDF Creator"
            TreeNode126.Name = "Merge_PDF"
            TreeNode126.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode126.Text = "Merge PDF Documents"
            TreeNode126.ToolTipText = "Merge PDF Documents"
            TreeNode127.Name = "Split_PDF"
            TreeNode127.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode127.Text = "Split PDF Documents"
            TreeNode127.ToolTipText = "Split PDF Documents"
            TreeNode128.Name = "Stamp_PDF_Documents"
            TreeNode128.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode128.Text = "Stamp PDF Documents"
            TreeNode128.ToolTipText = "Stamp PDF Documents"
            TreeNode129.Name = "Fill_PDF_Forms"
            TreeNode129.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            TreeNode129.Text = "Fill PDF Forms"
            TreeNode129.ToolTipText = "Fill PDF Forms"
            TreeNode130.Name = "PDF_Editor"
            TreeNode130.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            TreeNode130.Text = "PDF Editor"
            TreeNode130.ToolTipText = "PDF Editor"
            Me.tableOfContents.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode92, TreeNode95, TreeNode125, TreeNode130})
            Me.tableOfContents.Size = New System.Drawing.Size(333, 654)
            Me.tableOfContents.TabIndex = 8
            '
            'pnlTreeViewSeparator
            '
            Me.pnlTreeViewSeparator.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTreeViewSeparator.Location = New System.Drawing.Point(1, 65)
            Me.pnlTreeViewSeparator.Name = "pnlTreeViewSeparator"
            Me.pnlTreeViewSeparator.Size = New System.Drawing.Size(333, 3)
            Me.pnlTreeViewSeparator.TabIndex = 7
            '
            'topTreeViewBanner
            '
            Me.topTreeViewBanner.BackColor = System.Drawing.Color.White
            Me.topTreeViewBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.topTreeViewBanner.Controls.Add(Me.expandAllLabel)
            Me.topTreeViewBanner.Controls.Add(Me.collapseAllLabel)
            Me.topTreeViewBanner.Controls.Add(Me.bannerPicture)
            Me.topTreeViewBanner.Controls.Add(Me.expandAllPictureBox)
            Me.topTreeViewBanner.Controls.Add(Me.collapseAllPictureBox)
            Me.topTreeViewBanner.Dock = System.Windows.Forms.DockStyle.Top
            Me.topTreeViewBanner.Location = New System.Drawing.Point(1, 1)
            Me.topTreeViewBanner.Name = "topTreeViewBanner"
            Me.topTreeViewBanner.Size = New System.Drawing.Size(333, 64)
            Me.topTreeViewBanner.TabIndex = 6
            '
            'expandAllLabel
            '
            Me.expandAllLabel.AutoSize = True
            Me.expandAllLabel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.expandAllLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel)
            Me.expandAllLabel.ForeColor = System.Drawing.Color.Navy
            Me.expandAllLabel.Location = New System.Drawing.Point(246, 33)
            Me.expandAllLabel.Name = "expandAllLabel"
            Me.expandAllLabel.Size = New System.Drawing.Size(49, 15)
            Me.expandAllLabel.TabIndex = 3
            Me.expandAllLabel.Text = "Expand"
            '
            'collapseAllLabel
            '
            Me.collapseAllLabel.AutoSize = True
            Me.collapseAllLabel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.collapseAllLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel)
            Me.collapseAllLabel.ForeColor = System.Drawing.Color.Navy
            Me.collapseAllLabel.Location = New System.Drawing.Point(246, 12)
            Me.collapseAllLabel.Name = "collapseAllLabel"
            Me.collapseAllLabel.Size = New System.Drawing.Size(55, 15)
            Me.collapseAllLabel.TabIndex = 3
            Me.collapseAllLabel.Text = "Collapse"
            '
            'bannerPicture
            '
            Me.bannerPicture.Cursor = System.Windows.Forms.Cursors.Hand
            Me.bannerPicture.Image = CType(resources.GetObject("bannerPicture.Image"), System.Drawing.Image)
            Me.bannerPicture.Location = New System.Drawing.Point(8, 1)
            Me.bannerPicture.Name = "bannerPicture"
            Me.bannerPicture.Size = New System.Drawing.Size(214, 58)
            Me.bannerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.bannerPicture.TabIndex = 0
            Me.bannerPicture.TabStop = False
            '
            'expandAllPictureBox
            '
            Me.expandAllPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
            Me.expandAllPictureBox.Image = CType(resources.GetObject("expandAllPictureBox.Image"), System.Drawing.Image)
            Me.expandAllPictureBox.Location = New System.Drawing.Point(229, 35)
            Me.expandAllPictureBox.Name = "expandAllPictureBox"
            Me.expandAllPictureBox.Size = New System.Drawing.Size(14, 14)
            Me.expandAllPictureBox.TabIndex = 2
            Me.expandAllPictureBox.TabStop = False
            '
            'collapseAllPictureBox
            '
            Me.collapseAllPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
            Me.collapseAllPictureBox.Image = CType(resources.GetObject("collapseAllPictureBox.Image"), System.Drawing.Image)
            Me.collapseAllPictureBox.Location = New System.Drawing.Point(229, 14)
            Me.collapseAllPictureBox.Name = "collapseAllPictureBox"
            Me.collapseAllPictureBox.Size = New System.Drawing.Size(14, 14)
            Me.collapseAllPictureBox.TabIndex = 2
            Me.collapseAllPictureBox.TabStop = False
            '
            'tocBottomPanel
            '
            Me.tocBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.tocBottomPanel.Location = New System.Drawing.Point(1, 722)
            Me.tocBottomPanel.Name = "tocBottomPanel"
            Me.tocBottomPanel.Size = New System.Drawing.Size(333, 1)
            Me.tocBottomPanel.TabIndex = 5
            '
            'tocRightPanel
            '
            Me.tocRightPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.tocRightPanel.Location = New System.Drawing.Point(334, 1)
            Me.tocRightPanel.Name = "tocRightPanel"
            Me.tocRightPanel.Size = New System.Drawing.Size(1, 722)
            Me.tocRightPanel.TabIndex = 4
            '
            'tocLeftPanel
            '
            Me.tocLeftPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.tocLeftPanel.Location = New System.Drawing.Point(0, 1)
            Me.tocLeftPanel.Name = "tocLeftPanel"
            Me.tocLeftPanel.Size = New System.Drawing.Size(1, 722)
            Me.tocLeftPanel.TabIndex = 3
            '
            'tocTopPanel
            '
            Me.tocTopPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.tocTopPanel.Location = New System.Drawing.Point(0, 0)
            Me.tocTopPanel.Name = "tocTopPanel"
            Me.tocTopPanel.Size = New System.Drawing.Size(335, 1)
            Me.tocTopPanel.TabIndex = 1
            '
            'demoContentsPanel
            '
            Me.demoContentsPanel.BackColor = System.Drawing.Color.White
            Me.demoContentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.demoContentsPanel.Controls.Add(Me.demoTabControl)
            Me.demoContentsPanel.Controls.Add(Me.panelDemoRightSeparator)
            Me.demoContentsPanel.Controls.Add(Me.panelDemoLeftSeparator)
            Me.demoContentsPanel.Controls.Add(Me.panelDemoBottomSeparator)
            Me.demoContentsPanel.Controls.Add(Me.pnlDemoTopSeparator)
            Me.demoContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.demoContentsPanel.Location = New System.Drawing.Point(1, 1)
            Me.demoContentsPanel.Name = "demoContentsPanel"
            Me.demoContentsPanel.Size = New System.Drawing.Size(636, 721)
            Me.demoContentsPanel.TabIndex = 9
            '
            'demoTabControl
            '
            Me.demoTabControl.Controls.Add(Me.liveDemoTabPage)
            Me.demoTabControl.Controls.Add(Me.descriptionTabPage)
            Me.demoTabControl.Controls.Add(Me.codeSampleTabPage)
            Me.demoTabControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.demoTabControl.Location = New System.Drawing.Point(5, 5)
            Me.demoTabControl.Margin = New System.Windows.Forms.Padding(0)
            Me.demoTabControl.Name = "demoTabControl"
            Me.demoTabControl.SelectedIndex = 0
            Me.demoTabControl.Size = New System.Drawing.Size(624, 709)
            Me.demoTabControl.TabIndex = 4
            '
            'liveDemoTabPage
            '
            Me.liveDemoTabPage.BackColor = System.Drawing.Color.White
            Me.liveDemoTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.liveDemoTabPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.liveDemoTabPage.Location = New System.Drawing.Point(4, 24)
            Me.liveDemoTabPage.Name = "liveDemoTabPage"
            Me.liveDemoTabPage.Padding = New System.Windows.Forms.Padding(3)
            Me.liveDemoTabPage.Size = New System.Drawing.Size(616, 681)
            Me.liveDemoTabPage.TabIndex = 0
            Me.liveDemoTabPage.Text = "Live Demo"
            Me.liveDemoTabPage.ToolTipText = "Run the demo"
            '
            'descriptionTabPage
            '
            Me.descriptionTabPage.BackColor = System.Drawing.Color.White
            Me.descriptionTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.descriptionTabPage.Controls.Add(Me.pnlDescriptionTop)
            Me.descriptionTabPage.Location = New System.Drawing.Point(4, 22)
            Me.descriptionTabPage.Name = "descriptionTabPage"
            Me.descriptionTabPage.Padding = New System.Windows.Forms.Padding(3)
            Me.descriptionTabPage.Size = New System.Drawing.Size(616, 683)
            Me.descriptionTabPage.TabIndex = 2
            Me.descriptionTabPage.Text = "Description"
            Me.descriptionTabPage.ToolTipText = "Demo detailed description"
            '
            'pnlDescriptionTop
            '
            Me.pnlDescriptionTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlDescriptionTop.Location = New System.Drawing.Point(3, 3)
            Me.pnlDescriptionTop.Name = "pnlDescriptionTop"
            Me.pnlDescriptionTop.Size = New System.Drawing.Size(606, 5)
            Me.pnlDescriptionTop.TabIndex = 0
            '
            'codeSampleTabPage
            '
            Me.codeSampleTabPage.BackColor = System.Drawing.Color.White
            Me.codeSampleTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.codeSampleTabPage.Location = New System.Drawing.Point(4, 22)
            Me.codeSampleTabPage.Name = "codeSampleTabPage"
            Me.codeSampleTabPage.Padding = New System.Windows.Forms.Padding(3)
            Me.codeSampleTabPage.Size = New System.Drawing.Size(616, 683)
            Me.codeSampleTabPage.TabIndex = 1
            Me.codeSampleTabPage.Text = "Code Sample"
            Me.codeSampleTabPage.ToolTipText = "See demo code sample"
            '
            'panelDemoRightSeparator
            '
            Me.panelDemoRightSeparator.Dock = System.Windows.Forms.DockStyle.Right
            Me.panelDemoRightSeparator.Location = New System.Drawing.Point(629, 5)
            Me.panelDemoRightSeparator.Name = "panelDemoRightSeparator"
            Me.panelDemoRightSeparator.Size = New System.Drawing.Size(5, 709)
            Me.panelDemoRightSeparator.TabIndex = 3
            '
            'panelDemoLeftSeparator
            '
            Me.panelDemoLeftSeparator.Dock = System.Windows.Forms.DockStyle.Left
            Me.panelDemoLeftSeparator.Location = New System.Drawing.Point(0, 5)
            Me.panelDemoLeftSeparator.Name = "panelDemoLeftSeparator"
            Me.panelDemoLeftSeparator.Size = New System.Drawing.Size(5, 709)
            Me.panelDemoLeftSeparator.TabIndex = 2
            '
            'panelDemoBottomSeparator
            '
            Me.panelDemoBottomSeparator.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelDemoBottomSeparator.Location = New System.Drawing.Point(0, 714)
            Me.panelDemoBottomSeparator.Name = "panelDemoBottomSeparator"
            Me.panelDemoBottomSeparator.Size = New System.Drawing.Size(634, 5)
            Me.panelDemoBottomSeparator.TabIndex = 1
            '
            'pnlDemoTopSeparator
            '
            Me.pnlDemoTopSeparator.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlDemoTopSeparator.Location = New System.Drawing.Point(0, 0)
            Me.pnlDemoTopSeparator.Name = "pnlDemoTopSeparator"
            Me.pnlDemoTopSeparator.Size = New System.Drawing.Size(634, 5)
            Me.pnlDemoTopSeparator.TabIndex = 0
            '
            'demoRightPanel
            '
            Me.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.demoRightPanel.Location = New System.Drawing.Point(637, 1)
            Me.demoRightPanel.Name = "demoRightPanel"
            Me.demoRightPanel.Size = New System.Drawing.Size(1, 721)
            Me.demoRightPanel.TabIndex = 8
            '
            'demoLeftPanel
            '
            Me.demoLeftPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.demoLeftPanel.Location = New System.Drawing.Point(0, 1)
            Me.demoLeftPanel.Name = "demoLeftPanel"
            Me.demoLeftPanel.Size = New System.Drawing.Size(1, 721)
            Me.demoLeftPanel.TabIndex = 7
            '
            'demoBottomPanel
            '
            Me.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.demoBottomPanel.Location = New System.Drawing.Point(0, 722)
            Me.demoBottomPanel.Name = "demoBottomPanel"
            Me.demoBottomPanel.Size = New System.Drawing.Size(638, 1)
            Me.demoBottomPanel.TabIndex = 6
            '
            'demoTopPanel
            '
            Me.demoTopPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.demoTopPanel.Location = New System.Drawing.Point(0, 0)
            Me.demoTopPanel.Name = "demoTopPanel"
            Me.demoTopPanel.Size = New System.Drawing.Size(638, 1)
            Me.demoTopPanel.TabIndex = 2
            '
            'rightMargin
            '
            Me.rightMargin.Dock = System.Windows.Forms.DockStyle.Right
            Me.rightMargin.Location = New System.Drawing.Point(979, 1)
            Me.rightMargin.Name = "rightMargin"
            Me.rightMargin.Size = New System.Drawing.Size(1, 723)
            Me.rightMargin.TabIndex = 8
            '
            'leftMargin
            '
            Me.leftMargin.Dock = System.Windows.Forms.DockStyle.Left
            Me.leftMargin.Location = New System.Drawing.Point(0, 1)
            Me.leftMargin.Name = "leftMargin"
            Me.leftMargin.Size = New System.Drawing.Size(1, 723)
            Me.leftMargin.TabIndex = 7
            '
            'bottomMargin
            '
            Me.bottomMargin.BackColor = System.Drawing.Color.White
            Me.bottomMargin.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.bottomMargin.Location = New System.Drawing.Point(0, 724)
            Me.bottomMargin.Name = "bottomMargin"
            Me.bottomMargin.Size = New System.Drawing.Size(980, 1)
            Me.bottomMargin.TabIndex = 6
            '
            'topMargin
            '
            Me.topMargin.Dock = System.Windows.Forms.DockStyle.Top
            Me.topMargin.Location = New System.Drawing.Point(0, 0)
            Me.topMargin.Name = "topMargin"
            Me.topMargin.Size = New System.Drawing.Size(980, 1)
            Me.topMargin.TabIndex = 5
            '
            'demoForm
            '
            Me.AutoScroll = True
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(984, 729)
            Me.Controls.Add(Me.allPanel)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "demoForm"
            Me.Text = "EVO HTML to PDF Converter Demo"
            Me.allPanel.ResumeLayout(False)
            Me.contentsPanel.ResumeLayout(False)
            Me.splitContainer.Panel1.ResumeLayout(False)
            Me.splitContainer.Panel2.ResumeLayout(False)
            Me.splitContainer.ResumeLayout(False)
            Me.topTreeViewBanner.ResumeLayout(False)
            Me.topTreeViewBanner.PerformLayout()
            CType(Me.bannerPicture, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.expandAllPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.collapseAllPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.demoContentsPanel.ResumeLayout(False)
            Me.demoTabControl.ResumeLayout(False)
            Me.descriptionTabPage.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private allPanel As Panel
		Private contentsPanel As Panel
		Private splitContainer As SplitContainer
		Private tocBottomPanel As Panel
		Private tocRightPanel As Panel
		Private tocLeftPanel As Panel
		Private tocTopPanel As Panel
		Private demoContentsPanel As Panel
		Private demoRightPanel As Panel
		Private demoLeftPanel As Panel
		Private demoBottomPanel As Panel
		Private demoTopPanel As Panel
		Private rightMargin As Panel
		Private leftMargin As Panel
		Private bottomMargin As Panel
		Private topMargin As Panel
		Private WithEvents tableOfContents As TreeView
		Private pnlTreeViewSeparator As Panel
		Private topTreeViewBanner As Panel
		Private WithEvents bannerPicture As PictureBox
		Private pnlDemoTopSeparator As Panel
		Private demoTabControl As TabControl
		Private liveDemoTabPage As TabPage
		Private codeSampleTabPage As TabPage
		Private panelDemoRightSeparator As Panel
		Private panelDemoLeftSeparator As Panel
		Private panelDemoBottomSeparator As Panel
		Private descriptionTabPage As TabPage
		Private pnlDescriptionTop As Panel
		Private WithEvents expandAllPictureBox As PictureBox
		Private WithEvents collapseAllPictureBox As PictureBox
		Private WithEvents collapseAllLabel As Label
		Private WithEvents expandAllLabel As Label
	End Class
End Namespace


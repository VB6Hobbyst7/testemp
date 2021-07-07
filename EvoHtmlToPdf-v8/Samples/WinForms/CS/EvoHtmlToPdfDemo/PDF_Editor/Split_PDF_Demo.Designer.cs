namespace EvoHtmlToPdfDemo.PDF_Editor
{
    partial class Split_PDF_Demo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Split_PDF_Demo));
            this.demoLeftPanel = new System.Windows.Forms.Panel();
            this.demoRightPanel = new System.Windows.Forms.Panel();
            this.demoBottomPanel = new System.Windows.Forms.Panel();
            this.demoTopPanel = new System.Windows.Forms.Panel();
            this.convertButtonPanel = new System.Windows.Forms.Panel();
            this.splitPdfButton = new System.Windows.Forms.Button();
            this.splitResultPanel = new System.Windows.Forms.Panel();
            this.openInitialLinkLabel = new System.Windows.Forms.LinkLabel();
            this.openSecondLinkLabel = new System.Windows.Forms.LinkLabel();
            this.openFirstLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.urlPanel = new System.Windows.Forms.Panel();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.pdfFilePathTextBox = new System.Windows.Forms.TextBox();
            this.enterUrlLabel = new System.Windows.Forms.Label();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.convertButtonPanel.SuspendLayout();
            this.splitResultPanel.SuspendLayout();
            this.urlPanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // demoLeftPanel
            // 
            this.demoLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.demoLeftPanel.Location = new System.Drawing.Point(0, 6);
            this.demoLeftPanel.Name = "demoLeftPanel";
            this.demoLeftPanel.Size = new System.Drawing.Size(6, 638);
            this.demoLeftPanel.TabIndex = 131;
            // 
            // demoRightPanel
            // 
            this.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.demoRightPanel.Location = new System.Drawing.Point(604, 6);
            this.demoRightPanel.Name = "demoRightPanel";
            this.demoRightPanel.Size = new System.Drawing.Size(6, 638);
            this.demoRightPanel.TabIndex = 130;
            // 
            // demoBottomPanel
            // 
            this.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.demoBottomPanel.Location = new System.Drawing.Point(0, 644);
            this.demoBottomPanel.Name = "demoBottomPanel";
            this.demoBottomPanel.Size = new System.Drawing.Size(610, 6);
            this.demoBottomPanel.TabIndex = 129;
            // 
            // demoTopPanel
            // 
            this.demoTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.demoTopPanel.Location = new System.Drawing.Point(0, 0);
            this.demoTopPanel.Name = "demoTopPanel";
            this.demoTopPanel.Size = new System.Drawing.Size(610, 6);
            this.demoTopPanel.TabIndex = 128;
            // 
            // convertButtonPanel
            // 
            this.convertButtonPanel.Controls.Add(this.splitPdfButton);
            this.convertButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.convertButtonPanel.Location = new System.Drawing.Point(6, 238);
            this.convertButtonPanel.Name = "convertButtonPanel";
            this.convertButtonPanel.Size = new System.Drawing.Size(598, 42);
            this.convertButtonPanel.TabIndex = 140;
            // 
            // splitPdfButton
            // 
            this.splitPdfButton.Location = new System.Drawing.Point(6, 6);
            this.splitPdfButton.Name = "splitPdfButton";
            this.splitPdfButton.Size = new System.Drawing.Size(86, 27);
            this.splitPdfButton.TabIndex = 66;
            this.splitPdfButton.Text = "Split PDF";
            this.splitPdfButton.UseVisualStyleBackColor = true;
            this.splitPdfButton.Click += new System.EventHandler(this.splitPdfButton_Click);
            // 
            // splitResultPanel
            // 
            this.splitResultPanel.Controls.Add(this.openInitialLinkLabel);
            this.splitResultPanel.Controls.Add(this.openSecondLinkLabel);
            this.splitResultPanel.Controls.Add(this.openFirstLinkLabel);
            this.splitResultPanel.Controls.Add(this.label1);
            this.splitResultPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitResultPanel.Location = new System.Drawing.Point(6, 177);
            this.splitResultPanel.Name = "splitResultPanel";
            this.splitResultPanel.Size = new System.Drawing.Size(598, 61);
            this.splitResultPanel.TabIndex = 139;
            this.splitResultPanel.Visible = false;
            // 
            // openInitialLinkLabel
            // 
            this.openInitialLinkLabel.AutoSize = true;
            this.openInitialLinkLabel.Location = new System.Drawing.Point(414, 31);
            this.openInitialLinkLabel.Name = "openInitialLinkLabel";
            this.openInitialLinkLabel.Size = new System.Drawing.Size(96, 15);
            this.openInitialLinkLabel.TabIndex = 43;
            this.openInitialLinkLabel.TabStop = true;
            this.openInitialLinkLabel.Text = "Open Initial PDF";
            this.openInitialLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openInitialLinkLabel_LinkClicked_1);
            // 
            // openSecondLinkLabel
            // 
            this.openSecondLinkLabel.AutoSize = true;
            this.openSecondLinkLabel.Location = new System.Drawing.Point(193, 31);
            this.openSecondLinkLabel.Name = "openSecondLinkLabel";
            this.openSecondLinkLabel.Size = new System.Drawing.Size(181, 15);
            this.openSecondLinkLabel.TabIndex = 43;
            this.openSecondLinkLabel.TabStop = true;
            this.openSecondLinkLabel.Text = "Open the Second Resulted PDF";
            this.openSecondLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openSecondLinkLabel_LinkClicked);
            // 
            // openFirstLinkLabel
            // 
            this.openFirstLinkLabel.AutoSize = true;
            this.openFirstLinkLabel.Location = new System.Drawing.Point(6, 31);
            this.openFirstLinkLabel.Name = "openFirstLinkLabel";
            this.openFirstLinkLabel.Size = new System.Drawing.Size(162, 15);
            this.openFirstLinkLabel.TabIndex = 43;
            this.openFirstLinkLabel.TabStop = true;
            this.openFirstLinkLabel.Text = "Open the First Resulted PDF";
            this.openFirstLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openFirstLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Split Result";
            // 
            // urlPanel
            // 
            this.urlPanel.Controls.Add(this.selectFileButton);
            this.urlPanel.Controls.Add(this.pdfFilePathTextBox);
            this.urlPanel.Controls.Add(this.enterUrlLabel);
            this.urlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.urlPanel.Location = new System.Drawing.Point(6, 98);
            this.urlPanel.Name = "urlPanel";
            this.urlPanel.Size = new System.Drawing.Size(598, 79);
            this.urlPanel.TabIndex = 138;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectFileButton.Location = new System.Drawing.Point(516, 37);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(66, 26);
            this.selectFileButton.TabIndex = 44;
            this.selectFileButton.Text = "Browse";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // pdfFilePathTextBox
            // 
            this.pdfFilePathTextBox.Location = new System.Drawing.Point(9, 40);
            this.pdfFilePathTextBox.Name = "pdfFilePathTextBox";
            this.pdfFilePathTextBox.Size = new System.Drawing.Size(501, 21);
            this.pdfFilePathTextBox.TabIndex = 43;
            // 
            // enterUrlLabel
            // 
            this.enterUrlLabel.AutoSize = true;
            this.enterUrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.enterUrlLabel.Location = new System.Drawing.Point(6, 13);
            this.enterUrlLabel.Name = "enterUrlLabel";
            this.enterUrlLabel.Size = new System.Drawing.Size(180, 15);
            this.enterUrlLabel.TabIndex = 42;
            this.enterUrlLabel.Text = "The PDF Document to Split";
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Controls.Add(this.descriptionLabel);
            this.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionPanel.Location = new System.Drawing.Point(6, 46);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(598, 52);
            this.descriptionPanel.TabIndex = 137;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Location = new System.Drawing.Point(0, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(598, 52);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(6, 6);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(598, 40);
            this.titlePanel.TabIndex = 136;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.Location = new System.Drawing.Point(0, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(160, 17);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Split PDF Documents";
            // 
            // Split_PDF_Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.convertButtonPanel);
            this.Controls.Add(this.splitResultPanel);
            this.Controls.Add(this.urlPanel);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.demoLeftPanel);
            this.Controls.Add(this.demoRightPanel);
            this.Controls.Add(this.demoBottomPanel);
            this.Controls.Add(this.demoTopPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "Split_PDF_Demo";
            this.Size = new System.Drawing.Size(610, 650);
            this.Load += new System.EventHandler(this.Split_PDF_Demo_Load);
            this.convertButtonPanel.ResumeLayout(false);
            this.splitResultPanel.ResumeLayout(false);
            this.splitResultPanel.PerformLayout();
            this.urlPanel.ResumeLayout(false);
            this.urlPanel.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel demoLeftPanel;
        private System.Windows.Forms.Panel demoRightPanel;
        private System.Windows.Forms.Panel demoBottomPanel;
        private System.Windows.Forms.Panel demoTopPanel;
        private System.Windows.Forms.Panel convertButtonPanel;
        private System.Windows.Forms.Button splitPdfButton;
        private System.Windows.Forms.Panel splitResultPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel urlPanel;
        private System.Windows.Forms.Label enterUrlLabel;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.LinkLabel openSecondLinkLabel;
        private System.Windows.Forms.LinkLabel openFirstLinkLabel;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox pdfFilePathTextBox;
        private System.Windows.Forms.LinkLabel openInitialLinkLabel;
    }
}

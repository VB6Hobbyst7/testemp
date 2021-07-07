namespace EvoHtmlToPdfDemo.PDF_Editor
{
    partial class Stamp_PDF_Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stamp_PDF_Demo));
            this.demoLeftPanel = new System.Windows.Forms.Panel();
            this.demoRightPanel = new System.Windows.Forms.Panel();
            this.demoBottomPanel = new System.Windows.Forms.Panel();
            this.demoTopPanel = new System.Windows.Forms.Panel();
            this.urlPanel = new System.Windows.Forms.Panel();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.pdfFilePathTextBox = new System.Windows.Forms.TextBox();
            this.enterUrlLabel = new System.Windows.Forms.Label();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.stampHeightTextBox = new System.Windows.Forms.TextBox();
            this.stampWidthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.baseUrlTextBox = new System.Windows.Forms.TextBox();
            this.htmlStringTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.convertButtonPanel = new System.Windows.Forms.Panel();
            this.stampPdfButton = new System.Windows.Forms.Button();
            this.urlPanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.convertButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // demoLeftPanel
            // 
            this.demoLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.demoLeftPanel.Location = new System.Drawing.Point(0, 6);
            this.demoLeftPanel.Name = "demoLeftPanel";
            this.demoLeftPanel.Size = new System.Drawing.Size(6, 671);
            this.demoLeftPanel.TabIndex = 135;
            // 
            // demoRightPanel
            // 
            this.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.demoRightPanel.Location = new System.Drawing.Point(604, 6);
            this.demoRightPanel.Name = "demoRightPanel";
            this.demoRightPanel.Size = new System.Drawing.Size(6, 671);
            this.demoRightPanel.TabIndex = 134;
            // 
            // demoBottomPanel
            // 
            this.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.demoBottomPanel.Location = new System.Drawing.Point(0, 677);
            this.demoBottomPanel.Name = "demoBottomPanel";
            this.demoBottomPanel.Size = new System.Drawing.Size(610, 6);
            this.demoBottomPanel.TabIndex = 133;
            // 
            // demoTopPanel
            // 
            this.demoTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.demoTopPanel.Location = new System.Drawing.Point(0, 0);
            this.demoTopPanel.Name = "demoTopPanel";
            this.demoTopPanel.Size = new System.Drawing.Size(610, 6);
            this.demoTopPanel.TabIndex = 132;
            // 
            // urlPanel
            // 
            this.urlPanel.Controls.Add(this.selectFileButton);
            this.urlPanel.Controls.Add(this.pdfFilePathTextBox);
            this.urlPanel.Controls.Add(this.enterUrlLabel);
            this.urlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.urlPanel.Location = new System.Drawing.Point(6, 98);
            this.urlPanel.Name = "urlPanel";
            this.urlPanel.Size = new System.Drawing.Size(598, 73);
            this.urlPanel.TabIndex = 143;
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
            this.enterUrlLabel.Size = new System.Drawing.Size(192, 15);
            this.enterUrlLabel.TabIndex = 42;
            this.enterUrlLabel.Text = "The PDF Document to Stamp";
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Controls.Add(this.descriptionLabel);
            this.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionPanel.Location = new System.Drawing.Point(6, 46);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(598, 52);
            this.descriptionPanel.TabIndex = 142;
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
            this.titlePanel.TabIndex = 141;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.Location = new System.Drawing.Point(0, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(173, 17);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Stamp PDF Documents";
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.label31);
            this.settingsPanel.Controls.Add(this.label23);
            this.settingsPanel.Controls.Add(this.label30);
            this.settingsPanel.Controls.Add(this.label26);
            this.settingsPanel.Controls.Add(this.stampHeightTextBox);
            this.settingsPanel.Controls.Add(this.stampWidthTextBox);
            this.settingsPanel.Controls.Add(this.label2);
            this.settingsPanel.Controls.Add(this.baseUrlTextBox);
            this.settingsPanel.Controls.Add(this.htmlStringTextBox);
            this.settingsPanel.Controls.Add(this.label12);
            this.settingsPanel.Controls.Add(this.label5);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel.Location = new System.Drawing.Point(6, 171);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(598, 447);
            this.settingsPanel.TabIndex = 145;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label31.Location = new System.Drawing.Point(254, 41);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(17, 15);
            this.label31.TabIndex = 128;
            this.label31.Text = "pt";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label23.Location = new System.Drawing.Point(120, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 15);
            this.label23.TabIndex = 127;
            this.label23.Text = "pt";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label30.Location = new System.Drawing.Point(152, 41);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(46, 15);
            this.label30.TabIndex = 125;
            this.label30.Text = "Height:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label26.Location = new System.Drawing.Point(25, 41);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 15);
            this.label26.TabIndex = 126;
            this.label26.Text = "Width:";
            // 
            // stampHeightTextBox
            // 
            this.stampHeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.stampHeightTextBox.Location = new System.Drawing.Point(203, 38);
            this.stampHeightTextBox.Name = "stampHeightTextBox";
            this.stampHeightTextBox.Size = new System.Drawing.Size(45, 21);
            this.stampHeightTextBox.TabIndex = 121;
            this.stampHeightTextBox.Text = "400";
            // 
            // stampWidthTextBox
            // 
            this.stampWidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.stampWidthTextBox.Location = new System.Drawing.Point(70, 38);
            this.stampWidthTextBox.Name = "stampWidthTextBox";
            this.stampWidthTextBox.Size = new System.Drawing.Size(45, 21);
            this.stampWidthTextBox.TabIndex = 122;
            this.stampWidthTextBox.Text = "400";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(6, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Base URL";
            // 
            // baseUrlTextBox
            // 
            this.baseUrlTextBox.Location = new System.Drawing.Point(9, 411);
            this.baseUrlTextBox.Name = "baseUrlTextBox";
            this.baseUrlTextBox.Size = new System.Drawing.Size(575, 21);
            this.baseUrlTextBox.TabIndex = 53;
            // 
            // htmlStringTextBox
            // 
            this.htmlStringTextBox.Location = new System.Drawing.Point(9, 88);
            this.htmlStringTextBox.MaxLength = 1000000;
            this.htmlStringTextBox.Multiline = true;
            this.htmlStringTextBox.Name = "htmlStringTextBox";
            this.htmlStringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.htmlStringTextBox.Size = new System.Drawing.Size(574, 302);
            this.htmlStringTextBox.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label12.Location = new System.Drawing.Point(6, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 15);
            this.label12.TabIndex = 50;
            this.label12.Text = "Stamp HTML Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Stamp Size in PDF Page";
            // 
            // convertButtonPanel
            // 
            this.convertButtonPanel.Controls.Add(this.stampPdfButton);
            this.convertButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.convertButtonPanel.Location = new System.Drawing.Point(6, 618);
            this.convertButtonPanel.Name = "convertButtonPanel";
            this.convertButtonPanel.Size = new System.Drawing.Size(598, 42);
            this.convertButtonPanel.TabIndex = 146;
            // 
            // stampPdfButton
            // 
            this.stampPdfButton.Location = new System.Drawing.Point(6, 6);
            this.stampPdfButton.Name = "stampPdfButton";
            this.stampPdfButton.Size = new System.Drawing.Size(110, 27);
            this.stampPdfButton.TabIndex = 66;
            this.stampPdfButton.Text = "Stamp PDF";
            this.stampPdfButton.UseVisualStyleBackColor = true;
            this.stampPdfButton.Click += new System.EventHandler(this.stampPdfButton_Click);
            // 
            // Stamp_PDF_Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.convertButtonPanel);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.urlPanel);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.demoLeftPanel);
            this.Controls.Add(this.demoRightPanel);
            this.Controls.Add(this.demoBottomPanel);
            this.Controls.Add(this.demoTopPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "Stamp_PDF_Demo";
            this.Size = new System.Drawing.Size(610, 683);
            this.Load += new System.EventHandler(this.Stamp_PDF_Demo_Load);
            this.urlPanel.ResumeLayout(false);
            this.urlPanel.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.convertButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel demoLeftPanel;
        private System.Windows.Forms.Panel demoRightPanel;
        private System.Windows.Forms.Panel demoBottomPanel;
        private System.Windows.Forms.Panel demoTopPanel;
        private System.Windows.Forms.Panel urlPanel;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox pdfFilePathTextBox;
        private System.Windows.Forms.Label enterUrlLabel;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox stampHeightTextBox;
        private System.Windows.Forms.TextBox stampWidthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baseUrlTextBox;
        private System.Windows.Forms.TextBox htmlStringTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel convertButtonPanel;
        private System.Windows.Forms.Button stampPdfButton;
    }
}

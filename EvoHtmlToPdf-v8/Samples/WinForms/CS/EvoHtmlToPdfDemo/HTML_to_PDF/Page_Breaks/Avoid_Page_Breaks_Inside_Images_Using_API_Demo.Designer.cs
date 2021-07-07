namespace EvoHtmlToPdfDemo.HTML_to_PDF.Page_Breaks
{
    partial class Avoid_Page_Breaks_Inside_Images_Using_API_Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avoid_Page_Breaks_Inside_Images_Using_API_Demo));
            this.convertButtonPanel = new System.Windows.Forms.Panel();
            this.convertToPdfButton = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.avoidImagesBreakCheckBox = new System.Windows.Forms.CheckBox();
            this.urlPanel = new System.Windows.Forms.Panel();
            this.enterUrlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.demoLeftPanel = new System.Windows.Forms.Panel();
            this.demoRightPanel = new System.Windows.Forms.Panel();
            this.demoBottomPanel = new System.Windows.Forms.Panel();
            this.demoTopPanel = new System.Windows.Forms.Panel();
            this.convertButtonPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.urlPanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertButtonPanel
            // 
            this.convertButtonPanel.Controls.Add(this.convertToPdfButton);
            this.convertButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.convertButtonPanel.Location = new System.Drawing.Point(6, 218);
            this.convertButtonPanel.Name = "convertButtonPanel";
            this.convertButtonPanel.Size = new System.Drawing.Size(598, 42);
            this.convertButtonPanel.TabIndex = 125;
            // 
            // convertToPdfButton
            // 
            this.convertToPdfButton.Location = new System.Drawing.Point(9, 6);
            this.convertToPdfButton.Name = "convertToPdfButton";
            this.convertToPdfButton.Size = new System.Drawing.Size(150, 27);
            this.convertToPdfButton.TabIndex = 66;
            this.convertToPdfButton.Text = "Convert HTML to PDF";
            this.convertToPdfButton.UseVisualStyleBackColor = true;
            this.convertToPdfButton.Click += new System.EventHandler(this.convertToPdfButton_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.avoidImagesBreakCheckBox);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel.Location = new System.Drawing.Point(6, 168);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(598, 50);
            this.settingsPanel.TabIndex = 124;
            // 
            // avoidImagesBreakCheckBox
            // 
            this.avoidImagesBreakCheckBox.AutoSize = true;
            this.avoidImagesBreakCheckBox.Checked = true;
            this.avoidImagesBreakCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.avoidImagesBreakCheckBox.Location = new System.Drawing.Point(9, 15);
            this.avoidImagesBreakCheckBox.Name = "avoidImagesBreakCheckBox";
            this.avoidImagesBreakCheckBox.Size = new System.Drawing.Size(234, 20);
            this.avoidImagesBreakCheckBox.TabIndex = 1;
            this.avoidImagesBreakCheckBox.Text = "Avoid Page Breaks Inside Images";
            this.avoidImagesBreakCheckBox.UseVisualStyleBackColor = true;
            // 
            // urlPanel
            // 
            this.urlPanel.Controls.Add(this.enterUrlLabel);
            this.urlPanel.Controls.Add(this.urlTextBox);
            this.urlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.urlPanel.Location = new System.Drawing.Point(6, 101);
            this.urlPanel.Name = "urlPanel";
            this.urlPanel.Size = new System.Drawing.Size(598, 67);
            this.urlPanel.TabIndex = 123;
            // 
            // enterUrlLabel
            // 
            this.enterUrlLabel.AutoSize = true;
            this.enterUrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.enterUrlLabel.Location = new System.Drawing.Point(6, 13);
            this.enterUrlLabel.Name = "enterUrlLabel";
            this.enterUrlLabel.Size = new System.Drawing.Size(288, 16);
            this.enterUrlLabel.TabIndex = 42;
            this.enterUrlLabel.Text = "HTML Page URL or Local File to Convert";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(8, 34);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(574, 21);
            this.urlTextBox.TabIndex = 45;
            this.urlTextBox.Text = "http://www.cnn.com";
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Controls.Add(this.descriptionLabel);
            this.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionPanel.Location = new System.Drawing.Point(6, 46);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(598, 55);
            this.descriptionPanel.TabIndex = 122;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Location = new System.Drawing.Point(0, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(598, 55);
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
            this.titlePanel.TabIndex = 120;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.Location = new System.Drawing.Point(0, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(336, 18);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Avoid Page Breaks Inside Images Using API";
            // 
            // demoLeftPanel
            // 
            this.demoLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.demoLeftPanel.Location = new System.Drawing.Point(0, 6);
            this.demoLeftPanel.Name = "demoLeftPanel";
            this.demoLeftPanel.Size = new System.Drawing.Size(6, 638);
            this.demoLeftPanel.TabIndex = 119;
            // 
            // demoRightPanel
            // 
            this.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.demoRightPanel.Location = new System.Drawing.Point(604, 6);
            this.demoRightPanel.Name = "demoRightPanel";
            this.demoRightPanel.Size = new System.Drawing.Size(6, 638);
            this.demoRightPanel.TabIndex = 118;
            // 
            // demoBottomPanel
            // 
            this.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.demoBottomPanel.Location = new System.Drawing.Point(0, 644);
            this.demoBottomPanel.Name = "demoBottomPanel";
            this.demoBottomPanel.Size = new System.Drawing.Size(610, 6);
            this.demoBottomPanel.TabIndex = 117;
            // 
            // demoTopPanel
            // 
            this.demoTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.demoTopPanel.Location = new System.Drawing.Point(0, 0);
            this.demoTopPanel.Name = "demoTopPanel";
            this.demoTopPanel.Size = new System.Drawing.Size(610, 6);
            this.demoTopPanel.TabIndex = 116;
            // 
            // Avoid_Page_Breaks_Inside_Images_Using_API_Demo
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
            this.Name = "Avoid_Page_Breaks_Inside_Images_Using_API_Demo";
            this.Size = new System.Drawing.Size(610, 650);
            this.convertButtonPanel.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.urlPanel.ResumeLayout(false);
            this.urlPanel.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel convertButtonPanel;
        private System.Windows.Forms.Button convertToPdfButton;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.CheckBox avoidImagesBreakCheckBox;
        private System.Windows.Forms.Panel urlPanel;
        private System.Windows.Forms.Label enterUrlLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel demoLeftPanel;
        private System.Windows.Forms.Panel demoRightPanel;
        private System.Windows.Forms.Panel demoBottomPanel;
        private System.Windows.Forms.Panel demoTopPanel;
    }
}

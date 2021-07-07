namespace EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents
{
    partial class Merge_Table_of_Contents_Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Merge_Table_of_Contents_Demo));
            this.urlPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.enterUrlLabel = new System.Windows.Forms.Label();
            this.secondUrlTextBox = new System.Windows.Forms.TextBox();
            this.firstUrlTextBox = new System.Windows.Forms.TextBox();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.demoLeftPanel = new System.Windows.Forms.Panel();
            this.demoRightPanel = new System.Windows.Forms.Panel();
            this.demoBottomPanel = new System.Windows.Forms.Panel();
            this.demoTopPanel = new System.Windows.Forms.Panel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.includeSecondHtmlTocCheckBox = new System.Windows.Forms.CheckBox();
            this.includeFirstHtmlTocCheckBox = new System.Windows.Forms.CheckBox();
            this.startNewPageCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.convertButtonPanel = new System.Windows.Forms.Panel();
            this.convertToPdfButton = new System.Windows.Forms.Button();
            this.autoTableOfContentsCheckBox = new System.Windows.Forms.CheckBox();
            this.viewFirstHtmlLinkLabel = new System.Windows.Forms.LinkLabel();
            this.viewSecondHtmlLinkLabel = new System.Windows.Forms.LinkLabel();
            this.urlPanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.convertButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlPanel
            // 
            this.urlPanel.Controls.Add(this.viewSecondHtmlLinkLabel);
            this.urlPanel.Controls.Add(this.viewFirstHtmlLinkLabel);
            this.urlPanel.Controls.Add(this.label6);
            this.urlPanel.Controls.Add(this.enterUrlLabel);
            this.urlPanel.Controls.Add(this.secondUrlTextBox);
            this.urlPanel.Controls.Add(this.firstUrlTextBox);
            this.urlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.urlPanel.Location = new System.Drawing.Point(6, 109);
            this.urlPanel.Name = "urlPanel";
            this.urlPanel.Size = new System.Drawing.Size(598, 131);
            this.urlPanel.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(7, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Second HTML Page URL";
            // 
            // enterUrlLabel
            // 
            this.enterUrlLabel.AutoSize = true;
            this.enterUrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.enterUrlLabel.Location = new System.Drawing.Point(7, 14);
            this.enterUrlLabel.Name = "enterUrlLabel";
            this.enterUrlLabel.Size = new System.Drawing.Size(146, 15);
            this.enterUrlLabel.TabIndex = 40;
            this.enterUrlLabel.Text = "First HTML Page URL";
            // 
            // secondUrlTextBox
            // 
            this.secondUrlTextBox.Location = new System.Drawing.Point(9, 97);
            this.secondUrlTextBox.Name = "secondUrlTextBox";
            this.secondUrlTextBox.Size = new System.Drawing.Size(500, 21);
            this.secondUrlTextBox.TabIndex = 41;
            this.secondUrlTextBox.Text = "http://www.evopdf.com/DemoAppFiles/HTML_Files/Structured_HTML.html";
            // 
            // firstUrlTextBox
            // 
            this.firstUrlTextBox.Location = new System.Drawing.Point(9, 38);
            this.firstUrlTextBox.Name = "firstUrlTextBox";
            this.firstUrlTextBox.Size = new System.Drawing.Size(500, 21);
            this.firstUrlTextBox.TabIndex = 41;
            this.firstUrlTextBox.Text = "http://www.cnn.com";
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Controls.Add(this.descriptionLabel);
            this.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionPanel.Location = new System.Drawing.Point(6, 52);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(598, 57);
            this.descriptionPanel.TabIndex = 95;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Location = new System.Drawing.Point(0, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(598, 57);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.Location = new System.Drawing.Point(0, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(382, 17);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Merge Table of Contents from Multiple HTML Pages";
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(6, 6);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(598, 46);
            this.titlePanel.TabIndex = 94;
            // 
            // demoLeftPanel
            // 
            this.demoLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.demoLeftPanel.Location = new System.Drawing.Point(0, 6);
            this.demoLeftPanel.Name = "demoLeftPanel";
            this.demoLeftPanel.Size = new System.Drawing.Size(6, 638);
            this.demoLeftPanel.TabIndex = 93;
            // 
            // demoRightPanel
            // 
            this.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.demoRightPanel.Location = new System.Drawing.Point(604, 6);
            this.demoRightPanel.Name = "demoRightPanel";
            this.demoRightPanel.Size = new System.Drawing.Size(6, 638);
            this.demoRightPanel.TabIndex = 92;
            // 
            // demoBottomPanel
            // 
            this.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.demoBottomPanel.Location = new System.Drawing.Point(0, 644);
            this.demoBottomPanel.Name = "demoBottomPanel";
            this.demoBottomPanel.Size = new System.Drawing.Size(610, 6);
            this.demoBottomPanel.TabIndex = 91;
            // 
            // demoTopPanel
            // 
            this.demoTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.demoTopPanel.Location = new System.Drawing.Point(0, 0);
            this.demoTopPanel.Name = "demoTopPanel";
            this.demoTopPanel.Size = new System.Drawing.Size(610, 6);
            this.demoTopPanel.TabIndex = 90;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.autoTableOfContentsCheckBox);
            this.settingsPanel.Controls.Add(this.label5);
            this.settingsPanel.Controls.Add(this.label3);
            this.settingsPanel.Controls.Add(this.includeSecondHtmlTocCheckBox);
            this.settingsPanel.Controls.Add(this.includeFirstHtmlTocCheckBox);
            this.settingsPanel.Controls.Add(this.startNewPageCheckBox);
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel.Location = new System.Drawing.Point(6, 240);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(598, 178);
            this.settingsPanel.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(614, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 142;
            this.label5.Text = "pt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 15);
            this.label3.TabIndex = 137;
            this.label3.Text = "Table of Contents Options";
            // 
            // includeSecondHtmlTocCheckBox
            // 
            this.includeSecondHtmlTocCheckBox.AutoSize = true;
            this.includeSecondHtmlTocCheckBox.Checked = true;
            this.includeSecondHtmlTocCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeSecondHtmlTocCheckBox.Location = new System.Drawing.Point(234, 139);
            this.includeSecondHtmlTocCheckBox.Name = "includeSecondHtmlTocCheckBox";
            this.includeSecondHtmlTocCheckBox.Size = new System.Drawing.Size(175, 19);
            this.includeSecondHtmlTocCheckBox.TabIndex = 128;
            this.includeSecondHtmlTocCheckBox.Text = "Include Second HTML TOC";
            this.includeSecondHtmlTocCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeFirstHtmlTocCheckBox
            // 
            this.includeFirstHtmlTocCheckBox.AutoSize = true;
            this.includeFirstHtmlTocCheckBox.Checked = true;
            this.includeFirstHtmlTocCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeFirstHtmlTocCheckBox.Location = new System.Drawing.Point(40, 139);
            this.includeFirstHtmlTocCheckBox.Name = "includeFirstHtmlTocCheckBox";
            this.includeFirstHtmlTocCheckBox.Size = new System.Drawing.Size(156, 19);
            this.includeFirstHtmlTocCheckBox.TabIndex = 131;
            this.includeFirstHtmlTocCheckBox.Text = "Include First HTML TOC";
            this.includeFirstHtmlTocCheckBox.UseVisualStyleBackColor = true;
            // 
            // startNewPageCheckBox
            // 
            this.startNewPageCheckBox.AutoSize = true;
            this.startNewPageCheckBox.Location = new System.Drawing.Point(40, 37);
            this.startNewPageCheckBox.Name = "startNewPageCheckBox";
            this.startNewPageCheckBox.Size = new System.Drawing.Size(267, 19);
            this.startNewPageCheckBox.TabIndex = 40;
            this.startNewPageCheckBox.Text = "Start the Second HTML on a New PDF Page";
            this.startNewPageCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "HTML Merge Options";
            // 
            // convertButtonPanel
            // 
            this.convertButtonPanel.Controls.Add(this.convertToPdfButton);
            this.convertButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.convertButtonPanel.Location = new System.Drawing.Point(6, 418);
            this.convertButtonPanel.Name = "convertButtonPanel";
            this.convertButtonPanel.Size = new System.Drawing.Size(598, 50);
            this.convertButtonPanel.TabIndex = 100;
            // 
            // convertToPdfButton
            // 
            this.convertToPdfButton.Location = new System.Drawing.Point(7, 7);
            this.convertToPdfButton.Name = "convertToPdfButton";
            this.convertToPdfButton.Size = new System.Drawing.Size(150, 31);
            this.convertToPdfButton.TabIndex = 66;
            this.convertToPdfButton.Text = "Convert HTML to PDF";
            this.convertToPdfButton.UseVisualStyleBackColor = true;
            this.convertToPdfButton.Click += new System.EventHandler(this.convertToPdfButton_Click);
            // 
            // autoTableOfContentsCheckBox
            // 
            this.autoTableOfContentsCheckBox.AutoSize = true;
            this.autoTableOfContentsCheckBox.Checked = true;
            this.autoTableOfContentsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoTableOfContentsCheckBox.Location = new System.Drawing.Point(40, 104);
            this.autoTableOfContentsCheckBox.Name = "autoTableOfContentsCheckBox";
            this.autoTableOfContentsCheckBox.Size = new System.Drawing.Size(279, 19);
            this.autoTableOfContentsCheckBox.TabIndex = 143;
            this.autoTableOfContentsCheckBox.Text = "Create a Table of Contents from H1 to H6 Tags";
            this.autoTableOfContentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // viewFirstHtmlLinkLabel
            // 
            this.viewFirstHtmlLinkLabel.AutoSize = true;
            this.viewFirstHtmlLinkLabel.Location = new System.Drawing.Point(515, 41);
            this.viewFirstHtmlLinkLabel.Name = "viewFirstHtmlLinkLabel";
            this.viewFirstHtmlLinkLabel.Size = new System.Drawing.Size(70, 15);
            this.viewFirstHtmlLinkLabel.TabIndex = 47;
            this.viewFirstHtmlLinkLabel.TabStop = true;
            this.viewFirstHtmlLinkLabel.Text = "View HTML";
            this.viewFirstHtmlLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewFirstHtmlLinkLabel_LinkClicked);
            // 
            // viewSecondHtmlLinkLabel
            // 
            this.viewSecondHtmlLinkLabel.AutoSize = true;
            this.viewSecondHtmlLinkLabel.Location = new System.Drawing.Point(515, 100);
            this.viewSecondHtmlLinkLabel.Name = "viewSecondHtmlLinkLabel";
            this.viewSecondHtmlLinkLabel.Size = new System.Drawing.Size(70, 15);
            this.viewSecondHtmlLinkLabel.TabIndex = 47;
            this.viewSecondHtmlLinkLabel.TabStop = true;
            this.viewSecondHtmlLinkLabel.Text = "View HTML";
            this.viewSecondHtmlLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewSecondHtmlLinkLabel_LinkClicked);
            // 
            // Merge_Table_of_Contents_Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "Merge_Table_of_Contents_Demo";
            this.Size = new System.Drawing.Size(610, 650);
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

        private System.Windows.Forms.Panel urlPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label enterUrlLabel;
        private System.Windows.Forms.TextBox secondUrlTextBox;
        private System.Windows.Forms.TextBox firstUrlTextBox;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel demoLeftPanel;
        private System.Windows.Forms.Panel demoRightPanel;
        private System.Windows.Forms.Panel demoBottomPanel;
        private System.Windows.Forms.Panel demoTopPanel;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox includeSecondHtmlTocCheckBox;
        private System.Windows.Forms.CheckBox includeFirstHtmlTocCheckBox;
        private System.Windows.Forms.CheckBox startNewPageCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel convertButtonPanel;
        private System.Windows.Forms.Button convertToPdfButton;
        private System.Windows.Forms.CheckBox autoTableOfContentsCheckBox;
        private System.Windows.Forms.LinkLabel viewFirstHtmlLinkLabel;
        private System.Windows.Forms.LinkLabel viewSecondHtmlLinkLabel;
    }
}

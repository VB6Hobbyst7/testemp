namespace EvoHtmlToPdfDemo.HTML_to_PDF.Media_Types
{
    partial class Select_Screen_or_Print_Media_Type_Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select_Screen_or_Print_Media_Type_Demo));
            this.htmlPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.baseUrlTextBox = new System.Windows.Forms.TextBox();
            this.htmlStringTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.urlPanel = new System.Windows.Forms.Panel();
            this.viewHtmlLinkLabel = new System.Windows.Forms.LinkLabel();
            this.enterUrlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.selectHtmlToConvertPanel = new System.Windows.Forms.Panel();
            this.convertHtmlRadioButton = new System.Windows.Forms.RadioButton();
            this.convertUrlRadioButton = new System.Windows.Forms.RadioButton();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.demoLeftPanel = new System.Windows.Forms.Panel();
            this.demoRightPanel = new System.Windows.Forms.Panel();
            this.demoBottomPanel = new System.Windows.Forms.Panel();
            this.demoTopPanel = new System.Windows.Forms.Panel();
            this.selectMediaTypePanel = new System.Windows.Forms.Panel();
            this.printMediaTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.screenMediaTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.convertButtonPanel = new System.Windows.Forms.Panel();
            this.convertToPdfButton = new System.Windows.Forms.Button();
            this.htmlPanel.SuspendLayout();
            this.urlPanel.SuspendLayout();
            this.selectHtmlToConvertPanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.selectMediaTypePanel.SuspendLayout();
            this.convertButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlPanel
            // 
            this.htmlPanel.Controls.Add(this.label2);
            this.htmlPanel.Controls.Add(this.baseUrlTextBox);
            this.htmlPanel.Controls.Add(this.htmlStringTextBox);
            this.htmlPanel.Controls.Add(this.label12);
            this.htmlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.htmlPanel.Location = new System.Drawing.Point(6, 217);
            this.htmlPanel.Name = "htmlPanel";
            this.htmlPanel.Size = new System.Drawing.Size(598, 367);
            this.htmlPanel.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(6, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Base URL";
            // 
            // baseUrlTextBox
            // 
            this.baseUrlTextBox.Location = new System.Drawing.Point(9, 339);
            this.baseUrlTextBox.Name = "baseUrlTextBox";
            this.baseUrlTextBox.Size = new System.Drawing.Size(575, 21);
            this.baseUrlTextBox.TabIndex = 49;
            // 
            // htmlStringTextBox
            // 
            this.htmlStringTextBox.Location = new System.Drawing.Point(9, 26);
            this.htmlStringTextBox.MaxLength = 1000000;
            this.htmlStringTextBox.Multiline = true;
            this.htmlStringTextBox.Name = "htmlStringTextBox";
            this.htmlStringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.htmlStringTextBox.Size = new System.Drawing.Size(574, 292);
            this.htmlStringTextBox.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label12.Location = new System.Drawing.Point(6, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 16);
            this.label12.TabIndex = 42;
            this.label12.Text = "HTML String with @Media Rules";
            // 
            // urlPanel
            // 
            this.urlPanel.Controls.Add(this.viewHtmlLinkLabel);
            this.urlPanel.Controls.Add(this.enterUrlLabel);
            this.urlPanel.Controls.Add(this.urlTextBox);
            this.urlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.urlPanel.Location = new System.Drawing.Point(6, 135);
            this.urlPanel.Name = "urlPanel";
            this.urlPanel.Size = new System.Drawing.Size(598, 82);
            this.urlPanel.TabIndex = 110;
            this.urlPanel.Visible = false;
            // 
            // viewHtmlLinkLabel
            // 
            this.viewHtmlLinkLabel.AutoSize = true;
            this.viewHtmlLinkLabel.Location = new System.Drawing.Point(515, 47);
            this.viewHtmlLinkLabel.Name = "viewHtmlLinkLabel";
            this.viewHtmlLinkLabel.Size = new System.Drawing.Size(77, 16);
            this.viewHtmlLinkLabel.TabIndex = 48;
            this.viewHtmlLinkLabel.TabStop = true;
            this.viewHtmlLinkLabel.Text = "View HTML";
            this.viewHtmlLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewHtmlLinkLabel_LinkClicked);
            // 
            // enterUrlLabel
            // 
            this.enterUrlLabel.AutoSize = true;
            this.enterUrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.enterUrlLabel.Location = new System.Drawing.Point(6, 12);
            this.enterUrlLabel.Name = "enterUrlLabel";
            this.enterUrlLabel.Size = new System.Drawing.Size(198, 16);
            this.enterUrlLabel.TabIndex = 40;
            this.enterUrlLabel.Text = "HTML Page to Convert URL";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(9, 44);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(500, 21);
            this.urlTextBox.TabIndex = 41;
            // 
            // selectHtmlToConvertPanel
            // 
            this.selectHtmlToConvertPanel.Controls.Add(this.convertHtmlRadioButton);
            this.selectHtmlToConvertPanel.Controls.Add(this.convertUrlRadioButton);
            this.selectHtmlToConvertPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectHtmlToConvertPanel.Location = new System.Drawing.Point(6, 102);
            this.selectHtmlToConvertPanel.Name = "selectHtmlToConvertPanel";
            this.selectHtmlToConvertPanel.Size = new System.Drawing.Size(598, 33);
            this.selectHtmlToConvertPanel.TabIndex = 109;
            // 
            // convertHtmlRadioButton
            // 
            this.convertHtmlRadioButton.AutoSize = true;
            this.convertHtmlRadioButton.Checked = true;
            this.convertHtmlRadioButton.Location = new System.Drawing.Point(9, 8);
            this.convertHtmlRadioButton.Name = "convertHtmlRadioButton";
            this.convertHtmlRadioButton.Size = new System.Drawing.Size(233, 20);
            this.convertHtmlRadioButton.TabIndex = 69;
            this.convertHtmlRadioButton.TabStop = true;
            this.convertHtmlRadioButton.Text = "Convert HTML with @Media Rules";
            this.convertHtmlRadioButton.UseVisualStyleBackColor = true;
            this.convertHtmlRadioButton.CheckedChanged += new System.EventHandler(this.convertHtmlRadioButton_CheckedChanged);
            // 
            // convertUrlRadioButton
            // 
            this.convertUrlRadioButton.AutoSize = true;
            this.convertUrlRadioButton.Location = new System.Drawing.Point(260, 8);
            this.convertUrlRadioButton.Name = "convertUrlRadioButton";
            this.convertUrlRadioButton.Size = new System.Drawing.Size(181, 20);
            this.convertUrlRadioButton.TabIndex = 68;
            this.convertUrlRadioButton.Text = "Convert URL or Local File";
            this.convertUrlRadioButton.UseVisualStyleBackColor = true;
            this.convertUrlRadioButton.CheckedChanged += new System.EventHandler(this.convertUrlRadioButton_CheckedChanged);
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Controls.Add(this.descriptionLabel);
            this.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionPanel.Location = new System.Drawing.Point(6, 46);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(598, 56);
            this.descriptionPanel.TabIndex = 107;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Location = new System.Drawing.Point(0, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(598, 56);
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
            this.titlePanel.TabIndex = 105;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.Location = new System.Drawing.Point(0, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(388, 18);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Select Media Type When Converting HTML to PDF";
            // 
            // demoLeftPanel
            // 
            this.demoLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.demoLeftPanel.Location = new System.Drawing.Point(0, 6);
            this.demoLeftPanel.Name = "demoLeftPanel";
            this.demoLeftPanel.Size = new System.Drawing.Size(6, 732);
            this.demoLeftPanel.TabIndex = 104;
            // 
            // demoRightPanel
            // 
            this.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.demoRightPanel.Location = new System.Drawing.Point(604, 6);
            this.demoRightPanel.Name = "demoRightPanel";
            this.demoRightPanel.Size = new System.Drawing.Size(6, 732);
            this.demoRightPanel.TabIndex = 103;
            // 
            // demoBottomPanel
            // 
            this.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.demoBottomPanel.Location = new System.Drawing.Point(0, 738);
            this.demoBottomPanel.Name = "demoBottomPanel";
            this.demoBottomPanel.Size = new System.Drawing.Size(610, 6);
            this.demoBottomPanel.TabIndex = 102;
            // 
            // demoTopPanel
            // 
            this.demoTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.demoTopPanel.Location = new System.Drawing.Point(0, 0);
            this.demoTopPanel.Name = "demoTopPanel";
            this.demoTopPanel.Size = new System.Drawing.Size(610, 6);
            this.demoTopPanel.TabIndex = 101;
            // 
            // selectMediaTypePanel
            // 
            this.selectMediaTypePanel.Controls.Add(this.printMediaTypeRadioButton);
            this.selectMediaTypePanel.Controls.Add(this.screenMediaTypeRadioButton);
            this.selectMediaTypePanel.Controls.Add(this.label1);
            this.selectMediaTypePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectMediaTypePanel.Location = new System.Drawing.Point(6, 584);
            this.selectMediaTypePanel.Name = "selectMediaTypePanel";
            this.selectMediaTypePanel.Size = new System.Drawing.Size(598, 86);
            this.selectMediaTypePanel.TabIndex = 112;
            // 
            // printMediaTypeRadioButton
            // 
            this.printMediaTypeRadioButton.AutoSize = true;
            this.printMediaTypeRadioButton.Location = new System.Drawing.Point(119, 46);
            this.printMediaTypeRadioButton.Name = "printMediaTypeRadioButton";
            this.printMediaTypeRadioButton.Size = new System.Drawing.Size(55, 20);
            this.printMediaTypeRadioButton.TabIndex = 41;
            this.printMediaTypeRadioButton.Text = "Print";
            this.printMediaTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // screenMediaTypeRadioButton
            // 
            this.screenMediaTypeRadioButton.AutoSize = true;
            this.screenMediaTypeRadioButton.Checked = true;
            this.screenMediaTypeRadioButton.Location = new System.Drawing.Point(32, 46);
            this.screenMediaTypeRadioButton.Name = "screenMediaTypeRadioButton";
            this.screenMediaTypeRadioButton.Size = new System.Drawing.Size(72, 20);
            this.screenMediaTypeRadioButton.TabIndex = 41;
            this.screenMediaTypeRadioButton.TabStop = true;
            this.screenMediaTypeRadioButton.Text = "Screen";
            this.screenMediaTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Select Media Type";
            // 
            // convertButtonPanel
            // 
            this.convertButtonPanel.Controls.Add(this.convertToPdfButton);
            this.convertButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.convertButtonPanel.Location = new System.Drawing.Point(6, 670);
            this.convertButtonPanel.Name = "convertButtonPanel";
            this.convertButtonPanel.Size = new System.Drawing.Size(598, 43);
            this.convertButtonPanel.TabIndex = 113;
            // 
            // convertToPdfButton
            // 
            this.convertToPdfButton.Location = new System.Drawing.Point(6, 6);
            this.convertToPdfButton.Name = "convertToPdfButton";
            this.convertToPdfButton.Size = new System.Drawing.Size(150, 27);
            this.convertToPdfButton.TabIndex = 66;
            this.convertToPdfButton.Text = "Convert HTML to PDF";
            this.convertToPdfButton.UseVisualStyleBackColor = true;
            this.convertToPdfButton.Click += new System.EventHandler(this.convertToPdfButton_Click);
            // 
            // Select_Screen_or_Print_Media_Type_Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.convertButtonPanel);
            this.Controls.Add(this.selectMediaTypePanel);
            this.Controls.Add(this.htmlPanel);
            this.Controls.Add(this.urlPanel);
            this.Controls.Add(this.selectHtmlToConvertPanel);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.demoLeftPanel);
            this.Controls.Add(this.demoRightPanel);
            this.Controls.Add(this.demoBottomPanel);
            this.Controls.Add(this.demoTopPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "Select_Screen_or_Print_Media_Type_Demo";
            this.Size = new System.Drawing.Size(610, 744);
            this.Load += new System.EventHandler(this.Select_Screen_or_Print_Media_Type_Demo_Load);
            this.htmlPanel.ResumeLayout(false);
            this.htmlPanel.PerformLayout();
            this.urlPanel.ResumeLayout(false);
            this.urlPanel.PerformLayout();
            this.selectHtmlToConvertPanel.ResumeLayout(false);
            this.selectHtmlToConvertPanel.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.selectMediaTypePanel.ResumeLayout(false);
            this.selectMediaTypePanel.PerformLayout();
            this.convertButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel htmlPanel;
        private System.Windows.Forms.TextBox htmlStringTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel urlPanel;
        private System.Windows.Forms.Label enterUrlLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Panel selectHtmlToConvertPanel;
        private System.Windows.Forms.RadioButton convertHtmlRadioButton;
        private System.Windows.Forms.RadioButton convertUrlRadioButton;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel demoLeftPanel;
        private System.Windows.Forms.Panel demoRightPanel;
        private System.Windows.Forms.Panel demoBottomPanel;
        private System.Windows.Forms.Panel demoTopPanel;
        private System.Windows.Forms.Panel selectMediaTypePanel;
        private System.Windows.Forms.Panel convertButtonPanel;
        private System.Windows.Forms.Button convertToPdfButton;
        private System.Windows.Forms.RadioButton printMediaTypeRadioButton;
        private System.Windows.Forms.RadioButton screenMediaTypeRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baseUrlTextBox;
        private System.Windows.Forms.LinkLabel viewHtmlLinkLabel;
    }
}

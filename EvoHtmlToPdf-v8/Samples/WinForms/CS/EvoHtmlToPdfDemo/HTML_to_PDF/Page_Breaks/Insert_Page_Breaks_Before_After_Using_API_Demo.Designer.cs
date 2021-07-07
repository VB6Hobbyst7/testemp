namespace EvoHtmlToPdfDemo.HTML_to_PDF.Page_Breaks
{
    partial class Insert_Page_Breaks_Before_After_Using_API_Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insert_Page_Breaks_Before_After_Using_API_Demo));
            this.convertButtonPanel = new System.Windows.Forms.Panel();
            this.convertToPdfButton = new System.Windows.Forms.Button();
            this.htmlPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.baseUrlTextBox = new System.Windows.Forms.TextBox();
            this.htmlStringTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.urlPanel = new System.Windows.Forms.Panel();
            this.viewHtmlLinkLabel = new System.Windows.Forms.LinkLabel();
            this.enterUrlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.htmlElementsAfterSelectorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.htmlElementsBeforeSelectorTextBox = new System.Windows.Forms.TextBox();
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
            this.convertButtonPanel.SuspendLayout();
            this.htmlPanel.SuspendLayout();
            this.urlPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertButtonPanel
            // 
            this.convertButtonPanel.Controls.Add(this.convertToPdfButton);
            this.convertButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.convertButtonPanel.Location = new System.Drawing.Point(6, 677);
            this.convertButtonPanel.Name = "convertButtonPanel";
            this.convertButtonPanel.Size = new System.Drawing.Size(598, 42);
            this.convertButtonPanel.TabIndex = 143;
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
            // htmlPanel
            // 
            this.htmlPanel.Controls.Add(this.label2);
            this.htmlPanel.Controls.Add(this.baseUrlTextBox);
            this.htmlPanel.Controls.Add(this.htmlStringTextBox);
            this.htmlPanel.Controls.Add(this.label12);
            this.htmlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.htmlPanel.Location = new System.Drawing.Point(6, 340);
            this.htmlPanel.Name = "htmlPanel";
            this.htmlPanel.Size = new System.Drawing.Size(598, 337);
            this.htmlPanel.TabIndex = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(6, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Base URL";
            // 
            // baseUrlTextBox
            // 
            this.baseUrlTextBox.Location = new System.Drawing.Point(9, 305);
            this.baseUrlTextBox.Name = "baseUrlTextBox";
            this.baseUrlTextBox.Size = new System.Drawing.Size(575, 21);
            this.baseUrlTextBox.TabIndex = 53;
            // 
            // htmlStringTextBox
            // 
            this.htmlStringTextBox.Location = new System.Drawing.Point(9, 36);
            this.htmlStringTextBox.MaxLength = 1000000;
            this.htmlStringTextBox.Multiline = true;
            this.htmlStringTextBox.Name = "htmlStringTextBox";
            this.htmlStringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.htmlStringTextBox.Size = new System.Drawing.Size(574, 239);
            this.htmlStringTextBox.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 15);
            this.label12.TabIndex = 50;
            this.label12.Text = "HTML String to Convert";
            // 
            // urlPanel
            // 
            this.urlPanel.Controls.Add(this.viewHtmlLinkLabel);
            this.urlPanel.Controls.Add(this.enterUrlLabel);
            this.urlPanel.Controls.Add(this.urlTextBox);
            this.urlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.urlPanel.Location = new System.Drawing.Point(6, 273);
            this.urlPanel.Name = "urlPanel";
            this.urlPanel.Size = new System.Drawing.Size(598, 67);
            this.urlPanel.TabIndex = 141;
            this.urlPanel.Visible = false;
            // 
            // viewHtmlLinkLabel
            // 
            this.viewHtmlLinkLabel.AutoSize = true;
            this.viewHtmlLinkLabel.Location = new System.Drawing.Point(514, 37);
            this.viewHtmlLinkLabel.Name = "viewHtmlLinkLabel";
            this.viewHtmlLinkLabel.Size = new System.Drawing.Size(70, 15);
            this.viewHtmlLinkLabel.TabIndex = 48;
            this.viewHtmlLinkLabel.TabStop = true;
            this.viewHtmlLinkLabel.Text = "View HTML";
            this.viewHtmlLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewHtmlLinkLabel_LinkClicked);
            // 
            // enterUrlLabel
            // 
            this.enterUrlLabel.AutoSize = true;
            this.enterUrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.enterUrlLabel.Location = new System.Drawing.Point(6, 13);
            this.enterUrlLabel.Name = "enterUrlLabel";
            this.enterUrlLabel.Size = new System.Drawing.Size(182, 15);
            this.enterUrlLabel.TabIndex = 42;
            this.enterUrlLabel.Text = "HTML Page to Convert URL";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(8, 34);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(500, 21);
            this.urlTextBox.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.htmlElementsAfterSelectorTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.htmlElementsBeforeSelectorTextBox);
            this.panel2.Controls.Add(this.convertHtmlRadioButton);
            this.panel2.Controls.Add(this.convertUrlRadioButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(6, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 163);
            this.panel2.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 15);
            this.label3.TabIndex = 74;
            this.label3.Text = "CSS Selector of the HTML Elements After Which to Insert Page Breaks";
            // 
            // htmlElementsAfterSelectorTextBox
            // 
            this.htmlElementsAfterSelectorTextBox.Location = new System.Drawing.Point(8, 91);
            this.htmlElementsAfterSelectorTextBox.Name = "htmlElementsAfterSelectorTextBox";
            this.htmlElementsAfterSelectorTextBox.Size = new System.Drawing.Size(576, 21);
            this.htmlElementsAfterSelectorTextBox.TabIndex = 75;
            this.htmlElementsAfterSelectorTextBox.Text = "#page_break_before_and_after_div , #page_break_after_div";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 15);
            this.label1.TabIndex = 74;
            this.label1.Text = "CSS Selector of the HTML Elements Before Which to Insert Page Breaks";
            // 
            // htmlElementsBeforeSelectorTextBox
            // 
            this.htmlElementsBeforeSelectorTextBox.Location = new System.Drawing.Point(8, 33);
            this.htmlElementsBeforeSelectorTextBox.Name = "htmlElementsBeforeSelectorTextBox";
            this.htmlElementsBeforeSelectorTextBox.Size = new System.Drawing.Size(576, 21);
            this.htmlElementsBeforeSelectorTextBox.TabIndex = 75;
            this.htmlElementsBeforeSelectorTextBox.Text = "#page_break_before_and_after_div , #page_break_before_div";
            // 
            // convertHtmlRadioButton
            // 
            this.convertHtmlRadioButton.AutoSize = true;
            this.convertHtmlRadioButton.Checked = true;
            this.convertHtmlRadioButton.Location = new System.Drawing.Point(9, 138);
            this.convertHtmlRadioButton.Name = "convertHtmlRadioButton";
            this.convertHtmlRadioButton.Size = new System.Drawing.Size(145, 20);
            this.convertHtmlRadioButton.TabIndex = 71;
            this.convertHtmlRadioButton.TabStop = true;
            this.convertHtmlRadioButton.Text = "Convert HTML String";
            this.convertHtmlRadioButton.UseVisualStyleBackColor = true;
            this.convertHtmlRadioButton.CheckedChanged += new System.EventHandler(this.convertHtmlRadioButton_CheckedChanged);
            // 
            // convertUrlRadioButton
            // 
            this.convertUrlRadioButton.AutoSize = true;
            this.convertUrlRadioButton.Location = new System.Drawing.Point(192, 138);
            this.convertUrlRadioButton.Name = "convertUrlRadioButton";
            this.convertUrlRadioButton.Size = new System.Drawing.Size(171, 20);
            this.convertUrlRadioButton.TabIndex = 70;
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
            this.descriptionPanel.Size = new System.Drawing.Size(598, 64);
            this.descriptionPanel.TabIndex = 139;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Location = new System.Drawing.Point(0, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(598, 64);
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
            this.titlePanel.TabIndex = 138;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.Location = new System.Drawing.Point(0, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(517, 17);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Insert Page Breaks Before and After HTML Elements in PDF Using API";
            // 
            // demoLeftPanel
            // 
            this.demoLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.demoLeftPanel.Location = new System.Drawing.Point(0, 6);
            this.demoLeftPanel.Name = "demoLeftPanel";
            this.demoLeftPanel.Size = new System.Drawing.Size(6, 728);
            this.demoLeftPanel.TabIndex = 137;
            // 
            // demoRightPanel
            // 
            this.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.demoRightPanel.Location = new System.Drawing.Point(604, 6);
            this.demoRightPanel.Name = "demoRightPanel";
            this.demoRightPanel.Size = new System.Drawing.Size(6, 728);
            this.demoRightPanel.TabIndex = 136;
            // 
            // demoBottomPanel
            // 
            this.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.demoBottomPanel.Location = new System.Drawing.Point(0, 734);
            this.demoBottomPanel.Name = "demoBottomPanel";
            this.demoBottomPanel.Size = new System.Drawing.Size(610, 6);
            this.demoBottomPanel.TabIndex = 135;
            // 
            // demoTopPanel
            // 
            this.demoTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.demoTopPanel.Location = new System.Drawing.Point(0, 0);
            this.demoTopPanel.Name = "demoTopPanel";
            this.demoTopPanel.Size = new System.Drawing.Size(610, 6);
            this.demoTopPanel.TabIndex = 134;
            // 
            // Insert_Page_Breaks_Before_After_Using_API_Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.convertButtonPanel);
            this.Controls.Add(this.htmlPanel);
            this.Controls.Add(this.urlPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.demoLeftPanel);
            this.Controls.Add(this.demoRightPanel);
            this.Controls.Add(this.demoBottomPanel);
            this.Controls.Add(this.demoTopPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "Insert_Page_Breaks_Before_After_Using_API_Demo";
            this.Size = new System.Drawing.Size(610, 740);
            this.Load += new System.EventHandler(this.Insert_Page_Breaks_Before_After_Using_API_Demo_Load);
            this.convertButtonPanel.ResumeLayout(false);
            this.htmlPanel.ResumeLayout(false);
            this.htmlPanel.PerformLayout();
            this.urlPanel.ResumeLayout(false);
            this.urlPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel convertButtonPanel;
        private System.Windows.Forms.Button convertToPdfButton;
        private System.Windows.Forms.Panel htmlPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baseUrlTextBox;
        private System.Windows.Forms.TextBox htmlStringTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel urlPanel;
        private System.Windows.Forms.LinkLabel viewHtmlLinkLabel;
        private System.Windows.Forms.Label enterUrlLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox htmlElementsBeforeSelectorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox htmlElementsAfterSelectorTextBox;
    }
}

namespace EvoHtmlToPdfDemo.PDF_Editor
{
    partial class Merge_PDF_Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Merge_PDF_Demo));
            this.demoLeftPanel = new System.Windows.Forms.Panel();
            this.demoRightPanel = new System.Windows.Forms.Panel();
            this.demoBottomPanel = new System.Windows.Forms.Panel();
            this.demoTopPanel = new System.Windows.Forms.Panel();
            this.convertButtonPanel = new System.Windows.Forms.Panel();
            this.mergePdfButton = new System.Windows.Forms.Button();
            this.urlPanel = new System.Windows.Forms.Panel();
            this.selectSecondPdfFileButton = new System.Windows.Forms.Button();
            this.selectFirstPdfFileButton = new System.Windows.Forms.Button();
            this.secondPdfFilePathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstPdfFilePathTextBox = new System.Windows.Forms.TextBox();
            this.enterUrlLabel = new System.Windows.Forms.Label();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.convertButtonPanel.SuspendLayout();
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
            this.demoLeftPanel.TabIndex = 135;
            // 
            // demoRightPanel
            // 
            this.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.demoRightPanel.Location = new System.Drawing.Point(604, 6);
            this.demoRightPanel.Name = "demoRightPanel";
            this.demoRightPanel.Size = new System.Drawing.Size(6, 638);
            this.demoRightPanel.TabIndex = 134;
            // 
            // demoBottomPanel
            // 
            this.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.demoBottomPanel.Location = new System.Drawing.Point(0, 644);
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
            // convertButtonPanel
            // 
            this.convertButtonPanel.Controls.Add(this.mergePdfButton);
            this.convertButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.convertButtonPanel.Location = new System.Drawing.Point(6, 240);
            this.convertButtonPanel.Name = "convertButtonPanel";
            this.convertButtonPanel.Size = new System.Drawing.Size(598, 42);
            this.convertButtonPanel.TabIndex = 145;
            // 
            // mergePdfButton
            // 
            this.mergePdfButton.Location = new System.Drawing.Point(6, 6);
            this.mergePdfButton.Name = "mergePdfButton";
            this.mergePdfButton.Size = new System.Drawing.Size(86, 27);
            this.mergePdfButton.TabIndex = 66;
            this.mergePdfButton.Text = "Merge PDF";
            this.mergePdfButton.UseVisualStyleBackColor = true;
            this.mergePdfButton.Click += new System.EventHandler(this.mergePdfButton_Click);
            // 
            // urlPanel
            // 
            this.urlPanel.Controls.Add(this.selectSecondPdfFileButton);
            this.urlPanel.Controls.Add(this.selectFirstPdfFileButton);
            this.urlPanel.Controls.Add(this.secondPdfFilePathTextBox);
            this.urlPanel.Controls.Add(this.label2);
            this.urlPanel.Controls.Add(this.firstPdfFilePathTextBox);
            this.urlPanel.Controls.Add(this.enterUrlLabel);
            this.urlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.urlPanel.Location = new System.Drawing.Point(6, 98);
            this.urlPanel.Name = "urlPanel";
            this.urlPanel.Size = new System.Drawing.Size(598, 142);
            this.urlPanel.TabIndex = 143;
            // 
            // selectSecondPdfFileButton
            // 
            this.selectSecondPdfFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectSecondPdfFileButton.Location = new System.Drawing.Point(516, 102);
            this.selectSecondPdfFileButton.Name = "selectSecondPdfFileButton";
            this.selectSecondPdfFileButton.Size = new System.Drawing.Size(66, 26);
            this.selectSecondPdfFileButton.TabIndex = 44;
            this.selectSecondPdfFileButton.Text = "Browse";
            this.selectSecondPdfFileButton.UseVisualStyleBackColor = true;
            this.selectSecondPdfFileButton.Click += new System.EventHandler(this.selectSecondPdfFileButton_Click);
            // 
            // selectFirstPdfFileButton
            // 
            this.selectFirstPdfFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectFirstPdfFileButton.Location = new System.Drawing.Point(516, 37);
            this.selectFirstPdfFileButton.Name = "selectFirstPdfFileButton";
            this.selectFirstPdfFileButton.Size = new System.Drawing.Size(66, 26);
            this.selectFirstPdfFileButton.TabIndex = 44;
            this.selectFirstPdfFileButton.Text = "Browse";
            this.selectFirstPdfFileButton.UseVisualStyleBackColor = true;
            this.selectFirstPdfFileButton.Click += new System.EventHandler(this.selectFirstPdfFileButton_Click);
            // 
            // secondPdfFilePathTextBox
            // 
            this.secondPdfFilePathTextBox.Location = new System.Drawing.Point(9, 105);
            this.secondPdfFilePathTextBox.Name = "secondPdfFilePathTextBox";
            this.secondPdfFilePathTextBox.Size = new System.Drawing.Size(501, 21);
            this.secondPdfFilePathTextBox.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "Second Document to Merge";
            // 
            // firstPdfFilePathTextBox
            // 
            this.firstPdfFilePathTextBox.Location = new System.Drawing.Point(9, 40);
            this.firstPdfFilePathTextBox.Name = "firstPdfFilePathTextBox";
            this.firstPdfFilePathTextBox.Size = new System.Drawing.Size(501, 21);
            this.firstPdfFilePathTextBox.TabIndex = 43;
            // 
            // enterUrlLabel
            // 
            this.enterUrlLabel.AutoSize = true;
            this.enterUrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.enterUrlLabel.Location = new System.Drawing.Point(6, 13);
            this.enterUrlLabel.Name = "enterUrlLabel";
            this.enterUrlLabel.Size = new System.Drawing.Size(165, 15);
            this.enterUrlLabel.TabIndex = 42;
            this.enterUrlLabel.Text = "First Document to Merge";
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
            this.titleLabel.Text = "Merge PDF Documents";
            // 
            // Merge_PDF_Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.convertButtonPanel);
            this.Controls.Add(this.urlPanel);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.demoLeftPanel);
            this.Controls.Add(this.demoRightPanel);
            this.Controls.Add(this.demoBottomPanel);
            this.Controls.Add(this.demoTopPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "Merge_PDF_Demo";
            this.Size = new System.Drawing.Size(610, 650);
            this.Load += new System.EventHandler(this.Merge_PDF_Demo_Load);
            this.convertButtonPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button mergePdfButton;
        private System.Windows.Forms.Panel urlPanel;
        private System.Windows.Forms.Button selectFirstPdfFileButton;
        private System.Windows.Forms.TextBox firstPdfFilePathTextBox;
        private System.Windows.Forms.Label enterUrlLabel;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button selectSecondPdfFileButton;
        private System.Windows.Forms.TextBox secondPdfFilePathTextBox;
        private System.Windows.Forms.Label label2;
    }
}

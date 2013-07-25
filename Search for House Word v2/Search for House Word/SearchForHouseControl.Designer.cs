namespace Search_for_House_Word
{
    partial class SearchForHouseControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.howManyHouses = new System.Windows.Forms.TextBox();
            this.eventResults = new System.Windows.Forms.StatusStrip();
            this.resultStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.wordSearchProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.searchHouseButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.longResultBox = new System.Windows.Forms.TextBox();
            this.eventResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "house count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "input text";
            // 
            // howManyHouses
            // 
            this.howManyHouses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.howManyHouses.Location = new System.Drawing.Point(12, 264);
            this.howManyHouses.Name = "howManyHouses";
            this.howManyHouses.ReadOnly = true;
            this.howManyHouses.Size = new System.Drawing.Size(251, 20);
            this.howManyHouses.TabIndex = 11;
            // 
            // eventResults
            // 
            this.eventResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultStatusLabel,
            this.toolStripStatusLabel1,
            this.wordSearchProgress});
            this.eventResults.Location = new System.Drawing.Point(0, 378);
            this.eventResults.Name = "eventResults";
            this.eventResults.Size = new System.Drawing.Size(650, 22);
            this.eventResults.TabIndex = 10;
            this.eventResults.Text = "eventResultsHere";
            // 
            // resultStatusLabel
            // 
            this.resultStatusLabel.Name = "resultStatusLabel";
            this.resultStatusLabel.Size = new System.Drawing.Size(113, 17);
            this.resultStatusLabel.Text = "Result Appears Here";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(289, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // wordSearchProgress
            // 
            this.wordSearchProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.wordSearchProgress.Name = "wordSearchProgress";
            this.wordSearchProgress.Size = new System.Drawing.Size(200, 16);
            // 
            // inputBox
            // 
            this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox.Location = new System.Drawing.Point(12, 21);
            this.inputBox.MaxLength = 0;
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputBox.Size = new System.Drawing.Size(619, 224);
            this.inputBox.TabIndex = 9;
            // 
            // openFileButton
            // 
            this.openFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openFileButton.Location = new System.Drawing.Point(557, 297);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 8;
            this.openFileButton.Text = "...";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // searchHouseButton
            // 
            this.searchHouseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchHouseButton.Location = new System.Drawing.Point(557, 326);
            this.searchHouseButton.Name = "searchHouseButton";
            this.searchHouseButton.Size = new System.Drawing.Size(75, 23);
            this.searchHouseButton.TabIndex = 7;
            this.searchHouseButton.Text = "Search";
            this.searchHouseButton.UseVisualStyleBackColor = true;
            this.searchHouseButton.Click += new System.EventHandler(this.searchHouseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // longResultBox
            // 
            this.longResultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.longResultBox.Location = new System.Drawing.Point(15, 300);
            this.longResultBox.Multiline = true;
            this.longResultBox.Name = "longResultBox";
            this.longResultBox.ReadOnly = true;
            this.longResultBox.Size = new System.Drawing.Size(536, 49);
            this.longResultBox.TabIndex = 14;
            // 
            // SearchForHouseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.longResultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.howManyHouses);
            this.Controls.Add(this.eventResults);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.searchHouseButton);
            this.Name = "SearchForHouseControl";
            this.Size = new System.Drawing.Size(650, 400);
            this.eventResults.ResumeLayout(false);
            this.eventResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox howManyHouses;
        private System.Windows.Forms.StatusStrip eventResults;
        private System.Windows.Forms.ToolStripStatusLabel resultStatusLabel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox longResultBox;
        private System.Windows.Forms.ToolStripProgressBar wordSearchProgress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button searchHouseButton;
    }
}

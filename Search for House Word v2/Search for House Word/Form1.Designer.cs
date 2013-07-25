namespace Search_for_House_Word
{
    partial class searchForHouse
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchHouseButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.eventResults = new System.Windows.Forms.StatusStrip();
            this.resultStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.howManyHouses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.eventResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchHouseButton
            // 
            this.searchHouseButton.Location = new System.Drawing.Point(557, 330);
            this.searchHouseButton.Name = "searchHouseButton";
            this.searchHouseButton.Size = new System.Drawing.Size(75, 23);
            this.searchHouseButton.TabIndex = 0;
            this.searchHouseButton.Text = "Search";
            this.searchHouseButton.UseVisualStyleBackColor = true;
            this.searchHouseButton.Click += new System.EventHandler(this.searchHouseButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(557, 301);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "...";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 25);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(619, 224);
            this.inputBox.TabIndex = 2;
            // 
            // eventResults
            // 
            this.eventResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultStatusLabel});
            this.eventResults.Location = new System.Drawing.Point(0, 356);
            this.eventResults.Name = "eventResults";
            this.eventResults.Size = new System.Drawing.Size(644, 22);
            this.eventResults.TabIndex = 3;
            this.eventResults.Text = "eventResultsHere";
            // 
            // resultStatusLabel
            // 
            this.resultStatusLabel.Name = "resultStatusLabel";
            this.resultStatusLabel.Size = new System.Drawing.Size(113, 17);
            this.resultStatusLabel.Text = "Result Appears Here";
            // 
            // howManyHouses
            // 
            this.howManyHouses.Location = new System.Drawing.Point(12, 268);
            this.howManyHouses.Name = "howManyHouses";
            this.howManyHouses.ReadOnly = true;
            this.howManyHouses.Size = new System.Drawing.Size(251, 20);
            this.howManyHouses.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "input text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "house count";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // searchForHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.howManyHouses);
            this.Controls.Add(this.eventResults);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.searchHouseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "searchForHouse";
            this.Text = "Search for \"House\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.eventResults.ResumeLayout(false);
            this.eventResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchHouseButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.StatusStrip eventResults;
        private System.Windows.Forms.TextBox howManyHouses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel resultStatusLabel;
    }
}


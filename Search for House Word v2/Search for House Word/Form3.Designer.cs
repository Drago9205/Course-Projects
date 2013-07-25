namespace Search_for_House_Word
{
    partial class searchHouse
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddTabs = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.globalProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.removeTab = new System.Windows.Forms.Button();
            this.checkAll = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AddTabs
            // 
            this.AddTabs.Location = new System.Drawing.Point(958, 12);
            this.AddTabs.Name = "AddTabs";
            this.AddTabs.Size = new System.Drawing.Size(98, 27);
            this.AddTabs.TabIndex = 2;
            this.AddTabs.Text = "AddTabs";
            this.AddTabs.UseVisualStyleBackColor = true;
            this.AddTabs.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 575);
            this.tabControl1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.globalProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1068, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // globalProgress
            // 
            this.globalProgress.Name = "globalProgress";
            this.globalProgress.Size = new System.Drawing.Size(1054, 16);
            // 
            // removeTab
            // 
            this.removeTab.Location = new System.Drawing.Point(958, 45);
            this.removeTab.Name = "removeTab";
            this.removeTab.Size = new System.Drawing.Size(98, 32);
            this.removeTab.TabIndex = 4;
            this.removeTab.Text = "RemoveTab";
            this.removeTab.UseVisualStyleBackColor = true;
            this.removeTab.Click += new System.EventHandler(this.removeTab_Click);
            // 
            // checkAll
            // 
            this.checkAll.Location = new System.Drawing.Point(958, 546);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(98, 34);
            this.checkAll.TabIndex = 5;
            this.checkAll.Text = "CalculateAll";
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.Click += new System.EventHandler(this.checkAll_Click);
            // 
            // searchHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 612);
            this.Controls.Add(this.checkAll);
            this.Controls.Add(this.removeTab);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.AddTabs);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "searchHouse";
            this.Text = "Search for word";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button AddTabs;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripProgressBar globalProgress;
        private System.Windows.Forms.Button removeTab;
        private System.Windows.Forms.Button checkAll;
    }
}
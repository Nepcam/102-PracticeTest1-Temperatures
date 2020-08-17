namespace _102_PracticeTest1_Temperatures
{
    partial class Form1
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
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.graphAverageTempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMaxAverageTempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.buttonFindTemp = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            this.textBoxHigh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(12, 37);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(776, 401);
            this.pictureBoxDisplay.TabIndex = 0;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1237, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem1,
            this.graphAverageTempToolStripMenuItem,
            this.showMaxAverageTempToolStripMenuItem});
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.loadFileToolStripMenuItem.Text = "File";
            // 
            // loadFileToolStripMenuItem1
            // 
            this.loadFileToolStripMenuItem1.Name = "loadFileToolStripMenuItem1";
            this.loadFileToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.loadFileToolStripMenuItem1.Text = "Load File...";
            this.loadFileToolStripMenuItem1.Click += new System.EventHandler(this.loadFileToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBoxData
            // 
            this.listBoxData.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 14;
            this.listBoxData.Location = new System.Drawing.Point(794, 37);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(328, 396);
            this.listBoxData.TabIndex = 2;
            // 
            // graphAverageTempToolStripMenuItem
            // 
            this.graphAverageTempToolStripMenuItem.Name = "graphAverageTempToolStripMenuItem";
            this.graphAverageTempToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.graphAverageTempToolStripMenuItem.Text = "Graph average Temp";
            this.graphAverageTempToolStripMenuItem.Click += new System.EventHandler(this.graphAverageTempToolStripMenuItem_Click);
            // 
            // showMaxAverageTempToolStripMenuItem
            // 
            this.showMaxAverageTempToolStripMenuItem.Name = "showMaxAverageTempToolStripMenuItem";
            this.showMaxAverageTempToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.showMaxAverageTempToolStripMenuItem.Text = "Show max average Temp";
            this.showMaxAverageTempToolStripMenuItem.Click += new System.EventHandler(this.showMaxAverageTempToolStripMenuItem_Click);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(1128, 36);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 3;
            // 
            // buttonFindTemp
            // 
            this.buttonFindTemp.Location = new System.Drawing.Point(1128, 68);
            this.buttonFindTemp.Name = "buttonFindTemp";
            this.buttonFindTemp.Size = new System.Drawing.Size(100, 56);
            this.buttonFindTemp.TabIndex = 4;
            this.buttonFindTemp.Text = "Find Temperatures";
            this.buttonFindTemp.UseVisualStyleBackColor = true;
            this.buttonFindTemp.Click += new System.EventHandler(this.buttonFindTemp_Click);
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(1128, 173);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(100, 56);
            this.buttonCount.TabIndex = 6;
            this.buttonCount.Text = "Count Dates";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // textBoxHigh
            // 
            this.textBoxHigh.Location = new System.Drawing.Point(1128, 141);
            this.textBoxHigh.Name = "textBoxHigh";
            this.textBoxHigh.Size = new System.Drawing.Size(100, 20);
            this.textBoxHigh.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 450);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBoxHigh);
            this.Controls.Add(this.buttonFindTemp);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "102 Practice Test 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.ToolStripMenuItem graphAverageTempToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMaxAverageTempToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Button buttonFindTemp;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.TextBox textBoxHigh;
    }
}


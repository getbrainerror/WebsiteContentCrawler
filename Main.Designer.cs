namespace WebsiteContentCrawler
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectSavePath = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUrls = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.folderBrowserSaveLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDownMaxCountUp = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinCountUp = new System.Windows.Forms.NumericUpDown();
            this.checkBoxCountUp = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRegexSortDown = new System.Windows.Forms.Button();
            this.btnRegexSortUp = new System.Windows.Forms.Button();
            this.listBoxRegex = new System.Windows.Forms.ListBox();
            this.contextMenuRegex = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogRegex = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogRegex = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorkerCrawl = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialogUrlList = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogUrlList = new System.Windows.Forms.OpenFileDialog();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuUrllist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCountUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinCountUp)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.contextMenuRegex.SuspendLayout();
            this.contextMenuUrllist.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSelectSavePath);
            this.groupBox1.Controls.Add(this.txtSavePath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Folder";
            // 
            // btnSelectSavePath
            // 
            this.btnSelectSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectSavePath.Location = new System.Drawing.Point(549, 30);
            this.btnSelectSavePath.Name = "btnSelectSavePath";
            this.btnSelectSavePath.Size = new System.Drawing.Size(44, 20);
            this.btnSelectSavePath.TabIndex = 1;
            this.btnSelectSavePath.Text = "...";
            this.btnSelectSavePath.UseVisualStyleBackColor = true;
            // 
            // txtSavePath
            // 
            this.txtSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSavePath.Location = new System.Drawing.Point(16, 30);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(527, 20);
            this.txtSavePath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtUrls);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 142);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Urls";
            // 
            // txtUrls
            // 
            this.txtUrls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrls.ContextMenuStrip = this.contextMenuUrllist;
            this.txtUrls.Location = new System.Drawing.Point(16, 29);
            this.txtUrls.Multiline = true;
            this.txtUrls.Name = "txtUrls";
            this.txtUrls.Size = new System.Drawing.Size(578, 78);
            this.txtUrls.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max:";
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.Location = new System.Drawing.Point(12, 419);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(469, 30);
            this.pbProgress.TabIndex = 10;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(487, 419);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 30);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.numericUpDownMaxCountUp);
            this.groupBox5.Controls.Add(this.numericUpDownMinCountUp);
            this.groupBox5.Controls.Add(this.checkBoxCountUp);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(426, 235);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(202, 178);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Extra Stuff";
            // 
            // numericUpDownMaxCountUp
            // 
            this.numericUpDownMaxCountUp.Enabled = false;
            this.numericUpDownMaxCountUp.Location = new System.Drawing.Point(101, 70);
            this.numericUpDownMaxCountUp.Name = "numericUpDownMaxCountUp";
            this.numericUpDownMaxCountUp.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownMaxCountUp.TabIndex = 2;
            this.numericUpDownMaxCountUp.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownMinCountUp
            // 
            this.numericUpDownMinCountUp.Enabled = false;
            this.numericUpDownMinCountUp.Location = new System.Drawing.Point(101, 44);
            this.numericUpDownMinCountUp.Name = "numericUpDownMinCountUp";
            this.numericUpDownMinCountUp.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownMinCountUp.TabIndex = 2;
            this.numericUpDownMinCountUp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxCountUp
            // 
            this.checkBoxCountUp.AutoSize = true;
            this.checkBoxCountUp.Location = new System.Drawing.Point(16, 26);
            this.checkBoxCountUp.Name = "checkBoxCountUp";
            this.checkBoxCountUp.Size = new System.Drawing.Size(69, 17);
            this.checkBoxCountUp.TabIndex = 1;
            this.checkBoxCountUp.Text = "Count up";
            this.toolTipHelp.SetToolTip(this.checkBoxCountUp, "Use {count} where should be a number");
            this.checkBoxCountUp.UseVisualStyleBackColor = true;
            this.checkBoxCountUp.CheckedChanged += new System.EventHandler(this.checkBoxCountUp_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Min:";
            // 
            // toolTipHelp
            // 
            this.toolTipHelp.AutomaticDelay = 200;
            this.toolTipHelp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHelp.ToolTipTitle = "Help:";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.btnRegexSortDown);
            this.groupBox6.Controls.Add(this.btnRegexSortUp);
            this.groupBox6.Controls.Add(this.listBoxRegex);
            this.groupBox6.Location = new System.Drawing.Point(12, 235);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(408, 178);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Regex";
            // 
            // btnRegexSortDown
            // 
            this.btnRegexSortDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegexSortDown.Image = global::WebsiteContentCrawler.Properties.Resources.arrow_down;
            this.btnRegexSortDown.Location = new System.Drawing.Point(369, 66);
            this.btnRegexSortDown.Name = "btnRegexSortDown";
            this.btnRegexSortDown.Size = new System.Drawing.Size(33, 34);
            this.btnRegexSortDown.TabIndex = 1;
            this.btnRegexSortDown.UseVisualStyleBackColor = true;
            this.btnRegexSortDown.Click += new System.EventHandler(this.btnRegexSortDown_Click);
            // 
            // btnRegexSortUp
            // 
            this.btnRegexSortUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegexSortUp.Image = global::WebsiteContentCrawler.Properties.Resources.arrow_up;
            this.btnRegexSortUp.Location = new System.Drawing.Point(368, 26);
            this.btnRegexSortUp.Name = "btnRegexSortUp";
            this.btnRegexSortUp.Size = new System.Drawing.Size(33, 34);
            this.btnRegexSortUp.TabIndex = 1;
            this.btnRegexSortUp.UseVisualStyleBackColor = true;
            this.btnRegexSortUp.Click += new System.EventHandler(this.btnRegexSortUp_Click);
            // 
            // listBoxRegex
            // 
            this.listBoxRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRegex.ContextMenuStrip = this.contextMenuRegex;
            this.listBoxRegex.FormattingEnabled = true;
            this.listBoxRegex.Location = new System.Drawing.Point(16, 27);
            this.listBoxRegex.Name = "listBoxRegex";
            this.listBoxRegex.Size = new System.Drawing.Size(346, 134);
            this.listBoxRegex.TabIndex = 0;
            // 
            // contextMenuRegex
            // 
            this.contextMenuRegex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.contextMenuRegex.Name = "contextMenuRegex";
            this.contextMenuRegex.Size = new System.Drawing.Size(118, 120);
            this.contextMenuRegex.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuRegex_Opening);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveFileDialogRegex
            // 
            this.saveFileDialogRegex.Filter = "Regex list|*.rgxlst";
            // 
            // openFileDialogRegex
            // 
            this.openFileDialogRegex.Filter = "Regex list|*.rgxlst";
            // 
            // backgroundWorkerCrawl
            // 
            this.backgroundWorkerCrawl.WorkerReportsProgress = true;
            this.backgroundWorkerCrawl.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCrawl_DoWork);
            this.backgroundWorkerCrawl.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCrawl_RunWorkerCompleted);
            // 
            // saveFileDialogUrlList
            // 
            this.saveFileDialogUrlList.Filter = "Url list|*.urllst";
            // 
            // openFileDialogUrlList
            // 
            this.openFileDialogUrlList.Filter = "Url list|*.urllst";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(32, 19);
            // 
            // contextMenuUrllist
            // 
            this.contextMenuUrllist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.loadToolStripMenuItem1});
            this.contextMenuUrllist.Name = "contextMenuUrllist";
            this.contextMenuUrllist.Size = new System.Drawing.Size(101, 48);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.loadToolStripMenuItem1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 461);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.btnStart);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Main";
            this.Text = "Website Content Crawler";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCountUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinCountUp)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.contextMenuRegex.ResumeLayout(false);
            this.contextMenuUrllist.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectSavePath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUrls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserSaveLocation;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ContextMenuStrip contextMenuRegex;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxRegex;
        private System.Windows.Forms.Button btnRegexSortUp;
        private System.Windows.Forms.Button btnRegexSortDown;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogRegex;
        private System.Windows.Forms.OpenFileDialog openFileDialogRegex;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCrawl;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxCountUp;
        private System.Windows.Forms.NumericUpDown numericUpDownMinCountUp;
        private System.Windows.Forms.CheckBox checkBoxCountUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialogUrlList;
        private System.Windows.Forms.OpenFileDialog openFileDialogUrlList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ContextMenuStrip contextMenuUrllist;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
    }
}


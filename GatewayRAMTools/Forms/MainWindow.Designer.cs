namespace GatewayRAMTools
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlListView = new System.Windows.Forms.Panel();
            this.lstFiles = new System.Windows.Forms.ListView();
            this.filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filepath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgAddFiles = new System.Windows.Forms.OpenFileDialog();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.addFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.allGatewayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRAWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSelectedPartitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportRAWRAMDumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheatFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointerAddressSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlListView.SuspendLayout();
            this.pnlProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.toolStripSeparator2,
            this.viewSelectedPartitionToolStripMenuItem,
            this.exportRAWRAMDumpToolStripMenuItem,
            this.cheatFinderToolStripMenuItem,
            this.pointerAddressSearchToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator3,
            this.supportToolStripMenuItem,
            this.projectHomepageToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnRemove);
            this.pnlButtons.Controls.Add(this.btnAddFiles);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 239);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.pnlButtons.Size = new System.Drawing.Size(384, 37);
            this.pnlButtons.TabIndex = 1;
            // 
            // pnlListView
            // 
            this.pnlListView.Controls.Add(this.lstFiles);
            this.pnlListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListView.Location = new System.Drawing.Point(0, 24);
            this.pnlListView.Name = "pnlListView";
            this.pnlListView.Padding = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.pnlListView.Size = new System.Drawing.Size(384, 195);
            this.pnlListView.TabIndex = 2;
            // 
            // lstFiles
            // 
            this.lstFiles.CheckBoxes = true;
            this.lstFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.filename,
            this.size,
            this.type,
            this.filepath});
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFiles.FullRowSelect = true;
            this.lstFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstFiles.Location = new System.Drawing.Point(6, 0);
            this.lstFiles.MultiSelect = false;
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(372, 189);
            this.lstFiles.TabIndex = 3;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            this.lstFiles.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstFiles_ItemChecked);
            this.lstFiles.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstFiles_ItemSelectionChanged);
            this.lstFiles.DoubleClick += new System.EventHandler(this.lstFiles_DoubleClick);
            // 
            // filename
            // 
            this.filename.Text = "Filename";
            this.filename.Width = 54;
            // 
            // size
            // 
            this.size.Text = "Size";
            this.size.Width = 32;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 36;
            // 
            // filepath
            // 
            this.filepath.Text = "File Path";
            this.filepath.Width = 223;
            // 
            // dgAddFiles
            // 
            this.dgAddFiles.Filter = "RAM Dumps|*.bin|All Files|*.*";
            this.dgAddFiles.Multiselect = true;
            this.dgAddFiles.Title = "RAM Dumps";
            // 
            // pnlProgress
            // 
            this.pnlProgress.Controls.Add(this.pbar);
            this.pnlProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProgress.Location = new System.Drawing.Point(0, 219);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Padding = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.pnlProgress.Size = new System.Drawing.Size(384, 20);
            this.pnlProgress.TabIndex = 4;
            this.pnlProgress.Visible = false;
            // 
            // pbar
            // 
            this.pbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbar.Location = new System.Drawing.Point(6, 0);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(372, 14);
            this.pbar.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.Enabled = false;
            this.btnRemove.Image = global::GatewayRAMTools.Properties.Resources.document_minus;
            this.btnRemove.Location = new System.Drawing.Point(268, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 31);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Ticked";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.AutoSize = true;
            this.btnAddFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddFiles.Image = global::GatewayRAMTools.Properties.Resources.document_plus;
            this.btnAddFiles.Location = new System.Drawing.Point(6, 0);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(110, 31);
            this.btnAddFiles.TabIndex = 0;
            this.btnAddFiles.Text = "Add Files..";
            this.btnAddFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // addFilesToolStripMenuItem
            // 
            this.addFilesToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.document_plus;
            this.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
            this.addFilesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addFilesToolStripMenuItem.Text = "Add Files..";
            this.addFilesToolStripMenuItem.Click += new System.EventHandler(this.addFilesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.cross_circle;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.noneToolStripMenuItem,
            this.toolStripSeparator4,
            this.allGatewayToolStripMenuItem,
            this.allRAWToolStripMenuItem});
            this.selectToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.node_magnifier;
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.node_select_all;
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.node;
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(133, 6);
            // 
            // allGatewayToolStripMenuItem
            // 
            this.allGatewayToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.node_select_previous;
            this.allGatewayToolStripMenuItem.Name = "allGatewayToolStripMenuItem";
            this.allGatewayToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.allGatewayToolStripMenuItem.Text = "All Gateway";
            this.allGatewayToolStripMenuItem.Click += new System.EventHandler(this.allRAWToolStripMenuItem_Click);
            // 
            // allRAWToolStripMenuItem
            // 
            this.allRAWToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.node_select_next;
            this.allRAWToolStripMenuItem.Name = "allRAWToolStripMenuItem";
            this.allRAWToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.allRAWToolStripMenuItem.Text = "All RAW";
            this.allRAWToolStripMenuItem.Click += new System.EventHandler(this.allRAWToolStripMenuItem_Click_1);
            // 
            // viewSelectedPartitionToolStripMenuItem
            // 
            this.viewSelectedPartitionToolStripMenuItem.Enabled = false;
            this.viewSelectedPartitionToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.database;
            this.viewSelectedPartitionToolStripMenuItem.Name = "viewSelectedPartitionToolStripMenuItem";
            this.viewSelectedPartitionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.viewSelectedPartitionToolStripMenuItem.Text = "View Selected Partition";
            this.viewSelectedPartitionToolStripMenuItem.Click += new System.EventHandler(this.viewSelectedPartitionToolStripMenuItem_Click);
            // 
            // exportRAWRAMDumpToolStripMenuItem
            // 
            this.exportRAWRAMDumpToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.drive_download;
            this.exportRAWRAMDumpToolStripMenuItem.Name = "exportRAWRAMDumpToolStripMenuItem";
            this.exportRAWRAMDumpToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.exportRAWRAMDumpToolStripMenuItem.Text = "Export RAW RAM Dump";
            this.exportRAWRAMDumpToolStripMenuItem.Click += new System.EventHandler(this.exportRAWRAMDumpToolStripMenuItem_Click);
            // 
            // cheatFinderToolStripMenuItem
            // 
            this.cheatFinderToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.document_search_result;
            this.cheatFinderToolStripMenuItem.Name = "cheatFinderToolStripMenuItem";
            this.cheatFinderToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cheatFinderToolStripMenuItem.Text = "Fixed Address Search";
            this.cheatFinderToolStripMenuItem.Click += new System.EventHandler(this.cheatFinderToolStripMenuItem_Click);
            // 
            // pointerAddressSearchToolStripMenuItem
            // 
            this.pointerAddressSearchToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.hand_point_090;
            this.pointerAddressSearchToolStripMenuItem.Name = "pointerAddressSearchToolStripMenuItem";
            this.pointerAddressSearchToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.pointerAddressSearchToolStripMenuItem.Text = "Pointer Address Search";
            this.pointerAddressSearchToolStripMenuItem.Click += new System.EventHandler(this.pointerAddressSearchToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.stickman_smiley_question;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.book_question;
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.supportToolStripMenuItem.Text = "Support";
            this.supportToolStripMenuItem.Click += new System.EventHandler(this.supportToolStripMenuItem_Click);
            // 
            // projectHomepageToolStripMenuItem
            // 
            this.projectHomepageToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.git;
            this.projectHomepageToolStripMenuItem.Name = "projectHomepageToolStripMenuItem";
            this.projectHomepageToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.projectHomepageToolStripMenuItem.Text = "Project Homepage";
            this.projectHomepageToolStripMenuItem.Click += new System.EventHandler(this.projectHomepageToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 276);
            this.Controls.Add(this.pnlListView);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 315);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gateway RAM Tools v";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlListView.ResumeLayout(false);
            this.pnlProgress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem viewSelectedPartitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportRAWRAMDumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectHomepageToolStripMenuItem;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Panel pnlListView;
        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.ColumnHeader filename;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader filepath;
        private System.Windows.Forms.OpenFileDialog dgAddFiles;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem allGatewayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRAWToolStripMenuItem;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.ToolStripMenuItem cheatFinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointerAddressSearchToolStripMenuItem;
    }
}


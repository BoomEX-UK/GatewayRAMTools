namespace GatewayRAMTools
{
    partial class FixedAddrWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixedAddrWindow));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.tblExactValue = new System.Windows.Forms.TableLayoutPanel();
            this.rad8S = new System.Windows.Forms.RadioButton();
            this.rad16S = new System.Windows.Forms.RadioButton();
            this.rad32S = new System.Windows.Forms.RadioButton();
            this.rad8U = new System.Windows.Forms.RadioButton();
            this.rad16U = new System.Windows.Forms.RadioButton();
            this.rad32U = new System.Windows.Forms.RadioButton();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.grpMem = new System.Windows.Forms.GroupBox();
            this.lstMem = new System.Windows.Forms.ListView();
            this.RAMFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RAMTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuRegions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.invertSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpVal = new System.Windows.Forms.GroupBox();
            this.gridValues = new System.Windows.Forms.DataGridView();
            this.filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repResults = new System.Windows.Forms.GroupBox();
            this.tableResults = new System.Windows.Forms.TableLayoutPanel();
            this.lstResults = new System.Windows.Forms.ListView();
            this.colRAM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFoundIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progSearch = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.grpType.SuspendLayout();
            this.tblExactValue.SuspendLayout();
            this.grpMem.SuspendLayout();
            this.menuRegions.SuspendLayout();
            this.grpVal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridValues)).BeginInit();
            this.repResults.SuspendLayout();
            this.tableResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.grpType, 0, 0);
            this.tblMain.Controls.Add(this.grpMem, 0, 1);
            this.tblMain.Controls.Add(this.grpVal, 0, 2);
            this.tblMain.Controls.Add(this.repResults, 1, 0);
            this.tblMain.Controls.Add(this.btnClose, 1, 3);
            this.tblMain.Controls.Add(this.btnSearch, 0, 3);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(6, 6);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblMain.Size = new System.Drawing.Size(532, 470);
            this.tblMain.TabIndex = 0;
            this.tblMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.tblExactValue);
            this.grpType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpType.Location = new System.Drawing.Point(3, 3);
            this.grpType.Name = "grpType";
            this.grpType.Padding = new System.Windows.Forms.Padding(6);
            this.grpType.Size = new System.Drawing.Size(244, 129);
            this.grpType.TabIndex = 5;
            this.grpType.TabStop = false;
            this.grpType.Text = "Search Type";
            // 
            // tblExactValue
            // 
            this.tblExactValue.ColumnCount = 2;
            this.tblExactValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblExactValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblExactValue.Controls.Add(this.rad8S, 1, 1);
            this.tblExactValue.Controls.Add(this.rad16S, 1, 2);
            this.tblExactValue.Controls.Add(this.rad32S, 1, 3);
            this.tblExactValue.Controls.Add(this.rad8U, 0, 1);
            this.tblExactValue.Controls.Add(this.rad16U, 0, 2);
            this.tblExactValue.Controls.Add(this.rad32U, 0, 3);
            this.tblExactValue.Controls.Add(this.comboType, 0, 0);
            this.tblExactValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblExactValue.Location = new System.Drawing.Point(6, 19);
            this.tblExactValue.Name = "tblExactValue";
            this.tblExactValue.RowCount = 4;
            this.tblExactValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblExactValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblExactValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblExactValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblExactValue.Size = new System.Drawing.Size(232, 104);
            this.tblExactValue.TabIndex = 0;
            // 
            // rad8S
            // 
            this.rad8S.AutoSize = true;
            this.rad8S.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rad8S.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rad8S.Location = new System.Drawing.Point(119, 29);
            this.rad8S.Name = "rad8S";
            this.rad8S.Size = new System.Drawing.Size(110, 20);
            this.rad8S.TabIndex = 0;
            this.rad8S.Text = "8 Bit Signed";
            this.rad8S.UseVisualStyleBackColor = true;
            // 
            // rad16S
            // 
            this.rad16S.AutoSize = true;
            this.rad16S.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rad16S.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rad16S.Location = new System.Drawing.Point(119, 55);
            this.rad16S.Name = "rad16S";
            this.rad16S.Size = new System.Drawing.Size(110, 20);
            this.rad16S.TabIndex = 1;
            this.rad16S.Text = "16 Bit Signed";
            this.rad16S.UseVisualStyleBackColor = true;
            // 
            // rad32S
            // 
            this.rad32S.AutoSize = true;
            this.rad32S.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rad32S.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rad32S.Location = new System.Drawing.Point(119, 81);
            this.rad32S.Name = "rad32S";
            this.rad32S.Size = new System.Drawing.Size(110, 20);
            this.rad32S.TabIndex = 2;
            this.rad32S.Text = "32 Bit Signed";
            this.rad32S.UseVisualStyleBackColor = true;
            // 
            // rad8U
            // 
            this.rad8U.AutoSize = true;
            this.rad8U.Checked = true;
            this.rad8U.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rad8U.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rad8U.Location = new System.Drawing.Point(3, 29);
            this.rad8U.Name = "rad8U";
            this.rad8U.Size = new System.Drawing.Size(110, 20);
            this.rad8U.TabIndex = 3;
            this.rad8U.TabStop = true;
            this.rad8U.Text = "8 Bit Unsigned";
            this.rad8U.UseVisualStyleBackColor = true;
            // 
            // rad16U
            // 
            this.rad16U.AutoSize = true;
            this.rad16U.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rad16U.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rad16U.Location = new System.Drawing.Point(3, 55);
            this.rad16U.Name = "rad16U";
            this.rad16U.Size = new System.Drawing.Size(110, 20);
            this.rad16U.TabIndex = 4;
            this.rad16U.Text = "16 Bit Unsigned";
            this.rad16U.UseVisualStyleBackColor = true;
            // 
            // rad32U
            // 
            this.rad32U.AutoSize = true;
            this.rad32U.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rad32U.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rad32U.Location = new System.Drawing.Point(3, 81);
            this.rad32U.Name = "rad32U";
            this.rad32U.Size = new System.Drawing.Size(110, 20);
            this.rad32U.TabIndex = 5;
            this.rad32U.Text = "32 Bit Unsigned";
            this.rad32U.UseVisualStyleBackColor = true;
            // 
            // comboType
            // 
            this.tblExactValue.SetColumnSpan(this.comboType, 2);
            this.comboType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.Enabled = false;
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Exact Value",
            "Unknown Initial Value"});
            this.comboType.Location = new System.Drawing.Point(3, 3);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(226, 21);
            this.comboType.TabIndex = 6;
            // 
            // grpMem
            // 
            this.grpMem.Controls.Add(this.lstMem);
            this.grpMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMem.Location = new System.Drawing.Point(3, 138);
            this.grpMem.Name = "grpMem";
            this.grpMem.Padding = new System.Windows.Forms.Padding(6);
            this.grpMem.Size = new System.Drawing.Size(244, 143);
            this.grpMem.TabIndex = 7;
            this.grpMem.TabStop = false;
            this.grpMem.Text = "Memory Regions";
            // 
            // lstMem
            // 
            this.lstMem.CheckBoxes = true;
            this.lstMem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RAMFrom,
            this.RAMTo});
            this.lstMem.ContextMenuStrip = this.menuRegions;
            this.lstMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMem.FullRowSelect = true;
            this.lstMem.GridLines = true;
            this.lstMem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstMem.Location = new System.Drawing.Point(6, 19);
            this.lstMem.Name = "lstMem";
            this.lstMem.Size = new System.Drawing.Size(232, 118);
            this.lstMem.TabIndex = 5;
            this.lstMem.UseCompatibleStateImageBehavior = false;
            this.lstMem.View = System.Windows.Forms.View.Details;
            // 
            // RAMFrom
            // 
            this.RAMFrom.Text = "RAM From";
            this.RAMFrom.Width = 105;
            // 
            // RAMTo
            // 
            this.RAMTo.Text = "RAM To";
            this.RAMTo.Width = 105;
            // 
            // menuRegions
            // 
            this.menuRegions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.selectNoneToolStripMenuItem,
            this.toolStripSeparator1,
            this.invertSelectionToolStripMenuItem});
            this.menuRegions.Name = "menuRegions";
            this.menuRegions.Size = new System.Drawing.Size(156, 76);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.node_select_all;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // selectNoneToolStripMenuItem
            // 
            this.selectNoneToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.node;
            this.selectNoneToolStripMenuItem.Name = "selectNoneToolStripMenuItem";
            this.selectNoneToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.selectNoneToolStripMenuItem.Text = "Select None";
            this.selectNoneToolStripMenuItem.Click += new System.EventHandler(this.selectNoneToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // invertSelectionToolStripMenuItem
            // 
            this.invertSelectionToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.node_select_next;
            this.invertSelectionToolStripMenuItem.Name = "invertSelectionToolStripMenuItem";
            this.invertSelectionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.invertSelectionToolStripMenuItem.Text = "Invert Selection";
            this.invertSelectionToolStripMenuItem.Click += new System.EventHandler(this.invertSelectionToolStripMenuItem_Click);
            // 
            // grpVal
            // 
            this.grpVal.Controls.Add(this.gridValues);
            this.grpVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVal.Location = new System.Drawing.Point(3, 287);
            this.grpVal.Name = "grpVal";
            this.grpVal.Padding = new System.Windows.Forms.Padding(6);
            this.grpVal.Size = new System.Drawing.Size(244, 143);
            this.grpVal.TabIndex = 8;
            this.grpVal.TabStop = false;
            this.grpVal.Text = "Values";
            // 
            // gridValues
            // 
            this.gridValues.AllowUserToAddRows = false;
            this.gridValues.AllowUserToDeleteRows = false;
            this.gridValues.AllowUserToResizeColumns = false;
            this.gridValues.AllowUserToResizeRows = false;
            this.gridValues.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filename,
            this.colValue});
            this.gridValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridValues.Location = new System.Drawing.Point(6, 19);
            this.gridValues.MultiSelect = false;
            this.gridValues.Name = "gridValues";
            this.gridValues.RowHeadersVisible = false;
            this.gridValues.Size = new System.Drawing.Size(232, 118);
            this.gridValues.TabIndex = 0;
            // 
            // filename
            // 
            this.filename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.filename.HeaderText = "File";
            this.filename.Name = "filename";
            this.filename.ReadOnly = true;
            this.filename.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.filename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.filename.Width = 160;
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.colValue.DefaultCellStyle = dataGridViewCellStyle1;
            this.colValue.HeaderText = "Value";
            this.colValue.Name = "colValue";
            this.colValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colValue.Width = 70;
            // 
            // repResults
            // 
            this.repResults.Controls.Add(this.tableResults);
            this.repResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repResults.Location = new System.Drawing.Point(253, 3);
            this.repResults.Name = "repResults";
            this.repResults.Padding = new System.Windows.Forms.Padding(6);
            this.tblMain.SetRowSpan(this.repResults, 3);
            this.repResults.Size = new System.Drawing.Size(276, 427);
            this.repResults.TabIndex = 9;
            this.repResults.TabStop = false;
            this.repResults.Text = "Results";
            // 
            // tableResults
            // 
            this.tableResults.ColumnCount = 1;
            this.tableResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableResults.Controls.Add(this.lstResults, 0, 0);
            this.tableResults.Controls.Add(this.progSearch, 0, 1);
            this.tableResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableResults.Location = new System.Drawing.Point(6, 19);
            this.tableResults.Name = "tableResults";
            this.tableResults.RowCount = 2;
            this.tableResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableResults.Size = new System.Drawing.Size(264, 402);
            this.tableResults.TabIndex = 0;
            // 
            // lstResults
            // 
            this.lstResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRAM,
            this.colVal,
            this.colFile,
            this.colFoundIn});
            this.lstResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstResults.FullRowSelect = true;
            this.lstResults.Location = new System.Drawing.Point(3, 3);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(258, 376);
            this.lstResults.TabIndex = 11;
            this.lstResults.UseCompatibleStateImageBehavior = false;
            this.lstResults.View = System.Windows.Forms.View.Details;
            // 
            // colRAM
            // 
            this.colRAM.Text = "RAM Addr";
            this.colRAM.Width = 65;
            // 
            // colVal
            // 
            this.colVal.Text = "Init Value";
            this.colVal.Width = 64;
            // 
            // colFile
            // 
            this.colFile.Text = "File Addr";
            this.colFile.Width = 65;
            // 
            // colFoundIn
            // 
            this.colFoundIn.Text = "# Files";
            this.colFoundIn.Width = 55;
            // 
            // progSearch
            // 
            this.progSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progSearch.Location = new System.Drawing.Point(3, 385);
            this.progSearch.Name = "progSearch";
            this.progSearch.Size = new System.Drawing.Size(258, 14);
            this.progSearch.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::GatewayRAMTools.Properties.Resources.cross_circle;
            this.btnClose.Location = new System.Drawing.Point(419, 436);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 31);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close Window";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.Image = global::GatewayRAMTools.Properties.Resources.document_search_result;
            this.btnSearch.Location = new System.Drawing.Point(3, 436);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 31);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Begin Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FixedAddrWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 482);
            this.Controls.Add(this.tblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(560, 521);
            this.Name = "FixedAddrWindow";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fixed Address Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheatWindow_FormClosed);
            this.Load += new System.EventHandler(this.CheatWindow_Load);
            this.tblMain.ResumeLayout(false);
            this.grpType.ResumeLayout(false);
            this.tblExactValue.ResumeLayout(false);
            this.tblExactValue.PerformLayout();
            this.grpMem.ResumeLayout(false);
            this.menuRegions.ResumeLayout(false);
            this.grpVal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridValues)).EndInit();
            this.repResults.ResumeLayout(false);
            this.tableResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.TableLayoutPanel tblExactValue;
        private System.Windows.Forms.RadioButton rad8S;
        private System.Windows.Forms.RadioButton rad16S;
        private System.Windows.Forms.RadioButton rad32S;
        private System.Windows.Forms.RadioButton rad8U;
        private System.Windows.Forms.RadioButton rad16U;
        private System.Windows.Forms.RadioButton rad32U;
        private System.Windows.Forms.GroupBox grpMem;
        private System.Windows.Forms.ListView lstMem;
        private System.Windows.Forms.GroupBox grpVal;
        private System.Windows.Forms.GroupBox repResults;
        private System.Windows.Forms.ColumnHeader RAMFrom;
        private System.Windows.Forms.ColumnHeader RAMTo;
        private System.Windows.Forms.DataGridView gridValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.ContextMenuStrip menuRegions;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectNoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem invertSelectionToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableResults;
        private System.Windows.Forms.ListView lstResults;
        private System.Windows.Forms.ProgressBar progSearch;
        private System.Windows.Forms.ColumnHeader colRAM;
        private System.Windows.Forms.ColumnHeader colVal;
        private System.Windows.Forms.ColumnHeader colFile;
        private System.Windows.Forms.ColumnHeader colFoundIn;
    }
}
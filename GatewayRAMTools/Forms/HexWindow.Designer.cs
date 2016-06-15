namespace GatewayRAMTools
{
    partial class HexWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HexWindow));
            this.mnuHexMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offsetColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offsetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusHex = new System.Windows.Forms.StatusStrip();
            this.lblOffset = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlHexView = new System.Windows.Forms.Panel();
            this.hexView = new Be.Windows.Forms.HexBox();
            this.savHex = new System.Windows.Forms.SaveFileDialog();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHexMain.SuspendLayout();
            this.statusHex.SuspendLayout();
            this.pnlHexView.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuHexMain
            // 
            this.mnuHexMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.mnuHexMain.Location = new System.Drawing.Point(0, 0);
            this.mnuHexMain.Name = "mnuHexMain";
            this.mnuHexMain.Size = new System.Drawing.Size(534, 24);
            this.mnuHexMain.TabIndex = 1;
            this.mnuHexMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeWindowToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToToolStripMenuItem,
            this.toolStripSeparator1,
            this.offsetColumnToolStripMenuItem,
            this.offsetsToolStripMenuItem,
            this.dataViewToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // offsetColumnToolStripMenuItem
            // 
            this.offsetColumnToolStripMenuItem.Checked = true;
            this.offsetColumnToolStripMenuItem.CheckOnClick = true;
            this.offsetColumnToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.offsetColumnToolStripMenuItem.Name = "offsetColumnToolStripMenuItem";
            this.offsetColumnToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.offsetColumnToolStripMenuItem.Text = "Column Headers";
            this.offsetColumnToolStripMenuItem.Click += new System.EventHandler(this.offsetColumnToolStripMenuItem_Click);
            // 
            // offsetsToolStripMenuItem
            // 
            this.offsetsToolStripMenuItem.Checked = true;
            this.offsetsToolStripMenuItem.CheckOnClick = true;
            this.offsetsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.offsetsToolStripMenuItem.Name = "offsetsToolStripMenuItem";
            this.offsetsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.offsetsToolStripMenuItem.Text = "RAM Offsets";
            this.offsetsToolStripMenuItem.Click += new System.EventHandler(this.offsetsToolStripMenuItem_Click);
            // 
            // dataViewToolStripMenuItem
            // 
            this.dataViewToolStripMenuItem.Checked = true;
            this.dataViewToolStripMenuItem.CheckOnClick = true;
            this.dataViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dataViewToolStripMenuItem.Name = "dataViewToolStripMenuItem";
            this.dataViewToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.dataViewToolStripMenuItem.Text = "Data View";
            this.dataViewToolStripMenuItem.Click += new System.EventHandler(this.dataViewToolStripMenuItem_Click);
            // 
            // statusHex
            // 
            this.statusHex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblOffset});
            this.statusHex.Location = new System.Drawing.Point(0, 339);
            this.statusHex.Name = "statusHex";
            this.statusHex.Size = new System.Drawing.Size(534, 22);
            this.statusHex.TabIndex = 3;
            this.statusHex.Text = "statusStrip1";
            // 
            // lblOffset
            // 
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(58, 17);
            this.lblOffset.Text = "{selected}";
            // 
            // pnlHexView
            // 
            this.pnlHexView.Controls.Add(this.hexView);
            this.pnlHexView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHexView.Location = new System.Drawing.Point(0, 24);
            this.pnlHexView.Name = "pnlHexView";
            this.pnlHexView.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pnlHexView.Size = new System.Drawing.Size(534, 315);
            this.pnlHexView.TabIndex = 4;
            // 
            // hexView
            // 
            this.hexView.ColumnInfoVisible = true;
            this.hexView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hexView.LineInfoVisible = true;
            this.hexView.Location = new System.Drawing.Point(6, 0);
            this.hexView.Name = "hexView";
            this.hexView.ReadOnly = true;
            this.hexView.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexView.Size = new System.Drawing.Size(522, 315);
            this.hexView.StringViewVisible = true;
            this.hexView.TabIndex = 3;
            this.hexView.VScrollBarVisible = true;
            this.hexView.SelectionStartChanged += new System.EventHandler(this.hexView_SelectionStartChanged);
            this.hexView.SelectionLengthChanged += new System.EventHandler(this.hexView_SelectionLengthChanged);
            // 
            // savHex
            // 
            this.savHex.Filter = "Binary File|*.bin|All Files|*.*";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // closeWindowToolStripMenuItem
            // 
            this.closeWindowToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.cross_circle;
            this.closeWindowToolStripMenuItem.Name = "closeWindowToolStripMenuItem";
            this.closeWindowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeWindowToolStripMenuItem.Text = "Close Window";
            this.closeWindowToolStripMenuItem.Click += new System.EventHandler(this.closeWindowToolStripMenuItem_Click);
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Image = global::GatewayRAMTools.Properties.Resources.receipt__arrow;
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.goToToolStripMenuItem.Text = "Go To Offset...";
            this.goToToolStripMenuItem.Click += new System.EventHandler(this.goToToolStripMenuItem_Click);
            // 
            // HexWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.pnlHexView);
            this.Controls.Add(this.statusHex);
            this.Controls.Add(this.mnuHexMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuHexMain;
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "HexWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HexWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HexWindow_FormClosed);
            this.Load += new System.EventHandler(this.HexWindow_Load);
            this.mnuHexMain.ResumeLayout(false);
            this.mnuHexMain.PerformLayout();
            this.statusHex.ResumeLayout(false);
            this.statusHex.PerformLayout();
            this.pnlHexView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuHexMain;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offsetColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offsetsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusHex;
        private System.Windows.Forms.ToolStripStatusLabel lblOffset;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeWindowToolStripMenuItem;
        private System.Windows.Forms.Panel pnlHexView;
        private Be.Windows.Forms.HexBox hexView;
        private System.Windows.Forms.SaveFileDialog savHex;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
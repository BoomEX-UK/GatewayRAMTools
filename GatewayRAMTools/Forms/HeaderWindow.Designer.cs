namespace GatewayRAMTools
{
    partial class HeaderWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeaderWindow));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.pnlText = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnlTextLabels = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.pnlMainLabel = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.pnlMemregions = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ramFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ramTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filePosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dumpSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlButtons.SuspendLayout();
            this.pnlText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlTextLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnlMainLabel.SuspendLayout();
            this.pnlMemregions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Controls.Add(this.btnExport);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 224);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.pnlButtons.Size = new System.Drawing.Size(284, 37);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(203, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "button2";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExport.Location = new System.Drawing.Point(6, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 31);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "button1";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // pnlText
            // 
            this.pnlText.Controls.Add(this.splitContainer1);
            this.pnlText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlText.Location = new System.Drawing.Point(0, 198);
            this.pnlText.Name = "pnlText";
            this.pnlText.Padding = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.pnlText.Size = new System.Drawing.Size(284, 26);
            this.pnlText.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(6, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Size = new System.Drawing.Size(272, 20);
            this.splitContainer1.SplitterDistance = 136;
            this.splitContainer1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 2;
            // 
            // pnlTextLabels
            // 
            this.pnlTextLabels.Controls.Add(this.splitContainer2);
            this.pnlTextLabels.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTextLabels.Location = new System.Drawing.Point(0, 181);
            this.pnlTextLabels.Name = "pnlTextLabels";
            this.pnlTextLabels.Size = new System.Drawing.Size(284, 17);
            this.pnlTextLabels.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblRAM);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lblFile);
            this.splitContainer2.Size = new System.Drawing.Size(284, 17);
            this.splitContainer2.SplitterDistance = 142;
            this.splitContainer2.TabIndex = 2;
            // 
            // lblRAM
            // 
            this.lblRAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRAM.Location = new System.Drawing.Point(0, 0);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(142, 17);
            this.lblRAM.TabIndex = 2;
            this.lblRAM.Text = "RAM Offset";
            this.lblRAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFile
            // 
            this.lblFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFile.Location = new System.Drawing.Point(0, 0);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(138, 17);
            this.lblFile.TabIndex = 2;
            this.lblFile.Text = "File Offset";
            this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMainLabel
            // 
            this.pnlMainLabel.Controls.Add(this.lblMain);
            this.pnlMainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainLabel.Location = new System.Drawing.Point(0, 0);
            this.pnlMainLabel.Name = "pnlMainLabel";
            this.pnlMainLabel.Size = new System.Drawing.Size(284, 23);
            this.pnlMainLabel.TabIndex = 3;
            // 
            // lblMain
            // 
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMain.Location = new System.Drawing.Point(0, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(284, 23);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "{filename}";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMemregions
            // 
            this.pnlMemregions.Controls.Add(this.listView1);
            this.pnlMemregions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMemregions.Location = new System.Drawing.Point(0, 23);
            this.pnlMemregions.Name = "pnlMemregions";
            this.pnlMemregions.Padding = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.pnlMemregions.Size = new System.Drawing.Size(284, 158);
            this.pnlMemregions.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ramFrom,
            this.ramTo,
            this.filePosition,
            this.dumpSize});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(6, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(272, 152);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ramFrom
            // 
            this.ramFrom.Text = "RAM From";
            // 
            // ramTo
            // 
            this.ramTo.Text = "RAM To";
            // 
            // filePosition
            // 
            this.filePosition.Text = "File Position";
            // 
            // dumpSize
            // 
            this.dumpSize.Text = "Dump Size";
            // 
            // HeaderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pnlMemregions);
            this.Controls.Add(this.pnlMainLabel);
            this.Controls.Add(this.pnlTextLabels);
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.pnlButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "HeaderWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartitionTable";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HeaderWindow_FormClosed);
            this.pnlButtons.ResumeLayout(false);
            this.pnlText.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlTextLabels.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.pnlMainLabel.ResumeLayout(false);
            this.pnlMemregions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Panel pnlTextLabels;
        private System.Windows.Forms.Panel pnlMainLabel;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Panel pnlMemregions;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.ColumnHeader ramFrom;
        private System.Windows.Forms.ColumnHeader ramTo;
        private System.Windows.Forms.ColumnHeader filePosition;
        private System.Windows.Forms.ColumnHeader dumpSize;
    }
}
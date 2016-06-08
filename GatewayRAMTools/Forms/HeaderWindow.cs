using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GatewayRAMTools
{
    public partial class HeaderWindow : Form
    {
        public GWFileHeader binfile = new GWFileHeader();

        public HeaderWindow()
        {
            InitializeComponent();
        }

        private void HeaderWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void HeaderWindow_Load(object sender, EventArgs e)
        {
            ListViewItem lsi = new ListViewItem();
            lblMain.Text = binfile.fileName;
            for( int i = 0; i < binfile.memRegionCount; i++)
            {
                lsi = lstHeader.Items.Add(binfile.memRegions[i][0].ToString("X8"));
                lsi.SubItems.Add(binfile.memRegions[i][1].ToString("X8"));
                lsi.SubItems.Add(binfile.memRegions[i][2].ToString("X8"));
                lsi.SubItems.Add(binfile.memRegions[i][3].ToString("X8"));
            }
            resizeColumns();
        }

        private void resizeColumns()
        {
            int[] mins = new int[] { 85, 85, 85, 85 };
            foreach (ColumnHeader colhi in lstHeader.Columns)
            {
                colhi.Width = -2;
                if (colhi.Width < mins[colhi.Index]) colhi.Width = mins[colhi.Index];
            }
        }
    }
}

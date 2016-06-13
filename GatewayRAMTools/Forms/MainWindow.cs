using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace GatewayRAMTools
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            lstFiles.Columns.RemoveAt(3);
            resizeColumns();
            this.Text += string.Format("{0}.{1}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major, System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor);
        }

        // Convert Bytes To Next Readable Format (Simple)
        public string filesizestring(double len)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            while (len >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                len = len / 1024;
            }
            return String.Format("{0:0.##} {1}", len, sizes[order]);
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            addFiles(); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addFiles()
        {
            GWFunctions gwf = new GWFunctions();
            DialogResult dresult;
            dresult = dgAddFiles.ShowDialog();
            if( dresult == DialogResult.OK)
            {
                for( int i = 0; i < dgAddFiles.FileNames.Length; i++)
                {
                    if( !FileInList(dgAddFiles.FileNames[i]) )
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi = lstFiles.Items.Add(Path.GetFileName(dgAddFiles.FileNames[i]));
                        FileInfo f = new FileInfo(dgAddFiles.FileNames[i]);
                        lvi.SubItems.Add(filesizestring(f.Length));
                        lvi.SubItems.Add("RAW");
                        if (gwf.isGatewayDump(dgAddFiles.FileNames[i])) lvi.SubItems[2].Text = "Gateway";
                        lvi.SubItems.Add(dgAddFiles.FileNames[i]);
                        resizeColumns();
                    }
                }
            }
        }

        private void addFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFiles();
        }

        private bool FileInList( string fname)
        {
            bool result = false;
            for( int i = 0; i < lstFiles.Items.Count; i++)
            {
                if (lstFiles.Items[i].SubItems[3].Text == fname) result = true;
            }
            return result;
        }

        private void resizeColumns()
        {
            int[] mins = new int[] { 200, 75, 75, 200 };
            foreach(ColumnHeader colhi in lstFiles.Columns)
            {
                colhi.Width = -2;
                if (colhi.Width < mins[colhi.Index]) colhi.Width = mins[colhi.Index];
            }
        }

        private void lstFiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnRemove.Enabled = (lstFiles.CheckedItems.Count > 0);
            viewSelectedPartitionToolStripMenuItem.Enabled = (lstFiles.SelectedItems.Count > 0);
        }

        private void lstFiles_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            btnRemove.Enabled = (lstFiles.CheckedItems.Count > 0);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            while (lstFiles.CheckedItems.Count > 0)
            {
                lstFiles.Items.RemoveAt(lstFiles.CheckedItems[0].Index);
            }
        }

        private void allRAWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lstFiles.Items)
            {
                lvi.Checked = (lvi.SubItems[2].Text != "RAW");
            }
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lstFiles.Items)
            {
                lvi.Checked = true;
            }
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lstFiles.Items)
            {
                lvi.Checked = false;
            }
        }

        private void allRAWToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lstFiles.Items)
            {
                lvi.Checked = (lvi.SubItems[2].Text == "RAW");
            }
        }

        private void exportRAWRAMDumpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<GWFileHeader> heads = new List<GWFileHeader>();
            GWFunctions gwf = new GWFunctions();
            long tfSize = 0;
            int tregions = 0;

            foreach (ListViewItem lvi in lstFiles.CheckedItems)
            {
                if (lvi.SubItems[2].Text == "Gateway")
                {
                    heads.Add(gwf.buildFromDump(lvi.SubItems[3].Text));
                    tfSize += heads[heads.Count - 1].rawsize;
                    tregions += heads[heads.Count - 1].memRegionCount;
                }
            }

            if( heads.Count > 0)
            {
                string plural = "s";
                if (heads.Count == 1) plural = "";
                DialogResult confRes = MessageBox.Show(String.Format("Gateway RAM Tools will now create {0} RAW dump{1} totalling {2}.\r\nEach file will be in the same folder marked with '-raw'. Existing '-raw' files will be OVERWRITTEN.\r\n\r\nWould you like to continue?", heads.Count, plural, filesizestring(tfSize)),"Do You Want To Continue?",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if( confRes == DialogResult.Yes)
                {
                    pbar.Value = 0;
                    pbar.Maximum = tregions;
                    pnlProgress.Visible = true;
                    exportRAWRAMDumpToolStripMenuItem.Enabled = false;
                    Thread backgroundThread = new Thread(
                       new ThreadStart(() =>
                       {
                           for (int i = 0; i < heads.Count; i++)
                           {
                               gwf.dumpGWRAM(heads[i], pbar);
                           }
                           pnlProgress.BeginInvoke(
                               new Action(() =>
                               {
                                   pnlProgress.Visible = false;
                               }
                            ));
                           menuStrip1.BeginInvoke(
                               new Action(() =>
                               {
                                   exportRAWRAMDumpToolStripMenuItem.Enabled = true;
                               }
                           ));
                           MessageBox.Show("RAM Dumps have been sucessfull created.", "RAW RAM Dumping", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                       }
                   ));
                    backgroundThread.Start();
                }
            } else
            {
                MessageBox.Show("There are no Gateway RAM Dumps Ticked.","No Gateway RAM TickedSelected",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string appversion = string.Format("{0}.{1}",System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major, System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor);
            long buildversion  = (System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build*100000) + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Revision;
            MessageBox.Show(String.Format("Created By: xJam.es\r\nProject Started: 20th Jan 2016\r\nVersion: {0} (Build {1:X8})\r\n----------\r\nThanks To:\r\n* The Gateway Team\r\n* Maxconsole.com Forums\r\n* msparky76\r\n* makikatze\r\n* storm75x (Fort42)", appversion, buildversion),"About Gateway RAM Tools",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.maxconsole.com/maxcon_forums/threads/293584-Tool-Gateway-RAM-Tools");
        }

        private void projectHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/xJam-es/GatewayRAMTools");
        }

        private void viewSelectedPartitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HeaderWindow newhrd = new HeaderWindow();
            GWFunctions gwf = new GWFunctions();
            newhrd.binfile = gwf.buildFromDump(lstFiles.SelectedItems[0].SubItems[3].Text);
            newhrd.Show();
        }

        private void lstFiles_DoubleClick(object sender, EventArgs e)
        {
            ListView lstsend = (ListView)sender;
            if( lstsend.SelectedItems.Count == 1)
            {
                viewSelectedPartitionToolStripMenuItem_Click(sender, e);
                lstsend.FocusedItem.Checked = !lstsend.FocusedItem.Checked;
            }
        }

        private void cheatFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<GWFileHeader> cheatFiles = new List<GWFileHeader>();
            GWFunctions gwf = new GWFunctions();
            string SHAmatch = null;
            bool doMatch = true;

            foreach( ListViewItem lvi in lstFiles.CheckedItems)
            {
                cheatFiles.Add(gwf.buildFromDump(lvi.SubItems[3].Text));
                if(SHAmatch == null)
                {
                    SHAmatch = cheatFiles[cheatFiles.Count - 1].headerSHA1;
                } else
                {
                    if (SHAmatch != cheatFiles[cheatFiles.Count - 1].headerSHA1) doMatch = false;
                }
            }

            if ((cheatFiles.Count > 0) && doMatch)
            {
                FixedAddrWindow cht = new FixedAddrWindow();
                cht.cheatFiles = cheatFiles;
                cht.Show();
            }
            else
            {
                if (!doMatch) MessageBox.Show("The layout of your RAM Dumps do not match. You cannot mix RAW/Gateway & all RAM dumps selected must be from the same game.", "Cheat Finder Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("You must have at least 1 RAM Dump ticked before searching.", "Cheat Finder Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

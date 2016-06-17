using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace GatewayRAMTools
{
    public partial class PointerAddrWindow : Form
    {
        public List<GWFileHeader> ramDumps = new List<GWFileHeader>(); // Files In Use

        public PointerAddrWindow()
        {
            InitializeComponent();
        }

        public bool validHex(string test)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PointerAddrWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void PointerAddrWindow_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < ramDumps[0].memRegionCount; i++)
            {
                ListViewItem lvi = lstMemRegions.Items.Add(ramDumps[0].memRegions[i][0].ToString("X8"));
                lvi.SubItems.Add(ramDumps[0].memRegions[i][1].ToString("X8"));
                lvi.SubItems.Add(ramDumps[0].memRegions[i][2].ToString("X8"));
                lvi.SubItems.Add(ramDumps[0].memRegions[i][3].ToString("X8"));
                lvi.Checked = true;
                lvi.Tag = i;
            }

            for(int i=0; i<ramDumps.Count; i++)
            {
                gridFiles.Rows.Add(ramDumps[i].fileName,"00000000");
            }
        }

        private void setFormUseable( bool isUseable)
        {
            this.BeginInvoke(
                new Action(() =>
                {
                    grpInput.Enabled = isUseable;
                    grpMemRegions.Enabled = isUseable;
                    lstResults.Enabled = isUseable;
                    grpSettings.Enabled = isUseable;
                    btnGo.Enabled = isUseable;
                }
            ));
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            List<int[]> checkedRegions = new List<int[]>();
            bool includeNegative = chkNegative.Checked;
            bool reverseLookup = chkReverse.Checked;
            setFormUseable(false);

            // Check For Valid Addresses
            for (int i = 0; i < gridFiles.RowCount; i++)
            {
                if (!validHex(gridFiles.Rows[i].Cells[1].Value.ToString()) || (gridFiles.Rows[i].Cells[1].Value.ToString().Length != 8)) goto ErrorAddrs;
            }

            // Check For Valid Max Offset
            int maxOffset;
            if (!int.TryParse(txtMaxOffset.Text, out maxOffset)) goto ErrorMaxOffset;

            // Check For MemRegion Ticks
            if (lstMemRegions.CheckedItems.Count <= 0) goto ErrorMemregion;
            else
                foreach (ListViewItem lvi in lstMemRegions.CheckedItems)
                {
                    int[] tmp = new int[5];
                    for( int n=0; n<4; n++ ) tmp[n] = int.Parse(lvi.SubItems[n].Text,System.Globalization.NumberStyles.HexNumber);
                    tmp[4] = (int)lvi.Tag;
                    checkedRegions.Add(tmp);
                }

            lstResults.Items.Clear();

            // Reset Progress Bar
            prgSearch.Value = 0;
            prgSearch.Maximum = checkedRegions.Count * 100;

            // Begin Thread
            Thread backgroundThread = new Thread(
                new ThreadStart(() =>
                {
                    List<FileStream> readStreams = new List<FileStream>();
                    List<int> offsets = new List<int>();
                    int[] thisRegion;

                    // load Files and Offsets
                    for(int i =0; i<ramDumps.Count; i++)
                    {
                        FileStream fs = File.OpenRead(ramDumps[i].filePath);
                        readStreams.Add(fs);
                        offsets.Add(int.Parse(gridFiles.Rows[i].Cells[1].Value.ToString(),System.Globalization.NumberStyles.HexNumber));
                    }

                    // While We Have Regions To Search
                    while (checkedRegions.Count > 0)
                    {
                        List<byte[]> bars = new List<byte[]>();
                        bool keeprunning = true;
                        int lastprogress = 0;

                        thisRegion = checkedRegions[0];
                        checkedRegions.RemoveAt(0);

                        foreach (FileStream fs in readStreams)
                        {
                            byte[] bar = new byte[thisRegion[3]];
                            fs.Seek(thisRegion[2], SeekOrigin.Begin);
                            fs.Read(bar, 0, bar.Length);
                            // Make Sure We Have A Little End (oo-err)
                            if (!BitConverter.IsLittleEndian) Array.Reverse(bar);
                            bars.Add(bar);
                        }

                        // Check For Pointers
                        for (int n = 0; (n < (thisRegion[3]-3)) && keeprunning; n++)
                        {
                            int firstValue = 0;
                            int firstrelation = 0;
                            bool validPointer = true;
                            for (int x = 0; x < bars.Count; x++)
                            {
                                if (!reverseLookup && ((thisRegion[0] + n) >= offsets[x])) keeprunning = false;
                                int tempvalue = BitConverter.ToInt32(bars[x], n); // + thisRegion[0] + n;
                                int relation = offsets[x]- tempvalue;
                                if (includeNegative) relation = Math.Abs(relation);

                                if (x == 0)
                                {
                                    firstValue = tempvalue;
                                    firstrelation = relation;

                                }

                                // Check It's Within Bounds
                                if ((relation < 0) || (relation > maxOffset)) validPointer = false;
                                if ((x != 0) && (relation != firstrelation)) validPointer = false;
                            }
                            if (validPointer)
                            {
                                int inFilePos = thisRegion[0] + n;
                                int value = firstValue;
                                int regioncode = thisRegion[4];
                                lstResults.BeginInvoke(
                                    new Action(() =>
                                    {
                                        ListViewItem lvi = lstResults.Items.Add((inFilePos).ToString("X8"));
                                        lvi.SubItems.Add(value.ToString("X8"));
                                        lvi.SubItems.Add((offsets[0]-value).ToString("X8"));
                                        // if ((offsets[0] - value) == 0) lvi.BackColor = Color.LightGreen;
                                        if ((offsets[0] - value) < 0) lvi.BackColor = Color.LightGray;
                                        // if (inFilePos > offsets[0]) lvi.ForeColor = Color.DarkGray;
                                        lvi.Tag = regioncode;
                                    }
                                    ));
                            }

                            int thisprogress = 0;
                            if (keeprunning) thisprogress = (int)(((double)n / ((double)thisRegion[3] - 3)) * 100);
                            else thisprogress = 100;

                            if (thisprogress > lastprogress)
                            {
                                int toadd = thisprogress - lastprogress;
                                lastprogress = thisprogress;
                                prgSearch.BeginInvoke(
                                    new Action(() =>
                                    {
                                        prgSearch.Value += toadd;
                                    }
                                    ));
                            }
                        }

                    }

                    // Close Files When Done
                    foreach (FileStream fs in readStreams) fs.Close();
                    prgSearch.BeginInvoke(
                        new Action(() =>
                        {
                            prgSearch.Value = prgSearch.Maximum;
                        }
                        ));
                    setFormUseable(true);
                }
            ));
            backgroundThread.Start();

            goto EndFunc;

        ErrorAddrs:
            MessageBox.Show("Unable To Start Search As One Of The Known Addresses Given Is Invalid.", "Manual Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            goto ExitFunc;

        ErrorMaxOffset:
            MessageBox.Show("Unable To Start Search As The Maximum Offset Entered Is Invalid.", "Manual Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            goto ExitFunc;

        ErrorMemregion:
            MessageBox.Show("Unable To Start Search As You Must Have At Least 1 MemRegion Ticked.", "Manual Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            goto ExitFunc;

        ExitFunc:
            setFormUseable(true);

        EndFunc: ;
        }

        private void showInHexViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstResults.SelectedItems.Count > 0) {
                HexWindow hexwin = new HexWindow();
                hexwin.rDump = ramDumps[0];
                hexwin.memRegion = (int)lstResults.SelectedItems[0].Tag;
                hexwin.selectLength = 4;
                hexwin.gotoOffset = int.Parse(lstResults.SelectedItems[0].SubItems[0].Text,System.Globalization.NumberStyles.HexNumber);
                hexwin.Show();
            }
        }

        private void createCheatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lstResults.SelectedItems.Count > 0)
            {
                ListViewItem seli = lstResults.SelectedItems[0];
                CheatTextWindow cwin = new CheatTextWindow();
                cwin.pointeraddr = seli.SubItems[0].Text;
                cwin.cheatname = "Pointer " + seli.SubItems[0].Text;
                cwin.offset = seli.SubItems[2].Text;
                cwin.Show();
            }
        }
    }
}

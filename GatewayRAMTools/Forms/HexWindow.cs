using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.IO;
using Be.Windows.Forms;

namespace GatewayRAMTools
{
    public partial class HexWindow : Form
    {
        public string filename;
        public int startoffset;
        public int offsetsize;
        public int ramoffset;

        public HexWindow()
        {
            InitializeComponent();
        }

        private void HexWindow_Load(object sender, EventArgs e)
        {
            // DynamicFileByteProvider dbfp;
            byte[] bytereader;
            using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                reader.BaseStream.Position = startoffset;
                bytereader = reader.ReadBytes(offsetsize);
            }
            DynamicByteProvider dbp = new DynamicByteProvider(bytereader);
            hexView.ByteProvider = dbp;
            hexView.LineInfoOffset = ramoffset;
            this.Text = "Hex View (" + ramoffset.ToString("X8") + "-" + (ramoffset + offsetsize).ToString("X8") + ")";
            hexView_SelectionStartChanged(sender, e);
            // dbp.Bytes;
        }

        private void offsetColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem comefrom = (ToolStripMenuItem)sender;
            hexView.ColumnInfoVisible = comefrom.Checked;
        }

        private void offsetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem comefrom = (ToolStripMenuItem)sender;
            hexView.LineInfoVisible = comefrom.Checked;
        }

        private void dataViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem comefrom = (ToolStripMenuItem)sender;
            hexView.StringViewVisible = comefrom.Checked;
        }

        private void hexView_SelectionStartChanged(object sender, EventArgs e)
        {
            lblOffset.Text = "Cursor: " + (hexView.SelectionStart+hexView.LineInfoOffset).ToString("X8");
        }

        private void hexView_SelectionLengthChanged(object sender, EventArgs e)
        {
            if(hexView.SelectionLength>0)
            lblOffset.Text = "Cursor: " + (hexView.SelectionStart + hexView.LineInfoOffset).ToString("X8")+"-"+ (hexView.SelectionStart + hexView.LineInfoOffset+hexView.SelectionLength).ToString("X8");
        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HexWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToDialog gtd = new GoToDialog();
            gtd.offsetVal = (hexView.SelectionStart+hexView.LineInfoOffset).ToString("X8");
            if( gtd.ShowDialog() == DialogResult.OK)
            {
                long offsetval = 0;
                try
                {
                    offsetval = long.Parse(gtd.offsetVal,System.Globalization.NumberStyles.HexNumber);
                }
                catch { MessageBox.Show("Invalid Offset Entered"); }
                finally
                {
                    offsetval = offsetval-hexView.LineInfoOffset;
                    if ((offsetval < 0) || (offsetval > hexView.ByteProvider.Length))
                    {
                        MessageBox.Show("Offset Entered Is Outside The Memory Region.");
                    }
                    else
                    {
                        hexView.Select(offsetval, 0);
                        hexView.ScrollByteIntoView();
                    }
                }
                //hexView.ScrollByteIntoView(0);
            }

        }
    }
}

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
        public GWFileHeader rDump;
        public int memRegion;
        public int gotoOffset = 0;
        public int selectLength = 0;
        byte[] bytereader;

        public HexWindow()
        {
            InitializeComponent();
        }

        private void HexWindow_Load(object sender, EventArgs e)
        {
            // DynamicFileByteProvider dbfp;
            using (BinaryReader reader = new BinaryReader(File.Open(rDump.filePath, FileMode.Open)))
            {
                reader.BaseStream.Position = rDump.memRegions[memRegion][2];
                bytereader = reader.ReadBytes(rDump.memRegions[memRegion][3]);
            }
            DynamicByteProvider dbp = new DynamicByteProvider(bytereader);
            hexView.ByteProvider = dbp;
            hexView.LineInfoOffset = rDump.memRegions[memRegion][0];
            this.Text = "Hex View (" + rDump.memRegions[memRegion][0].ToString("X8") + "-" + (rDump.memRegions[memRegion][0] + rDump.memRegions[memRegion][3]).ToString("X8") + ")";
            if(gotoOffset > 0)
            {
                hexView.SelectionStart = (gotoOffset - rDump.memRegions[memRegion][0]);
                hexView.SelectionLength = selectLength;
                hexView.ScrollByteIntoView();
            }
            hexView_SelectionStartChanged(sender, e);
            hexView_SelectionLengthChanged(sender, e);
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
            lblValue.Text = "";
        }

        private void hexView_SelectionLengthChanged(object sender, EventArgs e)
        {
            if(hexView.SelectionLength>0)
            lblOffset.Text = "Cursor: " + (hexView.SelectionStart + hexView.LineInfoOffset).ToString("X8")+"-"+ (hexView.SelectionStart + hexView.LineInfoOffset+hexView.SelectionLength).ToString("X8");

            if( (hexView.SelectionLength>0) && (hexView.SelectionLength <= 4))
            {
                string selbase;
                string selSvalue;
                string selUvalue;
                switch (hexView.SelectionLength)
                {
                    case 1:
                        selbase = "8Bit";
                        selSvalue = bytereader[(int)hexView.SelectionStart].ToString();
                        selUvalue = bytereader[(int)hexView.SelectionStart].ToString();
                        break;
                    case 2:
                        selbase = "16Bit";
                        selSvalue = BitConverter.ToInt16(bytereader, (int)hexView.SelectionStart).ToString();
                        selUvalue = BitConverter.ToUInt16(bytereader, (int)hexView.SelectionStart).ToString();
                        break;
                    case 4:
                        selbase = "32Bit";
                        selSvalue = BitConverter.ToInt32(bytereader, (int)hexView.SelectionStart).ToString();
                        selUvalue = BitConverter.ToUInt32(bytereader, (int)hexView.SelectionStart).ToString();
                        break;
                    default:
                        selbase = "";
                        selSvalue = "";
                        selUvalue = "";
                        break;
                }
                if (selbase != "")
                {
                    lblValue.Text = selbase + ": " + selUvalue;
                    if( selSvalue != selUvalue) lblValue.Text += " (Signed: " + selSvalue + ")";
                }
                else lblValue.Text = "";
            } else lblValue.Text = "";
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
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

        public bool validHex(string test)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
        }

        private void HeaderWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void HeaderWindow_Load(object sender, EventArgs e)
        {
            ListViewItem lsi = new ListViewItem();
            lblMain.Text = binfile.fileName;
            this.Text += binfile.fileName;
            for ( int i = 0; i < binfile.memRegionCount; i++)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string xml_out_s = "";
            XmlSerializer xsSubmit = new XmlSerializer(typeof(GWFileHeader));
            using (StringWriter xml_out_w = new StringWriter())
            using (XmlWriter writer = XmlWriter.Create(xml_out_w, new XmlWriterSettings { Indent = true }))
            {
                xsSubmit.Serialize(writer, binfile);
                xml_out_s = xml_out_w.ToString(); // Your XML
            }

            if (savXML.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(savXML.FileName, xml_out_s);
            }

        }

        private void lstHeader_DoubleClick(object sender, EventArgs e)
        {
            if( lstHeader.FocusedItem.Index >= 0)
            {
                txtRAM.Text = lstHeader.FocusedItem.Text;
                // txtFile.Text = lstHeader.FocusedItem.SubItems[2].Text;
            }
        }

        // Toggling TextBox Changes (stops infinate loop)
        private void textChangeRamFile(object sender, EventArgs e)
        {
            TextBox txtFrom = (TextBox)sender;
            TextBox txtTo = new TextBox();
            int hexval = 0;

            int[] subcolumn = { 0, 0 };

            if (txtFrom.Name == "txtRAM")
            {
                txtTo = txtFile;
                subcolumn[0] = 0;
                subcolumn[1] = 2;
            }
            else
            {
                txtTo = txtRAM;
                subcolumn[0] = 2;
                subcolumn[1] = 0;
            }

            txtTo.TextChanged -= this.textChangeRamFile;
            if (validHex(txtFrom.Text))
            {
                hexval = int.Parse(txtFrom.Text, System.Globalization.NumberStyles.HexNumber);
                string ramout = "00000000";
                foreach(ListViewItem lvi in lstHeader.Items)
                {
                    int rfrom = int.Parse(lvi.SubItems[subcolumn[0]].Text, System.Globalization.NumberStyles.HexNumber);
                    int rto = rfrom + int.Parse(lvi.SubItems[3].Text, System.Globalization.NumberStyles.HexNumber);
                    if( (hexval >= rfrom) && (hexval <= rto ))
                    {
                        ramout = ((hexval-rfrom) + int.Parse(lvi.SubItems[subcolumn[1]].Text, System.Globalization.NumberStyles.HexNumber)).ToString("X8");
                    }
                }
                txtTo.Text = ramout;
            } else txtTo.Text = "00000000";
            txtTo.TextChanged += this.textChangeRamFile;
        }

    }
}

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
    public partial class CheatTextWindow : Form
    {
        public string pointeraddr = "";
        public string offset = "";
        public string cheatname = "";
        public string newvalue = "";

        public CheatTextWindow()
        {
            InitializeComponent();
        }

        private void writeCheat()
        {
            int outval;
            if (int.TryParse(txtVal.Text, out outval))
            {
                newvalue = outval.ToString("X8");
            }
            else newvalue = "00000000";
            txtCheat.Text = string.Format("[{0}]\r\nD3000000 {1}\r\n60000000 00000000\r\nB0000000 00000000\r\n{2} {3}\r\nD2000000 00000000",cheatname,pointeraddr,offset,newvalue);
        }

        private void CheatTextWindow_Load(object sender, EventArgs e)
        {
            writeCheat();
        }

        private void txtVal_TextChanged(object sender, EventArgs e)
        {
            writeCheat();
        }
    }
}

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
    public partial class GoToDialog : Form
    {
        public string offsetVal;

        public GoToDialog()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            offsetVal = txtOffset.Text;
            this.Close();
        }

        private void GoToDialog_Load(object sender, EventArgs e)
        {
            txtOffset.Text = offsetVal;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtOffset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { btnCancel_Click(sender, e); }
            if (e.KeyCode == Keys.Enter) { btnOK_Click(sender, e); }
        }
    }
}

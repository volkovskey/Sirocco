using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirocco
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Text = "Sirocco " + Properties.Settings.Default.version + " " + Properties.Settings.Default.branch;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program name: Sirocco\nProgram version: " + Properties.Settings.Default.version + "\nStatus of the current version: " + Properties.Settings.Default.branch + "\nDeveloper: volkovskey\nCopyright: Copyright ©volkovskey 2020-2021\nLicense:\n\n" + Properties.Resources.license, "About");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int f1 = Convert.ToInt32(freq1.Text);
            int f2 = Convert.ToInt32(freq2.Text);

            zeroUpdate();
            CL2.Text = Math.Round(Convert.ToInt32(CL1.Text) * f2 / f1 + 0.5).ToString();
            RCDRD2.Text = Math.Round(Convert.ToInt32(RCDRD1.Text) * f2 / f1 + 0.5).ToString();
            RCDWR2.Text = Math.Round(Convert.ToInt32(RCDWR1.Text) * f2 / f1 + 0.5).ToString();
            RP2.Text = Math.Round(Convert.ToInt32(RP1.Text) * f2 / f1 + 0.5).ToString();
            RAS2.Text = Math.Round(Convert.ToInt32(RAS1.Text) * f2 / f1 + 0.5).ToString();
            RC2.Text = Math.Round(Convert.ToInt32(RC1.Text) * f2 / f1 + 0.5).ToString();
            RRDS2.Text = Math.Round(Convert.ToInt32(RRDS1.Text) * f2 / f1 + 0.5).ToString();
            RRDL2.Text = Math.Round(Convert.ToInt32(RRDL1.Text) * f2 / f1 + 0.5).ToString();
            FAW2.Text = Math.Round(Convert.ToInt32(FAW1.Text) * f2 / f1 + 0.5).ToString();
            WTRS2.Text = Math.Round(Convert.ToInt32(WTRS1.Text) * f2 / f1 + 0.5).ToString();
            WTRL2.Text = Math.Round(Convert.ToInt32(WTRL1.Text) * f2 / f1 + 0.5).ToString();
            WR2.Text = Math.Round(Convert.ToInt32(WR1.Text) * f2 / f1 + 0.5).ToString();
            RFC2.Text = Math.Round(Convert.ToInt32(RFC1.Text) * f2 / f1 + 0.5).ToString();
            RTP2.Text = Math.Round(Convert.ToInt32(RTP1.Text) * f2 / f1 + 0.5).ToString();
        }

        private void zeroUpdate()
        {
            if (CL1.Text == "") CL1.Text = "0";
            if (RCDRD1.Text == "") CL1.Text = "0";
            if (RCDWR1.Text == "") CL1.Text = "0";
            if (RP1.Text == "") CL1.Text = "0";
            if (RAS1.Text == "") CL1.Text = "0";
            if (RC1.Text == "") CL1.Text = "0";
            if (RRDS1.Text == "") CL1.Text = "0";
            if (RRDL1.Text == "") CL1.Text = "0";
            if (FAW1.Text == "") CL1.Text = "0";
            if (WTRS1.Text == "") CL1.Text = "0";
            if (WTRL1.Text == "") CL1.Text = "0";
            if (WR1.Text == "") CL1.Text = "0";
            if (RFC1.Text == "") CL1.Text = "0";
            if (RTP1.Text == "") CL1.Text = "0";
        }
    }
}

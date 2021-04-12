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
            zeroUpdate();
            int f1 = Convert.ToInt32(freq1.Text);
            int f2 = Convert.ToInt32(freq2.Text);
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
            int timing;
            if (!Int32.TryParse(CL1.Text, out timing)) CL1.Text = "0";
            if (!Int32.TryParse(RCDRD1.Text, out timing)) RCDRD1.Text = "0";
            if (!Int32.TryParse(RCDWR1.Text, out timing)) RCDWR1.Text = "0";
            if (!Int32.TryParse(RP1.Text, out timing)) RP1.Text = "0";
            if (!Int32.TryParse(RAS1.Text, out timing)) RAS1.Text = "0";
            if (!Int32.TryParse(RC1.Text, out timing)) RC1.Text = "0";
            if (!Int32.TryParse(RRDL1.Text, out timing)) RRDL1.Text = "0";
            if (!Int32.TryParse(RRDS1.Text, out timing)) RRDS1.Text = "0";
            if (!Int32.TryParse(FAW1.Text, out timing)) FAW1.Text = "0";
            if (!Int32.TryParse(WTRS1.Text, out timing)) WTRS1.Text = "0";
            if (!Int32.TryParse(WTRL1.Text, out timing)) WTRL1.Text = "0";
            if (!Int32.TryParse(WR1.Text, out timing)) WR1.Text = "0";
            if (!Int32.TryParse(RFC1.Text, out timing)) RFC1.Text = "0";
            if (!Int32.TryParse(RTP1.Text, out timing)) RTP1.Text = "0";


            if (!Int32.TryParse(freq1.Text, out timing)) freq1.Text = "3466";
            if (!Int32.TryParse(freq2.Text, out timing)) freq2.Text = "3733";
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            String text = "";
            MessageBox.Show(text, "test");
        }
    }
}

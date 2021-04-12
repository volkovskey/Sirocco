using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

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
            String versionOfProgram = typeof(frmMain).Assembly.GetName().Version.ToString();
            int lengthOfVersion = versionOfProgram.LastIndexOf('.');
            Properties.Settings.Default.version = versionOfProgram.Substring(0, lengthOfVersion);
            Text = "Sirocco " + Properties.Settings.Default.version + " " + Properties.Settings.Default.branch;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program name: Sirocco\nProgram version: " + Properties.Settings.Default.version + "\nStatus of the current version: " + Properties.Settings.Default.branch + "\nDeveloper: volkovskey\nCopyright: Copyright ©volkovskey 2021\nLicense:\n\n" + Properties.Resources.license, "About");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            zeroUpdate();
            int f1 = Convert.ToInt32(freq1.Text);
            int f2 = Convert.ToInt32(freq2.Text);

            int cl1 = Convert.ToInt32(CL1.Text); int cl2 = (int)Math.Round(cl1 * f2 / f1 + 0.5);
            double cl1ns = Math.Round(cl1 * 2000.0 / f1, 2); double cl2ns = Math.Round(cl2 * 2000.0 / f2, 2);
            CL2.Text = cl2.ToString(); CL1ns.Text = cl1ns.ToString() + " ns"; CL2ns.Text = cl2ns.ToString() + " ns";

            int rcdrd1 = Convert.ToInt32(RCDRD1.Text); int rcdrd2 = (int)Math.Round(rcdrd1 * f2 / f1 + 0.5);
            double rcdrd1ns = Math.Round(rcdrd1 * 2000.0 / f1, 2); double rcdrd2ns = Math.Round(rcdrd2 * 2000.0 / f2, 2);
            RCDRD2.Text = rcdrd2.ToString(); RCDRD1ns.Text = rcdrd1ns.ToString() + " ns"; RCDRD2ns.Text = rcdrd2ns.ToString() + " ns";

            int rcdwr1 = Convert.ToInt32(RCDWR1.Text); int rcdwr2 = (int)Math.Round(rcdwr1 * f2 / f1 + 0.5);
            double rcdwr1ns = Math.Round(rcdwr1 * 2000.0 / f1, 2); double rcdwr2ns = Math.Round(rcdwr2 * 2000.0 / f2, 2);
            RCDWR2.Text = rcdwr2.ToString(); RCDWR1ns.Text = rcdwr1ns.ToString() + " ns"; RCDWR2ns.Text = rcdwr2ns.ToString() + " ns";

            int rp1 = Convert.ToInt32(RP1.Text); int rp2 = (int)Math.Round(rp1 * f2 / f1 + 0.5);
            double rp1ns = Math.Round(rp1 * 2000.0 / f1, 2); double rp2ns = Math.Round(rp2 * 2000.0 / f2, 2);
            RP2.Text = rp2.ToString(); RP1ns.Text = rp1ns.ToString() + " ns"; RP2ns.Text = rp2ns.ToString() + " ns";

            int ras1 = Convert.ToInt32(RAS1.Text); int ras2 = (int)Math.Round(ras1 * f2 / f1 + 0.5);
            double ras1ns = Math.Round(ras1 * 2000.0 / f1, 2); double ras2ns = Math.Round(ras2 * 2000.0 / f2, 2);
            RAS2.Text = ras2.ToString(); RAS1ns.Text = ras1ns.ToString() + " ns"; RAS2ns.Text = ras2ns.ToString() + " ns";

            int rc1 = Convert.ToInt32(RC1.Text); int rc2 = (int)Math.Round(rc1 * f2 / f1 + 0.5);
            double rc1ns = Math.Round(rc1 * 2000.0 / f1, 2); double rc2ns = Math.Round(rc2 * 2000.0 / f2, 2);
            RC2.Text = rc2.ToString(); RC1ns.Text = rc1ns.ToString() + " ns"; RC2ns.Text = rc2ns.ToString() + " ns";

            int rrdl1 = Convert.ToInt32(RRDL1.Text); int rrdl2 = (int)Math.Round(rrdl1 * f2 / f1 + 0.5);
            double rrdl1ns = Math.Round(rrdl1 * 2000.0 / f1, 2); double rrdl2ns = Math.Round(rrdl2 * 2000.0 / f2, 2);
            RRDL2.Text = rrdl2.ToString(); RRDL1ns.Text = rrdl1ns.ToString() + " ns"; RRDL2ns.Text = rrdl2ns.ToString() + " ns";

            int rrds1 = Convert.ToInt32(RRDS1.Text); int rrds2 = (int)Math.Round(rrds1 * f2 / f1 + 0.5);
            double rrds1ns = Math.Round(rrds1 * 2000.0 / f1, 2); double rrds2ns = Math.Round(rrds2 * 2000.0 / f2, 2);
            RRDS2.Text = rrds2.ToString(); RRDS1ns.Text = rrds1ns.ToString() + " ns"; RRDS2ns.Text = rrds2ns.ToString() + " ns";

            int faw1 = Convert.ToInt32(FAW1.Text); int faw2 = (int)Math.Round(faw1 * f2 / f1 + 0.5);
            double faw1ns = Math.Round(faw1 * 2000.0 / f1, 2); double faw2ns = Math.Round(faw2 * 2000.0 / f2, 2);
            FAW2.Text = faw2.ToString(); FAW1ns.Text = faw1ns.ToString() + " ns"; FAW2ns.Text = faw2ns.ToString() + " ns";

            int wtrs1 = Convert.ToInt32(WTRS1.Text); int wtrs2 = (int)Math.Round(wtrs1 * f2 / f1 + 0.5);
            double wtrs1ns = Math.Round(wtrs1 * 2000.0 / f1, 2); double wtrs2ns = Math.Round(wtrs2 * 2000.0 / f2, 2);
            WTRS2.Text = wtrs2.ToString(); WTRS1ns.Text = wtrs1ns.ToString() + " ns"; WTRS2ns.Text = wtrs2ns.ToString() + " ns";

            int wtrl1 = Convert.ToInt32(WTRL1.Text); int wtrl2 = (int)Math.Round(wtrl1 * f2 / f1 + 0.5);
            double wtrl1ns = Math.Round(wtrl1 * 2000.0 / f1, 2); double wtrl2ns = Math.Round(wtrl2 * 2000.0 / f2, 2);
            WTRL2.Text = wtrl2.ToString(); WTRL1ns.Text = wtrl1ns.ToString() + " ns"; WTRL2ns.Text = wtrl2ns.ToString() + " ns";

            int wr1 = Convert.ToInt32(WTRL1.Text); int wr2 = (int)Math.Round(wr1 * f2 / f1 + 0.5);
            double wr1ns = Math.Round(wr1 * 2000.0 / f1, 2); double wr2ns = Math.Round(wr2 * 2000.0 / f2, 2);
            WR2.Text = wr2.ToString(); WR1ns.Text = wr1ns.ToString() + " ns"; WR2ns.Text = wr2ns.ToString() + " ns";

            int rfc1 = Convert.ToInt32(RFC1.Text); int rfc2 = (int)Math.Round(rfc1 * f2 / f1 + 0.5);
            double rfc1ns = Math.Round(rfc1 * 2000.0 / f1, 2); double rfc2ns = Math.Round(rfc2 * 2000.0 / f2, 2);
            RFC2.Text = rfc2.ToString(); RFC1ns.Text = rfc1ns.ToString() + " ns"; RFC2ns.Text = rfc2ns.ToString() + " ns";

            int rtp1 = Convert.ToInt32(RTP1.Text); int rtp2 = (int)Math.Round(rtp1 * f2 / f1 + 0.5);
            double rtp1ns = Math.Round(rtp1 * 2000.0 / f1, 2); double rtp2ns = Math.Round(rtp2 * 2000.0 / f2, 2);
            RTP2.Text = rtp2.ToString(); RTP1ns.Text = rtp1ns.ToString() + " ns"; RTP2ns.Text = rtp2ns.ToString() + " ns";
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

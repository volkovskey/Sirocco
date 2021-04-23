using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

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
            if (!Int32.TryParse(CL1.Text, out timing)) { if (Convert.ToInt32(CL1.Text) < 1 || Convert.ToInt32(CL1.Text) > 50) CL1.Text = "0"; }
            if (!Int32.TryParse(RCDRD1.Text, out timing)) { if (Convert.ToInt32(RCDRD1.Text) < 1 || Convert.ToInt32(RCDRD1.Text) > 50) RCDRD1.Text = "0"; }
            if (!Int32.TryParse(RCDWR1.Text, out timing)) { if (Convert.ToInt32(RCDWR1.Text) < 1 || Convert.ToInt32(RCDWR1.Text) > 50) RCDWR1.Text = "0"; }
            if (!Int32.TryParse(RP1.Text, out timing)) { if (Convert.ToInt32(RP1.Text) < 1 || Convert.ToInt32(RP1.Text) > 50) RP1.Text = "0"; }
            if (!Int32.TryParse(RAS1.Text, out timing)) { if (Convert.ToInt32(RAS1.Text) < 1 || Convert.ToInt32(RAS1.Text) > 100) RAS1.Text = "0"; }
            if (!Int32.TryParse(RC1.Text, out timing)) { if (Convert.ToInt32(RC1.Text) < 1 || Convert.ToInt32(RC1.Text) > 100) RC1.Text = "0"; }
            if (!Int32.TryParse(RRDL1.Text, out timing)) { if (Convert.ToInt32(RRDL1.Text) < 1 || Convert.ToInt32(RRDL1.Text) > 50) RRDL1.Text = "0"; }
            if (!Int32.TryParse(RRDS1.Text, out timing)) { if (Convert.ToInt32(RRDS1.Text) < 1 || Convert.ToInt32(RRDS1.Text) > 50) RRDS1.Text = "0"; }
            if (!Int32.TryParse(FAW1.Text, out timing)) { if (Convert.ToInt32(FAW1.Text) < 1 || Convert.ToInt32(FAW1.Text) > 100) FAW1.Text = "0"; }
            if (!Int32.TryParse(WTRS1.Text, out timing)) { if (Convert.ToInt32(WTRS1.Text) < 1 || Convert.ToInt32(WTRS1.Text) > 50) WTRS1.Text = "0"; }
            if (!Int32.TryParse(WTRL1.Text, out timing)) { if (Convert.ToInt32(WTRL1.Text) < 1 || Convert.ToInt32(WTRL1.Text) > 50) WTRL1.Text = "0"; }
            if (!Int32.TryParse(WR1.Text, out timing)) { if (Convert.ToInt32(WR1.Text) < 1 || Convert.ToInt32(WR1.Text) > 100) WR1.Text = "0"; }
            if (!Int32.TryParse(RFC1.Text, out timing)) { if (Convert.ToInt32(RFC1.Text) < 1 || Convert.ToInt32(RFC1.Text) > 1000) RFC1.Text = "0"; }
            if (!Int32.TryParse(RTP1.Text, out timing)) { if (Convert.ToInt32(RTP1.Text) < 1 || Convert.ToInt32(RTP1.Text) > 50) RTP1.Text = "0"; }

            if (!Int32.TryParse(freq1.Text, out timing)) { if (Convert.ToInt32(freq1.Text) < 1 || Convert.ToInt32(freq1.Text) > 10000) freq1.Text = "3466"; }
            if (!Int32.TryParse(freq2.Text, out timing)) { if (Convert.ToInt32(freq2.Text) < 1 || Convert.ToInt32(freq2.Text) > 10000) freq2.Text = "3733"; }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            String text = "";
            MessageBox.Show(text, "test");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            GetComponent("Win32_PhysicalMemory", "Attributes");
            GetComponent("Win32_PhysicalMemory", "BankLabel"); //ПК - "P0 CHANNEL A" "P0 CHANNEL B". Ноут - "BANK 0" "BANK 2"
            GetComponent("Win32_PhysicalMemory", "Capacity"); //Даёт объём каждой планки
            GetComponent("Win32_PhysicalMemory", "Caption");
            GetComponent("Win32_PhysicalMemory", "ConfiguredClockSpeed"); //Частота озу, ноут - 3733
            GetComponent("Win32_PhysicalMemory", "ConfiguredVoltage"); //Вольтаж JEDEC
            GetComponent("Win32_PhysicalMemory", "CreationClassName");
            GetComponent("Win32_PhysicalMemory", "DataWidth"); //Ширина шины
            GetComponent("Win32_PhysicalMemory", "Description"); 
            GetComponent("Win32_PhysicalMemory", "DeviceLocator"); //ПК - "DIMM 1" "DIMM 1". Ноут - "ChannelA-DIMM0" "ChannelB-DIMM0"
            GetComponent("Win32_PhysicalMemory", "FormFactor"); //ПК - 8, ноут - 0
            GetComponent("Win32_PhysicalMemory", "HotSwappable");
            GetComponent("Win32_PhysicalMemory", "InstallDate");
            GetComponent("Win32_PhysicalMemory", "InterleaveDataDepth");
            GetComponent("Win32_PhysicalMemory", "InterleavePosition");
            GetComponent("Win32_PhysicalMemory", "Manufacturer"); //Пк - неизвестно, ноут - самсунг
            GetComponent("Win32_PhysicalMemory", "MaxVoltage");
            GetComponent("Win32_PhysicalMemory", "MemoryType");
            GetComponent("Win32_PhysicalMemory", "MinVoltage");
            GetComponent("Win32_PhysicalMemory", "Model");
            GetComponent("Win32_PhysicalMemory", "Name");
            GetComponent("Win32_PhysicalMemory", "OtherIdentifyingInfo");
            GetComponent("Win32_PhysicalMemory", "PartNumber"); //Даёт название каждой планки или чипа, если мобильная память
            GetComponent("Win32_PhysicalMemory", "PositionInRow");
            GetComponent("Win32_PhysicalMemory", "PoweredOn");
            GetComponent("Win32_PhysicalMemory", "Removable");
            GetComponent("Win32_PhysicalMemory", "Replaceable");
            GetComponent("Win32_PhysicalMemory", "SerialNumber"); //Серийник планки
            GetComponent("Win32_PhysicalMemory", "SKU");
            GetComponent("Win32_PhysicalMemory", "SMBIOSMemoryType"); //ПК - 26, ноут - 30
            GetComponent("Win32_PhysicalMemory", "Speed"); //Частота озу, ноут - 4266
            GetComponent("Win32_PhysicalMemory", "Status");
            GetComponent("Win32_PhysicalMemory", "Tag"); //ПК - 1 и 3, ноут - 0 и 1 (скорее всего слоты)
            GetComponent("Win32_PhysicalMemory", "TotalWidth"); 
            GetComponent("Win32_PhysicalMemory", "TypeDetail");
            GetComponent("Win32_PhysicalMemory", "Version");

            GetComponent("Win32_PhysicalMemoryArray", "Caption");
            GetComponent("Win32_PhysicalMemoryArray", "CreationClassName");
            GetComponent("Win32_PhysicalMemoryArray", "Description");
            GetComponent("Win32_PhysicalMemoryArray", "Height");
            GetComponent("Win32_PhysicalMemoryArray", "HotSwappable");
            GetComponent("Win32_PhysicalMemoryArray", "InstallDate");
            GetComponent("Win32_PhysicalMemoryArray", "Location");
            GetComponent("Win32_PhysicalMemoryArray", "Manufacturer");
            GetComponent("Win32_PhysicalMemoryArray", "MaxCapacity");
            GetComponent("Win32_PhysicalMemoryArray", "MaxCapacityEx");
            GetComponent("Win32_PhysicalMemoryArray", "MemoryDevices");
            GetComponent("Win32_PhysicalMemoryArray", "MemoryErrorCorrection");
            GetComponent("Win32_PhysicalMemoryArray", "Model");
            GetComponent("Win32_PhysicalMemoryArray", "Name");
            GetComponent("Win32_PhysicalMemoryArray", "OtherIdentifyingInfo");
            GetComponent("Win32_PhysicalMemoryArray", "PartNumber");
            GetComponent("Win32_PhysicalMemoryArray", "PoweredOn");
            GetComponent("Win32_PhysicalMemoryArray", "Removable");
            GetComponent("Win32_PhysicalMemoryArray", "Replaceable");
            GetComponent("Win32_PhysicalMemoryArray", "SerialNumber");
            GetComponent("Win32_PhysicalMemoryArray", "SKU");
            GetComponent("Win32_PhysicalMemoryArray", "Status");
            GetComponent("Win32_PhysicalMemoryArray", "Tag");
            GetComponent("Win32_PhysicalMemoryArray", "Use");
            GetComponent("Win32_PhysicalMemoryArray", "Version");
            GetComponent("Win32_PhysicalMemoryArray", "Weight");
            GetComponent("Win32_PhysicalMemoryArray", "Width");

            GetComponent("Win32_SystemBIOS", "PartComponent");
            GetComponent("Win32_SystemBIOS", "GroupComponent");

            //На ноуте не отображается
            GetComponent("Win32_DMAChannel", "AddressSize");
            GetComponent("Win32_DMAChannel", "Availability");
            GetComponent("Win32_DMAChannel", "BurstMode");
            GetComponent("Win32_DMAChannel", "ByteMode");
            GetComponent("Win32_DMAChannel", "Caption");
            GetComponent("Win32_DMAChannel", "ChannelTiming");
            GetComponent("Win32_DMAChannel", "CreationClassName");
            GetComponent("Win32_DMAChannel", "CSCreationClassName");
            GetComponent("Win32_DMAChannel", "CSName");
            GetComponent("Win32_DMAChannel", "Description");
            GetComponent("Win32_DMAChannel", "DMAChannel");
            GetComponent("Win32_DMAChannel", "InstallDate");
            GetComponent("Win32_DMAChannel", "MaxTransferSize");
            GetComponent("Win32_DMAChannel", "Name");
            GetComponent("Win32_DMAChannel", "Port");
            GetComponent("Win32_DMAChannel", "Status");
            GetComponent("Win32_DMAChannel", "TypeCTiming");
            GetComponent("Win32_DMAChannel", "WordMode");
        }

        private void GetComponent(string hwClass, string syntax)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwClass);
            foreach (ManagementObject mj in mos.Get())
            {
                ltsbxTest.Items.Add(hwClass + " " + syntax + " " + Convert.ToString(mj[syntax]));
            }    
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            btnCalc_Click(sender, e);
            string temp = "";

            temp = freq1.Text; freq1.Text = freq2.Text; freq2.Text = temp;
            CL1.Text = CL2.Text;
            RCDRD1.Text = RCDRD2.Text;
            RCDWR1.Text = RCDWR2.Text;
            RP1.Text = RP2.Text;
            RAS1.Text = RAS2.Text;
            RC1.Text = RC2.Text;
            RRDS1.Text = RRDS2.Text;
            RRDL1.Text = RRDL2.Text;
            FAW1.Text = FAW2.Text;
            WTRS1.Text = WTRS2.Text;
            WTRL1.Text = WTRL2.Text;
            WR1.Text = WR2.Text;
            RFC1.Text = RFC2.Text;
            RTP1.Text = RTP2.Text;

            btnCalc_Click(sender, e);
        }
    }
}

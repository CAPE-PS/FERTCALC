using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FERTCALC
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// milligrams for 1ppm
        /// </summary>
        double kno3_no3 = 1.0 / 0.613284;
        double kno3_k = 1.0 / 0.386717;
        double kh2po4_k = 1.0 / 0.287301;
        double kh2po4_po4 = 1.0 / 0.69788;
        double k2so4_k = 1.0 / 0.448737;
        double mgso4_mg = 1.0 / 0.0986127;//0.097?

        double tank;
        double container;
        double dose;
        double days;
        double C;


        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        void GetInfo()
        {
            tank = double.Parse(Tank.Text, CultureInfo.InvariantCulture);
            if (comboBox1.SelectedIndex == 0)
                tank *= 3.78541178;
            container = double.Parse(Container.Text, CultureInfo.InvariantCulture);
            dose = int.Parse(Dosing.Text, CultureInfo.InvariantCulture);
            days = (double)Days.Value;
            C = container / (dose * days);
        }

        void CalcFromTargets()
        {
            GetInfo();
            trackBar1.Minimum = 1;
            trackBar1.Maximum = (int)(dose * 5);
            trackBar1.Value = (int)dose;
            label27.Text = trackBar1.Value.ToString() + " ml";


            double TNO3 = double.Parse(PPMNO3.Text, CultureInfo.InvariantCulture);
            double TK = double.Parse(PPMK.Text, CultureInfo.InvariantCulture);
            double TPO4 = double.Parse(PPMPO4.Text, CultureInfo.InvariantCulture);
            double TMGSO4 = double.Parse(PPMMG.Text, CultureInfo.InvariantCulture);


            double kh2po4 = kh2po4_po4 * tank * TPO4 * C; // mg to reach target PO4 ppm for tank size
            double kno3 = kno3_no3 * tank * TNO3 * C; // mg to reach target NO3 ppm for tank size
            double mg = mgso4_mg * tank * TMGSO4 * C;

            MixKNO3.Text = (kno3 * 1e-3).ToString("F3", CultureInfo.InvariantCulture);
            MixKH2PO4.Text = (kh2po4 * 1e-3).ToString("F3", CultureInfo.InvariantCulture);
            MixMgSO4.Text = (mg * 1e-3).ToString("F3", CultureInfo.InvariantCulture);
            double ppmk1 = kh2po4 / (kh2po4_k * tank * C);
            double ppmk2 = kno3 / (kno3_k * tank * C);
            double ppmk = ppmk1 + ppmk2;
            double ppmk3 = TK - ppmk;
            if (ppmk3 < 0)
                MixK2SO4.Text = "0";
            else
            {
                double v = k2so4_k * tank * ppmk3 * C; // mg to reach target K ppm for tank size
                MixK2SO4.Text = (v * 1e-3).ToString("F3", CultureInfo.InvariantCulture);
            }
            CalcFromWeights();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CalcFromTargets();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = (int)(dose * 5);
            trackBar1.Value = (int)dose;
            label27.Text = trackBar1.Value.ToString() + " ml";
            CalcFromWeights();
        }

        private void CalcFromWeights(double dosepar=1.0)
        {
            GetInfo();

            double kh2po4 = double.Parse(MixKH2PO4.Text, CultureInfo.InvariantCulture) * 1e3;
            double kno3 = double.Parse(MixKNO3.Text, CultureInfo.InvariantCulture) * 1e3;
            double k2so4 = double.Parse(MixK2SO4.Text, CultureInfo.InvariantCulture) * 1e3;
            double mg = double.Parse(MixMgSO4.Text, CultureInfo.InvariantCulture) * 1e3;

            double ppmpo4 = kh2po4 / (kh2po4_po4 * tank * C);
            double ppmno3 = kno3 / (kno3_no3 * tank * C);
            double ppmmg = mg / (mgso4_mg * tank * C);
            double ppmk1 = kh2po4 / (kh2po4_k * tank * C);
            double ppmk2 = kno3 / (kno3_k * tank * C);
            double ppmk3 = k2so4 / (k2so4_k * tank * C);
            double ppmk = ppmk1 + ppmk2 + ppmk3;

            WNO3.Text = (ppmno3* dosepar).ToString("F3", CultureInfo.InvariantCulture);
            WK.Text = (ppmk * dosepar).ToString("F3", CultureInfo.InvariantCulture);
            WPO4.Text = (ppmpo4 * dosepar).ToString("F3", CultureInfo.InvariantCulture);
            WMg.Text = (ppmmg * dosepar).ToString("F3", CultureInfo.InvariantCulture);

            DNO3.Text = (ppmno3*dosepar / days).ToString("F3", CultureInfo.InvariantCulture);
            DK.Text = (ppmk*dosepar / days).ToString("F3", CultureInfo.InvariantCulture);
            DPO4.Text = (ppmpo4*dosepar / days).ToString("F3", CultureInfo.InvariantCulture);
            DMg.Text = (ppmmg*dosepar / days).ToString("F3", CultureInfo.InvariantCulture);

            mlNO3.Text = ((ppmno3 / days) / dose).ToString("F3", CultureInfo.InvariantCulture);
            mlK.Text = ((ppmk / days) / dose).ToString("F3", CultureInfo.InvariantCulture);
            mlPO4.Text = ((ppmpo4 / days) / dose).ToString("F3", CultureInfo.InvariantCulture);
            mlMg.Text = ((ppmmg / days) / dose).ToString("F3", CultureInfo.InvariantCulture);
        }

        private void PPMNO3_Validated(object sender, EventArgs e)
        {
            CalcFromTargets();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double val = trackBar1.Value;
            label27.Text = trackBar1.Value.ToString() + " ml";
            double par = val / dose;
            CalcFromWeights(par);
            label27.Focus();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
        }

        private void Tank_Validated(object sender, EventArgs e)
        {
            CalcFromTargets();
        }

        private void Days_ValueChanged(object sender, EventArgs e)
        {
            CalcFromTargets();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcFromTargets();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox2.SelectedIndex)
            {
                case 0: 
                    {
                        // EI
                        PPMNO3.Text = "20";
                        PPMK.Text = "20";
                        PPMPO4.Text = "2";
                        PPMMG.Text = "7.5";
                        Days.Value = 3;
                        break;
                    }
                case 1:
                    {
                        // ADA
                        PPMNO3.Text = "3";
                        PPMK.Text = "22";
                        PPMPO4.Text = "3";
                        PPMMG.Text = "0";
                        Days.Value = 7;
                        break;
                    }
                case 2:
                    {
                        // PPS
                        PPMNO3.Text = "7";
                        PPMK.Text = "10";
                        PPMPO4.Text = "1";
                        PPMMG.Text = "3.5";
                        Days.Value = 7;
                        break;
                    }
                case 3:
                    {
                        // PMDD
                        PPMNO3.Text = "3";
                        PPMK.Text = "3";
                        PPMPO4.Text = "0.2";
                        PPMMG.Text = "0.5";
                        Days.Value = 3;
                        break;
                    }
            }
            CalcFromTargets();
        }

        private void MixKNO3_Validated(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = (int)(dose * 5);
            trackBar1.Value = (int)dose;
            label27.Text = trackBar1.Value.ToString() + " ml";
            CalcFromWeights();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opgave5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_bereken_Click(object sender, EventArgs e)
        {
            int afstand = 0;

            if (rbtn_500m.Checked)
            {
                afstand = 500;
            }
            else
            {
                if (rbtn_1000m.Checked)
                {
                    afstand = 100;
                }
                else
                {
                    if (rbtn_1500m.Checked)
                    {
                        afstand = 1500;
                    }
                    else
                    {
                        if (rbtn_5000m.Checked)
                        {
                            afstand = 5000;
                        }
                    }
                }
            }

            double minuten = Double.Parse(txt_minuten.Text);
            double seconden = Double.Parse(txt_seconden.Text);
            double hondersten = Double.Parse(txt_hondersten.Text);

            double totaalSeconden = minuten * 60 + seconden + (hondersten/100);

            double gemiddeldeSnelheidKm = BerekenGemiddeldeSnelheid(afstand, totaalSeconden, true);
            lbl_snelheidKmOutput.Text = gemiddeldeSnelheidKm.ToString("00.00");

            double gemiddeldeSnelheidMiles = BerekenGemiddeldeSnelheid(afstand, totaalSeconden, false);
            lbl_snelheidMOutput.Text = gemiddeldeSnelheidMiles.ToString("00.00");
        }

        static double BerekenGemiddeldeSnelheid(double meters, double seconden, bool kmPerUur)
        {
            double afstand = 0;

            if (kmPerUur)
            {
                afstand = meters / 1000;
            }
            else
            {
                afstand = meters / 1609.344;
            }

            double uren = seconden / 3600;
            double gemiddeldeSnelheid = afstand / uren;
            return gemiddeldeSnelheid;
        }
    }
}

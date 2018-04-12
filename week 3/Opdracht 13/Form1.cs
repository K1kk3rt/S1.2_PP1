using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_13
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btn_berekenen_Click(object sender, EventArgs e)
        {
            double dagengehuurd = Double.Parse(txt_dagengehuurd.Text);
            double kmgereden = Double.Parse(txt_kmgereden.Text);
            double litergetankt = Double.Parse(txt_litergetankt.Text);

            double huurkosten = 55 * dagengehuurd;
            double kmkosten;
            double tankkosten;

            double vrijekm = dagengehuurd * 100;

            if (kmgereden > vrijekm)
            {
                kmkosten = (kmgereden - 100) * 0.25;

            }
            else
            {
                kmkosten = 0;
            }

            if (check_tankenhuurder.Checked)
            {
                tankkosten = litergetankt * 2.20;
            }
            else
            {
                tankkosten = 0;
            }

            double huurbedragOutput = huurkosten + kmkosten + tankkosten;
            lbl_huurbedragOutput.Text = huurbedragOutput.ToString("0.00");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_8
{
    public partial class BTWForm : Form
    {
        public BTWForm()
        {
            InitializeComponent();
        }

        private void btn_bereken_Click(object sender, EventArgs e)
        {
        
            
            //lees ingevulden waardes (string) en convert ze naar double
            double aantaltshirts = Double.Parse(txt_aantaltshirts.Text);
            double aantalbroeken = Double.Parse(txt_aantalbroeken.Text);

            //declare prijs, btw en totaalprijs
            double prijs = (aantalbroeken * 100) + (aantaltshirts * 30);
            double btw = prijs * 0.21;
            double totaalprijs = btw + prijs;

            //zet antwoorden in labals, "0.00" zorgt voor twee cijfers achter de komma
            lbl_toonprijs.Text = prijs.ToString("0.00");
            lbl_toonbtw.Text = btw.ToString("0.00");
            lbl_toontotaalprijs.Text = totaalprijs.ToString("0.00");


        }

        private void label1_Click(object sender, EventArgs e)
        {
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_aantaltshirts_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

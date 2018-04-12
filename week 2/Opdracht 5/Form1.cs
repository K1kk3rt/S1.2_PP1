using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_BerekenGemiddelde_Click(object sender, EventArgs e)
        {
            //Lees uit textboxen (string), convert naar een double en zet het in een nieuwe variable
            Double Getal1 = double.Parse(txt_Getal1.Text);
            Double Getal2 = double.Parse(txt_Getal2.Text);
            Double Getal3 = double.Parse(txt_Getal3.Text);

            //reken met said variablen, en zet het in nieuwe variabelen
            Double Gemiddelde = (Getal1 + Getal2 + Getal3) / 3;

           
            //zet antwoord in lbl_Gemiddelde
            lbl_Gemiddelde.Text = Gemiddelde.ToString();

        }
    }
}

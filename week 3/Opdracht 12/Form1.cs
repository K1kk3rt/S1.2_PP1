using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_12
{
    public partial class Bioscoopkaartje : Form
    {
        public Bioscoopkaartje()
        {
            InitializeComponent();
        }

        private void btn_bereken_Click(object sender, EventArgs e)
        {
            int leeftijd = Int32.Parse(txt_leeftijd.Text);

            int basisprijs = 12;
            double prijs;
            

            if (leeftijd < 5)
            {
                lbl_prijs.Text = "gratis";
            }
            if ((leeftijd >= 5) && (leeftijd <= 12))
            {
                prijs = basisprijs / 2;
                lbl_prijs.Text = prijs.ToString("0.00");
            }
            if ((leeftijd >= 13) && (leeftijd <= 54))
            {
                prijs = basisprijs;
                lbl_prijs.Text = prijs.ToString("0.00");
            }
            if (leeftijd >= 55)
            {
                lbl_prijs.Text = "gratis";
            }

        }
    }
}

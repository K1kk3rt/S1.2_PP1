using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_maakVierkant_Click(object sender, EventArgs e)
        {
            //declare en lees variabelen
            string spatie = " ";
            string ster = "x";
            string nieuwe_regel = "\n";
            int zijde = Int32.Parse(txt_zijde.Text);
            int rij = 0;
            int kolom;
            string vierkant = "";       //schrijf het hele patroon in een string, lees 'm daarna in het label

            //terwijl rij kleiner is als zijde, kolom = 0
            while (rij < zijde)
            {
                kolom = 0;

                //terwijl kolom kleiner is dan zijde
                //als rij nul is of rij zijde-1 of kolom is gelijk aan 0 of kolom is zijde -1, vierkant = vierkant + ster
                //anders vierkant = vierkant + spatie
                while (kolom < zijde)
                {
                    if ((rij == 0) || (rij == zijde-1) || (kolom == 0) || (kolom == zijde-1))
                    {
                        vierkant = vierkant + ster;
                    }
                    else {
                        vierkant = vierkant + spatie;
                    }
                    kolom = kolom + 1;
                }
                //ga naar een nieuwe regel en rij = rij + 1
                vierkant = vierkant + nieuwe_regel;
                rij++;
            }
            //schrijf het hele patroon in een keer naar het label
            lbl_output.Text = vierkant;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_vergelijk_Click(object sender, EventArgs e)
        {
            //lees variabele
            double getaln = Double.Parse(txt_getaln.Text);
            double optelgetal = 0;
            double som = 0;

            //Bereken de formule en geef het weer
            double formule = getaln * (getaln + 1) / 2;
            lbl_formuleOutput.Text = formule.ToString();

            //Terwijl optelgetal kleiner of gelijk is aan getaln, bereken som, tel 1 op bij optelgetal en geef het weer
            while (optelgetal <= getaln)
            {
                som = som + optelgetal;
                optelgetal++;
                lbl_somOutput.Text = som.ToString();
                
            }

            //als som gelijk is aan formule, geef weer dat de sommen gelijk zijn
            //anders geef weer dat de sommen niet gelijk zijn
            if (som == formule)
            {
                lbl_textOutput.Text = "De twee sommen zijn gelijk";
            }
            else
            {
                lbl_textOutput.Text = "De twee sommen zijn niet gelijk";
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_berekenen_Click(object sender, EventArgs e)
        {
            //Lees variabelen, en verklaar variabelen
            double startBedrag = Double.Parse(txt_startBedrag.Text);
            double bedrag = startBedrag;
            int jaren = 1;

            //zo lang jaren kleiner of gelijk is aan 5, bereken het bedrag en tel 1 op bij jaren
            while (jaren <= 5)
            {
                bedrag = bedrag * 1.05;
                jaren = jaren + 1;
            }

            //weerkeef het bedrag
            lbl_eindKapitaalOutput.Text = bedrag.ToString("0.00");
        }
    }
}

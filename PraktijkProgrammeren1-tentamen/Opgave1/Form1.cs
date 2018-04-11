using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opgave1
{
    public partial class form_Duimelot : Form
    {
        //declare variable zodat het door het hele form gebruikt kan worden
        int count = 0;

        public form_Duimelot()
        {
            InitializeComponent();

        }
        public void btn_next_Click(object sender, EventArgs e)
        {
            //lees rijmpje
            string rijmpje = lbl_rijmpjeOUTPUT.Text;

            //tel 1 op bij count, zodat na elke klik de volgende regel erbij komt
            count++;

            //nieuwe regel na een klik
            if (count == 1)
            {
                rijmpje = rijmpje + "Naar bed, naar bed, zei Duimelot" + "\n";
            }
            if (count == 2)
            {
                rijmpje = rijmpje + "Eerst nog wat eten, zei Likkepot" + "\n";
            }
            if (count == 3)
            {
                rijmpje = rijmpje + "Waar zal ik het halen, zei Langelijs" + "\n";
            }
            if (count == 4)
            {
                rijmpje = rijmpje + "Uit grootmoeders kastje, zei Ringeling" + "\n";
            }
            if (count == 5)
            {
                rijmpje = rijmpje + "Dat ga ik verklappen, zei het kleine ding" + "\n";
                //disable de knop next
                btn_next.Enabled = false;
            }

            //schrijf rijmpje
            lbl_rijmpjeOUTPUT.Text = rijmpje;
        }

        //reset knop
        private void btn_reset_Click(object sender, EventArgs e)
        {
            //maak rijmpje leeg
            string rijmpje = "";

            //schrijf leeg rijmpje
            lbl_rijmpjeOUTPUT.Text = rijmpje;

            //zet count terug op 0
            count = 0;

            //enable de knop next
            btn_next.Enabled = true;
        }
    }
}

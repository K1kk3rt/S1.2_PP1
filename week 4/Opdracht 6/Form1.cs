using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_6
{
    public partial class Bank : Form
    {

        private void button1_Click(object sender, EventArgs e)
        {
            double startBedrag = Double.Parse(txt_startBedrag.Text);
            double bedrag = startBedrag;
            int jaren = 1;

            while (jaren <= 5)
            {
                bedrag = startBedrag * 1.05;
                jaren = jaren + 1;
            }

            lbl_eindKapitaalOutput.Text = bedrag.ToString();
        }
    }
}

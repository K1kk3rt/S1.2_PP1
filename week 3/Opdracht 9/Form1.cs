using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_berekenContributie_Click(object sender, EventArgs e)
        {
            double leeftijd = Double.Parse(txt_leeftijd.Text);
            double lidmaatschap = Double.Parse(txt_leeftijd.Text);

            double contributie;

            if (radbtn_Voetbal.Checked == true)
            {
                contributie = 175;
            }
            else
            {
                contributie = 225;
            }

            if (leeftijd > 40)
            {
                contributie = contributie - 25;
            }

            if (lidmaatschap > 10)
            {
                contributie = contributie - 20;
            }

            lbl_ContributieOutput.Text = contributie.ToString("0.00");
        }
            
    }
}

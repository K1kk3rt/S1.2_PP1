using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_4
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

        private void btn_berekenbtw_Click(object sender, EventArgs e)
        {
            //lees wat er in txt_prijs staat, en zet dat in invoer (string)
            //convert dat naar een double en zet dat in prijs (double)
            //convert prijs (double) naar een string, en zet de inhoud van variable prijs in lbl_Prijs
            String invoer = txt_prijs.Text;
            Double prijs = double.Parse(invoer);
            lbl_Prijs.Text = prijs.ToString();

            //declare prijsbtw, convert het naar een string en zet het in lbl_Btw
            Double prijsbtw = prijs * 0.21;
            lbl_Btw.Text = prijsbtw.ToString();

            //declare prijstotaal, convert het naar een string en zet het in lbl_Totaal
            Double prijstotaal = prijs * 1.21;
            lbl_Totaal.Text = prijstotaal.ToString();
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

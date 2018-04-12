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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void lbl_beginkm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_prijsexbtw_Click(object sender, EventArgs e)
        {

        }

        private void btn_berekenen_Click(object sender, EventArgs e)
        {
            //Lees ingevulde variabelen (string) en convert ze naar double
            Double beginkm = double.Parse(txt_beginkm.Text);
            Double eindkm = double.Parse(txt_eindkm.Text);
            Double prijsperkm = double.Parse(txt_prijsperkm.Text);

            //declare kmstand
            Double kmstand = eindkm - beginkm;
            
            //declare prijsexbtw, btw en prijsinclbtw
            Double prijsexbtw = kmstand * prijsperkm;
            Double btw = kmstand * 0.21;
            Double prijsinclbtw = prijsexbtw + btw;

            //zet antwoorden in labels
            lbl_toonprijsexbtw.Text = prijsexbtw.ToString();
            lbl_toonbtw.Text = btw.ToString();
            lbl_toonprijsinclbtw.Text = prijsinclbtw.ToString();




      
        }

        private void btn_wissen_Click(object sender, EventArgs e)
        {
            //maak alle textboxen leeg
            txt_beginkm.Text = String.Empty;
            txt_eindkm.Text = String.Empty;
            txt_prijsperkm.Text = String.Empty;

            //maak alle labels leeg
            lbl_toonprijsexbtw.Text = "";
            lbl_toonprijsinclbtw.Text = "";
            lbl_toonbtw.Text = "";
        }
    }
}

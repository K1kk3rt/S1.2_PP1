namespace Opdracht_8
{
    partial class BTWForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_aantaltshirts = new System.Windows.Forms.Label();
            this.lbl_aantalbroeken = new System.Windows.Forms.Label();
            this.txt_aantaltshirts = new System.Windows.Forms.TextBox();
            this.txt_aantalbroeken = new System.Windows.Forms.TextBox();
            this.btn_bereken = new System.Windows.Forms.Button();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.lbl_prijs = new System.Windows.Forms.Label();
            this.lbl_btw = new System.Windows.Forms.Label();
            this.lbl_totaalprijs = new System.Windows.Forms.Label();
            this.lbl_toonprijs = new System.Windows.Forms.Label();
            this.lbl_toonbtw = new System.Windows.Forms.Label();
            this.lbl_toontotaalprijs = new System.Windows.Forms.Label();
            this.lbl_toondatum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_aantaltshirts
            // 
            this.lbl_aantaltshirts.AutoSize = true;
            this.lbl_aantaltshirts.Location = new System.Drawing.Point(12, 20);
            this.lbl_aantaltshirts.Name = "lbl_aantaltshirts";
            this.lbl_aantaltshirts.Size = new System.Drawing.Size(125, 13);
            this.lbl_aantaltshirts.TabIndex = 0;
            this.lbl_aantaltshirts.Text = "Aantal T-shirts a 30 euro ";
            // 
            // lbl_aantalbroeken
            // 
            this.lbl_aantalbroeken.AutoSize = true;
            this.lbl_aantalbroeken.Location = new System.Drawing.Point(12, 46);
            this.lbl_aantalbroeken.Name = "lbl_aantalbroeken";
            this.lbl_aantalbroeken.Size = new System.Drawing.Size(136, 13);
            this.lbl_aantalbroeken.TabIndex = 1;
            this.lbl_aantalbroeken.Text = "Aantal broeken a 100 euro ";
            // 
            // txt_aantaltshirts
            // 
            this.txt_aantaltshirts.Location = new System.Drawing.Point(165, 20);
            this.txt_aantaltshirts.Name = "txt_aantaltshirts";
            this.txt_aantaltshirts.Size = new System.Drawing.Size(184, 20);
            this.txt_aantaltshirts.TabIndex = 2;
            this.txt_aantaltshirts.TextChanged += new System.EventHandler(this.txt_aantaltshirts_TextChanged);
            // 
            // txt_aantalbroeken
            // 
            this.txt_aantalbroeken.Location = new System.Drawing.Point(165, 46);
            this.txt_aantalbroeken.Name = "txt_aantalbroeken";
            this.txt_aantalbroeken.Size = new System.Drawing.Size(184, 20);
            this.txt_aantalbroeken.TabIndex = 3;
            // 
            // btn_bereken
            // 
            this.btn_bereken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_bereken.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_bereken.Image = global::Opdracht_8.Properties.Resources.download;
            this.btn_bereken.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bereken.Location = new System.Drawing.Point(16, 72);
            this.btn_bereken.Name = "btn_bereken";
            this.btn_bereken.Size = new System.Drawing.Size(337, 40);
            this.btn_bereken.TabIndex = 4;
            this.btn_bereken.Text = "Bereken prijs";
            this.btn_bereken.UseVisualStyleBackColor = true;
            this.btn_bereken.Click += new System.EventHandler(this.btn_bereken_Click);
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Location = new System.Drawing.Point(12, 153);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(41, 13);
            this.lbl_datum.TabIndex = 5;
            this.lbl_datum.Text = "Datum:";
            // 
            // lbl_prijs
            // 
            this.lbl_prijs.AutoSize = true;
            this.lbl_prijs.Location = new System.Drawing.Point(12, 176);
            this.lbl_prijs.Name = "lbl_prijs";
            this.lbl_prijs.Size = new System.Drawing.Size(29, 13);
            this.lbl_prijs.TabIndex = 6;
            this.lbl_prijs.Text = "Prijs:";
            // 
            // lbl_btw
            // 
            this.lbl_btw.AutoSize = true;
            this.lbl_btw.Location = new System.Drawing.Point(12, 200);
            this.lbl_btw.Name = "lbl_btw";
            this.lbl_btw.Size = new System.Drawing.Size(35, 13);
            this.lbl_btw.TabIndex = 7;
            this.lbl_btw.Text = "BTW:";
            this.lbl_btw.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_totaalprijs
            // 
            this.lbl_totaalprijs.AutoSize = true;
            this.lbl_totaalprijs.Location = new System.Drawing.Point(12, 247);
            this.lbl_totaalprijs.Name = "lbl_totaalprijs";
            this.lbl_totaalprijs.Size = new System.Drawing.Size(61, 13);
            this.lbl_totaalprijs.TabIndex = 8;
            this.lbl_totaalprijs.Text = "Totaal prijs:";
            // 
            // lbl_toonprijs
            // 
            this.lbl_toonprijs.AutoSize = true;
            this.lbl_toonprijs.Location = new System.Drawing.Point(165, 175);
            this.lbl_toonprijs.Name = "lbl_toonprijs";
            this.lbl_toonprijs.Size = new System.Drawing.Size(0, 13);
            this.lbl_toonprijs.TabIndex = 10;
            // 
            // lbl_toonbtw
            // 
            this.lbl_toonbtw.AutoSize = true;
            this.lbl_toonbtw.Location = new System.Drawing.Point(162, 200);
            this.lbl_toonbtw.Name = "lbl_toonbtw";
            this.lbl_toonbtw.Size = new System.Drawing.Size(0, 13);
            this.lbl_toonbtw.TabIndex = 11;
            // 
            // lbl_toontotaalprijs
            // 
            this.lbl_toontotaalprijs.AutoSize = true;
            this.lbl_toontotaalprijs.Location = new System.Drawing.Point(165, 247);
            this.lbl_toontotaalprijs.Name = "lbl_toontotaalprijs";
            this.lbl_toontotaalprijs.Size = new System.Drawing.Size(0, 13);
            this.lbl_toontotaalprijs.TabIndex = 12;
            // 
            // lbl_toondatum
            // 
            this.lbl_toondatum.AutoSize = true;
            this.lbl_toondatum.Location = new System.Drawing.Point(168, 153);
            this.lbl_toondatum.Name = "lbl_toondatum";
            this.lbl_toondatum.Size = new System.Drawing.Size(0, 13);
            this.lbl_toondatum.TabIndex = 13;
            this.lbl_toondatum.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // BTWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 295);
            this.Controls.Add(this.lbl_toondatum);
            this.Controls.Add(this.lbl_toontotaalprijs);
            this.Controls.Add(this.lbl_toonbtw);
            this.Controls.Add(this.lbl_toonprijs);
            this.Controls.Add(this.lbl_totaalprijs);
            this.Controls.Add(this.lbl_btw);
            this.Controls.Add(this.lbl_prijs);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.btn_bereken);
            this.Controls.Add(this.txt_aantalbroeken);
            this.Controls.Add(this.txt_aantaltshirts);
            this.Controls.Add(this.lbl_aantalbroeken);
            this.Controls.Add(this.lbl_aantaltshirts);
            this.Name = "BTWForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_aantaltshirts;
        private System.Windows.Forms.Label lbl_aantalbroeken;
        private System.Windows.Forms.TextBox txt_aantaltshirts;
        private System.Windows.Forms.TextBox txt_aantalbroeken;
        private System.Windows.Forms.Button btn_bereken;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.Label lbl_prijs;
        private System.Windows.Forms.Label lbl_btw;
        private System.Windows.Forms.Label lbl_totaalprijs;
        private System.Windows.Forms.Label lbl_toonprijs;
        private System.Windows.Forms.Label lbl_toonbtw;
        private System.Windows.Forms.Label lbl_toontotaalprijs;
        private System.Windows.Forms.Label lbl_toondatum;
    }
}


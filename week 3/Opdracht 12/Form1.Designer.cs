namespace Opdracht_12
{
    partial class Bioscoopkaartje
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
            this.lbl_leeftijd = new System.Windows.Forms.Label();
            this.lbl_PrijsKaartje = new System.Windows.Forms.Label();
            this.lbl_euro = new System.Windows.Forms.Label();
            this.lbl_prijs = new System.Windows.Forms.Label();
            this.txt_leeftijd = new System.Windows.Forms.TextBox();
            this.btn_bereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_leeftijd
            // 
            this.lbl_leeftijd.AutoEllipsis = true;
            this.lbl_leeftijd.AutoSize = true;
            this.lbl_leeftijd.Location = new System.Drawing.Point(24, 27);
            this.lbl_leeftijd.Name = "lbl_leeftijd";
            this.lbl_leeftijd.Size = new System.Drawing.Size(41, 13);
            this.lbl_leeftijd.TabIndex = 0;
            this.lbl_leeftijd.Text = "Leeftijd";
            // 
            // lbl_PrijsKaartje
            // 
            this.lbl_PrijsKaartje.AutoEllipsis = true;
            this.lbl_PrijsKaartje.AutoSize = true;
            this.lbl_PrijsKaartje.Location = new System.Drawing.Point(24, 141);
            this.lbl_PrijsKaartje.Name = "lbl_PrijsKaartje";
            this.lbl_PrijsKaartje.Size = new System.Drawing.Size(105, 13);
            this.lbl_PrijsKaartje.TabIndex = 1;
            this.lbl_PrijsKaartje.Text = "Prijs Bioscoopkaartje";
            // 
            // lbl_euro
            // 
            this.lbl_euro.AutoEllipsis = true;
            this.lbl_euro.AutoSize = true;
            this.lbl_euro.Location = new System.Drawing.Point(150, 141);
            this.lbl_euro.Name = "lbl_euro";
            this.lbl_euro.Size = new System.Drawing.Size(13, 13);
            this.lbl_euro.TabIndex = 2;
            this.lbl_euro.Text = "€";
            // 
            // lbl_prijs
            // 
            this.lbl_prijs.AutoEllipsis = true;
            this.lbl_prijs.AutoSize = true;
            this.lbl_prijs.Location = new System.Drawing.Point(169, 141);
            this.lbl_prijs.Name = "lbl_prijs";
            this.lbl_prijs.Size = new System.Drawing.Size(10, 13);
            this.lbl_prijs.TabIndex = 3;
            this.lbl_prijs.Text = "-";
            // 
            // txt_leeftijd
            // 
            this.txt_leeftijd.Location = new System.Drawing.Point(153, 20);
            this.txt_leeftijd.Name = "txt_leeftijd";
            this.txt_leeftijd.Size = new System.Drawing.Size(100, 20);
            this.txt_leeftijd.TabIndex = 4;
            // 
            // btn_bereken
            // 
            this.btn_bereken.Location = new System.Drawing.Point(27, 87);
            this.btn_bereken.Name = "btn_bereken";
            this.btn_bereken.Size = new System.Drawing.Size(226, 23);
            this.btn_bereken.TabIndex = 5;
            this.btn_bereken.Text = "Bereken prijs bioscoopkaartje";
            this.btn_bereken.UseVisualStyleBackColor = true;
            this.btn_bereken.Click += new System.EventHandler(this.btn_bereken_Click);
            // 
            // Bioscoopkaartje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_bereken);
            this.Controls.Add(this.txt_leeftijd);
            this.Controls.Add(this.lbl_prijs);
            this.Controls.Add(this.lbl_euro);
            this.Controls.Add(this.lbl_PrijsKaartje);
            this.Controls.Add(this.lbl_leeftijd);
            this.Name = "Bioscoopkaartje";
            this.Text = "Bioscoopkaartje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_leeftijd;
        private System.Windows.Forms.Label lbl_PrijsKaartje;
        private System.Windows.Forms.Label lbl_euro;
        private System.Windows.Forms.Label lbl_prijs;
        private System.Windows.Forms.TextBox txt_leeftijd;
        private System.Windows.Forms.Button btn_bereken;
    }
}


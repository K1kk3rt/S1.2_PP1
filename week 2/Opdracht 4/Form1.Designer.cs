namespace Opdracht_4
{
    partial class Form1
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
            this.btn_berekenbtw = new System.Windows.Forms.Button();
            this.txt_prijs = new System.Windows.Forms.TextBox();
            this.lbl_geefprijs = new System.Windows.Forms.Label();
            this.lbl_ToonPrijs = new System.Windows.Forms.Label();
            this.lbl_ToonBTW = new System.Windows.Forms.Label();
            this.lbl_ToonTotaal = new System.Windows.Forms.Label();
            this.lbl_Prijs = new System.Windows.Forms.Label();
            this.lbl_Btw = new System.Windows.Forms.Label();
            this.lbl_Totaal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_berekenbtw
            // 
            this.btn_berekenbtw.Location = new System.Drawing.Point(45, 64);
            this.btn_berekenbtw.Name = "btn_berekenbtw";
            this.btn_berekenbtw.Size = new System.Drawing.Size(210, 32);
            this.btn_berekenbtw.TabIndex = 0;
            this.btn_berekenbtw.Text = "Bereken uw BTW";
            this.btn_berekenbtw.UseVisualStyleBackColor = true;
            this.btn_berekenbtw.Click += new System.EventHandler(this.btn_berekenbtw_Click);
            // 
            // txt_prijs
            // 
            this.txt_prijs.Location = new System.Drawing.Point(181, 25);
            this.txt_prijs.Name = "txt_prijs";
            this.txt_prijs.Size = new System.Drawing.Size(100, 20);
            this.txt_prijs.TabIndex = 1;
            // 
            // lbl_geefprijs
            // 
            this.lbl_geefprijs.Location = new System.Drawing.Point(42, 28);
            this.lbl_geefprijs.Name = "lbl_geefprijs";
            this.lbl_geefprijs.Size = new System.Drawing.Size(72, 17);
            this.lbl_geefprijs.TabIndex = 2;
            this.lbl_geefprijs.Text = "Geef Prijs";
            this.lbl_geefprijs.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_ToonPrijs
            // 
            this.lbl_ToonPrijs.AutoSize = true;
            this.lbl_ToonPrijs.Location = new System.Drawing.Point(31, 116);
            this.lbl_ToonPrijs.Name = "lbl_ToonPrijs";
            this.lbl_ToonPrijs.Size = new System.Drawing.Size(29, 13);
            this.lbl_ToonPrijs.TabIndex = 3;
            this.lbl_ToonPrijs.Text = "Prijs:";
            // 
            // lbl_ToonBTW
            // 
            this.lbl_ToonBTW.AutoSize = true;
            this.lbl_ToonBTW.Location = new System.Drawing.Point(31, 147);
            this.lbl_ToonBTW.Name = "lbl_ToonBTW";
            this.lbl_ToonBTW.Size = new System.Drawing.Size(35, 13);
            this.lbl_ToonBTW.TabIndex = 4;
            this.lbl_ToonBTW.Text = "BTW:";
            // 
            // lbl_ToonTotaal
            // 
            this.lbl_ToonTotaal.AutoSize = true;
            this.lbl_ToonTotaal.Location = new System.Drawing.Point(31, 177);
            this.lbl_ToonTotaal.Name = "lbl_ToonTotaal";
            this.lbl_ToonTotaal.Size = new System.Drawing.Size(62, 13);
            this.lbl_ToonTotaal.TabIndex = 5;
            this.lbl_ToonTotaal.Text = "Totaal Prijs:";
            // 
            // lbl_Prijs
            // 
            this.lbl_Prijs.AutoSize = true;
            this.lbl_Prijs.Location = new System.Drawing.Point(178, 116);
            this.lbl_Prijs.Name = "lbl_Prijs";
            this.lbl_Prijs.Size = new System.Drawing.Size(0, 13);
            this.lbl_Prijs.TabIndex = 6;
            // 
            // lbl_Btw
            // 
            this.lbl_Btw.AutoSize = true;
            this.lbl_Btw.Location = new System.Drawing.Point(178, 147);
            this.lbl_Btw.Name = "lbl_Btw";
            this.lbl_Btw.Size = new System.Drawing.Size(0, 13);
            this.lbl_Btw.TabIndex = 7;
            // 
            // lbl_Totaal
            // 
            this.lbl_Totaal.AutoSize = true;
            this.lbl_Totaal.Location = new System.Drawing.Point(178, 177);
            this.lbl_Totaal.Name = "lbl_Totaal";
            this.lbl_Totaal.Size = new System.Drawing.Size(0, 13);
            this.lbl_Totaal.TabIndex = 8;
            this.lbl_Totaal.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 268);
            this.Controls.Add(this.lbl_Totaal);
            this.Controls.Add(this.lbl_Btw);
            this.Controls.Add(this.lbl_Prijs);
            this.Controls.Add(this.lbl_ToonTotaal);
            this.Controls.Add(this.lbl_ToonBTW);
            this.Controls.Add(this.lbl_ToonPrijs);
            this.Controls.Add(this.lbl_geefprijs);
            this.Controls.Add(this.txt_prijs);
            this.Controls.Add(this.btn_berekenbtw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_berekenbtw;
        private System.Windows.Forms.TextBox txt_prijs;
        private System.Windows.Forms.Label lbl_geefprijs;
        private System.Windows.Forms.Label lbl_ToonPrijs;
        private System.Windows.Forms.Label lbl_ToonBTW;
        private System.Windows.Forms.Label lbl_ToonTotaal;
        private System.Windows.Forms.Label lbl_Prijs;
        private System.Windows.Forms.Label lbl_Btw;
        private System.Windows.Forms.Label lbl_Totaal;
    }
}


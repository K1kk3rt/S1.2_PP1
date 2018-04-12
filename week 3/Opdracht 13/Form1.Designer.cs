namespace Opdracht_13
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
            this.lbl_dagen = new System.Windows.Forms.Label();
            this.lbl_kmgereden = new System.Windows.Forms.Label();
            this.lbl_litersgetankt = new System.Windows.Forms.Label();
            this.txt_dagengehuurd = new System.Windows.Forms.TextBox();
            this.txt_kmgereden = new System.Windows.Forms.TextBox();
            this.txt_litergetankt = new System.Windows.Forms.TextBox();
            this.check_tankenhuurder = new System.Windows.Forms.CheckBox();
            this.btn_berekenen = new System.Windows.Forms.Button();
            this.lbl_uurbedrag = new System.Windows.Forms.Label();
            this.lbl_huurbedragOutput = new System.Windows.Forms.Label();
            this.lbl_euro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_dagen
            // 
            this.lbl_dagen.AutoSize = true;
            this.lbl_dagen.Location = new System.Drawing.Point(24, 25);
            this.lbl_dagen.Name = "lbl_dagen";
            this.lbl_dagen.Size = new System.Drawing.Size(128, 13);
            this.lbl_dagen.TabIndex = 0;
            this.lbl_dagen.Text = "Hoeveel dagen gehuurd?";
            this.lbl_dagen.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_kmgereden
            // 
            this.lbl_kmgereden.AutoSize = true;
            this.lbl_kmgereden.Location = new System.Drawing.Point(24, 55);
            this.lbl_kmgereden.Name = "lbl_kmgereden";
            this.lbl_kmgereden.Size = new System.Drawing.Size(112, 13);
            this.lbl_kmgereden.TabIndex = 1;
            this.lbl_kmgereden.Text = "Hoeveel km gereden?";
            // 
            // lbl_litersgetankt
            // 
            this.lbl_litersgetankt.AutoSize = true;
            this.lbl_litersgetankt.Location = new System.Drawing.Point(24, 123);
            this.lbl_litersgetankt.Name = "lbl_litersgetankt";
            this.lbl_litersgetankt.Size = new System.Drawing.Size(116, 13);
            this.lbl_litersgetankt.TabIndex = 2;
            this.lbl_litersgetankt.Text = "Hoeveel liters getankt?";
            // 
            // txt_dagengehuurd
            // 
            this.txt_dagengehuurd.Location = new System.Drawing.Point(172, 25);
            this.txt_dagengehuurd.Name = "txt_dagengehuurd";
            this.txt_dagengehuurd.Size = new System.Drawing.Size(100, 20);
            this.txt_dagengehuurd.TabIndex = 3;
            // 
            // txt_kmgereden
            // 
            this.txt_kmgereden.Location = new System.Drawing.Point(172, 55);
            this.txt_kmgereden.Name = "txt_kmgereden";
            this.txt_kmgereden.Size = new System.Drawing.Size(100, 20);
            this.txt_kmgereden.TabIndex = 4;
            // 
            // txt_litergetankt
            // 
            this.txt_litergetankt.Location = new System.Drawing.Point(172, 116);
            this.txt_litergetankt.Name = "txt_litergetankt";
            this.txt_litergetankt.Size = new System.Drawing.Size(100, 20);
            this.txt_litergetankt.TabIndex = 5;
            // 
            // check_tankenhuurder
            // 
            this.check_tankenhuurder.AutoSize = true;
            this.check_tankenhuurder.Location = new System.Drawing.Point(27, 87);
            this.check_tankenhuurder.Name = "check_tankenhuurder";
            this.check_tankenhuurder.Size = new System.Drawing.Size(188, 17);
            this.check_tankenhuurder.TabIndex = 6;
            this.check_tankenhuurder.Text = "Tanken op kosten van de huurder";
            this.check_tankenhuurder.UseVisualStyleBackColor = true;
            // 
            // btn_berekenen
            // 
            this.btn_berekenen.Location = new System.Drawing.Point(27, 155);
            this.btn_berekenen.Name = "btn_berekenen";
            this.btn_berekenen.Size = new System.Drawing.Size(245, 23);
            this.btn_berekenen.TabIndex = 7;
            this.btn_berekenen.Text = "Bereken huurbedrag";
            this.btn_berekenen.UseVisualStyleBackColor = true;
            this.btn_berekenen.Click += new System.EventHandler(this.btn_berekenen_Click);
            // 
            // lbl_uurbedrag
            // 
            this.lbl_uurbedrag.AutoSize = true;
            this.lbl_uurbedrag.Location = new System.Drawing.Point(24, 213);
            this.lbl_uurbedrag.Name = "lbl_uurbedrag";
            this.lbl_uurbedrag.Size = new System.Drawing.Size(66, 13);
            this.lbl_uurbedrag.TabIndex = 8;
            this.lbl_uurbedrag.Text = "Huurbedrag:";
            // 
            // lbl_huurbedragOutput
            // 
            this.lbl_huurbedragOutput.AutoSize = true;
            this.lbl_huurbedragOutput.Location = new System.Drawing.Point(248, 213);
            this.lbl_huurbedragOutput.Name = "lbl_huurbedragOutput";
            this.lbl_huurbedragOutput.Size = new System.Drawing.Size(10, 13);
            this.lbl_huurbedragOutput.TabIndex = 9;
            this.lbl_huurbedragOutput.Text = "-";
            this.lbl_huurbedragOutput.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_euro
            // 
            this.lbl_euro.AutoSize = true;
            this.lbl_euro.Location = new System.Drawing.Point(229, 213);
            this.lbl_euro.Name = "lbl_euro";
            this.lbl_euro.Size = new System.Drawing.Size(13, 13);
            this.lbl_euro.TabIndex = 10;
            this.lbl_euro.Text = "€";
            this.lbl_euro.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_euro);
            this.Controls.Add(this.lbl_huurbedragOutput);
            this.Controls.Add(this.lbl_uurbedrag);
            this.Controls.Add(this.btn_berekenen);
            this.Controls.Add(this.check_tankenhuurder);
            this.Controls.Add(this.txt_litergetankt);
            this.Controls.Add(this.txt_kmgereden);
            this.Controls.Add(this.txt_dagengehuurd);
            this.Controls.Add(this.lbl_litersgetankt);
            this.Controls.Add(this.lbl_kmgereden);
            this.Controls.Add(this.lbl_dagen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dagen;
        private System.Windows.Forms.Label lbl_kmgereden;
        private System.Windows.Forms.Label lbl_litersgetankt;
        private System.Windows.Forms.TextBox txt_dagengehuurd;
        private System.Windows.Forms.TextBox txt_kmgereden;
        private System.Windows.Forms.TextBox txt_litergetankt;
        private System.Windows.Forms.CheckBox check_tankenhuurder;
        private System.Windows.Forms.Button btn_berekenen;
        private System.Windows.Forms.Label lbl_uurbedrag;
        private System.Windows.Forms.Label lbl_huurbedragOutput;
        private System.Windows.Forms.Label lbl_euro;
    }
}


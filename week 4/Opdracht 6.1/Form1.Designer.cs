﻿namespace Opdracht_6._1
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
            this.lbl_startBedrag = new System.Windows.Forms.Label();
            this.lbl_eindKapitaal = new System.Windows.Forms.Label();
            this.lbl_euro = new System.Windows.Forms.Label();
            this.lbl_eindKapitaalOutput = new System.Windows.Forms.Label();
            this.txt_startBedrag = new System.Windows.Forms.TextBox();
            this.btn_berekenen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_startBedrag
            // 
            this.lbl_startBedrag.AutoSize = true;
            this.lbl_startBedrag.Location = new System.Drawing.Point(22, 25);
            this.lbl_startBedrag.Name = "lbl_startBedrag";
            this.lbl_startBedrag.Size = new System.Drawing.Size(68, 13);
            this.lbl_startBedrag.TabIndex = 0;
            this.lbl_startBedrag.Text = "Startbedrag: ";
            // 
            // lbl_eindKapitaal
            // 
            this.lbl_eindKapitaal.AutoSize = true;
            this.lbl_eindKapitaal.Location = new System.Drawing.Point(22, 193);
            this.lbl_eindKapitaal.Name = "lbl_eindKapitaal";
            this.lbl_eindKapitaal.Size = new System.Drawing.Size(68, 13);
            this.lbl_eindKapitaal.TabIndex = 1;
            this.lbl_eindKapitaal.Text = "Eindkapitaal:";
            // 
            // lbl_euro
            // 
            this.lbl_euro.AutoSize = true;
            this.lbl_euro.Location = new System.Drawing.Point(160, 193);
            this.lbl_euro.Name = "lbl_euro";
            this.lbl_euro.Size = new System.Drawing.Size(13, 13);
            this.lbl_euro.TabIndex = 2;
            this.lbl_euro.Text = "€";
            // 
            // lbl_eindKapitaalOutput
            // 
            this.lbl_eindKapitaalOutput.AutoSize = true;
            this.lbl_eindKapitaalOutput.Location = new System.Drawing.Point(179, 193);
            this.lbl_eindKapitaalOutput.Name = "lbl_eindKapitaalOutput";
            this.lbl_eindKapitaalOutput.Size = new System.Drawing.Size(10, 13);
            this.lbl_eindKapitaalOutput.TabIndex = 3;
            this.lbl_eindKapitaalOutput.Text = "-";
            // 
            // txt_startBedrag
            // 
            this.txt_startBedrag.Location = new System.Drawing.Point(163, 22);
            this.txt_startBedrag.Name = "txt_startBedrag";
            this.txt_startBedrag.Size = new System.Drawing.Size(100, 20);
            this.txt_startBedrag.TabIndex = 4;
            // 
            // btn_berekenen
            // 
            this.btn_berekenen.Location = new System.Drawing.Point(25, 100);
            this.btn_berekenen.Name = "btn_berekenen";
            this.btn_berekenen.Size = new System.Drawing.Size(238, 23);
            this.btn_berekenen.TabIndex = 5;
            this.btn_berekenen.Text = "Bereken bedrag na 5 jaar met 5% rente";
            this.btn_berekenen.UseVisualStyleBackColor = true;
            this.btn_berekenen.Click += new System.EventHandler(this.btn_berekenen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_berekenen);
            this.Controls.Add(this.txt_startBedrag);
            this.Controls.Add(this.lbl_eindKapitaalOutput);
            this.Controls.Add(this.lbl_euro);
            this.Controls.Add(this.lbl_eindKapitaal);
            this.Controls.Add(this.lbl_startBedrag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_startBedrag;
        private System.Windows.Forms.Label lbl_eindKapitaal;
        private System.Windows.Forms.Label lbl_euro;
        private System.Windows.Forms.Label lbl_eindKapitaalOutput;
        private System.Windows.Forms.TextBox txt_startBedrag;
        private System.Windows.Forms.Button btn_berekenen;
    }
}


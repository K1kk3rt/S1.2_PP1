namespace Opdracht_9
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
            this.lbl_Sportsoort = new System.Windows.Forms.Label();
            this.radbtn_Voetbal = new System.Windows.Forms.RadioButton();
            this.radbtn_Handbal = new System.Windows.Forms.RadioButton();
            this.lbl_leeftijd = new System.Windows.Forms.Label();
            this.txt_leeftijd = new System.Windows.Forms.TextBox();
            this.txt_lidmaatschap = new System.Windows.Forms.TextBox();
            this.lbl_lidmaatschap = new System.Windows.Forms.Label();
            this.btn_berekenContributie = new System.Windows.Forms.Button();
            this.lbl_teBetalenContributie = new System.Windows.Forms.Label();
            this.lbl_ContributieOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Sportsoort
            // 
            this.lbl_Sportsoort.AutoSize = true;
            this.lbl_Sportsoort.Location = new System.Drawing.Point(34, 32);
            this.lbl_Sportsoort.Name = "lbl_Sportsoort";
            this.lbl_Sportsoort.Size = new System.Drawing.Size(55, 13);
            this.lbl_Sportsoort.TabIndex = 0;
            this.lbl_Sportsoort.Text = "Sportsoort";
            // 
            // radbtn_Voetbal
            // 
            this.radbtn_Voetbal.AutoSize = true;
            this.radbtn_Voetbal.Location = new System.Drawing.Point(120, 32);
            this.radbtn_Voetbal.Name = "radbtn_Voetbal";
            this.radbtn_Voetbal.Size = new System.Drawing.Size(61, 17);
            this.radbtn_Voetbal.TabIndex = 1;
            this.radbtn_Voetbal.TabStop = true;
            this.radbtn_Voetbal.Text = "Voetbal";
            this.radbtn_Voetbal.UseVisualStyleBackColor = true;
            // 
            // radbtn_Handbal
            // 
            this.radbtn_Handbal.AutoSize = true;
            this.radbtn_Handbal.Location = new System.Drawing.Point(120, 64);
            this.radbtn_Handbal.Name = "radbtn_Handbal";
            this.radbtn_Handbal.Size = new System.Drawing.Size(65, 17);
            this.radbtn_Handbal.TabIndex = 2;
            this.radbtn_Handbal.TabStop = true;
            this.radbtn_Handbal.Text = "Handbal";
            this.radbtn_Handbal.UseVisualStyleBackColor = true;
            // 
            // lbl_leeftijd
            // 
            this.lbl_leeftijd.AutoSize = true;
            this.lbl_leeftijd.Location = new System.Drawing.Point(34, 103);
            this.lbl_leeftijd.Name = "lbl_leeftijd";
            this.lbl_leeftijd.Size = new System.Drawing.Size(41, 13);
            this.lbl_leeftijd.TabIndex = 3;
            this.lbl_leeftijd.Text = "Leeftijd";
            // 
            // txt_leeftijd
            // 
            this.txt_leeftijd.Location = new System.Drawing.Point(120, 103);
            this.txt_leeftijd.Name = "txt_leeftijd";
            this.txt_leeftijd.Size = new System.Drawing.Size(100, 20);
            this.txt_leeftijd.TabIndex = 4;
            // 
            // txt_lidmaatschap
            // 
            this.txt_lidmaatschap.Location = new System.Drawing.Point(120, 145);
            this.txt_lidmaatschap.Name = "txt_lidmaatschap";
            this.txt_lidmaatschap.Size = new System.Drawing.Size(100, 20);
            this.txt_lidmaatschap.TabIndex = 5;
            // 
            // lbl_lidmaatschap
            // 
            this.lbl_lidmaatschap.AutoSize = true;
            this.lbl_lidmaatschap.Location = new System.Drawing.Point(34, 152);
            this.lbl_lidmaatschap.Name = "lbl_lidmaatschap";
            this.lbl_lidmaatschap.Size = new System.Drawing.Size(73, 13);
            this.lbl_lidmaatschap.TabIndex = 6;
            this.lbl_lidmaatschap.Text = "Lidmaatschap";
            // 
            // btn_berekenContributie
            // 
            this.btn_berekenContributie.Location = new System.Drawing.Point(37, 187);
            this.btn_berekenContributie.Name = "btn_berekenContributie";
            this.btn_berekenContributie.Size = new System.Drawing.Size(183, 23);
            this.btn_berekenContributie.TabIndex = 7;
            this.btn_berekenContributie.Text = "Bereken Contributie";
            this.btn_berekenContributie.UseVisualStyleBackColor = true;
            this.btn_berekenContributie.Click += new System.EventHandler(this.btn_berekenContributie_Click);
            // 
            // lbl_teBetalenContributie
            // 
            this.lbl_teBetalenContributie.AutoSize = true;
            this.lbl_teBetalenContributie.Location = new System.Drawing.Point(34, 239);
            this.lbl_teBetalenContributie.Name = "lbl_teBetalenContributie";
            this.lbl_teBetalenContributie.Size = new System.Drawing.Size(116, 13);
            this.lbl_teBetalenContributie.TabIndex = 8;
            this.lbl_teBetalenContributie.Text = "Te betalen contributie: ";
            // 
            // lbl_ContributieOutput
            // 
            this.lbl_ContributieOutput.AutoSize = true;
            this.lbl_ContributieOutput.Location = new System.Drawing.Point(210, 239);
            this.lbl_ContributieOutput.Name = "lbl_ContributieOutput";
            this.lbl_ContributieOutput.Size = new System.Drawing.Size(10, 13);
            this.lbl_ContributieOutput.TabIndex = 9;
            this.lbl_ContributieOutput.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "€";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ContributieOutput);
            this.Controls.Add(this.lbl_teBetalenContributie);
            this.Controls.Add(this.btn_berekenContributie);
            this.Controls.Add(this.lbl_lidmaatschap);
            this.Controls.Add(this.txt_lidmaatschap);
            this.Controls.Add(this.txt_leeftijd);
            this.Controls.Add(this.lbl_leeftijd);
            this.Controls.Add(this.radbtn_Handbal);
            this.Controls.Add(this.radbtn_Voetbal);
            this.Controls.Add(this.lbl_Sportsoort);
            this.Name = "Form1";
            this.Text = "€";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Sportsoort;
        private System.Windows.Forms.RadioButton radbtn_Voetbal;
        private System.Windows.Forms.RadioButton radbtn_Handbal;
        private System.Windows.Forms.Label lbl_leeftijd;
        private System.Windows.Forms.TextBox txt_leeftijd;
        private System.Windows.Forms.TextBox txt_lidmaatschap;
        private System.Windows.Forms.Label lbl_lidmaatschap;
        private System.Windows.Forms.Button btn_berekenContributie;
        private System.Windows.Forms.Label lbl_teBetalenContributie;
        private System.Windows.Forms.Label lbl_ContributieOutput;
        private System.Windows.Forms.Label label1;
    }
}


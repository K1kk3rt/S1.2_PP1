namespace Opdracht_5
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
            this.lbl_Getal1 = new System.Windows.Forms.Label();
            this.lbl_Getal2 = new System.Windows.Forms.Label();
            this.lbl_Getal3 = new System.Windows.Forms.Label();
            this.btn_BerekenGemiddelde = new System.Windows.Forms.Button();
            this.lbl_Gem = new System.Windows.Forms.Label();
            this.lbl_Gemiddelde = new System.Windows.Forms.Label();
            this.txt_Getal1 = new System.Windows.Forms.TextBox();
            this.txt_Getal2 = new System.Windows.Forms.TextBox();
            this.txt_Getal3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Getal1
            // 
            this.lbl_Getal1.AutoSize = true;
            this.lbl_Getal1.Location = new System.Drawing.Point(54, 30);
            this.lbl_Getal1.Name = "lbl_Getal1";
            this.lbl_Getal1.Size = new System.Drawing.Size(65, 13);
            this.lbl_Getal1.TabIndex = 0;
            this.lbl_Getal1.Text = "Geef getal 1";
            // 
            // lbl_Getal2
            // 
            this.lbl_Getal2.AutoSize = true;
            this.lbl_Getal2.Location = new System.Drawing.Point(54, 61);
            this.lbl_Getal2.Name = "lbl_Getal2";
            this.lbl_Getal2.Size = new System.Drawing.Size(65, 13);
            this.lbl_Getal2.TabIndex = 1;
            this.lbl_Getal2.Text = "Geef getal 2";
            // 
            // lbl_Getal3
            // 
            this.lbl_Getal3.AutoSize = true;
            this.lbl_Getal3.Location = new System.Drawing.Point(54, 93);
            this.lbl_Getal3.Name = "lbl_Getal3";
            this.lbl_Getal3.Size = new System.Drawing.Size(65, 13);
            this.lbl_Getal3.TabIndex = 2;
            this.lbl_Getal3.Text = "Geef getal 3";
            // 
            // btn_BerekenGemiddelde
            // 
            this.btn_BerekenGemiddelde.Location = new System.Drawing.Point(33, 132);
            this.btn_BerekenGemiddelde.Name = "btn_BerekenGemiddelde";
            this.btn_BerekenGemiddelde.Size = new System.Drawing.Size(206, 23);
            this.btn_BerekenGemiddelde.TabIndex = 3;
            this.btn_BerekenGemiddelde.Text = "Bereken Gemiddelde";
            this.btn_BerekenGemiddelde.UseVisualStyleBackColor = true;
            this.btn_BerekenGemiddelde.Click += new System.EventHandler(this.btn_BerekenGemiddelde_Click);
            // 
            // lbl_Gem
            // 
            this.lbl_Gem.AutoSize = true;
            this.lbl_Gem.Location = new System.Drawing.Point(50, 191);
            this.lbl_Gem.Name = "lbl_Gem";
            this.lbl_Gem.Size = new System.Drawing.Size(69, 13);
            this.lbl_Gem.TabIndex = 4;
            this.lbl_Gem.Text = "Gemiddelde: ";
            // 
            // lbl_Gemiddelde
            // 
            this.lbl_Gemiddelde.AutoSize = true;
            this.lbl_Gemiddelde.Location = new System.Drawing.Point(170, 191);
            this.lbl_Gemiddelde.Name = "lbl_Gemiddelde";
            this.lbl_Gemiddelde.Size = new System.Drawing.Size(0, 13);
            this.lbl_Gemiddelde.TabIndex = 5;
            // 
            // txt_Getal1
            // 
            this.txt_Getal1.Location = new System.Drawing.Point(172, 23);
            this.txt_Getal1.Name = "txt_Getal1";
            this.txt_Getal1.Size = new System.Drawing.Size(100, 20);
            this.txt_Getal1.TabIndex = 6;
            // 
            // txt_Getal2
            // 
            this.txt_Getal2.Location = new System.Drawing.Point(172, 54);
            this.txt_Getal2.Name = "txt_Getal2";
            this.txt_Getal2.Size = new System.Drawing.Size(100, 20);
            this.txt_Getal2.TabIndex = 7;
            // 
            // txt_Getal3
            // 
            this.txt_Getal3.Location = new System.Drawing.Point(172, 86);
            this.txt_Getal3.Name = "txt_Getal3";
            this.txt_Getal3.Size = new System.Drawing.Size(100, 20);
            this.txt_Getal3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_Getal3);
            this.Controls.Add(this.txt_Getal2);
            this.Controls.Add(this.txt_Getal1);
            this.Controls.Add(this.lbl_Gemiddelde);
            this.Controls.Add(this.lbl_Gem);
            this.Controls.Add(this.btn_BerekenGemiddelde);
            this.Controls.Add(this.lbl_Getal3);
            this.Controls.Add(this.lbl_Getal2);
            this.Controls.Add(this.lbl_Getal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Getal1;
        private System.Windows.Forms.Label lbl_Getal2;
        private System.Windows.Forms.Label lbl_Getal3;
        private System.Windows.Forms.Button btn_BerekenGemiddelde;
        private System.Windows.Forms.Label lbl_Gem;
        private System.Windows.Forms.Label lbl_Gemiddelde;
        private System.Windows.Forms.TextBox txt_Getal1;
        private System.Windows.Forms.TextBox txt_Getal2;
        private System.Windows.Forms.TextBox txt_Getal3;
    }
}


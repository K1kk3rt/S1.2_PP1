namespace Opgave5
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
            this.lbl_schaatsafstanden = new System.Windows.Forms.Label();
            this.rbtn_500m = new System.Windows.Forms.RadioButton();
            this.rbtn_1000m = new System.Windows.Forms.RadioButton();
            this.rbtn_1500m = new System.Windows.Forms.RadioButton();
            this.rbtn_5000m = new System.Windows.Forms.RadioButton();
            this.lbl_tijd = new System.Windows.Forms.Label();
            this.txt_minuten = new System.Windows.Forms.TextBox();
            this.txt_seconden = new System.Windows.Forms.TextBox();
            this.txt_hondersten = new System.Windows.Forms.TextBox();
            this.btn_bereken = new System.Windows.Forms.Button();
            this.lbl_snelheidKmu = new System.Windows.Forms.Label();
            this.lbl_snelheidMu = new System.Windows.Forms.Label();
            this.lbl_snelheidKmOutput = new System.Windows.Forms.Label();
            this.lbl_snelheidMOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_schaatsafstanden
            // 
            this.lbl_schaatsafstanden.AutoSize = true;
            this.lbl_schaatsafstanden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_schaatsafstanden.Location = new System.Drawing.Point(27, 22);
            this.lbl_schaatsafstanden.Name = "lbl_schaatsafstanden";
            this.lbl_schaatsafstanden.Size = new System.Drawing.Size(126, 18);
            this.lbl_schaatsafstanden.TabIndex = 0;
            this.lbl_schaatsafstanden.Text = "Schaatsafstanden";
            // 
            // rbtn_500m
            // 
            this.rbtn_500m.AutoSize = true;
            this.rbtn_500m.Location = new System.Drawing.Point(30, 66);
            this.rbtn_500m.Name = "rbtn_500m";
            this.rbtn_500m.Size = new System.Drawing.Size(51, 17);
            this.rbtn_500m.TabIndex = 1;
            this.rbtn_500m.TabStop = true;
            this.rbtn_500m.Text = "500m";
            this.rbtn_500m.UseVisualStyleBackColor = true;
            // 
            // rbtn_1000m
            // 
            this.rbtn_1000m.AutoSize = true;
            this.rbtn_1000m.Location = new System.Drawing.Point(30, 98);
            this.rbtn_1000m.Name = "rbtn_1000m";
            this.rbtn_1000m.Size = new System.Drawing.Size(57, 17);
            this.rbtn_1000m.TabIndex = 2;
            this.rbtn_1000m.TabStop = true;
            this.rbtn_1000m.Text = "1000m";
            this.rbtn_1000m.UseVisualStyleBackColor = true;
            // 
            // rbtn_1500m
            // 
            this.rbtn_1500m.AutoSize = true;
            this.rbtn_1500m.Location = new System.Drawing.Point(30, 133);
            this.rbtn_1500m.Name = "rbtn_1500m";
            this.rbtn_1500m.Size = new System.Drawing.Size(57, 17);
            this.rbtn_1500m.TabIndex = 3;
            this.rbtn_1500m.TabStop = true;
            this.rbtn_1500m.Text = "1500m";
            this.rbtn_1500m.UseVisualStyleBackColor = true;
            // 
            // rbtn_5000m
            // 
            this.rbtn_5000m.AutoSize = true;
            this.rbtn_5000m.Location = new System.Drawing.Point(30, 165);
            this.rbtn_5000m.Name = "rbtn_5000m";
            this.rbtn_5000m.Size = new System.Drawing.Size(57, 17);
            this.rbtn_5000m.TabIndex = 4;
            this.rbtn_5000m.TabStop = true;
            this.rbtn_5000m.Text = "5000m";
            this.rbtn_5000m.UseVisualStyleBackColor = true;
            // 
            // lbl_tijd
            // 
            this.lbl_tijd.AutoSize = true;
            this.lbl_tijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tijd.Location = new System.Drawing.Point(164, 163);
            this.lbl_tijd.Name = "lbl_tijd";
            this.lbl_tijd.Size = new System.Drawing.Size(111, 18);
            this.lbl_tijd.TabIndex = 5;
            this.lbl_tijd.Text = "Tijd (hh:mm:ss)";
            this.lbl_tijd.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_minuten
            // 
            this.txt_minuten.Location = new System.Drawing.Point(301, 165);
            this.txt_minuten.Name = "txt_minuten";
            this.txt_minuten.Size = new System.Drawing.Size(35, 20);
            this.txt_minuten.TabIndex = 6;
            this.txt_minuten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_seconden
            // 
            this.txt_seconden.Location = new System.Drawing.Point(342, 165);
            this.txt_seconden.Name = "txt_seconden";
            this.txt_seconden.Size = new System.Drawing.Size(35, 20);
            this.txt_seconden.TabIndex = 7;
            // 
            // txt_hondersten
            // 
            this.txt_hondersten.Location = new System.Drawing.Point(383, 165);
            this.txt_hondersten.Name = "txt_hondersten";
            this.txt_hondersten.Size = new System.Drawing.Size(35, 20);
            this.txt_hondersten.TabIndex = 8;
            // 
            // btn_bereken
            // 
            this.btn_bereken.Location = new System.Drawing.Point(30, 215);
            this.btn_bereken.Name = "btn_bereken";
            this.btn_bereken.Size = new System.Drawing.Size(388, 29);
            this.btn_bereken.TabIndex = 9;
            this.btn_bereken.Text = "Berekenen";
            this.btn_bereken.UseVisualStyleBackColor = true;
            this.btn_bereken.Click += new System.EventHandler(this.btn_bereken_Click);
            // 
            // lbl_snelheidKmu
            // 
            this.lbl_snelheidKmu.AutoSize = true;
            this.lbl_snelheidKmu.Location = new System.Drawing.Point(30, 266);
            this.lbl_snelheidKmu.Name = "lbl_snelheidKmu";
            this.lbl_snelheidKmu.Size = new System.Drawing.Size(148, 13);
            this.lbl_snelheidKmu.TabIndex = 10;
            this.lbl_snelheidKmu.Text = "Gemiddelde snelheid (km/uur)";
            this.lbl_snelheidKmu.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_snelheidMu
            // 
            this.lbl_snelheidMu.AutoSize = true;
            this.lbl_snelheidMu.Location = new System.Drawing.Point(30, 290);
            this.lbl_snelheidMu.Name = "lbl_snelheidMu";
            this.lbl_snelheidMu.Size = new System.Drawing.Size(157, 13);
            this.lbl_snelheidMu.TabIndex = 11;
            this.lbl_snelheidMu.Text = "Gemiddelde snelheid (miles/uur)";
            // 
            // lbl_snelheidKmOutput
            // 
            this.lbl_snelheidKmOutput.AutoSize = true;
            this.lbl_snelheidKmOutput.Location = new System.Drawing.Point(239, 266);
            this.lbl_snelheidKmOutput.Name = "lbl_snelheidKmOutput";
            this.lbl_snelheidKmOutput.Size = new System.Drawing.Size(10, 13);
            this.lbl_snelheidKmOutput.TabIndex = 12;
            this.lbl_snelheidKmOutput.Text = "-";
            // 
            // lbl_snelheidMOutput
            // 
            this.lbl_snelheidMOutput.AutoSize = true;
            this.lbl_snelheidMOutput.Location = new System.Drawing.Point(239, 290);
            this.lbl_snelheidMOutput.Name = "lbl_snelheidMOutput";
            this.lbl_snelheidMOutput.Size = new System.Drawing.Size(10, 13);
            this.lbl_snelheidMOutput.TabIndex = 13;
            this.lbl_snelheidMOutput.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 338);
            this.Controls.Add(this.lbl_snelheidMOutput);
            this.Controls.Add(this.lbl_snelheidKmOutput);
            this.Controls.Add(this.lbl_snelheidMu);
            this.Controls.Add(this.lbl_snelheidKmu);
            this.Controls.Add(this.btn_bereken);
            this.Controls.Add(this.txt_hondersten);
            this.Controls.Add(this.txt_seconden);
            this.Controls.Add(this.txt_minuten);
            this.Controls.Add(this.lbl_tijd);
            this.Controls.Add(this.rbtn_5000m);
            this.Controls.Add(this.rbtn_1500m);
            this.Controls.Add(this.rbtn_1000m);
            this.Controls.Add(this.rbtn_500m);
            this.Controls.Add(this.lbl_schaatsafstanden);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_schaatsafstanden;
        private System.Windows.Forms.RadioButton rbtn_500m;
        private System.Windows.Forms.RadioButton rbtn_1000m;
        private System.Windows.Forms.RadioButton rbtn_1500m;
        private System.Windows.Forms.RadioButton rbtn_5000m;
        private System.Windows.Forms.Label lbl_tijd;
        private System.Windows.Forms.TextBox txt_minuten;
        private System.Windows.Forms.TextBox txt_seconden;
        private System.Windows.Forms.TextBox txt_hondersten;
        private System.Windows.Forms.Button btn_bereken;
        private System.Windows.Forms.Label lbl_snelheidKmu;
        private System.Windows.Forms.Label lbl_snelheidMu;
        private System.Windows.Forms.Label lbl_snelheidKmOutput;
        private System.Windows.Forms.Label lbl_snelheidMOutput;
    }
}


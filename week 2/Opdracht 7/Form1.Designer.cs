namespace Opdracht_7
{
    partial class form1
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
            this.lbl_beginkm = new System.Windows.Forms.Label();
            this.lbl_eindkm = new System.Windows.Forms.Label();
            this.lbl_prijsperkm = new System.Windows.Forms.Label();
            this.txt_beginkm = new System.Windows.Forms.TextBox();
            this.txt_eindkm = new System.Windows.Forms.TextBox();
            this.txt_prijsperkm = new System.Windows.Forms.TextBox();
            this.btn_wissen = new System.Windows.Forms.Button();
            this.btn_berekenen = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_prijsexbtw = new System.Windows.Forms.Label();
            this.lbl_BTW = new System.Windows.Forms.Label();
            this.lbl_prijsinclbtw = new System.Windows.Forms.Label();
            this.lbl_toonprijsexbtw = new System.Windows.Forms.Label();
            this.lbl_toonbtw = new System.Windows.Forms.Label();
            this.lbl_toonprijsinclbtw = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_beginkm
            // 
            this.lbl_beginkm.AutoSize = true;
            this.lbl_beginkm.Location = new System.Drawing.Point(40, 26);
            this.lbl_beginkm.Name = "lbl_beginkm";
            this.lbl_beginkm.Size = new System.Drawing.Size(53, 13);
            this.lbl_beginkm.TabIndex = 0;
            this.lbl_beginkm.Text = "Begin KM";
            // 
            // lbl_eindkm
            // 
            this.lbl_eindkm.AutoSize = true;
            this.lbl_eindkm.Location = new System.Drawing.Point(43, 57);
            this.lbl_eindkm.Name = "lbl_eindkm";
            this.lbl_eindkm.Size = new System.Drawing.Size(47, 13);
            this.lbl_eindkm.TabIndex = 1;
            this.lbl_eindkm.Text = "Eind KM";
            // 
            // lbl_prijsperkm
            // 
            this.lbl_prijsperkm.AutoSize = true;
            this.lbl_prijsperkm.Location = new System.Drawing.Point(46, 90);
            this.lbl_prijsperkm.Name = "lbl_prijsperkm";
            this.lbl_prijsperkm.Size = new System.Drawing.Size(63, 13);
            this.lbl_prijsperkm.TabIndex = 2;
            this.lbl_prijsperkm.Text = "Prijs per KM";
            // 
            // txt_beginkm
            // 
            this.txt_beginkm.Location = new System.Drawing.Point(139, 23);
            this.txt_beginkm.Name = "txt_beginkm";
            this.txt_beginkm.Size = new System.Drawing.Size(100, 20);
            this.txt_beginkm.TabIndex = 3;
            // 
            // txt_eindkm
            // 
            this.txt_eindkm.Location = new System.Drawing.Point(139, 54);
            this.txt_eindkm.Name = "txt_eindkm";
            this.txt_eindkm.Size = new System.Drawing.Size(100, 20);
            this.txt_eindkm.TabIndex = 4;
            // 
            // txt_prijsperkm
            // 
            this.txt_prijsperkm.Location = new System.Drawing.Point(139, 87);
            this.txt_prijsperkm.Name = "txt_prijsperkm";
            this.txt_prijsperkm.Size = new System.Drawing.Size(100, 20);
            this.txt_prijsperkm.TabIndex = 5;
            // 
            // btn_wissen
            // 
            this.btn_wissen.Location = new System.Drawing.Point(389, 26);
            this.btn_wissen.Name = "btn_wissen";
            this.btn_wissen.Size = new System.Drawing.Size(137, 23);
            this.btn_wissen.TabIndex = 6;
            this.btn_wissen.Text = "Wissen";
            this.btn_wissen.UseVisualStyleBackColor = true;
            this.btn_wissen.Click += new System.EventHandler(this.btn_wissen_Click);
            // 
            // btn_berekenen
            // 
            this.btn_berekenen.Location = new System.Drawing.Point(389, 69);
            this.btn_berekenen.Name = "btn_berekenen";
            this.btn_berekenen.Size = new System.Drawing.Size(137, 23);
            this.btn_berekenen.TabIndex = 7;
            this.btn_berekenen.Text = "Bedragen berekenen";
            this.btn_berekenen.UseVisualStyleBackColor = true;
            this.btn_berekenen.Click += new System.EventHandler(this.btn_berekenen_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_prijsexbtw, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_BTW, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_prijsinclbtw, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_toonprijsexbtw, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_toonbtw, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_toonprijsinclbtw, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(49, 135);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 97);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lbl_prijsexbtw
            // 
            this.lbl_prijsexbtw.AutoSize = true;
            this.lbl_prijsexbtw.Location = new System.Drawing.Point(3, 0);
            this.lbl_prijsexbtw.Name = "lbl_prijsexbtw";
            this.lbl_prijsexbtw.Size = new System.Drawing.Size(79, 13);
            this.lbl_prijsexbtw.TabIndex = 0;
            this.lbl_prijsexbtw.Text = "Prijs excl. BTW";
            this.lbl_prijsexbtw.Click += new System.EventHandler(this.lbl_prijsexbtw_Click);
            // 
            // lbl_BTW
            // 
            this.lbl_BTW.AutoSize = true;
            this.lbl_BTW.Location = new System.Drawing.Point(162, 0);
            this.lbl_BTW.Name = "lbl_BTW";
            this.lbl_BTW.Size = new System.Drawing.Size(32, 13);
            this.lbl_BTW.TabIndex = 1;
            this.lbl_BTW.Text = "BTW";
            // 
            // lbl_prijsinclbtw
            // 
            this.lbl_prijsinclbtw.AutoSize = true;
            this.lbl_prijsinclbtw.Location = new System.Drawing.Point(321, 0);
            this.lbl_prijsinclbtw.Name = "lbl_prijsinclbtw";
            this.lbl_prijsinclbtw.Size = new System.Drawing.Size(74, 13);
            this.lbl_prijsinclbtw.TabIndex = 2;
            this.lbl_prijsinclbtw.Text = "Prijs inc. BTW";
            // 
            // lbl_toonprijsexbtw
            // 
            this.lbl_toonprijsexbtw.AutoSize = true;
            this.lbl_toonprijsexbtw.Location = new System.Drawing.Point(3, 48);
            this.lbl_toonprijsexbtw.Name = "lbl_toonprijsexbtw";
            this.lbl_toonprijsexbtw.Size = new System.Drawing.Size(0, 13);
            this.lbl_toonprijsexbtw.TabIndex = 3;
            // 
            // lbl_toonbtw
            // 
            this.lbl_toonbtw.AutoSize = true;
            this.lbl_toonbtw.Location = new System.Drawing.Point(162, 48);
            this.lbl_toonbtw.Name = "lbl_toonbtw";
            this.lbl_toonbtw.Size = new System.Drawing.Size(0, 13);
            this.lbl_toonbtw.TabIndex = 4;
            // 
            // lbl_toonprijsinclbtw
            // 
            this.lbl_toonprijsinclbtw.AutoSize = true;
            this.lbl_toonprijsinclbtw.Location = new System.Drawing.Point(321, 48);
            this.lbl_toonprijsinclbtw.Name = "lbl_toonprijsinclbtw";
            this.lbl_toonprijsinclbtw.Size = new System.Drawing.Size(0, 13);
            this.lbl_toonprijsinclbtw.TabIndex = 5;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 244);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_berekenen);
            this.Controls.Add(this.btn_wissen);
            this.Controls.Add(this.txt_prijsperkm);
            this.Controls.Add(this.txt_eindkm);
            this.Controls.Add(this.txt_beginkm);
            this.Controls.Add(this.lbl_prijsperkm);
            this.Controls.Add(this.lbl_eindkm);
            this.Controls.Add(this.lbl_beginkm);
            this.Name = "form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.lbl_beginkm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_beginkm;
        private System.Windows.Forms.Label lbl_eindkm;
        private System.Windows.Forms.Label lbl_prijsperkm;
        private System.Windows.Forms.TextBox txt_beginkm;
        private System.Windows.Forms.TextBox txt_eindkm;
        private System.Windows.Forms.TextBox txt_prijsperkm;
        private System.Windows.Forms.Button btn_wissen;
        private System.Windows.Forms.Button btn_berekenen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_prijsexbtw;
        private System.Windows.Forms.Label lbl_BTW;
        private System.Windows.Forms.Label lbl_prijsinclbtw;
        private System.Windows.Forms.Label lbl_toonprijsexbtw;
        private System.Windows.Forms.Label lbl_toonbtw;
        private System.Windows.Forms.Label lbl_toonprijsinclbtw;
    }
}


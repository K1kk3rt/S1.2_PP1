namespace Opdracht_8
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
            this.lbl_getaln = new System.Windows.Forms.Label();
            this.lbl_som = new System.Windows.Forms.Label();
            this.lbl_formule = new System.Windows.Forms.Label();
            this.lbl_textOutput = new System.Windows.Forms.Label();
            this.lbl_formuleOutput = new System.Windows.Forms.Label();
            this.lbl_somOutput = new System.Windows.Forms.Label();
            this.btn_vergelijk = new System.Windows.Forms.Button();
            this.txt_getaln = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_getaln
            // 
            this.lbl_getaln.AutoSize = true;
            this.lbl_getaln.Location = new System.Drawing.Point(13, 24);
            this.lbl_getaln.Name = "lbl_getaln";
            this.lbl_getaln.Size = new System.Drawing.Size(98, 13);
            this.lbl_getaln.TabIndex = 0;
            this.lbl_getaln.Text = "Geef een getal (n): ";
            // 
            // lbl_som
            // 
            this.lbl_som.AutoSize = true;
            this.lbl_som.Location = new System.Drawing.Point(13, 129);
            this.lbl_som.Name = "lbl_som";
            this.lbl_som.Size = new System.Drawing.Size(122, 13);
            this.lbl_som.TabIndex = 1;
            this.lbl_som.Text = "som = 0 + 1 + 2 + ... + n ";
            // 
            // lbl_formule
            // 
            this.lbl_formule.AutoSize = true;
            this.lbl_formule.Location = new System.Drawing.Point(13, 171);
            this.lbl_formule.Name = "lbl_formule";
            this.lbl_formule.Size = new System.Drawing.Size(89, 13);
            this.lbl_formule.TabIndex = 2;
            this.lbl_formule.Text = "som = n * (n+1)/2";
            // 
            // lbl_textOutput
            // 
            this.lbl_textOutput.AutoSize = true;
            this.lbl_textOutput.Location = new System.Drawing.Point(13, 210);
            this.lbl_textOutput.Name = "lbl_textOutput";
            this.lbl_textOutput.Size = new System.Drawing.Size(10, 13);
            this.lbl_textOutput.TabIndex = 3;
            this.lbl_textOutput.Text = "-";
            // 
            // lbl_formuleOutput
            // 
            this.lbl_formuleOutput.AutoSize = true;
            this.lbl_formuleOutput.Location = new System.Drawing.Point(222, 171);
            this.lbl_formuleOutput.Name = "lbl_formuleOutput";
            this.lbl_formuleOutput.Size = new System.Drawing.Size(10, 13);
            this.lbl_formuleOutput.TabIndex = 4;
            this.lbl_formuleOutput.Text = "-";
            // 
            // lbl_somOutput
            // 
            this.lbl_somOutput.AutoSize = true;
            this.lbl_somOutput.Location = new System.Drawing.Point(222, 129);
            this.lbl_somOutput.Name = "lbl_somOutput";
            this.lbl_somOutput.Size = new System.Drawing.Size(10, 13);
            this.lbl_somOutput.TabIndex = 5;
            this.lbl_somOutput.Text = "-";
            // 
            // btn_vergelijk
            // 
            this.btn_vergelijk.Location = new System.Drawing.Point(16, 75);
            this.btn_vergelijk.Name = "btn_vergelijk";
            this.btn_vergelijk.Size = new System.Drawing.Size(216, 23);
            this.btn_vergelijk.TabIndex = 6;
            this.btn_vergelijk.Text = "Vergelijk";
            this.btn_vergelijk.UseVisualStyleBackColor = true;
            this.btn_vergelijk.Click += new System.EventHandler(this.btn_vergelijk_Click);
            // 
            // txt_getaln
            // 
            this.txt_getaln.Location = new System.Drawing.Point(132, 24);
            this.txt_getaln.Name = "txt_getaln";
            this.txt_getaln.Size = new System.Drawing.Size(100, 20);
            this.txt_getaln.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_getaln);
            this.Controls.Add(this.btn_vergelijk);
            this.Controls.Add(this.lbl_somOutput);
            this.Controls.Add(this.lbl_formuleOutput);
            this.Controls.Add(this.lbl_textOutput);
            this.Controls.Add(this.lbl_formule);
            this.Controls.Add(this.lbl_som);
            this.Controls.Add(this.lbl_getaln);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_getaln;
        private System.Windows.Forms.Label lbl_som;
        private System.Windows.Forms.Label lbl_formule;
        private System.Windows.Forms.Label lbl_textOutput;
        private System.Windows.Forms.Label lbl_formuleOutput;
        private System.Windows.Forms.Label lbl_somOutput;
        private System.Windows.Forms.Button btn_vergelijk;
        private System.Windows.Forms.TextBox txt_getaln;
    }
}


namespace Opdracht_7
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
            this.lbl_zijde = new System.Windows.Forms.Label();
            this.txt_zijde = new System.Windows.Forms.TextBox();
            this.btn_maakVierkant = new System.Windows.Forms.Button();
            this.lbl_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_zijde
            // 
            this.lbl_zijde.AutoSize = true;
            this.lbl_zijde.Location = new System.Drawing.Point(13, 13);
            this.lbl_zijde.Name = "lbl_zijde";
            this.lbl_zijde.Size = new System.Drawing.Size(33, 13);
            this.lbl_zijde.TabIndex = 0;
            this.lbl_zijde.Text = "Zijde:";
            // 
            // txt_zijde
            // 
            this.txt_zijde.Location = new System.Drawing.Point(106, 13);
            this.txt_zijde.Name = "txt_zijde";
            this.txt_zijde.Size = new System.Drawing.Size(100, 20);
            this.txt_zijde.TabIndex = 1;
            // 
            // btn_maakVierkant
            // 
            this.btn_maakVierkant.Location = new System.Drawing.Point(16, 49);
            this.btn_maakVierkant.Name = "btn_maakVierkant";
            this.btn_maakVierkant.Size = new System.Drawing.Size(190, 23);
            this.btn_maakVierkant.TabIndex = 2;
            this.btn_maakVierkant.Text = "Maak vierkant";
            this.btn_maakVierkant.UseVisualStyleBackColor = true;
            this.btn_maakVierkant.Click += new System.EventHandler(this.btn_maakVierkant_Click);
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output.Location = new System.Drawing.Point(102, 144);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(21, 22);
            this.lbl_output.TabIndex = 3;
            this.lbl_output.Text = "-";
            this.lbl_output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_output.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.btn_maakVierkant);
            this.Controls.Add(this.txt_zijde);
            this.Controls.Add(this.lbl_zijde);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_zijde;
        private System.Windows.Forms.TextBox txt_zijde;
        private System.Windows.Forms.Button btn_maakVierkant;
        private System.Windows.Forms.Label lbl_output;
    }
}


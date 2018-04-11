namespace Opgave1
{
    partial class form_Duimelot
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
            this.lbl_rijmpjeOUTPUT = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_rijmpjeOUTPUT
            // 
            this.lbl_rijmpjeOUTPUT.AutoSize = true;
            this.lbl_rijmpjeOUTPUT.Location = new System.Drawing.Point(25, 19);
            this.lbl_rijmpjeOUTPUT.Name = "lbl_rijmpjeOUTPUT";
            this.lbl_rijmpjeOUTPUT.Size = new System.Drawing.Size(0, 13);
            this.lbl_rijmpjeOUTPUT.TabIndex = 0;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(44, 219);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(143, 219);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // form_Duimelot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_rijmpjeOUTPUT);
            this.Name = "form_Duimelot";
            this.Text = "Duimelot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rijmpjeOUTPUT;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_reset;
    }
}


namespace Depo_Otomasyon
{
    partial class olculer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOlcuEkle = new System.Windows.Forms.Button();
            this.txtOlcu = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnOlcuEkle);
            this.panel1.Controls.Add(this.txtOlcu);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 97);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ölçü Adı:";
            // 
            // btnOlcuEkle
            // 
            this.btnOlcuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlcuEkle.Location = new System.Drawing.Point(16, 48);
            this.btnOlcuEkle.Name = "btnOlcuEkle";
            this.btnOlcuEkle.Size = new System.Drawing.Size(222, 36);
            this.btnOlcuEkle.TabIndex = 2;
            this.btnOlcuEkle.Text = "Ölçü Birimi Tanımla";
            this.btnOlcuEkle.UseVisualStyleBackColor = true;
            this.btnOlcuEkle.Click += new System.EventHandler(this.btnOlcuEkle_Click);
            // 
            // txtOlcu
            // 
            this.txtOlcu.Location = new System.Drawing.Point(87, 19);
            this.txtOlcu.Name = "txtOlcu";
            this.txtOlcu.Size = new System.Drawing.Size(151, 20);
            this.txtOlcu.TabIndex = 0;
            this.txtOlcu.TextChanged += new System.EventHandler(this.txtOlcu_TextChanged);
            // 
            // olculer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 116);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "olculer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ölçüler";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOlcuEkle;
        private System.Windows.Forms.TextBox txtOlcu;
        private System.Windows.Forms.Label label2;

    }
}
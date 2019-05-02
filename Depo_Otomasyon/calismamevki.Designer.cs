namespace Depo_Otomasyon
{
    partial class calismamevki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calismamevki));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMevkiEkle = new System.Windows.Forms.Button();
            this.txtMevkiAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMevki = new System.Windows.Forms.TextBox();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.dgvMevki = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevki)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnMevkiEkle);
            this.groupBox1.Controls.Add(this.txtMevkiAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mevki Ekle";
            // 
            // btnMevkiEkle
            // 
            this.btnMevkiEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMevkiEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnMevkiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMevkiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMevkiEkle.Location = new System.Drawing.Point(336, 24);
            this.btnMevkiEkle.Name = "btnMevkiEkle";
            this.btnMevkiEkle.Size = new System.Drawing.Size(105, 35);
            this.btnMevkiEkle.TabIndex = 2;
            this.btnMevkiEkle.Text = "Mevki Ekle";
            this.btnMevkiEkle.UseVisualStyleBackColor = false;
            this.btnMevkiEkle.Click += new System.EventHandler(this.btnMevkiEkle_Click);
            // 
            // txtMevkiAd
            // 
            this.txtMevkiAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMevkiAd.Location = new System.Drawing.Point(133, 30);
            this.txtMevkiAd.Name = "txtMevkiAd";
            this.txtMevkiAd.Size = new System.Drawing.Size(189, 21);
            this.txtMevkiAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışma Mevki Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMevki);
            this.groupBox2.Controls.Add(this.rd2);
            this.groupBox2.Controls.Add(this.rd1);
            this.groupBox2.Controls.Add(this.dgvMevki);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 313);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mevkiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 4;
            // 
            // txtMevki
            // 
            this.txtMevki.Location = new System.Drawing.Point(202, 51);
            this.txtMevki.Name = "txtMevki";
            this.txtMevki.Size = new System.Drawing.Size(222, 21);
            this.txtMevki.TabIndex = 3;
            this.txtMevki.TextChanged += new System.EventHandler(this.txtMevki_TextChanged);
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(17, 52);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(179, 19);
            this.rd2.TabIndex = 2;
            this.rd2.TabStop = true;
            this.rd2.Text = "Mevki Numarasına Göre Ara";
            this.rd2.UseVisualStyleBackColor = true;
            this.rd2.CheckedChanged += new System.EventHandler(this.rd2_CheckedChanged);
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(17, 27);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(148, 19);
            this.rd1.TabIndex = 1;
            this.rd1.TabStop = true;
            this.rd1.Text = "Mevki İsmine Göre Ara";
            this.rd1.UseVisualStyleBackColor = true;
            this.rd1.CheckedChanged += new System.EventHandler(this.rd1_CheckedChanged);
            // 
            // dgvMevki
            // 
            this.dgvMevki.AllowUserToAddRows = false;
            this.dgvMevki.AllowUserToDeleteRows = false;
            this.dgvMevki.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMevki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMevki.Location = new System.Drawing.Point(6, 85);
            this.dgvMevki.Name = "dgvMevki";
            this.dgvMevki.ReadOnly = true;
            this.dgvMevki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMevki.Size = new System.Drawing.Size(515, 222);
            this.dgvMevki.TabIndex = 0;
            // 
            // calismamevki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(551, 407);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(567, 445);
            this.Name = "calismamevki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışma Mevki";
            this.Load += new System.EventHandler(this.calismamevki_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMevkiAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMevkiEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMevki;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.TextBox txtMevki;
        private System.Windows.Forms.Label label2;
    }
}
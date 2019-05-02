namespace Depo_Otomasyon
{
    partial class depolar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(depolar));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.dgvDepolar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDepoEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepoSorumlu = new System.Windows.Forms.ComboBox();
            this.txtDepoAd = new System.Windows.Forms.TextBox();
            this.btnDepoGoruntule = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepolar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAra);
            this.groupBox2.Controls.Add(this.rdb2);
            this.groupBox2.Controls.Add(this.rdb1);
            this.groupBox2.Controls.Add(this.dgvDepolar);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 299);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Depolar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(206, 61);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(200, 22);
            this.txtAra.TabIndex = 3;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(6, 62);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(183, 20);
            this.rdb2.TabIndex = 2;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "Numaraya Göre Depo Ara";
            this.rdb2.UseVisualStyleBackColor = true;
            this.rdb2.CheckedChanged += new System.EventHandler(this.rdb2_CheckedChanged);
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(6, 36);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(152, 20);
            this.rdb1.TabIndex = 1;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "İsime Göre Depo Ara";
            this.rdb1.UseVisualStyleBackColor = true;
            this.rdb1.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // dgvDepolar
            // 
            this.dgvDepolar.AllowUserToAddRows = false;
            this.dgvDepolar.AllowUserToDeleteRows = false;
            this.dgvDepolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepolar.Location = new System.Drawing.Point(6, 99);
            this.dgvDepolar.Name = "dgvDepolar";
            this.dgvDepolar.ReadOnly = true;
            this.dgvDepolar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepolar.Size = new System.Drawing.Size(545, 186);
            this.dgvDepolar.TabIndex = 0;
            this.dgvDepolar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepolar_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnDepoEkle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDepoSorumlu);
            this.groupBox1.Controls.Add(this.txtDepoAd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depo Ekle";
            // 
            // btnDepoEkle
            // 
            this.btnDepoEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnDepoEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepoEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepoEkle.Location = new System.Drawing.Point(332, 54);
            this.btnDepoEkle.Name = "btnDepoEkle";
            this.btnDepoEkle.Size = new System.Drawing.Size(219, 38);
            this.btnDepoEkle.TabIndex = 4;
            this.btnDepoEkle.Text = "Depo Ekle";
            this.btnDepoEkle.UseVisualStyleBackColor = false;
            this.btnDepoEkle.Click += new System.EventHandler(this.btnDepoEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Depo Sorumlusu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Depo Adı:";
            // 
            // cmbDepoSorumlu
            // 
            this.cmbDepoSorumlu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepoSorumlu.FormattingEnabled = true;
            this.cmbDepoSorumlu.Location = new System.Drawing.Point(133, 68);
            this.cmbDepoSorumlu.Name = "cmbDepoSorumlu";
            this.cmbDepoSorumlu.Size = new System.Drawing.Size(193, 24);
            this.cmbDepoSorumlu.TabIndex = 1;
            // 
            // txtDepoAd
            // 
            this.txtDepoAd.Location = new System.Drawing.Point(133, 31);
            this.txtDepoAd.Name = "txtDepoAd";
            this.txtDepoAd.Size = new System.Drawing.Size(193, 22);
            this.txtDepoAd.TabIndex = 0;
            this.txtDepoAd.TextChanged += new System.EventHandler(this.txtDepoAd_TextChanged);
            // 
            // btnDepoGoruntule
            // 
            this.btnDepoGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepoGoruntule.Location = new System.Drawing.Point(12, 132);
            this.btnDepoGoruntule.Name = "btnDepoGoruntule";
            this.btnDepoGoruntule.Size = new System.Drawing.Size(559, 40);
            this.btnDepoGoruntule.TabIndex = 2;
            this.btnDepoGoruntule.Text = "Depoları Görüntüle";
            this.btnDepoGoruntule.UseVisualStyleBackColor = true;
            this.btnDepoGoruntule.Click += new System.EventHandler(this.btnDepoGoruntule_Click);
            // 
            // depolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(578, 179);
            this.Controls.Add(this.btnDepoGoruntule);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "depolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depolar";
            this.Load += new System.EventHandler(this.Depolar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepolar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDepolar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnDepoGoruntule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepoSorumlu;
        private System.Windows.Forms.TextBox txtDepoAd;
        private System.Windows.Forms.Button btnDepoEkle;


    }
}
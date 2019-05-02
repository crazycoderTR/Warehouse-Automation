namespace Depo_Otomasyon
{
    partial class stokhareketler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stokhareketler));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHareketler = new System.Windows.Forms.DataGridView();
            this.btnVeriGoster = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStokBarkod = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvHareketler);
            this.groupBox1.Controls.Add(this.btnVeriGoster);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStokBarkod);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.rd4);
            this.groupBox1.Controls.Add(this.rd3);
            this.groupBox1.Controls.Add(this.rd2);
            this.groupBox1.Controls.Add(this.rd1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1114, 567);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Hareketleri";
            // 
            // dgvHareketler
            // 
            this.dgvHareketler.AllowUserToAddRows = false;
            this.dgvHareketler.AllowUserToDeleteRows = false;
            this.dgvHareketler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHareketler.Location = new System.Drawing.Point(6, 132);
            this.dgvHareketler.Name = "dgvHareketler";
            this.dgvHareketler.ReadOnly = true;
            this.dgvHareketler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHareketler.Size = new System.Drawing.Size(1096, 426);
            this.dgvHareketler.TabIndex = 11;
            // 
            // btnVeriGoster
            // 
            this.btnVeriGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriGoster.Location = new System.Drawing.Point(592, 26);
            this.btnVeriGoster.Name = "btnVeriGoster";
            this.btnVeriGoster.Size = new System.Drawing.Size(131, 47);
            this.btnVeriGoster.TabIndex = 10;
            this.btnVeriGoster.Text = "Veri\r\nGetir";
            this.btnVeriGoster.UseVisualStyleBackColor = true;
            this.btnVeriGoster.Click += new System.EventHandler(this.btnVeriGoster_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Stok Barkodu;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tarih 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tarih 1:";
            // 
            // txtStokBarkod
            // 
            this.txtStokBarkod.Enabled = false;
            this.txtStokBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStokBarkod.Location = new System.Drawing.Point(408, 78);
            this.txtStokBarkod.Name = "txtStokBarkod";
            this.txtStokBarkod.Size = new System.Drawing.Size(178, 21);
            this.txtStokBarkod.TabIndex = 6;
            this.txtStokBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStokBarkod_KeyDown);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(386, 51);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(386, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // rd4
            // 
            this.rd4.AutoSize = true;
            this.rd4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd4.Location = new System.Drawing.Point(25, 104);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(160, 19);
            this.rd4.TabIndex = 3;
            this.rd4.TabStop = true;
            this.rd4.Text = "Seçili Stoğun Hareketleri";
            this.rd4.UseVisualStyleBackColor = true;
            this.rd4.CheckedChanged += new System.EventHandler(this.rd4_CheckedChanged);
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd3.Location = new System.Drawing.Point(25, 79);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(269, 19);
            this.rd3.TabIndex = 2;
            this.rd3.TabStop = true;
            this.rd3.Text = "İki Tarih Arasındaki  Seçili Stoğun Hareketleri";
            this.rd3.UseVisualStyleBackColor = true;
            this.rd3.CheckedChanged += new System.EventHandler(this.rd3_CheckedChanged);
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd2.Location = new System.Drawing.Point(27, 54);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(188, 19);
            this.rd2.TabIndex = 1;
            this.rd2.TabStop = true;
            this.rd2.Text = "İki Tarih Arasındaki Hareketler";
            this.rd2.UseVisualStyleBackColor = true;
            this.rd2.CheckedChanged += new System.EventHandler(this.rd2_CheckedChanged);
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1.Location = new System.Drawing.Point(27, 29);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(110, 19);
            this.rd1.TabIndex = 0;
            this.rd1.TabStop = true;
            this.rd1.Text = "Tüm Hareketler";
            this.rd1.UseVisualStyleBackColor = true;
            this.rd1.CheckedChanged += new System.EventHandler(this.rd1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(430, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(315, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "İki Tarih Arasında ki Seçilen Stoğun Harekatlarını";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // stokhareketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1126, 582);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1142, 620);
            this.Name = "stokhareketler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Hareketler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.stokharekatlar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStokBarkod;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnVeriGoster;
        private System.Windows.Forms.DataGridView dgvHareketler;
    }
}
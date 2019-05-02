namespace Depo_Otomasyon
{
    partial class stokbilgileri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stokbilgileri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.txtStokBilgi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStoklar = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detayGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoklar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvStoklar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1301, 596);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stoklar";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rd4);
            this.groupBox2.Controls.Add(this.rd3);
            this.groupBox2.Controls.Add(this.rd2);
            this.groupBox2.Controls.Add(this.rd1);
            this.groupBox2.Controls.Add(this.txtStokBilgi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(111, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(932, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veri Getir";
            // 
            // rd4
            // 
            this.rd4.AutoSize = true;
            this.rd4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd4.Location = new System.Drawing.Point(6, 102);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(181, 19);
            this.rd4.TabIndex = 5;
            this.rd4.TabStop = true;
            this.rd4.Text = "Bulunduğu Depoya Göre Ara";
            this.rd4.UseVisualStyleBackColor = true;
            this.rd4.CheckedChanged += new System.EventHandler(this.rd4_CheckedChanged);
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd3.Location = new System.Drawing.Point(6, 79);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(120, 19);
            this.rd3.TabIndex = 4;
            this.rd3.TabStop = true;
            this.rd3.Text = "Firmaya Göre Ara";
            this.rd3.UseVisualStyleBackColor = true;
            this.rd3.CheckedChanged += new System.EventHandler(this.rd3_CheckedChanged);
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd2.Location = new System.Drawing.Point(6, 54);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(163, 19);
            this.rd2.TabIndex = 3;
            this.rd2.TabStop = true;
            this.rd2.Text = "Stok Barkoduna Göre Ara";
            this.rd2.UseVisualStyleBackColor = true;
            this.rd2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1.Location = new System.Drawing.Point(6, 31);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(140, 19);
            this.rd1.TabIndex = 2;
            this.rd1.TabStop = true;
            this.rd1.Text = "Stok İsmine Göre Ara";
            this.rd1.UseVisualStyleBackColor = true;
            this.rd1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtStokBilgi
            // 
            this.txtStokBilgi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokBilgi.Location = new System.Drawing.Point(212, 101);
            this.txtStokBilgi.Name = "txtStokBilgi";
            this.txtStokBilgi.Size = new System.Drawing.Size(561, 21);
            this.txtStokBilgi.TabIndex = 1;
            this.txtStokBilgi.TextChanged += new System.EventHandler(this.txtStokBilgi_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // dgvStoklar
            // 
            this.dgvStoklar.AllowUserToAddRows = false;
            this.dgvStoklar.AllowUserToDeleteRows = false;
            this.dgvStoklar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStoklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoklar.Location = new System.Drawing.Point(6, 162);
            this.dgvStoklar.Name = "dgvStoklar";
            this.dgvStoklar.ReadOnly = true;
            this.dgvStoklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoklar.Size = new System.Drawing.Size(1289, 428);
            this.dgvStoklar.TabIndex = 0;
            this.dgvStoklar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvStoklar_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem,
            this.detayGösterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // detayGösterToolStripMenuItem
            // 
            this.detayGösterToolStripMenuItem.Name = "detayGösterToolStripMenuItem";
            this.detayGösterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.detayGösterToolStripMenuItem.Text = "Detay Göster";
            this.detayGösterToolStripMenuItem.Click += new System.EventHandler(this.detayGösterToolStripMenuItem_Click);
            // 
            // stokbilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1322, 617);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1338, 655);
            this.Name = "stokbilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Bilgileri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.stokbilgileri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoklar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvStoklar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStokBilgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detayGösterToolStripMenuItem;
    }
}
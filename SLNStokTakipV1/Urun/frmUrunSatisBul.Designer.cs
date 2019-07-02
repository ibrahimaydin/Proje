namespace SLNStokTakipV1.Urun
{
    partial class frmUrunSatisBul
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
            this.btnYazdir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GenelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Açıklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYazdir
            // 
            this.btnYazdir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYazdir.Location = new System.Drawing.Point(0, 147);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(142, 42);
            this.btnYazdir.TabIndex = 9;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Arama";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Firebrick;
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(0, 105);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(142, 42);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefonNo.Location = new System.Drawing.Point(3, 319);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(136, 20);
            this.txtTelefonNo.TabIndex = 5;
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirmaAdi.Location = new System.Drawing.Point(3, 293);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(136, 20);
            this.txtFirmaAdi.TabIndex = 3;
            // 
            // btnBul
            // 
            this.btnBul.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBul.Location = new System.Drawing.Point(0, 345);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(142, 63);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKapat.Location = new System.Drawing.Point(0, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(142, 63);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GenelNo,
            this.Tarih,
            this.FirmaAdı,
            this.FirmaTel,
            this.Açıklama});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Liste.Size = new System.Drawing.Size(646, 408);
            this.Liste.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 38);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Liste);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnYazdir);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btnSil);
            this.splitContainer1.Panel2.Controls.Add(this.txtTelefonNo);
            this.splitContainer1.Panel2.Controls.Add(this.txtFirmaAdi);
            this.splitContainer1.Panel2.Controls.Add(this.btnBul);
            this.splitContainer1.Panel2.Controls.Add(this.btnGuncelle);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Size = new System.Drawing.Size(800, 412);
            this.splitContainer1.SplitterDistance = 650;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuncelle.Location = new System.Drawing.Point(0, 63);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(142, 42);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Seçili Veriyi Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Satış BUL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GenelNo
            // 
            this.GenelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GenelNo.HeaderText = "Genel No";
            this.GenelNo.Name = "GenelNo";
            this.GenelNo.ReadOnly = true;
            this.GenelNo.Width = 77;
            // 
            // Tarih
            // 
            this.Tarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            this.Tarih.Width = 56;
            // 
            // FirmaAdı
            // 
            this.FirmaAdı.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirmaAdı.HeaderText = "FirmaAdı";
            this.FirmaAdı.Name = "FirmaAdı";
            this.FirmaAdı.ReadOnly = true;
            // 
            // FirmaTel
            // 
            this.FirmaTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FirmaTel.HeaderText = "Firma Tel";
            this.FirmaTel.Name = "FirmaTel";
            this.FirmaTel.ReadOnly = true;
            this.FirmaTel.Width = 75;
            // 
            // Açıklama
            // 
            this.Açıklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Açıklama.HeaderText = "Açıklama";
            this.Açıklama.Name = "Açıklama";
            this.Açıklama.ReadOnly = true;
            // 
            // frmUrunSatisBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Name = "frmUrunSatisBul";
            this.Text = "frmUrunSatisBul";
            this.Load += new System.EventHandler(this.frmUrunSatisBul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Açıklama;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
    }
}
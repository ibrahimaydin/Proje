namespace SLNStokTakipV1.Model
{
    partial class UrunBul
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtUrunAciklama = new System.Windows.Forms.TextBox();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün bul";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
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
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrunAciklama.Location = new System.Drawing.Point(3, 319);
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(136, 20);
            this.txtUrunAciklama.TabIndex = 5;
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrunKodu.Location = new System.Drawing.Point(3, 293);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(136, 20);
            this.txtUrunKodu.TabIndex = 3;
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
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
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
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
            this.splitContainer1.Panel2.Controls.Add(this.txtUrunAciklama);
            this.splitContainer1.Panel2.Controls.Add(this.txtUrunKodu);
            this.splitContainer1.Panel2.Controls.Add(this.btnBul);
            this.splitContainer1.Panel2.Controls.Add(this.btnGuncelle);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Size = new System.Drawing.Size(694, 412);
            this.splitContainer1.SplitterDistance = 544;
            this.splitContainer1.TabIndex = 5;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UrunNo,
            this.UrunKodu,
            this.UrunAciklama,
            this.Kategori,
            this.saveuser,
            this.savedate,
            this.updateuser,
            this.updatedate});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Liste.Size = new System.Drawing.Size(540, 408);
            this.Liste.TabIndex = 1;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
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
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // UrunNo
            // 
            this.UrunNo.HeaderText = "Ürün no";
            this.UrunNo.Name = "UrunNo";
            this.UrunNo.ReadOnly = true;
            // 
            // UrunKodu
            // 
            this.UrunKodu.HeaderText = "Ürün kodu";
            this.UrunKodu.Name = "UrunKodu";
            this.UrunKodu.ReadOnly = true;
            // 
            // UrunAciklama
            // 
            this.UrunAciklama.HeaderText = "Ürün Açıklama";
            this.UrunAciklama.Name = "UrunAciklama";
            this.UrunAciklama.ReadOnly = true;
            // 
            // Kategori
            // 
            this.Kategori.HeaderText = "Kategori";
            this.Kategori.Name = "Kategori";
            this.Kategori.ReadOnly = true;
            // 
            // saveuser
            // 
            this.saveuser.HeaderText = "Kaydeden Kullanıcı";
            this.saveuser.Name = "saveuser";
            this.saveuser.ReadOnly = true;
            // 
            // savedate
            // 
            this.savedate.HeaderText = "Kayıt Tarihi";
            this.savedate.Name = "savedate";
            this.savedate.ReadOnly = true;
            // 
            // updateuser
            // 
            this.updateuser.HeaderText = "Güncelleyen Kullanıcı";
            this.updateuser.Name = "updateuser";
            this.updateuser.ReadOnly = true;
            // 
            // updatedate
            // 
            this.updatedate.HeaderText = "Güncelleme Tarihi";
            this.updatedate.Name = "updatedate";
            this.updatedate.ReadOnly = true;
            // 
            // UrunBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Name = "UrunBul";
            this.Text = "UrunBul";
            this.Load += new System.EventHandler(this.UrunBul_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtUrunAciklama;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn saveuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn savedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedate;
    }
}
namespace SLNStokTakipV1.Model
{
    partial class FirmaBul
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaGsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yetkili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Web = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fvd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fvn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ftipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(567, 386);
            this.splitContainer1.SplitterDistance = 417;
            this.splitContainer1.TabIndex = 3;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirmaAdi,
            this.FirmaAdres,
            this.FirmaTel,
            this.FirmaGsm,
            this.FirmaFax,
            this.Departman,
            this.Yetkili,
            this.Email,
            this.Web,
            this.Fvd,
            this.Fvn,
            this.Ftipi,
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
            this.Liste.Size = new System.Drawing.Size(413, 382);
            this.Liste.TabIndex = 1;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // FirmaAdi
            // 
            this.FirmaAdi.HeaderText = "Firma Adı";
            this.FirmaAdi.Name = "FirmaAdi";
            this.FirmaAdi.ReadOnly = true;
            // 
            // FirmaAdres
            // 
            this.FirmaAdres.HeaderText = "Firma Adresi";
            this.FirmaAdres.Name = "FirmaAdres";
            this.FirmaAdres.ReadOnly = true;
            // 
            // FirmaTel
            // 
            this.FirmaTel.HeaderText = "Telefon";
            this.FirmaTel.Name = "FirmaTel";
            this.FirmaTel.ReadOnly = true;
            // 
            // FirmaGsm
            // 
            this.FirmaGsm.HeaderText = "Gsm";
            this.FirmaGsm.Name = "FirmaGsm";
            this.FirmaGsm.ReadOnly = true;
            // 
            // FirmaFax
            // 
            this.FirmaFax.HeaderText = "Fax";
            this.FirmaFax.Name = "FirmaFax";
            this.FirmaFax.ReadOnly = true;
            // 
            // Departman
            // 
            this.Departman.HeaderText = "Departman";
            this.Departman.Name = "Departman";
            this.Departman.ReadOnly = true;
            // 
            // Yetkili
            // 
            this.Yetkili.HeaderText = "Yetkili";
            this.Yetkili.Name = "Yetkili";
            this.Yetkili.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Web
            // 
            this.Web.HeaderText = "Web";
            this.Web.Name = "Web";
            this.Web.ReadOnly = true;
            // 
            // Fvd
            // 
            this.Fvd.HeaderText = "Vergi Dairesi";
            this.Fvd.Name = "Fvd";
            this.Fvd.ReadOnly = true;
            // 
            // Fvn
            // 
            this.Fvn.HeaderText = "Vergi No";
            this.Fvn.Name = "Fvn";
            this.Fvn.ReadOnly = true;
            // 
            // Ftipi
            // 
            this.Ftipi.HeaderText = "Tipi";
            this.Ftipi.Name = "Ftipi";
            this.Ftipi.ReadOnly = true;
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
            this.label2.Location = new System.Drawing.Point(53, 247);
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
            // txtTelefonNo
            // 
            this.txtTelefonNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefonNo.Location = new System.Drawing.Point(3, 293);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(136, 20);
            this.txtTelefonNo.TabIndex = 5;
            this.txtTelefonNo.Enter += new System.EventHandler(this.txtFirmaTel_Enter);
            this.txtTelefonNo.Leave += new System.EventHandler(this.txtFirmaTel_Leave);
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirmaAdi.Location = new System.Drawing.Point(3, 267);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(136, 20);
            this.txtFirmaAdi.TabIndex = 3;
            this.txtFirmaAdi.Enter += new System.EventHandler(this.txtFirmaAdi_Enter);
            this.txtFirmaAdi.Leave += new System.EventHandler(this.txtFirmaAdi_Leave);
            // 
            // btnBul
            // 
            this.btnBul.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBul.Location = new System.Drawing.Point(0, 319);
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hasta bul";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirmaBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 424);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Name = "FirmaBul";
            this.Text = "FirmaBul";
            this.Load += new System.EventHandler(this.FirmaBul_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaGsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yetkili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Web;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fvd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fvn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ftipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn saveuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn savedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedate;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnYazdir;
    }
}
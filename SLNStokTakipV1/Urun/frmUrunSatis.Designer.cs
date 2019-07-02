namespace SLNStokTakipV1.Urun
{
    partial class frmUrunSatis
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
            this.Ukod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uacik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bfiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nott = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.DateTimePicker();
            this.lblVergiNosu = new System.Windows.Forms.Label();
            this.lblVergiDairesi = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.txtAcik = new System.Windows.Forms.TextBox();
            this.txtFno = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtYazi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.txtKdv = new System.Windows.Forms.TextBox();
            this.txtAraToplam = new System.Windows.Forms.TextBox();
            this.urncmb = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGenelNo = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Liste);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel2.Controls.Add(this.txtGenelNo);
            this.splitContainer1.Panel2.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Size = new System.Drawing.Size(840, 450);
            this.splitContainer1.SplitterDistance = 662;
            this.splitContainer1.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ukod,
            this.Lot,
            this.Uacik,
            this.Adet,
            this.Bfiyat,
            this.ToplamFiyat,
            this.Nott,
            this.UrunNo});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 138);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(658, 134);
            this.Liste.TabIndex = 1;
            this.Liste.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellEndEdit);
            this.Liste.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Liste_EditingControlShowing);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Ukod
            // 
            this.Ukod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ukod.HeaderText = "Ürün Kodu";
            this.Ukod.Name = "Ukod";
            // 
            // Lot
            // 
            this.Lot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Lot.HeaderText = "Lot";
            this.Lot.Name = "Lot";
            this.Lot.Width = 47;
            // 
            // Uacik
            // 
            this.Uacik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Uacik.HeaderText = "Aciklama";
            this.Uacik.Name = "Uacik";
            this.Uacik.Width = 75;
            // 
            // Adet
            // 
            this.Adet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            this.Adet.Width = 54;
            // 
            // Bfiyat
            // 
            this.Bfiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Bfiyat.HeaderText = "Birim Fiyat";
            this.Bfiyat.Name = "Bfiyat";
            this.Bfiyat.Width = 79;
            // 
            // ToplamFiyat
            // 
            this.ToplamFiyat.HeaderText = "Toplam Fiyat";
            this.ToplamFiyat.Name = "ToplamFiyat";
            // 
            // Nott
            // 
            this.Nott.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nott.HeaderText = "Not";
            this.Nott.Name = "Nott";
            this.Nott.Width = 49;
            // 
            // UrunNo
            // 
            this.UrunNo.HeaderText = "Ürün No";
            this.UrunNo.Name = "UrunNo";
            this.UrunNo.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.txtSaat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTarih);
            this.panel1.Controls.Add(this.lblVergiNosu);
            this.panel1.Controls.Add(this.lblVergiDairesi);
            this.panel1.Controls.Add(this.lblAdres);
            this.panel1.Controls.Add(this.lblUnvan);
            this.panel1.Controls.Add(this.txtAcik);
            this.panel1.Controls.Add(this.txtFno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 138);
            this.panel1.TabIndex = 0;
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(101, 65);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(66, 20);
            this.txtSaat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firma No: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tarih :";
            // 
            // txtTarih
            // 
            this.txtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTarih.Location = new System.Drawing.Point(101, 40);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(113, 20);
            this.txtTarih.TabIndex = 2;
            // 
            // lblVergiNosu
            // 
            this.lblVergiNosu.BackColor = System.Drawing.Color.White;
            this.lblVergiNosu.Location = new System.Drawing.Point(436, 40);
            this.lblVergiNosu.Name = "lblVergiNosu";
            this.lblVergiNosu.Size = new System.Drawing.Size(167, 20);
            this.lblVergiNosu.TabIndex = 1;
            this.lblVergiNosu.Text = "Vergi No";
            // 
            // lblVergiDairesi
            // 
            this.lblVergiDairesi.BackColor = System.Drawing.Color.White;
            this.lblVergiDairesi.Location = new System.Drawing.Point(436, 7);
            this.lblVergiDairesi.Name = "lblVergiDairesi";
            this.lblVergiDairesi.Size = new System.Drawing.Size(167, 17);
            this.lblVergiDairesi.TabIndex = 1;
            this.lblVergiDairesi.Text = "V.Dairesi";
            // 
            // lblAdres
            // 
            this.lblAdres.BackColor = System.Drawing.Color.White;
            this.lblAdres.Location = new System.Drawing.Point(249, 39);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(167, 43);
            this.lblAdres.TabIndex = 1;
            this.lblAdres.Text = "Adres";
            // 
            // lblUnvan
            // 
            this.lblUnvan.BackColor = System.Drawing.Color.White;
            this.lblUnvan.Location = new System.Drawing.Point(249, 7);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(167, 17);
            this.lblUnvan.TabIndex = 1;
            this.lblUnvan.Text = "F.Unvan";
            // 
            // txtAcik
            // 
            this.txtAcik.Location = new System.Drawing.Point(432, 78);
            this.txtAcik.Name = "txtAcik";
            this.txtAcik.Size = new System.Drawing.Size(171, 20);
            this.txtAcik.TabIndex = 0;
            // 
            // txtFno
            // 
            this.txtFno.Location = new System.Drawing.Point(101, 11);
            this.txtFno.Name = "txtFno";
            this.txtFno.Size = new System.Drawing.Size(113, 20);
            this.txtFno.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.txtYazi);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtGenelToplam);
            this.panel2.Controls.Add(this.txtKdv);
            this.panel2.Controls.Add(this.txtAraToplam);
            this.panel2.Controls.Add(this.urncmb);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 174);
            this.panel2.TabIndex = 0;
            // 
            // txtYazi
            // 
            this.txtYazi.Location = new System.Drawing.Point(93, 123);
            this.txtYazi.Name = "txtYazi";
            this.txtYazi.Size = new System.Drawing.Size(452, 20);
            this.txtYazi.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(294, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Genel Toplam : ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(306, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "KDV : ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(306, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ara Toplam : ";
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenelToplam.Location = new System.Drawing.Point(380, 70);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.ReadOnly = true;
            this.txtGenelToplam.Size = new System.Drawing.Size(165, 20);
            this.txtGenelToplam.TabIndex = 3;
            this.txtGenelToplam.TextChanged += new System.EventHandler(this.txtGenelToplam_TextChanged);
            // 
            // txtKdv
            // 
            this.txtKdv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKdv.Location = new System.Drawing.Point(382, 37);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.ReadOnly = true;
            this.txtKdv.Size = new System.Drawing.Size(165, 20);
            this.txtKdv.TabIndex = 3;
            // 
            // txtAraToplam
            // 
            this.txtAraToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAraToplam.Location = new System.Drawing.Point(382, 6);
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.ReadOnly = true;
            this.txtAraToplam.Size = new System.Drawing.Size(165, 20);
            this.txtAraToplam.TabIndex = 3;
            // 
            // urncmb
            // 
            this.urncmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.urncmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.urncmb.FormattingEnabled = true;
            this.urncmb.Location = new System.Drawing.Point(93, 6);
            this.urncmb.Name = "urncmb";
            this.urncmb.Size = new System.Drawing.Size(121, 21);
            this.urncmb.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(553, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 174);
            this.button2.TabIndex = 1;
            this.button2.Text = "YAZDIR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 174);
            this.button1.TabIndex = 0;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtGenelNo
            // 
            this.txtGenelNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGenelNo.Location = new System.Drawing.Point(0, 66);
            this.txtGenelNo.Name = "txtGenelNo";
            this.txtGenelNo.Size = new System.Drawing.Size(170, 20);
            this.txtGenelNo.TabIndex = 5;
            this.txtGenelNo.Text = "***";
            this.txtGenelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LimeGreen;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(0, 380);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(170, 66);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(0, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(170, 66);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // frmUrunSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmUrunSatis";
            this.Text = "frmUrunGiris";
            this.Load += new System.EventHandler(this.frmUrunSatis_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGenelNo;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFno;
        private System.Windows.Forms.Label lblVergiNosu;
        private System.Windows.Forms.Label lblVergiDairesi;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtTarih;
        private System.Windows.Forms.ComboBox urncmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uacik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bfiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nott;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.TextBox txtKdv;
        private System.Windows.Forms.TextBox txtAraToplam;
        private System.Windows.Forms.TextBox txtYazi;
        private System.Windows.Forms.TextBox txtAcik;
    }
}
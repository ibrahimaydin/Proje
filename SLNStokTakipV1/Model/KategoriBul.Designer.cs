namespace SLNStokTakipV1.Model
{
    partial class KategoriBul
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
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnBul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
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
            this.Liste.Size = new System.Drawing.Size(466, 396);
            this.Liste.TabIndex = 0;
            this.Liste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellContentClick);
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hasta bul";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(3, 87);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(136, 20);
            this.txtKategori.TabIndex = 3;
            this.txtKategori.Enter += new System.EventHandler(this.txtKategori_Enter);
            this.txtKategori.Leave += new System.EventHandler(this.txtKategori_Leave);
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
            this.splitContainer1.Panel2.Controls.Add(this.txtKategori);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Panel2.Controls.Add(this.btnBul);
            this.splitContainer1.Size = new System.Drawing.Size(620, 400);
            this.splitContainer1.SplitterDistance = 470;
            this.splitContainer1.TabIndex = 7;
            // 
            // btnBul
            // 
            this.btnBul.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBul.Location = new System.Drawing.Point(0, 333);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(142, 63);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // KategoriBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 438);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Name = "KategoriBul";
            this.Text = "KategoriBul";
            this.Load += new System.EventHandler(this.KategoriBul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn saveuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn savedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedate;
    }
}
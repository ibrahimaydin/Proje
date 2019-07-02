using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLNStokTakipV1.Model
{
    public partial class KategoriBul : Form
    {
        Model.STContext db = new Model.STContext();
        public bool Secim;
        int secimId = -1;
        public KategoriBul()
        {
            InitializeComponent();
        }

        private void Liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void KategoriBul_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {

            #region Arama esnasında textboxlardaki default değerleri okumaması için
            //
            if (txtKategori.Text == "Kategori adı giriniz")
            {
                txtKategori.Text = "";
            }

            // 
            #endregion
            Liste.Rows.Clear();
            int i = 0;
            var bul = (from s in db.bgKategoriler

                       where s.KategoriAdi.Contains(txtKategori.Text)

                       select s).ToList();
            foreach (var k in bul)
            {

                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.KategoriAdi;
                Liste.Rows[i].Cells[2].Value = k.SaveUser;
                Liste.Rows[i].Cells[3].Value = k.SaveDate;
                Liste.Rows[i].Cells[4].Value = k.UpdateUser;
                Liste.Rows[i].Cells[5].Value = k.UpdateDate;
                i++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            #region Arama textboxlarına default text girer
            if (txtKategori.Text == "")
            {
                txtKategori.Font = new Font(txtKategori.Font, FontStyle.Italic);
                txtKategori.Text = "Kategori adı giriniz";
                txtKategori.ForeColor = Color.Silver;
            }

            #endregion
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                frmAnaSayfa.AktarmaI = secimId;
                Close();
            }
        }

        private void Sec()
        {
            try
            {
                secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());

            }
            catch (Exception)
            {
                secimId = -1;
            }
        }
        #region Arama butonlarının Enter & Leave eventları
        private void txtKategori_Enter(object sender, EventArgs e)
        {
            if (txtKategori.Text == "Kategori adı giriniz")
            {
                txtKategori.Font = new Font(txtKategori.Font, FontStyle.Regular);
                txtKategori.Text = "";
                txtKategori.ForeColor = Color.Black;

            }
        }

        private void txtKategori_Leave(object sender, EventArgs e)
        {
            if (txtKategori.Text == "")
            {
                txtKategori.Font = new Font(txtKategori.Font, FontStyle.Italic);
                txtKategori.Text = "Kategori adı giriniz";
                txtKategori.ForeColor = Color.Silver;
            }
        }

        #endregion
    }
}

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
    public partial class UrunBul : Form
    {
        public bool Secim;
        Model.STContext db = new Model.STContext();
        int secimId = -1;

        public UrunBul()
        {
            InitializeComponent();
        }

        private void UrunBul_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {

            #region Arama esnasında textboxlardaki default değerleri okumaması için
            //
            if (txtUrunKodu.Text == "Ürün kodu giriniz")
            {
                txtUrunKodu.Text = "";
            }
            if (txtUrunAciklama.Text == "Ürün açıklaması giriniz")
            {
                txtUrunAciklama.Text = "";
            }
            // 
            #endregion
            Liste.Rows.Clear();
            int i = 0;
            var bul = (from s in db.bgUrunGirisleri

                       where s.UrunKodu.Contains(txtUrunKodu.Text)
                       where s.UrunAciklama.Contains(txtUrunAciklama.Text)
                       select s).ToList();
            foreach (var k in bul)
            {

                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.UrunNo;
                Liste.Rows[i].Cells[2].Value = k.UrunKodu;
                Liste.Rows[i].Cells[3].Value = k.UrunAciklama;
                Liste.Rows[i].Cells[4].Value = k.BgKategori.KategoriAdi; // Hata verebilir
                Liste.Rows[i].Cells[5].Value = k.SaveUser;
                Liste.Rows[i].Cells[6].Value = k.SaveDate;
                Liste.Rows[i].Cells[7].Value = k.UpdateUser;
                Liste.Rows[i].Cells[8].Value = k.UpdateDate;
                i++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            #region Arama textboxlarına default text girer
            if (txtUrunKodu.Text == "")
            {
                txtUrunKodu.Font = new Font(txtUrunKodu.Font, FontStyle.Italic);
                txtUrunKodu.Text = "Ürün kodu giriniz";
                txtUrunKodu.ForeColor = Color.Silver;
            }
            if (txtUrunAciklama.Text == "")
            {
                txtUrunAciklama.Font = new Font(txtUrunAciklama.Font, FontStyle.Italic);
                txtUrunAciklama.Text = "Ürün açıklaması giriniz";
                txtUrunAciklama.ForeColor = Color.Silver;
            }
            #endregion
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();

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
        private void txtUrunKodu_Enter(object sender, EventArgs e)
        {
            if (txtUrunKodu.Text == "Ürün kodu giriniz")
            {
                txtUrunKodu.Font = new Font(txtUrunKodu.Font, FontStyle.Regular);
                txtUrunKodu.Text = "";
                txtUrunKodu.ForeColor = Color.Black;

            }
        }

        private void txtUrunKodu_Leave(object sender, EventArgs e)
        {
            if (txtUrunKodu.Text == "")
            {
                txtUrunKodu.Font = new Font(txtUrunKodu.Font, FontStyle.Italic);
                txtUrunKodu.Text = "Ürün kodu giriniz";
                txtUrunKodu.ForeColor = Color.Silver;
            }
        }

        private void txtUrunAciklama_Enter(object sender, EventArgs e)
        {
            if (txtUrunAciklama.Text == "Ürün açıklaması giriniz")
            {
                txtUrunAciklama.Font = new Font(txtUrunAciklama.Font, FontStyle.Regular);
                txtUrunAciklama.Text = "";
                txtUrunAciklama.ForeColor = Color.Black;
            }
        }

        private void txtUrunAciklama_Leave(object sender, EventArgs e)
        {
            if (txtUrunAciklama.Text == "")
            {
                txtUrunAciklama.Font = new Font(txtUrunAciklama.Font, FontStyle.Italic);

                txtUrunAciklama.Text = "Ürün açıklaması giriniz";
                txtUrunAciklama.ForeColor = Color.Silver;
            }
        }
        #endregion

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                frmAnaSayfa.AktarmaI = secimId;
                Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                db.bgUrunGirisleri.Remove(db.bgUrunGirisleri.Find(secimId));
                db.SaveChanges();
                Listele();
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            Raporlar.frmPrint frm = new Raporlar.frmPrint();
            frm.hangiliste = "Urunler";
            //          frm.txtbox.Text = txtFirmaNo.Text;
            frm.MdiParent = Application.OpenForms["frmAnaSayfa"] as frmAnaSayfa;
            frm.Show();
            Close();
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
    }
}

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
    public partial class FirmaBul : Form
    {
        Model.STContext db = new Model.STContext();
        public bool Secim;
        int secimId = -1;
        int secimFid = -1;

        public FirmaBul()
        {
            InitializeComponent();
        }

        private void Liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FirmaBul_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {

            #region Arama esnasında textboxlardaki default değerleri okumaması için
            //
            if (txtFirmaAdi.Text == "Firma adı giriniz")
            {
                txtFirmaAdi.Text = "";
            }
            if (txtTelefonNo.Text == "Firma telefon no giriniz")
            {
                txtTelefonNo.Text = "";
            }
            // 
            #endregion
            Liste.Rows.Clear();
            int i = 0;
            var bul = (from s in db.bgFirmalar

                       where s.FirmaAdi.Contains(txtFirmaAdi.Text)
                       where s.FirmaTel.Contains(txtTelefonNo.Text)
                       select s).ToList();
            foreach (var k in bul)
            {

                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.FirmaAdi;
                Liste.Rows[i].Cells[2].Value = k.FirmaAdres;
                Liste.Rows[i].Cells[3].Value = k.FirmaTel;
                Liste.Rows[i].Cells[4].Value = k.FirmaGsm;
                Liste.Rows[i].Cells[5].Value = k.FirmaFax;
                Liste.Rows[i].Cells[6].Value = k.Departman;
                Liste.Rows[i].Cells[7].Value = k.Yetkili;
                Liste.Rows[i].Cells[8].Value = k.Email;
                Liste.Rows[i].Cells[9].Value = k.Web;
                Liste.Rows[i].Cells[10].Value = k.Fvd;
                Liste.Rows[i].Cells[11].Value = k.Fvn;
                Liste.Rows[i].Cells[12].Value = k.FtipiId;
                Liste.Rows[i].Cells[13].Value = k.SaveUser;
                Liste.Rows[i].Cells[14].Value = k.SaveDate;
                Liste.Rows[i].Cells[15].Value = k.UpdateUser;
                Liste.Rows[i].Cells[16].Value = k.UpdateDate;
                i++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            #region Arama textboxlarına default text girer
            if (txtFirmaAdi.Text == "")
            {
                txtFirmaAdi.Font = new Font(txtFirmaAdi.Font, FontStyle.Italic);
                txtFirmaAdi.Text = "Firma adı giriniz";
                txtFirmaAdi.ForeColor = Color.Silver;
            }
            if (txtTelefonNo.Text == "")
            {
                txtTelefonNo.Font = new Font(txtTelefonNo.Font, FontStyle.Italic);
                txtTelefonNo.Text = "Firma telefon no giriniz";
                txtTelefonNo.ForeColor = Color.Silver;
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
        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                frmAnaSayfa.AktarmaI = secimId;
                frmAnaSayfa.AktarmaII = secimFid;
                Close();
            }
        }
        private void Sec()
        {
            try
            {    if (Liste.CurrentRow != null)
                {
                    secimId = int.Parse(Liste.CurrentRow.Cells[1].Value.ToString());
                }
                if (Liste.CurrentRow != null)
                {
                    secimFid = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
                }
            }
            catch (Exception)
            {
                secimId = -1;
                secimFid = -1;
            }
        }

        #region Arama butonlarının Enter & Leave eventları
        private void txtFirmaAdi_Enter(object sender, EventArgs e)
        {
            if (txtFirmaAdi.Text == "Firma adı giriniz")
            {
                txtFirmaAdi.Font = new Font(txtFirmaAdi.Font, FontStyle.Regular);
                txtFirmaAdi.Text = "";
                txtFirmaAdi.ForeColor = Color.Black;

            }
        }

        private void txtFirmaAdi_Leave(object sender, EventArgs e)
        {
            if (txtFirmaAdi.Text == "")
            {
                txtFirmaAdi.Font = new Font(txtFirmaAdi.Font, FontStyle.Italic);
                txtFirmaAdi.Text = "Firma adı giriniz";
                txtFirmaAdi.ForeColor = Color.Silver;
            }
        }

        private void txtFirmaTel_Enter(object sender, EventArgs e)
        {
            if (txtTelefonNo.Text == "Firma telefon no giriniz")
            {
                txtTelefonNo.Font = new Font(txtTelefonNo.Font, FontStyle.Regular);
                txtTelefonNo.Text = "";
                txtTelefonNo.ForeColor = Color.Black;
            }
        }

        private void txtFirmaTel_Leave(object sender, EventArgs e)
        {
            if (txtTelefonNo.Text == "")
            {
                txtTelefonNo.Font = new Font(txtTelefonNo.Font, FontStyle.Italic);

                txtTelefonNo.Text = "Firma telefon no giriniz";
                txtTelefonNo.ForeColor = Color.Silver;
            }
        }
        #endregion

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sec();
            if (secimId>0)
            {
                db.bgFirmalar.Remove(db.bgFirmalar.Find(secimId));
                db.SaveChanges();
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                frmAnaSayfa.AktarmaI = secimId;
                Close();
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            Raporlar.frmPrint frm = new Raporlar.frmPrint();
            frm.hangiliste = "Firmalar";
//          frm.txtbox.Text = txtFirmaNo.Text;
            frm.MdiParent = Application.OpenForms["frmAnaSayfa"] as frmAnaSayfa;
            frm.Show();
            Close();
        }
    }
}

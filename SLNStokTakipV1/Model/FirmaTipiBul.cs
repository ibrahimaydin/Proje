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
    public partial class FirmaTipiBul : Form
    {
        Model.STContext db = new Model.STContext();
        public bool Secim;
        int secimId = -1;
        public FirmaTipiBul()
        {
            InitializeComponent();
        }

        private void FirmaTipiBul_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {

            #region Arama esnasında textboxlardaki default değerleri okumaması için
            //
            if (txtFirmaTipi.Text == "Firma tipi giriniz")
            {
                txtFirmaTipi.Text = "";
            }

            // 
            #endregion
            Liste.Rows.Clear();
            int i = 0;
            var bul = (from s in db.bgFirmaTipleri

                       where s.Ftipi.Contains(txtFirmaTipi.Text)

                       select s).ToList();
            foreach (var k in bul)
            {

                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.Ftipi;
                Liste.Rows[i].Cells[2].Value = k.SaveUser;
                Liste.Rows[i].Cells[3].Value = k.SaveDate;
                Liste.Rows[i].Cells[4].Value = k.UpdateUser;
                Liste.Rows[i].Cells[5].Value = k.UpdateDate;
                i++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            #region Arama textboxlarına default text girer
            if (txtFirmaTipi.Text == "")
            {
                txtFirmaTipi.Font = new Font(txtFirmaTipi.Font, FontStyle.Italic);
                txtFirmaTipi.Text = "Firma tipi giriniz";
                txtFirmaTipi.ForeColor = Color.Silver;
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
        private void txtFirmaAdi_Enter(object sender, EventArgs e)
        {
            if (txtFirmaTipi.Text == "Firma tipi giriniz")
            {
                txtFirmaTipi.Font = new Font(txtFirmaTipi.Font, FontStyle.Regular);
                txtFirmaTipi.Text = "";
                txtFirmaTipi.ForeColor = Color.Black;

            }
        }

        private void txtFirmaAdi_Leave(object sender, EventArgs e)
        {
            if (txtFirmaTipi.Text == "")
            {
                txtFirmaTipi.Font = new Font(txtFirmaTipi.Font, FontStyle.Italic);
                txtFirmaTipi.Text = "Firma tipi giriniz";
                txtFirmaTipi.ForeColor = Color.Silver;
            }
        }

        #endregion
    }
}

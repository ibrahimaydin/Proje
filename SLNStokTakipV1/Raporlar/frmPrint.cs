using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLNStokTakipV1.Raporlar
{
    public partial class frmPrint : Form
    {
        Model.STContext db = new Model.STContext();
        public string hangiliste;

        public frmPrint()
        {
            InitializeComponent();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            switch(hangiliste)
            {
                case "Firma":
                    Firma();
                    break;
                case "Firmalar":
                    Firmalar();
                    break;
                case "Urun":
                    Urun();
                    break;
                case "Urunler":
                    Urunler();
                    break;
            }
        }

        private void Urunler()
        {
            Model.UrunBul lst = Application.OpenForms["UrunBul"] as Model.UrunBul;
            crUrun cr = new crUrun();
            var src = (from s in db.bgUrunGirisleri
                       select s).ToList();
            if (src != null)
            {
                Fonksiyonlar.PrintYardim ch = new Fonksiyonlar.PrintYardim();
                DataTable dt = ch.ConvertTo(src);
                cr.SetDataSource(dt);
                crFirma.ReportSource = cr;
            }
        }

        private void Urun()
        {
            Bilgi.frmUrun frm = Application.OpenForms["frmUrun"] as Bilgi.frmUrun;
            crUrun cr = new crUrun();

            int a = int.Parse(txtbox.Text);
            //  var lst = db.bgFirmalar.ToList();
            var lst = (from s in db.bgUrunGirisleri
                       where s.UrunNo == a
                       select new { s.Id, s.UrunAciklama, s.UrunKodu, s.BgKategori.KategoriAdi }).ToList();
            if (lst != null)
            {
                Fonksiyonlar.PrintYardim ch = new Fonksiyonlar.PrintYardim();
                DataTable dt = ch.ConvertTo(lst);
                cr.SetDataSource(dt);
                crFirma.ReportSource = cr;
            }
        }

        private void Firmalar()
        {
            Model.FirmaBul lst = Application.OpenForms["FirmaBul"] as Model.FirmaBul;
            crfirma cr = new crfirma();
            var src = (from s in db.bgFirmalar
                       select s).ToList();
            if (src != null)
            {
                Fonksiyonlar.PrintYardim ch = new Fonksiyonlar.PrintYardim();
                DataTable dt = ch.ConvertTo(src);
                cr.SetDataSource(dt);
                crFirma.ReportSource = cr;
            }
        }

        private void Firma()
        {
            Bilgi.frmFirma frm= Application.OpenForms["frmFirma"]as Bilgi.frmFirma;
            crfirma cr = new crfirma();

            int a = int.Parse(txtbox.Text);
        //  var lst = db.bgFirmalar.ToList();
            var lst = (from s in db.bgFirmalar
                       where s.Fno == a
                       select new { s.FirmaAdi, s.FirmaAdres, s.FirmaFax, s.BgFirmaTipi.Ftipi }).ToList();
            if (lst != null)
            {
                Fonksiyonlar.PrintYardim ch = new Fonksiyonlar.PrintYardim();
                DataTable dt = ch.ConvertTo(lst);
                cr.SetDataSource(dt);
                crFirma.ReportSource = cr;
            }
        }
    }
}

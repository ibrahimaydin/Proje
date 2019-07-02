using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLNStokTakipV1.Model;
using SLNStokTakipV1.Fonksiyonlar;
using System.Runtime.InteropServices;

namespace SLNStokTakipV1.Bilgi
{
    public partial class frmFirma : Form
    {
        Mesajlar m = new Mesajlar();
        Model.STContext db = new Model.STContext();
        Formlar f = new Formlar();
        private bool _edit = false;
        int _firmaId = -1;
        private bool _validasyon = true;
        Fonksiyonlar.Numaralar n = new Numaralar();

        public frmFirma()
        {
            InitializeComponent();
        }
        private void frmFirma_Load(object sender, EventArgs e)
        {
            // Combobox doldurma
            txtFirmaTipi.DataSource = db.bgFirmaTipleri.ToList();
            txtFirmaTipi.ValueMember = "Id";
            txtFirmaTipi.DisplayMember = "Ftipi";
            txtFirmaTipi.Text = "";
            txtFirmaNo.Text = n.FrmNo();
        }
        void Temizle()
        {
            foreach (Control ct in splitContainer1.Panel1.Controls) 
                if (ct is TextBox || ct is ComboBox) ct.Text = "";
            foreach (Control ct in splitContainer1.Panel2.Controls)
                if (ct is TextBox || ct is ComboBox) ct.Text = "";

            _edit = false;
            _firmaId = -1;
            frmAnaSayfa.AktarmaI = -1;
            frmAnaSayfa.AktarmaS = "";
            txtFirmaNo.Text = n.FrmNo();

        }
        protected override void OnLoad(EventArgs e)     //Loaddan önce çalışır
        {
            var btnFirmaNo = new Button();
            btnFirmaNo.Size = new Size(25, txtFirmaNo.ClientSize.Height + 2);
            btnFirmaNo.Location = new Point(txtFirmaNo.ClientSize.Width - btnFirmaNo.Width, -1);
            btnFirmaNo.Cursor = Cursors.Default;
            txtFirmaNo.Controls.Add(btnFirmaNo);
            SendMessage(txtFirmaNo.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnFirmaNo.Width << 16));
            btnFirmaNo.Anchor = (AnchorStyles.Top | AnchorStyles.Right);


            base.OnLoad(e);



            btnFirmaNo.Click += btnFirmaNo_Click;
        }

        private void btnFirmaNo_Click(object sender, EventArgs e)
        {
            int id = f.FirmaBul(true);
            if (id > 0)
            {
                FirmaAc(id);
            }
            frmAnaSayfa.AktarmaI = -1;
        }
        private void FirmaAc(int id)
        {
            _edit = true;
            _firmaId = id;

            bgFirma fb = db.bgFirmalar.First(x => x.Id == id);
            {
                txtFirmaNo.Text = fb.Fno.ToString().PadLeft(7,'0');
                txtAdi.Text = fb.FirmaAdi;
                txtAdres.Text = fb.FirmaAdres;
                txtTel.Text = fb.FirmaTel;
                txtGsm.Text = fb.FirmaGsm;
                txtFax.Text = fb.FirmaFax;
                txtDepartman.Text = fb.Departman;
                txtYetkili.Text = fb.Yetkili;
                txtEmail.Text = fb.Email;
                txtWeb.Text = fb.Web;
                txtVergiDai.Text = fb.Fvd;
                txtVergiNo.Text = fb.Fvn;
                txtFirmaTipi.Text = db.bgFirmaTipleri.First(x => x.Id == fb.FtipiId).Ftipi;
                
            }
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        void YeniKaydet()
        {
            
            bgFirma frm = new bgFirma();
            VerileriAl(frm);
            frm.SaveDate = DateTime.Now;
            frm.SaveUser = -1;

            db.bgFirmalar.Add(frm);
            db.SaveChanges();
            m.YeniKayit("Kayıt başarılı");
            Temizle();
        }

        void Guncelle()
        {
            try
            {
                
                bgFirma frm = db.bgFirmalar.First(x => x.Id == _firmaId);
                {
                    VerileriAl(frm);
                }
                db.SaveChanges();
                m.Guncelle(true);
                Temizle();
            }
            catch (Exception ex)
            {
                m.Hata(ex);

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _validasyon = true;
            Validasyon();
            if (_validasyon==true)
            {
                if (_edit && _firmaId > 0)
                {
                    if (m.Güncelle() == DialogResult.Yes)
                    {
                        Guncelle();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    YeniKaydet();
                } 
            }
        }



        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed)
            {
                splitContainer1.Panel2Collapsed = false;
                btnCollapse.Text = "GİZLE";
            }
            else
            {
                splitContainer1.Panel2Collapsed = true;
                btnCollapse.Text = "GÖSTER";
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmFirma_Load_1(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void VerileriAl(bgFirma frm)
        {
            frm.Departman = txtDepartman.Text;
            frm.Email = txtEmail.Text;
            frm.FirmaAdi = txtAdi.Text;
            frm.FirmaAdres = txtAdres.Text;
            frm.FirmaFax = txtFax.Text;
            frm.FirmaGsm = txtGsm.Text;
            frm.FirmaTel = txtTel.Text;
            try
            {
                frm.Fno = int.Parse(txtFirmaNo.Text);
            }
            catch
            {
                MessageBox.Show("Geçerli bir firma numarası giriniz");
                return;
            }
            try
            {
                frm.FtipiId = db.bgFirmaTipleri.First(x => x.Ftipi == (txtFirmaTipi.Text)).Id;
            }
            catch
            {
                MessageBox.Show("Geçerli bir firma tipi seçiniz");
                return;
            }
            frm.Fvd = txtVergiDai.Text;
            frm.Fvn = txtVergiNo.Text;
            frm.Web = txtWeb.Text;
            frm.Yetkili = txtYetkili.Text;
            frm.UpdateDate = DateTime.Now;
            frm.UpdateUser = -1;
        }
        private void Validasyon()
        {
            if (txtAdi.Text == "")
            {
                m.BosAlanHatasi("Firma adı alanı boş geçilemez");
                _validasyon = false;
                return;
            }
            if (txtFirmaNo.Text == "" || txtFirmaNo.Text == "Firma no giriniz")
            {
                m.BosAlanHatasi("Firma no alanına geçerli bir değer giriniz");
                _validasyon = false;
                return;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Raporlar.frmPrint frm = new Raporlar.frmPrint();
            frm.hangiliste = "Firma";
            frm.txtbox.Text = txtFirmaNo.Text;
            frm.MdiParent = Application.OpenForms["frmAnaSayfa"] as frmAnaSayfa;
            frm.Show();
        }
    }
}

using SLNStokTakipV1.Fonksiyonlar;
using SLNStokTakipV1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLNStokTakipV1.Bilgi
{
    public partial class frmUrun : Form
    {
        Mesajlar m = new Mesajlar();
        Model.STContext db = new Model.STContext();
        Formlar f = new Formlar();
        private bool _edit = false;
        int _urunId = -1;
        private bool _validasyon = true;
        Fonksiyonlar.Numaralar n = new Numaralar();
        public frmUrun()
        {
            InitializeComponent();
        }

        private void frmUrun_Load(object sender, EventArgs e)
        {
            txtKategori.DataSource = db.bgKategoriler.ToList();
            txtKategori.ValueMember = "Id";
            txtKategori.DisplayMember = "KategoriAdi";
            txtKategori.Text = "";
            txtUrunNo.Text = n.UrunNo();
        }

        void Temizle()
        {
            foreach (Control ct in splitContainer1.Panel1.Controls)
                if (ct is TextBox || ct is ComboBox) ct.Text = "";
            foreach (Control ct in splitContainer1.Panel2.Controls)
                if (ct is TextBox || ct is ComboBox) ct.Text = "";

            _edit = false;
            _urunId = -1;
            frmAnaSayfa.AktarmaI = -1;
            frmAnaSayfa.AktarmaS = "";
            txtUrunNo.Text = n.FrmNo();

        }
        protected override void OnLoad(EventArgs e)     //Loaddan önce çalışır
        {
            var btnUrunNo = new Button();
            btnUrunNo.Size = new Size(25, txtUrunNo.ClientSize.Height + 2);
            btnUrunNo.Location = new Point(txtUrunNo.ClientSize.Width - btnUrunNo.Width, -1);
            btnUrunNo.Cursor = Cursors.Default;
            txtUrunNo.Controls.Add(btnUrunNo);
            SendMessage(txtUrunNo.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnUrunNo.Width << 16));
            btnUrunNo.Anchor = (AnchorStyles.Top | AnchorStyles.Right);


            base.OnLoad(e);



            btnUrunNo.Click += btnUrunNo_Click;
        }

        private void btnUrunNo_Click(object sender, EventArgs e)
        {
            int id = f.UrunBul(true);
            if (id > 0)
            {
                UrunAc(id);
            }
            frmAnaSayfa.AktarmaI = -1;
        }

        private void UrunAc(int id)
        {
            _edit = true;
            _urunId = id;

            bgUrunGiris ug = db.bgUrunGirisleri.First(x => x.Id == id);
            {
                txtUrunNo.Text = ug.UrunNo.ToString().PadLeft(7, '0');
                txtUrunKodu.Text = ug.UrunKodu;
                txtUrunAciklama.Text = ug.UrunAciklama;
                txtKategori.Text = db.bgKategoriler.First(x => x.Id == ug.KategoriId).KategoriAdi;
            }
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void VerileriAl(bgUrunGiris frm)
        {
            frm.UrunKodu = txtUrunKodu.Text;
            frm.UrunAciklama = txtUrunAciklama.Text;
            try
            {
                frm.UrunNo = int.Parse(txtUrunNo.Text);
            }
            catch
            {
                MessageBox.Show("Geçerli bir ürün numarası giriniz");
                return;
            }
            try
            {
                frm.KategoriId = db.bgKategoriler.First(x => x.KategoriAdi == (txtKategori.Text)).Id;
            }
            catch
            {
                MessageBox.Show("Geçerli bir kategori seçiniz");
                return;
            }
            frm.UpdateDate = DateTime.Now;
            frm.UpdateUser = -1;
        }

        void YeniKaydet()
        {
            bgUrunGiris frm = new bgUrunGiris();
            VerileriAl(frm);
            frm.SaveDate = DateTime.Now;
            frm.SaveUser = -1;

            db.bgUrunGirisleri.Add(frm);
            db.SaveChanges();
            m.YeniKayit("Kayıt başarılı");
            Temizle();
        }
        void Guncelle()
        {
            try
            {

                bgUrunGiris frm = db.bgUrunGirisleri.First(x => x.Id == _urunId);
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
            if (_validasyon == true)
            {
                if (_edit && _urunId > 0)
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

        private void Validasyon()
        {
            if (txtUrunKodu.Text == "")
            {
                m.BosAlanHatasi("Ürün kodu alanı boş geçilemez");
                _validasyon = false;
                return;
            }
            if (txtUrunNo.Text == "" || txtUrunNo.Text == "Firma no giriniz")
            {
                m.BosAlanHatasi("Firma no alanına geçerli bir değer giriniz");
                _validasyon = false;
                return;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Raporlar.frmPrint frm = new Raporlar.frmPrint();
            frm.hangiliste = "Urun";
            frm.txtbox.Text = txtUrunNo.Text;
            frm.MdiParent = Application.OpenForms["frmAnaSayfa"] as frmAnaSayfa;
            frm.Show();
        }
    }
}

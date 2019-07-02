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
    public partial class frmKategori : Form
    {
        Model.STContext db = new Model.STContext();
        Formlar f = new Formlar();
        Mesajlar m = new Mesajlar();
        private bool _edit = false;
        int _kategoriId = -1;


        public frmKategori()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_edit && _kategoriId > 0)
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

        private void Guncelle()
        {
            try
            {
                bgKategori ktgr = db.bgKategoriler.First(x => x.Id == _kategoriId);
                {
                    ktgr.KategoriAdi = txtKategori.Text;
                    ktgr.UpdateDate = DateTime.Now;
                    ktgr.UpdateUser = -1;
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

        private void Temizle()
        {
            foreach (Control ct in splitContainer1.Controls)
                if (ct is TextBox || ct is ComboBox) ct.Text = "";

            _edit = false;
            _kategoriId = -1;
            frmAnaSayfa.AktarmaI = -1;
            frmAnaSayfa.AktarmaS = "";
        }

        protected override void OnLoad(EventArgs e)     //Loaddan önce çalışır
        {
            var btnKategori = new Button();
            btnKategori.Size = new Size(25, txtKategoriId.ClientSize.Height + 2);
            btnKategori.Location = new Point(txtKategoriId.ClientSize.Width - btnKategori.Width, -1);
            btnKategori.Cursor = Cursors.Default;
            txtKategoriId.Controls.Add(btnKategori);
            SendMessage(txtKategoriId.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnKategori.Width << 16));
            btnKategori.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            base.OnLoad(e);

            btnKategori.Click += btnKategori_Click;
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            int id = f.KategoriBul(true);
            if (id > 0)
            {
                KategorileriAc(id);
            }
            frmAnaSayfa.AktarmaI = -1;
        }

        private void KategorileriAc(int id)
        {
            _edit = true;
            _kategoriId = id;

            bgKategori ktg = db.bgKategoriler.First(x => x.Id == id);
            {
                txtKategoriId.Text = ktg.Id.ToString();
                txtKategori.Text = ktg.KategoriAdi;
            }
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void YeniKaydet()
        {
            bgKategori ktg = new bgKategori();
            ktg.KategoriAdi = txtKategori.Text;
            ktg.SaveDate = DateTime.Now;
            ktg.SaveUser = -1;
            ktg.UpdateDate = DateTime.Now;
            ktg.UpdateUser = -1;

            db.bgKategoriler.Add(ktg);
            db.SaveChanges();
            m.YeniKayit("Kayıt başarılı");
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

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

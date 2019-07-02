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

namespace SLNStokTakipV1.Urun
{
    public partial class frmUrunSatis : Form
    {
        STContext db = new STContext();
        Formlar f = new Formlar();
        Mesajlar m = new Mesajlar();
        Numaralar n = new Numaralar();

        bool edit = false;
        int usatisId = -1;
        int firmaId = -1;
        int firmaFid = -1;
        public string [] MyArray { get; set; }


        public frmUrunSatis()
        {
            InitializeComponent();
        }
        void combo()
        {
            urncmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            var lst = db.bgUrunGirisleri.Select(item => item.UrunKodu).Distinct();
            foreach (string urun  in lst)
            {
                veri.Add(urun);
                urncmb.Items.Add(urun);
            }
            urncmb.AutoCompleteCustomSource = veri;
            var dgv = urncmb.Items.Count;
            MyArray = new string[dgv];
            for(int p=0;p<dgv;p++)
            {
                MyArray[p] = urncmb.Items[p].ToString();

            }
        }

        void YeniKaydet()
        {
            try
            {
                bgSira sira = db.bgSiralar.First(x => x.Sadi == "GenelNo");
                sira.Sno = int.Parse(txtGenelNo.Text);
        


                Liste.AllowUserToAddRows = false;
                stUrunKayitUst ust = new stUrunKayitUst();
                ust.Aciklama = txtAcik.Text;
                ust.AraToplam = decimal.Parse(txtAraToplam.Text);
                ust.FirmaId = int.Parse(txtFno.Text);
                ust.GenelNo = int.Parse(txtGenelNo.Text);
                ust.GenelToplam = decimal.Parse(txtGenelToplam.Text);
                ust.GirisKodu = firmaFid;
                ust.GirisTarih = txtTarih.Value;
                ust.KDVToplam = decimal.Parse(txtKdv.Text);
                ust.Saat = txtSaat.Text;
                ust.SaveDate = DateTime.Now;
                ust.SaveUser = -1;
                ust.UpdateDate = DateTime.Now;
                ust.UpdateUser = -1;
                ust.yazi = txtYazi.Text;

                db.stUrunKayitUsts.Add(ust);
                db.SaveChanges();
                Temizle();

                stUrunKayitAlt[] alt = new stUrunKayitAlt[Liste.RowCount];
                for (int i = 0; i < Liste.RowCount; i++)
                {
                    alt[i] = new stUrunKayitAlt();
                    alt[i].Aciklama = Liste.Rows[i].Cells[3].Value.ToString();
                    alt[i].Adet=int.Parse( Liste.Rows[i].Cells[4].Value.ToString());
                    alt[i].bFiyat=decimal.Parse(Liste.Rows[i].Cells[5].Value.ToString());
                    alt[i].GenelNo = int.Parse(txtGenelNo.Text);
                    alt[i].GirisKod = firmaFid;
                    alt[i].LotSeriNo= Liste.Rows[i].Cells[2].Value.ToString();
                    alt[i].Nott= Liste.Rows[i].Cells[7].Value.ToString();
                    alt[i].SaveDate = DateTime.Now;
                    alt[i].SaveUser = -1;
                    alt[i].UpdateDate = DateTime.Now;
                    alt[i].UpdateUser = -1;
                    alt[i].UrunId =int.Parse( Liste.Rows[i].Cells[8].Value.ToString());
                    alt[i].UrunKodu=Liste.Rows[i].Cells[1].Value.ToString();

                    db.stUrunKayitAlts.Add(alt[i]);
                   
                }
                db.SaveChanges();
                m.YeniKayit("Kayıt Basarıyla Gerceklestirildi.");
                Temizle();
            }
            catch (Exception e)
            {

                m.Hata(e);
            }
        }

        private void Temizle()
        {
            Numaralar n = new Numaralar();
            try
            {
                //foreach (Control ct in splitContainer1.Panel1.Controls)
                //    if (ct is TextBox || ct is ComboBox) ct.Text = "";
                foreach (Control ct in panel1.Controls)
                    if (ct is TextBox || ct is ComboBox) ct.Text = "";
                foreach (Control ct in panel2.Controls)
                    if (ct is TextBox || ct is ComboBox)
                    {
                        if (urncmb.Text!=ct.Text)
                        {
                            ct.Text = "";
                        }
                    }
                txtGenelNo.Text = n.GenelNo();
                txtFno.Text = n.FrmNo();
                lblAdres.Text = "Adres";
                lblUnvan.Text = "Ünvan";
                lblVergiDairesi.Text = "Ver.Dairesi";
                lblVergiNosu.Text = "Ver.No";
                Liste.Rows.Clear();
          
                edit = false;
                frmAnaSayfa.AktarmaI = -1;
                frmAnaSayfa.AktarmaS = "";
                usatisId = -1;
                firmaId = -1;
        
            }
            catch (Exception e)
            {
               m.Hata(e);
            }
        }

        protected override void OnLoad(EventArgs e)     //Loaddan önce çalışır
        {
            var btnFno = new Button();
            btnFno.Size = new Size(25, txtFno.ClientSize.Height + 2);
            btnFno.Location = new Point(txtFno.ClientSize.Width - btnFno.Width, -1);
            btnFno.Cursor = Cursors.Default;
            txtFno.Controls.Add(btnFno);
            SendMessage(txtFno.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnFno.Width << 16));
            btnFno.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            var btnGno = new Button();
            btnGno.Size = new Size(25, txtGenelNo.ClientSize.Height + 2);
            btnGno.Location = new Point(txtGenelNo.ClientSize.Width - btnGno.Width, -1);
            btnGno.Cursor = Cursors.Default;
            txtFno.Controls.Add(btnGno);
            SendMessage(txtFno.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnGno.Width << 16));
            btnGno.Anchor = (AnchorStyles.Top | AnchorStyles.Right);


            base.OnLoad(e);



            btnFno.Click += btnFno_Click;
            btnGno.Click += btnGno_Click;
        }

        private void btnGno_Click(object sender, EventArgs e)
        {
            int id = f.UrunSatisBul(true);
            if (id > 0)
            {
                //Ac(id);
            }
            frmAnaSayfa.AktarmaI = -1;
        }

        private void btnFno_Click(object sender, EventArgs e)
        {
            int id = f.FirmaBul(true);
            int fid = frmAnaSayfa.AktarmaII;
            if (id > 0)
            {
                FirmaAc(id,fid);
            }
            frmAnaSayfa.AktarmaI = -1;
        }

        private void FirmaAc(int id,int fid)
        {
            try
            {
                edit = true;
                firmaId = id;
                firmaFid = fid;

                bgFirma fb = db.bgFirmalar.First(x => x.Id == id);
                {
                    txtFno.Text = fb.Fno.ToString().PadLeft(7, '0');
                    lblUnvan.Text = fb.FirmaAdi;
                    lblAdres.Text = fb.FirmaAdres;
                    lblVergiDairesi.Text = fb.Fvd;
                    lblVergiNosu.Text = fb.Fvn;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }


    
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void frmUrunSatis_Load(object sender, EventArgs e)
        {
            txtSaat.Text = DateTime.Now.ToShortTimeString();
            txtFno.Text = n.FrmNo();
            txtGenelNo.Text = n.GenelNo();
            combo();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;
            if(Liste.CurrentCell.ColumnIndex==1 && txt!=null)
            {
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt.AutoCompleteCustomSource.AddRange(MyArray);


            }

            else if(Liste.CurrentCell.ColumnIndex!=1 && txt!=null)
            {
                txt.AutoCompleteMode = AutoCompleteMode.None;


            }
        }

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        
            if(e.ColumnIndex==1 )
            {
                foreach(DataGridViewCell cell in Liste.SelectedCells)
                {
                    string a = Liste.CurrentRow.Cells[1].Value.ToString();
                    var lst = (from s in db.bgUrunGirisleri
                               where s.UrunKodu==a
                               select s).First();
                    string ack = lst.UrunAciklama;
                    var uno = lst.UrunNo;

                    if (Liste.CurrentRow!=null)
                    {
                        Liste.CurrentRow.Cells[3].Value = ack;
                        Liste.CurrentRow.Cells[8].Value = uno;

                    }
                   

                }

            }
            if (e.ColumnIndex == 5)
            {
                int adt = int.Parse(Liste.CurrentRow.Cells[4].Value.ToString());
               decimal brmfyt = decimal.Parse(Liste.CurrentRow.Cells[5].Value.ToString());
                if (Liste.CurrentRow.Cells[4].Value != null && Liste.CurrentRow.Cells[5].Value != null)
                {
                    Liste.CurrentRow.Cells[6].Value = adt * brmfyt;
                }
            }

            Topla();

        }

        void Topla()
        {
            decimal a = 0,b=0,c=0;
            for (int i = 0; i < Liste.Rows.Count; i++)
            {
                if (Liste.Rows[i].Cells[6].Value != null)
                {
                    a += decimal.Parse(Liste.Rows[i].Cells[6].Value.ToString());
                    txtAraToplam.Text = a.ToString("F");
                    b = (a * 18) / 100;
                    txtKdv.Text = b.ToString("F") ;
                    c = a + b;
                    txtGenelToplam.Text = c.ToString("F");
                }

            }

        }

        public static string yaziyacevir(decimal tutar)
        {
            bool tutarNegatifMi = false;
            if (tutar<0)
            {
                tutarNegatifMi = true;
                tutar *= -1;
            }
            string sTutar=tutar.ToString("F2").Replace('.', ',');
            string lira = sTutar.Substring(0, sTutar.IndexOf(','));
            string kurus = sTutar.Substring(sTutar.IndexOf(',') + 1, 2);
            string yazi = "";
            string[] birler = { "", "BİR", "İKİ", "ÜÇ", "DÖRT", "BEŞ", "ALTI", "YEDİ", "SEKİZ", "DOKUZ" };
            string[] onlar = { "", "ON", "YİRMİ", "OTUZ", "KIRK", "ELLİ", "ALTMIŞ", "YETMİŞ", "SEKSEN", "DOKSAN" };
            string[] binler = { "KATRİLYON", "TRİLYON", "MİLYAR", "MİLYON", "BİN", "" };

            int grupSayisi = 6;

            lira = lira.PadLeft(grupSayisi * 3, '0');

            string grupDegeri;

            for (int i = 0; i < grupSayisi*3; i+=3)
            {
                grupDegeri = "";
                if (lira.Substring(i, 1) != "0")
                {
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + "YÜZ";

                }
                if (grupDegeri=="BİRYÜZ")
                {
                    grupDegeri="YÜZ";
                }
                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))];
                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))];


                if (grupDegeri!="")
                {
                    grupDegeri += binler[i / 3];
                }
                if (grupDegeri == "BİRBİN")
                {
                    grupDegeri = "BİN";

                }
                yazi += grupDegeri;
               
            }
            if (yazi != "")
                yazi += "₺";
            int yaziuzunlugu = yazi.Length;
            if (kurus.Substring(0, 1) != "0")
          yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];
            if (kurus.Substring(0, 1) != "0")
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];
            if (yazi.Length > yaziuzunlugu)
                yazi += "Kr.";
            else
                yazi += "SIFIR Kr.";
            if (tutarNegatifMi)
                return "EKSİ" + yazi;
            return yazi;
         
        }

        private void txtGenelToplam_TextChanged(object sender, EventArgs e)
        {
            if (txtGenelToplam.Text!="")
            {
                txtYazi.Text = yaziyacevir(decimal.Parse(txtGenelToplam.Text));
            }
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
            Liste.AllowUserToAddRows = true;
        }
    }
}

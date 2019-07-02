using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLNStokTakipV1.Fonksiyonlar;

namespace SLNStokTakipV1
{
    public partial class frmAnaSayfa : Form
    {
        Formlar f = new Formlar();
        public static string AktarmaS;
        public static int AktarmaI;
        public static int AktarmaII;

        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnFirmaGiris_Click(object sender, EventArgs e)
        {
            Bilgi.frmFirma frm = new Bilgi.frmFirma();
            frm.MdiParent = Application.OpenForms["frmAnaSayfa"] as frmAnaSayfa;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnBir_Click(object sender, EventArgs e)
        {
            pnl1.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
            gbSol.Text = "Ürün İşlemleri";
        }

        private void btnIki_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = true;
            pnl3.Visible = false;
            gbSol.Text = "Bilgi Giriş";
        }

        private void btnUc_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = true;
            gbSol.Text = "%%";
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            pnl1.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
            gbSol.Text = "Ürün İşlemleri";
        }

        private void btnFirmaTipiGiris_Click(object sender, EventArgs e)
        {
            Bilgi.frmFirmaTipi frm = new Bilgi.frmFirmaTipi();
            frm.MdiParent = Application.OpenForms["frmAnaSayfa"] as frmAnaSayfa;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnKategoriGiris_Click(object sender, EventArgs e)
        {
            Bilgi.frmKategori frm = new Bilgi.frmKategori();
            frm.MdiParent = Application.OpenForms["frmAnaSayfa"] as frmAnaSayfa;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUrunGiris_Click(object sender, EventArgs e)
        {
            Bilgi.frmUrun frm = new Bilgi.frmUrun();
            frm.MdiParent = Application.OpenForms["frmAnaSayfa"] as frmAnaSayfa;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnOpTur_Click(object sender, EventArgs e)
        {
            f.UrunSatis();
        }

        private void btnUrunGirisListe_Click(object sender, EventArgs e)
        {
            f.UrunSatisBul();
        }
    }
}

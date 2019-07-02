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
    public partial class frmFirmaTipi : Form
    {
        Model.STContext db = new Model.STContext();
        Formlar f = new Formlar();
        Mesajlar m = new Mesajlar();
        private bool _edit = false;
        int _firmaTipiId = -1;
        public frmFirmaTipi()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)     //Loaddan önce çalışır
        {
            var btnFirmaTipi = new Button();
            btnFirmaTipi.Size = new Size(25, txtFirmaTipiId.ClientSize.Height + 2);
            btnFirmaTipi.Location = new Point(txtFirmaTipiId.ClientSize.Width - btnFirmaTipi.Width, -1);
            btnFirmaTipi.Cursor = Cursors.Default;
            txtFirmaTipiId.Controls.Add(btnFirmaTipi);
            SendMessage(txtFirmaTipiId.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnFirmaTipi.Width << 16));
            btnFirmaTipi.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            
            base.OnLoad(e);
                       
            btnFirmaTipi.Click += btnFirmaTipi_Click;
        }

        void Guncelle()
        {
            try
            {
                bgFirmaTipi frmtp = db.bgFirmaTipleri.First(x => x.Id == _firmaTipiId);
                {
                    frmtp.Ftipi = txtFirmaTipi.Text;
                    frmtp.UpdateDate = DateTime.Now;
                    frmtp.UpdateUser = -1;
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
            _firmaTipiId = -1;
            frmAnaSayfa.AktarmaI = -1;
            frmAnaSayfa.AktarmaS = "";
        }

        private void btnFirmaTipi_Click(object sender, EventArgs e)
        {
            int id = f.FirmaTipiBul(true);
            if (id > 0)
            {
                FirmaTipiAc(id);
            }
            frmAnaSayfa.AktarmaI = -1;
        }
        private void FirmaTipiAc(int id)
        {
            _edit = true;
            _firmaTipiId = id;

            bgFirmaTipi ft = db.bgFirmaTipleri.First(x => x.Id == id);
            {
                txtFirmaTipiId.Text = ft.Id.ToString();
                txtFirmaTipi.Text = ft.Ftipi;

            }
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_edit && _firmaTipiId > 0)
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

        private void YeniKaydet()
        {
            bgFirmaTipi frt = new bgFirmaTipi();
            frt.Ftipi = txtFirmaTipi.Text;
            frt.SaveDate = DateTime.Now;
            frt.SaveUser = -1;
            frt.UpdateDate = DateTime.Now;
            frt.UpdateUser = -1;

            db.bgFirmaTipleri.Add(frt);
            db.SaveChanges();
            m.YeniKayit("Kayıt başarılı");
        }

        private void frmFirmaTipi_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}

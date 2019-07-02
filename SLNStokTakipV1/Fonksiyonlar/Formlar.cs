using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLNStokTakipV1.Fonksiyonlar
{
    class Formlar
    {
        public int FirmaBul(bool secim = false)
        {
            Model.FirmaBul bul = new Model.FirmaBul();
            if (secim == true)
            {
                bul.Secim = true;
                //bul.btnAktar.Enabled = true;
                bul.ShowDialog();

            }
            else
            {
                bul.MdiParent = Form.ActiveForm;
                bul.WindowState = FormWindowState.Maximized;
                // bul.btnAktar.Enabled = false;
                bul.Show();
            }
            return frmAnaSayfa.AktarmaI;
        }
        public int FirmaTipiBul(bool secim = false)
        {
            Model.FirmaTipiBul bul = new Model.FirmaTipiBul();
            if (secim == true)
            {
                bul.Secim = true;
                //bul.btnAktar.Enabled = true;
                bul.ShowDialog();

            }
            else
            {
                bul.MdiParent = Form.ActiveForm;
                bul.WindowState = FormWindowState.Maximized;
                // bul.btnAktar.Enabled = false;
                bul.Show();
            }
            return frmAnaSayfa.AktarmaI;
        }
        public int KategoriBul(bool secim = false)
        {
            Model.KategoriBul bul = new Model.KategoriBul();
            if (secim == true)
            {
                bul.Secim = true;
                //bul.btnAktar.Enabled = true;
                bul.ShowDialog();

            }
            else
            {
                bul.MdiParent = Form.ActiveForm;
                bul.WindowState = FormWindowState.Maximized;
                // bul.btnAktar.Enabled = false;
                bul.Show();
            }
            return frmAnaSayfa.AktarmaI;
        }
        public int UrunBul(bool secim = false)
        {
            Model.UrunBul bul = new Model.UrunBul();
            if (secim == true)
            {
                bul.Secim = true;
                //bul.btnAktar.Enabled = true;
                bul.ShowDialog();

            }
            else
            {
                bul.MdiParent = Form.ActiveForm;
                bul.WindowState = FormWindowState.Maximized;
                // bul.btnAktar.Enabled = false;
                bul.Show();
            }
            return frmAnaSayfa.AktarmaI;
        }

        public void UrunSatis()
        {
            Urun.frmUrunSatis frm = new Urun.frmUrunSatis();
            frm.MdiParent = Application.OpenForms["frmAnaSayfa"] as
                frmAnaSayfa;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();



        }
        public int UrunSatisBul(bool secim = false)
        {
            Urun.frmUrunSatisBul bul = new Urun.frmUrunSatisBul();
            if (secim == true)
            {
                bul.Secim = true;
                //bul.btnAktar.Enabled = true;
                bul.ShowDialog();

            }
            else
            {
                bul.MdiParent = Form.ActiveForm;
                bul.WindowState = FormWindowState.Maximized;
                // bul.btnAktar.Enabled = false;
                bul.Show();
            }
            return frmAnaSayfa.AktarmaI;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLNStokTakipV1.Urun
{
    public partial class frmUrunSatisBul : Form
    {

        Model.STContext db = new Model.STContext();

        public bool Secim;



        public frmUrunSatisBul()
        {
            InitializeComponent();
        }

        private void frmUrunSatisBul_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            int i = 0;
            var lst = (from s in db.stUrunKayitUsts
                       select new
                       {
                           gno = s.GenelNo,
                           trh = s.GirisTarih,
                           fadi = s.BgFirma.FirmaAdi,
                           ftel = s.BgFirma.FirmaTel,
                           ack = s.Aciklama
                       }).Distinct();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.gno;
                Liste.Rows[i].Cells[1].Value = k.trh;
                Liste.Rows[i].Cells[2].Value = k.fadi;
                Liste.Rows[i].Cells[3].Value = k.ftel;
                Liste.Rows[i].Cells[4].Value = k.ack;
                i++;
                Liste.AllowUserToAddRows = false;

            }
        }
    }
}

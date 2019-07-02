using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNStokTakipV1.Model
{
    public class stUrunKayitAlt : baseEntity
    {
        public int GenelNo { get; set; }
        public int GirisKod { get; set; }
        public int UrunId { get; set; }
        public string UrunKodu { get; set; }
        public string LotSeriNo { get; set; }
        public int Adet { get; set; }
        public decimal bFiyat { get; set; }
        public string Aciklama { get; set; }
        public string Nott { get; set; }        // Sql'de not var

    }
}

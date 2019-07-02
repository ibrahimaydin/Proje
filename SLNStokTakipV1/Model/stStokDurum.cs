using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNStokTakipV1.Model
{
    public class stStokDurum : baseEntity
    {
        public string UrunKodu { get; set; }
        public string LotSeriNo { get; set; }
        public string UrunAciklama { get; set; }
        public int Adet { get; set; }

    }
}

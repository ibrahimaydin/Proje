using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNStokTakipV1.Model
{
    public class bgUrunGiris : baseEntity
    {
        public int UrunNo { get; set; }
        public string UrunKodu { get; set; }
        public string UrunAciklama { get; set; }
        public int KategoriId { get; set; }

        [ForeignKey("KategoriId")]
        public virtual bgKategori BgKategori { get; set; }
    }
}

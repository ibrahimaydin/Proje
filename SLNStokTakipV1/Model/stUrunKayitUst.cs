using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNStokTakipV1.Model
{
    public class stUrunKayitUst : baseEntity    
    {
        public int GenelNo { get; set; }
        public int GirisKodu { get; set; }
        public int? FirmaId { get; set; }
        [ForeignKey ("FirmaId")]
        public virtual bgFirma BgFirma { get; set; }
        public DateTime GirisTarih { get; set; }
        public string Aciklama { get; set; }
        
        [StringLength(5)]
        public string Saat { get; set; }
        public decimal AraToplam { get; set; }
        public decimal KDVToplam { get; set; }
        public decimal GenelToplam { get; set; }
        [StringLength(200)]
        public string yazi { get; set; }

    

   
    }
}

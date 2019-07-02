using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNStokTakipV1.Model
{
    public class bgFirma : baseEntity
    {
        public int Fno { get; set; }        // Firma no






        [StringLength(150)]
    
        public string FirmaAdi { get; set; }
        [StringLength(350)]
        public string FirmaAdres { get; set; }
        [StringLength(15)]
        public string FirmaTel { get; set; }
        [StringLength(15)]
        public string FirmaGsm { get; set; }
        [StringLength(15)]
        public string FirmaFax { get; set; }
        [StringLength(50)]
        public string Departman { get; set; }
        [StringLength(50)]
        public string Yetkili { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Web { get; set; }
        [StringLength(11)]
        public string Fvd { get; set; }     // Firma vergi dairesi
        [StringLength(11)]
        public string Fvn { get; set; }     // Firma vergi no




        public int? FtipiId { get; set; }      // Firma tipi

        [ForeignKey("FtipiId")]
        public virtual bgFirmaTipi BgFirmaTipi { get; set; }

        public virtual ICollection<stUrunKayitUst> StUrunKayitUsts { get; set; }

    }
}

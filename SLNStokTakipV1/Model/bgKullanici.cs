using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNStokTakipV1.Model
{
    public class bgKullanici : baseEntity
    {
        public string Kadi { get; set; }
        public string Kadres { get; set; }
        public string Ktel { get; set; }
        public string Kgsm { get; set; }
        public string Email { get; set; }
        public string Ktipi { get; set; }
        public string Sifre { get; set; }
        public int GenelNo { get; set; }

    }
}

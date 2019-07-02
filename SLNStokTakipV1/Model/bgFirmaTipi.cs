using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNStokTakipV1.Model
{
    public class bgFirmaTipi : baseEntity
    {
        public string Ftipi { get; set; }
        public virtual ICollection<bgFirma> BgFirmas { get; set; }

    }
}

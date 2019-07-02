using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNStokTakipV1.Model
{
    public class baseEntity
    {
        public int Id { get; set; }
        // Log tutmak için
        public int SaveUser { get; set; }
        public DateTime SaveDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }


    }
}

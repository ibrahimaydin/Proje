using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNStokTakipV1.Fonksiyonlar
{
    class Numaralar
    {
        Model.STContext db = new Model.STContext();

        public string FrmNo()
        {
            try
            {
                double numara = double.Parse((from s in db.bgFirmalar
                                              orderby s.Id descending
                                              select s).First().Fno.ToString());
                numara++;
                string num = numara.ToString().PadLeft(7, '0'); // sayının soluna yedi hane olacak kadar sıfır koy
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }
        public string UrunNo()
        {
            try
            {
                double numara = double.Parse((from s in db.bgUrunGirisleri
                                              orderby s.Id descending
                                              select s).First().UrunNo.ToString());
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {

                return "0000001";
            }
        }
        public string GenelNo()
        {


            try
            {
                double numara = double.Parse((from s in db.bgSiralar
                                              where s.Sadi == "GenelNo"
                                              orderby s.Id descending
                                              select s).First().Sno.ToString());
                numara++;
                string num = numara.ToString().PadLeft(7, '0'); // sayının soluna yedi hane olacak kadar sıfır koy
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }

    }


}

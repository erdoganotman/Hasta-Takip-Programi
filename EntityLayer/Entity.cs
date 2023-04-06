using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Entity
    {
        private int ID;
        private string ISIM;
        private string SOYISIM;
        private string DOGUMTARIHI;
        private string KANGRUBU;
        private string KRONIKHASTALIK;
        private string AMELIYAT;
        private string TESHIS;
        private string TEDAVIPLANI;
        private string TELEFON;
        private string ADRES;
        private int UCRET;
        private int BORC;
        private DateTime RANDEVUTARIHI;
        private string TC;





        public int ID1 { get => ID; set => ID = value; }
        public string ISIM1 { get => ISIM; set => ISIM = value; }
        public string SOYISIM1 { get => SOYISIM; set => SOYISIM = value; }

        public string TELEFON1 { get => TELEFON; set => TELEFON = value; }
        
        public string KANGRUBU1 { get => KANGRUBU; set => KANGRUBU = value; }
        public string KRONIKHASTALIK1 { get => KRONIKHASTALIK; set => KRONIKHASTALIK = value; }
        public string AMELIYAT1 { get => AMELIYAT; set => AMELIYAT = value; }
        public string TESHIS1 { get => TESHIS; set => TESHIS = value; }
        public string TEDAVIPLANI1 { get => TEDAVIPLANI; set => TEDAVIPLANI = value; }
        
        public string ADRES1 { get => ADRES; set => ADRES = value; }
        public int UCRET1 { get => UCRET; set => UCRET = value; }
        public int BORC1 { get => BORC2; set => BORC2 = value; }
        
        public string TC1 { get => TC; set => TC = value; }
        public string DOGUMTARIHI1 { get => DOGUMTARIHI; set => DOGUMTARIHI = value; }
        public int BORC2 { get => BORC; set => BORC = value; }
        public DateTime RANDEVUTARIHI1 { get => RANDEVUTARIHI; set => RANDEVUTARIHI = value; }
    }
}

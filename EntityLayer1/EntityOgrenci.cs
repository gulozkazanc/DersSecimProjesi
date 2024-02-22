using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer1
{
   public class EntityOgrenci
    {
        string ad;
        string soyad;
        int id;
        string numara;
        string fotograf;
        double bakiye;
        string sifre;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int Id { get => id; set => id = value; }
        public string Numara { get => numara; set => numara = value; }
        public string Fotograf { get => fotograf; set => fotograf = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }
        public string Sifre { get => sifre; set => sifre = value; }
    }
}

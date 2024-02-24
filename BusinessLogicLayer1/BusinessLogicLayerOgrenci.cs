using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer1;
using DataAccessLayer1;

namespace BusinessLogicLayer1
{
    public class BusinessLogicLayerOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Sifre != null && p.Fotograf != null)
            {
                return DataAccessLayerOgrenci.OgrenciEkle(p);//ad,soyad... alanlarına veri girişi yapıldıysa DALOgrenci deki OgrenciEkle metodunu çağır 
            }
            return -1;
        }

        public static List<EntityOgrenci> BllListele()
        {
            return DataAccessLayerOgrenci.OgrenciListesi();
        }

        public static bool OgrenciSilBll(int p)
        {
            if (p>=0)
            {
                return DataAccessLayerOgrenci.OgrenciSil(p);
            }
            return false;
        }


        public static List<EntityOgrenci> BllDetay(int p)
        {
            return DataAccessLayerOgrenci.OgrenciDetay(p);
        }

        public static bool OgrenciGuncelleBll(EntityOgrenci p)
        {
            if (p.Ad != null && p.Ad!="" && p.Soyad != null && p.Numara != null && p.Sifre != null && p.Fotograf != null && p.Id>0)
            {
                return DataAccessLayerOgrenci.OgrenciGuncelle(p);
            }
            return false;
           
        }


    }
}

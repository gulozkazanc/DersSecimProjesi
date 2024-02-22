using System;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BusinessLogicLayerOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if(p.Ad!=null && p.Soyad!=null && p.Numara!=null && p.Sifre!=null && p.Fotograf!=null)
            {
                return DataAccessLayerOgrenci.OgrenciEkle(p);//ad,soyad... alanlarına veri girişi yapıldıysa DALOgrenci deki OgrenciEkle metodunu çağır 
            }
            return -1;
        }

    }
}

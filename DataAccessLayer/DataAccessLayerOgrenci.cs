using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
   public class DataAccessLayerOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLOGRENCI(OGRAD,OGRSOYAD,OGRNUMARA,OGRFOTO,OGRSIFRE) values (@p1,@p2,@p3,@p4,@p5)",Baglanti.bgl);
            if(komut1.Connection.State!=ConnectionState.Open)//Bağlantı kapalıysa,aç
            {
                komut1.Connection.Open();

            }
            komut1.Parameters.AddWithValue("@p1",parametre.Ad);
            komut1.Parameters.AddWithValue("@p2", parametre.Soyad);
            komut1.Parameters.AddWithValue("@p3", parametre.Numara);
            komut1.Parameters.AddWithValue("@p4", parametre.Fotograf);
            komut1.Parameters.AddWithValue("@p5", parametre.Sifre);

            return komut1.ExecuteNonQuery();//Eklenen kayıt sayısını geri döndür

        }
    }
}

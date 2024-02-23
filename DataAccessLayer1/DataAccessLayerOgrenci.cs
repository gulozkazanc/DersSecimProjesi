﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer1;

namespace DataAccessLayer1
{
   public class DataAccessLayerOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)//Entityogrenci sınıfındaki tüm parametreleri alacak
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLOGRENCI(OGRAD,OGRSOYAD,OGRNUMARA,OGRFOTO,OGRSIFRE) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)//Bağlantı kapalıysa,aç
            {
                komut1.Connection.Open();

            }
            komut1.Parameters.AddWithValue("@p1", parametre.Ad);
            komut1.Parameters.AddWithValue("@p2", parametre.Soyad);
            komut1.Parameters.AddWithValue("@p3", parametre.Numara);
            komut1.Parameters.AddWithValue("@p4", parametre.Fotograf);
            komut1.Parameters.AddWithValue("@p5", parametre.Sifre);

            return komut1.ExecuteNonQuery();//Eklenen kayıt sayısını geri döndür

        }
        public static List<EntityOgrenci> OgrenciListesi()//System.Collection 'ın Generic Sınıfına ait bir komut: List, verileri veri tabanından çekmek için kullanılacak

        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("select * from TBLOGRENCI",Baglanti.bgl);//Baglanti sınıfındaki bgl nesnesi ile veriyi çekiyoruz
            if (komut2.Connection.State != ConnectionState.Open)//Bağlantı kapalıysa,aç
            {
                komut2.Connection.Open();

            }
            SqlDataReader dr = komut2.ExecuteReader();

            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(dr["OGRID"].ToString());
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad= dr["OGRSOYAD"].ToString();
                ent.Numara=dr["OGRNUMARA"].ToString();
                ent.Fotograf= dr["OGRFOTO"].ToString();
                ent.Sifre= dr["OGRSIFRE"].ToString();
                ent.Bakiye=Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("delete from TBLOGRENCI where OGRID=@p1",Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)//Bağlantı kapalıysa,aç
            {
                komut3.Connection.Open();

            }
            komut3.Parameters.AddWithValue("@p1",parametre);
            return komut3.ExecuteNonQuery() > 0;

        }


    }
}

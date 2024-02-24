using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer1;

namespace DataAccessLayer1
{
   public class DataAccsessLayerDers
    {
        public static List<EntityDers> DersListesi()//System.Collection 'ın Generic Sınıfına ait bir komut: List, verileri veri tabanından çekmek için kullanılacak

        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut2 = new SqlCommand("select * from TBLDERSLER", Baglanti.bgl);//Baglanti sınıfındaki bgl nesnesi ile veriyi çekiyoruz
            if (komut2.Connection.State != ConnectionState.Open)//Bağlantı kapalıysa,aç
            {
                komut2.Connection.Open();

            }
            SqlDataReader dr = komut2.ExecuteReader();

            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.Id = Convert.ToInt32(dr["DERSID"].ToString());
                ent.Dersad = dr["DERSAD"].ToString();
                ent.Min =int.Parse(dr["DERSMINKONT"].ToString());
                ent.Max =int.Parse(dr["DERSMAXKONT"].ToString());
                
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into TBLBASVURUFORM (OGRENCIID,DERSID) values (@P1,@P2)",Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1",parametre.Basogrid);
            komut.Parameters.AddWithValue("@p2",parametre.Basdersid);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }


    }
}

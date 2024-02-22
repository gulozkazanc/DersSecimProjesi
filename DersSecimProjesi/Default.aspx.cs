using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer1;
using DataAccessLayer1;
using BusinessLogicLayer1;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = "Derya";
            ent.Soyad = "Yıldız";
            ent.Numara = "1166";
            ent.Sifre = "123";
            ent.Fotograf = null;
            BusinessLogicLayerOgrenci.OgrenciEkleBLL(ent);//BLL de yazdığım şarta uyum sağlıyorsa ekleme işlemi yapılır.
        
    }
}
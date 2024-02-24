using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer1;
using DataAccessLayer1;
using BusinessLogicLayer1;
public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x=Convert.ToInt32(Request.QueryString["OGRID"].ToString());
        TxtId.Text = x.ToString();
        TxtId.Enabled = false;

        if (Page.IsPostBack == false)
        {
            List<EntityOgrenci> OgrList = BusinessLogicLayerOgrenci.BllDetay(x);
            TxtAd.Text = OgrList[0].Ad.ToString();//hafızaya aldığı ilk öğrencinin adını yazdır.
            TxtSoyad.Text = OgrList[0].Soyad.ToString();
            TxtNumara.Text = OgrList[0].Numara.ToString();
            TxtFoto.Text = OgrList[0].Fotograf.ToString();
            TxtSifre.Text = OgrList[0].Sifre.ToString();

        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.Ad = TxtAd.Text;
        ent.Soyad = TxtSoyad.Text;
        ent.Sifre = TxtSifre.Text;
        ent.Numara = TxtNumara.Text;
        ent.Fotograf = TxtFoto.Text;
        ent.Id = Convert.ToInt32(TxtId.Text);

        BusinessLogicLayerOgrenci.OgrenciGuncelleBll(ent);
        Response.Redirect("OgrenciListesi.aspx");
    }
}
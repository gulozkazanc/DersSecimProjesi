using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer1;
using DataAccessLayer1;
using BusinessLogicLayer1;
public partial class Dersler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            List<EntityDers> EntDers = BusinessLogicLayerDers.BllListele();
            DropDownList1.DataSource = BusinessLogicLayerDers.BllListele();
            DropDownList1.DataTextField = "Dersad";//DataTextField,Kullanıcı panelinde bize görünecek alan
            DropDownList1.DataValueField = "Id"; //Derslerin ıd lerini tutacak
            DropDownList1.DataBind();
        }
    }

    protected void Unnamed2_Click(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //TextBox1.Text = DropDownList1.SelectedValue.ToString();
        EntityBasvuruForm ent = new EntityBasvuruForm();
        ent.Basogrid = int.Parse(TextBox1.Text);
        ent.Basdersid = int.Parse(DropDownList1.SelectedValue.ToString());
        BusinessLogicLayerDers.TalepEkleBll(ent);

    }
}
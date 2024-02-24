<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciGuncelle.aspx.cs" Inherits="OgrenciGuncelle" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <form id="Form1" runat="server">

        <div class="form-group">
            <div>
                <strong>
            <asp:Label for="TxtId" runat="server" Text="Öğrenci ID :"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
            <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı :"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
            <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci Soyadı :"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        
            <br />
            <div>
                <strong>
            <asp:Label for="TxtNumara" runat="server" Text="Numara :"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        
            <br />
            <div>
                <strong>
            <asp:Label for="TxtSifre" runat="server" Text="Şifre :"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        
            <br />
            <div>
                <strong>
            <asp:Label for="TxtFoto" runat="server" Text="Fotoğraf :"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtFoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
        </div>


        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-warning" OnClick="Button1_Click" />


    </form>
    

</asp:Content>




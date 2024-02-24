<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Dersler.aspx.cs" Inherits="Dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

   <form runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Ders Seçiniz"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" ></asp:DropDownList>
    </div>

       <br />

    <div>
        <asp:Label ID="Label2" runat="server" Text="Öğrenci ID"></asp:Label>
        <asp:TextBox runat="server" CssClass="form-control" ID="TextBox1"></asp:TextBox>
    </div>

       <br />

       <asp:Button ID="Button1" runat="server" Text="Ders Talep Oluştur" CssClass="btn btn-warning" OnClick="Button1_Click"/>


   </form>


</asp:Content>


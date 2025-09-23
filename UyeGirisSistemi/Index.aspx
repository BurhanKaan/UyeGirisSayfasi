<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UyeGirisSistemi.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Assets/Css/IndexStyle.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="anaTasiyici">
            <div class="sol">
                <div class="baslik">
                    <h3>Hoşgeldiniz</h3>
                    <h4>Giriş Yapınız</h4>
                    <p>Sisteme giriş yapmak için doldurunuz.</p>
                </div>
                <div class="satir">
                    <asp:TextBox ID="tb_mail" runat="server" CssClass="metinkutu" placeholder="example@gmail.com"></asp:TextBox>
                </div>
                <div class="satir">
                    <asp:TextBox ID="tb_kadi" runat="server" CssClass="metinkutu" placeholder="Kullanıcı adınızı giriniz"></asp:TextBox>
                </div>
                <div class="satir">
                    <asp:TextBox ID="tb_sifre" runat="server" CssClass="metinkutu" TextMode="Password" placeholder="Şifrenizi girin"></asp:TextBox>
                </div>
                <div class="satir">
                    <asp:Button ID="btn_giris" runat="server" CssClass="Button" Text="Giriş Yap" OnClick="btn_giris_Click"/>
                </div>
                    <asp:Panel ID="pnl_mesaj" runat="server" CssClass="mesaj" Visible="false">
                        <asp:Label ID="lbl_mesaj" runat="server"></asp:Label>
                    </asp:Panel>
            </div>
            <div class="sag">
            </div>
            <div style="clear: both;"></div>
       </div>
    </form>
</body>
</html>

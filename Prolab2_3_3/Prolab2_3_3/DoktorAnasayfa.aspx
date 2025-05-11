<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoktorAnasayfa.aspx.cs" Inherits="Prolab2_3_3.DoktorAnasayfa" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Doktor Anasayfa</title>
    <style>
        .button-container {
     text-align: center;
     margin-top: 100px; /* Sayfanın üst kısmından 100px aşağıda yer alacak */
 }

 .big-button {
     width: 500px; /* Buton genişliği */
     height: 100px; /* Buton yüksekliği */
     margin: 10px; /* Butonlar arasında boşluk */
     font-size: 16px; /* Yazı boyutu */
     background-color: blue; /* Buton rengi */
     color: white; /* Yazı rengi */
 }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="button-container">
            <asp:Button ID="btnRandevuGoruntule" runat="server" Text="Randevularımı Görüntüle"  CssClass="big-button" OnClick="btnRandevuGoruntule_Click" />
            <br />
            <asp:Button ID="btnRaporSil" runat="server" Text="Rapor Sil" CssClass="big-button" OnClick="btnRaporSil_Click" />
            <br />
            <asp:Button ID="btnRaporEkle" runat="server" Text="Rapor Ekle" CssClass="big-button" OnClick="btnRaporEkle_Click" />
            <br />
            <asp:Button ID="btnRaporGuncelle" runat="server" Text="Rapor Güncelle" CssClass="big-button" OnClick="btnRaporGuncelle_Click" />
            <br />
            <asp:Button ID="btnDoktorBilgilerimiGuncelle" runat="server" Text="Bilgilerimi Güncelle" CssClass="big-button" OnClick="btnDoktorBilgilerimiGuncelle_Click" />
        </div>
    </form>
</body>
</html>

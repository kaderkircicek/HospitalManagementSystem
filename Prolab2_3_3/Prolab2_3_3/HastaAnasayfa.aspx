<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HastaAnasayfa.aspx.cs" Inherits="Prolab2_3_3.HastaAnasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        .container {
            display: flex;
            justify-content: space-between;
            margin-top: 50px;
            padding: 0 10%;
        }

        .section {
            width: 45%;
        }

        .section-title {
            font-size: 24px;
            font-weight: bold;
            margin-bottom: 20px;
            text-align: center;
        }

        .big-button {
            width: 100%;
            height: 100px;
            margin: 10px 0;
            font-size: 16px;
            background-color: blue;
            color: white;
        }

        .button-container {
            text-align: center;
        }

        .update-button-container {
            text-align: center;
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="section">
                <div class="section-title">Randevu ile İlgili İşlemler</div>
                <div class="button-container">
                    <asp:Button ID="btnRandevuOlustur" runat="server" Text="Randevu Oluştur" CssClass="big-button" OnClick="btnRandevuOlustur_Click" />
                    <br />
                    <asp:Button ID="btnRandevuIptalEt" runat="server" Text="Randevu İptal Et" CssClass="big-button" OnClick="btnRandevuIptalEt_Click" />
                    <br />
                    <asp:Button ID="btnRandevularimiGuncelle" runat="server" Text="Randevularımı Güncelle" CssClass="big-button" OnClick="btnRandevularimiGuncelle_Click" />
                    <br />
                    <asp:Button ID="btnRandevularimiGoruntule" runat="server" Text="Randevularımı Görüntüle" CssClass="big-button" OnClick="btnRandevularimiGoruntule_Click" />
                </div>
            </div>
            <div class="section">
                <div class="section-title">Rapor ile İlgili İşlemler</div>
                <div class="button-container">
                    <asp:Button ID="btnRaporlarimiGoruntule" runat="server" Text="Raporlarımı Görüntüle" CssClass="big-button" OnClick="btnRaporlarimiGoruntule_Click" />
                    <br />
                    <asp:Button ID="btnRaporEkle" runat="server" Text="Rapor Ekle" CssClass="big-button" OnClick="btnRaporEkle_Click" />
                    <br />
                    <asp:Button ID="btnRaporSil" runat="server" Text="Rapor Sil" CssClass="big-button" OnClick="btnRaporSil_Click" />
                    
                </div>
            </div>
        </div>
        <div class="update-button-container">
            <asp:Button ID="btnHastaBilgilerimiGuncelle" runat="server" Text="Hasta Bilgilerimi Güncelle" CssClass="big-button" OnClick="btnHastaBilgilerimiGuncelle_Click" />
        </div>
    </form>
</body>
</html>

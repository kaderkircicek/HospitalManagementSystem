<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HastaRandevularimiGoruntule.aspx.cs" Inherits="Prolab2_3_3.HastaRandevularimiGoruntule" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Hasta Randevularımı Görüntüleme</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="HastaAd" HeaderText="Hasta Adı" />
                    <asp:BoundField DataField="HastaSoyad" HeaderText="Hasta Soyadı" />
                    <asp:BoundField DataField="DoktorAd" HeaderText="Doktor Adı" />
                    <asp:BoundField DataField="DoktorSoyad" HeaderText="Doktor Soyadı" />
                    <asp:BoundField DataField="UzmanlikAlani" HeaderText="Uzmanlık Alanı" />
                    <asp:BoundField DataField="CalistigiHastane" HeaderText="Çalıştığı Hastane" />
                    <asp:BoundField DataField="RandevuTarihi" HeaderText="Randevu Tarihi" />
                    <asp:BoundField DataField="RandevuSaati" HeaderText="Randevu Saati" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>

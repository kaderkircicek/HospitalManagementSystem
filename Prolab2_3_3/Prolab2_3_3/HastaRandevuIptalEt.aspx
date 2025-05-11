<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HastaRandevuIptalEt.aspx.cs" Inherits="Prolab2_3_3.HastaRandevuIptalEt" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Randevu İptal Et</title>
</head>

<body>
    <div style="text-align: center;">
        <h2>Randevu İptal Etme</h2>
        <form id="form1" runat="server">
            <div>
                <label for="txtDoktorID"> Doktor ID:</label>
                <asp:TextBox ID="txtDoktorID" runat="server"></asp:TextBox>
            </div>
            <div style="margin-top: 10px;">
                <input type="checkbox" id="chkSorumluluk" />
                <label for="chkSorumluluk"> Silinecek randevuyla alakalı tüm sorumluluklar bana aittir.</label>
            </div>
            <div style="margin-top: 20px;">
                
            <asp:Button ID="btnRandevuSil" runat="server" Text="Randevu Sil" OnClick="btnRandevuSil_Click" />
            <asp:Label ID="lblMessage" runat="server" Visible="false"></asp:Label>
            </div>
        </form>
    </div>

</body>

</html>
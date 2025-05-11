<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoktorKendiBilgisiniGuncelleme.aspx.cs" Inherits="Prolab2_3_3.DoktorKendiBilgisiniGuncelleme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Doktor Güncelleme</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .form-container {
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            max-width: 400px;
            width: 100%;
        }
        .form-container h3 {
            margin-bottom: 20px;
            text-align: center;
            color: #333;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
            color: #555;
        }
        .form-group input {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }
        .form-group input:focus {
            border-color: #66afe9;
            outline: none;
            box-shadow: 0 0 5px rgba(102, 175, 233, 0.5);
        }
        .btn {
            background-color: #007bff;
            color: #fff;
            padding: 10px 15px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            width: 100%;
            text-align: center;
        }
        .btn:hover {
            background-color: #0056b3;
        }
        .alert {
            display: none;
            padding: 10px;
            margin-top: 15px;
            border-radius: 4px;
        }
        .alert.visible {
            display: block;
        }
        .alert-info {
            background-color: #d9edf7;
            color: #31708f;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="form-container">
        <h3> Bilgilerimi Güncelle </h3>
        
        <div class="form-group">
            <label for="txtDoktorAdi">Doktor Adı</label>
            <asp:TextBox ID="txtDoktorAdi" runat="server" placeholder="Doktor Adı"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtDoktorSoyadi">Doktor Soyadı</label>
            <asp:TextBox ID="txtDoktorSoyadi" runat="server" placeholder="Doktor Soyadı"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtUzmanlik">Uzmanlık</label>
            <asp:TextBox ID="txtUzmanlik" runat="server" placeholder="Uzmanlık"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtHastane">Hastane</label>
            <asp:TextBox ID="txtHastane" runat="server" placeholder="Hastane"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtSifre">Şifre</label>
            <asp:TextBox ID="txtSifre" runat="server" placeholder="Şifre" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="btnDoktorGuncelle" runat="server" Text="Doktor Güncelle" CssClass="btn" OnClick="btnDoktorGuncelle_Click" />
        <asp:Label ID="lblMessage" runat="server" CssClass="alert alert-info"></asp:Label>
    </form>
</body>
</html>

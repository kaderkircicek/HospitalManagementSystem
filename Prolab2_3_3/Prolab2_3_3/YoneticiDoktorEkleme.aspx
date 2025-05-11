<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YoneticiDoktorEkleme.aspx.cs" Inherits="Prolab2_3_3.YoneticiDoktorEkleme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Doktor Ekleme Formu</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f2f2f2;
        }
        .container {
            max-width: 400px;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        h3 {
            text-align: center;
            margin-bottom: 20px;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group input[type="text"], 
        .form-group input[type="password"] {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-sizing: border-box;
        }
        .form-group input[type="text"]:focus, 
        .form-group input[type="password"]:focus {
            outline: none;
            border-color: #007bff;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }
        .btn-submit {
            display: block;
            width: 100%;
            padding: 10px;
            border: none;
            border-radius: 5px;
            background-color: #007bff;
            color: #fff;
            font-size: 16px;
            cursor: pointer;
        }
        .btn-submit:hover {
            background-color: #0056b3;
        }
        .message {
            text-align: center;
            margin-top: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h3>Doktor Ekleme Formu</h3>
            <div class="form-group">
                <label for="txtDoktorAdi">Doktor Adı</label>
                <asp:TextBox ID="txtDoktorAdi" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtDoktorSoyadi">Doktor Soyadı</label>
                <asp:TextBox ID="txtDoktorSoyadi" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtUzmanlik">Uzmanlık</label>
                <asp:TextBox ID="txtUzmanlik" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtHastane">Hastane</label>
                <asp:TextBox ID="txtHastane" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtSifre">Şifre</label>
                <asp:TextBox ID="txtSifre" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <asp:Button ID="btnDoktorEkle" runat="server" Text="Doktor Ekle" CssClass="btn-submit" OnClick="btnDoktorEkle_Click" />
            <asp:Label ID="lblMessage" runat="server" CssClass="message" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>

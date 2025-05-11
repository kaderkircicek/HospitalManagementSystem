<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoktorRaporEkle.aspx.cs" Inherits="Prolab2_3_3.DoktorRaporEkle" %>

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
            <h3>Doktor Rapor Ekleme </h3>
            <div class="form-group">
                <label for="txtDoktorAdi">Doktor ID</label>
                <asp:TextBox type="text"  ID="txtDoktorId" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtDoktorSoyadi">Hasta ID</label>
                <asp:TextBox type="text" ID="txtHastaId" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtUzmanlik">Yönetici ID</label>
                <asp:TextBox type="text" ID="txtYoneticiId" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtHastane"> Tarih </label>
                <asp:TextBox ID="txtRandevuTarih" type="date" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtSifre">İçerik </label>
                <asp:TextBox ID="txtRaporIcerigi" runat="server"></asp:TextBox>
            </div>
              <div class="form-group">
      <label for="txtSifre">Resim Url  </label>
      <asp:TextBox ID="RaporUrl" runat="server" ></asp:TextBox>
  </div>
           
            <asp:Label ID="lblMessage" runat="server" CssClass="message" Visible="false"></asp:Label>
            <asp:Button ID="btnRaporEkle" runat="server" Text="Rapor Ekle" CssClass="btn-submit" OnClick="btnRaporEkle_Click" />
        </div>
    </form>
</body>
</html>

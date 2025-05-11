<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoktorGiris.aspx.cs" Inherits="Prolab2_3_3.DoktorGiris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Doktor Girişi</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            margin: 0;
            padding: 0;
        }
        .container {
            width: 400px;
            margin: 100px auto;
            background-color: #fff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px 0px rgba(0, 0, 0, 0.1);
        }
        h2 {
            text-align: center;
            color: #1164c0;
        }
        .inputField {
            width: 100%;
            padding: 10px;
            margin: 10px 0;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-sizing: border-box;
        }
        .submitButton {
            width: 100%;
            background-color: #1164c0;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        .submitButton:hover {
            background-color: #7a98c1;
        }
        .errorMessage {
           color: red;
           text-align: center;
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>DOKTOR GİRİŞİ</h2>
             <asp:TextBox runat="server" ID="txtUsername" CssClass="inputField" placeholder="Doktor Id" />
             <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="inputField" placeholder="Şifre" />
             <asp:Button runat="server" ID="btnLogin" Text="Giriş Yap" CssClass="submitButton" OnClick="btnLogin_Click" />
             <asp:Label runat="server" ID="lblError" CssClass="errorMessage" Visible="false" />
        </div>
    </form>
</body>
</html>

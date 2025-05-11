<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YoneticiDoktorSilme.aspx.cs" Inherits="Prolab2_3_3.YoneticiDoktorSilme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Doktor Silme</title>
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
        h2 {
            text-align: center;
            margin-bottom: 20px;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group input[type="text"] {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-sizing: border-box;
        }
        .form-group input[type="text"]:focus {
            outline: none;
            border-color: #007bff;
        }
        .btn-submit {
            display: block;
            width: 100%;
            padding: 10px;
            border: none;
            border-radius: 5px;
            background-color: #dc3545;
            color: #fff;
            font-size: 16px;
            cursor: pointer;
        }
        .btn-submit:hover {
            background-color: #c82333;
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
            <h2>Doktor Silme</h2>
            <div class="form-group">
                <asp:TextBox ID="TextDoktorId" runat="server" placeholder="Doktor Id"></asp:TextBox>
            </div>
            <asp:Button ID="btnDoktorSil" runat="server" Text="Doktor Sil" CssClass="btn-submit" OnClick="btnDoktorSil_Click" />
            <asp:Label ID="lblMessage" runat="server" CssClass="message" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>

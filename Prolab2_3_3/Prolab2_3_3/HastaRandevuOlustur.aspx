<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HastaRandevuOlustur.aspx.cs" Inherits="Prolab2_3_3.HastaRandevuOlustur" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Randevu Oluşturma İşlemi</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }

        .container {
            width: 50%;
            margin: 50px auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        .form-group {
            margin-bottom: 20px;
        }

        .form-group label {
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
        }

        .form-group input[type="text"], 
        .form-group input[type="password"] {
            width: calc(100% - 10px);
            padding: 10px;
            border-radius: 5px;
            border: 1px solid #ccc;
        }

        .button {
            display: inline-block;
            padding: 10px 20px;
            background-color: #007bff;
            color: #fff;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            text-decoration: none;
        }

        .button:hover {
            background-color: #0056b3;
        }

        /* Yeni stil */
        .footer-button {
            width: 100%;
            margin-top: 20px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Randevu Oluşturma İşlemi</h2>
          
          
            <div class="form-group">
                <label for="txtDoktorID">Doktor Id:</label>
                <input type="text" id="txtDoktorID" runat="server" required />
            </div>
            <div class="form-group">
                <label for="txtRandevuTarihi">Randevu Tarihi:</label>
                <input type="text" id="txtRandevuTarihi" runat="server" required />
            </div>
             <div class="form-group">
                <label for="txtRandevuSaati"> Randevu Saati:</label>
                <input type="text" id="txtRandevuSaati" runat="server" required />
             </div>

            <asp:Button ID="btnRandevuOLustur" runat="server" Text="Randevu Olustur" OnClick="btnRandevuOlustur_Click" />

            <asp:Label ID="lblMessage" runat="server" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
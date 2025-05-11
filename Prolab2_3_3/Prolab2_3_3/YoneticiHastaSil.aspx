<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YoneticiHastaSil.aspx.cs" Inherits="Prolab2_3_3.YoneticiHastaSil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Hasta Silme</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }

        .container {
            width: 50%;
            height: 50%;
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
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
        .form-group input[type="checkbox"] {
            width: calc(100% - 10px);
            padding: 10px;
            border-radius: 5px;
            border: 1px solid #ccc;
        }

        .button {
            display: inline-block;
            padding: 10px 20px;
            background-color: #dc3545;
            color: #fff;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            text-decoration: none;
        }

        .button:hover {
            background-color: #c82333;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2 style="text-align:center;">Hasta Silme İşlemi</h2>
            <div class="form-group">
                <label for="txtHastaId">Hasta ID:</label>
                <input type="text" id="txtHastaId" runat="server" required />
            </div>
            <div class="form-group">
                <label for="chkOnay">Tüm sorumluluk bana aittir.</label>
                <input type="checkbox" id="chkOnay" runat="server" />
            </div>
             <asp:Button ID="btnHastaSil" runat="server" Text="Hasta Sil" OnClick="btnHastaSil_Click" />
             <asp:Label ID="lblMessage" runat="server" Visible="false"></asp:Label>
        </div>
    </form>

    
</body>
</html>

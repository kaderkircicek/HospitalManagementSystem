<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YoneticiRaporSil.aspx.cs" Inherits="Prolab2_3_3.YoneticiRaporSil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>yonetici rapor  Silme</title>
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
          <div class="form-group">
      <label for="txtDoktorID">Rapor Id:</label>
      <input type="text" id="txtRaporID" runat="server" required />
  </div>
        <div>
             <asp:Button ID="btnRaporSil" runat="server" Text="Rapor Sil" OnClick="btnRaporSil_Click" />
             <asp:Label ID="lblMessage" runat="server" Visible="false"></asp:Label>
        </div>

    </form>
</body>
</html>

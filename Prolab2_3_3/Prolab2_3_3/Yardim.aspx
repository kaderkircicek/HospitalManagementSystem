<!DOCTYPE html>
<html lang="tr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>İletişim</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            margin: 0;
            padding: 0;
        }
        .container {
            max-width: 800px;
            margin: 50px auto;
            padding: 20px;
            background-color: #c2e5fa;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        h1, h2 {
            text-align: center;
            color: #007bff;
        }
        form {
            margin-top: 30px;
        }
        label {
            display: block;
            margin-bottom: 10px; /* Yeni eklenen satır */
            color: #000000;
        }
        input[type="text"], textarea {
            width: 100%;
            padding: 10px;
            margin-bottom: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-sizing: border-box;
        }
        input[type="submit"] {
            background-color: #007bff;
            color: #fff;
            border: none;
            padding: 12px 20px;
            border-radius: 5px;
            cursor: pointer;
        }
        input[type="submit"]:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>DESTEK VE YARDIM</h1>
        <form id="form1" runat="server">
            <label for="name">Adınız Soyadınız</label>
            <input type="text" id="name" name="name" required>

            <label for="email">E-posta Adresiniz</label>
            <input type="email" id="email" name="email" required>

            <label for="message">İletmek İstedikleriniz</label>
            <textarea id="message" name="message" rows="5" required></textarea>

            <input type="submit" value="Gönder">
        </form>
    </div>
</body>
</html>

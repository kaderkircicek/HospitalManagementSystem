<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        .container {
            display: flex;
            flex-direction: column;
            align-items: center;
            width: 80%;
            margin: 50px auto; 
        }

        .panel {
            width: 100%;
            padding: 20px;
            margin-bottom: 20px;
            box-sizing: border-box;
        }

        .button {
            display: block;
            width: 100%;
            padding: 10px 20px;
            margin-bottom: 10px;
            font-size: 18px;
            text-align: center;
            border-radius: 5px;
            cursor: pointer;
        }

        .button-blue {
            background-color: #007bff;
            color: #fff;
        }

        .button-red {
            background-color: #dc3545;
            color: #fff;
        }

        .button-green {
            background-color: #28a745;
            color: #fff;
        }

        .center-button {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="panel">
                <h2>Doktorlarla Alakalı İşlemler</h2>
                <a href="YoneticiDoktorEkleme.aspx" class="button button-blue">Doktor Ekle</a>
                <a href="YoneticiDoktorSilme.aspx" class="button button-red">Doktor Sil</a>
                <a href="YoneticiDoktorGuncelleme.aspx" class="button button-green">Doktor Bilgisi Güncelle</a>
            </div>
            <div class="panel">
                <h2>Hastalarla Alakalı İşlemler</h2>
                <a href="YoneticiHastaEkle.aspx" class="button button-blue">Hasta Ekle</a>
                <a href="YoneticiHastaSil.aspx" class="button button-red">Hasta Sil</a>
                <a href="YoneticiHastaBilgisiGuncelle.aspx" class="button button-green">Hasta Bilgisi Güncelle</a>
            </div>
             <div class="panel">
                <h2>Raporlarla Alakalı İşlemler</h2>
                <a href="YoneticiRaporEkle.aspx" class="button button-blue">Rapor Ekle</a>
                <a href="YoneticiRaporSil.aspx" class="button button-red">  Rapor Sil</a>
                <a href="YoneticiRaporBilgisiGuncelle.aspx" class="button button-green">Rapor Güncelle</a>
              </div>
                <div class="panel center-button">
                <a href="YoneticiKendiBilgisiniGuncelle.aspx" class="button button-blue">Yönetici Bilgilerimi Güncelle</a>
            </div>
        </div>
    </form>
</body>
</html>

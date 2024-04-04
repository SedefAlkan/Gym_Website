<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="antrenor.aspx.cs" Inherits="yazlab10.antrenor" %>

<!DOCTYPE html>
<html>
<head>
    <title>Profil Kartı</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <style>
        /* Simge çubuğu stilleri */
        .icon-bar {
            position: fixed;
            top: 0;
            width: 100%;
            background-color: #555;
            overflow: auto;
        }

        .icon-bar a {
            float: left;
            width: 20%;
            text-align: center;
            padding: 12px 0;
            transition: all 0.3s ease;
            color: white;
            font-size: 36px;
        }

        .icon-bar a:hover {
            background-color: #000;
        }

        .active {
            background-color: #04AA6D;
        }

        /* Profil kartı stilleri */
        body {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            padding-top: 60px; /* Simge çubuğu için boşluk bırak */
        }

        .profile-card {
            width: 300px;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 10px;
            background-color: #fff;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            text-align: center;
        }

        .profile-image {
            width: 150px;
            height: 150px;
            border-radius: 50%;
            overflow: hidden;
            margin: 0 auto 15px;
        }

        .profile-image img {
            width: 100%;
            height: 100%;
            object-fit: cover;
        }

        .profile-details {
            margin-bottom: 15px;
        }

        .profile-details h2 {
            margin-bottom: 5px;
            color: #333;
        }

        .profile-details p {
            color: #666;
            margin: 0;
        }
    </style>
</head>
<body>
      <div class="icon-bar">
    <form runat="server">

  <asp:LinkButton ID="lnkuser" runat="server" CssClass="icon-button" CommandArgument="user" OnCommand="IconCommand"><i class="fa fa-user"></i></asp:LinkButton>
<asp:LinkButton ID="lnkheartbeat" runat="server" CssClass="icon-button" CommandArgument="book" OnCommand="IconCommand"><i class="fa fa-book"></i></asp:LinkButton>
<asp:LinkButton ID="lnkenvelope" runat="server" CssClass="icon-button" CommandArgument="envelope" OnCommand="IconCommand"><i class="fa fa-envelope"></i></asp:LinkButton>
<asp:LinkButton ID="lnkcutlery" runat="server" CssClass="icon-button" CommandArgument="arrow-up" OnCommand="IconCommand"><i class="fa fa-arrow-up"></i></asp:LinkButton>
 <asp:LinkButton ID="lnkcog" runat="server" CssClass="icon-button" CommandArgument="cog" OnCommand="IconCommand"><i class="fa fa-times"></i></asp:LinkButton>
            
        </div>
</div>

    </div>
  <div class="profile-card">
                  <div class="profile-image">
    <i class="fa fa-user fa-5x"></i> <!-- Sporcu simgesi buraya eklendi -->
</div>
        <div class="profile-details">
            <h2>
                <asp:Label ID="lblAdSoyad" runat="server" Text=""></asp:Label>
            </h2>
            <p>
                <asp:Label ID="lblEposta" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="lblTelefon" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="lblDogumTarihi" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="lblilgialani" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <div id="bilgiGuncellemePaneli" class="panel hidden">
            <h2>Bilgileri Güncelle</h2>
            <div class="form-group">
                <label for="txtAd">Ad:</label>
                <asp:TextBox ID="txtAd" runat="server" CssClass="form-control" placeholder="Adınızı giriniz" />
            </div>
            <div class="form-group">
                <label for="txtSoyad">Soyad:</label>
                <asp:TextBox ID="txtSoyad" runat="server" CssClass="form-control" placeholder="Soyadınızı giriniz" />
            </div>
            <div class="form-group">
                <label for="txtEposta">E-posta:</label>
                <asp:TextBox ID="txtEposta" runat="server" CssClass="form-control" placeholder="E-posta adresinizi giriniz" />
            </div>
            <div class="form-group">
                <label for="txtTelefon">Telefon No:</label>
                <asp:TextBox ID="txtTelefon" runat="server" CssClass="form-control" placeholder="Telefon numaranızı giriniz" />
            </div>
            <div class="form-group">
                <label for="txtDogumTarihi">Doğum Tarihi:</label>
                <asp:TextBox ID="txtDogumTarihi" runat="server" CssClass="form-control" TextMode="Date" />
            </div>
            <div class="form-group">
                <label for="txtSifre">Şifre:</label>
                <asp:TextBox ID="txtSifre" runat="server" CssClass="form-control" placeholder="Şifrenizi giriniz" TextMode="Password" />
            </div>
            
            </div>
            <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
        </div>
    </div>
    </form>
</body>
</html>
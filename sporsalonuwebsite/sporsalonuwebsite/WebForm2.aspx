<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="yazlab10.WebForm2" %>
<!DOCTYPE html>
<html>
<head>
    <title>Profil Kartı</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

    <style>
        /* Genel stiller */
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding-top: 60px; /* Simge çubuğu için boşluk bırak */
        }

        /* Simge çubuğu stilleri */
        .icon-bar {
            position: fixed;
            top: 0;
            width: 100%;
            background-color: #555;
            overflow: auto;
            display: flex;
            justify-content: space-around;
            align-items: center;
            z-index: 999;
        }

        .icon-bar a {
            text-align: center;
            padding: 12px 0;
            transition: all 0.3s ease;
            color: white;
            font-size: 36px;
            text-decoration: none;
        }

        .icon-bar a:hover {
            background-color: #000;
        }

        .active {
            background-color: #04AA6D;
        }

        /* Profil kartı stilleri */
        .profile-card {
            width: 300px;
            margin: auto;
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

        /* Program seçim stilleri */
        .program-selection {
            text-align: center;
            margin-top: 20px;
        }

        .program {
            margin-bottom: 20px;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
            background-color: #fff;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }

        .program h4 {
            margin-bottom: 5px;
            color: #333;
        }

        .program p {
            color: #666;
            margin-bottom: 10px;
        }

        .program button {
            padding: 8px 16px;
            background-color: #04AA6D;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        .program button:hover {
            background-color: #fff;
            color: #04AA6D;
            border: 1px solid #04AA6D;
        }
    </style>
</head>
<body>
    <form runat="server">
      <div class="icon-bar">
    

    <asp:LinkButton ID="lnkuser" runat="server" CssClass="icon-button" CommandArgument="user" OnCommand="IconCommand"><i class="fa fa-user"></i></asp:LinkButton>
    <asp:LinkButton ID="lnkheartbeat" runat="server" CssClass="icon-button" CommandArgument="heartbeat" OnCommand="IconCommand"><i class="fa fa-heartbeat"></i></asp:LinkButton>
   <asp:LinkButton ID="lnkenvelope" runat="server" CssClass="icon-button" CommandArgument="envelope" OnCommand="IconCommand"><i class="fa fa-envelope"></i></asp:LinkButton>
    <asp:LinkButton ID="lnkcutlery" runat="server" CssClass="icon-button" CommandArgument="cutlery" OnCommand="IconCommand"><i class="fa fa-cutlery"></i></asp:LinkButton> <!-- Değişiklik burada yapıldı -->
    <asp:LinkButton ID="lnkcog" runat="server" CssClass="icon-button" CommandArgument="cog" OnCommand="IconCommand"><i class="fa fa-times"></i></asp:LinkButton>
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
     <asp:Label ID="lblbasvuru" runat="server" Text=""></asp:Label>
   </p>
      <p>
  <asp:Label ID="lblkilo" runat="server" Text=""></asp:Label>

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
        <label for="txtSifre">Şifre:</label>
        <asp:TextBox ID="txtSifre" runat="server" CssClass="form-control" placeholder="Şifrenizi giriniz" TextMode="Password" />
    </div>
    <div class="form-group">
        <label for="txtDogumTarihi">Doğum Tarihi:</label>
        <asp:TextBox ID="txtDogumTarihi" runat="server" CssClass="form-control" TextMode="Date" />
    </div>
    <div class="form-group">
        <label for="txtTelefon">Telefon No:</label>
        <asp:TextBox ID="txtTelefon" runat="server" CssClass="form-control" placeholder="Telefon numaranızı giriniz" />
  <div class="form-group">
     <label for="txtkilo">Güncel Kilo:</label>
     <asp:TextBox ID="txtkilo" runat="server" CssClass="form-control"  placeholder="Güncel kilonuzu giriniz" />
 </div>
   


    <div class="form-group">
      <label for="txtIlgiAlanlari">İlgi Alanları:</label>
      <asp:TextBox ID="txtIlgiAlanlari" runat="server" CssClass="form-control" placeholder="İlgi alanlarınızı virgül ile ayırarak giriniz" />
    </div>
    <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
  </div>
</div>

    </form>
</div>
 
    
</body>
</html>



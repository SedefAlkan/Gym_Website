<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kayit.aspx.cs" Inherits="yazlab10.kayit" EnableEventValidation="false" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .navbar-header {
            height: 130px;
            margin-left: 713px;
        }
        .active {
            height: 29px;
            margin-left: 682px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;</div>
        <p>
            &nbsp;</p>
    </body>
    
<head>
  <!-- Theme Made By www.w3schools.com - No Copyright -->
  <title>Bootstrap Theme The Band</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <link href="https://fonts.googleapis.com/css?family=Lato" rel="stylesheet" type="text/css">
  <link href="https://fonts.googleapis.com/css?family=Montserrat" rel="stylesheet" type="text/css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
  <style>
  body {
    font: 400 15px/1.8 Lato, sans-serif;
    color: #777;
  }
  h3, h4 {
    margin: 10px 0 30px 0;
    letter-spacing: 10px;      
    font-size: 20px;
    color: #111;
  }
  .container {
    padding: 80px 120px;
  }
  .person {
    border: 10px solid transparent;
    margin-bottom: 25px;
    width: 80%;
    height: 826px;
    opacity: 0.7;
          margin-right: 0px;
          margin-top: 0px;
      }
  .person:hover {
    border-color: #f1f1f1;
  }
  .carousel-inner img {
    -webkit-filter: grayscale(90%);
    filter: grayscale(90%); /* make all photos black and white */ 
    width: 100%; /* Set width to 100% */
    margin: auto;
  }
  .carousel-caption h3 {
    color: #fff !important;
  }
  @media (max-width: 600px) {
    .carousel-caption {
      display: none; /* Hide the carousel text when the screen is less than 600 pixels wide */
    }
  }
  .bg-1 {
    background: #2d2d30;
    color: #bdbdbd;
  }
  .bg-1 h3 {color: #fff;}
  .bg-1 p {font-style: italic;}
  .list-group-item:first-child {
    border-top-right-radius: 0;
    border-top-left-radius: 0;
  }
  .list-group-item:last-child {
    border-bottom-right-radius: 0;
    border-bottom-left-radius: 0;
  }
  .thumbnail {
    padding: 0 0 15px 0;
    border: none;
    border-radius: 0;
  }
  .thumbnail p {
    margin-top: 15px;
    color: #555;
  }
  .btn {
    padding: 10px 20px;
    background-color: #333;
    color: #f1f1f1;
    border-radius: 0;
    transition: .2s;
  }
  .btn:hover, .btn:focus {
    border: 1px solid #333;
    background-color: #fff;
    color: #000;
  }
  .modal-header, h4, .close {
    background-color: #333;
    color: #fff !important;
    text-align: center;
    font-size: 30px;
  }
  .modal-header, .modal-body {
    padding: 40px 50px;
  }
  .nav-tabs li a {
    color: #777;
  }
  #googleMap {
    width: 100%;
    height: 400px;
    -webkit-filter: grayscale(100%);
    filter: grayscale(100%);
  }  
  .navbar {
    font-family: Montserrat, sans-serif;
    margin-bottom: 0;
    background-color: #2d2d30;
    border: 0;
    font-size: 11px !important;
    letter-spacing: 4px;
    opacity: 0.9;
  }
  .navbar li a, .navbar .navbar-brand { 
    color: #d5d5d5 !important;
  }
  .navbar-nav li a:hover {
    color: #fff !important;
  }
  .navbar-nav li.active a {
    color: #fff !important;
    background-color: #29292c !important;
  }
  .navbar-default .navbar-toggle {
    border-color: transparent;
  }
  .open .dropdown-toggle {
    color: #fff;
    background-color: #555 !important;
  }
  .dropdown-menu li a {
    color: #000 !important;
  }
  .dropdown-menu li a:hover {
    background-color: red !important;
  }
  footer {
    background-color: #2d2d30;
    color: #f5f5f5;
    padding: 32px;
  }
  footer a {
    color: #f5f5f5;
  }
  footer a:hover {
    color: #777;
    text-decoration: none;
  }  
  .form-control {
    border-radius: 0;
  }
  textarea {
    resize: none;
  }
  </style>
</head>
<body id="myPage" data-spy="scroll" data-target=".navbar" data-offset="50">

<nav class="navbar navbar-default navbar-fixed-top">
 <div class="container-fluid">
  <div class="navbar-header">
   <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
    <span class="icon-bar"></span>
    <span class="icon-bar"></span>
    <span class="icon-bar"></span>             
   </button>
   &nbsp;<div>
      <span style="mso-spacerun:'yes';font-size:14pt;font-family:TimesNewRomanPS-BoldMT;color:rgb(0,0,0);font-weight:bold;">FitLife</span></div>
  </div>
  <div class="collapse navbar-collapse" id="myNavbar">
   <ul class="nav navbar-nav navbar-right">
       <li><a href="giris.aspx">Giriş</a></li>
    <li><a href="#band">Danışanlarımız</a></li>
    <li><a href="#tour">İletişim</a></li>
    
   </ul>
   <ul class="nav navbar-nav navbar-right">
    <li><a href="#"><span class="glyphicon glyphicon-search"></span></a></li>
   </ul>
  </div>
 </div>
</nav>

<div id="myCarousel" class="carousel slide" data-ride="carousel">
    <!-- Indicators -->
    <ol class="carousel-indicators">
      <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
      <li data-target="#myCarousel" data-slide-to="1"></li>
      <li data-target="#myCarousel" data-slide-to="2"></li>
    </ol>

    <!-- Wrapper for slides -->
    <div class="carousel-inner" role="listbox">
      <div class="item active">
        <img src="ny.jpg" alt="New York" width="1200" height="700">
        <div class="carousel-caption">
          <h3>New York</h3>
          <p>The atmosphere in New York is lorem ipsum.</p>
        </div>      
      </div>

      <div class="item">
        <img src="chicago.jpg" alt="Chicago" width="1200" height="700">
        <div class="carousel-caption">
          <h3>Chicago</h3>
          <p>Thank you, Chicago - A night we won't forget.</p>
        </div>      
      </div>
    
      <div class="item">
        <img src="la.jpg" alt="Los Angeles" width="1200" height="700">
        <div class="carousel-caption">
          <h3>LA</h3>
          <p>Even though the traffic was a mess, we had the best time playing at Venice Beach!</p>
        </div>      
      </div>
    </div>

    <!-- Left and right controls -->
    <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
      <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
      <span class="sr-only">Previous</span>
    </a>
    <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
      <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
      <span class="sr-only">Next</span>
    </a>
</div>

<!-- Container (The Band Section) -->
<div id="band" class="container text-center">
  <h3>FİTLİFE</h3>
  <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em><span style="color: rgb(101, 102, 106); font-family: roboto-regular; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">İster yeni spor alışkanlığı kazanmak isteyen biri ol, ister yarışmaya hazırlanan ileri seviye bir sporcu; sana ve hedeflerine özel hazırlanan antrenmanları en doğru şekilde yapmanı sağlayacak eğitmen yanı başında. Kişisel Eğitmenin, sadece antrenman sırasında değil, günün geri kalanında da seni yönlendirerek en doğru dinlenme ve beslenmeyle tüm yaşam performansını iyileştirmeye destek olacak. Kulübündeki kişisel eğitmenleri görmek ve özel ders için 
      iletişime geçmek için Fitlife ailesine katıl.</span></em></p>
    <h2 class="font-weight-bold wow fadeInUp" style="box-sizing: border-box; margin-top: 0px; margin-bottom: 0px; font-family: &quot;Bree Serif&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, &quot;Bree Serif&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-weight: 700; line-height: 1.25; color: rgb(21, 21, 21); font-size: 48px; letter-spacing: 0.025em; text-transform: uppercase; animation-name: fadeInUp; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; orphans: 2; text-align: center; text-indent: 0px; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; visibility: visible;">PROFESYONEL EKİBİMİZ</h2>
  <br>
  <div class="row">
    <div class="col-sm-4">
      <p class="text-center">Metehan Celep</p>
        <br>
        <a href="#demo" data-toggle="collapse">
        &nbsp;</a><div id="demo" class="collapse">
        <p>Guitarist and Lead Vocalist</p>
        <p>Loves long walks on the beach</p>
        <p>Member since 1988</p>
      </div>
    </div>
    <div class="col-sm-4">
        Buse Salı<br />
        <br />
        <br>
    </div>
    <div class="col-sm-4">
      <p class="text-center">Emir Göktaş</p>
        <p class="text-center">&nbsp;</p><br>
        <a href="#demo3" data-toggle="collapse">
        &nbsp;</a><div id="demo3" class="collapse">
        <p>Bass player</p>
        <p>Loves math</p>
        <p>Member since 2005</p>
      </div>
    </div>
  </div>
</div>
    <div id="tour" class="bg-1">
  
  <!-- Modal -->
  <div class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog">
    
      <!-- Modal content-->
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">×</button>
          <h4><span class="glyphicon glyphicon-lock"></span> Tickets</h4>
        </div>
        <div class="modal-body">
            <div class="form-group">
              <label for="psw"><span class="glyphicon glyphicon-shopping-cart"></span> Tickets, $23 per person</label>
              <input type="number" class="form-control" id="psw" placeholder="How many?">
            </div>
            <div class="form-group">
              <label for="usrname"><span class="glyphicon glyphicon-user"></span> Send To</label>
              <input type="text" class="form-control" id="usrname" placeholder="Enter email">
            </div>
              <button type="submit" class="btn btn-block">Pay 
                <span class="glyphicon glyphicon-ok"></span>
              </button>
        </div>
        <div class="modal-footer">
          <button type="submit" class="btn btn-danger btn-default pull-left" data-dismiss="modal">
            <span class="glyphicon glyphicon-remove"></span> Cancel
          </button>
          <p>Need <a href="#">help?</a></p>
        </div>
      </div>
    </div>
  </div>
</div>
            <form action="action_page.php">
<div class="window" style="width: 500px; height: 500px; margin: 0 auto;">
  <div class="container">
    <h1>Kayıt</h1>
    <p>Hesap oluşturmak için lütfen formu doldurun.</p>
    <hr>
    <div class="mb-3">
      Ad <asp:Literal ID="ltAdkayıt" runat="server"></asp:Literal>
    </div>
    <div class="mb-3">
      Soyad <asp:Literal ID="ltsoyadkayıt" runat="server"></asp:Literal>
    </div>
    <div class="mb-3">
      E-posta <asp:Literal ID="ltEmailkayıt" runat="server"></asp:Literal>
    </div>
    <div class="mb-3">
      Şifre <asp:Literal ID="ltPassword" runat="server"></asp:Literal>
    </div>
    <div class="mb-3">
      Şifreyi tekrar girin <asp:Literal ID="ltRepeatPassword" runat="server"></asp:Literal>
    </div>
    <div class="mb-3">
      Doğum Tarihi <asp:Literal ID="ltdogumkayıt" runat="server"></asp:Literal>
    </div>
    <div class="mb-3">
      Telefon Numarası <asp:Literal ID="lttelefonkayıt" runat="server"></asp:Literal>
    </div>
       <div class="mb-3">
   Mevcut Kilo <asp:Literal ID="ltkilokayıt" runat="server"></asp:Literal>
 </div>
 
      <div class="mb-3">
     <select id="basvurmaSebebi" name="basvurmaSebebi" class="form-control" required>
    <option value="">Başvurma Sebebi Seçin</option>
    <option value="Kilo Alma">Kilo Alma</option>
    <option value="Kilo Verme">Kilo Verme</option>
    <option value="Fitness">Fitness</option>
</select><br />
</div>
   
    <asp:Button ID="btnRegister" runat="server" Text="Kayıt Ol" CssClass="registerbtn" OnClick="btnRegister_Click" />
  </div>
</div>

</form>
<!-- Container (Contact Section) -->
<div id="contact" class="container">
  <h3 class="text-center">İLETİŞİM</h3>
    <p class="text-center">Bizimle iletişime geçin</p>

  <div class="row">
    <div class="col-md-4">
      <p>&nbsp;</p>
      <p>Kocaeli,Türkiye</p>
      <p><span class="glyphicon glyphicon-phone"></span>Phone: +00 1515151515</p>
      <p><span class="glyphicon glyphicon-envelope"></span>Email: sedef.alkan123@hotmail.com</p>
    </div>
    <div class="col-md-8">
      <div class="row">
 <div class="col-sm-6 form-group">
    <asp:Literal ID="ltAd" runat="server"></asp:Literal>
   
</div>
<div class="col-sm-6 form-group">
    <asp:Literal ID="ltEmail" runat="server"></asp:Literal>
  
</div>
<asp:Literal ID="ltComments" runat="server"></asp:Literal>

<br>

    </div>
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:Button ID="gonderbuton" runat="server" Height="43px" OnClick="Button1_Click" Text="Gönder" Width="83px" />
&nbsp;&nbsp;&nbsp;
  </div>
</div>

</body>
    </form>
</html>
</html>

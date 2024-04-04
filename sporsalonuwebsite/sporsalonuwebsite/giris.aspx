<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="giris.aspx.cs" Inherits="yazlab10.giris" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <style>
        /* Özel CSS stilleri */
        body {
            background-color: #f8f9fa;
            font-family: Arial, sans-serif;
        }
        .custom-form {
            max-width: 400px;
            margin: auto;
            margin-top: 50px;
            background-color: #fff;
            border-radius: 10px;
            padding: 20px;
            box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
        }
        .form-title {
            text-align: center;
            margin-bottom: 30px;
        }
        .form-control {
            width: 100%;
            margin-bottom: 15px;
        }
        .btn-primary {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-6">
                    <h1 class="text-center mt-5">Hoş Geldiniz!</h1>
                    <div class="card custom-form">
                        <h5 class="card-title form-title">Giriş Formu</h5>
                        <div class="card-body">
                            <div class="mb-3">
                                <asp:TextBox ID="txtEposta" runat="server" CssClass="form-control" placeholder="E-posta adresinizi girin" TextMode="Email" Required="true"></asp:TextBox>
                            </div>
                            <div class="mb-3">
                                <asp:TextBox ID="txtSifre" runat="server" CssClass="form-control" TextMode="Password" placeholder="Şifrenizi girin" Required="true"></asp:TextBox>
                            </div>
                            <asp:Button ID="btnGiris" runat="server" Text="Giriş Yap" CssClass="btn btn-primary" OnClick="btnGiris_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

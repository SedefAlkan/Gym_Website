<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="eslesme.aspx.cs" Inherits="yazlab10.eslesme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Danışanlar Listesi</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }
        .header {
            background-color: #3498db;
            color: #fff;
            text-align: center;
            padding: 20px 0;
            margin-bottom: 20px;
        }
        .container {
            width: 80%;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .label {
            font-size: 18px;
            font-weight: bold;
            margin-bottom: 10px;
        }
        .danisanlarListesi {
            padding: 10px;
            border: 1px solid #ddd;
            border-radius: 5px;
            margin-bottom: 20px;
        }
        .egzersizProgramlari {
            text-align: center;
            margin-top: 20px;
            padding: 20px;
            background-color: #fff;
            border-radius: 5px;
            box-shadow: 0 0 8px rgba(0, 0, 0, 0.1);
        }
        #lblEgzersizProgramlari {
            width: 100%;
            height: auto;
            display: block;
            padding: 10px;
            background-color: #ffc0cb;
            border-radius: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <h1>Danışanlar Listesi</h1>
        </div>
        <div class="container">
            <div class="danisanlarListesi">
                <asp:Label ID="Label1" runat="server" CssClass="label"></asp:Label>
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <!-- C# tarafından oluşturulacak veri buraya yerleştirilecek -->
            </div>
            <div class="egzersizProgramlari">
                <h2>Seçilen Egzersiz Programları</h2>
                <asp:Label ID="lblEgzersizProgramlari" runat="server"></asp:Label>
                <!-- Seçilen egzersiz programları buraya eklenecek -->
            </div>
        </div>
    </form>
</body>
</html>

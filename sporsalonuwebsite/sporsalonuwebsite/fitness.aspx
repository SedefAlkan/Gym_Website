<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fitness.aspx.cs" Inherits="yazlab10.fitness" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <title>FitLife - Egzersiz Programı Seç</title>
  <style>
    /* Stillemeler burada yapılabilir */
    body {
      font-family: Arial, sans-serif;
      margin: 0;
      padding: 0;
      background-color: #f4f4f4;
    }
    .container {
      width: 80%;
      margin: auto;
      overflow: hidden;
    }
    header {
      background: #333;
      color: #fff;
      padding-top: 30px;
      min-height: 70px;
      border-bottom: #eee 4px solid;
    }
    header #logo {
      float: left;
      display: inline;
      margin: 0;
      padding: 0;
    }
    header nav {
      float: right;
      display: inline;
      margin: 0;
      padding: 0;
    }
    header nav ul {
      margin: 0;
      padding: 0;
      list-style: none;
    }
    header nav ul li {
      display: inline;
      margin: 0 20px 0 20px;
    }
    header nav ul li a {
      color: #fff;
      text-decoration: none;
      text-transform: uppercase;
      font-size: 16px;
    }
    .main {
      padding: 20px;
    }
    .exercise-list {
      display: flex;
      flex-wrap: wrap;
      gap: 20px;
    }
    .exercise-card {
      width: calc(33.33% - 20px);
      background-color: #fff;
      border: 1px solid #ddd;
      padding: 15px;
      border-radius: 5px;
      box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
      transition: all 0.3s ease-in-out;
    }
    .exercise-card:hover {
      transform: translateY(-5px);
      box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    }
    .exercise-card h3 {
      margin-top: 0;
    }
    .exercise-card p {
      color: #555;
    }
    .exercise-card button {
      padding: 8px 16px;
      background-color: #333;
      color: #fff;
      border: none;
      border-radius: 3px;
      cursor: pointer;
      transition: background-color 0.3s ease-in-out;
    }
    .exercise-card button:hover {
      background-color: #444;
    }
  </style>
</head>
<body>

  <header>
    <div class="container">
      <h1 id="logo">FitLife</h1>
      <nav>
        <ul>
          
        </ul>
      </nav>
    </div>
  </header>
     <form id="form1" runat="server">

  <div class="container main">
    <h2>Egzersiz Programları</h2>
    <div class="exercise-list">
      <div class="exercise-card">
        <asp:Label ID="fitnessprog1Label" runat="server"></asp:Label>
         <asp:Button ID="fitnessprog1Button" runat="server" Text="Seç" OnClick="fitnessprog1Button_Click" CssClass="exercise-button" />
      </div>
      <div class="exercise-card">
        <asp:Label ID="fitnessprog2Label" runat="server"></asp:Label>
        <asp:Button ID="fitnessprog2Button" runat="server" Text="Seç" OnClick="fitnessprog2Button_Click" CssClass="exercise-button" />
      </div>
      <div class="exercise-card">
        <asp:Label ID="fitnessprog3Label" runat="server"></asp:Label>
        <asp:Button ID="fitnessprog3Button" runat="server" Text="Seç" OnClick="fitnessprog3Button_Click" CssClass="exercise-button" />
      </div>
      <!-- Dilediğiniz kadar egzersiz programı ekleyebilirsiniz -->
    </div>
  </div>
 </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VisualizarVeiculo.aspx.cs" Inherits="Oficina3B17.UI.VisualizarVeiculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ursinhos são carinhosos?</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>

    <link rel="stylesheet" href="StyleSheet1.css"></link>
</head>
<body>
    <div class="container">
    <form id="form1" runat="server">
         <asp:Label ID="Label1" runat="server" Text="Placa"></asp:Label>
            <br />
            <asp:TextBox ID="txtPlaca" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Ano"></asp:Label>
            <br />
            <asp:TextBox ID="txtAno" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Cor" ></asp:Label>
            <br />
            <asp:TextBox ID="txtCor" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Dono" ></asp:Label>
            <br />
            <asp:DropDownList ID="dplDono" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Modelo" ></asp:Label>
            <br />
            <asp:DropDownList ID="dplModelo" runat="server">
            </asp:DropDownList>
    </form>

  </div>
</body>
</html>

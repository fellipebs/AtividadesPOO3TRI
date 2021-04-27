<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Oficina3B17.UI.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>Login Monstro</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>

    <link rel="stylesheet" href="StyleSheet1.css"></link>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
        <asp:Label ID="Label1" runat="server" Text="Digite seu login:"></asp:Label><br />
        <asp:TextBox ID="txtLogin" runat="server" style="margin-bottom: 1px" CssClass="form-control"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Digite sua senha:"></asp:Label><br />
        <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:Button ID="btnLogar" runat="server" Text="Continuar" OnClick="btnLogar_Click" CssClass="btn btn-primary"/>
        </div>
    </form>
</body>
</html>

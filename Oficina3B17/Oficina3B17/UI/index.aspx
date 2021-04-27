<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Oficina3B17.UI.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>Logado estou!</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>

    <link rel="stylesheet" href="StyleSheet1.css"></link>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <center>Você está logado</center>
            <br /><br />

         </div>
      <div class="container">
        <div class="row">
            <div class="col-md-3">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Pular Fora dessa conta" CssClass="btn btn-danger"/>
            </div>
            <div class="col-md-3">
                <asp:Button ID="Button2" runat="server" Text="Pular para dentro de funcionario" OnClick="Button2_Click" CssClass="btn btn-success"/>
            </div>
            <div class="col-md-3">
                <asp:Button ID="Button3" runat="server" Text="Pular para dentro de produto" OnClick="Button3_Click" CssClass="btn btn-warning"/>
             </div>
            <div class="col-md-3">
                <asp:Button ID="Button4" runat="server" Text="Pular para dentro de veiculos" OnClick="Button4_Click" CssClass="btn btn-primary"/>
            </div>
        </div>
     </div>
    </form>
</body>
</html>

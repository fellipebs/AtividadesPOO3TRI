<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProduto.aspx.cs" Inherits="Oficina3B17.UI.frmProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>Ursinhos não tão Carinhosos</title>
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
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
            <br />
            <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
            <br /><asp:Label ID="Label2" runat="server" Text="Preco"></asp:Label>
            <br />
            <asp:TextBox ID="txtPreco" runat="server" CssClass="form-control"></asp:TextBox>
            <br /><asp:Label ID="Label3" runat="server" Text="Quantidade Estoque"></asp:Label>
            <br />
            <asp:TextBox ID="txtQtdEstoque" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Cadastrar" OnClick="Button1_Click" CssClass="btn btn-primary" Width="100%"/>
        <br />
        <asp:GridView ID="GridView1" runat="server" OnRowEditing="GridView1_RowEditing"
                                                    OnRowUpdating="GridView1_RowUpdating"
                                                    OnRowDeleting="GridView1_RowDeleting"
                                                    OnRowCancelingEdit="GridView1_RowCancelingEdit">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </form>
    </div>
</body>
</html>

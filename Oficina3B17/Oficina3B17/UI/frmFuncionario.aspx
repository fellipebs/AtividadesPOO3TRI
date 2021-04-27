<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmFuncionario.aspx.cs" Inherits="Oficina3B17.UI.frmFormulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ursinhos Carinhosos</title>
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
            <asp:label runat="server" text="Digite o bendito id:"></asp:label>
            <br />
            <asp:TextBox ID="txtID" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:label runat="server" text="Digite o bendito nome:"></asp:label>
            <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:label runat="server" text="Selecione a bendita data:"></asp:label>
            <br />
            <center>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </center>
             <asp:label runat="server" text="Digite o bendito telefone:"></asp:label>
            <asp:TextBox ID="txtTelefone" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:label runat="server" text="Digite o bendito cpf:"></asp:label>
            <asp:TextBox ID="txtCpf" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Gravar" class="btn btn-primary" Width="100%" OnClick="btnCadastrar_Click"/>
        <br /><br />
        <center>
        <asp:GridView ID="GridView1" CssClass="table" runat="server" OnRowEditing="GridView1_RowEditing"
                                                    OnRowUpdating="GridView1_RowUpdating"
                                                    OnRowDeleting="GridView1_RowDeleting"
                                                    OnRowCancelingEdit="GridView1_RowCancelingEdit">
            <Columns>
                <asp:CommandField ButtonType="Button" ShowEditButton="True"  />
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        </center>
            </div>
    </form>
</body>
</html>


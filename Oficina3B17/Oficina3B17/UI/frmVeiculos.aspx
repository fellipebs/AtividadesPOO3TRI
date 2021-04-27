<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmVeiculos.aspx.cs" Inherits="Oficina3B17.UI.frmVeiculos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ursinhos não tão Carinhosos como parecem</title>
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
            <asp:Label ID="Label1" runat="server" Text="Placa"></asp:Label>
            <br />
            <asp:TextBox ID="txtPlaca" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Ano"></asp:Label>
            <br />
            <asp:TextBox ID="txtAno" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Cor" ></asp:Label>
            <br />
            <asp:TextBox ID="txtCor" runat="server" CssClass="form-control"></asp:TextBox>
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
            <br />
            <br />
            <asp:Button ID="btnGrava" runat="server" Text="Gravar" class="btn btn-primary" Width="100%" OnClick="btnGrava_Click" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting" OnRowCancelingEdit="GridView1_RowCancelingEdit">
                <Columns>
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                    <asp:TemplateField HeaderText="Selecionares">
                        <ItemTemplate>
                            <a href="VisualizarVeiculo.aspx?id=<%#Eval("id")%>">Details</a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
           
      </div>
    </form>
</body>
</html>

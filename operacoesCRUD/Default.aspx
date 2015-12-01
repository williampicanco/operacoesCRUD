<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="operacoesCRUD.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Operaçãoes para Tipo de Pessoa: </h1>
    </div>
        <asp:Label ID="Label1" runat="server" Text="Código:"></asp:Label>
        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Descrição:"></asp:Label>
        <asp:TextBox ID="txtDescricao" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Sigla:"></asp:Label>
        <asp:TextBox ID="txtSigla" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <asp:Button ID="btnBuscar" runat="server" OnClick="Button1_Click" Text="Buscar" />
        <asp:Button ID="btnCriar" runat="server" Enabled="False" Text="Criar" OnClick="btnCriar_Click" />
        <asp:Button ID="btnAtualizar" runat="server" Enabled="False" Text="Atualizar" OnClick="btnAtualizar_Click" />
        <asp:Button ID="btnExcluir" runat="server" Enabled="False" Text="Excluir" OnClick="btnExcluir_Click" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
        <br />
        <asp:Label ID="lblMensagem" runat="server" ForeColor="Red"></asp:Label>
        <asp:GridView ID="grdViewTipoPessoa" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="codigo" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None" Width="315px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="codigo" HeaderText="codigo" ReadOnly="True" SortExpression="codigo" />
                <asp:BoundField DataField="descricao" HeaderText="descricao" SortExpression="descricao" />
                <asp:BoundField DataField="sigla" HeaderText="sigla" SortExpression="sigla" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:empresaConnectionString %>" SelectCommand="SELECT [codigo], [descricao], [sigla] FROM [tipo_de_pessoa] ORDER BY [descricao]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="DataSourceDeTodosOsTiposDePessoas" runat="server" OnSelecting="DataSourceDeTodosOsTiposDePessoas_Selecting"></asp:SqlDataSource>
    </form>
</body>
</html>

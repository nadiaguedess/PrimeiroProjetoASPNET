<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Acessorio.aspx.cs" Inherits="PrimeiroProjetoASPNET.Acessorio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       
    
    </div>
         Id:<asp:TextBox ID="txtid" runat="server"></asp:TextBox>
        <br />
        Nome:<asp:TextBox ID="txtnome" runat="server"></asp:TextBox>
        <br />
        Preço:<asp:TextBox ID="txtpreco" runat="server"></asp:TextBox>
        <br />
        Modelo:<asp:TextBox ID="txtmodelo" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btngravar" runat="server" Text="Gravar" OnClick="btngravar_Click" />
        <asp:Button ID="btnexcluir" runat="server" Text="Excluir" OnClick="btnexcluir_Click" />
        <asp:Button ID="btnlimpar" runat="server" Text="Limpar" OnClick="btnlimpar_Click" />
        <br />
        <br />
        <asp:GridView ID="GridAcessorios" runat="server" OnSelectedIndexChanged="GridAcessorios_SelectedIndexChanged" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Width="532px">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
    </form>
</body>
</html>

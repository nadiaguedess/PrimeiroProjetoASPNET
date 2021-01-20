<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PrimeiroProjetoASPNET.Menu" %>

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
        <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="Black" Font-Bold="True" Font-Overline="False" Font-Size="30pt" OnClick="LinkButton1_Click">Cadastrar Clientes</asp:LinkButton><br />
        <asp:LinkButton ID="LinkButton2" runat="server" ForeColor="Black" Font-Bold="True" Font-Overline="False" Font-Size="30pt" OnClick="LinkButton2_Click">Acessórios</asp:LinkButton>
    </form>
</body>
</html>

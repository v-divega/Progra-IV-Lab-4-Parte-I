
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridSimple.aspx.cs" Inherits="WebFerretería.GridSimple" EnableEventValidation="False" %>

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
        <asp:GridView ID="gridFactura" runat="server" AutoGenerateColumns="false" DataKeyNames ="idFactura" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="gridHerramienta_RowDataBound" OnSelectedIndexChanged="gridHerramienta_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="idFactura" HeaderText="ID de la factura" />
                <asp:BoundField DataField="numLinea" HeaderText="Linea" />
                <asp:BoundField DataField="codProducto" HeaderText="Codigo" />
                <asp:BoundField DataField="detProducto" HeaderText="Detalle" />
                <asp:BoundField DataField="cantProducto" HeaderText="Cantidad" />
                <asp:BoundField DataField="costUnitario" HeaderText="Costo" />
                <asp:BoundField DataField="totalLinea" HeaderText="Linea total" />
            </Columns>
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <br />
        <table>
            <tr>
                <td>ID</td>
                <td><asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Linea</td>
                <td><asp:TextBox ID="txtnumLinea" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Codigo</td>
                <td><asp:TextBox ID="txtcodProducto" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Detalle</td>
                <td><asp:TextBox ID="txtdetProducto" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Cantidad</td>
                <td><asp:TextBox ID="txtcantProducto" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Costo</td>
                <td><asp:TextBox ID="txtcostUnitario" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>LineaTotal</td>
                <td><asp:TextBox ID="txttotalLinea" runat="server"></asp:TextBox></td>
            </tr>
        </table>
    </form>
</body>
</html>

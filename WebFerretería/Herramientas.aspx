<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Herramientas.aspx.cs" Inherits="WebFerretería.Herramientas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ferretería</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Actualizar la base de datos</h1>
            <div><asp:Label runat ="server" ID="lblCod">Ingrese el código de la herramienta</asp:Label></div>
            <div><asp:TextBox runat="server" ID="txtCodHerramienta"></asp:TextBox></div>
            <div><asp:Label runat ="server" ID="lblNombre">Ingrese el nombre de la herramienta</asp:Label></div>
            <div><asp:TextBox runat="server" ID="txtNombre"></asp:TextBox></div>
            <div><asp:Label runat ="server" ID="lblCantidad">Ingrese la cantidad de la herramienta</asp:Label></div>
            <div><asp:TextBox runat="server" ID="txtCantidad"></asp:TextBox></div>
            <div><asp:Label runat ="server" ID="lblDisponible">¿Está la herramienta disponible?</asp:Label></div>
            <div><asp:DropDownList runat ="server" ID="cmbDisponible"></asp:DropDownList></div>
            <br />
            <div><asp:Button runat ="server" ID="btnAgregar" Text="Agregar" OnClick="btnAgregar_Click"/></div> 
            <br />
            <div><asp:Button runat ="server" ID="btnActualizar" Text="Actualizar" OnClick ="btnActualizar_Click"/></div> 
            <br />
            <div><asp:Button runat ="server" ID="btnBorrar" Text="Borrar" OnClick="btnBorrar_Click"/></div>
        </div>
    </form>
</body>
</html>

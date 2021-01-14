<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CRUDPersona.aspx.cs" Inherits="CRUDPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 92px;
        }
        .auto-style2 {
            width: 92px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style5 {
            width: 95px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            height: 26px;
            width: 130px;
        }
        .auto-style8 {
            width: 130px;
        }
        .auto-style10 {
            width: 90px;
            height: 23px;
        }
        .auto-style11 {
            width: 90px;
        }
        .auto-style12 {
            width: 95px;
        }
        .auto-style13 {
            width: 92px;
            height: 27px;
        }
        .auto-style14 {
            width: 130px;
            height: 27px;
        }
        .auto-style15 {
            height: 27px;
        }
        .auto-style16 {
            width: 92px;
            height: 42px;
        }
        .auto-style17 {
            width: 130px;
            height: 42px;
        }
        .auto-style18 {
            height: 42px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
        <tr>
            <td class="auto-style12">
                &nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">
                Id Persona</td>
            <td class="auto-style11">
                <asp:TextBox ID="txtIdPersona" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style10"><asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
            </td>
            <td class="auto-style6"></td>
        </tr>
    </table>
    <table style="width:100%;">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lbl1" runat="server" Text="Rut"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lbl2" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="lbl3" runat="server" Text="Apellido"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13">
                <asp:Label ID="lbl4" runat="server" Text="Edad"></asp:Label>
            </td>
            <td class="auto-style14">
                <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style15"></td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:Label ID="lbl5" runat="server" Text="Fecha Nacimiento"></asp:Label>
            </td>
            <td class="auto-style17">
                <asp:TextBox ID="txtFechaNacimiento" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style18"></td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Correo" runat="server" Text="Correo"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="Area de Trabajo"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="txtAreaTrabajo" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" Width="95px" />
            </td>
            <td class="auto-style8">
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            </td>
            <td>
                <asp:Label ID="L1" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="btnActualizar" runat="server" Text="Atualizar" Width="95px" />
            </td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </form>
    </body>
</html>

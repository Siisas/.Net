<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenField.aspx.cs" Inherits="WebApplication5.HiddenField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <table>
                <tr>
                    <td>Nombre</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Fecha</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Id Genero</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
              <tr>
                  <td>
                      <asp:Button ID="Button1" runat="server" Text="ACTUALIZAR" OnClick="Button1_Click" />
                  </td>
                   <td>
                       <asp:Button ID="Button2" runat="server" Text="CARGAR" OnClick="Button2_Click" />
                  </td>
              </tr>

            </table>
        </div>
    </form>
</body>
</html>

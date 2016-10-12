<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="check.aspx.cs" Inherits="WebApplication5.check" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatColumns="1">
            <asp:ListItem  Text="Diploma" Value="1"></asp:ListItem>
            <asp:ListItem Text="Grado" Selected="True" Value="2"></asp:ListItem>
            <asp:ListItem Text="PosGrado" Value="3"></asp:ListItem>
            <asp:ListItem Text="Doctorado" Value="4"></asp:ListItem>
                </asp:CheckBoxList>
            <asp:Button ID="Select" runat="server" Text="Select" OnClick="Select_Click" />
            <asp:Button ID="DesSelect" runat="server" Text="DesSelect" OnClick="DesSelect_Click" />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="task2.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            Username<asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br />
            <br />
            Password<asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="button" runat="server" Text="Login" OnClick="button_Click" />
        </div>
    </form>
</body>
</html>

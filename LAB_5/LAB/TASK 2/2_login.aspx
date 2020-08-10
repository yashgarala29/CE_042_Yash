<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TASK_2.login" %>

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
            Username<br />
            <asp:TextBox ID="username" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-bottom: 16px"></asp:TextBox>
            <br />
            <br />
            Password<br />
            <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

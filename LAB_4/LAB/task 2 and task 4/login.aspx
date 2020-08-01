<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="login.login" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>login</title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <asp:Label ID="Label1" runat="server"></asp:Label>
           
            <br />
            <asp:Label runat="server" Text="Username"></asp:Label>
            <br />
            <asp:TextBox ID="username" runat="server" OnTextChanged="username_TextChanged" ></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" Text="Password"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="password" runat="server" TextMode="Password" OnTextChanged="password_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            <br />
            <br />
           
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="birthday_reminder.aspx.cs" Inherits="TASK1.birthday_reminder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            <br />
            <br />
            Birth Date<br />
            <br />
            <asp:TextBox ID="birthday" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="remember" runat="server" OnClick="remember_Click" Text="remember" />
            &nbsp;&nbsp;&nbsp;
            <br />
        </div>
    &nbsp;&nbsp;&nbsp;
        </form>
</body>
</html>

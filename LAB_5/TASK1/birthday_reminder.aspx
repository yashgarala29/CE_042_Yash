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
            <asp:Button ID="delete" runat="server" OnClick="delete_Click" style="margin-left: 8px" Text="delete" Width="152px" />
            <br />
        </div>
    &nbsp;name=<asp:Label ID="name_l" runat="server"></asp:Label>
&nbsp;&nbsp;
        <br />
        birth date=<asp:Label ID="date" runat="server"></asp:Label>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert.aspx.cs" Inherits="TASK_1.insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p style="margin-left: 40px">
            NAME&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            SEM&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="sem" runat="server" TextMode="Number"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            EMAIL ID&nbsp;
            <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            <br />
            <asp:Button ID="add" runat="server" Height="61px" Text="Add Data" Width="258px" />
        </p>
    </form>
</body>
</html>

﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert.aspx.cs" Inherits="TASK_1.insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p style="margin-left: 40px">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Edit  " Width="77px" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Show" />
        </p>
        <p style="margin-left: 40px">
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
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
            MOBILE NO
            <asp:TextBox ID="mobile" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            <br />
            <asp:Button ID="add" runat="server" Height="61px" OnClick="add_Click" Text="Add Data" Width="258px" />
        </p>
    </form>
</body>
</html>
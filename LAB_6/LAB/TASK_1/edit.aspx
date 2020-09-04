<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="TASK_1.edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p style="margin-left: 40px">
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Insert" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Show" />
            </p>
            <p style="margin-left: 40px">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </p>
            <p style="margin-left: 40px">
                ID
                <asp:TextBox ID="given_id" runat="server"></asp:TextBox>
            </p>
            <p style="margin-left: 40px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="184px" />
            </p>
            <p style="margin-left: 40px">
                &nbsp;</p>
            <p style="margin-left: 40px">
                ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="id" runat="server" ReadOnly="True"></asp:TextBox>
            </p>
            <p style="margin-left: 40px">
                NAME&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
                MOBILE NO&nbsp;<asp:TextBox ID="mobile_no" runat="server"></asp:TextBox>
            </p>
            <p style="margin-left: 40px">
                <br />
                <asp:Button ID="show" runat="server" Height="61px" Text="Update" Width="258px" OnClick="show_Click" />
            </p>
            <p style="margin-left: 40px">
                &nbsp;</p>
            <p style="margin-left: 40px">
                &nbsp;</p>
        </div>
    </form>
</body>
</html>

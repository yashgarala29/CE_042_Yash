<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="TASK_2.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            WelCome
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" Width="238px" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem  Value="book">Books</asp:ListItem>
                <asp:ListItem Value="electronic">Electronics </asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:ListBox ID="item" runat="server" OnSelectedIndexChanged="item_SelectedIndexChanged" AutoPostBack="True" Height="131px" Width="126px">
               
            </asp:ListBox>
            <br />
            <asp:Label ID="temp" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
        </div>
    </form>
</body>
</html>

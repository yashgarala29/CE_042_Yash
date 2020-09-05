<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="TASK_3.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            id&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="212px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="55px" Text="Show Data" Width="244px" OnClick="Button1_Click" />
            
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/allproduct.aspx">All product</asp:HyperLink>
            
        </div>
    </form>
</body>
</html>

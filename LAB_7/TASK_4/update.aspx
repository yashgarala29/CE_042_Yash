<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="TASK_4.update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="insert" runat="server" NavigateUrl="~/insert.aspx">Insert</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/update.aspx">Update</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/delete.aspx">Delete</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/show.aspx">Show</asp:HyperLink>
            <br />
            <br />
            id&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="sid" runat="server" TextMode="Number"></asp:TextBox>
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            name&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />
            <br />
            sem<asp:TextBox ID="sem" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            contacno<asp:TextBox ID="contacno" runat="server" TextMode="Phone"></asp:TextBox>
            <br />
            <br />
            cpi<asp:TextBox ID="cpi" runat="server"></asp:TextBox>
            <br />
            <br />
            emailid<asp:TextBox ID="emailid" runat="server" TextMode="Email"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>

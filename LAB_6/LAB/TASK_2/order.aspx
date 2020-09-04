<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="task2.order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div aria-orientation="vertical">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="product">
                <Columns>
                    <asp:BoundField DataField="pname" HeaderText="product name" SortExpression="pname" />
                    <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
                    <asp:BoundField DataField="cost" HeaderText="cost" SortExpression="cost" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="product" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [pname], [description], [cost] FROM [order] ORDER BY [pid]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" Width="268px" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Place orde" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>

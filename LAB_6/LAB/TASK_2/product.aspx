<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="task2.product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="Table1" runat="server" Height="45px" Width="319px">
                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">product name</asp:TableCell>
                    <asp:TableCell runat="server">price</asp:TableCell>

                </asp:TableRow>
                

            </asp:Table>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="TASK_1.delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            ID&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="id" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="delet_data" runat="server" Height="68px" Text="Delet_data" Width="218px" OnClick="delet_data_Click" />
        </div>
    </form>
</body>
</html>

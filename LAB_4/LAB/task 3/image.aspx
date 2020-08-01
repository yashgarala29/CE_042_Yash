<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="image.aspx.cs" Inherits="task3.image" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Height="62px" Text="Button" Width="372px" OnClick="Button1_Click" />
            <br><br>
            <asp:Image ID="Image1" Visible="false" runat="server" Height="250px" ImageUrl="~/smile.jpg" Width="382px" />
            
            
        </div>
    </form>
</body>
</html>

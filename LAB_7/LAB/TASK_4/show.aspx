<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="show.aspx.cs" Inherits="TASK_4.show" %>

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
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" DataKeyNames="sid,name" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="LinqDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="sid" HeaderText="sid" ReadOnly="True" SortExpression="sid" />
                    <asp:BoundField DataField="name" HeaderText="name" ReadOnly="True" SortExpression="name" />
                </Columns>
            </asp:GridView>
            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="TASK_4.studentDataContext" EntityTypeName="" Select="new (sid, name)" TableName="student1s">
            </asp:LinqDataSource>
            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="sid" DataSourceID="LinqDataSource2" Height="50px" Width="125px" OnPageIndexChanging="DetailsView1_PageIndexChanging" AllowPaging="True">
                <Fields>
                    <asp:BoundField DataField="sid" HeaderText="sid" InsertVisible="False" ReadOnly="True" SortExpression="sid" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="sem" HeaderText="sem" SortExpression="sem" />
                    <asp:BoundField DataField="cpi" HeaderText="cpi" SortExpression="cpi" />
                    <asp:BoundField DataField="contactno" HeaderText="contactno" SortExpression="contactno" />
                    <asp:BoundField DataField="emailid" HeaderText="emailid" SortExpression="emailid" />
                </Fields>
            </asp:DetailsView>
            <asp:LinqDataSource ID="LinqDataSource2" runat="server" ContextTypeName="TASK_4.studentDataContext" EntityTypeName="" TableName="student1s" Where="sid == @sid">
                <WhereParameters>
                    <asp:ControlParameter ControlID="GridView1" DefaultValue="0" Name="sid" PropertyName="SelectedValue" Type="Int32" />
                </WhereParameters>
            </asp:LinqDataSource>
            <br />
            
            
        </div>
    </form>
</body>
</html>

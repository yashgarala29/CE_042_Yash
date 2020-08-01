<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="login.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Full name(text)
        <asp:RequiredFieldValidator ID="requiredfieldvalidator" runat="server" ControlToValidate="name"
           Text="please enter name" ErrorMessage="name is required" ForeColor="Red" ></asp:RequiredFieldValidator><br />
        <asp:TextBox ID="name" runat="server"  ></asp:TextBox>
        
        <br />
        Age (int)
        <asp:RangeValidator ID="rangevalidatorage" runat="server" ControlToValidate="age" Display="Dynamic"
            ErrorMessage="age must be in range 18 to 50" ForeColor="Red" MaximumValue="50" MinimumValue="18"
            SetFocusOnError="true" Type="Integer" Text="age must be in range 18 to 50 !"></asp:RangeValidator>
        <asp:RequiredFieldValidator ID="requiredfieldvalidator1" runat="server" ControlToValidate="age"
           Text="please enter age" ErrorMessage="age is required" ForeColor="Red" ></asp:RequiredFieldValidator><br />
        <asp:TextBox ID="age" runat="server"  ></asp:TextBox>
        <br />
        Password
        <asp:RequiredFieldValidator ID="requiredfieldvalidator2" runat="server" ControlToValidate="password"
           Text="please enter password" ErrorMessage="password is required" ForeColor="Red" ></asp:RequiredFieldValidator><br />
        <br />
        <asp:TextBox ID="password" runat="server" TextMode="Password" ></asp:TextBox>
        <br />
        Confirm Password
        <asp:CompareValidator ID="comparevalidatorpassword" runat="server" ControlToValidate="confirm_password"
         Text="password and confirm_password are not same" ErrorMessage="password and confirm_password are not same"
       ForeColor="Red" ControlToCompare="password" Display="Dynamic"   ></asp:CompareValidator>
        <asp:RequiredFieldValidator ID="requiredfieldvalidator3" runat="server" ControlToValidate="confirm_password"
           Text="please enter confirm_password" ErrorMessage="confirm_password is required" ForeColor="Red" ></asp:RequiredFieldValidator><br />
        <br />
        <asp:TextBox ID="confirm_password" runat="server" TextMode="Password" ></asp:TextBox>
        <br />
        Gender<asp:RadioButtonList ID="Gender" runat="server" RepeatDirection="Horizontal" Width="179px">
            <asp:ListItem Selected="True">Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        Mobile No
        <asp:RegularExpressionValidator ID="RegularExpressionValidatormo_number" runat="server"
        ErrorMessage="pleas enter 10 degit number" Text="pleas enter 10 degit number" ControlToValidate="mo_number"
         Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationExpression="\d{10}" ></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="requiredfieldvalidator4" runat="server" ControlToValidate="mo_number"
           Text="please enter mo_number" ErrorMessage="mo_number is required" ForeColor="Red" ></asp:RequiredFieldValidator><br />
        <br />
        <asp:TextBox ID="mo_number" runat="server"></asp:TextBox>
        <br />
        Hobbies (check box)<br />
        <asp:CheckBoxList ID="hobbies" runat="server" RepeatDirection="Horizontal" Width="548px">
            <asp:ListItem Text="Learning">Learning</asp:ListItem>
            <asp:ListItem Text="Drawing">Drawing</asp:ListItem>
            <asp:ListItem Text="Playing">Playing</asp:ListItem>
            <asp:ListItem Text="Coding">Coding</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        State (dropdown)<br />
        <asp:DropDownList ID="state"  AutoPostBack="true"  runat="server"  Height="34px" Width="104px" OnSelectedIndexChanged="state_SelectedIndexChanged">
            <asp:ListItem Value="Gujarat">Gujarat</asp:ListItem>
            <asp:ListItem Value="Maharastra">Maharastra</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        City(dropdown)<br />
        <asp:DropDownList ID="city"  runat="server">
            
        </asp:DropDownList>
        <br />
        <br />
        PAN number
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorpan_number" runat="server"
        ErrorMessage="Should be 10 Digit and start with either letter ‘B” or ‘A’." Text="Should be 10 Digit and start with either letter ‘B” or ‘A’." ControlToValidate="pan_number"
         Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationExpression="[A-B]\d{10}" ></asp:RegularExpressionValidator>
        
        <asp:RequiredFieldValidator ID="requiredfieldvalidator5" runat="server" ControlToValidate="pan_number"
           Text="please enter pab_number" ErrorMessage="pab_number is required" ForeColor="Red" ></asp:RequiredFieldValidator><br />
        <br />
        <br />
        <asp:TextBox ID="pan_number" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" Width="140px" OnClick="Button1_Click" />
        <br />
        <br />
        <br />
        Full name(texFull name(text):-<asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        Age (int):-<asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <br />
        Password:-<asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <br />
        Gender:-<asp:Label ID="Label4" runat="server"></asp:Label>
        <br />
        <br />
        Mobile No:-<asp:Label ID="Label5" runat="server"></asp:Label>
        <br />
        <br />
        Hobbies (check box):-<asp:Label ID="Label6" runat="server"></asp:Label>
        <br />
        <br />
        State (dropdown):-<asp:Label ID="Label7" runat="server"></asp:Label>
        <br />
        <br />
        City(dropdown):-<asp:Label ID="Label8" runat="server"></asp:Label>
        <br />
        <br />
        PAN number:-<asp:Label ID="Label9" runat="server"></asp:Label>
        <br />
        <br />
    </form>
</body>
</html>

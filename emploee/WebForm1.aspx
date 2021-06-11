<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="emploee.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="labelFn" runat="server">Employees Details</asp:Label><br />
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl="~/man-icon.png" Height="30px" Width="30px" /><br />
            <br />

            Full Name:<asp:TextBox ID="txtBoxFn" runat="server"></asp:TextBox>

            <asp:RegularExpressionValidator runat="server" ErrorMessage="only characters allowed" ControlToValidate="txtBoxFn" ValidationExpression="^[A-Za-z]*$" ForeColor="Red"></asp:RegularExpressionValidator><br />
            <br />

            Gender:<asp:RadioButton ID="rbtnMale" runat="server" GroupName="gender" Text="Male" />
            <asp:RadioButton ID="rtbnFemale" runat="server" GroupName="gender" Text="Female" /><br />
            <br />


            Company:
        <asp:DropDownList ID="ddlCompany" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlCompany_SelectedIndexChanged1">
            <asp:ListItem> Select </asp:ListItem>
            <asp:ListItem> suja </asp:ListItem>
            <asp:ListItem> microsoft </asp:ListItem>
            <asp:ListItem> google </asp:ListItem>
        </asp:DropDownList><br />
            <br />


            Designation:
            <asp:DropDownList ID="ddlDesignation" runat="server">
                <asp:ListItem> Select </asp:ListItem>
            </asp:DropDownList><br />
            <br />
            <asp:Label ID="lblDisplayError" CssClass="error" runat="server" ForeColor="#FF3300"></asp:Label><br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" BorderStyle="Solid" ToolTip="Submit" OnClick="btnSubmit_Click" />

        </div>
    </form>
</body>
</html>

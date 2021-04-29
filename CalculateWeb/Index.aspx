<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CalculateWeb.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 399px">
    <form id="form1" runat="server">
        <div>
            <textbox name="number1"></textbox>
            <dropdownlist
            </dropdownlist>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Selected="True">+</asp:ListItem>
                <asp:ListItem>-</asp:ListItem>
                <asp:ListItem>*</asp:ListItem>
                <asp:ListItem>/</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Your result: "></asp:Label>
            <asp:TextBox ID="TextBoxResult" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        </p>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="80px" Width="66px">
                <asp:ListItem>Text1</asp:ListItem>
                <asp:ListItem>Text2</asp:ListItem>
                <asp:ListItem>Text3</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="p" Text="Point1" />
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="p" Text="Point2" />
            <br />
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="p" Text="Point3" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

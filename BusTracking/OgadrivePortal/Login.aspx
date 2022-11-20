<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OgadrivePortal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblUserName" Text="User Name" runat="server" />
        <asp:TextBox ID="txtUserName" runat="server" ValidationGroup="login" />
        <asp:RequiredFieldValidator ID="rfvtxtUserName" ErrorMessage="*" ControlToValidate="txtUserName" runat="server" />
        <br />

        <asp:Label ID="lblPassword" Text="Password" runat="server" />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ValidationGroup="login" />
        <asp:RequiredFieldValidator ID="rfvtxtPassword" ErrorMessage="*" ControlToValidate="txtPassword" runat="server" />

        <asp:Label ID="lblMessage" Text="" runat="server" />

        <asp:Button ID="btnLogin" Text="Login" runat="server" ValidationGroup="login" OnClick="btnLogin_Click"/>
    </div>
    </form>
</body>
</html>

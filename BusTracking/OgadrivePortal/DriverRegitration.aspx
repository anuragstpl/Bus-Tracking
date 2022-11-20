<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DriverRegitration.aspx.cs" Inherits="OgadrivePortal.DriverRegitration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMessage" Text="" runat="server" />
        <br />
        <asp:Label ID="lblFullName" Text="Full Name" runat="server" />
        <asp:TextBox ID="txtFullName" runat="server" />
        <br />
        <asp:Label ID="lblEmail" Text="Email Address" runat="server" />
        <asp:TextBox ID="txtEmail" runat="server" ValidationGroup="registration" />
        <asp:RequiredFieldValidator ID="rfvtxtEmail" ErrorMessage="*" ControlToValidate="txtEmail" ValidationGroup="registration" runat="server" />
        <br />
        <asp:Label ID="lblPassword" Text="Password" runat="server" />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ValidationGroup="registration" />
        <asp:RequiredFieldValidator ID="rfvtxtPassword" ErrorMessage="*" ControlToValidate="txtPassword"   ValidationGroup="registration" runat="server" />
        <br />
        <asp:Label ID="lblConfirmPassword" Text="Confirm Password" runat="server" />
        <asp:TextBox ID="txtBoxConfirmPassword" runat="server" TextMode="Password" ValidationGroup="registration" />
        <asp:RequiredFieldValidator ID="rvftxtBoxConfirmPassword" ErrorMessage="*" ControlToValidate="txtBoxConfirmPassword" ValidationGroup="registration" runat="server" />
        <asp:CompareValidator ID="cmprValidatop" ErrorMessage="Password does not match" ControlToValidate="txtBoxConfirmPassword" ControlToCompare="txtPassword" runat="server" />
        <br />
        <asp:Label ID="lblPhoneNumber" Text="Phone Number" runat="server" />
        <asp:TextBox ID="txtPhoneNumber" runat="server"  />
        <asp:RequiredFieldValidator ID="rfvtxtPhoneNumber" ErrorMessage="*" ControlToValidate="txtPhoneNumber" ValidationGroup="registration" runat="server" />
        <br />
        <asp:Label ID="lblDOB" Text="Date Of Birth" runat="server" />
        <asp:TextBox ID="txtDateOfBirth" runat="server"  />
        
        <br />
        <asp:Label ID="lblICNumber" Text="IC Number" runat="server" />
        <asp:TextBox ID="txtICNumber" runat="server"  />
        
        <br />
        <asp:Label ID="lblLicenseNumber" Text="License Number" runat="server" />
        <asp:TextBox ID="txtLicense" runat="server"  />
        <asp:RequiredFieldValidator ID="rfvtxtLicense" ErrorMessage="*" ControlToValidate="txtLicense" ValidationGroup="registration" runat="server" />
        <br />
        <asp:Label ID="lbl" Text="Account Number" runat="server" />
        <asp:TextBox ID="txtAccount" runat="server"  />
        <br />

        <asp:Button ID="btnDriverRegistration" Text="Submit" runat="server" ValidationGroup="registration" OnClick="btnDriverRegistration_Click"/>
    </div>
    </form>
</body>
</html>

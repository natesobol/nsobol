<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProfileHome.aspx.cs" Inherits="Profile_ProfileHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 102px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
            Profile Home</div>
        <asp:Label ID="Label1" runat="server" Text="Welcome to nsobol.com"></asp:Label>
        <asp:Label ID="usernameLabel" runat="server"></asp:Label>
        <p>
            <asp:Button ID="logOutButton" runat="server" OnClick="logOutButton_Click" Text="Log Out" />
        </p>
    </form>
</body>
</html>

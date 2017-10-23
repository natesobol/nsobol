<%@ Page Language="C#" AutoEventWireup="true" CodeFile="flags.aspx.cs" Inherits="flags" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    
        <asp:DropDownList ID="flagDDL" runat="server">
        </asp:DropDownList>
    
    
        <asp:Button ID="changeFlag" runat="server" OnClick="changeFlag_Click" Text="Change Flag" />
    
    </div>
        <asp:Image ID="flagImage" runat="server" Height="147px" Width="240px" />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="calculator.aspx.cs" Inherits="calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 52px;
        }
    </style>
</head>
<body style="height: 174px">
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="operand1" runat="server"></asp:TextBox>
        <asp:DropDownList ID="ddl1" runat="server">
        </asp:DropDownList>
        <asp:TextBox ID="operand2" runat="server"></asp:TextBox>
    
    </div>
        <asp:Button ID="solveButton" runat="server" OnClick="solveButton_Click" Text="Solve" Width="68px" />
        <br />
        <div style="height: 42px">
            <asp:Label ID="answer" runat="server"></asp:Label>
        </div>
        <br />
    </form>
</body>
</html>

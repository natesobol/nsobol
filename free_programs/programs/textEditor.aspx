<%@ Page Language="C#" AutoEventWireup="true" CodeFile="textEditor.aspx.cs" Inherits="textEditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Text Editor<br /></h2>
        <h4>Upload a txt file to get started! <br /></h4>
    </div>
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" /> <br /><br />
    </div>
    <div>
        <asp:Label ID="byteLabel" runat="server"></asp:Label><br />
        <asp:TextBox ID="ContentsTextBox" TextMode="MultiLine" runat="server" Height="286px" Width="327px"></asp:TextBox>
        <p>
            <asp:Button ID="startButton" runat="server" OnClick="startButton_Click" Text="Start" />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:Button ID="downloadButton" runat="server" Text="Download" OnClick="downloadButton_Click" />
        </p>
    </div>
    </form>
</body>
</html>

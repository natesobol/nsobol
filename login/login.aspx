<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login_login" MasterPageFile ="~/MasterPage/nsobolMaster.master"%>

<asp:Content ID ="Content1" ContentPlaceHolderID = "ContentPlaceHolder1" runat ="server">

    <table class="auto-style1">
            <tr>
                <td class="auto-style4">Username:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxUN" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUN" ErrorMessage="Username Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Password:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxPass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPass" ErrorMessage="Password Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="loginButton" runat="server" OnClick="loginButton_Click" Text="Login" Width="80px" />
                    <asp:HyperLink ID="HyperLinkNewUser" runat="server" NavigateUrl="~/registration/registration.aspx">Not Registered?</asp:HyperLink>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Content>


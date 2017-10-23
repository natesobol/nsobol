<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration_registration"  MasterPageFile ="~/MasterPage/nsobolMaster.master"%>

<asp:Content ID ="Content2" ContentPlaceHolderID = "ContentPlaceHolder1" runat ="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">User Name:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBoxUN" runat="server" Width="180px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="UNValidator" runat="server" ControlToValidate="TextBoxUN" ErrorMessage="User Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">E-mail:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBoxEmail" runat="server" Width="180px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="emailValidator" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="E-Mail Required" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="emailRegExValidator" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Must be a valid E-mail" ForeColor="Red" Display="None" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Password:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBoxPass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="passValidator" runat="server" ControlToValidate="TextBoxPass" ErrorMessage="Password Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Confrim Password:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBoxRPass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="confirmPassValidator" runat="server" ControlToValidate="TextBoxRPass" ErrorMessage="Password Required" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:CompareValidator ID="passMatchValidator" runat="server" ControlToCompare="TextBoxPass" ControlToValidate="TextBoxRPass" ErrorMessage="Passwords must match" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Country:</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="DropDownListCounty" runat="server" Height="16px" Width="180px">
                            <asp:ListItem>Select Country</asp:ListItem>
                            <asp:ListItem>United States</asp:ListItem>
                            <asp:ListItem>China</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="countryValidator" runat="server" ControlToValidate="DropDownListCounty" ErrorMessage="Country Required" ForeColor="Red" InitialValue="Select Country"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" />
                        <input id="resetButton" class="auto-style6" type="reset" value="Clear Fields" /></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
</asp:Content>
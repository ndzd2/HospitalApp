<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Medical.aspx.cs" Inherits="FinalApp.Medical" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>You can add bills to the patients</h3>
    <p>&nbsp;</p>
    <p>&nbsp;&nbsp;&nbsp; Please select a patient and fill empty textboxes.</p>
    <table class="nav-justified">
        <tr>
            <td>&nbsp;</td>
            <td class="modal-sm" style="width: 271px">
                <asp:ListBox ID="ListBox1" runat="server" Height="142px" Width="155px"></asp:ListBox>
            </td>
            <td class="modal-sm" style="width: 174px">&nbsp;</td>
            <td style="width: 195px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="modal-sm" style="width: 271px">&nbsp;</td>
            <td class="modal-sm" style="width: 174px">Bill ID</td>
            <td style="width: 195px">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="modal-sm" style="width: 271px">&nbsp;</td>
            <td class="modal-sm" style="width: 174px">Patient ID</td>
            <td style="width: 195px">
                <input type="number" id="TextBox1" runat="server" style="width: 176px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="modal-sm" style="width: 271px">&nbsp;</td>
            <td class="modal-sm" style="width: 174px">Description of the bill</td>
            <td style="width: 195px">
                <asp:TextBox ID="TextBox3" runat="server" Width="176px" Height="70px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="modal-sm" style="width: 271px">&nbsp;</td>
            <td class="modal-sm" style="width: 174px">Your login</td>
            <td style="width: 195px">
                <asp:TextBox ID="TextBox4" runat="server" Width="176px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="modal-sm" style="width: 271px">&nbsp;</td>
            <td class="modal-sm" style="width: 174px">Your password</td>
            <td style="width: 195px">
                <asp:TextBox ID="TextBox5" runat="server" Width="176px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px"></td>
            <td class="modal-sm" style="height: 20px; width: 271px"></td>
            <td style="height: 20px; width: 174px"></td>
            <td style="height: 20px; width: 195px"></td>
            <td style="height: 20px">
                <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
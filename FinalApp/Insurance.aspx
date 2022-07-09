<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insurance.aspx.cs" Inherits="FinalApp.Insurance" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>In this page you can select hospital and enter patient id to get every information about it</h1>
        <table class="nav-justified">
            <tr>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 203px">&nbsp;</td>
                <td class="modal-sm" style="width: 277px">&nbsp;</td>
                <td class="modal-sm" style="width: 174px">&nbsp;</td>
                <td style="width: 229px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 203px">
                    <asp:ListBox ID="ListBox1" runat="server" Height="172px" Width="190px"></asp:ListBox>
                </td>
                <td class="modal-sm" style="width: 277px">
                    <asp:ListBox ID="ListBox2" runat="server" Height="171px" style="margin-left: 52" Width="199px"></asp:ListBox>
                </td>
                <td class="modal-sm" style="width: 174px">&nbsp;</td>
                <td style="width: 229px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="height: 22px"></td>
                <td class="modal-sm" style="width: 203px; height: 22px"></td>
                <td class="modal-sm" style="width: 277px; height: 22px"></td>
                <td class="modal-sm" style="width: 174px; height: 22px">ID of hospital</td>
                <td style="height: 22px; width: 229px">
                    <input type="number" ID="TextBox1" runat="server" />
                </td>
                <td style="height: 22px"></td>
                <td style="height: 22px">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 203px">&nbsp;</td>
                <td class="modal-sm" style="width: 277px">&nbsp;</td>
                <td class="modal-sm" style="width: 174px">ID of patient</td>
                <td style="width: 229px">
                    <input type="number" ID="TextBox2" runat="server" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 203px">&nbsp;</td>
                <td class="modal-sm" style="width: 277px">&nbsp;</td>
                <td class="modal-sm" style="width: 174px">&nbsp;</td>
                <td style="width: 229px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="height: 20px"></td>
                <td class="modal-sm" style="width: 203px; height: 20px"></td>
                <td class="modal-sm" style="width: 277px; height: 20px"></td>
                <td class="modal-sm" style="width: 174px; height: 20px"></td>
                <td style="width: 229px; height: 20px">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
                </td>
                <td style="height: 20px"></td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 203px">&nbsp;</td>
                <td class="modal-sm" style="width: 277px">&nbsp;</td>
                <td class="modal-sm" style="width: 174px">&nbsp;</td>
                <td style="width: 229px">&nbsp;</td>
                <td>
                    <asp:ListBox ID="ListBox3" runat="server" Height="596px" Width="596px"></asp:ListBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 203px">&nbsp;</td>
                <td class="modal-sm" style="width: 277px">&nbsp;</td>
                <td class="modal-sm" style="width: 174px">&nbsp;</td>
                <td style="width: 229px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 203px">&nbsp;</td>
                <td class="modal-sm" style="width: 277px">&nbsp;</td>
                <td class="modal-sm" style="width: 174px">&nbsp;</td>
                <td style="width: 229px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 203px">&nbsp;</td>
                <td class="modal-sm" style="width: 277px">&nbsp;</td>
                <td class="modal-sm" style="width: 174px">&nbsp;</td>
                <td style="width: 229px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 203px">&nbsp;</td>
                <td class="modal-sm" style="width: 277px">&nbsp;</td>
                <td class="modal-sm" style="width: 174px">&nbsp;</td>
                <td style="width: 229px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 203px">&nbsp;</td>
                <td class="modal-sm" style="width: 277px">&nbsp;</td>
                <td class="modal-sm" style="width: 174px">&nbsp;</td>
                <td style="width: 229px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
</asp:Content>

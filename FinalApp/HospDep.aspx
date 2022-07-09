<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HospDep.aspx.cs" Inherits="FinalApp.HospDep" MasterPageFile="~/Site.Master" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Welcome to our Hospital Department site</h2>
    <div></div>

    <div>

        <table class="nav-justified">
            <tr>
                <td>&nbsp;</td>
                <td>

                    <asp:ListBox ID="ListBox1" runat="server" Height="122px" Width="136px"></asp:ListBox>

                </td>
                <td style="width: 141px">

                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>

                    &nbsp;</td>
            </tr>
        </table>

    </div>
    <div>
        <table class="nav-justified">
            <tr>
                <td style="height: 20px; width: 241px"></td>
                <td class="modal-sm" style="width: 104px; height: 20px"></td>
                <td style="height: 20px; width: 203px;"></td>
                <td style="height: 20px"></td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td style="width: 241px">&nbsp;</td>
                <td class="modal-sm" style="width: 104px">E-Mail</td>
                <td style="width: 203px">
                    <asp:TextBox ID="TextBox1" runat="server" Width="195px" ClientIDMode="Static" ></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 241px; height: 22px"></td>
                <td class="modal-sm" style="width: 104px; height: 22px">&nbsp;</td>
                <td style="height: 22px; width: 203px;">
                    &nbsp;</td>
                <td style="height: 22px"></td>
                <td style="height: 22px"></td>
            </tr>
            <tr>
                <td style="width: 241px">&nbsp;</td>
                <td class="modal-sm" style="width: 104px">Password</td>
                <td style="width: 203px">
                    <asp:TextBox ID="TextBox2" runat="server" Width="194px" TextMode="Password" ></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 241px">&nbsp;</td>
                <td class="modal-sm" style="width: 104px">&nbsp;</td>
                <td style="width: 203px">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 241px">&nbsp;</td>
                <td class="modal-sm" style="width: 104px">Hospital ID</td>
                <td style="width: 203px">
                    <input type="number" ID="TextBox3" runat="server" style="width: 194px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 241px">&nbsp;</td>
                <td class="modal-sm" style="width: 104px">&nbsp;</td>
                <td style="width: 203px">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Proceed" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>
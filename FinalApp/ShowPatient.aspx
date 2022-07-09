<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowPatient.aspx.cs" Inherits="FinalApp.ShowPatient" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>You can take a look at patients from our database and manage their bills</h2>
    <div>Please select a patient<br />
        <table class="nav-justified">
            <tr>
                <td style="height: 22px; width: 331px"></td>
                <td style="height: 22px; width: 155px">
                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td style="height: 22px; width: 113px">&nbsp;</td>
                <td style="height: 22px; width: 145px">
                    &nbsp;</td>
                <td style="height: 22px; width: 121px">&nbsp;</td>
                <td style="height: 22px"></td>
            </tr>
            <tr>
                <td style="width: 331px">&nbsp;</td>
                <td class="modal-sm" style="width: 155px">&nbsp;</td>
                <td class="modal-sm" style="width: 113px"><asp:Label ID="Label7" runat="server" Text="Name"></asp:Label>
                </td>
                <td class="modal-sm" style="width: 145px">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="modal-sm" style="width: 121px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 331px">&nbsp;</td>
                <td class="modal-sm" style="width: 155px">&nbsp;</td>
                <td class="modal-sm" style="width: 113px"><asp:Label ID="Label9" runat="server" Text="Age"></asp:Label>
                </td>
                <td class="modal-sm" style="width: 145px">
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="modal-sm" style="width: 121px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 331px">&nbsp;</td>
                <td class="modal-sm" style="width: 155px">&nbsp;</td>
                <td class="modal-sm" style="width: 113px"><asp:Label ID="Label10" runat="server" Text="Telephone"></asp:Label>
                </td>
                <td class="modal-sm" style="width: 145px">
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="modal-sm" style="width: 121px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 331px">&nbsp;</td>
                <td class="modal-sm" style="width: 155px">&nbsp;</td>
                <td class="modal-sm" style="width: 113px"><asp:Label ID="Label11" runat="server" Text="E-Mail"></asp:Label>
                </td>
                <td class="modal-sm" style="width: 145px">
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="modal-sm" style="width: 121px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 331px; height: 26px"></td>
                <td class="modal-sm" style="width: 155px; height: 26px"></td>
                <td class="modal-sm" style="width: 113px; height: 26px"><asp:Label ID="Label12" runat="server" Text="Bill"></asp:Label>
                </td>
                <td class="modal-sm" style="width: 145px; height: 26px">
                    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                </td>
                <td class="modal-sm" style="width: 121px; height: 26px">
                    &nbsp;</td>
                <td style="height: 26px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 331px">&nbsp;</td>
                <td class="modal-sm" style="width: 155px">&nbsp;</td>
                <td class="modal-sm" style="width: 113px">
                    <asp:Label ID="Label13" runat="server" Text="Bill ID"></asp:Label>
                </td>
                <td class="modal-sm" style="width: 145px">
                    <input type="number" ID="TextBox1" runat="server" />
                </td>
                <td class="modal-sm" style="width: 121px">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Change status" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>

    <div>
    </div>
</asp:Content>
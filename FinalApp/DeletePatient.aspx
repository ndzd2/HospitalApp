<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeletePatient.aspx.cs" Inherits="FinalApp.DeletePatient" MasterPageFile="~/Site.Master" %>

<script runat="server">

</script>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>You can delete patients from our database in this site</h2>
    <p>&nbsp;</p>
    <div>
        <table class="nav-justified">
            <tr>
                <td style="height: 20px"></td>
                <td style="height: 20px"></td>
                <td class="modal-sm" style="width: 293px; height: 20px"></td>
                <td style="height: 20px; width: 71px">&nbsp;<br />
                    <td style="height: 20px">Please type ID and surname of the
                    patient that you want to delete
                </td>
                <td style="height: 20px"></td>
                <td style="height: 20px"></td>
                <td style="height: 20px"></td>
                <td style="height: 20px"></td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 293px">&nbsp;</td>
                <td style="width: 71px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="height: 20px"></td>
                <td style="height: 20px"></td>
                <td class="modal-sm" style="width: 293px; height: 20px"></td>
                <td style="width: 71px; height: 20px">ID</td>
                <td style="height: 20px">
                    <input type="number" id="TextBox1" runat="server" />
                </td>
                <td style="height: 20px"></td>
                <td style="height: 20px"></td>
                <td style="height: 20px"></td>
                <td style="height: 20px"></td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 293px">&nbsp;</td>
                <td style="width: 71px">Name</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 293px">&nbsp;</td>
                <td style="width: 71px">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 293px">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
                <td style="width: 71px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 293px">&nbsp;</td>
                <td style="width: 71px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 293px">&nbsp;</td>
                <td style="width: 71px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 293px">&nbsp;</td>
                <td style="width: 71px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="modal-sm" style="width: 293px">&nbsp;</td>
                <td style="width: 71px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>
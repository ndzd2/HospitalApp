<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hospital.aspx.cs" Inherits="FinalApp.Hospital" MasterPageFile="~/Site.Master" %>

<script runat="server">

</script>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Welcome to our Hospital Department site</h2>
    <div>
        <br />
        Select what do you want to do<br />
        <br />
        <br />
        <table class="nav-justified">
            <tr>
                <td style="width: 134px">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 30" Text="Add Patient" />
                </td>
                <td style="width: 66px">&nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Update Patient" OnClick="Button2_Click" />
                </td>
                <td style="width: 66px">&nbsp;</td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="Delete Patient" OnClick="Button3_Click" />
                </td>
                <td style="width: 66px">&nbsp;</td>
                <td>
                    <asp:Button ID="Button4" runat="server" Text="Show Patient" OnClick="Button4_Click" />
                </td>
            </tr>
            <tr>
                <td style="width: 134px">&nbsp;</td>
                <td>&nbsp;</td>
                <td style="width: 66px">&nbsp;</td>
                <td>&nbsp;</td>
                <td style="width: 66px">&nbsp;</td>
                <td>&nbsp;</td>
                <td style="width: 66px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>
<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FinalApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Welcome to main page</h1>
        <p class="lead">&nbsp;</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Hospital Department</h2>
            <p>
                &nbsp;</p>
            <p>
                <a class="btn btn-default" runat="server" href="~/HospDep"> >Login &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Medical Department</h2>
            <p>
                &nbsp;</p>
            <p>
                <a class="btn btn-default" runat="server" href="~/MedDep"> >Login &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Insurance Department</h2>
            <p>
                &nbsp;</p>
            <p>
                <a class="btn btn-default" runat="server" href="~/InsDep"> >Login &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>

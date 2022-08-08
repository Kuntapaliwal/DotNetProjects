<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TheaterWebApp.aspx.cs" Inherits="MovieWebApp.TheaterWebApp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <h2>Theater Entry </h2>
    <div class="form-group">
        <label> Theater id</label>
        
        <asp:TextBox runat="server" ID="txtTheaterId" CssClass="form-control" OnTextChanged="txtMovieId_TextChanged" /></div>

        <div class="form-group">
        <label> Theater Name</label>
        <asp:TextBox runat="server" ID="txtTheaterName" CssClass="form-control" /> </div>

    <div class="form-group">
        <label> Theater Description</label>
        <asp:TextBox runat="server" ID="txtTheaterDesc" CssClass="form-control" />

    </div>
    <div class="form-group">
        <label> Theater City</label>
        <asp:TextBox runat="server" ID="txtTheaterCity" CssClass="form-control" />
        </div>

     <asp:Button runat ="server" ID="btnSave" Text="Save" CssClass="btn btn-success" OnClick="btnSave_Click" />
    <asp:Button runat="server" ID="btnEdit" Text="Edit" CssClass="btn  btn-info" OnClick="btnEdit_Click" />
    <asp:Button runat="server" ID="btnUpdate" Text="Update" CssClass="btn  btn-info" OnClick="btnUpdate_Click" />
    <asp:Button runat="server" ID="btnDelete" Text="Delete" CssClass="btn  btn-danger" OnClick="btnDelete_Click" />
     <asp:Button runat ="server" ID="btnReset" Text="Reset" CssClass="btn btn-warning " OnClick="btnReset_Click" />
    <hr />
    <asp:Label runat="server" ID="lblMsg"></asp:Label>
    <hr />
    <div>
        <asp:GridView ID="gvTheaterDetails" runat="server" CssClass="table table-bordered table-striped"></asp:GridView>
    </div>
</asp:Content>

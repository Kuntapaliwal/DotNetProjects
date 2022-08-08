<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MovieEntry.aspx.cs" Inherits="MovieWebApp.MovieEntry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Movie Entry </h2>
    <div class="form-group">
        <label> Movie id</label>
        
        <asp:TextBox runat="server" ID="txtMovieId" CssClass="form-control" OnTextChanged="txtMovieId_TextChanged" /></div>

        <div class="form-group">
        <label> Movie Name</label>
        <asp:TextBox runat="server" ID="txtMovieName" CssClass="form-control" /> </div>
    <div class="form-group">
        <label> Movie Description</label>
        <asp:TextBox runat="server" ID="txtMovieDesc" CssClass="form-control" />

    </div>
    <div class="form-group">
        <label> Movie Type</label>
        <asp:TextBox runat="server" ID="txtMovieType" CssClass="form-control" />

    </div>
    <asp:Button runat ="server" ID="btnSave" Text="Save" CssClass="btn btn-warning" OnClick="btnSave_Click" />
    <asp:Button runat="server" ID="btnEdit" Text="Edit" CssClass="btn  btn-info" OnClick="btnEdit_Click" />
    <asp:Button runat="server" ID="btnUpdate" Text="Update" CssClass="btn  btn-info" OnClick="btnUpdate_Click" />
    <asp:Button runat="server" ID="btnDelete" Text="Delete" CssClass="btn  btn-info" OnClick="btnDelete_Click" />
     <asp:Button runat ="server" ID="btnReset" Text="Reset" CssClass="btn btn-primary" OnClick="btnReset_Click" />
    <hr />
    <asp:Label runat="server" ID="lblMsg"></asp:Label>
    <hr />
    <div>
        <asp:GridView ID="gvMovieDetails" runat="server" CssClass="table table-bordered table-striped"></asp:GridView>
    </div>
</asp:Content>

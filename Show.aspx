<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="test.Show" %>

<asp:Content ID="Content4" ContentPlaceHolderID="contentBody" runat="Server">
    <div>
        
        <asp:GridView ID="gvFilm" AutoGenerateColumns="false" CssClass="Grid" AlternatingRowStyle="alt" runat="server">
            <Columns>
                <asp:BoundField DataField="Nazwa" HeaderText="Nazwa" />
                <asp:BoundField DataField="Rok" HeaderText="Rok" />
                <asp:BoundField DataField="Ocena" HeaderText="Ocena" />
            </Columns>
        </asp:GridView>
    </div>

    <div>
            <a href="Add.aspx">Add film</a>
        </div>

</asp:Content>
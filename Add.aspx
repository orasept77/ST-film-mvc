<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="test.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentBody" runat="server">

    <h2>Dodaj film
    </h2>
    <div>
        <asp:Label Text="Nazwa" runat="server" />
        <asp:TextBox ID="Nazwa" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label Text="Rok" runat="server" />
        <asp:TextBox ID="Rok" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label Text="Ocena" runat="server" />
        <asp:TextBox ID="Ocena" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label Text="Jezyk" runat="server" />
        <asp:DropDownList ID="ddlJezyk" runat="server">
            <asp:ListItem Selected="true" Value="0" runat="server"> Tak</asp:ListItem>
            <asp:ListItem Value="1" runat="server"> Nie</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div>
        <asp:Label Text="Rodzaj" runat="server" />
        <asp:DropDownList ID="ddlRodzaj" runat="server">
        </asp:DropDownList>
    </div>

    <div>
        <asp:Label Text="Rezyser" runat="server" />
        <asp:DropDownList ID="ddlRezyser" runat="server">
        </asp:DropDownList>
    </div>

    <div>
        <asp:Button ID="addButton" Text="Zapisz" OnClick="addButton_Click" runat="server" />
    </div>
    <div>
        <a href="Show.aspx">Lista filmow</a>
    </div>
</asp:Content>

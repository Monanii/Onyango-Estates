<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="book.aspx.cs" Inherits="Realestates.book" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body>
    <form id="form1">
        <div>
            <h1>Property Reservation</h1>
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            <br />
            <br />
           <h3> <asp:Label ID="lblPropertyName" runat="server" Text="Property Name: "></asp:Label></h3>
            &nbsp;<asp:TextBox ID="txtPropertyName" runat="server" Height="29px" Width="165px"></asp:TextBox>
            <br />
            <h3><asp:Label ID="lblReservedBy" runat="server" Text="Reserved By: "></asp:Label></h3>
            &nbsp;<asp:TextBox ID="txtReservedBy" runat="server" Height="29px" Width="165px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnReserve" runat="server" Text="Reserve Property" OnClick="btnReserve_Click" Height="30px" Width="144px" />
            <br />
        </div>
    </form>
</body>
</asp:Content>

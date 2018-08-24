<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgeCalculator.aspx.cs" Inherits="MyWebForm.AgeCalculator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:Label ID="lblDate" runat="server" Text="Date (mm/dd/yyyy): "></asp:Label>
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblGender" runat="server" Text="Gender: "></asp:Label>
        <asp:DropDownList ID="ddlGender" runat="server">
            <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
            <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
        </asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
    </div>
    <div>
        <asp:Label ID="lblAge" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>

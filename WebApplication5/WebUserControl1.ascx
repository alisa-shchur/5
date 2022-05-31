<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="WebApplication5.WebUserControl1" %>
<asp:TextBox ID="TextBox1" runat="server" Width="148px" ></asp:TextBox>
    <asp:Button ID="ButtonPlus" runat="server" OnClick="ButtonPlus_Click" Text="+" Width="21px" style="margin-left: 36px" />
    <asp:Button ID="ButtonMinus" runat="server" OnClick="ButtonMinus_Click" Text="-" style="margin-left: 20px" />
    <asp:Button ID="ButtonUmn" runat="server" OnClick="ButtonUmn_Click" Text="*" style="margin-left: 20px" />
    <asp:Button ID="ButtonDel" runat="server" OnClick="ButtonDel_Click" Text="/" style="margin-left: 23px" />
<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 37px"></asp:TextBox>
<br />
<br />
<asp:Label ID="LabelResult" runat="server" Visible="False"></asp:Label>



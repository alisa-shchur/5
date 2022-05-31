<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lab52.aspx.cs" Inherits="WebApplication5.Lab52" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="ButtonGet" runat="server" Text="Get data from the database" />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:GridView ID="GridViewClient" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1 style="width: 187px; margin-left: 189px">&nbsp;Calculator</h1>
        <div>
            <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Result" style="margin-left: 232px" Width="97px" />
        &nbsp;&nbsp;&nbsp;<br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>

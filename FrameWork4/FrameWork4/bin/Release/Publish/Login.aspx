<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FrameWork4.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><asp:Label ID="Msg_Email" runat="server" Text="Email"></asp:Label></div>
        <div><asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox></div>
        <div><asp:Label ID="Msg_Password" runat="server" Text="Password" ></asp:Label></div>
        <div><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></div>
        <div><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/></div>
        <div><asp:Label ID="Msg_Login" runat="server" Text="Credencial de Usuario Incorrecta" ForeColor="Red" ></asp:Label></div>
    </form>
</body>
</html>

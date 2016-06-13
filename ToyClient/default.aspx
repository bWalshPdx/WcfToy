<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ToyClient._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>Guess the number!</div>
        <asp:TextBox id="txt1" runat="server" OnTextChanged="txt1_TextChanged" />
        <asp:Button ID="Button1" OnClick="submit" Text="Submit" runat="server" />
    </form>
</body>
</html>

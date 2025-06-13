<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FromViewState.aspx.cs" Inherits="StateManagement.FromViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnIdSave" runat="server" OnClick="btnIdSave_Click" Text="Save_ViewState" />
            <br />
        </div>
        <asp:Button ID="btnRead" runat="server" OnClick="btnRead_Click" Text="Read_ViewState" />
        <p>
            <asp:Label ID="LView" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>

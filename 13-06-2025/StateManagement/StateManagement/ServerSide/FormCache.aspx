<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormCache.aspx.cs" Inherits="StateManagement.ServerSide.FormCache" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnCacheSave" runat="server" OnClick="btnCacheSave_Click" Text="Add To Cache" Width="113px" />
            <br />
            <br />
            <asp:Button ID="btnCacheRead" runat="server" OnClick="btnCacheRead_Click" Text="ReadCache" />
            <br />
            <br />
            <asp:Button ID="btnCacheRemove" runat="server" OnClick="btnCacheRemove_Click" Text="RemoveCache" />
        </div>
        <p>
            <asp:Label ID="LCache" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>

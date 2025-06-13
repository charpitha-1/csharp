<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormWithHidden.aspx.cs" Inherits="StateManagement.FormWithHidden" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hidtest" runat="server" />
            <br />
            <br />
        </div>
        <asp:Button ID="btnSaveHid" runat="server" OnClick="btnSaveHid_Click" style="margin-left: 1px" Text="Save" Width="124px" />
        <p>
            <asp:Button ID="btnReadHid" runat="server" OnClick="btnRead_Click" style="margin-left: 0px" Text="Read" Width="121px" />
        </p>
        <asp:Label ID="LHid" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>

<%@ Page Language="VB" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="AmountToWords._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Amount to Words Converter</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Amount to Words Converter</h2>
            <p>
                Enter an amount:
                <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                <asp:Button ID="btnConvert" runat="server" Text="Convert" OnClick="btnConvert_Click" />
            </p>
            <p>
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </p>
        </div>
    </form>
</body>
</html> 

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet2.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="order">
        <h1>Ordering Menu</h1>
        <h2>Pie Sizes:</h2>
        <asp:CheckBoxList ID="CBLSizes" runat="server">
        </asp:CheckBoxList><br />
        <h2>Toppings:</h2>
        <asp:CheckBoxList ID="CBLToppings" runat="server">
        </asp:CheckBoxList>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>

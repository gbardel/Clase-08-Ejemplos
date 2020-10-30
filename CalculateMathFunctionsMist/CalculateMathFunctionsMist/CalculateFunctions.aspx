<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculateFunctions.aspx.cs" Inherits="CalculateMathFunctionsMist.CalculateFunctions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <h2>Dividir dos valores</h2>
         <div>
            <asp:label ID="lblValue7" runat="server" Text="Ingrese el valor 1"></asp:label>
            <asp:TextBox ID="txtValue7" runat="server"></asp:TextBox>
            <asp:label ID="lblValue8" runat="server" Text="Ingrese el valor 2"></asp:label>
            <asp:TextBox ID="txtValue8" runat="server"></asp:TextBox>
            <asp:Button ID="btnCalculateDiv" runat="server" Text="Dividir" OnClick="btnCalculateDiv_Click"/>
            <asp:label ID="lblResultDiv" runat="server"></asp:label>
        </div>
    </form>
</body>
</html>

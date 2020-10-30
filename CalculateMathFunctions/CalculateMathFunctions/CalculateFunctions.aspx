<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculateFunctions.aspx.cs" Inherits="CalculateMathFunctions.CalculateFunctions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Operaciones Matemáticas</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Sumar dos valores</h2>
        <div>
            <asp:label ID="lblValue1" runat="server" Text="Ingrese el valor 1"></asp:label>
            <asp:TextBox ID="txtValue1" runat="server"></asp:TextBox>
            <asp:label ID="lblValue2" runat="server" Text="Ingrese el valor 2"></asp:label>
            <asp:TextBox ID="txtValue2" runat="server"></asp:TextBox>
            <asp:Button ID="btnCalculateAdd" runat="server" Text="Sumar" OnClick="btnCalculate_Click"/>
            <asp:label ID="lblResultAdd" runat="server"></asp:label>
        </div>
         
        <h2>Restar dos valores</h2>
         <div>
            <asp:label ID="lblValue3" runat="server" Text="Ingrese el valor 1"></asp:label>
            <asp:TextBox ID="txtValue3" runat="server"></asp:TextBox>
            <asp:label ID="lblValue4" runat="server" Text="Ingrese el valor 2"></asp:label>
            <asp:TextBox ID="txtValue4" runat="server"></asp:TextBox>
            <asp:Button ID="btnCalculateSub" runat="server" Text="Restar" OnClick="btnCalculateSub_Click"/>
            <asp:label ID="lblResultSub" runat="server"></asp:label>
        </div>

         <h2>Multiplicar dos valores</h2>
        <div>
            <asp:label ID="lblValue5" runat="server" Text="Ingrese el valor 1"></asp:label>
            <asp:TextBox ID="txtValue5" runat="server"></asp:TextBox>
            <asp:label ID="lblValue6" runat="server" Text="Ingrese el valor 2"></asp:label>
            <asp:TextBox ID="txtValue6" runat="server"></asp:TextBox>
            <asp:Button ID="btnCalculateMul" runat="server" Text="Multiplicar" OnClick="btnCalculateMul_Click"/>
            <asp:label ID="lblResultMul" runat="server"></asp:label>
        </div>
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

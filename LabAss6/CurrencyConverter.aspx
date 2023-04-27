<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrencyConverter.aspx.cs" Inherits="LabAss6.CurrencyConverter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server" >
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <table>
               <tr>
                   <td>
                       <asp:Label ID="Label1" runat="server" Text="Convert:"></asp:Label></td>
                   <td>
                       <asp:TextBox ID="txtConvert" runat="server"></asp:TextBox></td>
                   <td>
                       <asp:Label ID="Label2" runat="server" Text="Chinese Yuan to Dollars."></asp:Label></td>
               </tr>
               <tr>
                   <td>
                       <asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click" /></td>
                   <td></td>
                   <td></td>
               </tr>
               <tr>
                   <td colspan="2">
                       <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></td>
                   <td></td>
                   
               </tr>
           </table>
        </div>
    </form>
</body>
</html>

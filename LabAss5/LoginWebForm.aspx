<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginWebForm.aspx.cs" Inherits="LabAss5.LoginWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblCaptipn" runat="server" Text="Please Log On"></asp:Label></td>
                    <td></td>
                    
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblUsername" runat="server" Text="UserName"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Invalid Username" ControlToValidate="txtUsername"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Invalid Password" ControlToValidate="txtPassword"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" OnClientClick="btnSubmit_Click" PostBackUrl="~/Welcome.aspx" /></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username"></asp:BoundField>
                                <asp:BoundField DataField="password" HeaderText="password" SortExpression="password"></asp:BoundField>
                            </Columns>
                        </asp:GridView>
                        <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:SimpleDatabaseConnectionString %>" ProviderName="<%$ ConnectionStrings:SimpleDatabaseConnectionString.ProviderName %>" SelectCommand="SELECT [Username], [password] FROM [Logon]"></asp:SqlDataSource>
                    </td>
                    
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
            </table>
        </div>
        
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowTabulerDataFrom.aspx.cs" Inherits="LabAss4.ShowTabulerDataFrom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>GridView </h1>
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1"></asp:GridView>
        </div>
        <div>
            <h1>DataList</h1>
            <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1"></asp:DataList>
        </div>
        <div>
            <h1>DetailsView </h1>
            <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" DataSourceID="SqlDataSource1"></asp:DetailsView>
        </div>
        <div>
            <h1>FormView </h1>
            <asp:FormView ID="FormView1" runat="server" DataSourceID="SqlDataSource1"></asp:FormView>
        </div>
        <div>
            <h1>Repeater</h1>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    <%#Eval("Username") %>
                    <i>-->y</i>
                    <%#Eval("password") %>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div>
            <h1>ListView</h1><p>
            <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    <%#Eval("Username") %>
                    <i>--></i>
                    <%#Eval("password") %>
                </ItemTemplate>
            </asp:ListView></p>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SimpleDatabaseConnectionString %>" SelectCommand="SELECT [Username], [password] FROM [Logon]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SchoolApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style ="font-family:Arial">
        </div>
            <asp:EntityDataSource ID ="schoolDatabase" runat="server" OnSelecting="schoolDatabase_Selecting">
            </asp:EntityDataSource>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminStuStat.aspx.cs" Inherits="student.AdminStuStat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        课程统计
			<asp:DataGrid id="DataGrid1" runat="server" AllowPaging="True" Width="320px">
				<HeaderStyle BackColor="#CCCC66"></HeaderStyle>
				<PagerStyle NextPageText="下一页" PrevPageText="上一页"></PagerStyle>
			</asp:DataGrid>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminGrade.aspx.cs" Inherits="student.AdminGrade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <FONT face="宋体">
				<asp:Button id="Button1" runat="server" Text="学生成绩录入" ></asp:Button><br>
				<br>
				<asp:DataGrid id="DataGrid1" runat="server" AllowPaging="True" Width="336px">
					<HeaderStyle BackColor="#CCCC66"></HeaderStyle>
					<PagerStyle NextPageText="下一页" PrevPageText="上一页"></PagerStyle>
				</asp:DataGrid>
			</FONT>
    </form>
</body>
</html>

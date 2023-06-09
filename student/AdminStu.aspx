﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminStu.aspx.cs" Inherits="student.AdminStu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button id="Button1" runat="server" Text="录入学生信息"></asp:Button><br>
			<br>
			<asp:DataGrid id="DataGrid1" runat="server" AllowPaging="True" AutoGenerateColumns="False" Width="480px">
				<HeaderStyle BackColor="#CCCC66"></HeaderStyle>
				<Columns>
					<asp:BoundColumn DataField="学号" ReadOnly="True" HeaderText="学号"></asp:BoundColumn>
					<asp:BoundColumn DataField="姓名" HeaderText="姓名">
						<HeaderStyle Width="100px"></HeaderStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="性别" ReadOnly="True" HeaderText="性别"></asp:BoundColumn>
					<asp:BoundColumn DataField="年龄" HeaderText="年龄"></asp:BoundColumn>
					<asp:BoundColumn DataField="所在院系" HeaderText="所在院系"></asp:BoundColumn>
					<asp:BoundColumn DataField="班级名" HeaderText="班级名"></asp:BoundColumn>
					<asp:BoundColumn DataField="入学年份" ReadOnly="True" HeaderText="入学年份"></asp:BoundColumn>
					<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="更新" CancelText="取消" EditText="编辑"></asp:EditCommandColumn>
					<asp:ButtonColumn Text="删除" CommandName="Delete"></asp:ButtonColumn>
				</Columns>
				<PagerStyle NextPageText="下一页" PrevPageText="上一页"></PagerStyle>
			</asp:DataGrid>
    </form>
</body>
</html>

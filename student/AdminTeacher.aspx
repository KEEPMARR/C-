<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminTeacher.aspx.cs" Inherits="student.AdminTeacher" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <FONT face="宋体">
				<asp:Button id="Button1" runat="server" Text="添加授课信息"></asp:Button><br>
				<br>
				<asp:DataGrid id="DataGrid1" runat="server" AllowPaging="True" Width="400px" AutoGenerateColumns="False">
					<HeaderStyle BackColor="#CCCC66"></HeaderStyle>
					<Columns>
						<asp:BoundColumn DataField="教师名" ReadOnly="True" HeaderText="教师名"></asp:BoundColumn>
						<asp:BoundColumn DataField="课程号" HeaderText="课程号"></asp:BoundColumn>
						<asp:BoundColumn DataField="学时数" HeaderText="学时数"></asp:BoundColumn>
						<asp:BoundColumn DataField="班级名" HeaderText="班级名"></asp:BoundColumn>
						<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="更新" CancelText="取消" EditText="编辑"></asp:EditCommandColumn>
						<asp:ButtonColumn Text="删除" CommandName="Delete"></asp:ButtonColumn>
					</Columns>
					<PagerStyle NextPageText="下一页" PrevPageText="上一页"></PagerStyle>
				</asp:DataGrid>
			</FONT>
    </form>
</body>
</html>

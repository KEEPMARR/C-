<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminGradeAdd.aspx.cs" Inherits="student.AdminGradeAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <FONT face="宋体">
				<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="616" border="1" style="WIDTH: 616px; HEIGHT: 183px">
					<TR>
						<TD style="WIDTH: 120px; HEIGHT: 4px">请选择班级</TD>
						<td style="HEIGHT: 4px"><FONT face="宋体">学生选择</FONT></td>
					</TR>
					<TR>
						<TD style="WIDTH: 120px" vAlign="top">
							<asp:DataGrid id="DataGrid1" runat="server" AutoGenerateColumns="False" Width="136px" AllowPaging="True">
								<HeaderStyle BackColor="#CCCC66"></HeaderStyle>
								<Columns>
									<asp:BoundColumn DataField="班级名" HeaderText="班级名"></asp:BoundColumn>
									<asp:HyperLinkColumn Text="班级名" DataNavigateUrlField="班级名" DataNavigateUrlFormatString="AdminGradeAdd.aspx?Action=Add&amp;班级名={0}"
										HeaderText="请选择" NavigateUrl="AdminGradeAdd.aspx"></asp:HyperLinkColumn>
								</Columns>
								<PagerStyle NextPageText="下一页" PrevPageText="上一页"></PagerStyle>
							</asp:DataGrid></TD>
						<td vAlign="top"><asp:DataGrid id="DataGrid2" runat="server" AutoGenerateColumns="False" Width="392px" AllowPaging="True">
								<HeaderStyle BackColor="#CCCC66"></HeaderStyle>
								<Columns>
									<asp:BoundColumn DataField="学号" HeaderText="学号"></asp:BoundColumn>
									<asp:BoundColumn DataField="姓名" HeaderText="姓名"></asp:BoundColumn>
									<asp:BoundColumn DataField="性别" HeaderText="性别"></asp:BoundColumn>
									<asp:BoundColumn DataField="班级名" HeaderText="班级名"></asp:BoundColumn>
									<asp:BoundColumn DataField="所在院系" HeaderText="所在院系"></asp:BoundColumn>
									<asp:HyperLinkColumn Target="_blank" DataNavigateUrlField="学号" DataNavigateUrlFormatString="AdminGradeAddNext.aspx?学号={0}"
										DataTextField="学号" HeaderText="录入成绩" NavigateUrl="AdminGradeAddNext.aspx"></asp:HyperLinkColumn>
								</Columns>
								<PagerStyle NextPageText="下一页" PrevPageText="上一页"></PagerStyle>
							</asp:DataGrid></td>
					</TR>
				</TABLE>
			</FONT>
    </form>
</body>
</html>

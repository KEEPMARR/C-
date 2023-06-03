<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminTeacherAdd.aspx.cs" Inherits="student.AdminTeacherAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <FONT face="宋体">
				<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="300" border="1">
					<TR>
						<TD>教师名</TD>
						<TD>
							<asp:TextBox id="txtTname" runat="server"></asp:TextBox></TD>
					</TR>
					<TR>
						<TD>课程号
						</TD>
						<TD>
							<asp:TextBox id="txtCid" runat="server"></asp:TextBox></TD>
					</TR>
					<TR>
						<TD>学时数</TD>
						<TD>
							<asp:TextBox id="txtTime" runat="server"></asp:TextBox></TD>
					</TR>
					<TR>
						<TD>班级名</TD>
						<TD>
							<asp:TextBox id="txtClass" runat="server"></asp:TextBox></TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 27px"></TD>
						<TD style="HEIGHT: 27px">
						<asp:Button ID="Button2" runat="server" Text="添加"  OnClick="Button2_Click"/></TD>
					</TR>
					
						<TD></TD>
						<TD></TD>
					</TR>
				</TABLE>
			</FONT>
    </form>
</body>
</html>

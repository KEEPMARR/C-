<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminCourseAdd.aspx.cs" Inherits="student.AdminCourseAdd" %>

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
						<TD>课程号</TD>
						<TD>
							<asp:TextBox id="txtid" runat="server"></asp:TextBox>
							<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtid"></asp:RequiredFieldValidator></TD>
					</TR>
					<TR>
						<TD>课程名
						</TD>
						<TD>
							<asp:TextBox id="txtname" runat="server"></asp:TextBox>
							<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ErrorMessage="必填" ControlToValidate="txtname"></asp:RequiredFieldValidator></TD>
					</TR>
					<TR>
						<TD>先修课
						</TD>
						<TD>
							<asp:TextBox id="txtpre" runat="server"></asp:TextBox></TD>
					</TR>
					<TR>
						<TD>
						</TD>
						<TD>
							<asp:Button id="Button1" runat="server" Text="添  加" ></asp:Button>&nbsp;
							<asp:Button id="Button2" runat="server" Text="返 回" ></asp:Button>
						</TD>
					</TR>
				</TABLE>
			</FONT>
    </form>
</body>
</html>

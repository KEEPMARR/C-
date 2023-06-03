<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminUrlAdd.aspx.cs" Inherits="student.AdminUrlAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <FONT face="宋体"></FONT>
			<br>
			<br>
			<br>
			<br>
			<br>
			<TABLE align="center" id="Table1" cellSpacing="1" cellPadding="1" width="300" border="0">
				<TR>
					<TD style="WIDTH: 110px"><FONT face="宋体"></FONT></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 110px"><FONT face="宋体">功能模块名称</FONT></TD>
					<TD>
						<asp:TextBox id="txtname" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtname"></asp:RequiredFieldValidator></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 110px"><FONT face="宋体">功能模块URL</FONT></TD>
					<TD>
						<asp:TextBox id="txturl" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ErrorMessage="必填" ControlToValidate="txturl"></asp:RequiredFieldValidator></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 110px"><FONT face="宋体">功能模块说明</FONT></TD>
					<TD>
						<asp:TextBox id="TextBox3" runat="server"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 110px"></TD>
					<TD>
						<asp:Button id="Button1" runat="server" Text="确  定"></asp:Button></TD>
				</TR>
			</TABLE>
    </form>
</body>
</html>

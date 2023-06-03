<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminGroupAdd.aspx.cs" Inherits="student.AdminGroupAdd" %>

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
						<TD style="WIDTH: 69px">组名称:</TD>
						<TD>
							<asp:TextBox id="txtGname" runat="server"></asp:TextBox>
							<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtGname"></asp:RequiredFieldValidator></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 69px">组说明:</TD>
						<TD>
							<asp:TextBox id="txtGinfo" runat="server"></asp:TextBox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 69px"></TD>
						<TD>
							<asp:Button id="Button1" runat="server" Text="确  定"></asp:Button></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 69px"></TD>
						<TD></TD>
					</TR>
				</TABLE>
			</FONT>
    </form>
</body>
</html>

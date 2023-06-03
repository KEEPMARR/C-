<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminGradeAddNext.aspx.cs" Inherits="student.AdminGradeAddNext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; WIDTH: 288px; POSITION: absolute; TOP: 8px; HEIGHT: 90px"
				cellSpacing="1" cellPadding="1" width="288" border="1">
				<TR>
					<TD><FONT face="宋体">课程号</FONT></TD>
					<TD>
						<asp:TextBox id="txtcid" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtcid"></asp:RequiredFieldValidator></TD>
				</TR>
				<TR>
					<TD><FONT face="宋体">成&nbsp; 绩</FONT></TD>
					<TD>
						<asp:TextBox id="txtgrade" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ErrorMessage="必填" ControlToValidate="txtgrade"></asp:RequiredFieldValidator>
						<asp:RangeValidator id="RangeValidator1" runat="server" ErrorMessage="输入无效" ControlToValidate="txtgrade"
							Type="Integer" MaximumValue="100" MinimumValue="0"></asp:RangeValidator></TD>
				</TR>
				<TR>
					<TD></TD>
					<TD>
						<asp:Button id="Button1" runat="server" Text="确 定"></asp:Button></TD>
					
				</TR>
			</TABLE>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminStuSearch.aspx.cs" Inherits="student.AdminStuSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <TABLE id="Table1" cellSpacing="1" cellPadding="1" width="592" border="1" style="WIDTH: 592px; HEIGHT: 432px">
				<TR>
					<td style="HEIGHT: 34px">
						学号
						<asp:TextBox id="txtsid" runat="server" Width="56px" BorderStyle="Groove"></asp:TextBox>
						姓名
						<asp:TextBox id="txtname" runat="server" Width="56px" BorderStyle="Groove"></asp:TextBox>&nbsp; 
						年龄
						<asp:TextBox id="txtage" runat="server" Width="64px" BorderStyle="Groove"></asp:TextBox>所在院系
						<asp:TextBox id="txtx" runat="server" Width="64px" BorderStyle="Groove"></asp:TextBox>&nbsp; 
						入学年份
						<asp:TextBox id="txty" runat="server" Width="72px" BorderStyle="Groove"></asp:TextBox>
						<asp:Button id="Button1" runat="server" Text="搜 索"></asp:Button><BR>
						<asp:RangeValidator id="RangeValidator1" runat="server" ErrorMessage="日期格式不对" Type="Date" ControlToValidate="txty"
							MaximumValue="3000-01-01" MinimumValue="1900-01-01"></asp:RangeValidator>
					</td>
				</TR>
				<TR>
					<TD vAlign="top">
						<asp:DataGrid id="DataGrid1" runat="server" AllowPaging="True">
							<HeaderStyle BackColor="#CCCC66"></HeaderStyle>
							<PagerStyle NextPageText="下一页" PrevPageText="上一页"></PagerStyle>
						</asp:DataGrid></TD>
				</TR>
			</TABLE>
    </form>
</body>
</html>

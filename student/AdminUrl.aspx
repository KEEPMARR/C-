﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminUrl.aspx.cs" Inherits="student.AdminUrl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <FONT face="宋体"><a href="AdminUrlAdd.aspx">功能模块添加</a>
				<asp:DataGrid id="DataGrid1" runat="server" AutoGenerateColumns="False" AllowPaging="True">
					<HeaderStyle BackColor="#CCCC66"></HeaderStyle>
					<Columns>
						<asp:BoundColumn DataField="Id" HeaderText="序号">
							<ItemStyle Width="30px"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="url" HeaderText="模块URL">
							<ItemStyle Width="150px"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="UrlName" HeaderText="模块名称">
							<ItemStyle Width="150px"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Comment" HeaderText="说明">
							<ItemStyle Width="250px"></ItemStyle>
						</asp:BoundColumn>
						<asp:HyperLinkColumn Text="删除" DataNavigateUrlField="id" ItemStyle-Width="30" DataNavigateUrlFormatString="AdminUrlDel.aspx?id={0}"
							HeaderText="删除" NavigateUrl="AdminUrlDel.aspx"></asp:HyperLinkColumn>
					</Columns>
					<PagerStyle NextPageText="下一页" PrevPageText="上一页"></PagerStyle>
				</asp:DataGrid></FONT>
    </form>
</body>
</html>

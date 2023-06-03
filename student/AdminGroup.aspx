<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminGroup.aspx.cs" Inherits="student.AdminGroup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <FONT face="宋体">
				<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="500" border="1">
					<TR>
						<TD>请选择组:
							<asp:DropDownList id="DropDownList1" runat="server" AutoPostBack="True"></asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;
							<asp:Label id="Label1" runat="server"></asp:Label>&nbsp;
							<asp:Button id="Button2" runat="server" Text="删除所选组"></asp:Button>&nbsp;
							<asp:Button id="Button1" runat="server" Text="添加新组"></asp:Button></TD>
					</TR>
					<TR>
						<TD>
							<asp:DataGrid id="DataGrid1" runat="server" AutoGenerateColumns="False" Width="440px" AllowPaging="True">
								<HeaderStyle BackColor="#CCCC66"></HeaderStyle>
								<Columns>
									<asp:TemplateColumn HeaderText="选择">
										<ItemTemplate>
											<asp:CheckBox ID="chkExPort" Checked="true" Runat="server"></asp:CheckBox>
										</ItemTemplate>
										<EditItemTemplate>
											<asp:CheckBox ID="chkExPortON" Runat="server"></asp:CheckBox>
										</EditItemTemplate>
									</asp:TemplateColumn>
									<asp:BoundColumn DataField="id" HeaderText="序号"></asp:BoundColumn>
									<asp:BoundColumn DataField="UrlName" HeaderText="功能模块"></asp:BoundColumn>
									<asp:BoundColumn DataField="Url" HeaderText="Url地址"></asp:BoundColumn>
								</Columns>
								<PagerStyle NextPageText="下一页" PrevPageText="上一页"></PagerStyle>
							</asp:DataGrid></TD>
					</TR>
					<TR>
						<TD>
							<asp:Button ID="Button3" runat="server" Text="全选"  OnClick="Button3_Click"/>
							<asp:Button id="cmdSP" runat="server" Text="设置权限"></asp:Button><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
								(注:超级管理组不可删除!)</FONT></TD>
					</TR>
				</TABLE>
			</FONT>
    </form>
</body>
</html>

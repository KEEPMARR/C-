<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="student.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 585px;
        }
        .auto-style2 {
            width: 290px;
            height: 311px;
        }
        .auto-style3 {
            height: 345px;
            width: 435px;
        }
        .auto-style4 {
            height: 358px;
            width: 734px;
        }
        </style>
</head>
<body style="height: 582px"><center>
    <form id="form1" runat="server" >
		
        <div class="auto-style1">
            <FONT face="宋体" >
				<br>
				<br>
				
				<br>
				<br>
				<TABLE align="center" cellSpacing="0" cellPadding="0" border="0" class="auto-style4">
					<asp:Label ID="Label1" runat="server" Text="学生管理系统"  Font-Size="50" Font-Names="楷体"></asp:Label>
					<TR>
						<TD><IMG alt="" src="1.jpg" class="auto-style3"></TD>
						<TD width="187" height="219">
							<TABLE id="Table3" cellSpacing="0" cellPadding="0" border="0" class="auto-style2">
								<TR>
									<TD>&nbsp;
										
											<TR>
												<TD>
													<asp:Label ID="Label2" runat="server" Text="用户名:"></asp:Label></TD>
												<TD>
													<asp:TextBox id="txtUsername" runat="server" BorderStyle="Groove" Width="129px" Height="38px"></asp:TextBox></TD>
											</TR>
											<TR>
												<TD>
													<asp:Label ID="Label3" runat="server" Text="密&nbsp; 码:"></asp:Label></TD>
												<TD>
													<asp:TextBox id="txtPassword" runat="server" TextMode="Password" BorderStyle="Groove" Width="127px" Height="33px"></asp:TextBox></TD>
											</TR>
											<TR>
												<TD></TD>
												<TD>
													<asp:Button id="Button1" runat="server" Text="确 定" Height="36px"  OnClick="Button1_Click"></asp:Button></TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
							</TABLE>
						</TD>
						
				</TABLE>
			</FONT>
        </div>
    </form>
	<center>
</body>
</html>

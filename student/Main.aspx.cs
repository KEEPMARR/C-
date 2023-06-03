using System;
using System.Web.UI;
using System.Configuration;
using System.Data.SqlClient;

namespace student
{
    
    public partial class Main : System.Web.UI.Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
		public string promiseUrl;
		private string promise;
		private string username;
		protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
				username = Session["username"].ToString();
			}
			catch
			{
				Response.Redirect("Login.aspx");
			}

			if (!Page.IsPostBack)
			{
				GetPromise();
				GetUrlByPromise();
			}
		}
		private void GetPromise()
		{
			string sql = string.Empty;
			sql = string.Format("select promise from Admin inner join AdminGroup on Admin.[Group] = AdminGroup.[Group] where username = '{0}'", username);
			
			SqlDataReader dr;
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand(sql, conn);
			try
			{
				conn.Open();
				dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					
					this.promise = dr["promise"].ToString();
				}
				
			}
			catch (Exception ex)
			{
				Response.Write(ex);
			}
			finally
			{
				conn.Close();
			}
		}


		#region 取得权限ID
		private void GetUrlByPromise()
		{
			string sql = string.Empty;
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			try
			{

				string id2e = promise; // 生成 "1,2,3,..."
				sql = string.Format("select url,urlname from AdminUrl where id in ({0})", id2e);
			}
			catch
			{
				
			}
			SqlDataReader dr;
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand(sql, conn);
			try
			{
				conn.Open();
				try
				{
					dr = cmd.ExecuteReader();
					if (dr.Read())
					{
						sb.Append("<table width=\"207\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\">");
						do
						{
							sb.Append("<tr><td width=\"207\" height=\"33\" " +
                                ">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a target=\"main\"" +
                                " href=\"" + dr["url"].ToString() + "\">" + dr["urlname"].ToString() + "</a></td></tr>\n");
						} while (dr.Read());
						sb.Append("</table>");
					}
				}
				catch
				{
					Response.Write("你输入的用户名尚未分组,或者分组信息丢失,请与管理员联系!");
				}
				promiseUrl = sb.ToString();
			}
			catch (Exception ex)
			{
				Response.Write(ex);
			}
			finally
			{
				conn.Close();
			}
		}
		#endregion


		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}

		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
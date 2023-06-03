using System;
using System.Configuration;
using System.Data.SqlClient;


namespace student
{
    public partial class AdminGradeAddNext : System.Web.UI.Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
		private void Add()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			string sql = string.Empty;
			sql = string.Format("insert into 成绩表(学号,课程号,成绩) values('{0}','{1}',{2})", Request.QueryString["学号"].ToString(), this.txtcid.Text.ToString(), this.txtgrade.Text.ToString());
			SqlCommand cmd = new SqlCommand(sql, conn);
			try
			{
				conn.Open();
				cmd.ExecuteNonQuery();
				Response.Write("<script>alert('成绩添加成功!')</script>");
			}
			catch//(Exception ex)
			{
				//Response.Write(ex);
				Response.Write("<script>alert('成绩添加失败!')</script>");
			}
			finally
			{
				conn.Close();
			}
		}
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
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			Add();
		}
		
	}
}
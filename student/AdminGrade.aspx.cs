using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace student
{
    public partial class AdminGrade : System.Web.UI.Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }
		#region 取得数据
		private void GetData()
		{
			string sql = string.Empty;
			SqlConnection conn = new SqlConnection(connectionString);
			sql = string.Format("select 成绩表.学号,姓名,课程号,成绩,性别,班级名  from 成绩表 join 学生信息表 on 成绩表.学号 = 学生信息表.学号");
			SqlDataAdapter da = new SqlDataAdapter(sql, conn);
			DataSet ds = new DataSet();
			try
			{
				da.Fill(ds, "t");
				this.DataGrid1.DataSource = ds.Tables["t"];
				this.DataGrid1.DataBind();
			}
			catch (Exception ex)
			{
				Response.Write(ex);
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
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("AdminGradeAdd.aspx");
		}
	}
}
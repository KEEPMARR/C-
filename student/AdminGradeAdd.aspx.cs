using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace student
{
    public partial class AdminGradeAdd : System.Web.UI.Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
			GetClassName();
			try
			{
				if (Request.QueryString["Action"].ToString() == "Add")
				{
					GetStu();
				}
			}
			catch
			{ }
		}
		private void GetClassName()
		{
			string sql = string.Empty;
			SqlConnection conn = new SqlConnection(connectionString);
			sql = string.Format("select 班级名 from 学生信息表 group by 班级名");
			SqlDataAdapter da = new SqlDataAdapter(sql, conn);
			DataSet ds = new DataSet();
			try
			{
				da.Fill(ds, "t");
				this.DataGrid1.DataSource = ds.Tables["t"];
				this.DataGrid1.DataBind();
			}
			catch
			{ }
		}
		private void GetStu()
		{
			string sql = string.Empty;
			SqlConnection conn = new SqlConnection(connectionString);
			sql = string.Format("select 学号,姓名,性别,班级名,所在院系 from 学生信息表 where 班级名='{0}'", Request.QueryString["班级名"].ToString());
			SqlDataAdapter da = new SqlDataAdapter(sql, conn);
			DataSet ds = new DataSet();
			try
			{
				da.Fill(ds, "t");
				this.DataGrid2.DataSource = ds.Tables["t"];
				this.DataGrid2.DataBind();
			}
			catch (Exception ex)
			{
				Response.Write(ex);
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
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			this.DataGrid2.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid2_PageIndexChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			this.DataGrid1.CurrentPageIndex = e.NewPageIndex;
			GetClassName();

		}

		private void DataGrid2_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			this.DataGrid2.CurrentPageIndex = e.NewPageIndex;
			GetStu();

		}
	}
}
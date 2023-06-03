﻿using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace student
{
    public partial class AdminStuStat : System.Web.UI.Page
    {
		private string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			GetData();

		}


		#region 取得数据
		private void GetData()
		{
			string sql = string.Empty; SqlConnection conn = new SqlConnection(connectionString);
			sql = string.Format("select 课程号,sum(成绩) as 总分,avg(成绩) as 平均分,count(学号) as 人数 from v_stuGrade group by 课程号");
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
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			this.DataGrid1.CurrentPageIndex = e.NewPageIndex;
			GetData();
		}
	}
}
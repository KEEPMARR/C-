﻿using System;
using System.Web.UI;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace student
{
    public partial class AdminStuSearch : System.Web.UI.Page
    {
		private string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
        {
			// 在此处放置用户代码以初始化页面
			if (!Page.IsPostBack)
			{
				GetStuData();
			}
		}


		#region
		private void GetStuData()
		{
			string sql = string.Empty; SqlConnection conn = new SqlConnection(connectionString);
			sql = GetSql();
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
		#endregion


		#region
		private string GetSql()
		{
			string sql = string.Empty;
			ArrayList sqlArr = new ArrayList();

			if (this.txtsid.Text.Length != 0)
			{
				sqlArr.Add(string.Format("学号 like '%{0}%' ", this.txtsid.Text.ToString()));
			}
			if (this.txtname.Text.Length != 0)
			{
				sqlArr.Add(string.Format("姓名 like '%{0}%' ", this.txtname.Text.ToString()));
			}
			if (this.txtage.Text.Length != 0)
			{
				sqlArr.Add(string.Format("年龄 like '%{0}%' ", this.txtage.Text.ToString()));
			}
			if (this.txtx.Text.Length != 0)
			{
				sqlArr.Add(string.Format("所有院系 like '%{0}%' ", this.txtx.Text.ToString()));
			}
			if (this.txty.Text.Length != 0)
			{
				sqlArr.Add(string.Format("入学年份 like '%{0}%' ", this.txty.Text.ToString()));
			}
			foreach (string str in sqlArr)
			{
				sql = sql + str + " and ";

			}
			sql = "select * from 学生信息表 where " + sql;
			int i = sql.Trim().Length - 5;
			sql = sql.Substring(0, i);
			return sql;
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
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			GetStuData();
		}

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			this.DataGrid1.CurrentPageIndex = e.NewPageIndex;
			GetStuData();
		}
	}
}
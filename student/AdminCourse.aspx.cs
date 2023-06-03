using System;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
//using 关键字

namespace student//定义命名空间
{
    public partial class AdminCourse : System.Web.UI.Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
		//获取连接字符串
		protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminCourseAdd.aspx");
        }
		#region 取得数据
		private void GetData()//定义私有方法
		{
			string sql = string.Empty;
			sql = string.Format("select * from 课程表");
			SqlConnection conn = new SqlConnection(connectionString);
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
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}

		
		private void InitializeComponent()
		{
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.DataGrid1.CancelCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_CancelCommand);
			this.DataGrid1.EditCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_EditCommand);
			this.DataGrid1.UpdateCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_UpdateCommand);
			this.DataGrid1.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_DeleteCommand);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion



		#region ExeSql
		private void ExeSql(string sql)//用于执行增、删、改
		{
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand(sql, conn);
			try
			{
				conn.Open();
				cmd.ExecuteNonQuery();
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


		//定义四个方法
		private void DataGrid1_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			this.DataGrid1.EditItemIndex = e.Item.ItemIndex;
			GetData();
		}

		private void DataGrid1_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string sid = e.Item.Cells[0].Text;
			string sql = string.Format("delete 课程表 where 课程号 = '{0}'", sid);
			ExeSql(sql);
			this.DataGrid1.EditItemIndex = -1;
			GetData();

		}

		private void DataGrid1_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			this.DataGrid1.EditItemIndex = -1;
			GetData();

		}

		private void DataGrid1_UpdateCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string sid = e.Item.Cells[0].Text;

			TextBox txtName = new TextBox();
			txtName = (TextBox)e.Item.Cells[1].Controls[0];
			string name = txtName.Text.ToString();

			TextBox txtAge = new TextBox();
			txtAge = (TextBox)e.Item.Cells[2].Controls[0];
			string age = txtAge.Text.ToString();


			string sql = string.Empty;
			sql = string.Format("update 课程表 set 课程名='{0}',先修课='{1}' where 课程号='{2}'", name, age, sid);
			ExeSql(sql);
			this.DataGrid1.EditItemIndex = -1;
			GetData();

		}
	}
}
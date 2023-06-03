using System;
using System.Configuration;
using System.Data.SqlClient;
namespace student
{
    public partial class AdminStuAdd : System.Web.UI.Page
    {
		private string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
        {

        }

		#region
		private void Add()
		{
			string sql = string.Empty;
			string sid = this.txtsid.Text.ToString();
			string name = this.txtname.Text.ToString();
			string sex = string.Empty;
			if (this.rbman.Checked)
			{
				sex = "男";
			}
			else
			{
				sex = "女";
			}
			int age = Convert.ToInt32(this.txtage.Text.ToString());
			string s = this.txts.Text.ToString();
			string classname = this.txtclassname.Text.ToString();
			string years = this.txtyear.Text.ToString();
			SqlConnection conn = new SqlConnection(connectionString);
			sql = string.Format("insert into 学生信息表(学号,姓名,性别,年龄,所在院系,班级名,入学年份 ) values('{0}','{1}','{2}',{3},'{4}','{5}','{6}')", sid, name, sex, age, s, classname, years);
			SqlCommand cmd = new SqlCommand(sql, conn);
			try
			{
				conn.Open();
				cmd.ExecuteNonQuery();
				Response.Write("<script>alert('学生信息添加成功!')</script>");
			}
			catch//(Exception ex)
			{
				//Response.Write(ex);
				Response.Write("<script>alert('该学号已经存在,添加失败!')</script>");
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
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			Add();
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("AdminStu.aspx");
		}
	}
}
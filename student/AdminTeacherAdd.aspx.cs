using System;
using System.Configuration;
using System.Data.SqlClient;

namespace student
{
    public partial class AdminTeacherAdd : System.Web.UI.Page
    {
		private string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
        {

        }
		private void Button1_Click(object sender, System.EventArgs e)
		{
			string sql = string.Empty;
			SqlConnection conn = new SqlConnection(connectionString);
			sql = string.Format("insert into 授课表(教师名,课程号,学时数,班级名) values('{0}','{1}','{2}','{3}')", this.txtTname.Text, this.txtCid.Text, this.txtTime.Text, this.txtClass.Text);
			SqlCommand cmd = new SqlCommand(sql, conn);
			try
			{
				conn.Open();
				cmd.ExecuteNonQuery();
				Response.Redirect("AdminTeacher.aspx");
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

        protected void Button2_Click(object sender, EventArgs e)
        {
			string sql = string.Empty;
			SqlConnection conn = new SqlConnection(connectionString);
			sql = string.Format("insert into 授课表(教师名,课程号,学时数,班级名) values('{0}','{1}','{2}','{3}')", this.txtTname.Text, this.txtCid.Text, this.txtTime.Text, this.txtClass.Text);
			SqlCommand cmd = new SqlCommand(sql, conn);
			try
			{
				conn.Open();
				cmd.ExecuteNonQuery();
				Response.Redirect("AdminTeacher.aspx");
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
    }
}
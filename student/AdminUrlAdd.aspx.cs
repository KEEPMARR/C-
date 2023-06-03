using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace student
{
    public partial class AdminUrlAdd : System.Web.UI.Page
    {
		private string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
        {

        }
		private void Button1_Click(object sender, System.EventArgs e)
		{
			string sql = string.Empty; 
			SqlConnection conn = new SqlConnection(connectionString);
			sql = string.Format("insert into AdminUrl(urlname,url,comment) values('{0}','{1}','{2}')", this.txtname.Text, this.txturl.Text, this.TextBox3.Text);
			SqlCommand cmd = new SqlCommand(sql, conn);
			try
			{
				conn.Open();
				cmd.ExecuteNonQuery();
				Response.Redirect("AdminUrl.aspx");
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
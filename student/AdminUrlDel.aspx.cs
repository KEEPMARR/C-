using System;
using System.Web.UI;
using System.Configuration;
using System.Data.SqlClient;
namespace student
{
    public partial class AdminUrlDel : System.Web.UI.Page
    {
		private string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DelUrl();
            }
        }

		private void DelUrl()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			string sql = string.Format("delete AdminUrl where id='{0}'", Request.QueryString["id"].ToString());
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
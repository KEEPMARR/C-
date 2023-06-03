using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace student
{
    public partial class AdminUrl : System.Web.UI.Page
    {
		private string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
        {
			if (!Page.IsPostBack)
			{
				GetUrl();
			}
		}
		private void GetUrl()
		{
			string sql = string.Empty; SqlConnection conn = new SqlConnection(connectionString);
			sql = string.Format("select * from AdminUrl");
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
	}
}
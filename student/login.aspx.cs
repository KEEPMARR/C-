using System;
using System.Configuration;
using System.Data.SqlClient;

namespace student
{
    public partial class login : System.Web.UI.Page
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void userLogin()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string user = txtUsername.Text;
            string pwd = txtPassword.Text;
            string cmdt = string.Format("select username,password,[group] from [Admin] where username='{0}' and password='{1}'", user, pwd);
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand(cmdt, conn);
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Session["username"] = dr["username"].ToString();
                    Session["group"] = dr["group"].ToString();
                    Response.Redirect("Main.aspx");
                }
                else
                {
                    Response.Write("<script>alert('用户名或者密码错误,请重新输入!')</script>");
                }
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            userLogin();
        }
    }
}
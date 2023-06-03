using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace student
{
    public partial class AdminGroup : System.Web.UI.Page
    {
		private string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;

		private string GetSelects;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if (!Page.IsPostBack)
			{
				GetGroupList();
				GetData();
			}
			JS();

		}

		#region GetData
		private void GetData()
		{
			string sql = string.Empty;
			sql = string.Format("select * from AdminUrl");
			SqlConnection conn = new SqlConnection(connectionString);
			SqlDataAdapter da = new SqlDataAdapter(sql, conn);
			DataSet ds = new DataSet();
			try
			{
				da.Fill(ds, "s");
				this.DataGrid1.DataSource = ds.Tables["s"];
				try
				{
					this.DataGrid1.DataBind();
				}
				catch
				{
					this.DataGrid1.CurrentPageIndex = 0;
					this.DataGrid1.DataBind();
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
		#endregion

		#region
		private void GetGroupList()
		{
			string sql = string.Empty;
			sql = string.Format("select id,[Group] from AdminGroup order by id asc");
			SqlDataReader dr;
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand(sql, conn);
			try
			{
				conn.Open();
				dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					this.DropDownList1.Items.Clear();
					do
					{
						ListItem ls = new ListItem(dr["group"].ToString(), dr["id"].ToString());
						this.DropDownList1.Items.Add(ls);
					} while (dr.Read());
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
		#endregion


		#region
		private void JS()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("<script language=javascript>");
			sb.Append("function Del(){");
			sb.Append("return confirm('确定要删除[" + this.DropDownList1.SelectedItem.Text + "]吗?操作将不可逆!!!');}");
			sb.Append("</script>");

			String js = sb.ToString();
			if (!IsClientScriptBlockRegistered("Del"))
			{
				RegisterClientScriptBlock("Del", js);
			}
			Button2.Attributes.Add("onclick", "return Del()");

		}
		#endregion

		#region Update method Set True;
		private void UpdateGroup()
		{
			string sql = string.Empty;
			sql = string.Format("update AdminGroup set Promise = '{0}' where [Group] = '{1}' ", GetSelects, this.DropDownList1.SelectedItem.Text.ToString());
			//Response.Write(sql);
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand(sql, conn);
			try
			{
				conn.Open();
				if (GetSelects != null)
				{
					cmd.ExecuteNonQuery();
				}
				else
				{
					Response.Write("<script>alert('您没有选择信息任何需要更新的记录?')</script>");
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

		private void InitializeComponent()
		{
			this.DropDownList1.SelectedIndexChanged += new System.EventHandler(this.DropDownList1_SelectedIndexChanged);
			this.cmdSP.Click += new System.EventHandler(this.cmdSP_Click);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		

		private void cmdSP_Click(object sender, System.EventArgs e)
		{
			System.Web.UI.WebControls.CheckBox chkExport;
			string sID;
			System.Text.StringBuilder strMsg = new System.Text.StringBuilder();
			foreach (DataGridItem oDataGridItem in this.DataGrid1.Items)
			{
				chkExport = (CheckBox)oDataGridItem.FindControl("chkExport");
				//若选中则取值
				if (chkExport.Checked)
				{
					sID = oDataGridItem.Cells[1].Text.ToString();
					strMsg.Append(sID + ",");
				}
			}
			GetSelects = strMsg.ToString().Trim();

			

			UpdateGroup();
		}

		private void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.Label1.Text = "当前选择:" + this.DropDownList1.SelectedItem.Text.ToString();
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("AdminGroupAdd.aspx");
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			Response.Write("<script>alert('你不能删除超级管理组!')</script>");

			SqlConnection conn = new SqlConnection(connectionString); 
			string sql = string.Format("delete AdminGroup where [Group]='{0}'", this.DropDownList1.SelectedItem.Text.ToString());
			SqlCommand cmd = new SqlCommand(sql, conn);
			try
			{
				conn.Open();
				if (this.DropDownList1.SelectedItem.Text.ToString() == "超级管理组")
				{

				}
				else
				{
					cmd.ExecuteNonQuery();
				}
				Response.Redirect("AdminGroup.aspx");
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

        protected void Button3_Click(object sender, EventArgs e)
        {
			System.Web.UI.WebControls.CheckBox chkExport;
			if (Button3.Text == "全选")
			{
				foreach (DataGridItem oDataGridItem in this.DataGrid1.Items)
				{
					//建立CheckBox的引用
					chkExport = (CheckBox)oDataGridItem.FindControl("chkExport");
					chkExport.Checked = true;
				}
				Button3.Text = "全消";
			}
			else
			{
				foreach (DataGridItem oDataGridItem in this.DataGrid1.Items)
				{
					chkExport = (CheckBox)oDataGridItem.FindControl("chkExport");
					chkExport.Checked = false;
				}
				Button3.Text = "全选";
			}
		}
    }

}
using System;
using System.Data.SqlClient;
namespace online_library.project
{
    public partial class finerecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
            SqlConnection a = new SqlConnection(s);
            string k = "select * from  fine " ;
            SqlCommand g = new SqlCommand(k, a);
            a.Open();
            SqlDataReader f = g.ExecuteReader();
            if (f.HasRows)
            {
                GridView1.DataSource = f;
                GridView1.DataBind();
                a.Close();
            }
            else
            {
                Response.Write("<script>alert('No record found');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
} 
using System;
using System.Data.SqlClient;
namespace online_library.project
{
    public partial class bookid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
            SqlConnection a = new SqlConnection(s);
            string k = "select * from  addbook where Book_Name='"+TextBox1.Text+"'";
            SqlCommand g = new SqlCommand(k, a);
            a.Open();
            SqlDataReader n = g.ExecuteReader();
            
            if (n.HasRows)
            {
                GridView1.DataSource = n;
                GridView1.DataBind();
                GridView1.Visible = true;
            }
            else
            {
                Response.Write("<script>alert('No book Found');</script>");
                GridView1.Visible = false;
            }
            a.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}
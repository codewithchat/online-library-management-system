using System;
using System.Data.SqlClient;
namespace online_library.project
{
    public partial class reset1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string o = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
            SqlConnection a = new SqlConnection(o);
            string k = "select * from que";
            SqlCommand g = new SqlCommand(k, a);
            a.Open();
            SqlDataReader n = g.ExecuteReader();
            while (n.Read())
            {

                if (TextBox1.Text == n.GetString(0) && TextBox2.Text == n.GetString(1)&&TextBox3.Text==n.GetString(2))
                {
                    Response.Redirect("resetpass.aspx");

                }
                else
                {
                    Response.Write("<script>alert('Enter wrong details');</script>");
                }

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}
using System;
using System.Data.SqlClient;

namespace online_library.project
{
    public partial class reset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
            SqlConnection a = new SqlConnection(s);
            string k = "Insert into que (q1,q2,code)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            SqlCommand g = new SqlCommand(k, a);
            a.Open();
            int f = g.ExecuteNonQuery();
            if(f==1)
            {
                Response.Write("<script>alert('update Successfully');</script>");
                Response.Redirect("choosepass.aspx");
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}
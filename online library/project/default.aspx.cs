using System;
using System.Data.SqlClient;
namespace online_library.project
{
    public partial class _default : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int z=0,d=0;

            if(TextBox1.Text=="")

            {
                z = 1;
            }
            if(TextBox2.Text=="")
            {
                z = 1;
            }
            if (z==0)
            {
                string o = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
                SqlConnection a = new SqlConnection(o);
                string k = "select * from ab";
                SqlCommand g = new SqlCommand(k, a);
                a.Open();
                SqlDataReader n = g.ExecuteReader();
                while (n.Read())
                {
                    if (TextBox1.Text == n.GetString(0) && TextBox2.Text == n.GetString(1))
                    {
                        a.Close();
                        k = "delete from ab where uname='viveklib' ";
                        g = new SqlCommand(k, a);
                        a.Open();
                         d=  g.ExecuteNonQuery();
                    }
                    if (d == 1)
                    {
                        Response.Redirect("chooseanswer.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('wrong password');</script>");
                    }
                }
                a.Close();
                k = "select * from login";
                g = new SqlCommand(k, a);
                a.Open();
                n = g.ExecuteReader();
                while (n.Read())
                {
                    if (TextBox1.Text == n.GetString(0) && TextBox2.Text == n.GetString(1))
                    {
                        Response.Redirect("Home.aspx");

                    }
                    else
                    {
                        Response.Write("<script>alert('Wrong username and password');</script>");
                    }

                }
            }
            else
            {
                Response.Write("<script>alert('please fill all the fields');</script>");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("reset.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("changepass.aspx");
        }
    }
}

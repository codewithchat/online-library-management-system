using System;
using System.Data.SqlClient;

namespace online_library.project
{
    public partial class changepass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int v = 0;
            string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
            SqlConnection a = new SqlConnection(s);
            string k = "select * from login";
            SqlCommand g = new SqlCommand(k, a);
            a.Open();
            SqlDataReader n = g.ExecuteReader();
            while (n.Read())
            {

                if (TextBox1.Text == n.GetString(1))
                {

                    v = 1;

                }


            }
            a.Close();
            if (v == 1)
            {
                k = "update login set pass='" + TextBox2.Text + "'";
                g = new SqlCommand(k, a);
                a.Open();
                int i = g.ExecuteNonQuery();
                if (i == 1)
                {
                    {
                        Response.Write("<script>alert('password change Sucesssfully');</script>");
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('old password is not matched');</script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}
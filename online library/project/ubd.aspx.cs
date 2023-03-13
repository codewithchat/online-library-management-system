using System;
using System.Data.SqlClient;

namespace online_library.project
{
    public partial class ubd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int v = 0;
            string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
            SqlConnection a = new SqlConnection(s);
            string k = "select * from addbook";
            SqlCommand g = new SqlCommand(k, a);
            a.Open();
            SqlDataReader n = g.ExecuteReader();
            while (n.Read())
            {

                if (TextBox1.Text == Convert.ToString(n.GetInt32(0)))
                {

                    TextBox2.Text = n.GetString(1);
                    TextBox3.Text = n.GetString(2);
                    TextBox4.Text = n.GetString(3);
                    TextBox5.Text = n.GetString(4);
                    v = 1;
                    TextBox1.Enabled = false;
                }


            }
            if (v == 1)
            {
            }
            else
            {

                Response.Write("<script>alert('No book Found');</script>");

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
            SqlConnection a = new SqlConnection(s);
            string k = " UPDATE addbook set Book_Name='" + TextBox2.Text + "',publisher='" + TextBox3.Text + "',Edition='" + TextBox4.Text + "',writer='" + TextBox5.Text + "' where( Book_id=" + TextBox1.Text + " )";
            SqlCommand g = new SqlCommand(k, a);
            a.Open();
            int f = g.ExecuteNonQuery();
            if (f == 1)
            {
                Response.Write("<script>alert('Update Successfully');</script>");
                a.Close();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}
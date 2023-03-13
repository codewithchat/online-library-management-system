using System;
using System.Data.SqlClient;

namespace online_library.project
{
    public partial class cpass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == TextBox2.Text)
            {
                string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
                SqlConnection a = new SqlConnection(s);
                string k = "Insert into login(uname,pass)values('viveklib','"+TextBox1.Text+"')";
                SqlCommand g = new SqlCommand(k, a);
                a.Open();
                int f = g.ExecuteNonQuery();
                if (f == 1)
                {
                    a.Close();
                    Response.Write("<script>alert('update Successfully');</script>");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                }
            }
            else
            {
                Response.Write("<script>alert('confirm password is not matched');</script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
            }

        }
    }
}
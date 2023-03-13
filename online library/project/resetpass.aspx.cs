using System;
using System.Data.SqlClient;
namespace online_library.project
{
    public partial class resetpass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            if(TextBox1.Text==TextBox2.Text)
            {
                x = 1;
              
            }
         
                if (x == 1)
                {
                    string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
                    SqlConnection a = new SqlConnection(s);
                    string k = "update login set pass='" + TextBox2.Text + "'";
                    SqlCommand g = new SqlCommand(k, a);
                    a.Open();
                    int i = g.ExecuteNonQuery();
                    if (i == 1)
                    {
                        
                            Response.Write("<script>alert('password Reset Sucesssfully');</script>");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                        
                    }
                
                else
                {
                    Response.Write("<script>alert('password not changed');</script>");
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


        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }

}
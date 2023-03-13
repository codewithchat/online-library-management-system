using System;
using System.Data.SqlClient;
namespace online_library.project
{
    public partial class deletestudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int v = 0;
            string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
            SqlConnection a = new SqlConnection(s);
            string k = "select * from addstudent";
            SqlCommand g = new SqlCommand(k, a);
            a.Open();
            SqlDataReader n = g.ExecuteReader();
            v = 2;
            while (n.Read())
            {

                if (TextBox1.Text == Convert.ToString(n.GetInt32(0)))
                {

                    TextBox2.Text = n.GetString(1);
                    TextBox3.Text = n.GetString(2);
                    TextBox4.Text = n.GetString(3);
                    TextBox5.Text = n.GetString(4);
                    Image1.ImageUrl = n.GetString(5);
                    v = 1;

                }


            }
            if (v == 1)
            {
            }
           else
            {

                Response.Write("<script>alert('No Student Found');</script>");

                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text ="";
                TextBox5.Text ="";

            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
            SqlConnection a = new SqlConnection(s);
            string k = "delete from addstudent where Student_Name='" + TextBox2.Text + "' AND Father_Name='" + TextBox3.Text + "' AND class='" + TextBox4.Text + "' AND Mobile_no='" + TextBox5.Text + "'";
            SqlCommand g = new SqlCommand(k, a);
            a.Open();
            int m = g.ExecuteNonQuery();
            if(m==1)
            {
                Response.Write("<Script>alert('Delete Student Successfully');</Script>");

                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                Image1.ImageUrl = "";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}
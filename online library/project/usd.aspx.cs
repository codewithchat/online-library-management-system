using System;
using System.Data.SqlClient;

namespace online_library.project
{
    public partial class usd : System.Web.UI.Page
    {
        static string q;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int v = 0;
            string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
            SqlConnection a = new SqlConnection(s);
            string k = "select * from addstudent";
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
                    Image1.ImageUrl = n.GetString(5);
                    v = 1;
                    TextBox1.Enabled = false;
                    TextBox2.Enabled = false;
                }


            }
            if (v == 1)
            {
            }
            else
            {

                Response.Write("<script>alert('No Student Found');</script>");

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string x = null;

            string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";

            SqlConnection a = new SqlConnection(s);
            string k = " UPDATE addstudent set Student_Name='" + TextBox2.Text + "',Father_Name='" + TextBox3.Text + "',class='" + TextBox4.Text + "',Mobile_no='" + TextBox5.Text + "',photo='" + q + "' where( Student_id=" + TextBox1.Text + " )";
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
                Image1.ImageUrl = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string j;
                q = FileUpload1.FileName;
                string p = Server.MapPath(q);
                FileUpload1.SaveAs(p);
                Image1.ImageUrl = q;
        }
    }
    }

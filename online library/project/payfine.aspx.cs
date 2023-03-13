using System;
using System.Data.SqlClient;

namespace online_library.project
{
    public partial class payfine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int v = 0;
            string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
            SqlConnection a = new SqlConnection(s);
            string k = "select * from fine";
            SqlCommand g = new SqlCommand(k, a);
            a.Open();
            SqlDataReader n = g.ExecuteReader();
            string d = "Not paid";
            while (n.Read())
            {
                Response.Write(TextBox1.Text);

                if (TextBox1.Text == Convert.ToString(n.GetInt32(1)) && d==n.GetString(8))
                {
                   
                    v = 1;
                }


            }
            if (v == 1)
            {
                int z = Convert.ToInt32(TextBox1.Text);
                a = new SqlConnection(s);
                k = "select * from fine where Std_id="+z+"";
                g = new SqlCommand(k, a);
                a.Open();
                n = g.ExecuteReader();
                GridView1.DataSource = n;
                GridView1.DataBind();
                Table1.Visible = true;
                Button4.Visible = true;
            }
            else
            {

                Response.Write("<script>alert('No fine record Found');</script>");

            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int r = 1;
            if (TextBox3.Text == "")
            {
                r = 0;
            }
            if (r == 1)
            {
                int v = 0;
                string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
                SqlConnection a = new SqlConnection(s);
                int u = Convert.ToInt32(TextBox1.Text);
                string k = "UPDATE fine set  pay_date='" + TextBox2.Text + "',status='" + TextBox3.Text + "' where(Std_id=" + u + ")";
                SqlCommand g = new SqlCommand(k, a);
                a.Open();
                int f = g.ExecuteNonQuery();
                if (f == 1)
                {
                    Response.Write("<script>alert('paid Successfully');</script>");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    GridView1.Visible = false;
                }
            }
            else
            {
                Response.Write("<script>alert('Write piad inside the status textbox for paying fine');</script>");
            }
        }
    }
}
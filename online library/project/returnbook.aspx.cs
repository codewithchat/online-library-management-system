using System;
using System.Data.SqlClient;
namespace online_library.project
{
    public partial class returnbook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
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

                    TextBox3.Text = n.GetString(1);
                    TextBox5.Text = n.GetString(2);
                    TextBox7.Text = n.GetString(4);
                    v = 1;

                }


            }
            if (v == 1)
            {
            }
            else
            {

                Response.Write("<script>alert('No Book Found');</script>");

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
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

                if (TextBox2.Text == Convert.ToString(n.GetInt32(0)))
                {

                    TextBox4.Text = n.GetString(1);
                    TextBox6.Text = n.GetString(3);
                    v = 1;

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

        protected void Button2_Click(object sender, EventArgs e)
        {

            int v = 0,t=0;
            DateTime j=new DateTime();
            string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
            SqlConnection a = new SqlConnection(s);
            string k = "select * from " + (TextBox4.Text.ToUpperInvariant()).Replace(" ", "") + "" + TextBox2.Text + "";
            SqlCommand g = new SqlCommand(k,a);
            a.Open(); 
            SqlDataReader h = g.ExecuteReader();
            while(h.Read())
            {
                if (TextBox1.Text == Convert.ToString(h.GetInt32(0)))
                {
                    j =Convert.ToDateTime( h.GetString(2));
                }
            }
            
            DateTime l = Convert.ToDateTime(TextBox8.Text);
            Double m = (l - j).TotalDays;
            double b= m - 10;
            double p = b * 5;
            a.Close();
           
                k = " UPDATE " + (TextBox4.Text.ToUpperInvariant()).Replace(" ", "") + "" + TextBox2.Text + " set Return_date='" + TextBox8.Text + "' where( Book_name='" + TextBox3.Text + "'AND Return_date='Not Return' )";
                g = new SqlCommand(k, a);
                a.Open();
                int f = g.ExecuteNonQuery();
                if (f == 1)
                {
                    Response.Write("<script>alert('Book Return Successfully');</script>");
                   
                }
                else
                {

                    Response.Write("<script>alert('NO Issue Record found');</script>");
                t = 1;
                }
            a.Close();
            if (m > 10 && t==0)
            {
                string r = Convert.ToString(p);
                string n = Convert.ToString(m);
                Response.Write("<script>alert('you return book after 10 days so you pay fine');</script>");
                k = "Insert into fine(Book_id,Std_id,Std_name,Book_name,Issue_date,Return_date,Extra_days,fine)values(" + TextBox1.Text + "," + TextBox2.Text + ",'" + TextBox4.Text + "','" + TextBox3.Text + "','" + j + "','"+ TextBox8.Text + "','" + b + "','" + p + "')";
                g = new SqlCommand(k, a);
                a.Open();
                int y = g.ExecuteNonQuery();
            
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}
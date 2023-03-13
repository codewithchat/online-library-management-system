using System;
using System.Data.SqlClient;


namespace online_library.project
{
    public partial class issuebook : System.Web.UI.Page
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
            int m = 0,r=0,v=0;
             string h,l;
            string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
            SqlConnection a = new SqlConnection(s);
            string k = "select * from  " + (TextBox4.Text.ToUpperInvariant()).Replace(" ", "") + "" + TextBox2.Text + "";
            SqlCommand g = new SqlCommand(k, a);
            a.Open();
            SqlDataReader n = g.ExecuteReader();
            while (n.Read())
            {
                l = n.GetString(1);
                  h =n.GetString(3);      
               if(TextBox3.Text==l && h=="Not Return")
                {
                    r = r + 1;
                }
                if (h=="Not Return")
                {
                   
                    m = m + 1;
                    

                }
   

            }

            if (m<3 && r==0)
            {
                a.Close();

                k = "select * from  fine";
                g = new SqlCommand(k, a);
                a.Open();
                n= g.ExecuteReader();
                string b = "Not paid";
                while (n.Read())
                {
                    if (TextBox2.Text == Convert.ToString(n.GetInt32(1)) && b == n.GetString(8))
                    {
                        v = 1;

                    }
                }
                a.Close();
                if (v == 0)
                {
                    string j = "Insert into " + (TextBox4.Text.ToUpperInvariant()).Replace(" ", "") + "" + TextBox2.Text + "(Book_id,Book_name,Issue_date)values('" + TextBox1.Text + "','" + TextBox3.Text + "','" + TextBox8.Text + "')";
                    a.Open();
                    g = new SqlCommand(j, a);
                    int z = g.ExecuteNonQuery();
                    if (z == 1)
                    {
                        Response.Write("<script>alert('Book Issued');</script>");
                        a.Close();
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        TextBox8.Text = "";
                    }
                }
                else
                {
                    Response.Write("<script>alert('First you pay previous fine');</script>");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                    TextBox8.Text = "";
                }
               
            }
            if(r>0)
            {
                Response.Write("<script>alert('You issue this book previously and not returned');</script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
            }
            if (m >= 3)
            {
                Response.Write("<script>alert('Three Book is already Issued');</script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        
    }
}
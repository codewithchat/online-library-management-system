using System;
using System.Data.SqlClient;


namespace online_library.project
{
    public partial class addbook : System.Web.UI.Page
    {
        int m;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
          
               if(TextBox2.Text=="")
                {
                i = 1;
            }
                if (TextBox3.Text == "")
                {
                i = 1;
            }
            if (TextBox4.Text =="")
            {
                i = 1;
            }
            if (TextBox5.Text == "")
            {
                i = 1;
            }
            if (i == 0)
            {
                string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
                SqlConnection a = new SqlConnection(s);
                string k = "select * from addbook";
                SqlCommand g = new SqlCommand(k, a);
                a.Open();
                SqlDataReader n = g.ExecuteReader();

                m = 2;
                while (n.Read())
                {

                    if ((TextBox2.Text.ToUpperInvariant()).Replace(" ", "") == (n.GetString(1).ToUpperInvariant()).Replace(" ", "") && (TextBox3.Text.ToUpperInvariant()).Replace(" ", "") == (n.GetString(2).ToUpperInvariant()).Replace(" ", "") && (TextBox4.Text.ToUpperInvariant()).Replace(" ", "") == (n.GetString(3).ToUpperInvariant()).Replace(" ", "") && (TextBox5.Text.ToUpperInvariant()).Replace(" ", "") == (n.GetString(4).ToUpperInvariant()).Replace(" ", ""))
                    {
                        m = 0;


                    }
                    else
                    {

                        m = 1;

                    }

                }

                if (m == 1 || m == 2)
                {
                    a.Close();
                    string j = "Insert into addbook (Book_name,publisher,Edition,writer)values('" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
                    a.Open();
                    g = new SqlCommand(j, a);

                    int z = g.ExecuteNonQuery();
                    if (z == 1)
                    {
                        Response.Write("<script>alert('Book Add successfully');</script>");
                    }
                    k = "select * from addbook";
                    g = new SqlCommand(k, a);
                    n = g.ExecuteReader();
                    while (n.Read())
                    {

                        if (TextBox2.Text == n.GetString(1) && TextBox3.Text == n.GetString(2) && TextBox4.Text == n.GetString(3) && TextBox5.Text == n.GetString(4))
                        {

                            Int32 l = n.GetInt32(0);
                            TextBox1.Text = Convert.ToString(l);
                            TextBox2.Text = "";
                            TextBox3.Text = "";
                            TextBox4.Text = "";
                            TextBox5.Text = "";

                        }
                    }
                }
                else
                {
                    Response.Write("<script>alert('Book is already Register');</script>");
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                }
            }
            else
            {
                Response.Write("<script>alert('please fill all the fields');</script>");
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
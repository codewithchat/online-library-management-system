using System;
using System.Data.SqlClient;


namespace online_library.project
{
    public partial class studentrecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int f=0;
            string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\online library\online library\App_Data\onlinelibrary.mdf;Integrated Security=True";
            SqlConnection a = new SqlConnection(s);
            string k = "select * from  " + (TextBox2.Text.ToUpperInvariant()).Replace(" ", "") + "" + TextBox1.Text + "";
            SqlCommand g = new SqlCommand(k, a);
            a.Open();
            SqlDataReader n = null;
            try
            {
                n = g.ExecuteReader();
                if (n.HasRows)
                {
                    f = 1;
                }
                else
                {
                    Response.Write("<script>alert('No student record Found');</script>");
                    GridView1.Visible = false;
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                }
                if (f == 1)
                {
                    GridView1.DataSource = n;
                    GridView1.DataBind();
                    GridView1.Visible = true;
                    a.Close();
                    Label1.Text = TextBox2.Text;
                    Label1.Visible = true;
                    a = new SqlConnection(s);
                    k = "select * from addstudent";
                    g = new SqlCommand(k, a);
                    a.Open();
                    n = g.ExecuteReader();

                    while (n.Read())
                    {

                        if (TextBox1.Text == Convert.ToString(n.GetInt32(0)))
                        {

                            Image1.ImageUrl = n.GetString(5);
                            Image1.Visible = true;

                        }


                    }

                }
            }
            catch (Exception b)
            {
                Response.Write("<script>alert('Student does not exist');</script>");
               
            } 

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace online_library.project
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("addbook.aspx");
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("deletebook.aspx");
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("issuebook.aspx");
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("returnbook.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("addstudent.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("deletestudent.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("search.aspx");
        }

        protected void Button9_Click1(object sender, EventArgs e)
        {
            Response.Redirect("update.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("fine.aspx");
        }

       
    }
}
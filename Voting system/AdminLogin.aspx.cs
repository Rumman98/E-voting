using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Voting_system
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            String user, pass;
            user = username.Text;
            pass = password.Text;
            if(user=="ADMIN"&&pass=="12345")
            {
               Response.Write("<script>alert('Successfully logged in')</script>");
                Response.Redirect("AdminPortal.aspx", true);
            }
            else
            {
                Response.Write("<script>alert('Incorrect username or password')</script>");
            }
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("startPage.aspx", true);
        }
    }
}
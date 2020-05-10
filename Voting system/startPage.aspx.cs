using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Voting_system
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void admin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx", true);
        }

        protected void voter_Click(object sender, EventArgs e)
        {
            Response.Redirect("Voter.aspx", true);
        }
    }
}
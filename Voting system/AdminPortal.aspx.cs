using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Voting_system
{
    public partial class AdminPortal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insertdata_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertData.aspx", true);
        }

        protected void count_Click(object sender, EventArgs e)
        {
            Response.Redirect("SeeCount.aspx", true);
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("startPage.aspx", true);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("voter_database.aspx", true);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("InsertData.aspx", true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
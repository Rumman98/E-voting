using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Voting_system
{
    public partial class SeeCount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void refresh_Click(object sender, EventArgs e)
        {
        
            string data = "Data Source=DESKTOP-J1NS0B9;Initial Catalog=vote;Integrated Security=True";
            SqlConnection conn = new SqlConnection(data);
            conn.Open();
            String s = "SELECT Count(Awamelegue) from vote_information";
            SqlCommand cmd1 = new SqlCommand(s, conn);
            Int32 a = Convert.ToInt32(cmd1.ExecuteScalar());
            cawm.Text = a.ToString();

            String s2 = "SELECT Count(BNP) from vote_information";
            SqlCommand cmd2 = new SqlCommand(s2, conn);
            Int32 b = Convert.ToInt32(cmd2.ExecuteScalar());
            cbnp.Text = b.ToString();

            String s3 = "SELECT Count(Jatiyo_party) from vote_information";
            SqlCommand cmd3 = new SqlCommand(s3, conn);
            Int32 c = Convert.ToInt32(cmd3.ExecuteScalar());
            cjp.Text = c.ToString();

            String s4 = "SELECT Count(Jamayat) from vote_information";
            SqlCommand cmd4 = new SqlCommand(s4, conn);
            Int32 d = Convert.ToInt32(cmd4.ExecuteScalar());
            cjip.Text = d.ToString();

            String s5 = "SELECT Count(No_Vote) from vote_information";
            SqlCommand cmd5 = new SqlCommand(s5, conn);
            Int32 f = Convert.ToInt32(cmd5.ExecuteScalar());
            cno.Text = f.ToString();








        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPortal.aspx", true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("vote_data.aspx", true);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPortal.aspx", true);
        }
    }
}
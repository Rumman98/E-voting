using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Voting_system
{
    public partial class Voter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("startPage.aspx", true);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string str = "Data Source=DESKTOP-J1NS0B9;Initial Catalog=Voter_info;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            
                String s = "UPDATE voter_details SET NID=NULL WHERE NID=@num";
            SqlCommand cmd1 = new SqlCommand(s, conn);
                cmd1.Parameters.AddWithValue("@num", nid.Text);
            if(cmd1.ExecuteNonQuery()==1)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Data successfully matched')</script>");
                Response.Redirect("vote.aspx", true);
            }
            else if(cmd1.ExecuteNonQuery() != 1)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Data not matched')</script>");
                nid.Text = String.Empty;
            }
            
            
        }

        protected void nid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 
    

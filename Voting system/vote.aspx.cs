using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Voting_system
{
    public partial class Count : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void selectparty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void confirm_Click(object sender, EventArgs e)
        {
            try {
                string data = "Data Source=DESKTOP-J1NS0B9;Initial Catalog=vote;Integrated Security=True";
                SqlConnection conn = new SqlConnection(data);
                conn.Open();

                if (R.SelectedItem.Value.ToString() == "Awamilegue")
                {
                    String vawm = "Awamelegue";
                    String insert1 = "INSERT INTO vote_information(Awamelegue) VALUES('" + vawm + "')";
                    SqlCommand cmd = new SqlCommand(insert1, conn);
                    cmd.ExecuteNonQuery();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Your Vote is Successfull')</script>");
                    Response.Redirect("startPage.aspx", true);
                }
                else if (R.SelectedItem.Value.ToString() == "BNP")
                {
                    String vbnp = "BNP";
                    String insert2 = "INSERT INTO vote_information(BNP) VALUES('" + vbnp + "')";
                    SqlCommand cmd = new SqlCommand(insert2, conn);
                    cmd.ExecuteNonQuery();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Your Vote is Successfull')</script>");
                    Response.Redirect("startPage.aspx", true);
                }
                else if (R.SelectedItem.Value.ToString() == "Jamayat islami party")
                {
                    String vjip = "Jatiya islami party";
                    String insert3 = "INSERT INTO vote_information(Jamayat) VALUES('" + vjip + "')";
                    SqlCommand cmd = new SqlCommand(insert3, conn);
                    cmd.ExecuteNonQuery();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Your Vote is Successfull')</script>");
                    Response.Redirect("startPage.aspx", true);
                }
                else if (R.SelectedItem.Value.ToString() == "Jatiya party")
                {
                    String vjp = "Jatiya party";
                    String insert4 = "INSERT INTO vote_information(Jatiyo_party) VALUES('" + vjp + "')";
                    SqlCommand cmd = new SqlCommand(insert4, conn);
                    cmd.ExecuteNonQuery();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Your Vote is Successfull')</script>");
                    Response.Redirect("startPage.aspx", true);
                }
                else if (R.SelectedItem.Value.ToString() == "Na Vote")
                {
                    String vno = "Na Vote";
                    String insert5 = "INSERT INTO vote_information(No_Vote) VALUES('" + vno + "')";
                    SqlCommand cmd = new SqlCommand(insert5, conn);
                    cmd.ExecuteNonQuery();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Your Vote is Successfull')</script>");
                    Response.Redirect("startPage.aspx", true);

                }
            }
            catch(Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('must select a option')</script>");
            }
            
        }

        protected void R_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
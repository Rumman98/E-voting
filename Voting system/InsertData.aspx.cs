using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Voting_system
{

    public partial class InsertData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPortal.aspx", true);
        }

        protected void insert_Click(object sender, EventArgs e)
        {
          
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                conn.Open();
                String insert = "INSERT INTO Voter_details(Name,NID,Father,Mother) VALUES(@Name,@NID,@Father,@Mother)";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@Name", name.Text);
                cmd.Parameters.AddWithValue("@NID", nid.Text);
                cmd.Parameters.AddWithValue("@Father", father.Text);
                cmd.Parameters.AddWithValue("@Mother", mother.Text);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Data Successfully saved')</script>");
                    clear();
                }
                else 
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Please Insert All data')</script>");
                }



            
   
                

        }
        public void clear()
        {
            name.Text = String.Empty;
            nid.Text = String.Empty;
            father.Text = String.Empty;
            mother.Text = String.Empty;
        }

        protected void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
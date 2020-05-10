using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Voting_system
{
    public partial class vote_data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string data = "Data Source=DESKTOP-J1NS0B9;Initial Catalog=vote;Integrated Security=True";
            SqlConnection conn = new SqlConnection(data);
            conn.Open();
            String query = "SELECT [Awamelegue],[BNP],[Jamayat],[Jatiyo_party],[No_Vote] FROM [dbo].[vote_information]";
            SqlCommand cmd = new SqlCommand(query, conn);
            GridView1.DataSource = getData(query);
            GridView1.DataBind();

        }

        public DataTable getData(string query)
        {
            string data = "Data Source=DESKTOP-J1NS0B9;Initial Catalog=vote;Integrated Security=True";
            SqlConnection conn = new SqlConnection(data);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SeeCount.aspx", true);
        }
    }
}
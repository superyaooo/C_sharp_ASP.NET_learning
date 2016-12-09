using System;
using System.Data.SqlClient;

namespace UsingRepeater
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            conn = new SqlConnection("Server=(localdb)\\Projects;" +
                "Database=Dorknozzle;Integrated Security=True");
            comm = new SqlCommand(
                "SELECT EmployeeID, Name, Username, Password " +
                "FROM Employees", conn);
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                myRepeater.DataSource = reader;
                myRepeater.DataBind();
                reader.Close();
            }
            catch
            {
                Response.Write("Error retrieving user data.");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
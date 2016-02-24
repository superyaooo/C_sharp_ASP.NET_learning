using System;
using System.Data.SqlClient;

namespace AccessingData
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(
                "Server=(localdb)\\Projects;Database=Dorknozzle;" +
                "Integrated Security=True");
            SqlCommand comm = new SqlCommand(
                "SELECT EmployeeID, Name FROM Employees", conn);
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            
            while(reader.Read())
            {
                employeesLabel.Text += reader["Name"] + "<br/>";
            }

            reader.Close();
            conn.Close();
        }
    }
}
using System;
using System.Data.SqlClient;

namespace QueryParameters
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            conn = new SqlConnection("Server=(localdb)\\Projects;" +
                "Database=Dorknozzle;Integrated Security=True");
            comm = new SqlCommand(
                "SELECT EmployeeID, Name, Username, Password " +
                "FROM Employees WHERE EmployeeID=@EmployeeID", conn);
            int employeeID;
            if(!int.TryParse(idTextBox.Text, out employeeID))
            {
                userLabel.Text = "Please enter a numeric ID!";
            }
            else
            {
                comm.Parameters.Add("@EmployeeID", System.Data.SqlDbType.Int);
                comm.Parameters["@EmployeeID"].Value = employeeID;
                try
                {
                    conn.Open();
                    reader = comm.ExecuteReader();
                    if (reader.Read())
                    {
                        userLabel.Text = "Employee ID: " +
                            reader["EmployeeID"] + "<br/>" +
                            "Name: " + reader["Name"] + "<br/>" +
                            "Username: " + reader["Username"] + "<br/>" +
                            "Password: " + reader["Password"];
                    }
                    else
                    {
                        userLabel.Text =
                            "There is no user with this ID: " + employeeID;
                    }
                    reader.Close();
                    conn.Close();
                }
                catch
                {
                    userLabel.Text = "Error retrieving user data.";
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
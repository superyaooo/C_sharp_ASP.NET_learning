using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Dorknozzle
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindList();
            }
        }
        
        protected void BindList()
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString =
                ConfigurationManager.ConnectionStrings[
                "Dorknozzle"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand(
                "SELECT EmployeeID, Name, Username FROM Employees",
                conn);
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();

                //employeesRepeater.DataSource = reader;
                //employeesRepeater.DataBind();
                employeesList.DataSource = reader;
                employeesList.DataBind();

                reader.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        protected void employeesList_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if(e.CommandName=="MoreDetailsPlease")
            {
                Literal li;
                li = (Literal)e.Item.FindControl("extraDetailsLiteral");
                li.Text = "Employee ID: <strong>" + e.CommandArgument +
                    "</strong><br/>";
            }
            else if(e.CommandName=="EditItem")
            {
                employeesList.EditItemIndex = e.Item.ItemIndex;
                BindList();
            }
            else if(e.CommandName=="CancelEditing")
            {
                employeesList.EditItemIndex = -1;
                BindList();
            }
            else if(e.CommandName=="UpdateItem")
            {
                int employeeId = Convert.ToInt32(e.CommandArgument);
                TextBox nameTextBox =
                    (TextBox)e.Item.FindControl("nameTextBox");
                string newName = nameTextBox.Text;
                TextBox usernameTextBox =
                    (TextBox)e.Item.FindControl("usernameTextBox");
                string newUsername = usernameTextBox.Text;
                UpdateItem(employeeId, newName, newUsername);
                employeesList.EditItemIndex = -1;
                BindList();
            }
        }

        private void UpdateItem(int employeeId, string newName, string newUsername)
        {
            SqlConnection conn;
            SqlCommand comm;
            string connectionString =
                ConfigurationManager.ConnectionStrings[
                "Dorknozzle"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("UpdateEmployee", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.Parameters.Add("@EmployeeID", SqlDbType.Int);
            comm.Parameters["@EmployeeID"].Value = employeeId;
            comm.Parameters.Add("@NewName", SqlDbType.NVarChar, 50);
            comm.Parameters["@NewName"].Value = newName;
            comm.Parameters.Add("@NewUsername", SqlDbType.NVarChar, 50);
            comm.Parameters["@NewUsername"].Value = newUsername;
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
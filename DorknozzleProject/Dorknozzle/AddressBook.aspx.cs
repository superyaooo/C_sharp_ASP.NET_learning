using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dorknozzle
{
    public partial class AddressBook : System.Web.UI.Page
    {
        protected void grid_Sorting(object sender, GridViewSortEventArgs e)
        {
            grid.DataBind();
        }

        protected void employeeDetails_ItemUpdated(object sender,
            DetailsViewUpdatedEventArgs e)
        {
            grid.DataBind();
        }

        protected void employeeDetails_ItemDeleted(object sender,
            DetailsViewDeletedEventArgs e)
        {
            grid.DataBind();
        }

        protected void employeeDetails_ItemInserted(object sender,
            DetailsViewInsertedEventArgs e)
        {
            grid.DataBind();
        }

        protected void addEmployeeButton_Click(object sender, EventArgs e)
        {
            employeeDetails.ChangeMode(DetailsViewMode.Insert);
        }
    }
}
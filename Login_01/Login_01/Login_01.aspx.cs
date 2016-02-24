using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_01
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                submitButton.Text = "Valid";
            }
            else
            {
                submitButton.Text = "Invalid!";
            }
        }
    }
}
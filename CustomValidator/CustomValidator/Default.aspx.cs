using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomValidator
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void submitButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                submitButton.Text = "Valid";
            }
            else
            {
                submitButton.Text = "Invalid!";
            }
        }

        protected void CheckUniqueUserName(object source, ServerValidateEventArgs args)
        {
            string username = args.Value.ToLower();
            if(username=="andrei"||username=="cristian")
            {
                args.IsValid = false;
            }
        }
    }
}
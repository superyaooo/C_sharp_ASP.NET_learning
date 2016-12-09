using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsingStyles
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void addToCartButton_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add(new ListItem(productsList.Text + "-" + quantityTextBox.Text));
            lblCart.Visible = true;
        }
    }
}
using System;
using System.Web.UI.HtmlControls;

namespace PlaceHolder
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlButton myButton = new HtmlButton();
            myButton.InnerText = "My New Button";
            myPlaceHolder.Controls.Add(myButton);
        }
    }
}
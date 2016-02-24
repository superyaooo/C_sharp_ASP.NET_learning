using System;

namespace Calendar_2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SelectionChanged(object sender, EventArgs e)
        {
            myLabel.Text = " ";
            foreach(DateTime d in myCalendar.SelectedDates)
            {
                myLabel.Text += d.ToString("D") + "<br />";
            }
        }
    }
}
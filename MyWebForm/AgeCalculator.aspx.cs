using System;
using AgeLibrary;

namespace MyWebForm
{
    public partial class AgeCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            DateOfBirth dob = new DateOfBirth();
            if(dob.IsValidDate(txtDate.Text.ToString()))
            {
                lblAge.Text = $"You are a {ddlGender.SelectedValue} and your age is {dob.ShowAge()}";
            }
           else
            {
                lblAge.Text = "Please enter valid value";
            }
            
        }
    }
}
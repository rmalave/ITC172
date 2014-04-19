using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		
	}
	protected void Button1_Click(object sender, EventArgs e)
	{
		//on the button click we make an instance of our person
		//class and then write the values in the text boxes
		//to the class properties
		People person = new People();
		person.FirstName = txtFirstName.Text;
		person.LastName = txtLastName.Text;
		person.Phone = txtPhone.Text;
		person.Email = txtEmail.Text;
		person.City = txtCity.Text;
		person.State = txtState.Text;
		person.Zip = txtZip.Text;
		person.Password = txtPassword.Text;
		
		//we create a session variable to store our class
		//with all the values in it
		//so we can access it on other pages
		Session["donation"] = person;
		//then we redirect to the second page
		Response.Redirect("Default2.aspx");
	}
}
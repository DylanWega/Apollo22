using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class Delete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 customerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the addres to be deleted from the session object
        customerID = Convert.ToInt32(Session["customerID"]);
    }

    protected void yesBtn_Click(object sender, EventArgs e)
    {
        //calling the delete method
        DeleteCustomer();
        //confirmation message
        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Customer deleted successfully');", true);
        //redirect to the admin dashboard
        Response.Redirect("customerListForm.aspx");
    }

    void DeleteCustomer()
    {
        //function to delete the selected record

        //create a new instance of all customers
        clsCustomerCollection AllCustomer = new clsCustomerCollection();
        //find the record to delete
        AllCustomer.ThisCustomer.Find(customerID);
        //delete the record
        AllCustomer.Delete();
    }

    protected void noBtn_Click(object sender, EventArgs e)
    {
        //redirect to the admin dashboard
        Response.Redirect("customerListForm.aspx");
    }
}
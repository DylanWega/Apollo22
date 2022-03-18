using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class customerListForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is dosplayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }

    private void DisplayCustomers()
    {
        //create an instance of the customer collection
        clsCustomerCollection theCustomer = new clsCustomerCollection();
        //set the data source to the list of customers in the collection
        listCustomers.DataSource = theCustomer.CustomerList;
        //set the name of the primary key
        listCustomers.DataValueField = "customerID";
        //set the data field to display
        listCustomers.DataTextField = "lastName";
        //bind the data to the list
        listCustomers.DataBind();
    }
}
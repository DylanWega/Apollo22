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

    //event handler for the add button
    protected void addBtn_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        // to the data entry page
        Response.Redirect("customerCreateAccount.aspx");

    }

    protected void deleteBtn_Click(object sender, EventArgs e)
    {    
        //var to store the primary key value of the record to be deleted
        Int32 customerID;
        //if a record has been selected fron the list
        if(listCustomers.SelectedIndex != -1)
        {
            //get the primary key for the value of the record to be deleted
            customerID = Convert.ToInt32(listCustomers.SelectedValue);
            //store the data in the session object
            Session["customerID"] = customerID;
            //confirmation message
            Response.Redirect("Delete.aspx");
        }
        //if no record has been selected
        else 
        {
            //display an error
            lblError.Text = "Please select the record to be deleted";
        }
    }

    protected void updateBtn_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 customerID;
        //if a record has been selected from the list
        if (listCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to get updated
            customerID = Convert.ToInt32(listCustomers.SelectedValue);
            //store the data in the session object
            Session["customerID"] = customerID;
            //confirmation message
            Response.Redirect("customerCreateAccount.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error
            lblError.Text = "Please select the record to be updated";
        }
    }
    }

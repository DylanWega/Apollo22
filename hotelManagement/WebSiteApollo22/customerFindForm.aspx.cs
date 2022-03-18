using HotelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class customerForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void findBtn_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsCustomer theCustomer = new clsCustomer();
        //variable to store the primary 
        Int32 customerid;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        customerid = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = theCustomer.Find(customerid);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtDOB.Text = theCustomer.dateOfbirth.ToString();
            txtEmail.Text = theCustomer.email;
            txtFname.Text = theCustomer.firstName;
            txtLname.Text = theCustomer.lastName;
            txtPhonenum.Text = theCustomer.phoneNumber;
        }
    }
}
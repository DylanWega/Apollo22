using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class customerCreateAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void createBtn_Click(object sender, EventArgs e)
    {
        //create an instance of clsCustomer
        clsCustomerCollection AllCustomer = new clsCustomerCollection();
        //capture the first name
        string firstname = txtfname.Text;
        //capture last name
        string lastname = txtLname.Text;
        //capture email
        string email = txtEmail.Text;
        //capture DOB
        string dateofbirth = txtDOB.Text;
        //capture phone number
        string phonenumber = txtphone.Text;
        //variable to store Error
        string Error = "";
        //validate the data
        Error = AllCustomer.ThisCustomer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
        if (Error == "")
        {
            //capture firtsname
            AllCustomer.ThisCustomer.firstName = firstname;
            //capture lastname
            AllCustomer.ThisCustomer.lastName = lastname;
            //capture email
            AllCustomer.ThisCustomer.email = email;
            //capture phone number
            AllCustomer.ThisCustomer.phoneNumber = phonenumber;
            //capture date if birth
            AllCustomer.ThisCustomer.dateOfbirth = Convert.ToDateTime(dateofbirth);
            //add the record
            AllCustomer.Add();
            //redirect to welcome page
            Response.Redirect("customerViewer.aspx");

        }
        else
        {
            //display the error message
            Errorlbl.Text = Error;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class customerCreateAccount : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 customerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the cutomerID to be processed
        customerID = Convert.ToInt32(Session["customerID"]);
        if (IsPostBack == false)
        {
            if (customerID != -1)
            {
                //populate the text field
                DisplayCustomerInfo();
            }
        }
    }

    void DisplayCustomerInfo()
    {
        //create an instance of the customer
        clsCustomerCollection AllCustomer = new clsCustomerCollection();
        //find the record to update
        AllCustomer.ThisCustomer.Find(customerID);
        //display the data for this record
        //capture the first name
        txtfname.Text = AllCustomer.ThisCustomer.firstName;
        //capture last name
        txtLname.Text = AllCustomer.ThisCustomer.lastName;
        //capture email
        txtEmail.Text = AllCustomer.ThisCustomer.email;
        //capture DOB
        txtDOB.Text = AllCustomer.ThisCustomer.dateOfbirth.ToString();
        //capture phone number
        txtphone.Text = AllCustomer.ThisCustomer.phoneNumber;

    }
    protected void createBtn_Click(object sender, EventArgs e)
    { if (customerID == -1)
        {
            //add the new record
            Add();
            //all done so redirect back to the main page
            Response.Redirect("customerViewer.aspx");
        }
        else
        {
            //update the record
            Update();
        }
    }

    void Add()
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

    void Update()
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
        {   //Find the record to update
            AllCustomer.ThisCustomer.Find(customerID);
            //get the user's data
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
            AllCustomer.Update();
            //redirect to welcome page
            Response.Redirect("customerListForm.aspx");

        }
        else
        {
            //display the error message
            Errorlbl.Text = Error;
        }
    }

    protected void backBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("main.aspx");
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelClasses;

namespace adminHotelMgmt
{
    public partial class FindFormCustomer : Form
    {
        public FindFormCustomer()
        {
            InitializeComponent();
        }

        private void findBtn_Click(object sender, EventArgs e)
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
}

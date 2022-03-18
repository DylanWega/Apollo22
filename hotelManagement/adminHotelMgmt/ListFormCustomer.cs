using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelClasses;

namespace adminHotelMgmt
{
    public partial class ListFormCustomer : Form
    {
        public ListFormCustomer()
        {
            InitializeComponent();
        }

        private void ListFormCustomer_Load(object sender, EventArgs e)
        {
            DisplayCustomers();
        }

        private void DisplayCustomers()
        {
            //create an instance of the customer collection
            clsCustomerCollection theCustomer = new clsCustomerCollection();
            //set the data source to the list of customers in the collection
            listCustomers.DataSource = theCustomer.CustomerList;
            //set the name of the primary key
            listCustomers.ValueMember = "customerID";
            //set the data field to display
            listCustomers.DisplayMember = "lastName";
            //bind the data to the list
            
        }

        
    }
}

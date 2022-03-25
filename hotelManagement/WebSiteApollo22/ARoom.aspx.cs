using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class ARoom : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsRoom AnRoom = new clsRoom();
        //variable to store the primary key
        Int32 RoomNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary kev entered by the user
        RoomNo = Convert.ToInt32(txtroom.Text);
        //find the record
        Found = AnRoom.Find(RoomNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txttype.Text = AnRoom.type;
            txtdescription.Text = AnRoom.description;
            txtprice.Text = AnRoom.price.ToString();
            txtavailability.Text = AnRoom.availability;
          
        }
    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
}
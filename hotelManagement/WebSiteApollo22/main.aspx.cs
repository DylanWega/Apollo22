using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;


public partial class main : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 roomNo;
        
    protected void Page_Load(object sender, EventArgs e)
    {
        ////get the cutomerID to be processed
        //roomNo = Convert.ToInt32(Session["roomNo"]);
        //if (IsPostBack == false)
        //{
        //    if (roomNo != -1)
        //    {
        //        //populate the text field
        //        DisplayroomInfo();
            }
    void Add()
    {
        //create an instance of clsCustomer
        clsRoomCollection Allroom = new clsRoomCollection();
        //capture the first name
        string roomNo = txtroom.Text;
        //capture last name
        string type = txttype.Text;
        //capture email
        string description = txtdescription.Text;
        //capture DOB
        string price = txtprice.Text;
        //capture phone number
        string availability = txtavailability.Text;
        //variable to store Error
        string Error = "";
        //validate the data
        Error = Allroom.Thisroom.Valid(roomNo, type, description, price, availability);
        if (Error == "")
        {
            //capture firtsname
            Allroom.Thisroom.roomNo = roomNo;
            //capture lastname
            Allroom.Thisroom.type = type;
            //capture email
            Allroom.Thisroom.description = description;
            //capture phone number
            Allroom.Thisroom.price = price;
            //capture date if birth
            Allroom.Thisroom.availability =(availability);
            //add the record
            Allroom.Add();
            //redirect to welcome page
            Response.Redirect("roomViewer.aspx");

        }
        else
        {
            //display the error message
            Errorlbl.Text = Error;
        }


        protected void Button1_Click(object sender, EventArgs e)
    {
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["RoomNo"] = -1;
        Response.Redirect("AED.aspx");
    }
}
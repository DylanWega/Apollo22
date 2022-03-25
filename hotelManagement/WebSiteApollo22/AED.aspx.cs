using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class AED : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ////if this is the first time the page is dosplayed
        //if (IsPostBack == false)
        //{
        //    //update the list box
        //    Displayroom();
        //}

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["RoomNo"] = -1;
        Response.Redirect("main.aspx");
    }


    //private void Displayroom()
    //{
    //    //create an instance of the customer collection
    //    clsRoomCollection theroom = new clsRoomCollection();
    //    //set the data source to the list of customers in the collection
    //    listbDisplay.DataSource = theroom.roomList;
    //    //set the name of the primary key
    //    listbDisplay.DataValueField = "roomNo";
    //    //set the data field to display
    //    listbDisplay.DataTextField = "description";
    //    //bind the data to the list
    //    listbDisplay.DataBind();
    //}

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Session["RoomNo"] = -1;
        Response.Redirect("AED.aspx");
    }
}

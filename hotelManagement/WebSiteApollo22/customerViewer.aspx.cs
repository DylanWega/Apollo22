using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class customerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void logOutBtn_Click(object sender, EventArgs e)
    {
        //redirect to main page
        Response.Redirect("main.aspx");
    }
}
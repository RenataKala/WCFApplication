using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReference;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GetDataClient proxi = new GetDataClient();
        DropDownList1.DataSource = proxi.GetAllStudents();
        DropDownList1.DataValueField = "ID";
        DropDownList1.DataTextField = "FullName";
        DropDownList1.DataBind();



    }
}
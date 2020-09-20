using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPClient.DonServiceReference;

namespace ASPClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServicesClient servicesClient = new ServicesClient();
            DropDownList1.DataSource = servicesClient.GetUsers();
            DropDownList1.DataValueField = "id";
            DropDownList1.DataTextField = "userName";
            DropDownList1.DataBind();
        }
    }
}
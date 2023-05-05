using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZohoPull
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void SwitchPlaces(object sender, EventArgs e)
        {
            //Submit.Visible = false;

            Response.Redirect("https://accounts.zoho.in/oauth/v2/auth?scope=ZohoBooks.fullaccess.all&client_id=1000.CDIM4I23HBPMVUSG6OMG7VNWQSM5AC&response_type=code&redirect_uri=https://localhost:44302/WebForm1");
        }
    }
}
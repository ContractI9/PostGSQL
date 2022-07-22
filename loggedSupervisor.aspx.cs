using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostGSQL
{
    public partial class loggedSupervisor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void listPublications(object sender, EventArgs e)
        {
            Session["sid"] = studentID.Text;
            Response.Redirect("listPublications.aspx");
        }

    }
}
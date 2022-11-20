using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OgadrivePortal
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtUserName.Text))
            {
                if (txtUserName.Text.Equals("Admin") && txtPassword.Text.Equals("@123") )
                {
                    Session["UserInfo"] = txtUserName.Text;
                    Response.Redirect("DriverRegitration.aspx");
                }
            }
        }
    }
}
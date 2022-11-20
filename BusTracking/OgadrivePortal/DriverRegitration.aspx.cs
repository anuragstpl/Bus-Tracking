using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ogadrive.Common;
using OgadriveData.Model;
using OgadriveData.UnitOfWork;

namespace OgadrivePortal
{
    public partial class DriverRegitration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
                Response.Redirect("Login.aspx");

        }

        protected void btnDriverRegistration_Click(object sender, EventArgs e)
        {
            
        }

        private void Clear()
        {
            txtFullName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtBoxConfirmPassword.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtDateOfBirth.Text = string.Empty;
            txtICNumber.Text = string.Empty;
            txtLicense.Text = string.Empty;
            txtAccount.Text = string.Empty;
        }
    }
}
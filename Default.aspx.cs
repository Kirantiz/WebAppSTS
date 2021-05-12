using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.AccessControl;
using System.Security.Authentication;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Principal;
using System.Security;

namespace WebAppSTS
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if (Context.User.Identity.GetUserName().Length == 0)
           
        }
    }
}
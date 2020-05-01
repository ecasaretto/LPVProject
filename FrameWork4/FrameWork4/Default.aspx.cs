using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrameWork4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Msg_Nombre.Visible = false;
            if ( Session["sessionID"] == null)
            {
                Response.Redirect("Login.aspx");  // Sin Logeo Dirigido a Login
            } else {
                Msg_Nombre.Text = Session["username"].ToString();
                Msg_Nombre.Visible = true;

            }
            
        }
    }
}
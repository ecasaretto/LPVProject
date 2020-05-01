using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrameWork4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Msg_Login.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            var resultado = FrameWork4.ConexionLogin.validarLogin(txtUsuario.Text.Trim(), txtPassword.Text.Trim());
            if (resultado.Item1 > 0)
            {
                Msg_Login.Text = "Login Valido";
                Msg_Login.Visible = true;
                Session["username"] = txtUsuario.Text.Trim();
                Session["sessionID"] = resultado.Item2;
                
                Response.Redirect("Default.aspx");  // Acceso Concedido
            }
            else
            {
                Msg_Login.Text = "Login InValido";
                Msg_Login.Visible = true;
                Session["username"] = txtUsuario.Text.Trim();
            }

        }
    }
}
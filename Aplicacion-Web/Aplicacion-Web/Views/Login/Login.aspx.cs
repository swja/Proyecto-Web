using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aplicacion_Web.Views.documentos
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool Autenticado = false;
            Autenticado = LoginCorrecto(Login1.UserName, Login1.Password);
            e.Authenticated = Autenticado; if (Autenticado)
            {
                Response.Redirect("Default.aspx");
            }
        }
            private bool LoginCorrecto(string Usuario, string Contrasena)
        {
            if (Usuario.Equals("maestros") && Contrasena.Equals("delweb"))
                return true; return false;
        }
    }
    }

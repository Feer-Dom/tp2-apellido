using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace CatalogoWeb_3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" && txtPass.Text == "")
            {
                lblCompletar.Visible = true;
                lblFaltaPass.Visible = false;
                lblFaltaUser.Visible = false;
            }
            else if (txtUser.Text == "")
            {
                lblFaltaUser.Visible = true;
                lblCompletar.Visible = false;
            }    
            else if (txtPass.Text == "")
            {
                lblFaltaPass.Visible = true;
                lblCompletar.Visible = false;
            }
            else
            {
                Session["userName"] = txtUser.Text;
                Response.Redirect("Home.aspx");
            }

        }
    }
}
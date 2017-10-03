using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PAGINAINVENTARIO.MODELO;

namespace PAGINAINVENTARIO.FORMULARIO
{
    public partial class Login : System.Web.UI.Page
    {
        INVENTARIODBEntities db = new INVENTARIODBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            var consulta = db.USUARIOS.Where(x => x.Usuario.Equals(txtNombre.Text) && x.Contraseña.Equals(txtContraseña.Text)).FirstOrDefault();

            if (consulta !=null)
            {
                Response.Redirect("Principal.aspx");
            }
            else
            {
                Response.Write("<script>alert('Usuario o contraseña incorrecto')</script");
            }
        }
    }
}
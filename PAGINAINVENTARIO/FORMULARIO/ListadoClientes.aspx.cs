using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PAGINAINVENTARIO.MODELO;

namespace PAGINAINVENTARIO.FORMULARIO
{
    public partial class ListadoClientes : System.Web.UI.Page
    {
        INVENTARIODBEntities db = new INVENTARIODBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            //gvListado.DataSource = db.CLIENTES.ToList();
            //DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvListado_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvListado.EditIndex = e.NewEditIndex = -1;
            DataBind();
        }

        protected void gvListado_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = (int)e.Keys["Id_cliente"];
            DataBind();
        }

        protected void gvListado_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = (int)e.Keys["Id_cliente"];
            string nombre = (string)e.NewValues["Nombre"];
            string direccion = (string)e.NewValues["Direccion"];

            gvListado.EditIndex = -1;
            DataBind();
        }

        protected void gvListado_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvListado.EditIndex = 1;
            DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CLIENTES cliente = new CLIENTES
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text
                };

                db.CLIENTES.Add(cliente);
                db.SaveChanges();

                Response.Write("<script>alert('Cliente insertado con exito!!!')</script>");

                txtNombre.Text = txtDireccion.Text = "";
            }
            catch (Exception error)
            {
                Response.Write("<script>alert('Ha ocurrido un problema')</script>");
            }
        }
    }
}
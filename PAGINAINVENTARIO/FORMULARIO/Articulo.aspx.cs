using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PAGINAINVENTARIO.MODELO;

namespace PAGINAINVENTARIO.FORMULARIO
{
    
    public partial class Articulo : System.Web.UI.Page
    {
        INVENTARIODBEntities db = new INVENTARIODBEntities();
        int precio, cantidad;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            añadirArticulo();
        }

        private void añadirArticulo()
        {
            convertirAEntero();
            try
            {
                ARTICULOS articulo = new ARTICULOS
                {
                    Articulo = txtArticulo.Text,
                    Cantidad = txtCantidad.Text,
                    Precio = precio
                };

                db.ARTICULOS.Add(articulo);
                db.SaveChanges();

                Response.Write("<script>alert('Articulo insertado')</script>");
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Ha ocurrido un error')</script>");
            }

            limpiarCajaDeTexto();
            focoArticulo();
            
        }

        private void convertirAEntero()
        {
            precio = Convert.ToInt32(txtPrecio.Text);
            cantidad = Convert.ToInt32(txtCantidad.Text);
        }

        private void limpiarCajaDeTexto()
        {
            txtArticulo.Text = txtCantidad.Text = txtPrecio.Text = "";
        }

        private void focoArticulo()
        {
            txtArticulo.Focus();
        }

        private void binding()
        {
            gvArticulo.DataSource = db.ARTICULOS.ToList();
            gvArticulo.DataBind();
        }
        
        private void actualizar(DETALLEFACTURAS factura)
        {
            convertirAEntero();
            //using(var db =new INVENTARIODBEntities())
            //{
            //    db.DETALLEFACTURAS.Where(x=>x.Cantidad==cantidad)
            //}
        }
    }
}
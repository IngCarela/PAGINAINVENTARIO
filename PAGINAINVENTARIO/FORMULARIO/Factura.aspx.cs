using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PAGINAINVENTARIO.MODELO;
using System.Data;
using System.Data.SqlClient;

namespace PAGINAINVENTARIO.FORMULARIO
{
    public partial class Factura : System.Web.UI.Page
    {
        INVENTARIODBEntities db = new INVENTARIODBEntities();

        int articulo, monto, cantidad, cliente, descuento;
        
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            validarCantidadDescuento();
            focoEnMonto();
            limpiaCajaDeTexto();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiaCajaDeTexto();
            focoEnMonto();
        }

        private void limpiaCajaDeTexto()
        {
            txtDescuento.Text = txtCantidad.Text = "";
        }

        private void focoEnMonto()
        {
            txtCantidad.Focus();
        }

       

        
        private void bindGrid()
        {
            gvFactura.DataSource = db.DETALLEFACTURAS.ToList();
            gvFactura.DataBind();
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void validarCantidadDescuento()
        {
            convertirVariables();
            if (cantidad>monto || descuento>monto)
            {
                Response.Write("<script>alert('La cantidad o el descuento son mayores que el monto')</script>");
            }
            else
            {
                facturar();
                editar();
            }
        }
        
        private void facturar()
        {
            convertirVariables();
            try
            {
                DETALLEFACTURAS factura = new DETALLEFACTURAS
                {
                    Id_articulos = articulo,
                    Monto = monto,
                    Cantidad = cantidad,
                    Id_cliente = cliente,
                    Descuento = descuento
                };

                db.DETALLEFACTURAS.Add(factura);
                db.SaveChanges();

                Response.Write("<script>alert('Facturado con exito!!!')</script>");
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Ha ocurrido un error')</script>");
            }

        }

        private void editar()
        {
            try
            {
                int id = Convert.ToInt32(ddArticulo.SelectedValue);

                ARTICULOS a = db.ARTICULOS.Single(x => x.id_articulo == id);


                int z;

                z = Convert.ToInt32(txtCantidad.Text);
                string p = a.Cantidad;
                int r = Convert.ToInt32(p);
                int lo = r - z;

                a.Cantidad = lo.ToString();

                db.SaveChanges();
            }
            catch (Exception er)
            {

                Response.Write("<script>alert('Hubo un error')</script>");
            }

        }


        private void convertirVariables()
        {
            articulo = Convert.ToInt32(ddArticulo.SelectedValue);
            monto = Convert.ToInt32(ddMonto.SelectedValue);
            cantidad = Convert.ToInt32(txtCantidad.Text);
            cliente = Convert.ToInt32(ddCliente.SelectedValue);
            descuento = Convert.ToInt32(txtDescuento.Text);
        }
    }
}
﻿using System;
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
        
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiaCajaDeTexto();
            focoEnMonto();
        }

        private void limpiaCajaDeTexto()
        {
            txtMonto.Text = txtDescuento.Text = txtCantidad.Text = "";
        }

        private void focoEnMonto()
        {
            txtMonto.Focus();
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            facturar();
            editar();
            
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

        private void convertirVariables()
        {
            articulo = Convert.ToInt32(ddArticulo.SelectedValue);
            monto = Convert.ToInt32(txtMonto.Text);
            cantidad = Convert.ToInt32(txtCantidad.Text);
            cliente = Convert.ToInt32(ddCliente.SelectedValue);
            descuento = Convert.ToInt32(txtDescuento.Text);
        }
        private void bindGrid()
        {
            gvFactura.DataSource = db.DETALLEFACTURAS.ToList();
            gvFactura.DataBind();
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void editar()
        {
            string conectionString = "Data Source= DESKTOP-8K6I7RO/CARELADBA; Initial Catalog= INVENTARIODB; Integrated Security=true ";

            SqlConnection cnn = new SqlConnection(conectionString);

            cnn.Open();

            try
            {
                string sql = "UPDATE ARTICULOS SET Cantidad = Cantida -" + txtCantidad.Text + "WHERE id_articulo = @id_articulo";

                SqlCommand cmd = new SqlCommand(sql);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    Response.Write("Actualizacion exitosa!!!!!");
                }
                else
                {
                    Response.Write("Hubo un error");
                }
            }
            catch (Exception)
            {

                Response.Write("ERROR");
            }
            finally
            {
                cnn.Close();
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PAGINAINVENTARIO.MODELO;
using System.Data;

namespace PAGINAINVENTARIO.FORMULARIO
{
    public partial class Factura : System.Web.UI.Page
    {
        INVENTARIODBEntities db = new INVENTARIODBEntities();
        int articulo, monto, cantidad, cliente, descuento;

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            articulo = Convert.ToInt32(ddArticulo.SelectedIndex);
            monto = Convert.ToInt32(txtMonto.Text);
            cantidad = Convert.ToInt32(txtCantidad.Text);
            cliente = Convert.ToInt32(ddCliente.SelectedIndex);
            descuento = Convert.ToInt32(txtDescuento.Text);

            DataTable dt = new DataTable();
            
            DataRow dr = dt.NewRow();

            

            if (dt.Rows.Count==0)
            {
                dt.Columns.Add(new DataColumn("IdArticulo", typeof(string)));
                dt.Columns.Add(new DataColumn("IdMonto", typeof(string)));
                dt.Columns.Add(new DataColumn("IdCantidad", typeof(string)));
                dt.Columns.Add(new DataColumn("IdCliente", typeof(string)));
                dt.Columns.Add(new DataColumn("IdDescuento", typeof(string)));

                dr["IdArticulo"] = articulo;
                dr["IdMonto"] = monto;
                dr["IdCantidad"] = cantidad;
                dr["IdCliente"] = cliente;
                dr["IdDescuento"] = descuento;

                dt.Rows.Add(dr);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            
            else
            {
                Response.Write("<script>alert('ERROR')</script>");
            }

            //GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
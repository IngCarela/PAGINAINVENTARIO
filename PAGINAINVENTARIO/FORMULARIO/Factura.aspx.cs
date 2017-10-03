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
            DataTable dt = new DataTable();


            if (dt.Columns.Count==0)
            {
                articulo = Convert.ToInt32(ddArticulo.SelectedIndex);
                monto = Convert.ToInt32(txtMonto.Text);
                cantidad = Convert.ToInt32(txtCantidad.Text);
                cliente = Convert.ToInt32(ddCliente.SelectedIndex);
                descuento = Convert.ToInt32(txtDescuento.Text);

                dt.Columns.Add("Articulo", typeof(string));
                dt.Columns.Add("Monto", typeof(string));
                dt.Columns.Add("Cantidad", typeof(string));
                dt.Columns.Add("Cliente", typeof(string));
                dt.Columns.Add("Descuento", typeof(string));

                DataRow dr = dt.NewRow();
                dr[0] = ddArticulo.SelectedIndex;
                dr[1] = txtMonto.Text;
                dr[2] = txtCantidad.Text;
                dr[3] = ddCliente.SelectedIndex;
                dr[4] = txtDescuento.Text;

                dt.Rows.Add(dr);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
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
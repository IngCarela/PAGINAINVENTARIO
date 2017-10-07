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
        

        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            bindGrid();
        }

        private void crearTabla()
        {
            
            dt.Columns.Add(new DataColumn("IdArticulo"));
            dt.Columns.Add(new DataColumn("IdMonto"));
            dt.Columns.Add(new DataColumn("IdCantidad"));
            dt.Columns.Add(new DataColumn("IdCliente"));
            dt.Columns.Add(new DataColumn("IdDescuento"));
        }
        
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            crearTabla();
            llenarTabla();
            bindGrid();
        }

        private void llenarTabla()
        {
            DataRow dr = dt.NewRow();

            dr["IdArticulo"] = ddArticulo.SelectedIndex;
            dr["IdMonto"] = txtMonto.Text;
            dr["IdCantidad"] = txtCantidad.Text;
            dr["IdCliente"] = ddArticulo.Text;
            dr["IdDescuento"] = txtDescuento.Text;

            dt.Rows.Add(dr);
        }

        private void bindGrid()
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
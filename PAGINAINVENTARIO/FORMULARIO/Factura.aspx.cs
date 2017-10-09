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
            //añadir();
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

            ViewState["tabla"] = dt;
        }

        private void añadir()
        {
            int conteo = 0;

            

            if (ViewState["tabla"] !=null)
            {
                DataTable dtActual = (DataTable)ViewState["tabla"];
                DataRow drActual = null;

                if (dtActual.Rows.Count>0)
                {
                    for (int i = 1; i < dtActual.Rows.Count; i++)
                    {
                        DropDownList dropA = (DropDownList)gvFactura.Rows[conteo].Cells[0].FindControl("IdArticulo");
                        TextBox boxM = (TextBox)gvFactura.Rows[conteo].Cells[1].FindControl("IdMonto");
                        TextBox boxC = (TextBox)gvFactura.Rows[conteo].Cells[2].FindControl("IdCantidad");
                        DropDownList dropC = (DropDownList)gvFactura.Rows[conteo].Cells[3].FindControl("IdCliente");
                        TextBox boxD = (TextBox)gvFactura.Rows[conteo].Cells[4].FindControl("IdDescuento");

                        drActual = dtActual.NewRow();
                        drActual["IdArticulo"] = i + 1;

                        dtActual.Rows[i - 1]["IdArticulo"] = dropA.SelectedIndex;
                        dtActual.Rows[i - 1]["IdMonto"] = boxM.Text;
                        dtActual.Rows[i - 1]["IdCantidad"] = boxC.Text;
                        dtActual.Rows[i - 1]["IdCliente"] = dropC.SelectedIndex;
                        dtActual.Rows[i - 1]["IdDescuento"] = boxD.Text;

                        conteo++;
                    }

                    dtActual.Rows.Add(drActual);
                    ViewState["tabla"] = dtActual;

                    gvFactura.DataSource = dtActual;
                    gvFactura.DataBind();
                }
            }
            else
            {
                Response.Write("ViewState is null");
            }


        }
        
        private void bindGrid()
        {
            gvFactura.DataSource = dt;
            gvFactura.DataBind();
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
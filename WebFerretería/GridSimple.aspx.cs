using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaDatos.Entidades;

namespace WebFerretería
{
    public partial class GridSimple : System.Web.UI.Page
    {
        ActualizarBD objBD;
        List<Factura> auxListado;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)  //validacion importante para saber si no es una recarga.
            {
                cargaDatosGrid();
            }
          

        }


        void cargaDatosGrid ()
        {
            objBD = new ActualizarBD ();
            auxListado = objBD.listadoArticulos();
            gridFactura.DataSource = auxListado; //el origen de datos
            gridFactura.DataBind(); // enlazo los datos al control
        }

        protected void gridHerramienta_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow) //validando si la fila enlazada contiene datos
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gridFactura, "Select$" + e.Row.RowIndex);       
             }
        }

        protected void gridHerramienta_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow fila in gridFactura.Rows)
            {
                if (fila.RowIndex == gridFactura.SelectedIndex)
                {
                    txtID.Text = fila.Cells[0].Text; // obtengo el codigo de herramienta
                    txtnumLinea.Text = fila.Cells[1].Text;
                    txtcodProducto.Text = fila.Cells[2].Text;
                    txtdetProducto.Text = fila.Cells[3].Text;
                    txtcantProducto.Text = fila.Cells[4].Text;
                    txtcostUnitario.Text = fila.Cells[5].Text;
                    txttotalLinea.Text = fila.Cells[6].Text;
                    fila.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                }
                else
                {
                    fila.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }

                cargaDatosGrid();

            }
        }
    }
}
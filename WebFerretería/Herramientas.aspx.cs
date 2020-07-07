using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaDatos.Entidades;
namespace WebFerretería
{
    public partial class Herramientas : System.Web.UI.Page
    {
        UpdateBD objUBD;
        ActualizarBD objBD;
        EliminarBD objBDE;
        List<Disponible> listadoDisponible;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                cargarcmbDisponible();
            }
        }

        void cargarcmbDisponible()
        {
            objBD = new ActualizarBD();
            listadoDisponible = objBD.listadoDisponible();

            cmbDisponible.DataSource = listadoDisponible;
            cmbDisponible.DataTextField = "Palabra";
            cmbDisponible.DataValueField = "numPalabra";
            cmbDisponible.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            objBD = new ActualizarBD();
            Herramienta objHerramienta = new Herramienta();
            objHerramienta.CodHerramienta =  Convert.ToInt32(txtCodHerramienta.Text);
            objHerramienta.Nombre = txtNombre.Text;
            objHerramienta.Cantidad = Convert.ToInt32(txtCantidad.Text);
            objHerramienta.Disponible = cmbDisponible.Text;

           bool resultado = objBD.registrarHerramienta(objHerramienta);

            if (resultado == true)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "scriptAlert", "alert('Se agregó con exito')", true);
            } else { ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "scriptAlert", "alert('No se agregó con exito')", true); }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            objUBD = new UpdateBD();
            Herramienta objHerramienta = new Herramienta();
            objHerramienta.CodHerramienta = Convert.ToInt32(txtCodHerramienta.Text);
            objHerramienta.Nombre = txtNombre.Text;
            objHerramienta.Cantidad = Convert.ToInt32(txtCantidad.Text);
            objHerramienta.Disponible = cmbDisponible.Text;

            bool resultado = objUBD.ActualizarHerramienta(objHerramienta);

            if (resultado == true)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "scriptAlert", "alert('Se actualizó con exito')", true);
            }
            else { ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "scriptAlert", "alert('No se actualizó con exito')", true); }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            objBDE = new EliminarBD();
            Herramienta objHerramienta = new Herramienta();
            objHerramienta.CodHerramienta = Convert.ToInt32(txtCodHerramienta.Text);
           

            bool resultado = objBDE.EliminarHerramienta(objHerramienta);

            if (resultado == true)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "scriptAlert", "alert('Se eliminó con exito')", true);
            }
            else { ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "scriptAlert", "alert('No se eliminó con exito')", true); }
        }

    }


    }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using cNegocio;

public partial class CRUDPersona : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnConsultar_Click(object sender, EventArgs e)
    {
        Persona per = new Persona();
        Empleado emp = new Empleado();

        txtIdPersona.Text = per.IdPersona.ToString();

        if (per.LeerPersona() && emp.LeerEmpleado())
        {
            txtRut.Text = per.Rut;
            txtNombre.Text = per.Nombre;
            txtApellido.Text = per.Apellido;
            txtEdad.Text = per.Edad.ToString();
            txtFechaNacimiento.Text = per.FechaNacimiento.ToString();
            txtCorreo.Text = per.Correo;
            txtAreaTrabajo.Text = per.AreaTrabajo;

            L1.Text = string.Empty;
        }
        else
        {
            L1.Text = "No existe";
        }
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {

    }
}
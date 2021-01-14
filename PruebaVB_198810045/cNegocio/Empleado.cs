using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cNegocio
{
    public class Empleado
    {
        private int idEmpleado;
        private int idPers;
        private string correo;
        private string areaTrabajo;

        public Empleado() { }

        public Empleado(int idEmpleado, int idPersona, string correo, string areaTrabajo)
        {
            this.idEmpleado = idEmpleado;
            this.idPers = idPersona;
            this.correo = correo;
            this.areaTrabajo = areaTrabajo;
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int IdPersona { get => idPers; set => idPers = value; }
        public string Correo { get => correo; set => correo = value; }
        public string AreaTrabajo { get => areaTrabajo; set => areaTrabajo = value; }


        public bool CrearEmpleado()
        {
            try
            {
                cDatos.Empleado emp = new cDatos.Empleado();

                emp.ID_Empleado = this.IdEmpleado;
                emp.ID_Persona = this.idPers;
                emp.Correo = this.correo;
                emp.Area_trabajo = this.areaTrabajo;
                

                CommonBC.ModPrueba.Empleadoes.Add(emp);
                CommonBC.ModPrueba.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EliminarEmpleado()
        {
            try
            {
                cDatos.Empleado empleado =
                CommonBC.ModPrueba.Empleadoes.First
                (
                    tar => tar.ID_Empleado == this.IdEmpleado
                    );

                CommonBC.ModPrueba.Empleadoes.Remove(empleado);
                CommonBC.ModPrueba.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool LeerEmpleado()
        {
            try
            {
                cDatos.Empleado empleado =
                CommonBC.ModPrueba.Empleadoes.First
                (
                    emp => emp.ID_Empleado == this.IdEmpleado
                );
                this.idPers = empleado.ID_Persona;
                this.correo = empleado.Correo;
                this.areaTrabajo = empleado.Area_trabajo;
             
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}

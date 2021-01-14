using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cNegocio
{
    public class Persona : Empleado
    {
        private int idPersona;
        private string rut;
        private string nombre;
        private string apellido;
        private int edad;
        private DateTime fechaNacimiento;

        public Persona() { }

        public Persona(int idPersona, string rut, string nombre, string apellido, int edad, DateTime fechaNacimiento)
        {
            this.idPersona = idPersona;
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.fechaNacimiento = fechaNacimiento;
        }

        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public bool CrearPersona()
        {
            try
            {
                cDatos.Persona per = new cDatos.Persona();

                per.ID_Persona = this.IdPersona;
                per.Rut = this.Rut;
                per.Nombre = this.Nombre;
                per.Apellido = this.Apellido;
                per.Edad = this.edad;
                per.Fecha_Nacimiento = this.FechaNacimiento;

                CommonBC.ModPrueba.Personas.Add(per);
                CommonBC.ModPrueba.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ActualizarPersona()
        {
            try
            {
                cDatos.Persona persona =
                    CommonBC.ModPrueba.Personas.First(
                        per => per.ID_Persona == this.IdPersona);
                persona.Rut = this.Rut;
                persona.Nombre = this.Nombre;
                persona.Apellido = this.Apellido;
                persona.Edad = this.edad;
                persona.Fecha_Nacimiento = this.FechaNacimiento;

                CommonBC.ModPrueba.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EliminarPersona()
        {
            try
            {
                cDatos.Persona persona =
                CommonBC.ModPrueba.Personas.First
                (
                    tar => tar.ID_Persona == this.IdPersona
                    );

                CommonBC.ModPrueba.Personas.Remove(persona);
                CommonBC.ModPrueba.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool LeerPersona()
        {
            try
            {
                cDatos.Persona persona =
                CommonBC.ModPrueba.Personas.First
                (
                    tar => tar.ID_Persona == this.IdPersona
                );
                this.Rut = persona.Rut;
                this.Nombre = persona.Nombre;
                this.Apellido = persona.Apellido;
                this.Edad = persona.Edad;
                this.FechaNacimiento = persona.Fecha_Nacimiento;

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

    }
}

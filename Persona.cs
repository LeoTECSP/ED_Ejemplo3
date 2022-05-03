using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Ejemplo3
{
    public class Persona
    {
        //Miembro de tipo campo (variables)
        //Tipos de acceso: private, public, internal, protected...
        private string nombre, apellido;
        private DateTime fechaNacimiento;

        //Miembro de tipo Propiedad
        public string Nombre
        {
            get { return nombre; } // Lectura
            set { nombre = value; } // Escritura = "Ulises";
        }
        //
        public string Apellido
        {
            get { return apellido; } // Lectura
            set { apellido = value; } // Escritura = "Ulises";
        }
        //
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; } // Lectura
            set { fechaNacimiento = value; } // Escritura = "Ulises";
        }
        //Miembro de tipo metodo
        public int CalcularEdad() {
            //fecha de NAcimiento de la persona - fechaActual
            TimeSpan edad = DateTime.Now - fechaNacimiento;
            return (int)edad.TotalDays / 365;
            //regresar la edad del usuario
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_Ejemplo3
{
    public partial class Form1 : Form
    {
        //Lista global
        List<Persona> listaPersonas = new List<Persona>();
        

        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Intanciar la clase (crear un objeto)
            //TipoClase nombreObjeto = new TipoClase();
            Persona objetoUno = new Persona();
            //Acceder a los miembos de la clase
            objetoUno.Nombre = txtNombre.Text;
            objetoUno.Apellido = txtApellido.Text;
            objetoUno.FechaNacimiento = dateTimePicker1.Value;

            //Mostrar el resultado del metodo en la etiqueda
            string resultado = string.Format("El usuaio llamado {0} {1}, " +
                "tiene la edad de {2} años.", objetoUno.Nombre, objetoUno.Apellido, objetoUno.CalcularEdad().ToString());
            lblEdad.Text = resultado;
            //Llenar la lista
            listaPersonas.Add(objetoUno);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //Enviar la lista al form llamado listarEdades (el que tiene dataGridView)
            // 1. Mandar llamar el otro Form listarEdades
            listarEdades edades = new listarEdades();
            edades.MostrarListaObjetos(listaPersonas);
            //mostrar el segundo form listarEdades
            DialogResult result = edades.ShowDialog();

            if (result == DialogResult.Yes)
            {
                //mensaje
                MessageBox.Show(edades.PersonaSeleccionada.Nombre +" " + edades.PersonaSeleccionada.Apellido);
            }

            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("En el segundo form cargaste la opcion de Cancel");
            }
        }
    

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}

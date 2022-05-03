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
    public partial class listarEdades : Form
    {

        //Necesito cargar sl DataGridView
        //Crear un metodo
        public void MostrarListaObjetos(List<Persona> lista) {
            //DataSource (origen de datos)
            dataGridView1.DataSource = lista;
        }

        //Miembro
        private Persona personaSeleccionada;
        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { personaSeleccionada = value; }
        }

        public listarEdades()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            //validar si dataGridView tiene datos
            if (dataGridView1.SelectedRows.Count > 0)
            {
                PersonaSeleccionada = (Persona)dataGridView1.SelectedRows[0].DataBoundItem;                
            }
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

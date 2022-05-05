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
    public partial class Movimiento : Form
    {
        //Variable global
        private int contador = 0, x, limite;
        //salto en y para ir restando y y que el monito suba y time para determinar cuanto tiempo sube
        //y cuanto tarda en bajar
        private int saltoEnY = 150, time = 0;

        //Declarar una variable global de tipo del user control creado (Corredor)
        //Usamos una variable para que no se encuentre cargado en memoria innecesariamente
        Corredor corredor2 = null;

        public Movimiento()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            limite = this.Width;
          //  timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (corredor2 == null)
            {//se cargan constructores y variables y deja de ser nulo
                corredor2 = new Corredor() { Location = new Point(0, (ClientSize.Height * 50) / 100) };
                Controls.Add(corredor2);
            }

            contador++;
            label1.Text = contador.ToString();
            //Mover el GIF
            corredor1.Left = x += 10;
            corredor2.Left = x += 10;

            if (x >= limite)
            {
                timer1.Stop();
                //corredor1.Estatus = 1;
                corredor1.DetenerCholo = true; //MANDAR EL VALOR AL CONSTRUCTOR
                corredor2.DetenerCholo = true; 
            }
        }

        //crear cholito en tiempo de ejecución

    
        private void Movimiento_Click(object sender, EventArgs e)
        {

            //cambio el timer se active cuando se de click

            timer1.Enabled = true;
            //Mostar al corredor 2 - para que yo lo pueda ver primero necesito instanciarlo con el new

            //corregir que no genere mas cholos
            if (corredor2 == null)
            {//se cargan constructores y variables y deja de ser nulo
                corredor2 = new Corredor() { Location = new Point(0,150 /* (ClientSize.Height * 50) / 100) */)}
                ;
                Controls.Add(corredor2);
            }
            else
            {
                Controls.Remove(corredor2);
                corredor2 = null;

            }

        }

        //cuando presione la tecla p voy a activar el salto
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P && x<= limite)
            {
                timerBrinco.Enabled = true;
            }
        }

        private void timerBrinco_Tick(object sender, EventArgs e)
        {
            time++;

            if (time <10 )
            {
                //subo al monito
                corredor2.Location = new Point(x, saltoEnY -= 10);
            }

            else
            {
                corredor2.Location = new Point(x, saltoEnY += 10);
                if (corredor2.Location.Y ==150)
                {
                    timerBrinco.Enabled = false;
                    time = 0;
                }
            }
                  
           
        }

        private void Movimiento_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                label2.Text = i.ToString();
                System.Threading.Thread.Sleep(3);
            }
        }

        //Modificar metodo OnPaint
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Image image = Properties.Resources.garden;//Guardar el recurso físico en una variable

            e.Graphics.FillRectangle(Brushes.AliceBlue, 0, 0, ClientSize.Width, (ClientSize.Height * 70) / 100);
            e.Graphics.FillRectangle(Brushes.ForestGreen, 0, (ClientSize.Height * 70) / 100, ClientSize.Width, ClientSize.Height);
            //empieza a dibujar despues de la coordenada donde termina el azul y empieza a dibujar el verde

            //coordenadas x y y despues el tamaño de 200,200
            e.Graphics.DrawImage(image, 0, (ClientSize.Height * 70) / 100, (ClientSize.Width * 50) / 100, (ClientSize.Height * 30) / 100);
            //Sobreescribe por encima unas flores
        }

    }   
}

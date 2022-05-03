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
        private int contador = 0, x,limite;
     

     


        public Movimiento()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            limite = this.Width;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            label1.Text = contador.ToString();
            //Mover el GIF
            corredor1.Left = x += 10;
            if (x >= limite)
            {
                timer1.Stop();
                //corredor1.Estatus = 1;
                corredor1.DetenerCholo = true; //MANDAR EL VALOR AL CONSTRUCTOR
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
            e.Graphics.FillRectangle(Brushes.BlueViolet, 0, 0, ClientSize.Width, ClientSize.Height);

                
        }
    }
}

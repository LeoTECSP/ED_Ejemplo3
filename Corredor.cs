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
    public partial class Corredor : UserControl
    {
        //byte esttus;

        //-Forma del profe:
        //Variable global
        private bool detenerCholo;
        
        public Corredor()
        {
            InitializeComponent();
            BackgroundImageLayout = ImageLayout.Stretch;

       

            //if (esttus == 1)
            //{
            //    timer1.Stop();
            //}
        }
        //public byte Estatus
        //{
        //    get { return esttus; }
        //    set { esttus = value; }
        //}
       
        //-Propiedad para proteger a la variable 
        public bool DetenerCholo
        {
            get {return detenerCholo; } //tomar el detenercholo
            set {detenerCholo = value; } //darle el valor a detenercholo
           

        }

        private int frame = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
          

            frame++;
                switch (frame)
                {
                    case 1: BackgroundImage = Properties.Resources._1; break;
                    case 2: BackgroundImage = Properties.Resources._2; break;
                    case 3: BackgroundImage = Properties.Resources._3; break;
                    case 4: BackgroundImage = Properties.Resources._4; break;
                    case 5: BackgroundImage = Properties.Resources._3; break;
                    default:
                        BackgroundImage = Properties.Resources._2;
                        frame = 0;
                        break;
                }
            //if (esttus ==1)
            //{
            //    timer1.Stop();
            //}

            if (detenerCholo == true)
            {
                timer1.Enabled = false;
            }
        }
    }
}

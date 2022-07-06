using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoSnake
{
    public partial class Form1 : Form
    {
        List<PictureBox> Lista = new List<PictureBox>();
        int TamanioPiezaPrincipal = 26, tiempo = 10;
        PictureBox Comida = new PictureBox();
        String Direccion = "right"; // Dirección del snake

        public Form1()
        {
            InitializeComponent();
            IniciarJuego();
        }
        public void IniciarJuego() {
            tiempo = 10;
            Direccion = "right";
            timer1.Interval = 200;
            lblPuntos.Text = "0";
            Lista = new List<PictureBox>();
            // Piezas iniciales 
            for (int i = 2; 0 <= i; i--)
            {
                CrearSnake(Lista, this, (i * TamanioPiezaPrincipal) + 70, 80);
            
            }
            CrearComida();

        
        }
        public void CrearSnake(List<PictureBox> ListaPelota, Form formulario, int posicionx, int posiciony)
        {

            PictureBox pb = new PictureBox();
            pb.Location = new Point(posicionx, posiciony);
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("bodySnake");
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            ListaPelota.Add(pb);
            formulario.Controls.Add(pb);
        }
        private void CrearComida()
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int nx = Lista[0].Location.X;
            int ny = Lista[0].Location.Y;
            // Colocar la pieza Principal( Cabeza de la serpiente)
            Lista[0].Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("head" + Direccion);

            for (int i = Lista.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {

                }
                else { 

                }
            }

        }

    }
}

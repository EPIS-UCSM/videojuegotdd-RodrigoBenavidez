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
        int ComidaNecesariaPorNivel = 3;

        public Form1()
        {
            InitializeComponent();
            IniciarJuego();
        }
        public void IniciarJuego(int interval = 200)
        {
            tiempo = 10;
            Direccion = "right";
            timer1.Interval = interval;
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

            Random rnd = new Random();
            int enterox = rnd.Next(1, this.Width - TamanioPiezaPrincipal - 10);
            int enteroy = rnd.Next(1, this.Height - TamanioPiezaPrincipal - 40);

            PictureBox pb = new PictureBox();
            pb.Location = new Point(enterox, enteroy);
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("manzanaa");
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            Comida = pb;
            this.Controls.Add(pb);

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
                    if (Direccion == "right") nx = nx + TamanioPiezaPrincipal;
                    else if (Direccion == "left") nx = nx - TamanioPiezaPrincipal;
                    else if (Direccion == "up") ny = ny - TamanioPiezaPrincipal;
                    else if (Direccion == "down") ny = ny + TamanioPiezaPrincipal;
                    Lista[0].Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("head" + Direccion);
                    Lista[0].Location = new Point(nx, ny);
                }
                else
                {
                    // intercambio de seguimiento 
                    Lista[i].Location = new Point((Lista[i - 1].Location.X), (Lista[i].Location.Y));
                    Lista[i].Location = new Point(Lista[i].Location.X, Lista[i - 1].Location.Y);


                }
            }
            // detectar colisión 
            for (int contarPiezas = 1; contarPiezas < Lista.Count; contarPiezas++)
            {
                if (Lista[contarPiezas].Bounds.IntersectsWith(Comida.Bounds))
                {
                    this.Controls.Remove(Comida); // remueve la comida 
                    tiempo = Convert.ToInt32(timer1.Interval); // aumenta el tiempo
                    if (tiempo > 10) { timer1.Interval = tiempo - 10; }
                    lblPuntos.Text = (Convert.ToInt32(lblPuntos.Text) + 1).ToString();

                    // Sube de nivel
                    if (Convert.ToInt32(lblPuntos.Text) >= ComidaNecesariaPorNivel)
                    {
                        iniciarNivel(Convert.ToInt32(lblNivel.Text) + 1);
                    }
                    else
                    {
                        CrearComida(); // crea nueva comida
                        CrearSnake(Lista, this, Lista[Lista.Count - 1].Location.X * TamanioPiezaPrincipal, 0); // nueva parte del snake
                    }



                }
            }
            // detectar solisión con paredes (form)
            if ((Lista[0].Location.X >= this.Width - 15) || (Lista[0].Location.Y >= this.Height - 50) || (Lista[0].Location.Y < -10) || (Lista[0].Location.X < -30))
            {

                timer1.Stop();

                string message = "GAME OVER - Desea continuar?";
                string caption = "Error Detectado";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    lblNivel.Text = "1";
                    timer1.Start();
                    ReiniciarJuego();
                }
                else
                {
                    // Closes the parent form.
                    this.Close();
                }


            }
            // colisión con el cuerpo del snake (piezas )
            for (int contarPiezas = 1; contarPiezas < Lista.Count; contarPiezas++)
            {
                if (Lista[0].Bounds.IntersectsWith(Lista[contarPiezas].Bounds))
                {
                    timer1.Stop();

                    string message = "GAME OVER - Desea continuar?";
                    string caption = "Error Detectado";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        lblNivel.Text = "1";
                        timer1.Start();
                        ReiniciarJuego();
                    }
                    else
                    {
                        // Closes the parent form.
                        this.Close();
                    }
                }

            }



        }

        public void ReiniciarJuego(int interval = 200)
        {
            foreach (PictureBox Serpiente in Lista) { this.Controls.Remove(Serpiente); }
            this.Controls.Remove(Comida);
            IniciarJuego(interval);

        }

        private void nivel1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciarNivel(1);
        }

        private void iniciarNivel(int n = 1)
        {
            if (n >= 9)
            {
                timer1.Stop();
                string message = "CONGRATULATIONS \nUsted llego al nivel mas alto.\n¿desea iniciar a jugar de nuevo?";
                string caption = "Victoria";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    iniciarNivel(1);
                }
                else
                {
                    // Closes the parent form.
                    this.Close();
                }

            } else
            {
                ReiniciarJuego(200 - (n - 1) * 20);
                lblNivel.Text = n.ToString();
                timer1.Start();
            }

            
        }

        private void seleccioneNivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void continuarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void nivel2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciarNivel(2);
        }

        private void nivel3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciarNivel(3);
        }

        private void nivel4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciarNivel(4);
        }

        private void nivel5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciarNivel(5);
        }

        private void nivel6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciarNivel(6);
        }

        private void nivel7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciarNivel(7);
        }

        private void nivel8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciarNivel(8);
        }

        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void manzanasToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            ComidaNecesariaPorNivel = 25;
            iniciarNivel(Convert.ToInt32(lblNivel.Text));
        }

        private void manzanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComidaNecesariaPorNivel = 3;
            iniciarNivel(Convert.ToInt32(lblNivel.Text));
        }

        private void nroManzanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void manzanasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ComidaNecesariaPorNivel = 5;
            iniciarNivel(Convert.ToInt32(lblNivel.Text));
        }

        private void manzanasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ComidaNecesariaPorNivel = 7;
            iniciarNivel(Convert.ToInt32(lblNivel.Text));
        }

        private void manzanasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ComidaNecesariaPorNivel = 9;
            iniciarNivel(Convert.ToInt32(lblNivel.Text));
        }

        private void manzanasToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ComidaNecesariaPorNivel = 11;
            iniciarNivel(Convert.ToInt32(lblNivel.Text));
        }

        private void manzanasToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ComidaNecesariaPorNivel = 13;
            iniciarNivel(Convert.ToInt32(lblNivel.Text));
        }

        private void manzanasToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ComidaNecesariaPorNivel = 15;
            iniciarNivel(Convert.ToInt32(lblNivel.Text));
        }

        private void manzanasToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ComidaNecesariaPorNivel = 20;
            iniciarNivel(Convert.ToInt32(lblNivel.Text));
        }

        private void manzanasToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            ComidaNecesariaPorNivel = 30;
            iniciarNivel(Convert.ToInt32(lblNivel.Text));
        }

        private void manzanasToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            ComidaNecesariaPorNivel = 50;
            iniciarNivel(Convert.ToInt32(lblNivel.Text));
        }

        private void manzanasToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            ComidaNecesariaPorNivel = 70;
            iniciarNivel(Convert.ToInt32(lblNivel.Text));
        }

        private void MoverPieza(object sender, KeyEventArgs e)
        {
            Direccion = ((e.KeyCode & Keys.Up) == Keys.Up) ? "up" : Direccion;
            Direccion = ((e.KeyCode & Keys.Down) == Keys.Down) ? "down" : Direccion;
            Direccion = ((e.KeyCode & Keys.Left) == Keys.Left) ? "left" : Direccion;
            Direccion = (((e.KeyCode & Keys.Right) == Keys.Right)) ? "right" : Direccion;

        }
    }
}

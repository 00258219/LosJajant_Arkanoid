using System;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Properties;

namespace Arkanoid
{
    public sealed partial class Game : UserControl
    {
        public Game()
        {
            InitializeComponent(); 
            Dock = DockStyle.Fill;
            DoubleBuffered = true;
        }
        
        private void Game_Load(object sender, EventArgs e)
        {
            tableLayoutPanel2.BackColor = Color.FromArgb(70, tableLayoutPanel2.BackColor);
            BackgroundImage = Resources.gameBackground;
            pictureBox1.Image = Resources.heartf;
            pictureBox2.Image = Resources.heartf;
            pictureBox3.Image = Resources.heartf;
            pictureBox4.Image = Resources.plataform;
            pictureBox5.Image = Resources.ball;
            
            //Debemos quitar el tableyout para el movimiento de la pelota y plataforma, asi que guardamos
            //los componentes importantes
            var tlp2 = tableLayoutPanel2;
            var pb4 = pictureBox4;
            var pb5 = pictureBox5;
            var tlp4 = tableLayoutPanel4;

            var tlp2size = tableLayoutPanel2.Size;
            var tlp4size = tableLayoutPanel4.Size;
            //Borramos todos lo componentes que esten en este userControl
            Controls.Clear();
        
            //Agregamos los importantes
            tlp2.Dock = DockStyle.None;
            tlp2.Size = tlp2size;
            Controls.Add(tlp2);//score
            Controls.Add(pb4);//plataforma
            Controls.Add(pb5);//pelota
            tlp4.Dock = DockStyle.None;
            tlp4.Size = tlp4size;
            Controls.Add(tlp4);//los bloques

            tlp4.Location = new Point(tlp4.Location.X, tlp4.Location.Y+80);
            pb5.Location = new Point(pb5.Location.X, pb5.Location.Y+100);

            fillRowBlock(Resources.block5t, 0, tlp4);
            fillRowBlock(Resources.block3t, 1, tlp4);
            fillRowBlock(Resources.block2t, 2, tlp4);
            fillRowBlock(Resources.block1t, 3, tlp4);
        }
        
        //Esta funcion rellana cada fila de un tableLayout que contendra los bloques del juego.
        private void fillRowBlock(Image im, int rowN, TableLayoutPanel tlp)
        {
            for (int i = 0; i < 6; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Dock = DockStyle.Fill;
                pb.Margin = new Padding(6, 0, 6, 8);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Image = im;
                tlp.Controls.Add(pb, i+1, rowN);
            }
        }
        
        //necesita mejorar
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            //con el controls accedo a la plataforma [1] o a la pelota [2]
            var plat = Controls[2];
            //pueden probar con el key right y left a ver si les sirve
            switch (e.KeyCode)
            {
                case Keys.A:
                    plat.Location = new Point(plat.Location.X - (5) , plat.Location.Y);
                    break;
                case Keys.D:
                    plat.Location = new Point(plat.Location.X + (5) , plat.Location.Y);
                    break;
                case Keys.S:
                    plat.Location = new Point(plat.Location.X , plat.Location.Y + (5));
                    break;
                case Keys.W:
                    plat.Location = new Point(plat.Location.X  , plat.Location.Y - (5));
                    break;
            }
            */
        }
        
    }
}
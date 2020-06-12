using System;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Properties;
using System.Windows.Input;
using Arkanoid.Controlador;
using Arkanoid.Modelo;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace Arkanoid
{
    public sealed partial class Game : UserControl
    {
        //variable que guarda el tiempo de juego
        private int currentTime = 240; //4 mins
        //variable que describe si la pelota esta fijada con la plataforma
        private bool trapped = true;

        public Game()
        {
            InitializeComponent(); 
            Dock = DockStyle.Fill;
            DoubleBuffered = true;
        }
        
        private void Game_Load(object sender, EventArgs e)
        {
            //cargando las imagenes y fondos
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
            
            //creando label de tiempo
            var labelTime = new Label();
            labelTime.Name = "labelTime";
            labelTime.BackColor = Color.FromArgb(130, 7,0,48);
            labelTime.Size = tlp2.Controls[4].Size;
            labelTime.Height -= pb4.Height/2;
            labelTime.Location = new Point( tlp2.Controls[5].Location.X, pb4.Location.Y+pb4.Height);
            labelTime.Font = new Font("Blader", 30F, FontStyle.Regular, 
                GraphicsUnit.Point, ((byte) (0)));
            labelTime.ForeColor = Color.White;
            labelTime.TextAlign = ContentAlignment.MiddleCenter;
            labelTime.Text = currentTime.ToString();
            
            //Agregamos los importantes
            tlp2.Dock = DockStyle.None;
            tlp2.Size = tlp2size;
            Controls.Add(tlp2);//[0]score
            Controls.Add(pb4);//[1]plataforma
            Controls.Add(labelTime);//[2]tiempo
            Controls.Add(pb5);//[3]pelota
            tlp4.Dock = DockStyle.None;
            tlp4.Size = tlp4size;
            Controls.Add(tlp4);//[4]los bloques

            //Hacer que la pelota inicie justo arriba de la plataforma y ajustando la posicion de los bloques
            pb5.Location = new Point(pb5.Location.X, pb4.Location.Y-pb5.Height);
            tlp4.Location = new Point(tlp4.Location.X, tlp4.Location.Y+100);

            //colocando los bloques en el juego
            fillRowBlock(Resources.block5t, 5, 0, tlp4);
            fillRowBlock(Resources.block3t, 3, 1, tlp4);
            fillRowBlock(Resources.block2t, 2, 2, tlp4);
            fillRowBlock(Resources.block1t, 1, 3, tlp4);
            
            //Iniciar puntaje
            scoreLabel.Text = PanelControlator.score.ToString("D7");
            
            
            Focus();
        }
        
        //Esta funcion rellana cada fila de un tableLayout que contendra los bloques del juego.
        private void fillRowBlock(Image im, int hits, int rowN, TableLayoutPanel tlp)
        {
            for (int i = 0; i < 6; i++)
            {
                PictureBox pb = new BlockPB(im, hits);
                tlp.Controls.Add(pb, i+1, rowN);
            }
        }
        
        //Funcion que inicia el conteo de tiempo del juego mediante el timeLimit_Tick.
        private void startTime()
        {
            timeLimit.Enabled = true;
            timeLimit.Interval = (1000);
            timeLimit.Start();
        }
        private void timeLimit_Tick(object sender, EventArgs e)
        {
            //Mientras el tiempo no llegue a cero restar 1 segundo, si es cero entonces se para.
            if (currentTime == 0)
            {
                timeLimit.Stop();
            }
            else
            {
                currentTime--;
                Controls[2].Text = currentTime.ToString("D3");
            }
        }
        
        //Funcion que realiza el movimiento de la plataforma, ya sea de lado izquierdo o derecho, con o sin la pelota
        //fijada, por medio de variables booleanas
        private void plataformMove(bool left)
        {
            var speed = 15;
            var plat = Controls[1];
            var ball = Controls[3];
            var limitRight = ClientSize.Width - plat.Width;
            if (left && (plat.Left != 0))
            {
                plat.Left -= speed;
                if (trapped)
                    ball.Left -= speed;
            }
            else if(left == false && (plat.Left < limitRight))
            {
                plat.Left += speed;
                if (trapped)
                    ball.Left += speed;
            }
        }
        
        //Evento para el movimiento de la plataforma e inicio del juego
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            //Si tiene las siguientes dos teclas presionadas que la plataforma se detenga
            if ((Keyboard.IsKeyDown(Key.Left) && Keyboard.IsKeyDown(Key.Right))||
                (Keyboard.IsKeyDown(Key.A) && Keyboard.IsKeyDown(Key.D))||
                (Keyboard.IsKeyDown(Key.A) && Keyboard.IsKeyDown(Key.Right))||
                (Keyboard.IsKeyDown(Key.Left) && Keyboard.IsKeyDown(Key.D)))
                return;
            
            //movimiento a la izquierda
            if (Keyboard.IsKeyDown(Key.A) || Keyboard.IsKeyDown(Key.Left))
                plataformMove(true);
            //movimiento a la derecha
            else if(Keyboard.IsKeyDown(Key.D) || Keyboard.IsKeyDown(Key.Right))
                plataformMove(false);

        }
        
        private void Game_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Esto ayuda a detectar las arrow keys cuando es precionada
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Right:
                case Keys.Left:
                case Keys.Space:
                    e.IsInputKey = true;
                    break;
            }
        }
        
    }
}
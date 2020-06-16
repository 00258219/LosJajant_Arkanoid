using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Arkanoid.Properties;
using System.Windows.Input;
using Arkanoid.Controlador;
using Arkanoid.Modelo;
using ContentAlignment = System.Drawing.ContentAlignment;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace Arkanoid
{
    public sealed partial class Game : UserControl
    {
        //variable que guarda el tiempo de juego
        private int currentTime = 240; //4 mins
        //variable que describe si la pelota esta fijada con la plataforma
        public static bool trapped = true;
        
        //Variable
        List<BlockPB> bloques = new List<BlockPB>();
        
        public Game()
        {
            InitializeComponent(); 
            Dock = DockStyle.Fill;
            DoubleBuffered = true;
        }
        
        public void Game_Load(object sender, EventArgs e)
        {
            //cargando las imagenes y fondos
            tableLayoutPanel2.BackColor = Color.FromArgb(70, tableLayoutPanel2.BackColor);
            //BackgroundImage = Resources.gameBackground;
            pictureBox1.Image = Resources.heartf;
            pictureBox2.Image = Resources.heartf;
            pictureBox3.Image = Resources.heartf;
            pictureBox4.Image = Resources.plataform;
            pictureBox5.Image = Resources.ball;
            
            pictureBox4.BackColor=Color.Azure;
            pictureBox5.BackColor=Color.Bisque;
            
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
            
            //Comenzando el timerPlayer
            startTimePlayer();
            
            //Activando el timeLimit para llevar el conteo  del tiempo de partida
            startTime();

            //Removiendo el TableLayoutPanel que contiene los bloques
            //Guardamos la ubicacion y tamaño que deben llevar
            int valueY = tlp4.Top;
            int valueX = tlp4.Left;
            var blockSize = tlp4.Controls[0].Size;
            //Quitamos el tlp del userControl
            Controls.Remove(tlp4);
            //Recorremos el controls de tlp4 que es quien contiene los bloques
            foreach (var i in tlp4.Controls)
            {
                BlockPB blockAux = (BlockPB) i;
                blockAux.Dock = DockStyle.None;
                bloques.Add(blockAux);//lo agregamos a una lista simple
            }

            foreach (var i in bloques)//recorremos la lista simple que contiene los bloques
            {
                Controls.Add(i);//los agregamos al UserControl
                i.Size = blockSize;
                i.Top += valueY;
                i.Left += valueX;
            }
            
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
        
        //Metodo que inicia los movimientos de la pelota;
        private void startTimePlayer()
        {
            timePlayer.Enabled = true;
            timePlayer.Start();
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
            if (e.KeyCode == Keys.Space) {
                GameData.StartGame = true;
                trapped = false; //Cambiar la condicion para que se muevan independientemente
               
            }

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
        
        //Metodo que realiza lleva a cabo los movimientos de la pelota
        private void timePlayer_Tick(object sender, EventArgs e)
        {
            //Si el juego no ha inicia no realiza moviemientos de la pelota
            if (!GameData.StartGame)
                return;
            
            //Movimiento de la pelota    
            BallMoves();
            
            //Colisiones
            Bounces();
        }

        //Metodo para realizar los movimientos de la pelota
        private void BallMoves()
        {
            pictureBox5.Left += GameData.xSpeed;
            pictureBox5.Top += GameData.ySpeed;
        }

        //Metodo que se encarga de revisar las colisiones
        private void Bounces()
        {
            //Genera un rebote en la parte superior
            if(pictureBox5.Top<tableLayoutPanel2.Bottom)
                GameData.ySpeed = -GameData.ySpeed;
            
            //Condicion para que rebote cuando colisione con el borde
            if(pictureBox5.Left<0 || pictureBox5.Right>Width){
                GameData.xSpeed = -GameData.xSpeed;
                return;
            }
            
            // Condicion para que la pelota rebote con la plataforma
            if (pictureBox5.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                GameData.ySpeed = -GameData.ySpeed;
                return;
            }
            
            //Para conocer las colisiones entre la pelota y el bloque
            foreach (var block in bloques) 
            {
            
                //Condicion para conocer si el bloque esta activo y existe colision
                if (block.Enabled && Controls[3].Bounds.IntersectsWith(block.Bounds))
                {
                    block.Beaten(scoreLabel); // Verificando golpes y puntaje
                    
                    GameData.ySpeed = -GameData.ySpeed; //Cambia la direccion al chocar
                      
                }
            }

            /*
            //Cuando no tiene más vidas, aparece la ventana de GameOver
            if(pictureBox5.Bottom>pictureBox4.Bottom+10)
            {
                timePlayer.Stop();
                timeLimit.Stop();
                //Mostrando el Form GameOver de esta manera, inabilita el uso del Form Game mientras esté abierto GameOver
                NewGameOver();
            }   
            */
        }

        /*
        //Método que muestra la ventana de GameOver y deja el fondo oscuro
        private void NewGameOver()
        {
            //Tomando una "captura" del form completo con sus controles existentes
            //bmp se convierte en una "copia" de nuestro form Game
            Bitmap bmp = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
            
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                G.CopyFromScreen(this.PointToScreen(new Point(0, 0)), new Point(0, 0), this.ClientRectangle.Size);
                //Haciendo oscuro el fondo
                Color darken = Color.FromArgb(220, Color.Black);
                using (Brush brsh = new SolidBrush(darken))
                {
                    //Coloreando el fondo de la copia del Form
                    G.FillRectangle(brsh, this.ClientRectangle);
                }
            }

            //Poniendo la "captura oscura" del form por delante del form actual
            using (Panel p = new Panel())
            {
                p.Location = new Point(0, 0);
                p.Size = this.ClientRectangle.Size;
                p.BackgroundImage = bmp;
                this.Controls.Add(p);
                p.BringToFront();

                //Mostrando el Game Over
                GameOver gameOver = new GameOver();
                gameOver.StartPosition = FormStartPosition.CenterParent;
                
                //Se mostrará dde esta forma, ya que deja inabilitado el form del fondo, y a su vez esperará
                //una respuesta para volver a la normalidad (form no oscurecido)
                gameOver.ShowDialog(this);
            }
        }
        */
    }
}
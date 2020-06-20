using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Arkanoid.Properties;
using System.Windows.Input;
using Arkanoid.Controlador;
using ContentAlignment = System.Drawing.ContentAlignment;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;
using Arkanoid.Modelo;

namespace Arkanoid
{
    public sealed partial class Game : UserControl
    {
        //variable que guarda el tiempo de juego
        private double currentTime = 150.00; //2 mins y 30 seg
        //variable que describe si la pelota esta fijada con la plataforma
        public static bool trapped = true, isEmpty=false;
        private Action FinishGame, WinningGame;

        //Lista que identifica a los bloques
        List<BlockPB> blocksList = new List<BlockPB>();
        
        //Agregando delegates 
        private delegate void MyDelegate();
        static MyDelegate ballActions,timeActions;
        
        public Game()
        {
            InitializeComponent(); 
            Dock = DockStyle.Fill;
            DoubleBuffered = true;

            //Suscribiendo las acciones de la pelota
            ballActions = BallMoves;
            ballActions += Bounces;
            //Suscribiendo la accion de inicio de tiempo
            timeActions = startTimePlayer;
            //suscribiendo acciones de finishgame and wingame
            FinishGame = () =>
            {
                GameData.timePlayer = 150 - Convert.ToInt32(Math.Floor(currentTime));
                timePlayer.Stop();
                GameData.tmrPlayer = false;
                NewGameOver();
            };
            WinningGame = () =>
            {
                GameData.timePlayer = 150 - Convert.ToInt32(Math.Floor(currentTime));
                timePlayer.Stop();
                GameData.tmrPlayer = false;
                GameData.winner = true;
                GameData.AddScoreDB();
                //Mostrando el Form GameOver de esta manera, inabilita el uso del Form Game
                //mientras esté abierto GameOver
                NewGameOver();
            };
        }
        public void Game_Load(object sender, EventArgs e)
        {
            //cargando las imagenes y fondos
            tableLayoutPanel2.BackColor = Color.FromArgb(70, tableLayoutPanel2.BackColor);
            BackgroundImage = Resources.gameBackground;
            life1.Image = Resources.heartf;
            life2.Image = Resources.heartf;
            life3.Image = Resources.heartf;
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
             //posiciones pelota y plataforma
             pb4.Top = Height - pb4.Height - 80;
             pb4.Left = (Width / 2) - (pb4.Width / 2);

             pb5.Height = pb5.Width = pictureBox5.Height = pictureBox5.Width;
             pb5.Top = pb5.Top - pb5.Height;
             pb5.Left = pb4.Left + (pb4.Width / 2) - (pb5.Width / 2);
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
            scoreLabel.Text = GameData.scoreBlocks.ToString("D7");

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
                blocksList.Add(blockAux);//lo agregamos a una lista simple
            }

            foreach (var i in blocksList)//recorremos la lista simple que contiene los bloques
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
        
        
        //Metodo que inicia los movimientos de la pelota;
        private void startTimePlayer()
        {
            timePlayer.Enabled = true;
            timePlayer.Interval = 70; //version 1.0
            //timePlayer.Interval=1; version 2.0
            timePlayer.Start();
            GameData.tmrPlayer = true;
        }
        
        //Funcion que realiza el movimiento de la plataforma, ya sea de lado izquierdo o derecho, con o sin la pelota
        //fijada, por medio de variables booleanas
        private void plataformMove(bool left)
        {
            var speed = 15;
            var plat = Controls[1];
            var ball = Controls[3];
            var limitRight = ClientSize.Width - plat.Width;

            try
            {
                if (left && (plat.Left > 0))
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
            catch (OutOfBoundsException Ex)
            {
                DialogResult dr = MessageBox.Show(Ex.Message);
                if (dr == DialogResult.OK)
                {
                    //Regresando la plataforma al centro
                    pictureBox4.Top = Height - pictureBox4.Height - 80;
                    pictureBox4.Left = (Width / 2) - (pictureBox4.Width / 2);
                }
            }
        }
        
        //Evento para el movimiento de la plataforma e inicio del juego
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //Cuando presione ESC se pausará el juego
                if (Keyboard.IsKeyDown(Key.Escape))
                    throw new GamePausedException("Juego en pausa, presione ACEPTAR para continuar");
                
                //Cuando minimice la pantalla, se pondrá en pausa
                if(GameData.StartGame==true && GameData.tmrPlayer==false)
                    throw new MinimizingPauseException("Juego en pausa, presione ACEPTAR para continuar");
                
                //Detectar SPACE para comenzar el juego
                if(GameData.StartGame==false && !Keyboard.IsKeyDown(Key.Space) && 
                   !Keyboard.IsKeyDown(Key.Escape) && !Keyboard.IsKeyDown(Key.Left) && 
                   !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.A) && 
                   !Keyboard.IsKeyDown(Key.D))
                    throw new StartOfTheGameException("Presiona SPACE para jugar");
            }
            catch (GamePausedException Ex)
            {
                timePlayer.Stop();
                GameData.tmrPlayer = false;

                DialogResult dR = MessageBox.Show(Ex.Message);
                
                if (dR == DialogResult.OK && GameData.StartGame==true)
                {
                    timePlayer.Start();
                    GameData.tmrPlayer = true;
                    timeActions.Invoke();
                }
            }
            catch (StartOfTheGameException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (MinimizingPauseException Ex)
            {
                DialogResult dR = MessageBox.Show(Ex.Message);
                
                if (dR == DialogResult.OK && GameData.StartGame==true)
                {
                    timePlayer.Start();
                    GameData.tmrPlayer = true;
                    timeActions.Invoke();
                }   
            }
            

            if (e.KeyCode == Keys.Space) {
                //Inicio de tiempo de jugador e inicio de conteo para tiempo de partida
                timeActions.Invoke();
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
        
        //funcion que verifica el tiempo restante de juego
        private void RemainingTimePlayer()
        {
            if (currentTime <= 1)
            {
                FinishGame?.Invoke();
            }
            else
            {
                currentTime-=0.07;
                //mostrar el tiempo restante
                Controls[2].Text = Convert.ToInt32(Math.Floor(currentTime)).ToString("D3");
            }
        }
        
        //Metodo que realiza lleva a cabo los movimientos de la pelota
        private void timePlayer_Tick(object sender, EventArgs e)
        {
            RemainingTimePlayer();
            //Si el juego no ha inicia no realiza moviemientos de la pelota
            if (!GameData.StartGame)
                return;
            
            ballActions.Invoke();
            
        }

        //Metodo para realizar los movimientos de la pelota
        private void BallMoves()
        {
            pictureBox5.Left += GameData.xSpeed;
            pictureBox5.Top += GameData.ySpeed;
        }
        
        //Metodo para reposicionar la pelota y la plataforma al centro cuando se  pierde una vida
        
        private void Relocation()
        {
            Controls[1].Left = (Width / 2) - (Controls[1].Width / 2);
            Controls[3].Top = Controls[1].Top - Controls[3].Height;
            Controls[3].Left = Controls[1].Left + (Controls[1].Width / 2) - (Controls[3].Width / 2);
            trapped = true;
        }

        //Metodo que se encarga de revisar las colisiones
        private void Bounces()
        {
            //Random para el rebote
            Random random= new Random();
            
            //verifica si la pelota cae al vacio
            if (pictureBox5.Bottom > Height)
            {
                GameData.life--;
                timePlayer.Stop();
                
                
                switch (GameData.life)
                {
                    case 2:
                        life3.Image = Image.FromFile("../../Resources/heartn.png");
                        Relocation();
                        break;
                    case 1:
                        life2.Image = Image.FromFile("../../Resources/heartn.png");
                        Relocation();
                        break;
                    case 0:
                        life1.Image = Image.FromFile("../../Resources/heartn.png");
                        FinishGame?.Invoke();
                        break;
                }
            }
            
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
                //version 1.0
                pictureBox5.Top -= (pictureBox5.Bottom - pictureBox4.Top);
                GameData.ySpeed = -random.Next(13, 23);
                
                //GameData.ySpeed = -(rnd.Next(3,6)); version 2.0
                
                return;
            }
            
            //Condicion para conocer si el bloque esta activo y existen colisiones
                if (Collisions())
                {
                    GameData.ySpeed = -GameData.ySpeed; //Cambia la direccion al chocar
                    
                    if (GameData.remainingBlocks==0)
                    {
                        WinningGame?.Invoke(); 
                    }
                }
        }

        //Método que muestra la ventana de GameOver y deja el fondo oscuro
        private void NewGameOver()
        {
            //Tomando una "captura" del form completo con sus controles existentes
            //bmp se convierte en una "copia" de nuestro form Game
            Bitmap bmp = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
            
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                G.CopyFromScreen(this.PointToScreen(new Point(0, 0)),
                    new Point(0, 0), this.ClientRectangle.Size);
                
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
                gameOver.ShowDialog();
            }
        }
        
        //Método que verifica todas las colisiones que pueden haber en un mismo momento.
        private bool Collisions()
        {
            //Detecta que haya al menos una colision
            foreach (var block in blocksList)
            {
                //Condicion para conocer si el bloque esta activo y existe colision
                if (block.Enabled && Controls[3].Bounds.IntersectsWith(block.Bounds))
                {
                    //Realiza el cambio de imagen cuando hay colision
                    block.CollisionImage(block.Top);
                     
                    // Verificando golpes y puntaje
                    block.Beaten(scoreLabel);
 
                    return true; //Si hay colisiones su valor cambia
                }
            }
            return false;
        }
        
        //Método que se usará con el delegate de Form para pausar el juego al minimizar
        //la pantalla
        public void StopTimerPlayer()
        {
            if (GameData.StartGame == true)
            {
                timePlayer.Stop();
                GameData.tmrPlayer = false;
            }
        }
    }
}
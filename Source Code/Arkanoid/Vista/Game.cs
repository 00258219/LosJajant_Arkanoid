using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using Arkanoid.Controlador;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;
using Arkanoid.Modelo;


namespace Arkanoid
{
    public sealed partial class Game : UserControl
    {
    
        #region Initialize components code
        
        //Inizializando componentes del juego
        private Panel scorePnl = new Panel();
        private Label scoreLbl = new Label();
        private Label lives = new Label();
        private PictureBox life1 = new PictureBox();
        private PictureBox life2 = new PictureBox();
        private PictureBox life3 = new PictureBox();
        private PictureBox plataform = new PictureBox();
        private PictureBox ball = new PictureBox();
        private Label timeLbl = new Label();
        
        #endregion
        
        //Lista de los bloques en el juego
        private List<BlockPB> blocksList = new List<BlockPB>();
        
        //Agregando actions
        private Action LoadGame, WinningGame, FinishGame, BallActions;

        public Game()
        {
            InitializeComponent(); 
            Dock = DockStyle.Fill;
            DoubleBuffered = true;
            
            #region Asignando las acciones
            
            //Suscribiendo las acciones
            LoadGame = () =>
            {
                LoadScorePanel();
                LoadPlataform_Ball_Time();
                LoadBlocks();
                Focus();
            };
            
            BallActions = BallMoves;
            BallActions += Bounces;
            
            WinningGame = () =>
            {
                //Al ganar el juego, se indica que el jugador gana, se para el tiempo del juego y
                //se llama la ventana GameOver
                tmrGame.Stop();
                GameData.timePlayed = Convert.ToInt32(Math.Floor(GameData.currentTime));
                GameData.activeTimer = false;
                GameData.winner = true;
                GameData.RegisterPlayer();
                NewGameOver();
            };
            
            FinishGame = () =>
            {
                //Al perder el juego, basta con llamar la ventana GameOver
                tmrGame.Stop();
                GameData.timePlayed = Convert.ToInt32(Math.Floor(GameData.currentTime));
                GameData.activeTimer = false;
                GameData.life = 0;
                NewGameOver();
            };
            
            #endregion
            
        }
        
        private void Game_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("../../Resources/gameBackground.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            LoadGame?.Invoke(); 
        }
        
        private void LoadScorePanel() 
        {
            #region Código para cargar todo el panel del score
            scorePnl.BackColor = Color.FromArgb(70, Color.Gray);
            scorePnl.Top = (int) (Height * 0.04);
            scorePnl.Left = (int) (Width * 0.02);
            scorePnl.Height = (int) (Height * 0.10);
            scorePnl.Width = (int) (Width * 0.96);
            Controls.Add(scorePnl);
            
            scoreLbl.BackColor = Color.Transparent;
            scoreLbl.Font = new Font("Blader", 36F, FontStyle.Regular, 
                GraphicsUnit.Point, ((byte) (0)));
            scoreLbl.ForeColor = Color.White;
            scoreLbl.Text = "SCORE : "+GameData.scoreBlocks.ToString("D7");
            scoreLbl.TextAlign = ContentAlignment.MiddleCenter;
            scoreLbl.Height = scorePnl.Height;
            scoreLbl.Width = (int) (Width * 0.40);
            
            lives.BackColor = Color.Transparent;
            lives.Font = new Font("Blader", 36F, FontStyle.Regular, 
                GraphicsUnit.Point, ((byte) (0)));
            lives.ForeColor = Color.White;
            lives.Text = "LIVES : ";
            lives.TextAlign = ContentAlignment.MiddleRight;
            scoreLbl.Left = scoreLbl.Width;
            lives.Height = scorePnl.Height;
            lives.Width = (int) (Width * 0.36);
            
            life1.BackColor = life2.BackColor = life3.BackColor =  Color.Transparent;
            life1.SizeMode = life2.SizeMode = life3.SizeMode = PictureBoxSizeMode.Zoom;
            life1.Image = life2.Image = life3.Image = Image.FromFile("../../Resources/heartf.png");
            life1.Height = life2.Height = life3.Height = (int) (scorePnl.Height * 0.6);
            life1.Top = life2.Top = life3.Top = (int) (scorePnl.Height * 0.2);
            life1.Width = life2.Width = life3.Width = (int) (Width * 0.06);

            scorePnl.Controls.Add(scoreLbl);
            scorePnl.Controls.Add(lives);
            scorePnl.Controls.Add(life1);
            scorePnl.Controls.Add(life2);
            scorePnl.Controls.Add(life3);

            scoreLbl.Left = 0;
            lives.Left = scoreLbl.Width;
            life1.Left = lives.Left + lives.Width;
            life2.Left = life1.Left + life1.Width;
            life3.Left = life2.Left + life2.Width;
            #endregion
        }

        private void LoadPlataform_Ball_Time()
        {
            #region Código para cargar la plataforma, pelota y tiempo
            plataform.BackColor = Color.Transparent;
            plataform.SizeMode = PictureBoxSizeMode.StretchImage;
            plataform.Image = Image.FromFile("../../Resources/plataform.png");
            plataform.Height = (int) (Height * 0.04);
            plataform.Width = (int) (Width * 0.16);
            Controls.Add(plataform);
            plataform.Top = (int) (Height * 0.90);
            plataform.Left = (Width / 2) - (plataform.Width / 2);
            
            ball.BackColor = Color.Transparent;
            ball.SizeMode = PictureBoxSizeMode.StretchImage;
            ball.Image = Image.FromFile("../../Resources/ball.png");
            ball.Height = (int) (Height * 0.05);
            ball.Width = (int) (Height * 0.05);
            Controls.Add(ball);
            ball.Top = plataform.Top - ball.Height;
            ball.Left = (Width / 2) - (ball.Width / 2);
            
            timeLbl.BackColor = Color.FromArgb(130, 7,0,48);
            timeLbl.Font = new Font("Blader", 30F, FontStyle.Regular, 
                GraphicsUnit.Point, ((byte) (0)));
            timeLbl.ForeColor = Color.White;
            timeLbl.TextAlign = ContentAlignment.MiddleCenter;
            timeLbl.Text = "150";
            timeLbl.Height = (int) (Height * 0.10) - plataform.Height;
            timeLbl.Width = (int) (Width * 0.12);
            Controls.Add(timeLbl);
            timeLbl.Top = (int) (Height * 0.90) + plataform.Height;
            timeLbl.Left = (int) (Width * 0.85);
            #endregion
        }

        private void LoadBlocks()
        {
            #region Código para cargar todos los bloques
            
            //Variables auxilares para la generacion de bloques
            int columns = 6, rows = 4;
            int top = (int) (Height * 0.22), left = (int) (Width * 0.08);
            Size blockSize = new Size( (int) (Width * 0.13),(int) (Height * 0.05));

            var hitsBlocks = new List<int>() {5, 3, 2, 1};
            
            //Instanciacion y adicin al UC
            BlockPB blockAux;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    blockAux = new BlockPB(hitsBlocks[i], blockSize);
                    Controls.Add(blockAux);
                    blockAux.Top = top + (blockSize.Height * i) + (i * (int) (Width * 0.01));
                    blockAux.Left = left + (blockSize.Width * j) + (j * (int) (Width * 0.01));
                    
                    blocksList.Add(blockAux);
                }
            }
            
            #endregion
        }
        
        //Método que realiza el movimiento de la plataforma, con o sin la pelota fijada
        private void PlataformMove(bool left)
        {
            #region Movimiento de la plataforma
            var speed = 15;
            
            try
            {
                if (left && (plataform.Left > 0))
                {
                    plataform.Left -= speed;
                    if (GameData.trapped)
                        ball.Left -= speed;
                }
                else if(left == false && (plataform.Left < (ClientSize.Width - plataform.Width)))
                {
                    plataform.Left += speed;
                    if (GameData.trapped)
                        ball.Left += speed;
                }
            }
            catch (OutOfBoundsException Ex)
            {
                DialogResult dr = MessageBox.Show(Ex.Message);
                if (dr == DialogResult.OK)
                {
                    //Regresando la plataforma al centro
                    plataform.Left = (Width / 2) - (plataform.Width / 2);
                }
            }
            #endregion
        }
        
        //Evento para el movimiento de la plataforma e inicio del juego
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            #region Excepciones de pausado e inicio del juego
            try
            {
                //Cuando presione ESC se pausará el juego
                if (Keyboard.IsKeyDown(Key.Escape))
                    throw new GamePausedException("Juego en pausa, presione ACEPTAR para continuar");
                
                //Cuando minimice la pantalla, se pondrá en pausa
                if(GameData.startGame && GameData.activeTimer==false)
                    throw new MinimizingPauseException("Juego en pausa, presione ACEPTAR para continuar");
                
                //Detectar SPACE para comenzar el juego
                if(GameData.startGame==false && !Keyboard.IsKeyDown(Key.Space) && 
                   !Keyboard.IsKeyDown(Key.Escape) && !Keyboard.IsKeyDown(Key.Left) && 
                   !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.A) && 
                   !Keyboard.IsKeyDown(Key.D))
                    throw new StartOfTheGameException("Presiona SPACE para jugar");
            }
            catch (GamePausedException Ex)
            {
                tmrGame.Stop();
                GameData.activeTimer = false;

                DialogResult dR = MessageBox.Show(Ex.Message);
                
                if (dR == DialogResult.OK && GameData.startGame==true)
                {
                    tmrGame.Start();
                    GameData.activeTimer = true;
                    StartTimeGame();
                }
            }
            catch (StartOfTheGameException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (MinimizingPauseException Ex)
            {
                DialogResult dR = MessageBox.Show(Ex.Message);
                
                if (dR == DialogResult.OK && GameData.startGame)
                {
                    tmrGame.Start();
                    GameData.activeTimer = true;
                    StartTimeGame();
                }   
            }
            #endregion
            
            //Iniciar el juego con la tecla space
            if (e.KeyCode == Keys.Space) {
                StartTimeGame();
                GameData.startGame = true;
                GameData.trapped = false; //Cambiar la condicion para que la pelota se mueva independientemente
            }

            //Si tienes alguna de las siguientes dos teclas presionadas que la plataforma se detenga
            if ((Keyboard.IsKeyDown(Key.Left) && Keyboard.IsKeyDown(Key.Right))||
                (Keyboard.IsKeyDown(Key.A) && Keyboard.IsKeyDown(Key.D))||
                (Keyboard.IsKeyDown(Key.A) && Keyboard.IsKeyDown(Key.Right))||
                (Keyboard.IsKeyDown(Key.Left) && Keyboard.IsKeyDown(Key.D)))
                return;
            
            //Movimiento a la izquierda
            if (Keyboard.IsKeyDown(Key.A) || Keyboard.IsKeyDown(Key.Left))
                PlataformMove(true);
            //Movimiento a la derecha
            else if(Keyboard.IsKeyDown(Key.D) || Keyboard.IsKeyDown(Key.Right))
                PlataformMove(false);
        }
        
        //Método que ayuda a detectar las arrow keys cuando es precionada
        private void Game_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
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
        
        //Método que inicia el tiempo del juego
        private void StartTimeGame()
        {
            tmrGame.Enabled = true;
            tmrGame.Interval = 70;
            tmrGame.Start();
            GameData.activeTimer = true;
        }
        
        //Método que lleva a cabo los movimientos de la pelota
        private void TmrGame_Tick(object sender, EventArgs e)
        {
            GameRemainingTime();
            
            if (!GameData.startGame) //Si el juego no ha iniciado no realiza moviemientos de la pelota
                return;
            
            BallActions.Invoke();
        }

        //Método que verifica el tiempo restante de juego
        private void GameRemainingTime()
        {
            if (GameData.currentTime <= 1)
            {
                FinishGame?.Invoke();
            }
            else
            {
                GameData.currentTime-=0.07;
                //mostrar el tiempo restante
                timeLbl.Text = Convert.ToInt32(Math.Floor(GameData.currentTime)).ToString("D3");
            }
        }
        
        //Método para realizar los movimientos de la pelota
        private void BallMoves()
        {
            ball.Left += GameData.xSpeed;
            ball.Top += GameData.ySpeed;
        }
        
        //Método para reposicionar la pelota y la plataforma al centro cuando se pierde una vida
        private void Relocation()
        {
            plataform.Left = (Width / 2) - (plataform.Width / 2);
            ball.Top = plataform.Top - ball.Height;
            ball.Left = plataform.Left + (plataform.Width / 2) - (ball.Width / 2);
            GameData.trapped = true;
        }

        //Metodo que se encarga de revisar las colisiones
        private void Bounces()
        {
            //Random para el rebote
            Random random= new Random();
            
            #region Cargado de vidas
            
            //verifica si la pelota cae al vacio
            if (ball.Bottom > Height)
            {
                GameData.life--;
                tmrGame.Stop();
                
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
            #endregion
            
            #region Posibles Rebotes
            
            //Genera un rebote en la parte superior
            if(ball.Top<scorePnl.Bottom)
                GameData.ySpeed = -GameData.ySpeed;
            
            //Condicion para que rebote cuando colisione con el borde
            if(ball.Left<0 || ball.Right>Width){
                GameData.xSpeed = -GameData.xSpeed;
                return;
            }
            
            // Condicion para que la pelota rebote con la plataforma
            if (ball.Bounds.IntersectsWith(plataform.Bounds))
            {
                ball.Top -= (ball.Bottom - plataform.Top);
                GameData.ySpeed = -random.Next(14, 28);
                return;
            }
            
            //Condicion para conocer si el bloque esta activo y existen colisiones
            if (Collisions())
            {
                GameData.ySpeed = -GameData.ySpeed; //Cambia la direccion al chocar
                
                if (GameData.remainingBlocks==0)
                    WinningGame?.Invoke();
            }
            #endregion
        }
        
        //Método que verifica la colision de peloa y bloques en mismo momento.
        private bool Collisions()
        {
            //Detectar que bloque esta colisionando
            foreach (var block in blocksList)
            {
                //Condicion para conocer si el bloque esta activo y existe colision
                if (block.Enabled && ball.Bounds.IntersectsWith(block.Bounds))
                {
                    block.Beaten(scoreLbl); //Golpeando el bloque
                    return true; 
                }
            }
            return false;
        }

        //Método que muestra la ventana de GameOver y deja el fondo oscuro
        private void NewGameOver()
        {
            //Tomando una "captura" del form completo con sus controles existentes
            //bmp se convierte en una "copia" del form Game
            Bitmap bmp = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                G.CopyFromScreen(PointToScreen(new Point(0, 0)),
                    new Point(0, 0), ClientRectangle.Size);
                
                //Haciendo oscuro el fondo
                Color darken = Color.FromArgb(220, Color.Black);
                using (Brush brsh = new SolidBrush(darken))
                {
                    //Coloreando el fondo de la copia del Form
                    G.FillRectangle(brsh, ClientRectangle);
                }
            }

            //Poniendo la "captura oscura" del form por delante del form actual
            using (Panel p = new Panel())
            {
                p.Location = new Point(0, 0);
                p.Size = ClientRectangle.Size;
                p.BackgroundImage = bmp;
                Controls.Add(p);
                p.BringToFront();

                //Mostrando el Game Over
                FrmGameOver gameOver = new FrmGameOver();
                gameOver.StartPosition = FormStartPosition.CenterParent;
                
                //Se mostrará dde esta forma, ya que deja inabilitado el form del fondo, y a su vez esperará
                //una respuesta para volver a la normalidad (form no oscurecido)
                gameOver.ShowDialog();
            }
        }
        
        //Método que se usará con el delegate de Form para pausar el juego al minimizar la pantalla
        public void StopTimerPlayer()
        {
            if (GameData.startGame)
            {
                tmrGame.Stop();
                GameData.activeTimer = false;
            }
        }
    }
}
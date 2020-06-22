using System;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Controlador;
using Arkanoid.Modelo;

namespace Arkanoid
{
    public partial class FrmGameOver : Form
    {
        private int scoreTotal = 0;
        private int scoreBonus = 0;
        private int diffScore = 200;
        public FrmGameOver()
        {
            InitializeComponent();
            tmrPoints.Interval = 1;
        }
        
        private void GameOver_Load(object sender, EventArgs e)
        {
            #region Background
            //Cargando la imagen de fondo y acomodando su tamaño
            DoubleBuffered = true;
            BackgroundImage = Image.FromFile("../../Resources/FondoEstrellas.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            #endregion
            
            #region Lógica del puntaje a mostrar
            //verificando puntaje bonus
            if (GameData.winner)
            {
                System.Media.SoundPlayer winner = new System.Media.SoundPlayer
                    ("../../Resources/winner.wav");
                winner.Play();
                scoreBonus = GameData.BonusPoints();
            }
            else
            {
                System.Media.SoundPlayer loser = new System.Media.SoundPlayer
                    ("../../Resources/lose.wav");
                loser.Play();
                scoreBonus = 0;
            }

            scoreTotal = GameData.scoreBlocks;
            
            //Mostrando mensaje de "GANASTE" o "PERDISTE" según vidas
            switch (GameData.life)
                {
                    case 3: lblMessage.Text = "Muy bien!";
                        break;
                    case 2: lblMessage.Text = "Bien hecho!";
                        break;
                    case 1: lblMessage.Text = "Por Poco!";
                        break;
                    default: lblMessage.Text = "Perdiste!";
                        break;
                }
            
            
            //Mostrando el puntaje en la ventana
            lblScore.Text = "Score: " + GameData.scoreBlocks.ToString();
            lblBonus.Text = "Bonus: " + scoreBonus.ToString();
            lblTotal.Text = "Total: " + scoreTotal.ToString();
            
            //Activando el timer
            tmrPoints.Enabled = true;
            #endregion
            
            #region Opacidad de los labes 
            //Creando efecto de opacidad en algunos labels
            lblMessage.BackColor = Color.FromArgb(100, 5, 235, 179);
            lblGameOver.BackColor = Color.FromArgb(125, Color.Red);
            lblPlayAgain.BackColor = Color.FromArgb(125, 7, 0, 48);
            lblMenu.BackColor = Color.FromArgb(125, 7, 0, 48);
            lblExit.BackColor = Color.FromArgb(125, 7, 0, 48);
            #endregion
        }

        #region Eventos que permiten ser interactivos a los labels

        private void LblPlayAgain_MouseEnter(object sender, EventArgs e)
        {
            lblPlayAgain.BackColor = Color.FromArgb(125, 29, 5, 175);
        }

        private void LblPlayAgain_MouseLeave(object sender, EventArgs e)
        {
            lblPlayAgain.BackColor = Color.FromArgb(125, 7, 0, 48);
        }

        private void LblMenu_MouseEnter(object sender, EventArgs e)
        {
            lblMenu.BackColor = Color.FromArgb(125, 29, 5, 175);
        }

        private void LblMenu_MouseLeave(object sender, EventArgs e)
        {
            lblMenu.BackColor = Color.FromArgb(125, 7, 0, 48);
        }
        
        private void LblExit_MouseEnter(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.FromArgb(125, 29, 5, 175);
        }

        private void LblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.FromArgb(125, 7, 0, 48);
        }
        #endregion

        
        private void LblPlayAgain_Click(object sender, EventArgs e)
        {
            //Eliminando el user control gameUc para volver a implementarlo 
            PanelControlator.mainPnl.Controls.Remove(PanelControlator.currentUc);
            PanelControlator.currentUc = new Game();
            PanelControlator.currentUc.Size = PanelControlator.mainPnl.Size;
            
            GameReset();
            
            //Agregando el nuevo UserControl
            PanelControlator.mainPnl.Controls.Add(PanelControlator.currentUc);
            this.Hide();
        }

        private void LblMenu_Click(object sender, EventArgs e)
        {
            //Cambiando el user control dentro del Form 
            PanelControlator.mainPnl.Controls.Remove(PanelControlator.currentUc);
            PanelControlator.gameUc = new Game();
            PanelControlator.gameUc.Size = PanelControlator.mainPnl.Size;
            
            GameReset();

            //Agregando el nuevo UserControl
            PanelControlator.currentUc = PanelControlator.menuUc;
            PanelControlator.mainPnl.Controls.Add(PanelControlator.currentUc);
            PanelControlator.mainPnl.Parent.Text = "Arkanoid by Jajan'tGames";
            this.Hide();
        }
        
        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Método encargado de restablecer los valores necesarios para que Game funcione correctamente
        private void GameReset()
        {
            GameData.scoreBlocks = 0;
            GameData.startGame=false;
            GameData.life = 3;
            GameData.trapped = true;
            GameData.remainingBlocks = 24;
            GameData.winner = false;
            GameData.currentTime = 150;
            
        }
        
        //Método encargado de realizar la animacion de sumar puntos
        private void TmrPoints_Tick(object sender, EventArgs e)
        {
            //Realizando cuenta regresiva hasta cero
            if (scoreBonus != 0)
            {
                if (scoreBonus - diffScore < diffScore)
                {
                    diffScore = scoreBonus; //Evita restar mas
                }

                //Cambia el score
                scoreBonus -= diffScore;
                scoreTotal += diffScore;

                //Actualiza los labels
                lblBonus.Text = "Bonus: " + scoreBonus.ToString();
                lblTotal.Text = "Total: " + scoreTotal.ToString();
            }
            else
            {
                tmrPoints.Stop();
            }
        }
    }
}
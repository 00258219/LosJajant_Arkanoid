using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Arkanoid.Controlador;
using Arkanoid.Modelo;

namespace Arkanoid
{
    public partial class GameOver : Form
    {
        private int scoreTotal = 0;
        private int scoreBonus = 0;
        private int diffScore = 200;
        public GameOver()
        {
            InitializeComponent();
            timerPoints.Interval = 1;
        }

        //Método que se realiza cuando este formulario carga, agregando el BackGround y el color de fondo 
        //de los labels
        private void GameOver_Load(object sender, EventArgs e)
        {
            //Cargando la imagen de fondo y acomodando su tamaño
            DoubleBuffered = true;
            BackgroundImage = Image.FromFile("../../Resources/FondoEstrellas.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            
            //Calculando el puntaje total
            if (GameData.winner==true)
                scoreBonus = GameData.BonusPoints();
            else
                scoreBonus = 0;
            scoreTotal = GameData.scoreBlocks;// + scoreBonus;

            //Mostrando mensaje de "GANASTE" o "PERDISTE" según vidas
            if (GameData.winner) label1.Text = "Ganaste!";
            else if (GameData.life == 3) label1.Text = "Muy bien!";
            else if (GameData.life == 2) label1.Text = "Bien hecho!";
            else if (GameData.life == 1) label1.Text = "Por Poco!";
            else label1.Text = "Perdiste!";
            
            //Mostrando el puntaje en la ventana
            label3.Text = "Score: " + GameData.scoreBlocks.ToString();
            label7.Text = "Bonus: " + scoreBonus.ToString();
            label8.Text = "Total: " + scoreTotal.ToString();
            
            //Activando el timer
            timerPoints.Enabled = true;

            //Creando efecto de opacidad en algunos labels
            label1.BackColor = Color.FromArgb(100, 5, 235, 179);
            label2.BackColor = Color.FromArgb(125, Color.Red);
            label4.BackColor = Color.FromArgb(125, 7, 0, 48);
            label5.BackColor = Color.FromArgb(125, 7, 0, 48);
            label6.BackColor = Color.FromArgb(125, 7, 0, 48);
        }

        #region Métodos que simulan el Huver de los labels correspondientes, para simular un botón interactivo

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(125, 29, 5, 175);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(125, 7, 0, 48);
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.BackColor = Color.FromArgb(125, 29, 5, 175);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.FromArgb(125, 7, 0, 48);
        }
        
        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.BackColor = Color.FromArgb(125, 29, 5, 175);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.FromArgb(125, 7, 0, 48);
        }
        #endregion

        private void label4_Click(object sender, EventArgs e)
        {
            //Eliminando el user control game para volver a implementarlo 
            PanelControlator.panel1.Controls.Remove(PanelControlator.uc);
            PanelControlator.uc = new Game();
            
            //Restableciendo los valores que hacen funcionar correctamente a Game
            GameReset();
            
            //Agregando el nuevo UserControl
            PanelControlator.panel1.Controls.Add(PanelControlator.uc);
            this.Hide();
        }
        
        private void label5_Click(object sender, EventArgs e)
        {
            //Cambiando el user control dentro del Form 
            PanelControlator.panel1.Controls.Remove(PanelControlator.uc);
            PanelControlator.game=new Game();
            
            //Restableciendo los valores que hacen funcionar correctamente a Game
            GameReset();
            
            //Agregando el nuevo UserControl
            PanelControlator.uc = PanelControlator.menu;
            PanelControlator.panel1.Controls.Add(PanelControlator.uc);
            this.Hide();
        }
        
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Método encargado de restablecer el UserControl Game 
        private void GameReset()
        {
            //Restableciendo los valores necesarios para que Game funcione correctamente
            PanelControlator.uc.Size = PanelControlator.panel1.Size;
            GameData.scoreBlocks = 0;
            GameData.StartGame=false;
            GameData.life = 3;
            Game.trapped = true;
            GameData.remainingBlocks = 24;
            GameData.winner = false;
        }
        

        //Método encargado de realizar la animacion de sumar puntos
        private void timerPoints_Tick(object sender, EventArgs e)
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
                label7.Text = "Bonus: " + scoreBonus.ToString();
                label8.Text = "Total: " + scoreTotal.ToString();
            }
            else
            {
                timerPoints.Stop();
            }
        }
    }
}
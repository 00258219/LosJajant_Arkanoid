﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Controlador;
using Arkanoid.Modelo;
using Arkanoid.Properties;

namespace Arkanoid
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        //Método que se realiza cuando este formulario carga, agregando el BackGround y el color de fondo 
        //de los labels
        private void GameOver_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            BackgroundImage = Image.FromFile("../../Resources/FondoEstrellas.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            label3.Text = "Score: " + PanelControlator.score.ToString("D7");
            label1.BackColor = Color.FromArgb(125, 5, 235, 179);
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
            //Limpiando el user control game para volver a implementarlo 
            PanelControlator.panel1.Controls.Remove(PanelControlator.uc);
            PanelControlator.uc = new Game();
            //Restableciendo los valores que hacen funcionar correctamente a Game
            GameReset();
            PanelControlator.panel1.Controls.Add(PanelControlator.uc);
            this.Hide();
        }
        
        private void label5_Click(object sender, EventArgs e)
        {
            //Cambiando el user control dentro del Form 
            PanelControlator.panel1.Controls.Remove(PanelControlator.uc);
            PanelControlator.game=new Game();
            //Restableciendo los valores que hacen funcionar correctamente a Game
            GameMenuReset();
            PanelControlator.uc = PanelControlator.menu;
            PanelControlator.panel1.Controls.Add(PanelControlator.uc);
            this.Hide();
        }
        
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameReset()
        {
            PanelControlator.uc.Size = PanelControlator.panel1.Size;
            PanelControlator.score = 0;
            GameData.StartGame=false;
            Game.trapped = true;
        }
        
        private void GameMenuReset()
        {
            PanelControlator.game.Size = PanelControlator.panel1.Size;
            PanelControlator.score = 0;
            GameData.StartGame=false;
            Game.trapped = true;
        }
    }
}
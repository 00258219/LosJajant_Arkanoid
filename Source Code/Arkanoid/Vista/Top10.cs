﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Controlador;

namespace Arkanoid
{
    public partial class Top10 : UserControl
    {
        public Top10()
        {
            InitializeComponent();
        }
        
        private void Top10_Load(object sender, EventArgs e)
        {
            #region Cargado de diseño del UC
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            pbLogo.Image = Image.FromFile("../../Resources/logo.png");
            lblTop10.BackColor = Color.FromArgb(125, lblTop10.BackColor);
            lblPlayers.BackColor = Color.FromArgb(125, lblTop10.BackColor);
            lblScore.BackColor = Color.FromArgb(125, lblTop10.BackColor);
            #endregion
            BestPlayers(); //Imprime los diez puntajes mas altos
        }

        //Método que añade diez primeros jugadores con el puntaje mas alto
        private void BestPlayers()
        {
            //Inializando los textos
            lblPlayers.Text = "\n   Players\n";
            lblScore.Text = "\nScore\n";
            
            //Guardando los diez jugadores con su respectivo puntaje
            var PlayerList = ScoreDAO.GetNickNames();
            var ScoreList = ScoreDAO.GetScores();
            
            //Llenando los textos con los jugadores
            for (int i = 0; i < PlayerList.Count; i++)
            {
                //Utilizado para indentar de manera correcta los textos
                switch (i)
                {
                    case 0:
                        lblPlayers.Text += $"{i + 1}   " + PlayerList[i] + "\n";
                        break;
                    case 9:lblPlayers.Text += $"{i + 1} " + PlayerList[i] + "\n";
                            break;
                    default: lblPlayers.Text += $"{i + 1}  " + PlayerList[i] + "\n";
                        break;
                }
                lblScore.Text += ScoreList[i] + "\n";
            }
        }
    
        //Método para regresar al menuUc principal
        private void BtnBack_Click(object sender, EventArgs e)
        {
            BestPlayers();
            
            //Cambiando el componente que esta dentro del panel en el FrmMain 
            PanelControlator.mainPnl.Controls.Remove(PanelControlator.currentUc);
            PanelControlator.currentUc = PanelControlator.menuUc;
            PanelControlator.mainPnl.Controls.Add(PanelControlator.currentUc);
            //seteando sonido de boton 
            System.Media.SoundPlayer button = new System.Media.SoundPlayer
            ("../../Resources/button.wav");
            button.Play();
        }
    }
}
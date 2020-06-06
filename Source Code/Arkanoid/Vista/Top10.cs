using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Controlador;
using Arkanoid.Modelo;

namespace Arkanoid
{
    public partial class Top10 : UserControl
    {
        public Top10()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Dock = DockStyle.Fill;
        }


        private void Top10_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            labTop10.BackColor = Color.FromArgb(125, labTop10.BackColor);
            labPlayers.BackColor = Color.FromArgb(125, labTop10.BackColor);
            labScore.BackColor = Color.FromArgb(125, labTop10.BackColor);
            BestPlayer(); //Imprime los diez puntajes mas altos
        }

        //Metodo que añade diez primeros jugadores con el puntaje mas alto
        private void BestPlayer()
        {
            //Inializando los textos
            labPlayers.Text = "\n   Players\n";
            labScore.Text = "\nScore\n";
            
            // Guardando los diez jugadores con su respectivo puntaje
            var PlayerList = ScoreDAO.getNickName();
            var ScoreList = ScoreDAO.getScore();
            
            //Llenando los textos con los jugadores
            for (int i = 0; i < PlayerList.Count; i++)
            {
                //Utilizado para indentar de manera correcta los textos
                switch (i)
                {
                    case 0:
                        labPlayers.Text += $"{i + 1}   " + PlayerList[i] + "\n";
                        break;
                    case 9:labPlayers.Text += $"{i + 1} " + PlayerList[i] + "\n";
                            break;
                    default: labPlayers.Text += $"{i + 1}  " + PlayerList[i] + "\n";
                        break;
                }
                labScore.Text += ScoreList[i] + "\n";
            }
        }
    
        //Metodo para regresar al menu principal
        private void btnback_Click(object sender, EventArgs e)
        {
            //cambiando el componente que esta dentro del panel en el Form1 
            PanelControlator.panel1.Controls.Remove(PanelControlator.uc);
            PanelControlator.uc = PanelControlator.menu;
            PanelControlator.panel1.Controls.Add(PanelControlator.uc);
        }
    }
}
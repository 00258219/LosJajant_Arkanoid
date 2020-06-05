/*
 * User control para el inicio del juego
 * version: 1.0.1
 * Responsable: Cortez Amaya Henry Alexander (00095119)
*/


using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Controlador;

namespace Arkanoid
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
            Dock = DockStyle.Fill; 
        }

        /*
         * Evento MouseHover: Crear el efecto de entrada en un boton
         * Evento MouseLeave: Quita el efecto al estar afuera de un boton
        */
        private void labelPlay_MouseHover(object sender, EventArgs e)
        {
        
            labelPlay.BackColor =  Color.FromArgb(100,Color.Black);
        }

        private void labelPlay_MouseLeave(object sender, EventArgs e)
        {
        
            labelPlay.BackColor=Color.Transparent;
        }

        private void labelTop_MouseHover(object sender, EventArgs e)
        {
            labelTop.BackColor = Color.FromArgb(100,Color.Black);
        }

        private void labelTop_MouseLeave(object sender, EventArgs e)
        {
            labelTop.BackColor=Color.Transparent;
        }

        private void labelExit_MouseHover(object sender, EventArgs e)
        {
            labelExit.BackColor = Color.FromArgb(100,Color.Black);
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.BackColor=Color.Transparent;
        }
        //funcionamiento del click en 'Play'
        private void labelPlay_Click(object sender, EventArgs e)
        {
            //cambiando el componente que esta dentro del panel en el Form1 
            PanelControlator.panel1.Controls.Remove(PanelControlator.uc);
            PanelControlator.uc = PanelControlator.playeregister;
            PanelControlator.panel1.Controls.Add(PanelControlator.uc);
        }

        //funcionamiento del click en 'Top10'
        private void labelTop_Click(object sender, EventArgs e)
        { 
            //cambiando el componente que esta dentro del panel en el Form1 
            PanelControlator.panel1.Controls.Remove(PanelControlator.uc);
            PanelControlator.uc = PanelControlator.top10;
            PanelControlator.panel1.Controls.Add(PanelControlator.uc);
        }
        //funcionamiento del click en 'Exit'
        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
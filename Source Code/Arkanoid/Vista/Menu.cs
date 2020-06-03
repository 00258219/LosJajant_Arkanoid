/*
 * User control para el inicio del juego
 * version: 1.0.0
 * Responsable: Cortez Amaya Henry Alexander (00095119)
*/


using System;
using System.Drawing;
using System.Windows.Forms;

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

    }
}
using System;
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
        
        private void Menu_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            pbLogo.Image = Image.FromFile("../../Resources/logo.png");
        }

        /*
         * Evento MouseHover: Crear el efecto de entrada en un boton
         * Evento MouseLeave: Quita el efecto al estar afuera de un boton
        */
        private void LblPlay_MouseHover(object sender, EventArgs e)
        {
        
            lblPlay.BackColor =  Color.FromArgb(100,Color.Black);
        }

        private void LblPlay_MouseLeave(object sender, EventArgs e)
        {
        
            lblPlay.BackColor=Color.Transparent;
        }

        private void LblTop_MouseHover(object sender, EventArgs e)
        {
            lblTop.BackColor = Color.FromArgb(100,Color.Black);
        }

        private void LblTop_MouseLeave(object sender, EventArgs e)
        {
            lblTop.BackColor=Color.Transparent;
        }

        private void LblExit_MouseHover(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.FromArgb(100,Color.Black);
        }

        private void LblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.BackColor=Color.Transparent;
        }
        //funcionamiento del click en 'Play'
        private void LblPlay_Click(object sender, EventArgs e)
        {
            //cambiando el componente que esta dentro del panel en el Form1 
            PanelControlator.mainPnl.Controls.Remove(PanelControlator.currentUc);
            PanelControlator.currentUc = PanelControlator.playerRegisterUc;
            PanelControlator.mainPnl.Controls.Add(PanelControlator.currentUc);
        }

        //funcionamiento del click en 'Top10'
        private void LblTop_Click(object sender, EventArgs e)
        { 
            //cambiando el componente que esta dentro del panel en el Form1 
            PanelControlator.mainPnl.Controls.Remove(PanelControlator.currentUc);
            PanelControlator.currentUc = PanelControlator.top10Uc;
            PanelControlator.mainPnl.Controls.Add(PanelControlator.currentUc);
        }
        
        //funcionamiento del click en 'Exit'
        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
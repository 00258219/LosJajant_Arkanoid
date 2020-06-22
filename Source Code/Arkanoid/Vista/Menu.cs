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
        
        #region Eventos que permiten ser interactivos a los labels 
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
        #endregion
        
        //Permite acceder al registro del usuario
        private void LblPlay_Click(object sender, EventArgs e)
        {
            //cambiando el componente que esta dentro del panel en el FrmMain 
            PanelControlator.mainPnl.Controls.Remove(PanelControlator.currentUc);
            PanelControlator.currentUc = PanelControlator.playerRegisterUc;
            PanelControlator.mainPnl.Controls.Add(PanelControlator.currentUc);
        }
        
        //Permite acceder al top 10 de jugadores
        private void LblTop_Click(object sender, EventArgs e)
        { 
            //cambiando el componente que esta dentro del panel en el FrmMain 
            PanelControlator.mainPnl.Controls.Remove(PanelControlator.currentUc);
            PanelControlator.currentUc = new Top10();
            PanelControlator.mainPnl.Controls.Add(PanelControlator.currentUc);
        }
        
        //Cierra el programa
        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Controlador;
using Arkanoid.Modelo;

namespace Arkanoid
{
    public partial class PlayerRegister : UserControl
    {
        public PlayerRegister()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Dock = DockStyle.Fill;
            txtNickname.box.MaxLength = 10;
            txtNickname.box.TextAlign = HorizontalAlignment.Center;
        }
        
        private void PlayerRegister_Load(object sender, EventArgs e)
        {
            ActiveControl = txtNickname.box;
        }
        
        //Con las siguientes 2 funciones emulamos un hover para el label que esta representando a un boton
        private void lblButton_MouseEnter(object sender, EventArgs e)
        {
            lblButton.BackColor = Color.FromArgb(125, 7, 0, 48);
        }

        private void lblButton_MouseLeave(object sender, EventArgs e)
        {
            lblButton.BackColor = Color.Transparent;
        }

        //Con este evento Click guarademos el nombre del jugador en una clase estatica
        //para luego mandarlo a la base de datos y tambien cambiaremos al panel Game
        private void lblButton_Click(object sender, EventArgs e)
        {
            if (!txtNickname.Text.Equals(""))
            {
                string actualPlayer = txtNickname.Text.ToLower();
                GameData.player = actualPlayer;
                Parent.Parent.Text += "            PLAYER: "+actualPlayer;
                PanelControlator.panel1.Controls.Remove(PanelControlator.uc);
                PanelControlator.uc = PanelControlator.game;
                PanelControlator.panel1.Controls.Add(PanelControlator.uc);
            }else
                MessageBox.Show("Tienes que escribir tu nickname para jugar");
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Limpiando el texto si se habia escrito algo
            txtNickname.Text = "";
            
            //cambiando el componente que esta dentro del panel en el Form1 
            PanelControlator.panel1.Controls.Remove(PanelControlator.uc);
            PanelControlator.uc = PanelControlator.menu;
            PanelControlator.panel1.Controls.Add(PanelControlator.uc);
        }
    }
}
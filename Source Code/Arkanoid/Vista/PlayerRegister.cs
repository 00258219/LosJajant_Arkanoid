using System;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Controlador;
using Arkanoid.Modelo;

namespace Arkanoid
{
    public partial class PlayerRegister : UserControl
    {
        private delegate void MyDelegatePlayerRegiser(object sender, EventArgs e);
        private static MyDelegatePlayerRegiser clickSimulator;
        public PlayerRegister()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            txtNickname.box.MaxLength = 10;
            txtNickname.box.TextAlign = HorizontalAlignment.Center;
        }
        
        private void PlayerRegister_Load(object sender, EventArgs e)
        {
            ActiveControl = txtNickname.box;
        }
        
        //Con las siguientes 2 funciones emulamos un hover para el label que esta representando a un boton
        private void LblButton_MouseEnter(object sender, EventArgs e)
        {
            lblButton.BackColor = Color.FromArgb(125, 7, 0, 48);
        }

        private void LblButton_MouseLeave(object sender, EventArgs e)
        {
            lblButton.BackColor = Color.Transparent;
        }

        //Con este evento Click guarademos el nombre del jugador en una clase estatica
        //para luego mandarlo a la base de datos y tambien cambiaremos al panel Game
        private void LblButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Quitando posibles espacios en blanco del textbox (al inicio y al final)
                txtNickname.Text = txtNickname.Text.Trim();
                
                if (txtNickname.Text.Equals(""))
                throw new EmptyNickNameException("Ingresa tu nickname antes de jugar!");
                
                else
                {
                    string actualPlayer = txtNickname.Text.ToLower();
                    GameData.player = actualPlayer;
                    Parent.Parent.Text += "            PLAYER: "+actualPlayer;
                    PanelControlator.mainPnl.Controls.Remove(PanelControlator.currentUc);
                    PanelControlator.currentUc = PanelControlator.gameUc;
                    PanelControlator.mainPnl.Controls.Add(PanelControlator.currentUc);   
                    
                    //Limpiando el txtNickname
                    txtNickname.Text = "";
                }
            }
            catch (EmptyNickNameException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //Limpiando el texto si se habia escrito algo
            txtNickname.Text = "";
            
            //cambiando el componente que esta dentro del panel en el Form1 
            PanelControlator.mainPnl.Controls.Remove(PanelControlator.currentUc);
            PanelControlator.currentUc = PanelControlator.menuUc;
            PanelControlator.mainPnl.Controls.Add(PanelControlator.currentUc);
        }
    }
}
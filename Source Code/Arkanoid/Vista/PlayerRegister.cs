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
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            txtNickname.box.MaxLength = 10;
            txtNickname.box.TextAlign = HorizontalAlignment.Center;
        }
        
        private void PlayerRegister_Load(object sender, EventArgs e)
        {
            ActiveControl = txtNickname.box;
        }
        
        #region Eventos que permite ser interactivo al label
        private void LblStart_MouseEnter(object sender, EventArgs e)
        {
            lblStart.BackColor = Color.FromArgb(125, 7, 0, 48);
        }

        private void LblStart_MouseLeave(object sender, EventArgs e)
        {
            lblStart.BackColor = Color.Transparent;
        }
        #endregion

        //Evento encargado de asignar el nombre del jugador 
        private void LblStart_Click(object sender, EventArgs e)
        {
            try
            {
                //Quitando posibles espacios en blanco del textbox (al inicio y al final)
                txtNickname.Text = txtNickname.Text.Trim();
                
                if (txtNickname.Text.Equals(""))
                 throw new EmptyNickNameException("Ingresa tu nickname antes de jugar!");
                
                //Se convierte el texto a minúsculas y se otorga a player
                string actualPlayer = txtNickname.Text.ToLower();
                GameData.player = actualPlayer;
                
                //Se coloca el nombre del jugador en la parte superior de la pantalla
                Parent.Parent.Text += "            PLAYER: "+actualPlayer;

                //Cambiando el componente actual que se encuentra dentro del panel
                PanelControlator.mainPnl.Controls.Remove(PanelControlator.currentUc);
                PanelControlator.currentUc = PanelControlator.gameUc;
                PanelControlator.mainPnl.Controls.Add(PanelControlator.currentUc); 
                
                //Limpiando el txtNickname
                txtNickname.Text = "";
                
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
            
            //cambiando el componente que esta dentro del panel en el FrmMain 
            PanelControlator.mainPnl.Controls.Remove(PanelControlator.currentUc);
            PanelControlator.currentUc = PanelControlator.menuUc;
            PanelControlator.mainPnl.Controls.Add(PanelControlator.currentUc);
        }
    }
}
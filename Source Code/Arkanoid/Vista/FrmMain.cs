using System;
using System.Drawing;
using System.Windows.Forms;
using static Arkanoid.Controlador.PanelControlator;

namespace Arkanoid
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            BackgroundImage = Image.FromFile("../../Resources/background.png");

            //Cambiando el size de cada userControl
            menuUc.Size = pnlBase.Size;
            top10Uc.Size = pnlBase.Size;
            playerRegisterUc.Size = pnlBase.Size;
            gameUc.Size = pnlBase.Size;

            //Agregando componente al panel mediante la clase controladora
            mainPnl = pnlBase;
            mainPnl.Controls.Add(menuUc);
            currentUc = menuUc;
        }

        //Método que encargado de verificar los cambios de tamaño que la ventana sufre
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            //Si la ventana no está maximizada, se maximizará
            if (WindowState==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }

            //Si la ventana se minimiza, el juego se pausa hasta que vuelva a entrar
            if (WindowState == FormWindowState.Minimized)
            {
                gameUc.StopTimerPlayer();
            }
        }
        
        //Método encargado de gestionar los mensajes que recibe la ventana que evita que al darle click a la parte
        //superior de la ventana esta se minimice, de igual manera evita que la ventana maximizada pueda moverse
        protected override void WndProc(ref Message m)
        {
            const int wmSyscommand = 0x0112; //Comando que representa a la ventana en general
            const int scMove = 0xF010; //Comando que indica que la ventana se mueve
            const int wmNclbuttondblclk = 0x00A3; //Comando que indica el click en la ventana (parte superior)
            
            switch(m.Msg)
            {
                case wmSyscommand:
                    //Recibiendo el mensaje que el usuario realiza en la ventana
                    int command = m.WParam.ToInt32() & 0xfff0;
                    //Verifica que el mensaje sea mover la ventana, si es así evita que suceda con el return
                    if (command == scMove)
                        return;
                    
                    //Se muestra la ventana referente al mensaje percatado
                    base.WndProc(ref m);
                    break;
            }
            
            //Si el mensaje recibido desde la ventana es doble click sobre la parte superior, lo retorna como nulo
            //el mensaje
            if (m.Msg == wmNclbuttondblclk)
            {
                //Retornando IntPtr.Zero como null
                m.Result = IntPtr.Zero;
                return;
            }
            //Se muestra la ventana referente al mensaje percatado
            base.WndProc(ref m);
        }
        
        //Método que permite activar el "doble buffer" para el cargado optimizado de los controles de los 
        //userControls por utilizar
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Activando el WS_EX_COMPOSITED (doble buffer)
                return cp;
            }
        }
    }
}
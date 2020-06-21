using System;
using System.Drawing;
using System.Windows.Forms;
using static Arkanoid.Controlador.PanelControlator;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        private delegate void DelegateForm();
        static DelegateForm myDelegate;
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        
        private void Form1_Load(object sender, EventArgs e)
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
        
        //Cuando se deja maximimazada la ventana aun ocurren dos cosas que queremos evitar y es el movimiento de la
        //ventana y el minimizado por doble clic en la barra superior, entonces recibimos esas acciones y evitamos
        //que hagan cambios, osea las suprimimos.
        protected override void WndProc(ref Message m)
        {  
            const int SC_MINIMIZE = 0xF020;
            const int wmSyscommand = 0x0112;
            const int scMove = 0xF010;
            const int wmNclbuttondblclk = 0x00A3;
            switch(m.Msg)
            {
                case wmSyscommand:
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == scMove)
                        return;
                    
                    /*//Minimizar perzonalizado
                    if (m.WParam == (IntPtr)SC_MINIMIZE)
                        MessageBox.Show("Hacer lo que quieras en vez de minimizar");*/

                    base.WndProc(ref m);
                    break;
            }


            if (m.Msg == wmNclbuttondblclk)
            {
                m.Result = IntPtr.Zero;
                
                return;
            }

            base.WndProc(ref m);
        }
        
        //La funcion que paso Walter
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        //Permite que la ventana luego de estar minimizada, al abrirla se maximice siempre
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }

            if (WindowState == FormWindowState.Minimized)
            {
                myDelegate += gameUc.StopTimerPlayer;
                myDelegate.Invoke();
            }
        }
        
    }
}
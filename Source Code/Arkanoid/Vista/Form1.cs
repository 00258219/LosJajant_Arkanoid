using System;
using System.Windows.Forms;
using Arkanoid.Controlador;
using Arkanoid.Modelo;
using Arkanoid.Properties;
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
            BackgroundImage = Resources.background;
            //Cambiando el size de cada userControl
            game.Size = panel1.Size;
            menu.Size = panel1.Size;
            top10.Size = panel1.Size;
            playeregister.Size = panel1.Size;
            //Agregando componente al panel mediante la clase controladora
            PanelControlator.panel1 = panel1;
            PanelControlator.panel1.Controls.Add(menu);
            uc = menu;
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
            if (this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            if (this.WindowState == FormWindowState.Minimized)
            {
                myDelegate += game.StopTimerPlayer;
                myDelegate.Invoke();
            }
        }

        //Resetea el nombre del jugador en la parte superior de la ventana
        public void ParentTextReset()
        {
            Parent.Parent.Text += "";
        }
    }
}
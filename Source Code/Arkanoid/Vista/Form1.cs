using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arkanoid.Controlador;
using Arkanoid.Properties;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
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
            PanelControlator.game.Size = panel1.Size;
            PanelControlator.menu.Size = panel1.Size;
            PanelControlator.top10.Size = panel1.Size;
            PanelControlator.playeregister.Size = panel1.Size;
            //Agregando componente al panel mediante la clase controladora
            PanelControlator.panel1 = panel1;
            PanelControlator.panel1.Controls.Add(PanelControlator.menu);
            PanelControlator.uc = PanelControlator.menu;
        }
        
        //Cuando se deja maximimazada la ventana aun ocurren dos cosas que queremos evitar y es el movimiento de la
        //ventana y el minimizado por doble clic en la barra superior, entonces recibimos esas acciones y evitamos
        //que hagan cambios, osea las suprimimos.
        protected override void WndProc(ref Message m)
        {
            const int wmSyscommand = 0x0112;
            const int scMove = 0xF010;
            const int wmNclbuttondblclk = 0x00A3;

            switch(m.Msg)
            {
                case wmSyscommand:
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == scMove)
                        return;
                    break;
            }
            
            if (m.Msg == wmNclbuttondblclk)
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
        }
    }
}
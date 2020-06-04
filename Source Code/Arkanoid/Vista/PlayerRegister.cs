using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class PlayerRegister : UserControl
    {
        public PlayerRegister()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Dock = DockStyle.Fill;
            
        }
        
        private void lblButton_MouseEnter(object sender, EventArgs e)
        {
            lblButton.BackColor = Color.FromArgb(125, 7, 0, 48);
        }

        private void lblButton_MouseLeave(object sender, EventArgs e)
        {
            lblButton.BackColor = Color.Transparent;
        }
    }
}
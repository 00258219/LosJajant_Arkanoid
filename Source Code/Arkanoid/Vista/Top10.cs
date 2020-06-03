using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Top10 : UserControl
    {
        public Top10()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Dock = DockStyle.Fill;
        }


        private void Top10_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            labTop10.BackColor = Color.FromArgb(125, labTop10.BackColor);
            labPlayers.BackColor = Color.FromArgb(125, labTop10.BackColor);
            labScore.BackColor = Color.FromArgb(125, labTop10.BackColor);

        }
    }
}
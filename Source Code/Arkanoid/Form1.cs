using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        private int increment;
        
        public Form1()
        {
            InitializeComponent();
            increment = 10;
            WindowState = FormWindowState.Maximized;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    pictureBox1.Left -= increment;
                    break;
                case Keys.Right:
                    pictureBox1.Left += increment;
                    break;
            }
        }
    }
}
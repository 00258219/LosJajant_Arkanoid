using System;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Properties;

namespace Arkanoid
{
    public sealed partial class Game : UserControl
    {
        public Game()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            tableLayoutPanel2.BackColor = Color.FromArgb(70, tableLayoutPanel2.BackColor);
        }
        private void Game_Load(object sender, EventArgs e)
        {
            BackgroundImage = Resources.gameBackground;
            pictureBox1.Image = Resources.heartf;
            pictureBox2.Image = Resources.heartf;
            pictureBox3.Image = Resources.heartn;
            pictureBox4.Image = Resources.plataform;
            
            pictureBox5.Image = Resources.ball;


            fillRowTest(Resources.block5t, 0);
            fillRowTest(Resources.block3t, 1);
            fillRowTest(Resources.block2t, 2);
            fillRowTest(Resources.block1t, 3);


        }
        private void fillRowTest(Image im, int rowN)
        {
            for (int i = 0; i < 6; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Dock = DockStyle.Fill;
                pb.Margin = new Padding(6, 0, 6, 8);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;

                pb.Image = im;
                
                tableLayoutPanel4.Controls.Add(pb, i+1, rowN);
            }



        }
        
    }
}
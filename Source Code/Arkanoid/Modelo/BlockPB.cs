using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid.Modelo
{
    public class BlockPB : PictureBox
    {
        public int hits { get; set; }
        private int points;
        private string imageName;
        
        public BlockPB(int hits, Size size) : base()
        {
            //Inicializar con los valores predeterminados y los de parametro
            this.hits = hits;
            points = hits * 1000;
            BackColor = Color.Transparent;
            SizeMode = PictureBoxSizeMode.StretchImage;
            imageName = "../../Resources/block"+hits+"hit";
            Image = Image.FromFile(imageName+hits+".png");
            Size = size;
        }
        
        //Método que debe ocurrir cuando la pelota y el bloque colisionan para restar hits y camibar el scoreZ
        public void Beaten(Label scoreGame)
        {
            if (hits > 0)
                hits--; //resta un hit si aun tiene
            
            // Cambiando al estado para que no se pueda rebotar mas en este bloque
            if (hits == 0)
            {
                GameData.remainingBlocks--;
                GameData.scoreBlocks += points;
                scoreGame.Text = "SCORE : " + GameData.scoreBlocks.ToString("D7");
                points = 0;
                Visible = false;
                Enabled = false;
            }
            else
            {
                //cambiando la imagen, si ha recibido un hit y si aun no tiene 0 hits
                Image = Image.FromFile(imageName + hits + ".png");
            }
        }
    }
}
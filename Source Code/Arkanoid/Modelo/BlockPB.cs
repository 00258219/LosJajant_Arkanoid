using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arkanoid.Controlador;

namespace Arkanoid.Modelo
{
    public class BlockPB : PictureBox
    {
        public int Hits { get; set; }
        private int Points;
        
        public BlockPB(Image im, int hits) : base()
        {
            //inicializar con los valores predeterminados y los de parametro
            BackColor = Color.Azure;
            Image = im;
            Hits = hits;
            Points = hits * 1000;
            Dock = DockStyle.Fill;
           // Margin = new Padding(6, 0, 6, 8);
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Hace un efecto de parpadeo para poder denotar un golpe
        private async void blinkBlock()
        {
            Image aux = Image;
            Image = null;
            await Task.Delay(300);
            Image = aux;
        }
        
        //Funcion que debe ocurrir cuando la pelota y el bloque colisionan.
        //Necesita un label, este label es el que contiene el score, se necesita para cambiar su valor instantaneamente
        //cuando el bloque es destruido.
        public void Beaten(Label scoreGame)
        {
            if (Hits > 0){
                //blinkBlock(); 
                Hits--;
            }
            // No estoy seguro si esto serviria como para que no vuelva a rebotar en este block (probar que funcione!)
            if (Hits == 0)
            {
                GameData.remainingBlocks--;
                GameData.scoreBlocks += Points;
                scoreGame.Text = GameData.scoreBlocks.ToString("D7");
                Points = 0;
                Visible = false;
                Enabled = false;
            }
        }
        //Se encarga de cambiar la imagen de los bloques al colisionar
        public void CollisionImage(int xPosition)
        {
            int im = Hits - 1; //Detecta cuantos hit quedan
            
            //xPosition guarda la ubicacion del bloque actual
            switch (xPosition)
            {
                  
                case 148: //Bloques grises
                    if(im>=2)
                        Image=Image.FromFile("../../Resources/BloqueGris"+im+".png");
                    break;
               
                case 198: //Bloques azules
                    if(im>=1)
                        Image=Image.FromFile("../../Resources/BloqueAzul"+im+".png");
                    break;
               
                case 248: //Bloques rosados
                    if(im>=1)
                        Image=Image.FromFile("../../Resources/BloqueRosa"+im+".png"); 
                    break; 
            }
        }
        
    }
}
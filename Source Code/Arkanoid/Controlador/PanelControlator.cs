using System.Windows.Forms;

namespace Arkanoid.Controlador
{
    //Clase para el funcionanmiento de cambios de panel del programa.
    //Esta clase guarda los componentes necesarios para que se cargue el UserControl en el panel del form1 y para que 
    //funcionen los eventos clicks de cada boton de los UserControls donde cambiara de panel.
    public static class PanelControlator
    {
        public static Menu menu = new Menu();
        public static Top10 top10 = new Top10();
        public static PlayerRegister playeregister = new PlayerRegister();
        public static Game game = new Game();

        public static UserControl uc = new UserControl();
        public static Panel panel1=new Panel();
        
        //Tambien guardaremos el usuario que este actualmente jugando.
        public static string player = "";
    }
}
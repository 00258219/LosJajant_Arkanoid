using System.Windows.Forms;

namespace Arkanoid.Controlador
{
    //Clase para el funcionanmiento de cambios de panel del programa.
    //Esta clase guarda los componentes necesarios para que se cargue el UserControl en el panel del form1 y para que 
    //funcionen los eventos clicks de cada boton de los UserControls donde cambiara de panel.
    public static class PanelControlator
    {
        public static Panel mainPnl = new Panel();
        public static UserControl currentUc = new UserControl();

        public static Menu menuUc = new Menu();
        public static Top10 top10Uc = new Top10();
        public static PlayerRegister playerRegisterUc = new PlayerRegister();
        public static Game gameUc = new Game();
    }
}
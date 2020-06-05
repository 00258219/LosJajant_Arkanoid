using System.Windows.Forms;

namespace Arkanoid.Controlador
{
    //Clase para el funcionanmiento del UserControl menu:
    //Esta clase guarda los componentes necesarios para que se cargue el menu en el panel del form1 y para que 
    //funcionen los eventos clicks de los labels del usercontrol 'menu'
    public static class PanelControlator
    {
        public static Top10 top10=new Top10();
        public static Menu menu=new Menu();
        public static PlayerRegister playeregister=new PlayerRegister();
        public static UserControl uc=new UserControl();
        public static Panel panel1=new Panel();
    }
}
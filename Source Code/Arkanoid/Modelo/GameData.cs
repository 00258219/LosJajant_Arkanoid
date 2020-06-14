namespace Arkanoid.Modelo
{
    public static class GameData
    {
        // Boleano que verifica la ejecucion del juego
        public static bool StartGame = false;
        
        //Velocidades con las cuales se movera la pelota
        public static int xSpeed =14, ySpeed =-xSpeed-1;
    }
}
using Arkanoid.Controlador;

namespace Arkanoid.Modelo
{
    public static class GameData
    {
        // Boleano que verifica la ejecucion del juego
        public static bool StartGame = false;
        //Velocidades con las cuales se movera la pelota
        public static int xSpeed =15, ySpeed =-(xSpeed-1); //version 1.0
        
        //public static int xSpeed =4, ySpeed =-(xSpeed-1); version 2.0
        
        //Tambien guardaremos el usuario que este actualmente jugando,
        public static string player = "";
        //el puntuaje del usuario que esta jugando,
        public static int scoreBlocks = 0;
        //el numero de vidas restantes del jugador
        public static int life = 3;
        //y el tiempo que tarda en jugar
        public static int timePlayer = 0;
        //variable para saber si gano o no
        public static bool winner = false;
        //guarda los bloques restantes
        public static int remainingBlocks = 24;

        //funcion para calcular los puntos extras
        public static int BonusPoints()
        {
            int bonusPoints = 0, bonustime = 0;
            bonustime = (150-timePlayer)*200;
            bonusPoints = bonustime * life;
            return bonusPoints;
        }
        
        //funcion para registrar el puntaje en la base de datos
        public static void AddScoreDB()
        {
            foreach(Player user in PlayerDAO.getPlayer())
            {
                if (user.nickname.Equals(player))
                {
                    ScoreDAO.AddScore(scoreBlocks+BonusPoints(), player);
                    return;
                }
            }
            PlayerDAO.insertPlayer(player);
            ScoreDAO.AddScore(scoreBlocks+BonusPoints(), player);
        }
    }
}
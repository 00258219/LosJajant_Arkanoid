using Arkanoid.Controlador;

namespace Arkanoid.Modelo
{
    public static class GameData
    {
        //Manejo del nombre del jugador
        public static string player = "";

        //Inizializando variables del juego
        public static int scoreBlocks = 0;
        public static int life = 3;
        public static int remainingBlocks = 24;
        public static double currentTime = 150.00; //2 mins y 30 seg
        public static bool trapped = true; //si la pelota se mueve junto a la plataforma
        public static bool StartGame = false;
        public static bool activeTimer = false;
        public static int timePlayed = 0;
        public static bool winner = false;
        
        //Velocidades con las cuales se movera la pelota
        public static int xSpeed =15, ySpeed =-(xSpeed-1);

        //funcion para calcular los puntos extras
        public static int BonusPoints()
        {
            int bonusPoints = 0, bonustime = 0;
            bonustime = (150 - timePlayed) * 200;
            bonusPoints = bonustime * life;
            return bonusPoints;
        }
        
        //funcion para registrar el puntaje en la base de datos
        public static void AddScoreDB()
        {
            foreach(Player user in PlayerDAO.GetPlayer())
            {
                if (user.nickname.Equals(player))
                {
                    ScoreDAO.AddScore(scoreBlocks+BonusPoints(), player);
                    return;
                }
            }
            PlayerDAO.InsertPlayer(player);
            ScoreDAO.AddScore(scoreBlocks+BonusPoints(), player);
        }
        
    }
}
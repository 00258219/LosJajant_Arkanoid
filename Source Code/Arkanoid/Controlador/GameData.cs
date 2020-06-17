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
        public static int score = 0;
        //el numero de vidas restantes del jugador
        public static int life = 3;
        //y el tiempo que tarda en jugar
        public static int timePlayer = 0;

        //funcion para calcular los puntos extras
        public static int BonusPoints(int time)
        {
            int bonusPoints = 0, timeLeft = 0, bonusPerLife=0;
            timeLeft = (time)/60;
            bonusPerLife = life * 10;
            bonusPoints = timeLeft * bonusPerLife;
            
            return bonusPoints;
        }
        
        //funcion para registrar el puntaje en la base de datos
        public static void AddScoreDB()
        {
            int newplayer = 0;
            
            foreach(Player user in PlayerDAO.getPlayer())
            {
                if (user.nickname.Equals(player))
                {
                    ScoreDAO.AddScore(score, player);
                    newplayer++;
                }
            }

            if (newplayer == 0)
            {
                PlayerDAO.insertPlayer(player);
                ScoreDAO.AddScore(score, player);
            }
        }
        
    }
}
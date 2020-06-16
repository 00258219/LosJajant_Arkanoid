using System.Windows.Forms;
using Arkanoid.Controlador;

namespace Arkanoid.Modelo
{
    public static class GameData
    {
        // Boleano que verifica la ejecucion del juego
        public static bool StartGame = false;
        
        //Velocidades con las cuales se movera la pelota
        public static int xSpeed =14, ySpeed =-xSpeed-1;
                
        //Tambien guardaremos el usuario que este actualmente jugando.
        public static string player = "";
        //y el puntuaje del usuario que esta jugando.
        public static int score = 0;
        //numero de vidas restantes del jugador
        public static int life = 3;

        //funcion para calcular los puntos extras
        public static int BonusPoints(int time)
        {
            int bonusPoints = 0, timeLeft = 0, bonusperLife=0;
            timeLeft = (time)/60;
            bonusperLife = life * 10;
            bonusPoints = timeLeft * bonusperLife;
            
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
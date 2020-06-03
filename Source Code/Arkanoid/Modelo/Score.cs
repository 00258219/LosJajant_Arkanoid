namespace Arkanoid.Modelo
{
    public class Score
    {
        public int idScore { get; set; }
        public int score { get; set; }
        public string nickname { get; set; }

        public Score()
        {
            idScore = 1;
            score = 0;
            nickname = "";
        }
    }
}
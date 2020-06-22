using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Arkanoid.Controlador
{
    public static class ScoreDAO
    {

        //Método encargado de guardar en una lista el nickname de los mejores 10 puntajes
        //ordenados de mayor a menor
        public static List<string> GetNickNames()
        {
            List<string> listScore = new List<string>();
            DataTable dt = null;

            try
            {
                dt = ConnectionDB.ExecuteQuery("SELECT nickname FROM SCORE ORDER BY score DESC, score LIMIT 10");
            }
            catch (GetDataException ex)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }

            foreach (DataRow row in dt.Rows)
            {
                listScore.Add(row[0].ToString());
            }
            return listScore;
        }
        
        //Método encargado de guardar en una lista el score de los mejores 10 puntajes
        //ordenados de mayor a menor
        public static List<string> GetScores()
        {
            List<string> listScore = new List<string>();
            DataTable dt = null;
            try
            {
                dt = ConnectionDB.ExecuteQuery("SELECT score FROM SCORE ORDER BY score DESC, score LIMIT 10");
            }
            catch (GetDataException ex)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }

            foreach (DataRow row in dt.Rows)
            {
                listScore.Add(row[0].ToString());
            }

            return listScore;
        }
        
        //Método que añade los score a la base de datos
        public static void AddScore(int score, string nickname)
        {
            try
            {
                string query = $"INSERT INTO SCORE(score, nickname) VALUES ({score},'{nickname}');";
                ConnectionDB.ExecuteNonQuery(query);
            }
            catch (AddScoreException e)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
        }
    }
}
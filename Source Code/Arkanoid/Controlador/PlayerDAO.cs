using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Arkanoid.Modelo;

namespace Arkanoid.Controlador
{
    public static class PlayerDAO
    {
        
        //Método que permite el acceso a la base de datos para identificar jugadores existentes
        public static List<Player> GetPlayers()
        {
            DataTable dt = null;
            List<Player> listPlayer = new List<Player>();
            
            try
            {
                dt= ConnectionDB.ExecuteQuery("SELECT * FROM PLAYER");
            }
            catch (GetDataException Ex)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
            
            foreach (DataRow row in dt.Rows)
            {
                Player p = new Player();
                p.nickname = row[0].ToString();
                listPlayer.Add(p);
            }
            return listPlayer;
        }

        //Método que agrega un jugador a la base de datos
        public static void InsertPlayer(string player)
        {
            try
            {
                string query = $"INSERT INTO PLAYER(nickname) VALUES ('{player}')";
                ConnectionDB.ExecuteNonQuery(query);
            }
            catch (PlayerRegistrationException Ex)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
        }
    }
}
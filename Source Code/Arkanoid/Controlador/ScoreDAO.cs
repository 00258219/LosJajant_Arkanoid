﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Arkanoid.Modelo;

namespace Arkanoid.Controlador
{
    public static class ScoreDAO
    {

        //Método encargada de guardar en una lista el nickname de los mejores 10 puntajes
        //ordenados de mayor a menor
        public static List<string> getNickName()
        {
            List<string> listScore = new List<string>();
            DataTable dt = null;

            try
            {
                dt = ConnectionDB.ExecuteQuery("SELECT nickname FROM SCORE ORDER BY score DESC, score LIMIT 10");
            }
            catch (GetFirstTenNickNameException Ex)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }

            foreach (DataRow row in dt.Rows)
            {
                listScore.Add(row[0].ToString());
            }
            return listScore;
        }
        
        //Método encargada de guardar en una lista el score de los mejores 10 puntajes
        //ordenados de mayor a menor
        public static List<string> getScore()
        {
            List<string> listScore = new List<string>();
            DataTable dt = null;
            try
            {
                dt = ConnectionDB.ExecuteQuery("SELECT score FROM SCORE ORDER BY score DESC, score LIMIT 10");
            }
            catch (GetFirstTenScoreException Ex)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }

            foreach (DataRow row in dt.Rows)
            {
                listScore.Add(row[0].ToString());
            }

            return listScore;
        }
        
        //Método que devuelve el jugador con mayor puntaje actualmente
        public static List<Score> getFirstScore()
        {
            List<Score> listScore = new List<Score>();
            DataTable dt = null;

            try
            {
                dt = ConnectionDB.ExecuteQuery("SELECT * FROM SCORE ORDER BY score DESC, score LIMIT 1");
            }
            catch (GetFirsScoreException e)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }

            foreach (DataRow row in dt.Rows)
            {
                Score s = new Score();
                s.idScore = Convert.ToInt32(row[0].ToString());
                s.score = Convert.ToInt32(row[1].ToString());
                s.nickname = row[3].ToString();
                listScore.Add(s);
            }
            return listScore;
        }
        
        //Método que permite el acceso a la base de datos para identificar los puntajes
        //de los jugadores existentes
        public static List<Score> getPlayerScore()
        {
            List<Score> listScore = new List<Score>();
            DataTable dt = null;

            try
            {
                dt = ConnectionDB.ExecuteQuery("SELECT * FROM SCORE");
            }
            catch (GetPlayerScoreException e)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }

            foreach (DataRow row in dt.Rows)
            {
                Score s = new Score();
                s.idScore = Convert.ToInt32(row[0].ToString());
                s.score = Convert.ToInt32(row[1].ToString());
                s.nickname = row[3].ToString();
                listScore.Add(s);
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
                MessageBox.Show("Score añadido!");
            }
            catch (AddScoreException e)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
        }
        
        
    }
}
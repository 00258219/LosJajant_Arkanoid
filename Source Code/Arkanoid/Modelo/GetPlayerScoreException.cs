using System;

namespace Arkanoid.Modelo
{
    public class GetPlayerScoreException : Exception
    {
        public GetPlayerScoreException(string Ex) : base(Ex)
        {
        }
    }
}
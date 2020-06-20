using System;

namespace Arkanoid.Controlador
{
    public class GetPlayerScoreException : Exception
    {
        public GetPlayerScoreException(string Ex) : base(Ex)
        {
        }
    }
}
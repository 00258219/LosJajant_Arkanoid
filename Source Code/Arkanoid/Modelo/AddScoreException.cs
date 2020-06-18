using System;

namespace Arkanoid.Modelo
{
    public class AddScoreException : Exception
    {
        public AddScoreException(string Ex) : base(Ex)
        {
        }
    }
}
using System;

namespace Arkanoid.Controlador
{
    public class AddScoreException : Exception
    {
        public AddScoreException(string Ex) : base(Ex)
        {
        }
    }
}